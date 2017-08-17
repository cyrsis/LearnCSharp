using System.Collections.Generic;
using System.Linq;
#if SILVERLIGHT
using SalesAmountExtract = ExecutiveDashboard.Web.SalesAmountExtract;

#else
using SalesAmountExtract = ExecutiveDashboard.AWDWDomainService.SalesAmountExtract;
#endif

namespace ExecutiveDashboard
{
    public class SalesInfoGrouping
    {
        public string Country { get; set; }

        public decimal TotalValue { get; set; }

        public IEnumerable<SalesAmountExtract> SalesInfos { get; set; }

        public static IEnumerable<SalesInfoGrouping> CreateFromSalesAmountExtractCollection(IEnumerable<SalesAmountExtract> collection)
        {
            var a = (from all in collection
                     group all by all.Country into result
                     orderby result.Key
                     select new SalesInfoGrouping
                     {
                         Country = result.Key,
                         TotalValue = result.Sum(x => x.ActualAmount),
                         SalesInfos = from all in result
                                      select new SalesAmountExtract
                                      {
                                          ActualAmount = all.ActualAmount,
                                          ProductCategory = all.ProductCategory ?? "Components", // return components if null since the same is hardcoded in the DB
                                          Country = all.Country
                                      }
                     }).ToList();
            return a;
        }
    }
}