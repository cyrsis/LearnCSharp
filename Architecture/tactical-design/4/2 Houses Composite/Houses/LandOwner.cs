using System;
using System.Collections.Generic;
using System.Linq;

namespace Houses
{
    public class LandOwner
    {
        private int totalHouses;
        private IPainter painter;

        public LandOwner(int totalHouses, IPainter painter)
        {
            this.totalHouses = totalHouses;
            this.painter = painter;
        }

        public void MaintainHouses()
        {

            double days = this.painter.Paint(this.totalHouses);

            Console.WriteLine("\nPainted {0:0} houses in {1:0.00} days.",
                              this.totalHouses, days);

        }
    }
}
