using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media.Imaging;

namespace Mod05_NETNative
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

        public int Width { get { return _width; } }
        public int Height { get { return _height; } }

        public void Calculate()
        {
            float xStep = (MAX_X - MIN_X) / _width;
            float yStep = (MAX_Y - MIN_Y) / _height;

            for (int x = 0; x < _height; ++x)
            {
                for (int y = 0; y < _width; ++y)
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
                    _fractal[x * _width + y] = iters;
                }
            }
        }

        public void Draw(WriteableBitmap bitmap)
        {
            for (int x = 0; x < _height; ++x)
            {
                for (int y = 0; y < _width; ++y)
                {
                    int iters = _fractal[x * _width + y];
                    bitmap.SetPixel(x, y, iters >= ITERATIONS ? Colors.Red : Colors.Blue);
                }
            }
        }

        public void Draw(TextWriter writer)
        {
            writer.WriteLine("Drawing Mandelbrot fractal");
            for (int x = 0; x < _height; ++x)
            {
                for (int y = 0; y < _width; ++y)
                {
                    int iterations = _fractal[x * _width + y];
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
