using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sixeyed.Extensions.Advanced.Tests.Demo4
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void FormatWith()
        {
            Assert.AreEqual("Demo 4", "Demo {0}".FormatWith(4));
        }
    }
}
