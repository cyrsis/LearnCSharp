using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseArray
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

			// using internal array method
			Array.Reverse(daysOfWeek);
			// using LINQ
			//			var reversed = daysOfWeek.Reverse();

			foreach (string day in daysOfWeek)
				Console.WriteLine(day);
		}
	}
}
