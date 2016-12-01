using System;

namespace Houses
{
    public class Painter: IPainter
    {
        private string name;
        private int daysPerHouse;

        public Painter(string name, int daysPerHouse)
        {
            this.name = name;
            this.daysPerHouse = daysPerHouse;
        }

        public double Paint(double houses)
        {

            double days = this.EstimateDays(houses);

            Console.WriteLine("{0} painting {1:0.00} houses for {2:0.00} days.",
                              this.name, houses, days);

            return days;

        }

        public double EstimateDays(double housesCount)
        {
            return housesCount * this.daysPerHouse;
        }
    }
}
