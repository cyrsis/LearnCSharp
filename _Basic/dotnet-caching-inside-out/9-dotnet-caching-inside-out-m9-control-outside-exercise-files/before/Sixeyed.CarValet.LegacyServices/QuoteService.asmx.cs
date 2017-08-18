using Sixeyed.CarValet.Entities;
using Sixeyed.CarValet.LegacyServices.Contracts;
using Sixeyed.CarValet.LegacyServices.Entities;
using Sixeyed.Core.Caching;
using Sixeyed.Core.Containers.Interception.Cache;
using Sixeyed.Core.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web.Services;
using fx = Sixeyed.Core.Containers;

namespace Sixeyed.CarValet.LegacyServices
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class QuoteService : System.Web.Services.WebService
    {
        static QuoteService()
        {
            fx.Container.Register<QuoteService>(fx.Lifetime.Singleton);
        }

        [WebMethod]
        public GetQuotesResponse GetQuotes(GetQuotesRequest request)
        {
             return fx.Container.Get<QuoteService>().GetQuotesInternal(request);
        }

        [Cache(CacheType=CacheType.Disk)]
        protected virtual GetQuotesResponse GetQuotesInternal(GetQuotesRequest request)
        {
            Log.Debug("QuoteService.GetQuotesInternal called for vehicle ID: {0}, postal code: {1}", request.VehicleId, request.PostalCode);
            var productCodes = request.ProductCodes.Count() > 0 ? request.ProductCodes : Product.Defaults.Select(x=>x.ProductCode);
            var quotes = new List<Quote>();
            foreach (var code in productCodes)
            {
                var quote= new Quote();
                quote.VehicleId = request.VehicleId;
                quote.PostalCode = request.PostalCode;
                quote.Product = GetProduct(code);
                quote.Options = GetOptions(code);
                quote.Cost = CalculateCost(quote.Product.BasePrice, request.VehicleId, request.PostalCode);
                quotes.Add(quote);
            }
            var response = new GetQuotesResponse();
            response.Quotes = quotes;
            Log.Debug("QuoteService.GetQuotesInternal returning for vehicle ID: {0}, postal code: {1}", request.VehicleId, request.PostalCode);
            return response;
        }

        private decimal CalculateCost(decimal basePrice, int vehicleId, string postalCode)
        {
            Thread.Sleep(1000);
            var price = basePrice * (decimal)GetVehicleFactor(vehicleId);
            price = price *(decimal)GetPostalCodeFactor(postalCode);
            return Math.Round(price, 2);
        }

        private double GetVehicleFactor(int vehicleId)
        {
            return GetFactor("VID", vehicleId.ToString());
        }

        private double GetPostalCodeFactor(string postalCode)
        {
            return GetFactor("POC", postalCode.Substring(0,3));
        }

        private double GetFactor(string factorTypeCode, string appliesTo)
        {
            var factorAmount = 1.0;
            using (var entities = new PricingEntities())
            {
                var factor = entities.PricingFactors.FirstOrDefault
                    (x => x.PricingFactorType.PricingFactorTypeCode == factorTypeCode &&
                          x.AppliesTo == appliesTo);
                if (factor != null)
                {
                    factorAmount = factor.Factor;
                }
            }
            return factorAmount;
        }

        private List<ProductOption> GetOptions(string code)
        {
            var level = int.Parse(code.Substring(0,1));
            var options = new List<ProductOption>();
            for (int i=1; i<=level; i++)
            {
                options.AddRange(ProductOption.Defaults.Where(x=>x.OptionCode.StartsWith(i.ToString())));
            }
            return options;
        }

        private Product GetProduct(string code)
        {
            return Product.Defaults.Single(x => x.ProductCode == code); 
        }
    }
}
