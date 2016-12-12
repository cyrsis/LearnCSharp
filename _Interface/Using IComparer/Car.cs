using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_IComparer
{
    public class Car
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int TopSpeed { get; set; }
        public int Horsepower { get; set; }
        public Car(string name, decimal price, int topSpeed, int horsepower)
        {
            Name = name;
            Price = price;
            TopSpeed = topSpeed;
            Horsepower = horsepower;
        }
        public override string ToString()
        {
            return Name + "\t" +
                Price.ToString("C") + "\t" +
                TopSpeed.ToString() + " mph\t" +
                Horsepower.ToString() + " hp";
        }
    }
}
