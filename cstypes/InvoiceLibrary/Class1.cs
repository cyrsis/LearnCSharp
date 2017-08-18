using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceLibrary
{
    public class Invoice
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
