using System;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
  /* •—————————————————————————————————————————————————————————•
      Feature: Inline Alias
         
      Use Case: Replaces all references to an aliased type 
      or namespace in the active document with the fully 
      qualified name of the type or the namespace.
	 
      Available: When the caret is on the alias declaration.

      See also: Replace with Alias
     •—————————————————————————————————————————————————————————• */

  using Generic = System.Collections.Generic;

	public class InlineAlias
	{
		public void CreateSampleOrder()
		{
			Generic.List<ShoppingBasketItem> list = new Generic.List<ShoppingBasketItem>();
			list.Add(new ShoppingBasketItem("CodeRush", 20));
			list.Add(new ShoppingBasketItem("DXperience Universal", 2));
			list.Add(new ShoppingBasketItem("DevExtreme", 5));
		}
	}
}
