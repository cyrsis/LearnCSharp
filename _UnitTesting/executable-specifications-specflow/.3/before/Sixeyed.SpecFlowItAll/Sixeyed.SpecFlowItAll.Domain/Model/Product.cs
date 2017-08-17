using System;
using System.Collections.Generic;

namespace Sixeyed.SpecFlowItAll.Domain.Model
{
    public partial class Product
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int StockCount { get; set; }
        public bool IsAvailable { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
