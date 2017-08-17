using System;
using System.Threading;

namespace DemoCode
{
    public class Calculator
    {        
        public int AddInts(int a, int b)
        {
            // Thread.Sleep(200);
            return a + b;
        }

        public double AddDoubles(double a, double b)
        {
            return a + b;
        }

        public int Divide(int number, int by)
        {
            if (number > 100)
            {
                throw new ArgumentOutOfRangeException("by");
            }

            return number / by;
        }
    }
}
