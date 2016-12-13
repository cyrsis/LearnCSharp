using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
   public class Segment
   {
      private DateTime startTime;
      private DateTime endTime;
      public double Duration 
         { get { return (endTime - startTime).TotalSeconds; } }

      public void Start(DateTime start)
      {
         startTime = start;
      }

      public void End (DateTime end)
      {
         endTime = end;
      }


   }
}
