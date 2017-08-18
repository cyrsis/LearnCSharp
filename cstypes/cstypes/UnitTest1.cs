using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

using InvoiceLibrary;

namespace cstypes
{

   
  
    [TestClass]
    public class ReferenceTypesAndValueTypes
    {
        [TestMethod]
        public void IdentityTest()
        {
            Invoice firstInvoice = new Invoice();
            firstInvoice.ID = 1;
            firstInvoice.Description = "Test";
            firstInvoice.Amount = 0.0M;

            Invoice secondInvoice = new Invoice();
            secondInvoice.ID = 1;
            secondInvoice.Description = "Test";
            secondInvoice.Amount = 0.0M;

            Assert.IsFalse(object.ReferenceEquals(secondInvoice, firstInvoice));
            Assert.IsTrue(firstInvoice.ID == 1);

            secondInvoice.ID = 2;

            Assert.IsTrue(secondInvoice.ID == 2);
            Assert.IsTrue(firstInvoice.ID == 1);


            secondInvoice = firstInvoice;

            Assert.IsTrue(object.ReferenceEquals(secondInvoice, firstInvoice));

            secondInvoice.ID = 5;
            Assert.IsTrue(firstInvoice.ID == 5);

        }

        [TestMethod]
        public void ValueTypeTest()
        {

            int x = 5;
            int y = x;

            y = 10;

            Assert.IsTrue(x == 5);
            Assert.IsTrue(y == 10);
        }

        [TestMethod]
        public void PassByValue()
        {
            Invoice invoice = new Invoice();
            invoice.ID = 1;
            int value = 1;

            DoWork(ref invoice, ref value);

            Assert.IsTrue(invoice.ID == 5);
            Assert.IsTrue(value == 3);
        }
        
        void DoWork(ref Invoice invoice, ref int value)
        {
            invoice = new Invoice();
            invoice.ID = 5;

            value = 3;

        }

        [TestMethod]
        public void StringTests()
        {
            string name = " Scott ";

            name = name.Trim();

            Assert.IsTrue(name.Equals("Scott", StringComparison.CurrentCulture));
        }

        [TestMethod]
        public void ArrayTests()
        {
            string[] names = { "Scott", "Aaron", "Fritz", "Matt" };            

            ChangeName(names);

            int index = Array.IndexOf(names, "Foo");

            Assert.IsTrue(index == -1);
            Assert.IsTrue(names[0] == "Allen");
        }

        private void ChangeName(IList names)
        {
            names[0] = "Allen";
        }
    }
}
