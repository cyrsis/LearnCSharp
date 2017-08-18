using System.Diagnostics;
using Demos.DemoSupportCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class BreakAndContinueExample
    {

        [TestMethod]
        public void BreakFromLoop()
        {
            var i = 10;

            while (true)
            {
                i--;

                if (i == 5)
                {
                    break;
                }
            }

            for (int j = 0; j < 1000; j++)
            {
                i = j;

                if (j == 50)
                {
                    break;
                }
            }
        }








        [TestMethod]
        public void SkipRemainingLoop()
        {     
            for (int i = 0; i < 10; i++)
            {
               if (i < 5)
               {
                   continue;
               }

               Debug.WriteLine(i);                
            }
        }




    }
}
