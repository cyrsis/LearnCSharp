using Sixeyed.CarValet.LegacyServices.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sixeyed.CarValet.LegacyServices.Contracts
{
    public class GetQuotesResponse
    {
        public List<Quote> Quotes { get; set; }
    }
}