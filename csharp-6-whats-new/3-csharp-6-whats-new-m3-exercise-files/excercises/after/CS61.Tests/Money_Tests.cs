using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

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
                new Money(1.0m, null);
            }
            catch (ArgumentNullException ex)
            {
                paramName = ex.ParamName;
            }
            Assert.AreEqual("currency", paramName);   
        }

        [TestMethod]
        public void Can_Parse_Money()
        {
            var input = "12.1 inr";
            var money = Money.Parse(input);

            Assert.AreEqual(12.1m, money.Amount);
            Assert.AreEqual("inr", money.Currency);
        }

        [TestMethod]        
        public void Amount_Is_0_When_Amount_Misformatted()
        {
            var input = "12x.1 inr";
            var money = Money.Parse(input);

            Assert.AreEqual(0m, money.Amount);
            Assert.AreEqual("inr", money.Currency);

        }

        [TestMethod]
        public void Can_Add_Money()
        {
            var m1 = new Money(10m, "usd");
            var m2 = new Money(12.1m, "usd");
            var m3 = m1 + m2;

            AreEqual(22.1m, m3.Amount);
            AreEqual("usd", m3.Currency);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Throws_If_Adding_Different_Currencies()
        {
            var m1 = new Money(10m, "usd");
            var m2 = new Money(12.1m, "nok");
            var m3 = m1 + m2;
        }
    }
}
