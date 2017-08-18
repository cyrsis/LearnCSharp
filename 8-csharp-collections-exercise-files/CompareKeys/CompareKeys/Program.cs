using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.Dictionaries.CompareKeys
{
	// Important: This sample uses .NET 4.0. However some of the samples for this module require .NET 4.5 
	// (in order to use read-only collection classes, which were only introduced with .NET 4.5).
	// If you are following along the module by editing the code from this project, then you
	// will need to change the framework version to 4.5 to get later samples to work
	// (You can make the change using the Application tab of the Project Properties dialog)


	class Program
	{
		static void Main(string[] args)
		{
			// choose the equality comparer to use and comment out the others
			var primeMinisters = new Dictionary<string, PrimeMinister>
				(new UncasedStringEqualityComparer())
			//var primeMinisters = new Dictionary<string, PrimeMinister>
			//    (StringComparer.InvariantCultureIgnoreCase)
			{
			    {"JC", new PrimeMinister("James Callaghan", 1974)},
			    {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
			    {"TB", new PrimeMinister("Tony Blair", 1997)}
			};

			Console.WriteLine(primeMinisters["tb"]);
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
