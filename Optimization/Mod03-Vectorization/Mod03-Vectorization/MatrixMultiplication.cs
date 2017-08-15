using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Mod03_Vectorization
{
    class MatrixMultiplication
    {
        /// <summary>
        /// Multiply a matrix A of size MxR by a matrix B of size RxN to obtain
        /// a matrix C of size MxN.
        /// </summary>
        public static void MultiplyScalar(
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

        /// <summary>
        /// Multiply a matrix A of size MxR by a matrix B of size RxN to obtain
        /// a matrix C of size MxN.
        /// </summary>
        public static void MultiplyVector(
            int[] A, int M, int R,
            int[] B, int N,
            int[] C)
        {
            int vecSize = Vector<int>.Length;
            Trace.Assert(N % vecSize == 0, "N must be divisible by the vector length on your hardware");

            for (int i = 0; i < M; ++i)
            {
                for (int k = 0; k < R; ++k)
                {
                    for (int j = 0; j < N; j += vecSize)
                    {
                        Vector<int> vC = new Vector<int>(C, i * M + j);
                        Vector<int> vB = new Vector<int>(B, k * R + j);
                        Vector<int> vA = new Vector<int>(A[i * M + k]);
                        vC += vA * vB;
                        vC.CopyTo(C, i * M + j);
                    }
                }
            }
        }
    }
}
