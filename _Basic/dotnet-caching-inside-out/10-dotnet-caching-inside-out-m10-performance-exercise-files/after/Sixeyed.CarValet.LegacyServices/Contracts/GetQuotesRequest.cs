using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sixeyed.CarValet.LegacyServices.Contracts
{
    public class GetQuotesRequest
    {
        public int VehicleId { get; set; }

        public string PostalCode { get; set; }

        public List<string> ProductCodes { get; set; }
    }
}