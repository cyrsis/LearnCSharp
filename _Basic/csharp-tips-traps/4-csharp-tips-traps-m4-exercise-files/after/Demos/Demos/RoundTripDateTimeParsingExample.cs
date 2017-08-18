using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class RoundTripDateTimeParsingExample
    {

        [TestMethod]
        public void DateTimeExampleWithTimeZone()
        {
            var original = new DateTime(2000, 12, 1, 13, 30, 0, DateTimeKind.Local);

            var safeRoundTripString = original.ToString("o");

            var reparsed = DateTime.Parse(safeRoundTripString);

            Debug.WriteLine(original);
            Debug.WriteLine(safeRoundTripString);
            Debug.WriteLine(reparsed);
        }










        [TestMethod]
        public void DateTimeExampleWithoutTimeZone()
        {
            // defaults to DateTimeKind.Unspecified
            var original = new DateTime(2000, 12, 1, 13, 30, 0); 

            var safeRoundTripString = original.ToString("o");

            var reparsed = DateTime.Parse(safeRoundTripString);

            Debug.WriteLine(original);
            Debug.WriteLine(safeRoundTripString);
            Debug.WriteLine(reparsed);
        }








        [TestMethod]
        public void DateTimeExampleEnforcingRoundTripFormat()
        {           
            string almostIso8601 = "2000/12/01T13:30:00.0000000+08:00";
         
            var reparsed = DateTime.Parse(almostIso8601);

            reparsed = DateTime.ParseExact(almostIso8601, "o", null);            
        }









        [TestMethod]
        public void DateTimeOffsetExample()
        {
            var original = new DateTimeOffset(2000, 12, 1, 13, 30, 0,
                                                                  TimeSpan.FromHours(-8) );

            var safeRoundTripString = original.ToString("o");

            var reparsed = DateTimeOffset.Parse(safeRoundTripString);

            Debug.WriteLine(original);
            Debug.WriteLine(safeRoundTripString);
            Debug.WriteLine(reparsed);
        }



    }
}
