using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
#if SILVERLIGHT
using System.ServiceModel.DomainServices.Client;
using SalesDashboard.Web;
using AWDWContext = SalesDashboard.Web.DomainServices.AWDWDomainContext;
#else
using System.Windows.Threading;
using System.Data.Services.Client;
using SalesDashboard.AWDWDomainService;
using SalesAmountExtract = SalesDashboard.AWDWDomainService.SalesAmountExtract;
using AWDWContext = SalesDashboard.AWDWDomainService.AdventureWorksDWAZ2008R2XLabsEntities;
#endif

namespace SalesDashboard
{
    public class MainRepository : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool isOrdersDataForAllCustomersForPeriodLoading;
        private bool isActualsByCountriesAndProductCategoriesLoading;
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
        
        public bool IsActualsByCountriesAndProductCategoriesLoading
        {
            get { return this.isActualsByCountriesAndProductCategoriesLoading; }
            set
            {
                this.isActualsByCountriesAndProductCategoriesLoading = value;
                this.OnPropertyChanged("IsActualsByCountriesAndProductCategoriesLoading");
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

        private static IAsyncResult ordersDataForAllCustomersForPeriodLoadOperation;
        private static IAsyncResult actualsByCountriesAndProductCategoriesLoadOperation;
        private static IAsyncResult dailyActualsVsTargetsByProductLoadOperation;

        private readonly static Dictionary<IAsyncResult, bool> cancelledOperations = new Dictionary<IAsyncResult, bool>();

        public void GetActualsByCountriesAndProductCategories(DateTime start, DateTime end, Action<IEnumerable<SalesAmountExtract>> completedCallback)
        {
            var query = context.CreateQuery<SalesAmountExtract>("GetActualsByCountriesAndProductCategories")
                               .AddQueryOption("start", StringApostropheWrapperHelper.WrapWithApostrophes(start.ToString()))
                               .AddQueryOption("end", StringApostropheWrapperHelper.WrapWithApostrophes(end.ToString()));

            if (this.IsActualsByCountriesAndProductCategoriesLoading)
            {
                cancelledOperations.Add(actualsByCountriesAndProductCategoriesLoadOperation, true);
                context.CancelRequest(actualsByCountriesAndProductCategoriesLoadOperation);
            }

            AsyncCallback callback = (args) =>
            {
                if (cancelledOperations.ContainsKey(args))
                {
                    cancelledOperations.Remove(args);
                    return;
                }

                System.Windows.Application.Current.Dispatcher.BeginInvoke(
                    new Action(() =>
                    {
                        this.IsActualsByCountriesAndProductCategoriesLoading = false;

                        IEnumerable<SalesAmountExtract> result = (args.AsyncState as DataServiceQuery<SalesAmountExtract>).EndExecute(args);
                        completedCallback(result.ToList());
                    }));
            };

            this.IsActualsByCountriesAndProductCategoriesLoading = true;
            actualsByCountriesAndProductCategoriesLoadOperation = query.BeginExecute(callback, query);
        }

        public void GetDailyActualsVsTargetsByProduct(Action<IEnumerable<SalesAmountExtract>> completedCallback)
        {
            var query = context.CreateQuery<SalesAmountExtract>("GetDailyActualsVsTargetsByProduct");

            if (IsDailyActualsVsTargetsByProductLoading)
            {
                cancelledOperations.Add(dailyActualsVsTargetsByProductLoadOperation, true);
                context.CancelRequest(dailyActualsVsTargetsByProductLoadOperation);
            }

            AsyncCallback callback = (args) =>
            {
                if (cancelledOperations.ContainsKey(args))
                {
                    cancelledOperations.Remove(args);
                    return;
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

        public System.Data.Services.Client.DataServiceQuery<OrdersDetails> GetOrdersDataForAllCustomersForPeriodQuery(DateTime startDate, DateTime endDate)
        {
            var query = context.CreateQuery<OrdersDetails>("GetOrdersDataForAllCustomersForPeriod")
                               .AddQueryOption("start", StringApostropheWrapperHelper.WrapWithApostrophes(startDate.ToString()))
                               .AddQueryOption("end", StringApostropheWrapperHelper.WrapWithApostrophes(endDate.ToString()));
            return query;
        }

        public void GetOrdersDataForAllCustomersForPeriod(DataServiceQuery<OrdersDetails> query, Action<IEnumerable<OrdersDetails>, int> completedCallback, int startIndex)
        {

            if (this.IsOrdersDataForAllCustomersForPeriodLoading)
            {
                cancelledOperations.Add(ordersDataForAllCustomersForPeriodLoadOperation, true);
                context.CancelRequest(ordersDataForAllCustomersForPeriodLoadOperation);
            }

            AsyncCallback callback = (args) =>
            {
                if (cancelledOperations.ContainsKey(args))
                {
                    cancelledOperations.Remove(args);
                    return;
                }

                System.Windows.Application.Current.Dispatcher.BeginInvoke(
                    new Action(() =>
                    {
                        this.IsOrdersDataForAllCustomersForPeriodLoading = false;

                        QueryOperationResponse<OrdersDetails> result = (args.AsyncState as DataServiceQuery<OrdersDetails>).EndExecute(args) as QueryOperationResponse<OrdersDetails>;
                        completedCallback(result.ToList(), (int)result.TotalCount);
                    }));
            };

            this.IsOrdersDataForAllCustomersForPeriodLoading = true;
            ordersDataForAllCustomersForPeriodLoadOperation = query.BeginExecute(callback, query);
        }
#else
        private static readonly AWDWContext context = new AWDWContext();
        private static LoadOperation<OrdersDetails> ordersDataForAllCustomersForPeriodLoadOperation;
        private static LoadOperation<SalesAmountExtract> actualsByCountriesAndProductCategoriesLoadOperation;
        private static LoadOperation<SalesAmountExtract> dailyActualsVsTargetsByProductLoadOperation;

        public void GetOrdersDataForAllCustomersForPeriod(EntityQuery<OrdersDetails> query, Action<LoadOperation<OrdersDetails>> completedCallback, int startIndex)
        {
            Action<LoadOperation<OrdersDetails>> completed = (lo) =>
            {
                this.IsOrdersDataForAllCustomersForPeriodLoading = false;
                completedCallback(lo);
            };

            this.IsOrdersDataForAllCustomersForPeriodLoading = true;
            context.Load<OrdersDetails>(query, LoadBehavior.RefreshCurrent, completed, startIndex);
        }

        public void GetOrdersDataForAllCustomersForPeriod(DateTime start, DateTime end, Action<IEnumerable<OrdersDetails>> completedCallback)
        {
            if (ordersDataForAllCustomersForPeriodLoadOperation != null && ordersDataForAllCustomersForPeriodLoadOperation.CanCancel)
            {
                this.IsOrdersDataForAllCustomersForPeriodLoading = false;
                ordersDataForAllCustomersForPeriodLoadOperation.Cancel();
            }

            Action<LoadOperation<OrdersDetails>> loadOperationCallback = (lo) =>
            {
                this.IsOrdersDataForAllCustomersForPeriodLoading = false;
                completedCallback(lo.Entities); 
            };

            this.IsOrdersDataForAllCustomersForPeriodLoading = true;
            var query = context.GetOrdersDetailsQuery();
            ordersDataForAllCustomersForPeriodLoadOperation = context.Load<OrdersDetails>(query, loadOperationCallback, null);
        }

        public void GetActualsByCountriesAndProductCategories(DateTime start, DateTime end, Action<IEnumerable<SalesAmountExtract>> completedCallback)
        {
            if (actualsByCountriesAndProductCategoriesLoadOperation != null && actualsByCountriesAndProductCategoriesLoadOperation.CanCancel)
            {
                this.IsActualsByCountriesAndProductCategoriesLoading = false;
                actualsByCountriesAndProductCategoriesLoadOperation.Cancel();
            }

            Action<LoadOperation<SalesAmountExtract>> loadOperationCallback = (lo) =>
            {
                this.IsActualsByCountriesAndProductCategoriesLoading = false;
                completedCallback(lo.Entities);
            };

            this.IsActualsByCountriesAndProductCategoriesLoading = true;
            var query = context.GetActualsByCountriesAndProductCategoriesQuery(start, end);
            actualsByCountriesAndProductCategoriesLoadOperation = context.Load<SalesAmountExtract>(query, loadOperationCallback, null);
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

        public EntityQuery<OrdersDetails> GetOrdersDataForAllCustomersForPeriodQuery(DateTime startDate, DateTime endDate)
        {
            return context.GetOrdersDataForAllCustomersForPeriodQuery(startDate, endDate);
        }
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
