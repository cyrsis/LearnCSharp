using System;

namespace AllCodeRush.Code.Expressions
{
  /* •———————————————————————————————————————————————————————•
      Feature: Replace With Local
        
      Use Case: Replaces the selected expression with a 
      reference to a local variable which was previously 
      assigned this value.
         
      Available: When the caret is on a primitive and there's 
      a local variable initialized to the same value.
        
      See also: Introduce Local, Replace with Constant
     •———————————————————————————————————————————————————————• */

  public class ReplaceWithLocal
	{
		public double GetCircleArea(int radius)
		{
      double PI = 3.1415926535897932385;
      return radius * radius * 3.1415926535897932385;
		}
	}
}
