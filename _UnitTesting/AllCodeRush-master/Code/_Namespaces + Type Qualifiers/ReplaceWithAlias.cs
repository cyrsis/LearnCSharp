using System;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
	/* •—————————————————————————————————————————————————————————•
	    Feature: Replace with Alias
         
	    Use Case: Expands the alias at the caret.
	 
			Available: When the edit cursor or caret is on a type or 
	    namespace alias. 

      See Also: Inline Alias
		 •—————————————————————————————————————————————————————————• */

	using Generic = System.Collections.Generic;

	public class ReplaceWithAlias
	{
		public void CreateBasket()
		{
			Generic.List<ShoppingBasketItem> list = new Generic.List<ShoppingBasketItem>();
			list.Add(new ShoppingBasketItem("Awesome UI Design - Mark Miller (Book)", 10));
			list.Add(new ShoppingBasketItem("C# in Depth- Jon Skeet (Book)", 10));

		}
	}
}
