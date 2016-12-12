using System;
using System.Linq;
using System.Collections.Generic;

namespace AllCodeRush.Code.Types
{
	/* •—————————————————————————————————————————————————————————•
			Feature: Declare Struct
         
			Use Case: Generates a structure for a current reference.  
	 
			Available: When the caret is on a reference to a 
	    non-existent structure.
		 •—————————————————————————————————————————————————————————• */
	public class DeclareStruct
	{
		public DeclareStruct()
		{
			ShoppingCart Cart = new ShoppingCart();
			Cart.Add(new BasketItem() { Name = "Soda", Quantity = 15, DiscountMultiplier = 1.00 });
			Cart.Add(new BasketItem() { Name = "Chips", Quantity = 5, DiscountMultiplier = 0.20 });
			Cart.Add(new BasketItem() { Name = "Dip", Quantity = 5, DiscountMultiplier = 0.20 });
		}
	}
}
