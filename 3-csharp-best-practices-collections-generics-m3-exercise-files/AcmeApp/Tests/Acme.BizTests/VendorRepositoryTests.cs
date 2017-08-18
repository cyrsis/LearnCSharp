using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetrieveValueTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = 42;

            //Act
            var actual = repository.RetrieveValue<int>("Select ...", 42);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveValueStringTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = "test";

            //Act
            var actual = repository.RetrieveValue<string>("Select ...", "test");

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetrieveValueObjectTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var vendor = new Vendor();
            var expected = vendor;

            //Act
            var actual = repository.RetrieveValue<Vendor>("Select ...", vendor);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
}