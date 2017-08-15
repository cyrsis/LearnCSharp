using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04_CacheEffects
{
    class MatrixMultiplication
    {
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

        public static void Measure()
        {
            int[] A = GetRandomMatrix(M, R);
            int[] B = GetRandomMatrix(R, N);
            int[] C1 = new int[M * N];
            int[] C2 = new int[M * N];

            Utils.Measure("MultiplyTextbook", () => MultiplyTextbook(A, M, R, B, N, C1));
            Utils.Measure("MultiplyOptimized", () => MultiplyOptimized(A, M, R, B, N, C2));

            // Verify that we get the same results
            for (int i = 0; i < C1.Length; ++i)
            {
                if (C1[i] != C2[i])
                    Console.WriteLine("ERROR!");
            }
        }

        private static void MultiplyTextbook(
            int[] A, int M, int R,
            int[] B, int N,
            int[] C)
        {
            for (int i = 0; i < M; ++i)
            {
                for (int j = 0; j < N; ++j)
                {
                    for (int k = 0; k < R; ++k)
                    {
                        C[i * M + j] += A[i * M + k] * B[k * R + j];
                    }
                }
            }
        }

        private static void MultiplyOptimized(
            int[] A, int M, int R,
            int[] B, int N,
            int[] C)
        {
            for (int i = 0; i < M; ++i)
            {
                for (int k = 0; k < R; ++k)
                {
                    for (int j = 0; j < N; ++j)
                    {
                        C[i * M + j] += A[i * M + k] * B[k * R + j];
                    }
                }
            }
        }
    }
}
