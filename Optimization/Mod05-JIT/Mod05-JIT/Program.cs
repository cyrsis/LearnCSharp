using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod05_JIT
{
    class Program
    {
        static void Measure(string what, Action action)
        {
            Stopwatch sw = Stopwatch.StartNew();
            action();
            Console.WriteLine("{0}\t{1}ms", what, sw.ElapsedMilliseconds);
        }

        private const int ROWS = 10000;
        private const int COLS = 10000;

        static void Main(string[] args)
        {
            Measure("ImageBlur1", () =>
            {
                ImageBlur1 blur = new ImageBlur1(new Pixel1[ROWS * COLS], ROWS, COLS);
                blur.Blur();
            });
            //Measure("ImageBlur2", () =>
            //{
            //    ImageBlur2 blur = new ImageBlur2(new Pixel2[ROWS * COLS], ROWS, COLS);
            //    blur.Blur();
            //});
            //Measure("ImageBlur3", () =>
            //{
            //    ImageBlur3 blur = new ImageBlur3(new Pixel3[ROWS * COLS], ROWS, COLS);
            //    blur.Blur();
            //});
            Measure("ImageBlur4", () =>
            {
                ImageBlur4 blur = new ImageBlur4(new Pixel4[ROWS * COLS], ROWS, COLS);
                blur.Blur();
            });
        }
    }
}
