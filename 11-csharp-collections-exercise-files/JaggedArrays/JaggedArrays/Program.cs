using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pluralsight.CSharpCollections.Multidim.JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
			float[][] tempsGrid = new float[4][];
			Console.WriteLine("Rank is " + tempsGrid.Rank);
			Console.WriteLine("Length is " + tempsGrid.Length);

			for (int x = 0; x < 4; x++)
			{
				tempsGrid[x] = new float[3];
				for (int y = 0; y < 3; y++)
				{
					tempsGrid[x][y] = x + 10 * y;
				}
			}

			for (int x = 0; x < 4; x++)
			{
				for (int y = 0; y < 3; y++)
				{
					Console.Write(tempsGrid[x][y] + ", ");
				}
				Console.WriteLine();
			}
		} 
    }
}
