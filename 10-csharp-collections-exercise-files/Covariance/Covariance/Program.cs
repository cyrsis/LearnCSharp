using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.Covariance
{
	class Program
	{
		static void Main(string[] args)
		{
            // this cast works implicitly
			string str = "Hello, World!";
			object obj = str;

            // casting List<string> to List<object> doesn't work
			var strList = new List<string> { "Monday", "Tuesday" };
//			List<object> objList = strList; // will cause error

            // but casting to IEnumerable<object> works
			IEnumerable<object> objEnum = strList;		

            // and the comparable cast for arrays works due to array covariance
            var strArray = new string[] { "Monday", "Tuesday" };
            object[] objArray = strArray; 
            // but beware: This would through an exception at runtime
            // objArray[0] = 5;
		
		}
	}
}
