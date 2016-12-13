using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryOperators
{
   class Worker
   {

      public Worker()
      {
         Work();
      }
      public void Work()
      {
         var listOfInt = new List<int>
         {
            2,
            7,
            3,
            13,
            5,
            18,
            16
         };

         var smallerNumbers = from num in listOfInt
                              where num < 8
                              select num;

         foreach (int number in smallerNumbers)
         {
            Console.WriteLine($"Value: {number}");
         }

      }
   }

}
