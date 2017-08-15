using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04_CacheExploration
{
    class CacheLineSize
    {
        private const int TOTAL_ARRAY_LENGTH = 16 * 1024 * 1024; // doesn't fit in cache
        private const int REPETITIONS = 20;

        private static double AccessMemoryAndMeasure(int stride)
        {
            int[] memory = new int[TOTAL_ARRAY_LENGTH];
            GC.Collect();
            Stopwatch sw = new Stopwatch();
            for (int j = 0; j < REPETITIONS; ++j)
            {
                if (j == 1)
                {
                    // discard first iteration
                    sw.Start();
                }
                for (int i = 0; i < memory.Length; i += stride)
                {
                    memory[i] *= 3;
                }
            }
            return sw.Elapsed.TotalMilliseconds;
        }

        public static void Measure()
        {
            // Warm up
            AccessMemoryAndMeasure(1);

            Console.WriteLine("*** CACHE LINE SIZES DEMONSTRATION ***");
            Console.WriteLine("Stride\tTime (ms)");
            for (int stride = 1; stride <= 256; stride *= 2)
            {
                double result = AccessMemoryAndMeasure(stride);
                Console.WriteLine("{0}\t{1:0.000}", stride, result);
            }
        }
    }
}
