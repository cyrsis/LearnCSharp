using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class ThreePartNumericFormatString
    {
        [TestMethod]
        public void Example()
        {
            const double aPositiveNumber = 99.99;
            const double aNegativeNumber = -23.55;           
            const double aZeroNumber = 0;
            

            const string threePartFormat = "(+)#.##;(-)#.##;(sorry nothing at all)";


            var positiveOutput = aPositiveNumber.ToString(threePartFormat);
            var negativeOutput = aNegativeNumber.ToString(threePartFormat);            
            var zeroOutput = aZeroNumber.ToString(threePartFormat);


            Debug.IndentLevel = 10;
            Debug.WriteLine(positiveOutput);
            Debug.WriteLine(negativeOutput);            
            Debug.WriteLine(zeroOutput);
        }
    }
}
