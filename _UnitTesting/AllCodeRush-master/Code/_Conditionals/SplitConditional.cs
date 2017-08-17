using System;

namespace AllCodeRush.Code.Conditionals
{
  /* •—————————————————————————————————————————————————————————————•
      Feature: Split Conditional
                                                            
      Use Case: Lets you break apart a single conditional
      if-statement having multiple expressions into two
      or more conditional statements.
                                                            
      Available: When the caret is on the "if" keyword of
      an if-statement having two or more logical child 
      expressions.
    
      Related Refactorings: Combine Conditionals (nested & parallel)
           
      For more information on formatting code, see the "Code 
      Formatting" video.
     •—————————————————————————————————————————————————————————————• */
  public class SplitConditional
  {
    public static bool AllTrue(bool a, bool b, bool c)
    {
      if (a && b && c)
        return true;

      return false;
    }

    public static bool AnyTrue(bool a, bool b, bool c)
    {
      if (a || b || c)
        return true;

      return false;
    }

    public static bool SomeTrue(bool a, bool b, bool c)
    {
      if (a || b && c)
        return true;

      return false;
    }
  }
}
