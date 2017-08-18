using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Advanced.Demo5;
using System;

namespace Sixeyed.Extensions.Advanced.Tests.Demo5
{
    [TestClass]
    public class DecimalExtensionsTests
    {
        [TestMethod]
        public void ToString()
        {
            var input = 10.51M;
            Assert.AreEqual("10.5", input.ToString());
        }

        [TestMethod]
        public void ToStringRounded()
        {
            var input = 10.51M;
            Assert.AreEqual("10.5", input.ToStringRounded());
        }
    }
}
