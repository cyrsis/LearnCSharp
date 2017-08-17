using System;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Create Case Blocks From Enum
        
			Use Case: Generates Switch/Select statements for each 
      element of the enum at the caret.
         
			Available: When the caret is placed on a reference to an 
			enum.
		 •———————————————————————————————————————————————————————• */

  public class CreateCaseBlocksFromEnum
	{
		private enum DiscountLevel
		{
			Platinum,
			Gold,
			Silver,
			Bronze
		}

		private void OfferDiscount(DiscountLevel discount)
		{
		}

	}
}
