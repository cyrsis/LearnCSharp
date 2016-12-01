using System;
using System.Collections.Generic;
using System.Linq;

namespace Houses
{
    public class LandOwner
    {
        private int totalHouses;
        private IEnumerable<Painter> painters;

        public LandOwner(int totalHouses, IEnumerable<Painter> painters)
        {
            this.totalHouses = totalHouses;
            this.painters = new List<Painter>(painters);
        }

        public void MaintainHouses()
        {
            double totalVelocity =
                this.painters
                .Select(painter => painter.EstimateDays(1))
                .Select(daysPerHouse => 1 / (double)daysPerHouse)
                .Sum();

            double totalDays = this.totalHouses / totalVelocity;

            double totalHouses =
                this.painters
                .Select(painter => painter.PaintFor(totalDays))
                .Sum();

            Console.WriteLine("\nPainted {0:0} houses.", totalHouses);

        }
    }
}
