using System;
using System.Collections.Generic;
using System.Linq;

namespace CarShop
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<Car> cars = new CarRepository().GetAll();

            foreach (Car car in cars)
                Console.WriteLine(car.Register());

            Console.Write("Press ENTER to exit...");
            Console.ReadLine();

        }
    }
}