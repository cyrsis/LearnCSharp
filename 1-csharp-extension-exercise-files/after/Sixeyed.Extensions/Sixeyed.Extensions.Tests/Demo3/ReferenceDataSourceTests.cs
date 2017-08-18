using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Samples.Demo3;
using Sixeyed.Extensions.Samples.Demo3.Impl;

namespace Sixeyed.Extensions.Tests.Demo3
{
    [TestClass]
    public class ReferenceDataSourceTests
    {
        [TestMethod]
        public void GetItems()
        {
            IReferenceDataSource source;
            source = new SqlReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
            source = new XmlReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
            source = new ApiReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
        }

        [TestMethod]
        public void GetItemsByCode_Sql()
        {
            IReferenceDataSource source;
            source = new SqlReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());
        }

        [TestMethod]
        public void GetItemsByCode_Xml()
        {
            var source = new XmlReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());
        }
    }
}