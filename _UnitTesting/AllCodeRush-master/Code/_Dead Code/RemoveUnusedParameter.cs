using System;

namespace AllCodeRush.Code.DeadCode
{
  /* •————————————————————————————————————————————————————————•
      Feature: Remove Unused Parameter.
        
      Use Case: Removes an unused parameter from a method 
      declaration and updates all calls accordingly.
	 
      Available: When the caret is within the declaration of a 
      method parameter and that parameter is unused within the 
      method.
    
      See also: Remove Unused Parameters
     •————————————————————————————————————————————————————————• */
  public class RemoveUnusedParameter
	{
    public double TimeToDestination(DateTime startTime, double distance, double velocity)
    {
      return distance / velocity;
    }

    public DateTime CalculateArrivalTime()
    {
      DateTime startTime = DateTime.Now;
      return startTime + TimeSpan.FromSeconds(TimeToDestination(startTime, 1000, 200));
    }
	}
}
