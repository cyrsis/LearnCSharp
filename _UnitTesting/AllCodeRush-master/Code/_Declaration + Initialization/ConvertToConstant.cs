using System;

namespace AllCodeRush.Code.DeclarationInitialization
{
	/* •———————————————————————————————————————————————————————•
		  Feature: Convert To Constant
        
		  Use Case: Converts a variable to a constant.
         
		  Available: When the caret is on a local variable or a
		  field declaration with initialization, and that variable 
      is never changed in the code.
		 •———————————————————————————————————————————————————————• */

	public class ConvertToConstant
	{
		private double AlmostPi = 3.14;
		public double GetRoughCircleArea(int radius)
		{
      return AlmostPi * radius * radius;
		}

    public double ToRadians(double degrees)
    {
      double HalfSpin = 180.0;
      return Math.PI * degrees / HalfSpin;
    }
	}
}
