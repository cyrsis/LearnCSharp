using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AddElement
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] daysOfWeek = {
                                      "Monday",
                                      "Tuesday",
                                      "Wednesday",
                                      "Thursday",
                                      "Friday",
                                      "Saturday",
                                      "Sunday"
                                  };
			ICollection<string> collection = (ICollection<string>)daysOfWeek;

			// will throw an exception
			//collection.Add("SlaveDay");

			// the correct way to use IsReadOnly
			if (!collection.IsReadOnly)
				collection.Add("SlaveDay");
			else
				Console.WriteLine("Collection is read-only");

			// but we can still replace elements!
			(collection as string[])[5] = "SlaveDay";

			foreach (string day in collection)
				Console.WriteLine(day);
		}
	}
}
