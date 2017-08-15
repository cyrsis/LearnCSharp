using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04_CacheExploration
{
    class Program
    {
        static void Measure(string what, Action action)
        {
            Stopwatch sw = Stopwatch.StartNew();
            action();
            Console.WriteLine("{0}\t{1}ms", what, sw.ElapsedMilliseconds);
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: <cachelines | cachelevels>");
                return;
            }

            switch (args[0])
            {
                case "cachelines":
                    CacheLineSize.Measure();
                    break;
                case "cachelevels":
                    CacheSizes.Measure();
                    break;
            }
        }
    }
}
