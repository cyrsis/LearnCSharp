using System;

namespace AllCodeRush.Code.Conditionals
{
  /* •———————————————————————————————————————————————————————•
      Feature: Conditional To Case
        
      Use Case: Lets you convert series of nested if/else 
      statements to a single switch statement (or a select 
      statement in VB).
         
      Availability: When the caret is on an if statement that has 
      a corresponding else block (with potentially recursive if/else 
      child blocks), and the expression in each conditional is testing 
      the same variable.
        
      Related Refactorings: Case To Conditional
           
      For more information on formatting code, see the "Code 
      Formatting" video.
     •———————————————————————————————————————————————————————• */

  public class ConditionalToCase
  {
    public double CalculateSuperDiscountPercent(DiscountLevelEnum discountLevel)
    {
      if (discountLevel == DiscountLevelEnum.Platinum)
        return 15.0;
      else if (discountLevel == DiscountLevelEnum.Gold)
        return 10.0;
      else if (DiscountLevelEnum.Silver == discountLevel)
        return 5.0;
      else if (discountLevel == DiscountLevelEnum.Bronze)
        return 2.5;
      else
        throw new Exception("This cannot happen");
    }

    #region Support Code
    public enum DiscountLevelEnum
    {
      Platinum,
      Gold,
      Silver,
      Bronze
    }
    #endregion
  }
}
