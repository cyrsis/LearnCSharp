using System;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using SalesModel.DataLayer;
using SalesModel.DomainClasses;

namespace TestDomainClasses
{
  [TestClass]
  public class IntegrationTestsExternalApis
  {
    public IntegrationTestsExternalApis()
    {
      Database.SetInitializer<SalesModelContext>(null);
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
