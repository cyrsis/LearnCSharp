using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllCodeRush.Code.Methods
{
	public class Cart
	{
		public IEnumerable<CartEntry> Items { get; set; }
		public Cart()
		{
		}
	}
}
