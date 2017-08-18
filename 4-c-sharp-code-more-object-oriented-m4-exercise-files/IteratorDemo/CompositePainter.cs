using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorDemo
{
    class CompositePainter<TPainter>: IPainter
        where TPainter : IPainter
    {
        public bool IsAvailable => this.Painters.Any(painter => painter.IsAvailable);

        private IEnumerable<TPainter> Painters { get; }

        private Func<double, IEnumerable<TPainter>, IPainter> Reduce { get; }

        public CompositePainter(IEnumerable<TPainter> painters,
                                Func<double, IEnumerable<TPainter>, IPainter> reduce)
        {
            this.Painters = painters.ToList();
            this.Reduce = reduce;
        }

        public TimeSpan EstimateTimeToPaint(double sqMeters) =>
            this.Reduce(sqMeters, this.Painters).EstimateTimeToPaint(sqMeters);

        public double EstimateCompensation(double sqMeters) =>
            this.Reduce(sqMeters, this.Painters).EstimateCompensation(sqMeters);
    }
}
