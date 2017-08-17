namespace ExecutiveDashboard.Web.DomainServices
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
    using ExecutiveDashboard.Web;
    using System.Collections;
    using System.Diagnostics;

    [EnableClientAccess()]
    public class AWDWDomainService : LinqToEntitiesDomainService<AdventureWorksDWAZ2008R2XLabsEntities>
    {
        [OutputCache(OutputCacheLocation.Server, duration: 60 * 60 * 12)]
        public IQueryable<SalesAmountExtract> GetActualsByCountries(DateTime start, DateTime end)
        {
            var actualsVsTotalsByCountries = from all in this.ObjectContext.SalesAmountExtractView
                                      where all.OrderDate > start && all.OrderDate <= end
                                      group all by all.Country into result
                                      select new
                                      {
                                          Country = result.Key,
                                          ActualAmount = result.Sum(x => x.ActualAmount),
                                          TargetAmount = result.Sum(x => x.TargetAmount)
                                      };

            var productsByCountriesList = actualsVsTotalsByCountries.ToList().Select(x => new SalesAmountExtract { Country = x.Country, ProductCategory = x.Country.GetHashCode().ToString(), ActualAmount = x.ActualAmount, TargetAmount = x.TargetAmount });
            var orderedResult = productsByCountriesList.OrderBy(k => k.Country, new CountryComparer()).AsQueryable();
            return orderedResult;
        }

        //[Query(IsDefault = true)]
        [OutputCache(OutputCacheLocation.Server, duration: 60 * 60 * 12)]
        public IQueryable<SalesAmountExtract> GetDailyActualsVsTargetsByProduct()
        {
            var data =
                        from all in this.ObjectContext.SalesAmountExtractView
                        group all by new { OrderDate = all.OrderDate, ProductCategory = all.ProductCategory } into result
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
    }

    public class CountryComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            string xToLower = x.ToLowerInvariant();
            string yToLower = y.ToLowerInvariant();

            Dictionary<string, int> countriesOrder = new Dictionary<string, int>()
            {
                { "germany", 0 },
                { "united states", 1 },
                { "australia", 2 },
                { "united kingdom", 3 },
                { "canada", 4 },
                { "france", 5 }
            };
            return countriesOrder[xToLower].CompareTo(countriesOrder[yToLower]);
        }
    }

    // Implements application logic using the AdventureWorksDWAZ2008R2XLabsEntities context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    //[EnableClientAccess()]
    //public class AWDWDomainService : LinqToEntitiesDomainService<AdventureWorksDWAZ2008R2XLabsEntities>
    //{
    //    [OutputCache(OutputCacheLocation.Server, duration: 60 * 60 * 12)]
    //    public IQueryable<SalesAmountExtract> GetSalesAmountsByProductCategories(DateTime start, DateTime end)
    //    {
    //        var actualSumsByCategories = from all in this.ObjectContext.FactInternetSales
    //                                     join dates in this.ObjectContext.DimDate on all.OrderDateKey equals dates.DateKey
    //                                     where dates.FullDateAlternateKey >= start && dates.FullDateAlternateKey < end
    //                                     join products in this.ObjectContext.DimProduct on all.ProductKey equals products.ProductKey
    //                                     join productSubCategories in this.ObjectContext.DimProductSubcategory on products.ProductSubcategoryKey equals productSubCategories.ProductSubcategoryKey
    //                                     join productCategories in this.ObjectContext.DimProductCategory on productSubCategories.ProductCategoryKey equals productCategories.ProductCategoryKey
    //                                     group new { sales = all, category = productCategories } by new { Key = productCategories.ProductCategoryKey, CategoryName = productCategories.EnglishProductCategoryName } into result
    //                                     select new { Value = result.Sum(r => r.sales.SalesAmount), CategoryKey = result.Key.Key, CategoryName = result.Key.CategoryName };

    //        var actualSumsWithNullProductCategory = from all in this.ObjectContext.FactInternetSales
    //                               join dates in this.ObjectContext.DimDate on all.OrderDateKey equals dates.DateKey
    //                               where dates.FullDateAlternateKey >= start && dates.FullDateAlternateKey < end
    //                               join products in this.ObjectContext.DimProduct on all.ProductKey equals products.ProductKey
    //                               where products.ProductSubcategoryKey == null
    //                               select all;

    //        var targetSumsByCategories = from all in this.ObjectContext.FactInternetSalesQuota
    //                                     join dates in this.ObjectContext.DimDate on all.OrderDateKey equals dates.DateKey
    //                                     where dates.FullDateAlternateKey >= start && dates.FullDateAlternateKey < end
    //                                     group all by all.ProductCategoryKey into results
    //                                     orderby results.Key
    //                                     select new { CategoryKey = results.Key, Value = results.Sum(r => r.SalesAmount) };

    //        var actualPlusTarget = from actuals in actualSumsByCategories
    //                               join targets in targetSumsByCategories on actuals.CategoryKey equals targets.CategoryKey
    //                               orderby actuals.CategoryName
    //                               select new SalesAmountExtract { ActualValue = actuals.Value, TargetValue = targets.Value, ProductCategory = actuals.CategoryName };


    //        var actualPlusTargetList = actualPlusTarget.ToList();
    //        if (actualSumsWithNullProductCategory.Count() > 0)
    //        {
    //            actualPlusTargetList.First().ActualValue += actualSumsWithNullProductCategory.Sum(a => a.SalesAmount);
    //        }

    //        var valueToReturn = new List<SalesAmountExtract>
    //        {
    //            actualPlusTargetList.SingleOrDefault(sae => sae.ProductCategory.Equals("bikes", StringComparison.OrdinalIgnoreCase)),
    //            actualPlusTargetList.SingleOrDefault(sae => sae.ProductCategory.Equals("components", StringComparison.OrdinalIgnoreCase)),
    //            actualPlusTargetList.SingleOrDefault(sae => sae.ProductCategory.Equals("clothing", StringComparison.OrdinalIgnoreCase)),
    //            actualPlusTargetList.SingleOrDefault(sae => sae.ProductCategory.Equals("accessories", StringComparison.OrdinalIgnoreCase)),
    //        }.Where(sae => sae != null).AsQueryable();

    //        return valueToReturn;
    //    }

    //    [OutputCache(OutputCacheLocation.Server, duration: 60 * 60 * 12)]
    //    public IQueryable<SalesAmountExtract> GetSalesAmountsByCountries(DateTime start, DateTime end)
    //    {
    //        var actualSumsByCountries = from all in this.ObjectContext.FactInternetSales
    //                                    join dates in this.ObjectContext.DimDate on all.OrderDateKey equals dates.DateKey
    //                                    where dates.FullDateAlternateKey >= start && dates.FullDateAlternateKey < end
    //                                    join countries in this.ObjectContext.DimSalesTerritory on all.SalesTerritoryKey equals countries.SalesTerritoryKey
    //                                    group new { sales = all, country = countries.SalesTerritoryCountry }by countries.SalesTerritoryCountry into result
    //                                    orderby result.Key
    //                                    select new { Country = result.Key, Value = result.Sum(r => r.sales.SalesAmount) };
            
    //        var targetSumsByCountries = from targets in this.ObjectContext.FactInternetSalesQuota
    //                                    join dates in this.ObjectContext.DimDate on targets.OrderDateKey equals dates.DateKey
    //                                    where dates.FullDateAlternateKey >= start && dates.FullDateAlternateKey < end
    //                                    join countries in this.ObjectContext.DimSalesTerritory on targets.SalesTerritoryKey equals countries.SalesTerritoryKey
    //                                    group new { country = countries.SalesTerritoryCountry, targets = targets }by countries.SalesTerritoryCountry into results
    //                                    orderby results.Key
    //                                    select new { CategoryKey = results.Key, Value = results.Sum(r => r.targets.SalesAmount) };
            
    //        var actualPlusTarget = from actuals in actualSumsByCountries
    //                               join targets in targetSumsByCountries on actuals.Country equals targets.CategoryKey
    //                               select new SalesAmountExtract { ActualValue = actuals.Value, TargetValue = targets.Value, ProductCategory = actuals.Country };
            
    //        return actualPlusTarget;
    //    }

    //    [OutputCache(OutputCacheLocation.Server, duration: 60 * 60 * 12)]
    //    public IQueryable<SalesAmountExtract> GetDailySalesAmounts()
    //    {
    //        var allInternetSales = from internetSales in this.ObjectContext.FactInternetSales
    //                               join dates in this.ObjectContext.DimDate on internetSales.OrderDateKey equals dates.DateKey
    //                               group new { dates, internetSales } by dates.DateKey into result
    //                               orderby result.Key
    //                               select new { Value = result.Sum(r => r.internetSales.SalesAmount), Date = result.Key };

    //        var allTargetSales = from targetSales in this.ObjectContext.FactInternetSalesQuota
    //                             join dates in this.ObjectContext.DimDate on targetSales.OrderDateKey equals dates.DateKey
    //                             group new { dates, targetSales } by targetSales.OrderDateKey into result
    //                             orderby result.Key
    //                             select new { Value = result.Sum(r => r.targetSales.SalesAmount), Date = result.Key };

    //        var actualsPlusTargets = from allActuals in allInternetSales
    //                                 join allTargets in allTargetSales on allActuals.Date equals allTargets.Date into catalog
    //                                 from catItems in catalog.DefaultIfEmpty()
    //                                 select new
    //                                 {
    //                                     StartDate = allActuals.Date,
    //                                     ActualValue = allActuals.Value,
    //                                     TargetValue = catItems.Value == null ? 0 : catItems.Value
    //                                 };

    //        var a = from all in actualsPlusTargets
    //                join dates in this.ObjectContext.DimDate on all.StartDate equals dates.DateKey
    //                select new SalesAmountExtract
    //                {
    //                    StartDate = dates.FullDateAlternateKey,
    //                    ActualValue = all.ActualValue,
    //                    TargetValue = all.TargetValue,
    //                    ProductCategory = "",
    //                    ID = dates.DateKey
    //                };

    //        return a;
    //    }

    //    [OutputCache(OutputCacheLocation.Server, duration: 60 * 60 * 12)]
    //    public IQueryable<SalesAmountExtract> GetMonthlySalesAmounts()
    //    {
    //        var allInternetSales = from internetSales in this.ObjectContext.FactInternetSales
    //                               join dates in this.ObjectContext.DimDate on internetSales.OrderDateKey equals dates.DateKey
    //                               group new { dates, internetSales } by dates.DateKey into result
    //                               orderby result.Key
    //                               select new { Sum = result.Sum(r => r.internetSales.SalesAmount), DateKey = result.Key };

    //        var allSalesForPeriods = from dayGroups in allInternetSales
    //                                 join dates in this.ObjectContext.DimDate on dayGroups.DateKey equals dates.DateKey
    //                                 group new { dates, dayGroups } by dates.MonthNumberOfYear + dates.CalendarYear * 12 into result
    //                                 orderby result.Key
    //                                 select new { Value = result.Sum(r => r.dayGroups.Sum), Date = result.FirstOrDefault().dates.DateKey };

    //        var allTargetSales = from targetSales in this.ObjectContext.FactInternetSalesQuota
    //                             join dates in this.ObjectContext.DimDate on targetSales.OrderDateKey equals dates.DateKey
    //                             group new { dates, targetSales } by targetSales.OrderDateKey into result
    //                             orderby result.Key
    //                             select new { Value = result.Sum(r => r.targetSales.SalesAmount), Date = result.Key };

    //        var actualsPlusTargets = from allActuals in allSalesForPeriods
    //                                 join allTargets in allTargetSales on allActuals.Date equals allTargets.Date into catalog
    //                                 from catItems in catalog.DefaultIfEmpty()
    //                                 select new
    //                                 {
    //                                     StartDate = allActuals.Date,
    //                                     ActualValue = allActuals.Value,
    //                                     TargetValue = catItems.Value == null ? 0 : catItems.Value
    //                                 };

    //        var a = from all in actualsPlusTargets
    //                join dates in this.ObjectContext.DimDate on all.StartDate equals dates.DateKey
    //                select new SalesAmountExtract
    //                {
    //                    StartDate = dates.FullDateAlternateKey,
    //                    ActualValue = all.ActualValue,
    //                    TargetValue = all.TargetValue * 30,
    //                    ProductCategory = "",
    //                    ID = dates.DateKey
    //                };

    //        return a;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'DimAccount' query.
    //    public IQueryable<DimAccount> GetDimAccount()
    //    {
    //        return this.ObjectContext.DimAccount;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'DimCurrency' query.
    //    public IQueryable<DimCurrency> GetDimCurrency()
    //    {
    //        return this.ObjectContext.DimCurrency;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'DimCustomer' query.
    //    public IQueryable<DimCustomer> GetDimCustomer()
    //    {
    //        return this.ObjectContext.DimCustomer;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'DimDate' query.
    //    public IQueryable<DimDate> GetDimDate()
    //    {
    //        return this.ObjectContext.DimDate;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'DimDepartmentGroup' query.
    //    public IQueryable<DimDepartmentGroup> GetDimDepartmentGroup()
    //    {
    //        return this.ObjectContext.DimDepartmentGroup;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'DimEmployee' query.
    //    public IQueryable<DimEmployee> GetDimEmployee()
    //    {
    //        return this.ObjectContext.DimEmployee;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'DimGeography' query.
    //    public IQueryable<DimGeography> GetDimGeography()
    //    {
    //        return this.ObjectContext.DimGeography;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'DimOrganization' query.
    //    public IQueryable<DimOrganization> GetDimOrganization()
    //    {
    //        return this.ObjectContext.DimOrganization;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'DimProduct' query.
    //    public IQueryable<DimProduct> GetDimProduct()
    //    {
    //        return this.ObjectContext.DimProduct;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'DimProductCategory' query.
    //    public IQueryable<DimProductCategory> GetDimProductCategory()
    //    {
    //        return this.ObjectContext.DimProductCategory;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'DimProductSubcategory' query.
    //    public IQueryable<DimProductSubcategory> GetDimProductSubcategory()
    //    {
    //        return this.ObjectContext.DimProductSubcategory;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'DimPromotion' query.
    //    public IQueryable<DimPromotion> GetDimPromotion()
    //    {
    //        return this.ObjectContext.DimPromotion;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'DimReseller' query.
    //    public IQueryable<DimReseller> GetDimReseller()
    //    {
    //        return this.ObjectContext.DimReseller;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'DimSalesReason' query.
    //    public IQueryable<DimSalesReason> GetDimSalesReason()
    //    {
    //        return this.ObjectContext.DimSalesReason;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'DimSalesTerritory' query.
    //    public IQueryable<DimSalesTerritory> GetDimSalesTerritory()
    //    {
    //        return this.ObjectContext.DimSalesTerritory;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'DimScenario' query.
    //    public IQueryable<DimScenario> GetDimScenario()
    //    {
    //        return this.ObjectContext.DimScenario;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'FactAdditionalInternationalProductDescription' query.
    //    public IQueryable<FactAdditionalInternationalProductDescription> GetFactAdditionalInternationalProductDescription()
    //    {
    //        return this.ObjectContext.FactAdditionalInternationalProductDescription;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'FactCallCenter' query.
    //    public IQueryable<FactCallCenter> GetFactCallCenter()
    //    {
    //        return this.ObjectContext.FactCallCenter;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'FactCurrencyRate' query.
    //    public IQueryable<FactCurrencyRate> GetFactCurrencyRate()
    //    {
    //        return this.ObjectContext.FactCurrencyRate;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'FactFinance' query.
    //    public IQueryable<FactFinance> GetFactFinance()
    //    {
    //        return this.ObjectContext.FactFinance;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'FactInternetSales' query.
    //    public IQueryable<FactInternetSales> GetFactInternetSales()
    //    {
    //        return this.ObjectContext.FactInternetSales;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'FactInternetSalesReason' query.
    //    public IQueryable<FactInternetSalesReason> GetFactInternetSalesReason()
    //    {
    //        return this.ObjectContext.FactInternetSalesReason;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'FactResellerSales' query.
    //    public IQueryable<FactResellerSales> GetFactResellerSales()
    //    {
    //        return this.ObjectContext.FactResellerSales;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'FactSalesQuota' query.
    //    public IQueryable<FactSalesQuota> GetFactSalesQuota()
    //    {
    //        return this.ObjectContext.FactSalesQuota;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'FactSurveyResponse' query.
    //    public IQueryable<FactSurveyResponse> GetFactSurveyResponse()
    //    {
    //        return this.ObjectContext.FactSurveyResponse;
    //    }

    //    // TODO:
    //    // Consider constraining the results of your query method.  If you need additional input you can
    //    // add parameters to this method or create additional query methods with different names.
    //    // To support paging you will need to add ordering to the 'ProspectiveBuyer' query.
    //    public IQueryable<ProspectiveBuyer> GetProspectiveBuyer()
    //    {
    //        return this.ObjectContext.ProspectiveBuyer;
    //    }
    //}
}
