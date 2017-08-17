using System;

namespace AllCodeRush.Code.Methods
{
  /* •———————————————————————————————————————————————————————•
      Feature: Extract Method to Type
          
      Use Case: Extracts the selected code to the specified 
      type, inserting appropriate calling code into the 
      source method or property.
           
      Available: When a contiguous block of code is selected
      that includes one or more dot-delimited member calls 
      into a type or instance declared in the solution.
           
      See also: Extract Method
     •———————————————————————————————————————————————————————• */

  public class ExtractMethodToType
  {
    public static decimal CalculateTax(ShoppingCart shoppingCart, decimal taxRate)
    {
      decimal total = 0;
      foreach (Item item in shoppingCart.Items)
      {
        decimal taxableItemTotal;
        
        if (item.IsTaxable)
          taxableItemTotal = item.Cost * item.Quantity;
        else 
          taxableItemTotal = 0;

        total += taxableItemTotal;
      }
      
      return taxRate * total;
    }
  }
}
