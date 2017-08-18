using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.ArrayType.ArrayCovariance
{
	class Program
	{
		static void Main(string[] args)
		{
			object[] objArr = new object[3];
			string[] daysOfWeek = {
                                      "Monday",
                                      "Tuesday",
                                      "Wednesday",
                                      "Thursday",
                                      "Friday",
                                      "Saturday",
                                      "Sunday"
                                  };

			objArr[0] = 3;
			Console.WriteLine("objArr[0] = " + objArr[0]);

			object[] objArr2 = daysOfWeek;
			// this next line will cause a runtime exception because objArr2 points to an array of string
			objArr2[0] = 3;
			Console.WriteLine("obj2Arr[0] = " + objArr2[0]);
		}
	}
}
