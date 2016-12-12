using System;

namespace AllCodeRush.Code.Conditionals
{
  /* •———————————————————————————————————————————————————————•
      Feature: Combine Conditionals (parallel)
                                                            
      Use Case: Combines two or more side-by-side conditional 
      statements.
                                                            
      Available: When the caret is on the "if" keyword of
      an if-statement that is next to other if statements 
      having identical child blocks.
    
      Related Refactorings: Combine Conditionals (nested),  
                            Split Conditional
           
      For more information on formatting code, see the "Code 
      Formatting" video.
     •———————————————————————————————————————————————————————• */
  public class CombineConditionalsParallel
  {
    public static bool AnyTrue(bool a, bool b, bool c)
    {
      if (a)
        return true;

      if (b)
        return true;

      if (c)
        return true;

      return false;
    }
  }
}
