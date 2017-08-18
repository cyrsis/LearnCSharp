using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class DateTimeMinValueExample
    {
        [TestMethod]
        public void Example()
        {
            var minVal = DateTime.MinValue;
           
            var localMinVal = minVal.ToLocalTime();

            var isMinVal = localMinVal == DateTime.MinValue;
        }
    }
}
