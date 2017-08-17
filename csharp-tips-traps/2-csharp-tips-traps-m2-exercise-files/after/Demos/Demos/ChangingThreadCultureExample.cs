using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class ChangingThreadCultureExample
    {
        [TestMethod]
        public void Example()
        {
            // Culture names format: languagecode-countryregioncode
            const string australiaCultureString = "en-AU";
            const string turkeyCultureString = "tr-TR";            
            // Complete list of cultures: http://bit.ly/pscultures
            
            const double someNumber = 23.45;


            


            Debug.WriteLine("Setting English language - Australia country/region" );  

            var australiaCultureInfo = CultureInfo.GetCultureInfo(australiaCultureString);
            Thread.CurrentThread.CurrentCulture = australiaCultureInfo;

            var ausUppercaseI = "i".ToUpper();
       
            Debug.WriteLine(ausUppercaseI);
            Debug.WriteLine(someNumber);
            Debug.WriteLine(DateTime.Now);




            Debug.WriteLine("Setting Turkish language - Turkey country/region");

            var turkeyCultureInfo = CultureInfo.GetCultureInfo(turkeyCultureString);
            Thread.CurrentThread.CurrentCulture = turkeyCultureInfo;

            var turUppercaseI = "i".ToUpper();            

            Debug.WriteLine(turUppercaseI);
            Debug.WriteLine(someNumber);
            Debug.WriteLine(DateTime.Now);
        }
    }
}
