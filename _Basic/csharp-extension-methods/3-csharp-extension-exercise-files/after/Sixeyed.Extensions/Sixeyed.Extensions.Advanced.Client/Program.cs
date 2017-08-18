using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sixeyed.Extensions.Advanced.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo ?");
            var demo = Console.ReadLine();
            Console.WriteLine("Demo {0}".FormatWith(demo));
            Console.ReadLine();
        }
    }
}
