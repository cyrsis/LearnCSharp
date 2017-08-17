using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Conditionals
{
  /* •———————————————————————————————————————————————————————•
      Feature: Expand Ternary Expression
        
      Use Case: Lets you convert a Ternary Expression into an 
      if/else block.
         
      Available: When the caret is on an expression containing 
      a ternary operator.
        
      Related Refactorings: Compress to Ternary Expression
           
      For more information on formatting code, see the "Code 
      Formatting" video.
     •———————————————————————————————————————————————————————• */

  public class ExpandTernaryExpression
  {
    public static string GetZeroStr(int input)
    {
      return input == 0 ? "zero" : "non-zero";
    }

    public static string GetSignStr(int input)
    {
      return input == 0 ? "zero" : input > 0 ? "positive" : "negative";
    }
  }
}
