using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Mod03_Vectorization
{
    class MinMax
    {
        public static void MinMaxScalar(int[] a, out int minimum, out int maximum)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < a.Length; ++i)
            {
                min = Math.Min(min, a[i]);
                max = Math.Max(max, a[i]);
            }
            minimum = min;
            maximum = max;
        }

        public static void MinMaxVector(int[] a, out int minimum, out int maximum)
        {
            int vecSize = Vector<int>.Length;
            Vector<int> vmin = new Vector<int>(int.MaxValue);
            Vector<int> vmax = new Vector<int>(int.MinValue);
            for (int i = 0; i < a.Length; i += vecSize)
            {
                Vector<int> va = new Vector<int>(a, i);
                Vector<int> vLessThan = Vector.LessThan(va, vmin);
                // vLessThan now has 0's in all indexes i where va[i] < vmin[i]
                // and 1's in all other indexes. It's a Vector<int> but in fact
                // it's kind of like a vector of Booleans.

                vmin = Vector.ConditionalSelect(vLessThan, va, vmin);
                // For each index i, vmin[i] = vLessThan[i] ? va[i] : vmin[i].
                // In other words, we just ensured that vmin has the minimum
                // values in each four components.

                // The same thing applies in reverse for vGreaterThan and vmax.
                Vector<int> vGreaterThan = Vector.GreaterThan(va, vmax);
                vmax = Vector.ConditionalSelect(vGreaterThan, va, vmax);
            }

            // Gather the results from the vectors to scalar values
            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < vecSize; ++i)
            {
                min = Math.Min(min, vmin[i]);
                max = Math.Max(max, vmax[i]);
            }
            minimum = min;
            maximum = max;
        }
    }
}
