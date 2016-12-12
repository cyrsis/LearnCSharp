using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_IComparer
{
    public class CarNameComparer : IComparer<Car>
    {
        public int Compare(Car car1, Car car2)
        {
            return car1.Name.CompareTo(car2.Name);
        }
    }
}
