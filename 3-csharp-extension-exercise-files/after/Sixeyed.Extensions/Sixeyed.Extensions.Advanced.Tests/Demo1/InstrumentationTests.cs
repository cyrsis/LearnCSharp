using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.Extensions.Advanced.Demo1;
using System.Threading;

namespace Sixeyed.Extensions.Advanced.Tests.Demo1
{
    [TestClass]
    public class InstrumentationTests
    {
        [TestMethod]
        public void GetTotalSeconds()
        {
            var instrumentation = new Instrumentation();
            instrumentation.Start();
            Thread.Sleep(750);
            Assert.AreEqual(1, instrumentation.GetElapsedTime());
        }

        [TestMethod]
        public void GetPreciseElapsedTime()
        {
            var instrumentation = new Instrumentation();
            instrumentation.Start();
            Thread.Sleep(750);
            var elapsed = instrumentation.GetPreciseElapsedTime();
            Assert.IsTrue(elapsed >= 0.75 && elapsed < 0.78);
        }

        [TestMethod]
        public void GetReallyPreciseElapsedTime()
        {
            var instrumentation = new Instrumentation();
            instrumentation.StartWithPrecision();
            Thread.Sleep(750);
            Assert.AreEqual(750, instrumentation.GetReallyPreciseElapsedTime());
        }
    }
}
