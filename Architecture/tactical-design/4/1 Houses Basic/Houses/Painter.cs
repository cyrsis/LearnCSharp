using System;
namespace Houses
{
    public class Painter
    {
        private string name;
        private int daysPerHouse;

        public Painter(string name, int daysPerHouse)
        {
            this.name = name;
            this.daysPerHouse = daysPerHouse;
        }

        public double PaintFor(double totalDays)
        {

            double totalHouses = totalDays / this.daysPerHouse;

            Console.WriteLine("{0} painting {1:0.00} houses for {2:0.00} days.",
                              this.name, totalHouses, totalDays);

            return totalHouses;

        }

        public int EstimateDays(int housesCount)
        {
            return housesCount * this.daysPerHouse;
        }
    }
}
