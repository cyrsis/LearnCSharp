using Sixeyed.CarValet.Api.ServiceAgents.Asmx.Quotes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sixeyed.CarValet.Api.Models
{
    public class QuoteModel
    {
        public int VehicleId { get; set; }

        public string PostalCode { get; set; }

        public string ProductName { get; set; }

        public IEnumerable<string> Options { get; set; }

        public decimal Cost { get; set; }

        public static QuoteModel FromServiceEntity(Quote quote)
        {
            return new QuoteModel()
            {
                VehicleId = quote.VehicleId,
                PostalCode = quote.PostalCode,
                ProductName = quote.Product.ProductName,
                Options = quote.Options.Select(x => x.OptionName),
                Cost = quote.Cost
            };
        }
    }
}