using System;
using System.Collections.Generic;
using System.Linq;

namespace CarShop
{
    class CarsView
    {
        private IEnumerable<Car> cars;

        public CarsView(IEnumerable<Car> cars)
        {
            this.cars = new List<Car>(cars);
        }

        public void Render()
        {
            foreach (Car car in cars)
                Console.WriteLine("{0} {1} {2}cc {3}kW {4} seat(s)",
                                  car.Make, car.Model,
                                  car.Engine.CylinderVolume, car.Engine.Power,
                                  car.Seats.Sum(seat => seat.Capacity));
        }
    }
}
