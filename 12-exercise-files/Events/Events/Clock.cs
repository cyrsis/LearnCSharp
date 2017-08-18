using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Events
{
   public class Clock
   {
      private int hour;
      private int minute;
      private int second;

      public delegate void SecondChangedHandler(
         object clock,
         TimeInfoEventArgs timeInfo);

      public event SecondChangedHandler SecondChanged;

      public void Run()
      {
         for (;;)
         {
            Thread.Sleep(100);
            DateTime now = DateTime.Now;
            if (now.Second != second)
            {
               TimeInfoEventArgs timeInfoEventArgs =
                  new TimeInfoEventArgs(
                     now.Hour,
                     now.Minute,
                     now.Second);
               if (SecondChanged != null)
               {
                  SecondChanged(this, timeInfoEventArgs);
               }
            }
         }
      }

   }
}
