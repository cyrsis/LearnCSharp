using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.Sets.HashSetBasics
{
	class Program
	{
		static void Main(string[] args)
		{
			var bigCities = new HashSet<string> 
			{ "New York", "Manchester", "Sheffield", "Paris" };

			bool addedSheffield = bigCities.Add("Sheffield");
			bool addedBeijing = bigCities.Add("Beijing");
			Console.WriteLine("Added Sheffield? " + addedSheffield);
			Console.WriteLine("Added Beijing? " + addedBeijing);
			Console.WriteLine();

			foreach (string city in bigCities)
				Console.WriteLine(city);
		}

	}
}
