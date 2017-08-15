using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Mod03_Vectorization
{
    class Program
    {
        #region Support

        static Program()
        {
            // Dummy reference to work around issue in CTP
            int vecSize = Vector<int>.Length;
        }

        static void Measure(string what, Action action)
        {
            Stopwatch sw = Stopwatch.StartNew();
            action();
            Console.WriteLine("{0}\t{1}ms", what, sw.ElapsedMilliseconds);
        }

        #endregion

        #region Matrix Multiplication

        const int M = 1024;
        const int R = 1024;
        const int N = 1024;

        static Random _rand = new Random();

        static int[] GetRandomMatrix(int rows, int cols)
        {
            int[] matrix = new int[rows * cols];
            for (int i = 0; i < matrix.Length; ++i)
            {
                matrix[i] = _rand.Next();
            }
            return matrix;
        }

        private static void MatrixMult()
        {
            int[] A = GetRandomMatrix(M, R);
            int[] B = GetRandomMatrix(R, N);
            int[] C1 = new int[M * N];
            int[] C2 = new int[M * N];

            Measure("MultiplyScalar", () => MatrixMultiplication.MultiplyScalar(A, M, R, B, N, C1));
            Measure("MultiplyVector", () => MatrixMultiplication.MultiplyVector(A, M, R, B, N, C2));

            // Verify that we get the same results
            for (int i = 0; i < C1.Length; ++i)
            {
                if (C1[i] != C2[i])
                    Console.WriteLine("ERROR!");
            }
        }

        #endregion

        #region Min-Max
        
        private static void MinimumMaximum()
        {
            int[] a = GetRandomMatrix(10000, 10000);
            int minimum, maximum;
            Measure("MinMaxScalar", () => MinMax.MinMaxScalar(a, out minimum, out maximum));
            Measure("MinMaxVector", () => MinMax.MinMaxVector(a, out minimum, out maximum));
        }

        #endregion

        #region Mandelbrot

        const int MANDELBROT_WIDTH = 1024;
        const int MANDELBROT_HEIGHT = 1024;

        private static void Mandel()
        {
            Measure("MandelbrotScalar", () =>
            {
                Mandelbrot mandelbrot = new Mandelbrot(MANDELBROT_WIDTH, MANDELBROT_HEIGHT);
                mandelbrot.CalculateScalar();
            });
            Measure("MandelbrotVector", () =>
            {
                Mandelbrot mandelbrot = new Mandelbrot(MANDELBROT_WIDTH, MANDELBROT_HEIGHT);
                mandelbrot.CalculateVector();
            });
        }

        #endregion

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: <matrix | minmax | mandelbrot>");
                return;
            }

            switch (args[0])
            {
                case "matrix":
                    MatrixMult();
                    return;
                case "minmax":
                    MinimumMaximum();
                    return;
                case "mandelbrot":
                    Mandel();
                    return;
            }
        }
    }
}
