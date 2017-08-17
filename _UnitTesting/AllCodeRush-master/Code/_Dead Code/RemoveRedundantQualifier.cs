using System;

namespace AllCodeRush.Code.DeadCode
{
  /* •———————————————————————————————————————————————————————•
      Feature: Remove Redundant Qualifier.
        
      Use Case: Removes an unnecessary 'this' or 'base' 
      qualifier (or Me and MyBase in VB).

      Available: When the caret is on a 'this' or 'base' 
      qualifier which is unnecessary in the current context.
   
      See also: Remove Redundant Qualifier (All)
     •—————————————————————————————————————————————————————————• */

  public class RemoveRedundantQualifier: BaseAccount
	{
    public void TransferToAccount(decimal value, BaseAccount targetAccount)
		{
			this.Withdraw(value);
			targetAccount.Deposit(value);
		}
	}
}
