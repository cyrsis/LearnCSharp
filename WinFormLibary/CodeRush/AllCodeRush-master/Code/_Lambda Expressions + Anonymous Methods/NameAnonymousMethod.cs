using System;

namespace AllCodeRush.Code.LambdaExpressionsAnonymousMethods
{
  /* •———————————————————————————————————————————————————————•
      Feature: Name Anonymous Method.
          
      Use Case: Converts an anonymous method to an instance 
      method.
           
      Available: When the caret is on the delegate keyword 
      within an anonymous method declaration. 
      The method should not use local variables.
      
      See also: Inline Delegate
     •———————————————————————————————————————————————————————• */

  public class NameAnonymousMethod : BaseNameAnonymousMethod
  {
    protected override Func<int, int, int> GetOperation()
    {
      return delegate(int x, int y)
      {
        return x + y;
      };
    }
  }
}