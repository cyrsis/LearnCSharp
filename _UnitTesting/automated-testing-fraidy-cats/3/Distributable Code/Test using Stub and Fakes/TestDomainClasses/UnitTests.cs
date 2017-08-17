using System;
using System.Collections.Generic;
using DataLayerInterfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using SalesModel.DomainClasses;

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
    public void GetOrdersForPastPromotionsExecutesQuery()
    {
      var promo = new SalesPromotion() {Id=1, StartDate = DateTime.Today.AddDays(-1) };
      
      using (var repo = new SimpleOrderRepository(new FakeSalesModelContext()))
        {
        
          Assert.IsInstanceOfType(repo.OrdersViaPromotion(promo),
            typeof(List<Order>));
        }
      }
    

    [TestMethod]
    public void GetOrdersForFuturePromotionsSkipsQueryAndReturnsNull()
    {
      var promo = new SalesPromotion { StartDate = DateTime.Today.AddDays(+1) };

      using (var repo = new SimpleOrderRepository(new FakeSalesModelContext()))
        {
          Assert.IsNull(repo.OrdersViaPromotion(promo));
        }
      }
    }

  }

  
 

