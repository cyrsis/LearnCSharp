using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.Lists.ListCapacity
{
    class Program
    {
        static void Main(string[] args)
        {
 			var presidents = new List<string>{
				"Jimmy Carter",
				"Ronald Reagan",
				"George HW Bush",
				"Bill Clinton",
				"George W Bush"
			};

            Console.WriteLine("\r\nBefore adding:");
            Console.WriteLine("Count = " + presidents.Count);
            Console.WriteLine("Capacity = " + presidents.Capacity);

            presidents.Add("Barack Obama");
            presidents.Add("Bill Gates");
            presidents.Add("Steven Spielberg");
            presidents.Add("Aaron Skonnard");

            Console.WriteLine("\r\nAfter adding:");
            Console.WriteLine("Count = " + presidents.Count);
            Console.WriteLine("Capacity = " + presidents.Capacity);

            Console.WriteLine();
			foreach (string president in presidents)
				Console.WriteLine(president);
		}       
    }
}
