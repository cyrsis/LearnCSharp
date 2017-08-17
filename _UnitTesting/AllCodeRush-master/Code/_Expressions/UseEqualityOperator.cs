using System;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
		  Feature: Use Equality Operator
          
		  Use Case: Converts an Equals method call to an 
	    expression with the equality operator.
           
		  Available: When an expression with the Equals method 
			call is selected.
          
		  See also: Introduce Local, Replace with Constant
	   •———————————————————————————————————————————————————————• */

	public class UseEqualityOperator
	{
    private string ConcatIfDifferent(string str1, string str2)
		{
			if (str1.Equals(str2))
        return str1;
      else
        return str1 + "," + str2;
		}
	}
}
