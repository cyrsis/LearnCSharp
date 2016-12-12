using System;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Introduce Constant
        
			Use Case: Declares a new constant initialized to 
			the value of the string or number at the caret.
         
			Available: When the caret is on a number or string literal.
        
			See also: Inline Constant, Introduce Constant (Local)
		 •———————————————————————————————————————————————————————• */

	public class IntroduceConstant
	{
    public double GetCircleSegmentLength(double radius, double percentageAround)
		{
      // Let's introduce a constant for tau:
      return 6.2831853071 * percentageAround * radius;
		}
	}
}
