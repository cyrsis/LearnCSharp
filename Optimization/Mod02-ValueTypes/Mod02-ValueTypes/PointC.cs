using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod02_ValueTypes
{
    class PointC : IEquatable<PointC>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointC(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            PointC other = obj as PointC;
            if (other == null)
            {
                return false;
            }
            return Equals(other);
        }

        public bool Equals(PointC other)
        {
            return other.X == X && other.Y == Y;
        }

        public static bool operator==(PointC a, PointC b)
        {
            return a.Equals(b);
        }

        public static bool operator!=(PointC a, PointC b)
        {
            return !a.Equals(b);
        }

        public override int GetHashCode()
        {
            int hash = 19;
            hash = hash * 29 + X;
            hash = hash * 29 + Y;
            return hash;
        }
    }
}
