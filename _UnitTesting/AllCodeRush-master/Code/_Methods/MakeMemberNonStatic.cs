using System;

namespace AllCodeRush.Code.Methods
{
	/* •———————————————————————————————————————————————————————•
			Feature: Make Member Non-Static
        
			Use Case: Makes a static member an instance member and 
      updates all references accordingly.
         
			Available: When the caret is on a static method 
      declaration.
        
			See also: Make Member Static
		 •———————————————————————————————————————————————————————• */

	public class MakeMemberNonStatic
	{
		public static decimal GetCartTotal(Cart cart)
		{
			decimal total = 0;
			foreach (CartEntry entry in cart.Items)
			{
				total += entry.Value * entry.Quantity;
			}
			return total;
		}
	}
}
