using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intersect
{
	class Program
	{
		static void Main(string[] args)
		{
			var bigCities = new HashSet<string> 
			{ "New York", "Manchester", "Sheffield", "Paris" };

			string[] citiesInUk = 
			{ "Sheffield", "Ripon", "Truro", "Manchester" };

			// using LINQ
			var newCities = bigCities.Intersect(citiesInUk);
			foreach (string city in newCities)
				Console.WriteLine(city);
			Console.WriteLine();

			// using ISet<T> methods
			// uncomment the operation you want
			bigCities.IntersectWith(citiesInUk);
			//bigCities.UnionWith(citiesInUk);
			//bigCities.SymmetricExceptWith(citiesInUk);
			//bigCities.ExceptWith(citiesInUk);
			foreach (string city in bigCities)
				Console.WriteLine(city);
		}

	}
}
