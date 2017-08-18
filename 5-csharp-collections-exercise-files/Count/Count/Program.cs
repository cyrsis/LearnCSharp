using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Count
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
			ICollection<string> collection = (ICollection<string>)daysOfWeek;
			// LINQ extension method
			Console.WriteLine("Count()  = " + collection.Count());
			// ICollection<T> property
			Console.WriteLine("Count  = " + collection.Count);
			// Array property
			Console.WriteLine("Length  = " + daysOfWeek.Length);
		}
	}
}
