using System;
using System.Collections.Generic;

namespace Sixeyed.SpecFlowItAll.Domain.Model
{
    public partial class Supplier
    {
        public Supplier()
        {
            this.Products = new List<Product>();
        }

        public int SupplierId { get; set; }
        public string Name { get; set; }
        public int ReorderType { get; set; }
        public string ReorderAddress { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
