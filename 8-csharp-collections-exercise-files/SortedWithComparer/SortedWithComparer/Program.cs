using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.Dictionaries.SortedWithComparer
{
	class Program
	{
		// Important: This sample uses .NET 4.0. However some of the samples for this module require .NET 4.5 
		// (in order to use read-only collection classes, which were only introduced with .NET 4.5).
		// If you are following along the module by editing the code from this project, then you
		// will need to change the framework version to 4.5 to get later samples to work
		// (You can make the change using the Application tab of the Project Properties dialog)

		static void Main(string[] args)
		{
			// choose the comparer to use and comment out the other one
			var primeMinisters = new SortedDictionary
				<string, PrimeMinister>(new UncasedStringComparer())
			//var primeMinisters = new SortedDictionary
			//    <string, PrimeMinister>(StringComparer.InvariantCultureIgnoreCase)
			{
			    {"JC", new PrimeMinister("James Callaghan", 1974)},
			    {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
			    {"TB", new PrimeMinister("Tony Blair", 1997)}
			};
			primeMinisters.Add("JM", new PrimeMinister("John Major", 1990));

			Console.WriteLine("tony is " + primeMinisters["tb"]);
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
