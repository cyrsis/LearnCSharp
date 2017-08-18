using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortArray
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] daysOfWeek = 
			{
				"Monday",
				"Tuesday",
				"Wednesday",
				"Thursday",
				"Friday",
				"Saturday",
				"Sunday" 
			};

			// will sort the array in increasing order of length of string
			var comparer = new StringLengthComparer();
			Array.Sort(daysOfWeek, comparer);

			// will sort the array alphabetically
			Array.Sort(daysOfWeek);


			foreach (string day in daysOfWeek)
				Console.WriteLine(day);
		}
	}

	class StringLengthComparer : IComparer<string>
	{

		public int Compare(string x, string y)
		{
			return x.Length.CompareTo(y.Length);
		}
	}


}
