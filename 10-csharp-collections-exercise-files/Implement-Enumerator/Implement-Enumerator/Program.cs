using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.ImplementEnumerator
{
	class Program
	{
		static void Main(string[] args)
		{
			AllDaysOfWeek allDays = new AllDaysOfWeek();
            // use intellisense after this line to view the enumerator type created by the compiler
			var enumerator = allDays.GetEnumerator();

            // this works as normal
			foreach (string day in allDays)
				Console.WriteLine(day);
		}
	}



	public class AllDaysOfWeek :IEnumerable<string>
	{


		public IEnumerator<string> GetEnumerator()
		{
			Console.WriteLine("Calling generic GetEnumerator");
			yield return "Monday";
			yield return "Tuesday";
			yield return "Wednesday";
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
