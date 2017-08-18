using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CsharpCollections.FindElements
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
			// index of Tuesday
			int indexOfTues = Array.IndexOf(daysOfWeek, "Tuesday");
			Console.WriteLine(indexOfTues);
			Console.WriteLine();

			// index of first day beginning with W
			int indexOfW = Array.FindIndex(daysOfWeek, x => x[0] == 'W');
			Console.WriteLine(indexOfW);
			Console.WriteLine(daysOfWeek[indexOfW]);
			Console.WriteLine();

			// all days with 6 chars in name
			string[] allWith6Chars = Array.FindAll(
				daysOfWeek, x => x.Length == 6);
			foreach (string item in allWith6Chars)
				Console.WriteLine(item);
		}
	}
}
