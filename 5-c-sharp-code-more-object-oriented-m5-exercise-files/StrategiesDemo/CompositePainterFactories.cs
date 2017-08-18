using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategiesDemo
{
    static class CompositePainterFactories
    {
        public static IPainter CombineProportional(IEnumerable<ProportionalPainter> painters) =>
            new CombiningPainter<ProportionalPainter>(painters, new ProportionalPaintingScheduler());

        public static IPainter CreateCheapestSelector(IEnumerable<ProportionalPainter> painters) =>
            new CompositePainter<ProportionalPainter>(painters,
                (sqMeters, sequence) => new Painters(sequence).GetAvailable().GetCheapestOne(sqMeters));

        public static IPainter CreateFastestSelector(IEnumerable<ProportionalPainter> painters) =>
            new CompositePainter<ProportionalPainter>(painters,
                (sqMeters, sequence) => new Painters(sequence).GetAvailable().GetFastestOne(sqMeters));

    }
}
