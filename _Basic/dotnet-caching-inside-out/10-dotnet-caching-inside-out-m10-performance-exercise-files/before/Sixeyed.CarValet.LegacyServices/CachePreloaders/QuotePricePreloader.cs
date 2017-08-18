using Sixeyed.CarValet.Entities;
using Sixeyed.CarValet.LegacyServices.Contracts;
using Sixeyed.Core.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sixeyed.CarValet.LegacyServices.CachePreloaders
{
    public static class QuotePricePreloader
    {
        public static void Run()
        {
            try
            {
                Log.Debug("QuotePricePreloader.Run starting");
                var ids = new List<int>();
                using (var entities = new VehicleEntities())
                {
                    ids.AddRange(entities.Vehicles.Select(x => x.VehicleId));
                }
                var postalCodes = new List<string>();
                using (var pricing = new PricingEntities())
                {
                    postalCodes.AddRange(pricing.PricingFactors.Where(x => x.PricingFactorType.PricingFactorTypeCode == "POC").Select(x => x.AppliesTo));
                }
                var quoteTasks = new List<Task>();
                var stopwatch = Stopwatch.StartNew();
                foreach (var id in ids)
                {
                    foreach (var postalCode in postalCodes)
                    {
                        var tId = id;
                        var tPostalCode = postalCode;
                        quoteTasks.Add(Task.Factory.StartNew(() => PreloadQuotePrice(tId, tPostalCode)));
                    }
                }
                Log.Debug("QuotePricePreloader.Run fetching prices for: {0} quotes", quoteTasks.Count);
                Task.WaitAll(quoteTasks.ToArray());
                Log.Debug("QuotePricePreloader.Run fetched prices for: {0} quotes, in: {1}ms", quoteTasks.Count, stopwatch.ElapsedMilliseconds);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "QuotePricePreloader.Run failed");
            }
        }

        private static void PreloadQuotePrice(int vehicleId, string postalCode)
        {
            try
            {
                var request = new GetQuotesRequest()
                {
                    VehicleId = vehicleId,
                    PostalCode = postalCode,
                    ProductCodes = new List<string>()
                };
                var service = new QuoteService();
                service.GetQuotes(request);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "QuotePricePreloader.PreloadQuotePrice failed for vehicleId: {0}, postalCode: {1}", vehicleId, postalCode);
            }
        }
    }
}