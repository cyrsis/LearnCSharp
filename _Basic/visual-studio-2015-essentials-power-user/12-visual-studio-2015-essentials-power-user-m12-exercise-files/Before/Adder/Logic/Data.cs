using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    public class Data
    {
        private double num1, num2, num3;

        public double Number1
        {
          get { return Math.Round(num1); }
        }
        public double Number2
        {
            get { return Math.Round(num2); }
        }
        public double Number3
        {
            get { return Math.Round(num3); }
        }

        public double Total
        {
            get { return Math.Round(num1 + num2 + num3); }
        }

        public Data()
        {
            //in a real app, there would be good stuff here
            Random r = new Random();
            num1 = r.NextDouble() * 10;
            num2 = r.NextDouble() * 10;
            num3 = r.NextDouble() * 10;
        }

    }
}
