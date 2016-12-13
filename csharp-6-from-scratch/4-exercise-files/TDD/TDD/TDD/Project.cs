using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
   public class Project
   {
      public bool IsActive { get; set; }
      private List<Segment> segments;
      private Segment activeSegment;

      public Project()
      {
         segments = new List<Segment>();
      }


      public double Duration
      {
         get
         {
            return GetDuration();
         }
      }

      DateTime endTime;
      DateTime startTime;

      public void Start()
      {

      }
      public void Start(DateTime startTime)
      {
         IsActive = true;
         this.startTime = startTime;
         activeSegment = new Segment();
         activeSegment.Start(startTime);
      }

      public void End(DateTime endTime)
      {
         this.endTime = endTime;
         activeSegment.End(endTime);
         segments.Add(activeSegment);
      }

      private double GetDuration()
      {
         double totalTime = 0.0;
         foreach (Segment segment in segments)
         {
            totalTime += segment.Duration;
         }
         return totalTime;
      }
   }
}
