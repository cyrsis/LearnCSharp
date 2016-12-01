using System;
using System.Collections.Generic;

namespace CarShop
{
    class Seat
    {

        private string name;
        private int capacity;

        public Seat(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }

        public void Accept(Func<ICarPartVisitor> visitorFactory)
        {
            visitorFactory().VisitSeat(this.name, this.capacity);
        }

        public static IEnumerable<Seat> FourSeatConfiguration
        {
            get
            {
                return new Seat[]
                {
                    new Seat("Driver", 1),
                    new Seat("Passenger", 1),
                    new Seat("Rear bench", 2)
                };
            }
        }

        public static IEnumerable<Seat> TwoSeatConfiguration
        {
            get
            {
                return new Seat[]
                {
                    new Seat("Driver", 1),
                    new Seat("Passenger", 1)
                };
            }
        }
    }
}
