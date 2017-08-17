using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FakesForTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using SalesModel.DataLayer;
using SalesModel.DomainClasses;
using SalesModel.DomainClasses.Enums;
using Telerik.JustMock;

namespace TestDomainClasses
{
  [TestClass]
  public class IntegrationTestsExternalApis
  {
    public IntegrationTestsExternalApis()
    {
      Database.SetInitializer(new DropCreateDatabaseAlways<SalesModelContext>());
    }

    [TestMethod]
    public void AddOrderContainingLineItemWithQuantityZeroNotAllowed()
    {
      var order = new Order();
      order.LineItems.Add(new LineItem());
      var repo = new SimpleOrderRepository();
      repo.AddNewOrder(order);
      Assert.IsFalse(repo.IsValid(order));
    }


#if false
    //REMEMBER: In the course I refactored so we're no longer testing
    //the CancelOrder method but the instead, the individual
    //methods called INSIDE of CancelOrder
    
    //I want to be able to cancel and order
    //but keep a record of when and why it was cancelled
    [TestMethod]
    public void CancellingAnOrderRemovesOrder()
    {
      //arrange
      _fakeOrders = new List<Order> { FakeOrder };
      var context = Mock.Create<ISalesModelContext>();
      Mock.Arrange(() => context.Orders).ReturnsCollection(FakeOrders);
      var order = _fakeOrders[0];
      Mock.Arrange(() => context.Orders.Remove(order))
        .DoInstead((Order o) => _fakeOrders.Remove(o));
      //act
      using (var repo = new SimpleOrderRepository(context))
      {
        repo.CancelOrder(1, "Found the item(s) in a local store");
        Assert.AreEqual(0, repo.Orders().Count(o => o.OrderId == 1));
      }
    }
 

    //[TestMethod]
    //public void CancellingAnOrderAddsANewCancelledOrder()
    //{
    //  //arrange
    //  _fakeOrders = new List<Order> { FakeOrder };
    //  _fakeCancelledOrders = new List<CancelledOrder>();
    //  var context = Mock.Create<ISalesModelContext>();
    //  Mock.Arrange(() => context.Orders).ReturnsCollection(FakeOrders);
    //  Mock.Arrange(() => context.CancelledOrders).ReturnsCollection(FakeCancelledOrders);
    //  Mock.Arrange(() => context.CancelledOrders.Add(Arg.IsAny<CancelledOrder>()))
    //    .DoInstead((CancelledOrder o) => _fakeCancelledOrders.Add(o));
    //  //act
    //  using (var repo = new SimpleOrderRepository(context))
    //  {
    //    repo.CancelOrder(1, "Found the item(s) in a local store");
    //    Assert.AreEqual(1, repo.CancelledOrders().Count(o => o.OriginalOrderId == 1));
    //  }
    //}
#endif

    //NOTE : Commented out code were from 
    //solution in video where I used
    //paid version of JustMock where DbSet can be mocked
    [TestMethod]
    public void CancellingAnOrderRemovesOrder()
    {
      //arrange
      //_fakeOrders = new List<Order> {FakeOrder};
      _fakeOrders = new FakeOrderDbSet {FakeOrder};
      var context = Mock.Create<ISalesModelContext>();
      //Mock.Arrange(() => context.Orders).ReturnsCollection(FakeOrders);
      Mock.Arrange(() => context.Orders).Returns(FakeOrders);
      //var order = _fakeOrders[0];
      var order = _fakeOrders.First();
      //Mock.Arrange(() => context.Orders.Remove(order))
      //  .DoInstead((Order o) => _fakeOrders.Remove(o));
      //act
      using (var repo = new SimpleOrderRepository(context))
      {
        repo.FindAndRemoveOrder(1);
        //assert
        Assert.AreEqual(0, repo.Orders().Count(o => o.OrderId == 1));
      }
    }
    //NOTE : Commented out lines were from 
    //solution in video where I used
    //paid version of JustMock
    [TestMethod]
    public void CanCreateCancelledOrderFromExistingOrder()
    {
     // _fakeCancelledOrders = new List<CancelledOrder>();
      _fakeCancelledOrders=new FakeCancelledOrderDbSet();
      var context = Mock.Create<ISalesModelContext>();
      Mock.Arrange(() => context.CancelledOrders).Returns(FakeCancelledOrders);
      //Mock.Arrange(() => context.CancelledOrders.Add(Arg.IsAny<CancelledOrder>()))
      //  .DoInstead((CancelledOrder o) => _fakeCancelledOrders.Add(o));
       using (var repo = new SimpleOrderRepository(context))
      {
        repo.CreateAndAddCancelledOrderFromOrder("Found the item(s) in a local store",FakeOrder);
        Assert.AreEqual(1, repo.CancelledOrders().Count(o => o.OriginalOrderId == 1));
      }
    }
    //private List<Order> _fakeOrders;
    //protected List<Order> FakeOrders{
    //  get{
    //    return _fakeOrders;
    //  }
    private IDbSet<Order> _fakeOrders;
    protected IDbSet<Order> FakeOrders
    {
      get
      {
        return _fakeOrders;
      }
    }

    protected Order FakeOrder
    {
      get
      {
        return new Order
                 {
                   OrderId = 1,
                   CustomerId = 1,
                   OrderDate = new DateTime(2013, 1, 1),
                   OrderSource = OrderSource.Email,
                   ModifiedDate = DateTime.Now
                 };
      }
    }

    //private List<CancelledOrder> _fakeCancelledOrders;
    //protected List<CancelledOrder> FakeCancelledOrders{
    //  get{
    //    return _fakeCancelledOrders;
    //  }
    //}
    private IDbSet<CancelledOrder> _fakeCancelledOrders;
    protected IDbSet<CancelledOrder> FakeCancelledOrders
    {
      get
      {
        return _fakeCancelledOrders;
      }
    }
    protected CancelledOrder FakeCancelledOrder{
      get{
        return new CancelledOrder{
          Id = 1,
          OriginalOrderId = 1,
          CustomerId = 1,
          Reason = "just because",
          ModifiedDate = DateTime.Now
        };
      }
    }

   
    //I want to be able to cancel and order
    //but keep a record of when and why it was cancelled
    //[TestMethod]
    //public void CancellingCreatesACancelledOrderRecord()
    //{
    //  using (var repo = new SimpleOrderRepository())
    //  {
    //    repo.CancelOrder(1, "Found the item(s) in a local store");
    //    Assert.AreEqual(0, repo.CachedCancelledOrders().Count(o => o.OrderId == 1));
    //  }
    //}
  }
}
