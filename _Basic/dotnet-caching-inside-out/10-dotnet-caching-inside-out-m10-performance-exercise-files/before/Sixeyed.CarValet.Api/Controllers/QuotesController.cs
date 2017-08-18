using Sixeyed.CarValet.Api.ActionFilters;
using Sixeyed.CarValet.Api.Models;
using Sixeyed.CarValet.Api.ServiceAgents;
using Sixeyed.CarValet.Api.ServiceAgents.Asmx.Quotes;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace Sixeyed.CarValet.Api.Controllers
{
    public class QuotesController : ApiController
    {
        //7 days in private cache, 1 day in public cache:
        [CacheControl(MaxAgeSeconds = 604800, SharedMaxAgeSeconds = 86400)]
        [ComputeETag]
        public IEnumerable<QuoteModel> GetQuotes(int vehicleId, string postalCode)
        {
            var request = new GetQuotesRequest() 
            { 
                VehicleId = vehicleId, 
                PostalCode = postalCode
            };
            var response = ServiceAgent.Quotes.GetQuotes(request);
            var quotes = new List<Quote>(response.Quotes);
            return quotes.ConvertAll<QuoteModel>(new Converter<Quote, QuoteModel>(QuoteModel.FromServiceEntity));
        }
    }
}