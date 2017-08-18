using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sixeyed.CarValet.LegacyServices.Entities
{
    public class Quote
    {
        public int VehicleId { get; set; }

        public string PostalCode { get; set; }

        public Product Product { get; set; }

        public List<ProductOption> Options { get; set; }

        public decimal Cost { get; set; }
    }
}