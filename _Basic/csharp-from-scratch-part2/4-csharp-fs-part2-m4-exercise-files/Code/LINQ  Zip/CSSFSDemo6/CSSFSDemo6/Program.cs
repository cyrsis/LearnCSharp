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
         string[] postalCodes = { "AL", "AK", "AZ", "AR", 
                                   "CA", "CO", "CT", "DE", "FL" };

         string[] states = { "Alabama", "Alaska", "Arizona", 
                              "Arkansas", "California", "Colorodo", 
                              "Connecticut", "Deleware", "Florida" };

         var statesWithCodes = postalCodes.Zip(states, (code, state) =>
            code + ": " + state);

         foreach (var stateWithCode in statesWithCodes)
         {
            Console.WriteLine(stateWithCode);
         }


      }
   }
}
