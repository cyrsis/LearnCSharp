using System.Collections.Generic;
using System.Linq;

namespace Houses
{
    public class PaintingCompany: IPainter
    {

        private IEnumerable<IPainter> painters;

        public PaintingCompany(IEnumerable<IPainter> painters)
        {
            this.painters = new List<IPainter>(painters);
        }

        public double Paint(double houses)
        {
            double totalVelocity = this.GetOverallVelocity();

            double totalDays =
                this.painters
                .Select(painter =>
                    new
                    {
                        Painter = painter,
                        Velocity = 1 / (double)painter.EstimateDays(1)
                    })
                .Select(record =>
                    new
                    {
                        Painter = record.Painter,
                        HousesToPaint = houses * record.Velocity / totalVelocity
                    })
                .Select(record => record.Painter.Paint(record.HousesToPaint))
                .Max();

            return totalDays;

        }

        private double GetOverallVelocity()
        {
            return
                this.painters
                .Select(painter => painter.EstimateDays(1))
                .Select(daysPerHouse => 1 / (double)daysPerHouse)
                .Sum();
        }

        public double EstimateDays(double houses)
        {
            return houses / this.GetOverallVelocity();
        }
    }
}
