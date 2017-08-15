using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod02_ValueTypes
{
    class MandelbrotS
    {
        private const float MIN_X = -2;
        private const float MAX_X = 1;
        private const float MIN_Y = -1;
        private const float MAX_Y = 1;

        private const int ITERATIONS = 1000;
        private const float THRESHOLD = 2;

        private int _width;
        private int _height;

        private Dictionary<PointS, int> _fractal = new Dictionary<PointS, int>();

        public MandelbrotS(int width, int height)
        {
            _width = width;
            _height = height;
        }

        public void Calculate()
        {
            float xStep = (MAX_X - MIN_X) / _width;
            float yStep = (MAX_Y - MIN_Y) / _height;

            for (int x = 0; x < _width; ++x)
            {
                for (int y = 0; y < _height; ++y)
                {
                    ComplexS c = new ComplexS(MIN_X + x * xStep, MIN_Y + y * yStep);
                    ComplexS z = new ComplexS(MIN_X + x * xStep, MIN_Y + y * yStep);
                    int i;
                    for (i = 0; i < ITERATIONS; ++i)
                    {
                        if (z.MagnitudeSquared >= THRESHOLD)
                        {
                            break;
                        }
                        z = z * z + c;
                    }
                    _fractal.Add(new PointS(x, y), i);
                }
            }
        }

        public void Draw(TextWriter writer)
        {
            writer.WriteLine("Drawing Mandelbrot fractal");
            for (int x = 0; x < _width; ++x)
            {
                for (int y = 0; y < _height; ++y)
                {
                    int iterations = _fractal[new PointS(x, y)];
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
