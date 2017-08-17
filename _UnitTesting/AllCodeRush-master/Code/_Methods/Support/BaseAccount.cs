using System;

namespace AllCodeRush.Code.Methods
{
  public class BaseAccount
  {
    protected int balance;
    public void Withdraw(int value)
    {
      balance -= value;
    }
  }
}