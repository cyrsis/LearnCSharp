using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesModel.DomainClasses;

namespace TestDomainClasses
{
  [TestClass]
  public class IntegrationTestsMyApiOnly
  {

    
    [TestMethod]
    public void LastUpdatedSelectedCorrectlyWhenContactDetailIsNull()
    {
      var customer = new Customer
                       {
                         ModifiedDate = new DateTime(2001, 1, 1)
                       };
      Assert.AreEqual(new DateTime(2001, 1, 1), customer.LastUpdated);
    }


    [TestMethod]
    public void LastUpdatedSelectedCorrectlyWhenContactDetailIsNotNull()
    {
      var customer = new Customer
      {
        ModifiedDate = new DateTime(2001, 1, 1),
        ContactDetail = new ContactDetail { ModifiedDate = new DateTime(2013, 1, 1) }
      };
      Assert.AreEqual(new DateTime(2013, 1, 1), customer.LastUpdated);
    }


  }
}

