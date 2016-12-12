using System;

namespace AllCodeRush.Code.LambdaExpressionsAnonymousMethods
{
  /* •———————————————————————————————————————————————————————•
      Feature: Compress to Lambda Expression.
        
      Use Case: Converts an anonymous method to a corresponding 
      lambda expression.
	 
      Available: When the caret is on the delegate keyword 
      in an anonymous method declaration.

      See also: Expand Lambda Expression
     •—————————————————————————————————————————————————————————• */
  public class CompressToLambdaExpression
	{
    protected Func<string, int> func = delegate(string s) { return s.Length; };
	}
}
