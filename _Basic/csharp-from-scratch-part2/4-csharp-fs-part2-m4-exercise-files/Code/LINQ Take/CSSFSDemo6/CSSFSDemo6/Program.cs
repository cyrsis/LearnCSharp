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
         var bigList = Enumerable.Range(1, 20);
         var littleList = bigList.Take(5).Select(x => x * 10);
         foreach (var i in littleList)
            Console.WriteLine(i);
      }
   }
}
