using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SalesModel.DomainClasses;

namespace TestDomainClasses
{
  [TestClass]
  public class DomainClassTests
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

    //goal: create a new property in customer to concatenate first & last name
    [TestMethod]
    public void CustomerFirstNameLastNameConcatenationReturnsCorrectResult()
    {
      var customer = new Customer {FirstName = "Julie  ", LastName = "Lerman"};
      Assert.AreEqual("Julie Lerman",customer.FullName);

    }

  }

}
