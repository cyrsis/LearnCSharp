using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.InsideArrays.BasicArrayOps
{
    class Program
    {
        static void Main(string[] args)
        {
			string monday = "Monday";
            string[] daysOfWeek = {
                                      "Monday",
                                      "Tuesday",
                                      "Wednesday",
                                      "Thursday",
                                      "Friday",
                                      "Saturday",
                                      "Sunday"
                                  };
			Console.WriteLine(daysOfWeek[1]);

			// would cause an index out of bounds exception
			// Console.WriteLine(daysOfWeek[7]);

			daysOfWeek[5] = "PartyDay";

			foreach (string day in daysOfWeek)
				Console.WriteLine(day);

        }
    }
}
