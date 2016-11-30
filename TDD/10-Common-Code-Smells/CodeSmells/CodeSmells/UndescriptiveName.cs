using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells
{
    public class UndescriptiveName
    {
        public int GetArea(int b, int h)
        {
            return b * h;
        }

        public double GetAofT(int b, int h)
        {
            return GetArea(b, h) / 2;
        }
    }
}
