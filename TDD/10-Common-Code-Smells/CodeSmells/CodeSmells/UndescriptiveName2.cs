using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSmells
{
    public class OtherUndescriptiveName
    {
        public double GetTwiceAreaOfTriangle(int width, int height)
        {
            var undescriptive = new UndescriptiveName();
            return undescriptive.GetArea(width, height);
        }
    }
}
