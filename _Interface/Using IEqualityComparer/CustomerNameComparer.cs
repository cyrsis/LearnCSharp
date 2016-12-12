using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_IEqualityComparer
{
    public class CustomerNameComparer : IEqualityComparer<Customer>
    {
        public bool Equals(Customer x, Customer y)
        {
            if (x == null) return (y == null);
            if (y == null) return false;
            return (x.Name == y.Name);
        }

        public int GetHashCode(Customer obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
