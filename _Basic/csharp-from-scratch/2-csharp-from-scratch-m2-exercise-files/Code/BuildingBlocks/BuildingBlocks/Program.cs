using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            var myString    =   "Hello World";
            Console.WriteLine(myString);
            int myFirstValue = 23;
            double mySecondValue = 45.79;
            double sum = myFirstValue + mySecondValue;
            Console.WriteLine(sum.ToString());
        }
    }
}
