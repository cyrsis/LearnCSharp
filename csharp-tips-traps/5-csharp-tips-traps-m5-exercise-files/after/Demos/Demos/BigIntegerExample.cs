using System.Diagnostics;
using System.Numerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Demos
{
    [TestClass]
    public class BigIntegerExample
    {

        [TestMethod]
        public void Creating()
        {
            BigInteger b = 24;

            b = BigInteger.Parse("999999999999999999999999999999999999999999999");

            var millillion = BigInteger.Pow(10, 3003);

            Debug.WriteLine(millillion);
        }







        [TestMethod]
        public void Using()
        {
            BigInteger b1 = 1000;
            BigInteger b2 = 2000;

            var result = b1*b2+45/2;

            result = result % 5;


            result = BigInteger.Negate(result);

            result = BigInteger.Max(b1, b2);            
        }







        [TestMethod]
        public void LossOfPrecision()
        {
            BigInteger b = 9999999999999999999;

            double d = (double) b;

            b = (BigInteger) d;
        }
    }
}
