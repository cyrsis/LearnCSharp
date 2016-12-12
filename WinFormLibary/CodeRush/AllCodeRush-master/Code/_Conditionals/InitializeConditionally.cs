using System;

namespace AllCodeRush.Code.Conditionals
{
  /* •———————————————————————————————————————————————————————•
      Feature: Initialize Conditionaly
        
      Use Case: Let's you make a variable's initialization 
      conditional by moving said initialization to a new else 
      block.
         
      Available: When the cursor is on a variable initialization
      provided that the following if block contains an assignment 
      statement for this variable.
           
      For more information on formatting code, see the "Code 
      Formatting" video.
     •———————————————————————————————————————————————————————• */

  public class InitializeConditionally
  {
    public string GetAgeDescription(int age)
    {
      string description = "Young";
      if (age > 70)
        description = "Young at Heart";
      return description;
    }
  }
}
