using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.Types
{
	/* •—————————————————————————————————————————————————————————•
			Feature: Move Type To File
         
			Use Case: Moves a type to a new code file.  
	 
			Available: When the caret is on a type declaration and the 
	    file contains two or more types. The class should have a 
	    name that differs from the file name.
		 •—————————————————————————————————————————————————————————• */
	public class Store
	{
		private List<Shelf> _Shelves = new List<Shelf>();
		public Store()
		{
			_Shelves.Add(new Shelf("Fresh Vegetables"));
			_Shelves.Add(new Shelf("Fresh Meat"));
			_Shelves.Add(new Shelf("Frozen"));
		}
	}
	public class Shelf
	{
		private readonly string _name;
		public Shelf(string Name)
		{
			_name = Name;
		}
	}
}
