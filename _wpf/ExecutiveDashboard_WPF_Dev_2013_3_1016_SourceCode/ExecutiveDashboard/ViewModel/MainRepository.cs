using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
#if SILVERLIGHT
using System.ServiceModel.DomainServices.Client;
using ExecutiveDashboard.Web;
using AWDWContext = ExecutiveDashboard.Web.DomainServices.AWDWDomainContext;
#else
using System.Windows.Threading;
using System.Data.Services.Client;
using ExecutiveDashboard.AWDWDomainService;
using SalesAmountExtract = ExecutiveDashboard.AWDWDomainService.SalesAmountExtract;
using AWDWContext = ExecutiveDashboard.AWDWDomainService.AdventureWorksDWAZ2008R2XLabsEntities;
#endif

namespace ExecutiveDashboard
{
    public class MainRepository : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool isOrdersDataForAllCustomersForPeriodLoading;
        private bool isActualsByCountriesLoading;
        private bool isDailyActualsVsTargetsByProductLoading;

        public bool IsOrdersDataForAllCustomersForPeriodLoading
        {
            get { return this.isOrdersDataForAllCustomersForPeriodLoading; }
            set
            {
                this.isOrdersDataForAllCustomersForPeriodLoading = value;
                this.OnPropertyChanged("IsOrdersDataForAllCustomersForPeriodLoading");
            }
        }
        
        public bool IsActualsByCountriesLoading
        {
            get { return this.isActualsByCountriesLoading; }
            set
            {
                this.isActualsByCountriesLoading = value;
                this.OnPropertyChanged("IsActualsByCountriesLoading");
            }
        }

        public bool IsDailyActualsVsTargetsByProductLoading
        {
            get { return this.isDailyActualsVsTargetsByProductLoading; }
            set
            {
                this.isDailyActualsVsTargetsByProductLoading = value;
                this.OnPropertyChanged("IsDailyActualsVsTargetsByProductLoading");
            }
        }

#if !SILVERLIGHT        
        
        static MainRepository()
        {
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                string urlSource = System.Configuration.ConfigurationManager.AppSettings["DataServiceURL_DemosTelerikCom"];
                context = new AWDWContext(new Uri(urlSource));
            }
            else
            {
                string urlSource = System.Configuration.ConfigurationManager.AppSettings["DataServiceURL_Localhost"];
                context = new AWDWContext(new Uri(urlSource));
            }
        }

        private static readonly AWDWContext context;

        private static IAsyncResult actualsByCountriesLoadOperation;
        private static IAsyncResult dailyActualsVsTargetsByProductLoadOperation;

        private readonly static Dictionary<IAsyncResult, bool> cancelledOperations = new Dictionary<IAsyncResult, bool>();

        public void GetActualsByCountries(DateTime start, DateTime end, Action<IEnumerable<SalesAmountExtract>> completedCallback)
        {
            var query = context.CreateQuery<SalesAmountExtract>("GetActualsByCountries")
                               .AddQueryOption("start", StringApostropheWrapperHelper.WrapWithApostrophes(start.ToString()))
                               .AddQueryOption("end", StringApostropheWrapperHelper.WrapWithApostrophes(end.ToString()));

            if (this.IsActualsByCountriesLoading)
            {
                lock (cancelledOperations)
                {
                    cancelledOperations.Add(actualsByCountriesLoadOperation, true);
                    context.CancelRequest(actualsByCountriesLoadOperation);
                }
            }

            AsyncCallback callback = (args) =>
            {
                lock (cancelledOperations)
                {
                    if (cancelledOperations.ContainsKey(args))
                    {
                        cancelledOperations.Remove(args);
                        return;
                    }
                }
                System.Windows.Application.Current.Dispatcher.BeginInvoke(
                    new Action(() =>
                    {
                        this.IsActualsByCountriesLoading = false;

                        IEnumerable<SalesAmountExtract> result = (args.AsyncState as DataServiceQuery<SalesAmountExtract>).EndExecute(args);
                        completedCallback(result.ToList());
                    }));
            };

            this.IsActualsByCountriesLoading = true;
            actualsByCountriesLoadOperation = query.BeginExecute(callback, query);
        }

        public void GetDailyActualsVsTargetsByProduct(Action<IEnumerable<SalesAmountExtract>> completedCallback)
        {
            var query = context.CreateQuery<SalesAmountExtract>("GetDailyActualsVsTargetsByProduct");

            if (IsDailyActualsVsTargetsByProductLoading)
            {
                lock (cancelledOperations)
                {
                    cancelledOperations.Add(dailyActualsVsTargetsByProductLoadOperation, true);
                    context.CancelRequest(dailyActualsVsTargetsByProductLoadOperation);
                }
            }

            AsyncCallback callback = (args) =>
            {
                lock (cancelledOperations)
                {
                    if (cancelledOperations.ContainsKey(args))
                    {
                        cancelledOperations.Remove(args);
                        return;
                    }
                }
                System.Windows.Application.Current.Dispatcher.BeginInvoke(
                    new Action(() =>
                    {
                        this.IsDailyActualsVsTargetsByProductLoading = false;

                        IEnumerable<SalesAmountExtract> result = (args.AsyncState as DataServiceQuery<SalesAmountExtract>).EndExecute(args);
                        completedCallback(result.ToList());
                    }));
            };

            this.IsDailyActualsVsTargetsByProductLoading = true;
            dailyActualsVsTargetsByProductLoadOperation = query.BeginExecute(callback, query);
        }
