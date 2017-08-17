using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.NamespacesTypeQualifiers
{
	public class ShoppingBasketItem
	{
		private readonly string _itemName;
		private readonly int _count;
		public ShoppingBasketItem(string ItemName, int Count = 1)
		{
			_count = Count;
			_itemName = ItemName;			
		}
	}
}
