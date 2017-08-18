using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<ProportionalPainter> painters = new ProportionalPainter[10];

            IPainter painter = CompositePainterFactories.CreateGroup(painters);
        }
    }
}
