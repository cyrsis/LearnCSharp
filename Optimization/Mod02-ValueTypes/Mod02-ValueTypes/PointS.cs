using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod02_ValueTypes
{
    struct PointS : IEquatable<PointS>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointS(int x, int y) : this()
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is PointS))
            {
                return false;
            }
            PointS other = (PointS)obj;
            return Equals(other);
        }

        public bool Equals(PointS other)
        {
            return other.X == X && other.Y == Y;
        }

        public static bool operator ==(PointS a, PointS b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(PointS a, PointS b)
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
