using System;
using System.Collections.Generic;
using System.Linq;

namespace Houses
{
    public class ProportionalScheduler: IPaintingScheduler
    {
        public IEnumerable<Tuple<IPainter, double>> Organize(
                                    IEnumerable<IPainter> painters, double houses)
        {

            double totalVelocity = GetOverallVelocity(painters);

            IEnumerable<Tuple<IPainter, double>> result =
                painters
                .Select(painter =>
                    new
                    {
                        Painter = painter,
                        Velocity = 1 / (double)painter.EstimateDays(1)
                    })
                .Select(record =>
                    Tuple.Create(
                        record.Painter,
                        houses * record.Velocity / totalVelocity))
                .ToList();

            return result;

        }

        private double GetOverallVelocity(IEnumerable<IPainter> painters)
        {
            return
                painters
                .Select(painter => painter.EstimateDays(1))
                .Select(daysPerHouse => 1 / (double)daysPerHouse)
                .Sum();
        }
    }
}
