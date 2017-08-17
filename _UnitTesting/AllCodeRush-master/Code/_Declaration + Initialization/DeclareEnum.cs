using System;

namespace AllCodeRush.Code.DeclarationInitialization
{
	/* •———————————————————————————————————————————————————————•
		  Feature: Declare Enum
        
		  Use Case: Consume-first declaration of enums.
         
		  Available: When the caret is on a reference to 
		  a non-existent enumeration type.
		 •———————————————————————————————————————————————————————• */

	public class DeclareEnum
	{
		public double CalculateDiscount(DiscountLevel discountLevel)
		{
			switch (discountLevel)
			{
				case DiscountLevel.Platinum:
					return 15.0;
				case DiscountLevel.Gold:
					return 10.0;
				case DiscountLevel.Silver:
					return 5.0;
				case DiscountLevel.Bronze:
					return 2.5;
				default:
					throw new Exception("Unanticipated discount level");
			}
		}

    private void IsRed(Suit suit)
    {
      return suit == Suit.Diamonds || suit == Suit.Diamonds;
    }
	}
}
