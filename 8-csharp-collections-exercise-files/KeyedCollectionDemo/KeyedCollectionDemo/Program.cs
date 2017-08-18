using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Pluralsight.CSharpCollections.Dictionaries.KeyedCollectionDemo
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
			var primeMinisters = new PrimeMinistersByYearDictionary()
			{
			    new PrimeMinister("James Callaghan", 1974),
			    new PrimeMinister("Margaret Thatcher", 1979),
			    new PrimeMinister("Tony Blair", 1997)
			};
			primeMinisters.Add(new PrimeMinister("John Major", 1990));

			var list = (IList<PrimeMinister>)primeMinisters; 
			Console.WriteLine("First PM is " + list[0]);

			Console.WriteLine("Tony is " + primeMinisters[1997]);

			foreach (var pm in primeMinisters)
				Console.WriteLine(pm);
		}
	}

	class PrimeMinistersByYearDictionary :
		KeyedCollection<int, PrimeMinister>
	{
		protected override int GetKeyForItem(PrimeMinister item)
		{
			return item.YearElected;
		}
	}


}
