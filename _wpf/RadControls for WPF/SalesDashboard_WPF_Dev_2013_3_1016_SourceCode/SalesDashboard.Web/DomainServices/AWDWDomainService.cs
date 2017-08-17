using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System;
namespace SalesDashboard.Web
{
    public partial class OrdersDetails
    {
        [Key]
        [DataMember]
        public int ID
        {
            get
            {
                return this.SalesOrderNumber.GetHashCode();

            }

            set
            {
                //intentionally empty
            }
        }

        //#if !SILVERLIGHT
        //        [DataMember]
        //        public DateTime OrderDate { get; set; }

        //        [DataMember]
        //        public int ItemsSold { get; set; }

        //        [DataMember]
        //        public decimal SalesAmount { get; set; }

        //        [DataMember]
        //        public string Country { get; set; }

        //        [DataMember]
        //        public int ProductsEnum { get; set; }
        //#endif
    }
}

namespace SalesDashboard.Web.DomainServices
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using SalesDashboard.Web;
    using System.Collections;
    using System.Diagnostics;
    using System.Data.Objects.DataClasses;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    using System.Data.Objects;

    // Implements application logic using the AdventureWorksDWAZ2008R2XLabsEntities context.
    [EnableClientAccess()]
    public class AWDWDomainService : LinqToEntitiesDomainService<AdventureWorksDWAZ2008R2XLabsEntities>
    {
        private static IEnumerable<OrdersDetails> orderDetailsCache;

        [OutputCache(OutputCacheLocation.Server, duration: 60 * 60 * 12)]
        public IQueryable<OrdersDetails> GetOrdersDataForAllCustomersForPeriod(DateTime start, DateTime end)
        {
            if (orderDetailsCache == null)
            {
                orderDetailsCache = this.GetOrdersDetails().ToList();
            }

            return orderDetailsCache.AsQueryable().Where(od => od.OrderDate >= start && od.OrderDate < end);
        }

        [OutputCache(OutputCacheLocation.Server, duration: 60 * 60 * 12)]
        public IQueryable<SalesAmountExtract> GetActualsByCountriesAndProductCategories(DateTime start, DateTime end)
        {
            var productsByCountries = from all in this.ObjectContext.SalesAmountExtractView
                                      where all.OrderDate > start && all.OrderDate <= end
                                      group all by new { Country = all.Country, ProductCategory = all.ProductCategory } into result
                                      select new 
                                      {
                                          Country = result.Key.Country,
                                          ProductCategory = result.Key.ProductCategory,
                                          ActualAmount = result.Sum(x => x.ActualAmount)
                                      };

            var productsByCountriesList = productsByCountries.ToList().Select(x => new SalesAmountExtract { Country = x.Country, ProductCategory = x.ProductCategory, ActualAmount = x.ActualAmount });
            return productsByCountriesList.AsQueryable();
        }

        //[Query(IsDefault = true)]
        [OutputCache(OutputCacheLocation.Server, duration: 60 * 60 * 12)]
        public IQueryable<SalesAmountExtract> GetDailyActualsVsTargetsByProduct()
        {
            var data =
                        from all in this.ObjectContext.SalesAmountExtractView
                        group all by new { OrderDate = all.OrderDate, ProductCategory = all.ProductCategory }into result
                        orderby result.Key.OrderDate
                        select new
                        {
                            TargetAmount = result.Sum(x => x.TargetAmount),
                            OrderDate = result.Key.OrderDate,
                            ProductCategory = result.Key.ProductCategory,
                            ActualAmount = result.Sum(x => x.ActualAmount)
                        };
            var dataList = data.ToList().Select(item => new SalesAmountExtract
            {
                TargetAmount = item.TargetAmount,
                OrderDate = item.OrderDate,
                ProductCategory = item.ProductCategory,
                ActualAmount = item.ActualAmount,
                Country = string.Empty //ria services throws error when country is null, fixes "Entity 'SalesAmountExtract .....' cannot be added to cache because it doesn't have a valid identity" message
            });
            return dataList.AsQueryable();
        }

        //[Query(IsDefault = true)]
        [OutputCache(OutputCacheLocation.Server, duration: 60 * 60 * 12)]
        public IQueryable<OrdersDetails> GetOrdersDetails()
        {
            return this.ObjectContext.OrdersDetails;
        }
    }
}
