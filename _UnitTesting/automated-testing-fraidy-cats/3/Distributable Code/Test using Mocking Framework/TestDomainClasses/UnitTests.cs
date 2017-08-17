using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataLayerInterfaces;
using FakesForTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using SalesModel.DataLayer;
using SalesModel.DomainClasses;
using ServiceUtilities;
using Telerik.JustMock;

namespace TestDomainClasses
{
  [TestClass]
  public class UnitTests
  {
    [TestMethod]
    public void EnteringMoreThan50CharactersInLastNameIsNotAllowed()
    {
      try
      {
        new Customer {LastName = new string('x', 60)};
        Assert.Fail("Customer.LastName allowed a string longer than 50");
      }
      catch (Exception ex)
      {

        Assert.IsInstanceOfType(ex, typeof (InvalidOperationException));
      }
    }

    [TestMethod]
    [TestCategory("TestWithFake")]
    public void GetOrdersForPastPromotionsExecutesQuery()
    {
      //arrange
      ISalesModelContext context = Mock.Create<ISalesModelContext>(Constructor.Mocked);
      //in video, I was able to do this without any fakes
      //That's because I was using the commercial version of JustMock
      //This example uses the free version which does not have Arrange.ReturnsCollection
      //And the DbSet can't be mocked.
      //so instead, I am forced to use the FAKE DbSet implementation :(
      //and look at context mock above, I *had* to mock the interface
      //There may be a better way, but I couldn't find it and 
      //just using the commercial product makes life a LOT simpler! :)
      //------line of code in course
      //Mock.Arrange(() => context.Orders).ReturnsCollection(FakeOrders);
      //------line of code in course
      
      Mock.Arrange(() => context.Orders).Returns(FakeOrders);


      var repo = new SimpleOrderRepository(context);
      var promo = new SalesPromotion {Id = 1, StartDate = DateTime.Today.AddDays(-1)};
      //act
      var promoOrders = repo.OrdersViaPromotion(promo);
      //assert
      Assert.IsInstanceOfType(promoOrders, typeof(List<Order>));
    }

    [TestMethod]
    [TestCategory("TestWithFake")]
    public void GetOrdersForFuturePromotionsSkipsQueryAndReturnsNull()
    {
      //arrange
      var context = Mock.Create<SalesModelContext>();
      var repo = new SimpleOrderRepository(context);
      var promo = new SalesPromotion {Id = 1, StartDate = DateTime.Today.AddDays(1)};
      //act
      var orders = repo.OrdersViaPromotion(promo);
      //assert

      Assert.IsNull(orders);
    }

    //used in demo, but not in this distributed code.
    //see note in test above for further explanation
    public IDbSet<Order> FakeOrders()
    {
      return new FakeOrderDbSet();
     // return new List<Order>();
    }





   

  }
}


