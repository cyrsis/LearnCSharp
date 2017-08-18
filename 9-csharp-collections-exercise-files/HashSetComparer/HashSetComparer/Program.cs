using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.Sets.HashSetComparer
{
	class Program
	{
		static void Main(string[] args)
		{
			// choose one of these declarations:
			// will think SHEFFIELD and Sheffield are different strings
			//var bigCities = new HashSet<string>() { "New York", "Manchester", "Sheffield", "Paris" };
			//// will think SHEFFIELD and Sheffield are same string - using MS comparer
			var bigCities = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase) { "New York", "Manchester", "Sheffield", "Paris" };
			//// will think SHEFFIELD and Sheffield are same string - using our own custom comparer
			//var bigCities = new HashSet<string>(new UncasedStringEqualityComparer()) { "New York", "Manchester", "Sheffield", "Paris" };

			bigCities.Add("SHEFFIELD");
			bigCities.Add("BEIJING");

			foreach (string city in bigCities)
				Console.WriteLine(city);
		}

	}
	class UncasedStringEqualityComparer : IEqualityComparer<string>
	{
		public bool Equals(string x, string y)
		{
			return x.ToUpper() == y.ToUpper();
		}

		public int GetHashCode(string obj)
		{
			return obj.ToUpper().GetHashCode();
		}
	}
}
