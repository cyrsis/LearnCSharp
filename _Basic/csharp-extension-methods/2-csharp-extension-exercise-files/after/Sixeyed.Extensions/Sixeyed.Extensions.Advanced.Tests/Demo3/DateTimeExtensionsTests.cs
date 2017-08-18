using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Advanced.Demo3;
using System;

namespace Sixeyed.Extensions.Advanced.Tests.Demo3
{
    [TestClass]
    public class DateTimeExtensionsTests
    {
        [TestMethod]
        public void ToXmlDateTime()
        {
            string xmlDateTime2 = DateTimeExtensions.ToXmlDateTime(new DateTime(2013, 10, 24));
            Assert.AreEqual("2013-10-24T00:00:00Z", xmlDateTime2); 
            
            string xmlDateTime = new DateTime(2013, 10, 24).ToXmlDateTime();
            Assert.AreEqual("2013-10-24T00:00:00Z", xmlDateTime);
        }
    }
}
