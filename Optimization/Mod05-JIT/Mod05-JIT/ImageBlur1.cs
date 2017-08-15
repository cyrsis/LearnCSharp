using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod05_JIT
{
    struct Pixel1
    {
        public byte Red;
        public byte Green;
        public byte Blue;

        public Pixel1(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }
    }

    class ImageBlur1
    {
        private Pixel1[] _image;
        private Pixel1[] _blurredImage;
        private int _rows;
        private int _cols;

        public ImageBlur1(Pixel1[] image, int rows, int cols)
        {
            Trace.Assert(image.Length == rows * cols, "rows*cols isn't equal to the image size");
            _image = image;
            _rows = rows;
            _cols = cols;
        }

        public void Blur()
        {
            _blurredImage = new Pixel1[_rows * _cols];
            for (int x = 1; x < _rows-1; ++x)
            {
                for (int y = 1; y < _cols-1; ++y)
                {
                    BlurPixel(x, y);
                }
            }
        }

        public Pixel1[] BlurredImage { get { return _blurredImage; } }

        private void BlurPixel(int x, int y)
        {
            ushort red = 0, green = 0, blue = 0;
            for (int currX = x-1; currX < x+1; ++currX)
            {
                for (int currY = y-1; currY < y+1; ++currY)
                {
                    Pixel1 pixel = _image[currX * _cols + currY];
                    red += pixel.Red;
                    green += pixel.Green;
                    blue += pixel.Blue;
                }
            }
            Pixel1 newPixel = new Pixel1();
            newPixel.Red = (byte)(red / 3);
            newPixel.Green = (byte)(green / 3);
            newPixel.Blue = (byte)(blue / 3);
            _image[x * _cols + y] = newPixel;
        }
    }
}
