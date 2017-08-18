using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.Multidim.MultiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] tempsGrid = new float[4, 3];

			Console.WriteLine("Length is " + tempsGrid.Length);
			Console.WriteLine("Rank is " + tempsGrid.Rank);

			for (int x = tempsGrid.GetLowerBound(0);
				x <= tempsGrid.GetUpperBound(0); x++)
			{
				for (int y = tempsGrid.GetLowerBound(1);
					y <= tempsGrid.GetUpperBound(1); y++)
				{
					tempsGrid[x, y] = x + 10 * y;
				}
			}

			for (int x = 0; x < tempsGrid.GetLength(0) ; x++)
			{
				for (int y = 0; y < tempsGrid.GetLength(1) ; y++)
				{
					Console.Write(tempsGrid[x, y] + ", ");
				}
				Console.WriteLine();
			}

			// alternative way of displaying values
			//foreach (float temperature in tempsGrid)
			//{
			//    Console.WriteLine(temperature);
			//}

		}
    }
}
