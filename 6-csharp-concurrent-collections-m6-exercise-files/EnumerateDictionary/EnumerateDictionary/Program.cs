using System;  
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Pluralsight.ConcurrentCollections.EnumerateDictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			// change this to a Dictionary<string, int> to see that enumerating while modifying
			// throws an exception for the standard dictionary
			var stock = new ConcurrentDictionary<string, int>();
			stock.TryAdd("jDays", 0);
			stock.TryAdd("Code School", 0);
			stock.TryAdd("Buddhist Geeks", 0);

			foreach (var shirt in stock)
			{
				stock.AddOrUpdate("jDays", 0, (key, value) => value + 1);
				Console.WriteLine(shirt.Key + ": " + shirt.Value);
			}
		}
	}
}
