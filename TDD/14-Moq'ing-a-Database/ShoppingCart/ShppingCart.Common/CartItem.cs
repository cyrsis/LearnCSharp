using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Common
{
    public class CartItem
    {
        public int Quantity { get; set; }
        public string Description { get; private set; }
        public decimal UnitPrice { get; private set; }
        public decimal Discount { get; private set; }

        public CartItem(int quantity, string description, decimal unitPrice)
        {
            Quantity = quantity;
            Description = description;
            UnitPrice = unitPrice;
        }

        public decimal GetItemPrice()
        {
            var price = (Quantity * UnitPrice) - Discount;

            return price < 0m ? 0m : price;
        }

        public void ApplyDiscount(decimal discountAmount)
        {
            Discount = discountAmount;
        }
    }
}
