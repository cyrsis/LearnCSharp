using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04_ILP
{
    class Program
    {
        private static void Measure(string what, Action action, int repetitions)
        {
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < repetitions; ++i)
            {
                action();
            }
            Console.WriteLine("{0}\t{1}ms", what, sw.ElapsedMilliseconds);
        }

        private static void MaxSimple(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; ++i)
            {
                max = Math.Max(max, array[i]);
            }
        }

        private static void MaxILPOptimized(int[] array)
        {
            int max1 = int.MinValue, max2 = int.MinValue;
            for (int i = 0; i < array.Length; i += 2)
            {
                max1 = Math.Max(max1, array[i]);
                max2 = Math.Max(max2, array[i+1]);
            }
            int max = Math.Max(max1, max2);
        }

        private static int[] GetRandomArray(int size)
        {
            Random rand = new Random();
            int[] array = new int[size];
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = rand.Next();
            }
            return array;
        }

        static void Main(string[] args)
        {
            const int REPETITIONS = 1000;
            const int ARRAY_SIZE = 1048576;

            int[] array = GetRandomArray(ARRAY_SIZE);
            Measure("Max Simple", () => MaxSimple(array), REPETITIONS);
            Measure("Max Optimized", () => MaxILPOptimized(array), REPETITIONS);
        }
    }
}
