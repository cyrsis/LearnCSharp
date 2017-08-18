using System.Collections.Generic;

namespace StrategiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<ProportionalPainter> painters = new ProportionalPainter[10];
            IPainter painter = CompositePainterFactories.CombineProportional(painters);
        }
    }
}
