using System;

namespace AllCodeRush.Code.Methods.Parameters
{
  /* •———————————————————————————————————————————————————————•
        Feature: Add Parameter
          
        Use Case: Adds a parameter to the method or 
        constructor at the caret.
           
        Available: When the caret is in the arguments section
        of a method call or when the caret is in the parameters
        section of a method declaration.
       •———————————————————————————————————————————————————————• */
  public class AddParameter
  {
    readonly UndoEngine undoEngine = new UndoEngine();
      
    public void CompressDrive(Drive drive)
    {
      // TODO: trace SetAttributes all the way down to the lowest level, 
      // and add undoEngine as a parameter, then bubble up...
      drive.SetAttributes(FileAttributes.Compressed);
    }

    /// <summary>
    /// Calculates the montly payments for a purchased item, given 
    /// the interest rate (e.g., 8.5 for 8.5%), the purchase price,
    /// and the number of months for the loan.
    /// </summary>
    /// 
    /// <param name="loanTermMonths">The number of months for the loan.</param>
    /// <param name="interestRate">The yearly interest rate for the loan.</param>
    /// <param name="purchasePrice">The purchase price of the item.</param>
    public decimal CalculateMonthlyPayment(double loanTermMonths, double interestRate, double purchasePrice)
    {
      double payment;
      double amountFinanced = purchasePrice;
      double monthlyInterest = interestRate / 1200;
      double factor = monthlyInterest + monthlyInterest / (Math.Pow(monthlyInterest + 1, loanTermMonths) - 1);
      payment = amountFinanced * factor;
      return Math.Round((decimal)payment, 2);
    }

    public void TestPaymentCalculator(Loan testLoan)
    {
      // TODO: Add support for a down payment into the calculation.
      if (CalculateMonthlyPayment(testLoan.Months, testLoan.InterestRate, testLoan.ItemPrice) != testLoan.ExpectedMonthlyPayment)
        throw new Exception("Problem with payment calculator!");
    }

    public void TestPaymentCalculator()
    {
      if (CalculateMonthlyPayment(56, 7.5, 23500) != 498.65m)
        throw new Exception("Problem with payment calculator!");
      if (CalculateMonthlyPayment(72, 6.9, 18300) != 311.12m)
        throw new Exception("Problem with payment calculator!");
    }
    public UndoEngine UndoEngine
    {
      get
      {
        return undoEngine;
      }
    }
  }
}
