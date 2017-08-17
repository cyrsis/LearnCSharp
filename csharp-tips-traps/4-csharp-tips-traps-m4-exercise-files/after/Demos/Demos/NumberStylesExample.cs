using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class NumberStylesExample
    {

        [TestMethod]
        public void Overview()
        {
            int iMinus24 = int.Parse("(24)", NumberStyles.AllowParentheses);

            double dMinus24 = Double.Parse("(24)", NumberStyles.AllowParentheses);

            decimal decMinus24 = Decimal.Parse("(24)", NumberStyles.AllowParentheses);

            float f = float.Parse("-24000", NumberStyles.None);
        }









        [TestMethod]
        public void CustomComposites()
        {
            double d1 = Double.Parse("(24,000)", 
                NumberStyles.AllowParentheses | 
                NumberStyles.AllowThousands);

            double d2 = Double.Parse("$24-",
                NumberStyles.AllowCurrencySymbol | 
                NumberStyles.AllowThousands |
                NumberStyles.AllowTrailingSign);

            double d3 = Double.Parse("$24-",                
                NumberStyles.AllowThousands |
                NumberStyles.AllowTrailingSign);
        }














        [TestMethod]
        public void PremadeComposites()
        {
            double d1 = Double.Parse("$(24,000)", NumberStyles.Currency);

            int i1 = int.Parse("FF", NumberStyles.HexNumber);

            float f1 = float.Parse("99E-22", NumberStyles.Float);
        }









        [TestMethod]
        public void CustomCurrency()
        {
            var strangeCurrency = "k$123.45";

            var nfi = new NumberFormatInfo
                          {
                              CurrencySymbol = "J$"
                          };


            double d = Double.Parse(strangeCurrency,
                                     NumberStyles.Currency,
                                     nfi );
        }


    }
}
