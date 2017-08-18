using System;
using System.Collections.Generic;
//using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.Lists.OverrideCollection
{
	class Program
	{
		static void Main(string[] args)
		{
			NonBlankStringList lst = new NonBlankStringList();
			lst.Add("Item added at index 0");
			// this line would throw an exception
//			lst[0] = "   ";
			lst.Add("Item added at index 1");
			lst.Insert(2, "Item inserted at index 2");

			foreach (string item in lst)
				Console.WriteLine(item);

		}
	}


}
