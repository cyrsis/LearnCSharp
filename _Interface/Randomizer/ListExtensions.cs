using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    public static class ListExtensions
    {
        // Used to randomize ILists.
        private static Random Rand = new Random();

        // Randomize the items in an IList.
        public static void Randomize<T>(this IList<T> list)
        {
            // Loop through all positions except the last one.
            for (int i = 0; i < list.Count - 1; i++)
            {
                // Pick a random item to swap into position i.
                int j = Rand.Next(i, list.Count);

                // Swap item j into position i.
                T temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }
        }
    }
}
