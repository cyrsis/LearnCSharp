using System;
using System.Collections.Generic;
using System.Linq;

namespace Commerce.Engine.Entities
{
    public class Product
    {
        public int Sku { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
    }
}