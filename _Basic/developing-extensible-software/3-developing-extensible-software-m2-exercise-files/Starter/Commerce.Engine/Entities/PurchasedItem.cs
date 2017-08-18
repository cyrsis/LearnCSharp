using System;
using System.Collections.Generic;
using System.Linq;

namespace Commerce.Engine.Entities
{
    public class PurchasedItem
    {
        public int Sku { get; set; }
        public double PurchasePrice { get; set; }
        public DateTime PurchasedOn { get; set; }
    }
}
