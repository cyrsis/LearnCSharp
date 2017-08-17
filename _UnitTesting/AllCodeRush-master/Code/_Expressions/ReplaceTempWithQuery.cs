using System;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Replace Temp With Query
        
			Use Case: Replaces all references to a local 
			variable with a call to a property or method that returns 
			the variable's initial value.
         
			Available: When the caret is on a local variable 
			declaration. The variable should be initialized right 
      in the declaration statement.
		 •———————————————————————————————————————————————————————• */

	public class ReplaceTempWithQuery
	{
    const double gravitationalConstant = 6.673e-11;
    const double massOfEarth = 5.97219e24;

    public double ForceFromEarth(double mass, double distance)
		{
      double gravitationalConstantForEarth = massOfEarth * gravitationalConstant;

      return gravitationalConstantForEarth * mass / (distance * distance);
		}
	}
}
