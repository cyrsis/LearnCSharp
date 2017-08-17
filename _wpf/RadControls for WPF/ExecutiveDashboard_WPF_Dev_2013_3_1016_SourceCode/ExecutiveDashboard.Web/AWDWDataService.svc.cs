using System;
using System.Data.Services;
using System.Data.Services.Common;
using System.Globalization;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ExecutiveDashboard.Web
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class AWDWDataService : DataService<AdventureWorksDWAZ2008R2XLabsEntities>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            config.SetEntitySetAccessRule("*", EntitySetRights.AllRead);
            config.SetServiceOperationAccessRule("*", ServiceOperationRights.All);
            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2;

            //new DomainServices.AWDWDomainService().GetActualsByCountries(start, end);
            new DomainServices.AWDWDomainService().GetDailyActualsVsTargetsByProduct();
        }

        [WebGet]
        public IQueryable<SalesAmountExtract> GetActualsByCountries(string start, string end)
        {
            DateTime startDate = DateTime.Parse(start, CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.Parse(end, CultureInfo.InvariantCulture);
            using (DomainServices.AWDWDomainService service = new DomainServices.AWDWDomainService())
            {
                var data = service.GetActualsByCountries(startDate, endDate);
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
    }
}
