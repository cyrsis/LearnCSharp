using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.Sets.SetComparisons
{
	class Program
	{
		static void Main(string[] args)
		{
			var ukCities = new HashSet<string> 
			{ "Sheffield", "Ripon", "Truro", "Manchester" };

			var bigUkCities = new HashSet<string> 
			{ "Sheffield", "Manchester" };

			var bigCitiesArr = new HashSet<string> 
			{ "New York", "Manchester", "Sheffield", "Paris" };

			//	bool ukIsSubset = ukCities.IsSubsetOf(bigCitiesArr);
			bool ukIsSubset = bigCitiesArr.IsSupersetOf(ukCities);
			Console.WriteLine("UK cities subset of big cities? " + ukIsSubset);

			// bool bigUkIsSubset = bigUkCities.IsSubsetOf(bigCitiesArr);
			bool bigUkIsSubset = bigCitiesArr.IsSupersetOf(bigUkCities); 
			
			Console.WriteLine("Big UK cities subset of big cities? " + bigUkIsSubset);
		}
	}
}
