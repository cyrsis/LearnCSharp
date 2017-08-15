using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04_CacheExploration
{
    class CacheSizes
    {
        private const int REPETITIONS = 5;
        private const ulong TOTAL_STEPS = 4L * 1024 * 1024 * 1024; // 4 GB

        private static double AccessMemoryAndMeasure(ulong size)
        {
            byte[] memory = new byte[size];
            GC.Collect();
            Stopwatch sw = new Stopwatch();
            for (int j = 0; j < REPETITIONS; ++j)
            {
                if (j == 1)
                {
                    // discard first iteration
                    sw.Start();
                }
                ulong loops = TOTAL_STEPS / size;
                for (ulong i = 0; i < loops; ++i)
                {
                    for (int k = 0; k < memory.Length; k += 64 /*every cache line*/)
                    {
                        memory[k]++;
                    }
                }
            }
            return sw.Elapsed.TotalMilliseconds;
        }

        public static void Measure()
        {
            // Warm up
            AccessMemoryAndMeasure(1024);

            Console.WriteLine("*** CACHE LEVELS DEMONSTRATION ***");
            Console.WriteLine("Size\tTime (ms)\tThroughput");
            for (ulong size = 1024; size <= 1024*1024*1024; size *= 2)
            {
                double result = AccessMemoryAndMeasure(size);
                Console.WriteLine("{0}\t{1:0.000}\t{2}/s",
                    FormatNumberAsMemorySizeString(size),
                    result,
                    FormatNumberAsMemorySizeString(TOTAL_STEPS / (result / 1000.0)));
            }
        }

        private static string FormatNumberAsMemorySizeString(double number)
        {
            if (number < 1024)
            {
                return number + "b";
            }
            if (number < 1024*1024)
            {
                return String.Format("{0:0.0}kb", number / 1024.0);
            }
            if (number < 1024*1024*1024)
            {
                return String.Format("{0:0.0}mb", number / (1024.0 * 1024.0));
            }
            return String.Format("{0:0.0}gb", number / (1024.0 * 1024.0 * 1024.0));
        }
    }
}
