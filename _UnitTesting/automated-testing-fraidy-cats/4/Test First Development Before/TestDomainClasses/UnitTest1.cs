using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository;
using SalesModel.DomainClasses;
using SalesModel.DomainClasses.Enums;

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

    

  }

  namespace SalesModel
  {
    public class StringTooLongException : Exception
    {
      private readonly string _maxLength;

      public StringTooLongException(int maxLength)
      {
        _maxLength = maxLength.ToString();
      }

      public override string Message
      {
        get { return "You've entered too many characters. The limit is " + _maxLength; }
      }

    }
  }
}
