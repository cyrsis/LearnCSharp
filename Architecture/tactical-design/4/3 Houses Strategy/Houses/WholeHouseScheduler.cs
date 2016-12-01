using System;
using System.Collections.Generic;
using System.Linq;

namespace Houses
{
    public class WholeHouseScheduler: IPaintingScheduler
    {
        public IEnumerable<Tuple<IPainter, double>> Organize(
                                    IEnumerable<IPainter> painters, double houses)
        {
            IEnumerable<Tuple<IPainter, double>> schedule =
                this.CreateEmptySchedule(painters);

            while (houses > 0.0)
            {
                double part = Math.Min(1.0, houses);
                schedule = this.Add(schedule, part);
                houses -= part;
            }
            return schedule;
        }

        private IEnumerable<Tuple<IPainter, double>> Add(
                    IEnumerable<Tuple<IPainter, double>> schedule, double part)
        {

            Tuple<IPainter, double> optimalPainter =
                schedule
                .Select(pair => Tuple.Create(pair.Item1, pair.Item2 + part))
                .OrderBy(pair => pair.Item1.EstimateDays(pair.Item2))
                .First();

            IEnumerable<Tuple<IPainter, double>> newSchedule =
                schedule
                .Where(pair =>
                    !object.ReferenceEquals(pair.Item1, optimalPainter.Item1))
                .Union(new Tuple<IPainter, double>[] { optimalPainter })
                .ToList();

            return newSchedule;

        }

        private IEnumerable<Tuple<IPainter, double>> CreateEmptySchedule(
                                                IEnumerable<IPainter> painters)
        {
            return
                painters
                .Select(painter => Tuple.Create(painter, 0.0))
                .ToList();
        }
    }
}
