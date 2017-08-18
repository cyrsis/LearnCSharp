using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.InsideArrays.DeclareInitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1;
            int[] x2;

			// bad. Use of uninitialized variable
			// var copy = x2;

			int x3 = 5;
			int[] x4 = new int[5];

			// ok even though the array elements haven't been explicitly initialized
			Console.WriteLine(x4[0]);

			int[] x5 = new int[] { 1, 4, 9, 1,6, 25 };

        }
    }
}
