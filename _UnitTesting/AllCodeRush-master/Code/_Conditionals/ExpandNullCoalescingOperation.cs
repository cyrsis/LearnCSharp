using System;

namespace AllCodeRush.Code.Conditionals
{
  /* •—————————————————————————————————————————————————————————————•
      Feature: Expand Null Coalescing Operation
        
      Use Case: Lets you convert a Null Coalescing Operation into an 
      equivalent Ternary Expression.
         
      Availability: When the caret is at the start of a statement that 
      uses the ?? operator.
        
      Related Refactorings: Compress To Null Coalescing Operation
     •—————————————————————————————————————————————————————————————• */
  public class ExpandNullCoalescingOperation
  {
    private string _value;
    public string GetValue()
    {
      return _value ?? "Default";
    }
  }
}
