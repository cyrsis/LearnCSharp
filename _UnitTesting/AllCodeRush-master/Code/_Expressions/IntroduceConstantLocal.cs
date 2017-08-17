using System;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Introduce Constant (Local)
        
			Use Case: Declares a new *local* constant 
			initialized to the value of the string or number at the 
			caret.
         
			Available: When the caret is on a number or string literal.
        
			See also: Inline Constant, Introduce Constant
		 •———————————————————————————————————————————————————————• */

	public class IntroduceConstantLocal
	{
    public static TimeSpan GetLightSpan(double meters)
    {
      // TODO: Introduce a constant for the speed of light...
      return TimeSpan.FromSeconds(meters / 2.9979e10);
    }
	}
}