#else
        private static readonly AWDWContext context = new AWDWContext();
        //private static LoadOperation<OrdersDetails> ordersDataForAllCustomersForPeriodLoadOperation;
        private static LoadOperation<SalesAmountExtract> actualsByCountriesLoadOperation;
        private static LoadOperation<SalesAmountExtract> dailyActualsVsTargetsByProductLoadOperation;

        //public void GetOrdersDataForAllCustomersForPeriod(EntityQuery<OrdersDetails> query, Action<LoadOperation<OrdersDetails>> completedCallback, int startIndex)
        //{
        //    Action<LoadOperation<OrdersDetails>> completed = (lo) =>
        //    {
        //        this.IsOrdersDataForAllCustomersForPeriodLoading = false;
        //        completedCallback(lo);
        //    };

        //    this.IsOrdersDataForAllCustomersForPeriodLoading = true;
        //    context.Load<OrdersDetails>(query, LoadBehavior.RefreshCurrent, completed, startIndex);
        //}

        //public void GetOrdersDataForAllCustomersForPeriod(DateTime start, DateTime end, Action<IEnumerable<OrdersDetails>> completedCallback)
        //{
        //    if (ordersDataForAllCustomersForPeriodLoadOperation != null && ordersDataForAllCustomersForPeriodLoadOperation.CanCancel)
        //    {
        //        this.IsOrdersDataForAllCustomersForPeriodLoading = false;
        //        ordersDataForAllCustomersForPeriodLoadOperation.Cancel();
        //    }

        //    Action<LoadOperation<OrdersDetails>> loadOperationCallback = (lo) =>
        //    {
        //        this.IsOrdersDataForAllCustomersForPeriodLoading = false;
        //        completedCallback(lo.Entities); 
        //    };

        //    this.IsOrdersDataForAllCustomersForPeriodLoading = true;
        //    var query = context.GetOrdersDetailsQuery();
        //    ordersDataForAllCustomersForPeriodLoadOperation = context.Load<OrdersDetails>(query, loadOperationCallback, null);
        //}

        public void GetActualsByCountries(DateTime start, DateTime end, Action<IEnumerable<SalesAmountExtract>> completedCallback)
        {
            if (actualsByCountriesLoadOperation != null && actualsByCountriesLoadOperation.CanCancel)
            {
                this.IsActualsByCountriesLoading = false;
                actualsByCountriesLoadOperation.Cancel();
            }

            Action<LoadOperation<SalesAmountExtract>> loadOperationCallback = (lo) =>
            {
                this.IsActualsByCountriesLoading = false;
                completedCallback(lo.Entities);
            };

            this.IsActualsByCountriesLoading = true;
            var query = context.GetActualsByCountriesQuery(start, end);
            actualsByCountriesLoadOperation = context.Load<SalesAmountExtract>(query, loadOperationCallback, null);
        }

        public void GetDailyActualsVsTargetsByProduct(Action<IEnumerable<SalesAmountExtract>> completedCallback)
        {
            if (dailyActualsVsTargetsByProductLoadOperation != null && dailyActualsVsTargetsByProductLoadOperation.CanCancel)
            {
                this.IsDailyActualsVsTargetsByProductLoading = false;
                dailyActualsVsTargetsByProductLoadOperation.Cancel();
            }

            Action<LoadOperation<SalesAmountExtract>> loadOperationCallback = (lo) =>
            {
                this.IsDailyActualsVsTargetsByProductLoading = false;
                completedCallback(lo.Entities);
            };

            this.IsDailyActualsVsTargetsByProductLoading = true;
            var query = context.GetDailyActualsVsTargetsByProductQuery();
            dailyActualsVsTargetsByProductLoadOperation = context.Load<SalesAmountExtract>(query, loadOperationCallback, null);
        }

        //public EntityQuery<OrdersDetails> GetOrdersDataForAllCustomersForPeriodQuery(DateTime startDate, DateTime endDate)
        //{
        //    return context.GetOrdersDataForAllCustomersForPeriodQuery(startDate, endDate);
        //}
#endif

        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
