using System;

namespace AllCodeRush.Code.Conditionals
{
  /* •———————————————————————————————————————————————————————•
      Feature: Combine Conditionals (nested)
                                                            
      Use Case: Combines two or more nested conditional 
      statements.
                                                            
      Available: When the caret is on the "if" keyword of
      an if-statement that parents other if statements.
    
      Related Refactorings: Combine Conditionals (parallel),  
                            Split Conditional
           
      For more information on formatting code, see the "Code 
      Formatting" video.
     •———————————————————————————————————————————————————————• */
  public class CombineConditionalsNested
  {
    public static bool AllTrue(bool a, bool b, bool c)
    {
      if (a)
        if (b)
          if (c)
            return true;
      return false;
    }
  }
}
