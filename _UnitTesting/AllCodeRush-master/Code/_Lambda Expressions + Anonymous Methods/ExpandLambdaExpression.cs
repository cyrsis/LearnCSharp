using System;

namespace AllCodeRush.Code.LambdaExpressionsAnonymousMethods
{
  /* •———————————————————————————————————————————————————————•
      Feature: Expand Lambda Expression.
        
      Use Case: Converts a Lambda Expression into an anonymous 
      method.
	 
      Available: When the caret is on the left side of a lambda 
      operator or on a lambda operator (=>). 
    
      See also: Name Anonymous Method, Compress to Lambda 
      Expression
     •———————————————————————————————————————————————————————• */
  public class ExpandLambdaExpression
	{
    protected Func<string, char, int> charCount = (workStr, matchCharacter) => workStr.Split(matchCharacter).Length - 1;
	}
}
