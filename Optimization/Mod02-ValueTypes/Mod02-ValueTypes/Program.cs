using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod02_ValueTypes
{
    class Program
    {
        static int[] GetGCPerGenCounts()
        {
            int[] counts = new int[3];
            for (int i = 0; i < 3; ++i)
            {
                counts[i] = GC.CollectionCount(i);
            }
            return counts;
        }

        static void TimeAndMeasureGC(string what, Action action)
        {
            int[] gcCountsBefore = GetGCPerGenCounts();
            Stopwatch sw = Stopwatch.StartNew();
            action();
            int[] gcCountsAfter = GetGCPerGenCounts();
            Console.Write("{0}\tTime = {1}ms\t", what, sw.ElapsedMilliseconds);
            for (int i = 0; i < gcCountsAfter.Length; ++i)
            {
                Console.Write("Gen{0} GCs = {1}\t", i, gcCountsAfter[i] - gcCountsBefore[i]);
            }
            Console.Write("Mem = {0:0.00}MB", GC.GetTotalMemory(true) / 1024576.0);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // For visualization only
            MandelbrotC mandelbrot = new MandelbrotC(50, 50);
            mandelbrot.Calculate();
            mandelbrot.Draw(Console.Out);

            Console.WriteLine("Press ENTER to start the measurements");
            Console.ReadLine();

            // Now start the actual measurements
            const int WIDTH = 1000;
            const int HEIGHT = 1000;

            MandelbrotC mandelbrotC = new MandelbrotC(WIDTH, HEIGHT);
            TimeAndMeasureGC("MandelbrotC", () =>
            {
                mandelbrotC.Calculate();
                mandelbrotC.Draw(TextWriter.Null);
            });
            mandelbrotC = null;
            GC.Collect();

            MandelbrotS mandelbrotS = new MandelbrotS(WIDTH, HEIGHT);
            TimeAndMeasureGC("MandelbrotS", () =>
            {
                mandelbrotS.Calculate();
                mandelbrotS.Draw(TextWriter.Null);
            });
            GC.KeepAlive(mandelbrotS);
        }
    }
}
