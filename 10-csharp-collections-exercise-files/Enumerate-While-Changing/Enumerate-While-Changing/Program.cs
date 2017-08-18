using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.EnumerateWhileChanging
{
	class Program
	{
		static void Main(string[] args)
		{
			var days = new string[] { 
				"Monday", 
				"Tuesday", 
				"Wednesday" };

            // this works fine - no modification checking for an array
            foreach (string day in days)
            {
                days[1] = "2nd day";
                Console.WriteLine(day);
            }

            var dayslist = new string[] { 
				"Monday", 
				"Tuesday", 
				"Wednesday" };

            // this will throw an exception if you uncomment the days[1] =... line
            foreach (string day in dayslist)
            {
 //               days[1] = "2nd day";
                Console.WriteLine(day);
            }

		}
	}
}
