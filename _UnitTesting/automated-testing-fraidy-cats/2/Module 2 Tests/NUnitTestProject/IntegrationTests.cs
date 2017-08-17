using System;
using NUnit.Framework;
using SalesModel.DomainClasses;

namespace NUnitTestProject
{
  [TestFixture]
  public class NUnitDomainClassTests
  {
    [Test]
    public void LastUpdatedSelectedCorrectlyWhenContactDetailIsNull()
    {
      var customer = new Customer
                       {
                         ModifiedDate = new DateTime(2001, 1, 1)
                       };
      Assert.AreEqual(new DateTime(2001, 1, 1), customer.LastUpdated);
    }
  }
}
