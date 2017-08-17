using System;

namespace AllCodeRush.Code.Conditionals
{
  /* •———————————————————————————————————————————————————————•
      Feature: Compress To Ternary Expression
        
      Use Case: Lets you convert an if/else conditional into a
      Ternary Expression.
         
      Available: When the caret is on an if statement that has a 
      corresponding else block. 
       - Both if and else blocks should contain one statement. 
       - These statements should be similar assignments or method 
         calls with different arguments.
        
      Related Refactorings: Expand Ternary Condition
           
      For more information on formatting code, see the "Code 
      Formatting" video. 
     •———————————————————————————————————————————————————————• */

  public class CompressToTernaryExpression
  {
    public static string GetZeroStr(int input)
    {
      if (input == 0)
        return "zero";
      else
        return "non-zero";
    }
  }
}
