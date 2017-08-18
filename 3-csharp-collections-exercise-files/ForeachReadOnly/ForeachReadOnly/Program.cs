using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.InsideArrays.ForeachReadOnly
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

			MakeDaysPlural(daysOfWeek);

			foreach (string day in daysOfWeek)
			{
				Console.WriteLine(day);
			}

        }

        static void MakeDaysPlural(string[] daysOfWeek)
        {
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
				string day = daysOfWeek[i];
				daysOfWeek[i] = day + "s";
            }
        }

		// this won't compile - can't replace array elements using foreach
		//static void MakeDaysPlural2(string[] daysOfWeek)
		//{
		//    foreach (string day in daysOfWeek)
		//    {
		//        day = day + 's';
		//    }
		//}

    }
}
