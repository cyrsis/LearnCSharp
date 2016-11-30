using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells
{
    public class DuplicatedCode
    {
        public int GetAreaOfSquare(int width, int height)
        {
            return GetArea(width, height);
        }

        private static int GetArea(int width, int height)
        {
            return width * height;
        }

        public int GetAreaOfRectangle(int width, int height)
        {
            return GetArea(width, height);
        }

        public double GetAreaOfTriangle(int width, int height)
        {
            return GetArea(width, height) / 2;
        }
    }
}
