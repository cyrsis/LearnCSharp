using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace Sixeyed.ExtensionLibrary.Tests.Demo1
{
    [TestClass]
    public class ExceptionExtensionsTests
    {
        [TestMethod]
        public void DivideBy1()
        {
            Assert.AreEqual(10, Divide(10, 1));
        }

        [TestMethod]
        public void DivideBy0()
        {
            try
            {
                Divide(10, 0);
                Assert.Fail("Should throw exception");
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
                //Debug.WriteLine(ex);
                //Debug.WriteLine(ex.FullMessage());
                Assert.IsInstanceOfType(ex, typeof(ApplicationException));
            }
        }

        public double Divide(int amount, int by)
        {
            try
            {
                return amount / by;
            }
            catch (Exception ex)
            {
                var invalidOpEx = new InvalidOperationException("Invalid operation", ex);
                var message = string.Format("Divide failed - amount: {0}, by: {1}", amount, by);
                throw new ApplicationException(message, invalidOpEx);
            }
        }
    }
}
