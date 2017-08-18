using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Samples.Demo3;
using Sixeyed.Extensions.Samples.Demo3.Impl;
using System.Collections;
using System.Collections.Generic;

namespace Sixeyed.Extensions.Tests.Demo4
{
    [TestClass]
    public class IReferenceDataSourceCollectionExtensionsTests
    {
        [TestMethod]
        public void GetAllItemsByCode_Array()
        {
            var sources = new IReferenceDataSource[] { new SqlReferenceDataSource(),
                new XmlReferenceDataSource(), new ApiReferenceDataSource()};
            var items = sources.GetAllItemsByCode("xyz");
            Assert.AreEqual(6, items.Count());
        }

        [TestMethod]
        public void GetAllItemsByCode_ArrayList()
        {
            var sources = new ArrayList() { new SqlReferenceDataSource(),
                new XmlReferenceDataSource(), new ApiReferenceDataSource()};
            sources.Add("i am not a reference data source");
            var items = sources.GetAllItemsByCode("xyz");
            Assert.AreEqual(6, items.Count());
        }

        [TestMethod]
        public void GetAllItemsByCode_IEnumerable()
        {
            var sources = new HashSet<IReferenceDataSource> { new SqlReferenceDataSource(),
                new XmlReferenceDataSource(), new ApiReferenceDataSource()};
            var items = sources.GetAllItemsByCode("xyz");
            Assert.AreEqual(6, items.Count());
        }
    }
}
