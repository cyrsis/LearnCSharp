using System;

namespace AllCodeRush.Code.DeclarationInitialization
{
  public class Calculator
  {
    public static double GetTotalPrice(double unitPrice = 1, double quantity = 1, double percentDiscount = 0)
    {
      double discountMultiplier;
      if (percentDiscount > 0)
        discountMultiplier = 1 - percentDiscount / 100;
      else
        discountMultiplier = 1;
      return unitPrice * quantity * discountMultiplier;
    }
  }
}
