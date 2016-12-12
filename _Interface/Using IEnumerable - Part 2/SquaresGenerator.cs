using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_IEnumerable___Part_2
{
    class SquaresGenerator : IEnumerable<long>
    {
        public IEnumerator<long> GetEnumerator()
        {
            for (int i = 0; ; i++)
                yield return i * i;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
