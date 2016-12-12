using System;

namespace AllCodeRush.Code.DeadCode
{
	/* •———————————————————————————————————————————————————————•
			Feature: Remove Redundant Call.
        
			Use Case: Removes a call to a method or constructor 
      that does nothing.
         
			Available: When the caret is on a call to an empty base 
			constructor or on a call to String.Format with a single 
			argument.
   
      See also: Inline Method, Inline Method (and delete)
		 •———————————————————————————————————————————————————————• */

	public class RemoveRedundantCall : BaseAccount
	{
		private decimal limit = 0m;
    public RemoveRedundantCall()
			: base()
		{
		}

    public void Withdraw(decimal value)
    {
      if (balance - value < limit)
        throw new Exception(string.Format("Insufficient credit."));
      
      balance = balance - value;
    }
	}
}
