using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMedian
{
    public static class IListExtensions
    {
        public static T FindMedian<T>(this IList<T> list) where T : IComparable<T>
        {
            T[] array = list.ToArray();
            Array.Sort(array);
            int middle = (list.Count + 1) / 2 - 1;
            return array[middle];
        }
    }
}
