using System;

namespace AllCodeRush.Code.DeadCode
{
  /* •—————————————————————————————————————————————————————————•
        Feature: Remove Redundant Delegate Creation.
            
        Use Case: Removes the unnecessary event delegate creation 
        call around an event handler hook-up.
    	 
        Available: When the caret is on the delegate creation 
        code. 
       •—————————————————————————————————————————————————————————• */
  public class RemoveRedundantDelegateCreation
  {
    public event EventHandler Click;
    public RemoveRedundantDelegateCreation()
    {
      Click += new EventHandler(DoSomething);
    }

    void DoSomething(object sender, EventArgs e)
    {
      throw new NotImplementedException();
    }
  }
}
