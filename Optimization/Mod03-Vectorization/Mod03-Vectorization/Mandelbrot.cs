using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Mod03_Vectorization
{
    class Mandelbrot
    {
        private const float MIN_X = -2;
        private const float MAX_X = 1;
        private const float MIN_Y = -1;
        private const float MAX_Y = 1;

        private const int ITERATIONS = 1000;
        private static readonly float THRESHOLD = (float)Math.Sqrt(2);

        private int _width;
        private int _height;

        private int[] _fractal;

        public Mandelbrot(int width, int height)
        {
            _width = width;
            _height = height;
            _fractal = new int[_width * _height];
        }

        public void CalculateScalar()
        {
            float xStep = (MAX_X - MIN_X) / _width;
            float yStep = (MAX_Y - MIN_Y) / _height;

            for (int x = 0; x < _width; ++x)
            {
                for (int y = 0; y < _height; ++y)
                {
                    ComplexF c = new ComplexF(MIN_X + x * xStep, MIN_Y + y * yStep);
                    ComplexF z = c;
                    int iters;
                    for (iters = 0; iters < ITERATIONS; ++iters)
                    {
                        if (z.MagnitudeSquared >= THRESHOLD)
                        {
                            break;
                        }
                        z = z * z + c;
                    }
                    _fractal[y * _width + x] = iters;
                }
            }
        }

        public void CalculateVector()
        {
            float xStep = (MAX_X - MIN_X) / _width;
            float yStep = (MAX_Y - MIN_Y) / _height;

            int vecSize = Vector<int>.Length; // the same as Vector<float.Length!
            for (int x = 0; x < _width; ++x)
            {
                // The real component in all the numbers in the inner loop is 
                // going to be the same.
                Vector<float> vReal = new Vector<float>(MIN_X + x * xStep);
                for (int y = 0; y < _height; y += vecSize)
                {
                    // The imaginary component has multiple separate values
                    // because we're traversing through multiple values of 'y'
                    // in each loop iteration.
                    float[] imags = new float[vecSize];
                    for (int i = 0; i < imags.Length; ++i)
                    {
                        imags[i] = MIN_Y + (y + i) * yStep;
                    }
                    Vector<float> vImag = new Vector<float>(imags);

                    ComplexVF vC = new ComplexVF(vReal, vImag);
                    ComplexVF vZ = vC;

                    Vector<int> vIters = Vector<int>.Zero;
                    Vector<int> vMaxIters = new Vector<int>(ITERATIONS);
                    Vector<int> vIncrement = Vector<int>.One;
                    Vector<float> vThreshold = new Vector<float>(THRESHOLD);
                    do
                    {
                        // This is vector multiplication and addition
                        vZ = vZ * vZ + vC;

                        vIters += vIncrement;

                        // Which vZ's have magnitude less than the threshold?
                        Vector<int> vLessThanThreshold = Vector.LessThanOrEqual(vZ.MagnitudeSquared, vThreshold);
                        // Which vIters have # iterations less than the maximum?
                        Vector<int> vLessThanMaxIters = Vector.LessThanOrEqual(vIters, vMaxIters);
                        // Which elements should proceed to the next iteration?
                        Vector<int> vShouldContinue = vLessThanThreshold & vLessThanMaxIters;
                        
                        // Which vIters elements should be incremented in the next iteration?
                        vIncrement &= vShouldContinue;
                    }
                    while (vIncrement != Vector<int>.Zero);

                    for (int i = 0; i < vecSize; ++i)
                    {
                        _fractal[y * _width + x + i] = vIters[i];
                    }
                }
            }
        }

        public void Draw(TextWriter writer)
        {
            writer.WriteLine("Drawing Mandelbrot fractal");
            for (int row = 0; row < _height; ++row)
            {
                for (int col = 0; col < _width; ++col)
                {
                    int iterations = _fractal[row * _width + col];
                    if (iterations >= ITERATIONS)
                    {
                        writer.Write('*');
                    }
                    else
                    {
                        writer.Write(' ');
                    }
                }
                writer.WriteLine();
            }
            writer.WriteLine("Drawing complete");
        }
    }
}
