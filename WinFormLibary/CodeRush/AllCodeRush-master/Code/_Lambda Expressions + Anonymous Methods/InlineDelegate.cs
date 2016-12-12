using System;

namespace AllCodeRush.Code.LambdaExpressionsAnonymousMethods
{
	/* •———————————————————————————————————————————————————————•
			Feature: Inline Delegate.
        
			Use Case: Inlines a delegate creating an anonymous 
	    method. If there are no other references to the delegate 
	    method it is removed.
         
			Available: When the caret is on a delegate method.
    
      See also: Name Anonymous Method
		 •———————————————————————————————————————————————————————• */
	public class InlineDelegate
	{
    public enum Operation
    {
      Add,
      Difference
    }
		private int Add(int x, int y)
		{
			return x + y;
		}
    private int Difference(int x, int y)
    {
      return x - y;
    }
    public virtual Func<int, int, int> GetOperation(Operation operation)
    {
      if (operation == Operation.Add)
        return Add;
      else
        return Difference;
    }
	}
}
