using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSFSDemo6
{
   class Program
   {
      static void Main(string[] args)
      {
         var primes = new List<int> { 1, 2, 3, 5, 7, 11, 13, 17, 19, 23 };
         var query = from val in primes
                     where val < 13
                     select val;
         foreach (var val in query)
            Console.WriteLine(val);

         var methodQuery = primes.Where(x => x < 13);
         foreach (var val in methodQuery)
            Console.WriteLine(val);



      }
   }
}
