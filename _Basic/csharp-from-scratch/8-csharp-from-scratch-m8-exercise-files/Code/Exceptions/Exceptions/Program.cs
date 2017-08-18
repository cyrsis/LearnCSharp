using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Tester
    {
        public void Method1()
        {
            Console.WriteLine("Method 1 begins");
            Method2();
            Console.WriteLine("Method 1 ends");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2 begins");
            try
            {
                Method3();
            }
            catch (Exception e)
            {
                Console.WriteLine("Caught exception: {0}", e.Message);
            }

            Console.WriteLine("Method 2 ends");

        }

        public void Method3()
        {
            Console.WriteLine("Method 3 begins");
                var x = 0;
                var y = 12 / x;
            Console.WriteLine("Method 3 ends");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Tester t = new Tester();
            t.Method1();
        }
    }
}
