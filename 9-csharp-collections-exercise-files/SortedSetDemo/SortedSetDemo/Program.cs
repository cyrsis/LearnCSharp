using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.Sets.SortedSetDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			// choose the string comparer you want and uncomment that one
//			var bigCities = new SortedSet<string>() { "New York", "Manchester", "Sheffield", "Paris" };
//			var bigCities = new SortedSet<string>(StringComparer.InvariantCultureIgnoreCase) { "New York", "Manchester", "Sheffield", "Paris" };
			var bigCities = new SortedSet<string>(new UncasedStringComparer()) { "New York", "Manchester", "Sheffield", "Paris" };

			bigCities.Add("SHEFFIELD");
			bigCities.Add("BEIJING");

			foreach (string city in bigCities)
				Console.WriteLine(city);
		}


	}

	class UncasedStringComparer : IComparer<string>
	{

		public int Compare(string x, string y)
		{
			return string.Compare(x, y, StringComparison.InvariantCultureIgnoreCase);
		}
	}

}
