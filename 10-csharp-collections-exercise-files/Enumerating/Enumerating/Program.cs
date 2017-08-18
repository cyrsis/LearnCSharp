using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumerating
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

            // will enumerate elements of the array
            DisplayItems(daysOfWeek);

            // will enumerate the characters in the string
            DisplayItems("Hello, World!");

        }


        public static void DisplayItems<T>(IEnumerable<T> collection)
        {
            using (IEnumerator<T> enumerator = collection.GetEnumerator())
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

	}
}
