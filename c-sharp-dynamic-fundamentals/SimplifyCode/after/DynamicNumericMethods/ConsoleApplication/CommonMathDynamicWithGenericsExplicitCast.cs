using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    static class CommonMathDynamicWithGenericsExplicitCast
    {
        public static T Add<T>(T a, T b)
        {
            dynamic result = (dynamic)a + b;
            return (T)result;
        }

        // To increase performance if required for specific types
        public static double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }
    }
}
