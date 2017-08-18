using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CS61.Tests
{
    [TestClass]
    public class Money_Tests
    {
        [TestMethod]
        public void Cannot_Create_Money_With_Currency_And_Amount()
        {
            var m1 = new Money(1.0m, "eur");
            Assert.AreEqual(1.0m, m1.Amount);
            Assert.AreEqual("eur", m1.Currency);
        }

        [TestMethod]
        public void Cannot_Create_Money_With_Null_Currency()
        {
            var paramName = "";
            try
            {
                var m1 = new Money(1.0m, null);
            }
            catch (ArgumentNullException ex)
            {
                paramName = ex.ParamName;
            }
            Assert.AreEqual("currency", paramName);   
        }
    }
}
