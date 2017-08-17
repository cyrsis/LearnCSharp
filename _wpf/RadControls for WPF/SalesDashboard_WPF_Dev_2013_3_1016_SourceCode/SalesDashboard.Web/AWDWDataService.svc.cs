using System;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Globalization;

namespace SalesDashboard.Web
{
    [ServiceBehavior(IncludeExceptionDetailInFaults=true)]
    public class AWDWDataService : DataService<AdventureWorksDWAZ2008R2XLabsEntities>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);
            config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;
        }
        
        [WebGet]
        public IQueryable<OrdersDetails> GetOrdersDataForAllCustomersForPeriod(string start, string end)
        {
            DateTime startD = DateTime.Parse(start, CultureInfo.InvariantCulture);
            DateTime endD = DateTime.Parse(end, CultureInfo.InvariantCulture);
            using (DomainServices.AWDWDomainService service = new DomainServices.AWDWDomainService())
            {
                IQueryable<OrdersDetails> data = service.GetOrdersDataForAllCustomersForPeriod(startD, endD).ToList().AsQueryable();
                return data;
            }
        }

        [WebGet]
        public IQueryable<SalesAmountExtract> GetActualsByCountriesAndProductCategories(string start, string end)
        {
            DateTime startDate = DateTime.Parse(start, CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.Parse(end, CultureInfo.InvariantCulture);
            using (DomainServices.AWDWDomainService service = new DomainServices.AWDWDomainService())
            {
                var data = service.GetActualsByCountriesAndProductCategories(startDate, endDate);
                return data;
            }
        }

        [WebGet]
        public IQueryable<SalesAmountExtract> GetDailyActualsVsTargetsByProduct()
        {
            using (DomainServices.AWDWDomainService service = new DomainServices.AWDWDomainService())
            {
                var data = service.GetDailyActualsVsTargetsByProduct();
                return data;
            }
        }

        [WebGet]
        public IQueryable<OrdersDetails> GetOrdersDetails()
        {
            using (DomainServices.AWDWDomainService service = new DomainServices.AWDWDomainService())
            {
                var data = service.GetOrdersDetails();
                return data;
            }
        }
    }
}
