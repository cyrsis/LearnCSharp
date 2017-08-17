using System;
using AllCodeRush.Code.Conditionals.Support;

namespace AllCodeRush.Code.Conditionals
{
  /* •———————————————————————————————————————————————————————•
      Feature: Flatten Conditional
                                                            
      Use Case: Reduces the size (line count) of a conditional.
                                                            
      Availability: When the caret is on the "if" keyword of
      an if-statement that has more lines of code than 
      necessary.
    
      Related Refactorings: Add Else Statement, 
                            Combine Conditionals
           
      For more information on formatting code, see the "Code 
      Formatting" video.
     •———————————————————————————————————————————————————————• */

  public class FlattenConditional
  {
    public static bool IsValidCard(string creditCardNumber)
    {
      if (string.IsNullOrEmpty(creditCardNumber))
        return false;

      return true;
    }

    public static bool AnyTrue(bool a, bool b, bool c)
    {
      if (a || b || c)
        return true;
      else
        return false;
    }

    public static int AllTrue(bool a, bool b, bool c)
    {
      if (a && b && c)
        return 1;
      else
        return 0;
    }

    public static void RentMovie(bool parentalControls, int minAgeForThisMovie, Guid movieID, Customer customer)
    {
      if (!parentalControls || customer.Age > minAgeForThisMovie)
        if (!RentalFacility.IsDown())
          if (RentalFacility.HasMovie(movieID))
            if (RentalFacility.CustomerHasValidPaymentDetails(customer))
            {
              RentalFacility.ReserveMovie(movieID);
              customer.Charge(RentalFacility.GetMoviePrice(movieID));
              customer.RentMovie(RentalFacility.GetMovie(movieID), TimeSpan.FromHours(48));
            }
    }
  }
}
