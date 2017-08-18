using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class ConvertingCharsToNumbers
    {
        [TestMethod]
        public void Example()
        {
            var fiveChar = '5';

            double fiveDouble = char.GetNumericValue(fiveChar);

            var twoThirdsChar = '⅔';

            double twoThirdsDouble = Char.GetNumericValue(twoThirdsChar);

            double a = char.GetNumericValue('a');
        }
    }  
}