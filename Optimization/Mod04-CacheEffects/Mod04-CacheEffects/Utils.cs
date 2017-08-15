using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04_CacheEffects
{
    class Utils
    {
        public static void Measure(string what, Action action)
        {
            Stopwatch sw = Stopwatch.StartNew();
            action();
            Console.WriteLine("{0}\t{1}ms", what, sw.ElapsedMilliseconds);
        }
    }
}
