using System;
using System.Data.Entity;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using SalesModel.DataLayer;
using SalesModel.DomainClasses;
using SalesModel.DomainClasses.Enums;

namespace TestDomainClasses
{
  [TestClass]
  public class IntegrationTestsExternalApis
  {
    public IntegrationTestsExternalApis()
    {
      Database.SetInitializer(new DropCreateDatabaseAlways<SalesModelContext>());
    }
    //I want to be able to cancel an order
    //but keep a record of when and why it was cancelled.
    //Order and line items should be deleted
    //An order cannot be cancelled if it has shipped.
    //NOTE: in the course, I did not continue trying to get
    //this test working. Instead I shifted to doing it in 
    //TDD.
    [TestMethod]
    public void CancellingAnOrderRemovesOrderAndCreatesACancelledOrderRecord()
    {
      var order = new Order
      {
        OrderId = 1,
        CustomerId = 1,
        OrderDate = new DateTime(2013, 1, 1),
        OrderSource = OrderSource.Email,
        ModifiedDate = DateTime.Now
      };
      using (var repo = new SimpleOrderRepository())
      {
        repo.CancelOrder(order, "Found the item at a local store");
        Assert.IsFalse(repo.CachedOrders().Any());
        Assert.IsTrue(repo.CachedCancelledOrders().Any());
      }
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
   
  }
}
