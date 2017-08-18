using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Pluralsight.CSharpCollections.Dictionaries.ReadOnlyDict
{
	class Program
	{
		static void Main(string[] args)
		{
			var primeMinisters = new Dictionary<string, PrimeMinister>()
			{
			    {"JC", new PrimeMinister("James Callaghan", 1974)},
			    {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
			    {"TB", new PrimeMinister("Tony Blair", 1997)}
			};


			var pmsReadOnly = new ReadOnlyDictionary
				<string, PrimeMinister>(primeMinisters);
			// won't compile for readonly dictionary
//			pmsReadOnly.Add("GB", new PrimeMinister("Gordon Brown", 2007));



			foreach (var pm in pmsReadOnly)
				Console.WriteLine(pm.Value);

		}
	}
}
