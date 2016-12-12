using System;

namespace AllCodeRush.Code.DeadCode
{
  /* •—————————————————————————————————————————————————————————•
      Feature: Remove Unused Parameters
          
      Use Case: Removes all the unused parameters from a method 
      declaration and updates all calls accordingly.
  	 
      Available: When the caret is in the name of a method 
      declaration that has two or more unused parameters.
      
      See also: Remove Unused Parameter
     •—————————————————————————————————————————————————————————• */
  public class RemoveUnusedParameters
  {
    public double TimeToDestination(DateTime startTime, string userID, bool stopIfTooSlow, 
                                    double distance, double velocity)
    {
      return distance / velocity;
    }

    public DateTime CalculateArrivalTime(string userID)
    {
      DateTime startTime = DateTime.Now;
      return startTime + TimeSpan.FromSeconds(TimeToDestination(startTime, userID, false, 1000, 200));
    }
  }
}
