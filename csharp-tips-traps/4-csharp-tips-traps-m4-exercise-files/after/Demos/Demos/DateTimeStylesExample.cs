using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class DateTimeStylesExample
    {

        [TestMethod]
        public void UsefulDateTimeStyles()
        {
            DateTime d1 = DateTime.Parse("01/12/2000",
                                                              null,
                                                              DateTimeStyles.AssumeUniversal );


            DateTime d2 = DateTime.Parse("01/12/2000",
                                                              null,
                                                              DateTimeStyles.AssumeLocal );


            DateTime d3 = DateTime.Parse("13:30:00",
                                                              null,
                                                              DateTimeStyles.NoCurrentDateDefault );


            DateTime d4 = DateTime.Parse("13:30:00",
                                                              null,
                                                              DateTimeStyles.None);
        }
        
    }
}
