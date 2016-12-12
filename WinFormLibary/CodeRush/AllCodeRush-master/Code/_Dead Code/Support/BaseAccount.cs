using System;

namespace AllCodeRush.Code.DeadCode
{
	public class BaseAccount
	{
		protected decimal balance;
		public void Withdraw(decimal Value)
		{
			balance = balance - Value;
		}
		public void Deposit(decimal Value)
		{
			balance = balance + Value;
		}
    public decimal Balance
    {
      get
      {
        return balance;
      }
    }
  }
}
