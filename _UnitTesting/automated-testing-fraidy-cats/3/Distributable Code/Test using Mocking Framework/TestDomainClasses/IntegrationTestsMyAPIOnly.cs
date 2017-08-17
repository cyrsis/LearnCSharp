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

    //[TestMethod]
    //public void ContactDetailReturnsTweetDateWhenModifiedDateIsNotSet()
    //{
    //  var cd = new ContactDetail {TwitterAlias = "julielerman"};
    //  var stub = new StubTwitterDataUtilities();
    //  cd.SetTwitterDataUtils(stub);

    //  Assert.AreEqual(cd.ModifiedDate,stub.LatestTweetDateAsUtc(null));
    //}
    //[TestMethod]
    //public void ContactDetailReturnsSetModifiedDateEvenWhenTwitterIsAvailable()
    //{
    //  var cd = new ContactDetail { TwitterAlias = "julielerman",ModifiedDate = new DateTime(2012,12,12)};
    //  var stub = new StubTwitterDataUtilities();
    //  cd.SetTwitterDataUtils(stub);

    //  Assert.AreEqual(cd.ModifiedDate, new DateTime(2012, 12, 12));
    //}

  }
}

