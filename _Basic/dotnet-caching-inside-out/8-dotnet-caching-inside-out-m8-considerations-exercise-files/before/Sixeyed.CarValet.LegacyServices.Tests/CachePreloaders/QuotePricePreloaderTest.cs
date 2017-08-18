using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.CarValet.LegacyServices.CachePreloaders;

namespace Sixeyed.CarValet.LegacyServices.Tests
{
    [TestClass]
    public class QuotePricePreloaderTest
    {
        [TestMethod]
        public void Run()
        {
            QuotePricePreloader.Run();
        }
    }
}
