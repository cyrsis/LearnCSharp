using System.Collections.Generic;
using System.Linq;

namespace IteratorDemo
{
    class Program
    {

        private static IPainter FindCheapestPainter(double sqMeters, IEnumerable<IPainter> painters)
        {
            return
                painters
                    .Where(painter => painter.IsAvailable)
                    .WithMinimum(painter => painter.EstimateCompensation(sqMeters));
        }

        static void Main(string[] args)
        {
        }
    }
}
