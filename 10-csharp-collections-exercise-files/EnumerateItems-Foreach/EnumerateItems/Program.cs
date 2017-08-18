using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CsharpCollections.EnumerateItems
{
	class Program
	{
        static void Main(string[] args)
        {
            string[] daysOfWeek = {
									  "Monday",
									  "Tuesday",
									  "Wednesday",
									  "Thursday",
									  "Friday",
									  "Saturday",
									  "Sunday"
								  };
            // both functions do the same thing
            DisplayItems(daysOfWeek);
            DisplayItems2(daysOfWeek);

        }


        public static void DisplayItems<T>(IEnumerable<T> enumerable)
        {
            using (IEnumerator<T> enumerator = enumerable.GetEnumerator())
            {
                bool moreItems = enumerator.MoveNext();
                while (moreItems)
                {
                    T item = enumerator.Current;
                    Console.WriteLine(item);
                    moreItems = enumerator.MoveNext();
                }
            }

        }

        public static void DisplayItems2<T>(IEnumerable<T> enumerable)
        {
            foreach (T item in enumerable)
            {
                Console.WriteLine(item);
            }

        }

	}
}
