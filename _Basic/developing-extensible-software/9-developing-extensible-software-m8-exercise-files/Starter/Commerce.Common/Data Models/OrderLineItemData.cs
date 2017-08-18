using System;
using System.Collections.Generic;
using System.Linq;

namespace Commerce.Common.DataModels
{
    public class OrderLineItemData
    {
        public int Sku { get; set; }
        public double PurchasePrice { get; set; }
        public int Quantity { get; set; }
    }
}
