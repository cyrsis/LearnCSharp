using System;

namespace AllCodeRush.Code.Conditionals
{
  /* •———————————————————————————————————————————————————————•
      Feature: Compress to Null Coalescing Operation.
        
      Use Case: Lets you convert a ternary operation which uses
      a null comparison into a null coalescing operation.
         
      Available: When the caret is on a ? statement. 
       - The statement's left hand side should compare a variable
         to null. 
       - The same variable should be one of two alternatives in 
         the right-hand side.
        
      Related Refactorings: Expand Null Coalescing Operation.
           
      For more information on formatting code, see the "Code 
      Formatting" video.
     •———————————————————————————————————————————————————————• */

  public class CompressToNullCoalescingOperation
  {
    private string _value;
    public string GetValue(string defaultValue)
    {
      return _value == null ? defaultValue : _value;
    }

    public string GetOtherValue(string defaultValue)
    {
      return _value != null ? _value : defaultValue;
    }
  }
}
