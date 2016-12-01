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

            CarsView view = new CarsView(cars);
            view.Render();

            Console.Write("Press ENTER to exit...");
            Console.ReadLine();

        }
    }
}