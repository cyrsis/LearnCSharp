using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Telerik.Windows.Controls;
using Telerik.Windows.Data;
#if SILVERLIGHT
using System.ServiceModel.DomainServices.Client;
using SalesDashboard.Web;
using SalesDashboard.Web.DomainServices;
using Telerik.Windows.Controls.DomainServices;
using System.Windows;

#else
using SalesDashboard.AWDWDomainService;
using AWDWDomainContext = SalesDashboard.AWDWDomainService.AdventureWorksDWAZ2008R2XLabsEntities;
using SalesAmountExtract = SalesDashboard.AWDWDomainService.SalesAmountExtract;
using System.Data.Services.Client;
#endif
namespace SalesDashboard
{
    public class ViewModel : ViewModelBase
    {
        //private AWDWDomainContext context;
        private VirtualQueryableCollectionView ordersDataForAllCustomersForPeriod;
        private SelectionRange<DateTime> selection;
        private bool shouldLoad = true;
        private bool areChartYLabelsVisible = true;

        private double axisXStep;
        private string axisXDefaultLabelFormat;

        private IEnumerable<SalesAmountExtract> dailyActualsVsTargetsByProduct;
        private IEnumerable<SalesInfoGrouping> selectedSalesAmountsByCountriesAndProductCategories;

        private IEnumerable<SalesAmountExtractWrapper> actualTrendData;
        private IEnumerable<SalesAmountExtractWrapper> targetTrendData;
        
        private IEnumerable<SalesAmountExtractWrapper> selectedAmountsPerProductCategories;
        private IEnumerable<DailySalesInfoGrouping> selectedDailySalesByProductCategories;

        private readonly MainRepository repository = new MainRepository();

        public ViewModel()
        {
            this.Selection = new SelectionRange<DateTime>(new DateTime(2007, 2, 1), new DateTime(2007, 4, 1));
            this.repository.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(OnRepositoryPropertyChanged);
        }

        public bool IsActualsByCountriesAndProductCategoriesLoading
        {
            get
            {
                return this.repository.IsActualsByCountriesAndProductCategoriesLoading;
            }
        }

        public bool IsDailyActualsVsTargetsByProductLoading
        {
            get
            {
                return this.repository.IsDailyActualsVsTargetsByProductLoading;
            }
        }

        public bool IsOrdersDataForAllCustomersForPeriodLoading
        {
            get
            {
                return this.repository.IsOrdersDataForAllCustomersForPeriodLoading;
            }
        }

        public IEnumerable<SalesAmountExtract> DailyActualsVsTargetsByProduct
        {
            get
            {
                if (this.dailyActualsVsTargetsByProduct == null)
                {
                    this.repository.GetDailyActualsVsTargetsByProduct((result) =>
                    {
                        this.DailyActualsVsTargetsByProduct = result;
                    });
                }

                return this.dailyActualsVsTargetsByProduct;
            }
            set
            {
                this.dailyActualsVsTargetsByProduct = value;
                this.OnPropertyChanged("DailyActualsVsTargetsByProduct");
                //timebar
                this.OnPropertyChanged("ActualTrendData");
                this.OnPropertyChanged("TargetTrendData");
                this.OnPropertyChanged("MaxActualYValue");
                this.OnPropertyChanged("MinActualYValue");
                //chart
                this.OnPropertyChanged("SelectedDailySalesByProductCategories");
                //gauge
                this.OnPropertyChanged("SelectedAmountsPerProductCategories");
                this.OnPropertyChanged("MaxSalesPerProductValue");
                this.OnPropertyChanged("SelectedActualTotalSalesAmount");
            }
        }

        public IEnumerable<SalesAmountExtractWrapper> ActualTrendData
        {
            get
            {
                if (this.actualTrendData == null && this.DailyActualsVsTargetsByProduct != null)
                { 
                    var dataGroupedByDate = from all in this.DailyActualsVsTargetsByProduct
                                            group all by all.OrderDate into result
                                            select result;

                    var resultData = dataGroupedByDate.Select(x => new SalesAmountExtractWrapper(new SalesAmountExtract()
                    {
                        TargetAmount = x.Sum(y => y.TargetAmount),
                        ActualAmount = x.Sum(y => y.ActualAmount),
                        OrderDate = x.FirstOrDefault().OrderDate
                    }));

                    this.actualTrendData = resultData.Count() != 0 ? resultData : null;
                }
                return this.actualTrendData;
            }
        }

        public IEnumerable<SalesInfoGrouping> SelectedSalesAmountsByCountriesAndProductCategories
        {
            get
            {
                if (this.selectedSalesAmountsByCountriesAndProductCategories == null)
                {
                    this.repository.GetActualsByCountriesAndProductCategories(this.Selection.Start, this.Selection.End, (result) =>
                    {
                        var comparer = new SalesAmountExtractProductCategoryComparer();
                        var sortedResult = result.ToList();
                        sortedResult.Sort(comparer);
                        this.SelectedSalesAmountsByCountriesAndProductCategories = SalesInfoGrouping.CreateFromSalesAmountExtractCollection(sortedResult);
                    });
                }

                return this.selectedSalesAmountsByCountriesAndProductCategories;
            }
            set
            {
                this.selectedSalesAmountsByCountriesAndProductCategories = value;
                this.OnPropertyChanged("SelectedSalesAmountsByCountriesAndProductCategories");
                this.OnPropertyChanged("MaxSelectedSalesAmountsByCountriesAndProductCategories");
            }
        }

        public decimal MaxSelectedSalesAmountsByCountriesAndProductCategories
        {
            get
            {
                if (this.SelectedSalesAmountsByCountriesAndProductCategories == null || SelectedSalesAmountsByCountriesAndProductCategories.Count() == 0)
                {
                    return 0;
                }

                decimal maximum = this.SelectedSalesAmountsByCountriesAndProductCategories.Max(salesInfoGrouping => salesInfoGrouping.SalesInfos.Max(extract => extract.ActualAmount));
                return maximum;
            }
        }

        public IEnumerable<SalesAmountExtractWrapper> TargetTrendData
        {
            get
            {
                if (this.targetTrendData == null)
                {
                    if (this.ActualTrendData != null)
                    {
                        this.targetTrendData = this.ActualTrendData.Where(a => a.TargetValue != null && a.TargetValue != 0d);
                    }
                }
                return this.targetTrendData;
            }
        }
        
        public IEnumerable<DailySalesInfoGrouping> SelectedDailySalesByProductCategories
        {
            get
            {
                if (this.selectedDailySalesByProductCategories == null && this.DailyActualsVsTargetsByProduct != null && this.DailyActualsVsTargetsByProduct.Count() != 0)
                {
                    var convertedCollection = (from dailySales in this.DailyActualsVsTargetsByProduct
                                               orderby dailySales.OrderDate
                                               group dailySales by dailySales.OrderDate into groupsByDates
                                               select new DailySalesInfoGrouping()
                                               {
                                                   Date = groupsByDates.Key,
                                                   BikesValue = groupsByDates.FirstOrDefault(g => g.ProductCategory.Equals("bikes", StringComparison.InvariantCultureIgnoreCase)) != null
                                                                ? groupsByDates.Where(g => g.ProductCategory.Equals("bikes", StringComparison.InvariantCultureIgnoreCase)).Sum(o => o.ActualAmount) : 0,
                                                   AccessoriesValue = groupsByDates.FirstOrDefault(g => g.ProductCategory.Equals("accessories", StringComparison.InvariantCultureIgnoreCase)) != null
                                                                      ? groupsByDates.Where(g => g.ProductCategory.Equals("accessories", StringComparison.InvariantCultureIgnoreCase)).Sum(o => o.ActualAmount) : 0,
                                                   ClothingValue = groupsByDates.FirstOrDefault(g => g.ProductCategory.Equals("clothing", StringComparison.InvariantCultureIgnoreCase)) != null
                                                                   ? groupsByDates.Where(g => g.ProductCategory.Equals("clothing", StringComparison.InvariantCultureIgnoreCase)).Sum(o => o.ActualAmount) : 0,
                                                   ComponentsValue = groupsByDates.FirstOrDefault(g => g.ProductCategory.Equals("components", StringComparison.InvariantCultureIgnoreCase)) != null
                                                                     ? groupsByDates.Where(g => g.ProductCategory.Equals("components", StringComparison.InvariantCultureIgnoreCase)).Sum(o => o.ActualAmount) : 0,
                                               });
                    this.selectedDailySalesByProductCategories = convertedCollection.ToList();
                }

                if (this.selectedDailySalesByProductCategories != null)
                {
                    return this.selectedDailySalesByProductCategories.Where(x => this.Selection.Start <= x.Date && this.Selection.End >= x.Date);
                }

                return null;
            }
        }

        public decimal SelectedActualTotalSalesAmount
        {
            get
            {
                if (this.SelectedAmountsPerProductCategories == null)
                    return decimal.One;
                return (decimal)this.SelectedAmountsPerProductCategories.Sum(a => a.ActualValue);
            }
        }

        public IEnumerable<SalesAmountExtractWrapper> SelectedAmountsPerProductCategories
        {
            get
            {
                if (this.selectedAmountsPerProductCategories == null && this.DailyActualsVsTargetsByProduct != null)
                {
                    var data = from all in this.DailyActualsVsTargetsByProduct
                               where all.OrderDate > this.Selection.Start && all.OrderDate <= this.Selection.End
                               group all by all.ProductCategory into result
                               select new SalesAmountExtractWrapper(new SalesAmountExtract()
                               {
                                   ActualAmount = result.Sum(s => s.ActualAmount),
                                   TargetAmount = result.Sum(s => s.TargetAmount),
                                   ProductCategory = result.Key
                               });
                    var sortedData = data.ToList();
                    sortedData.Sort(new SalesAmountExtractWrapperProductCategoryComparer());

                    this.selectedAmountsPerProductCategories = sortedData.Count() != 0 ? sortedData : null;
                }
                return this.selectedAmountsPerProductCategories;
            }
        }

        public double MaxActualYValue
        {
            get
            {
                if (this.ActualTrendData != null && this.ActualTrendData.Count() != 0)
                {
                    return Math.Max(this.ActualTrendData.Max(v => v.ActualValue), this.TargetTrendData.Max(v => v.TargetValue.Value));
                }
                return 0;
            }
        }

        public double MinActualYValue
        {
            get
            {
                if (this.ActualTrendData != null && this.ActualTrendData.Count() != 0)
                {
                    return Math.Min(this.ActualTrendData.Min(v => v.ActualValue), this.TargetTrendData.Min(v => v.TargetValue.Value));
                }
                return 0;
            }
        }

        public decimal MaxSalesPerProductValue
        {
            get
            {
                if (this.SelectedAmountsPerProductCategories != null && this.SelectedAmountsPerProductCategories.Count() != 0)
                {
                    var maximum = Math.Max(this.SelectedAmountsPerProductCategories.Max(v => v.ActualValue), this.SelectedAmountsPerProductCategories.Max(v => v.TargetValue).Value);
                    return (decimal)maximum;
                }
                return 0;
            }
        }

        public SelectionRange<DateTime> Selection
        {
            get
            {
                return this.selection; 
            }
            set
            {
                this.selection = value;
                this.OnPropertyChanged("Selection");
                this.ResetViewData();
                this.ClearLoadedOrderData();
                this.UpdateChartDateRange();
            }
        }

        public bool AreChartYLabelsVisible
        {
            get
            {
                return this.areChartYLabelsVisible;
            }

            set
            {
                this.areChartYLabelsVisible = value;
                this.OnPropertyChanged("AreChartYLabelsVisible");
            }
        }

        public double AxisXStep
        {
            get
            {
                return this.axisXStep;
            }
            set
            {
                this.axisXStep = value;
                this.OnPropertyChanged("AxisXStep");
            }
        }

        public double AxisXMinValue
        {
            get
            {
                return this.Selection.Start.ToOADate();
            }
        }

        public double AxisXMaxValue
        {
            get
            {
                return this.Selection.End.ToOADate();
            }
        }

        public string AxisXDefaultLabelFormat
        {
            get
            {
                return this.axisXDefaultLabelFormat;
            }
            set
            {
                this.axisXDefaultLabelFormat = value;
                this.OnPropertyChanged("AxisXDefaultLabelFormat");
            }
        }

        public VirtualQueryableCollectionView OrdersDataForAllCustomersForPeriod
        {
            get
            {
                if (this.ordersDataForAllCustomersForPeriod == null)
                {
                    this.ordersDataForAllCustomersForPeriod = new VirtualQueryableCollectionView();
                    this.ordersDataForAllCustomersForPeriod.ItemsLoading += this.OnOrdersDataForAllCustomersForPeriodItemsLoading;
                    this.ordersDataForAllCustomersForPeriod.VirtualItemCount = 100; // Force ItemsLoading to get the real total item count and data in a single request
                    
                    this.ordersDataForAllCustomersForPeriod.LoadSize = 10;
                }

                return this.ordersDataForAllCustomersForPeriod;
            }
            private set
            {
                if (this.ordersDataForAllCustomersForPeriod != value)
                {
#if SILVERLIGHT
                    this.ordersDataForAllCustomersForPeriod.ItemsLoading -= this.OnOrdersDataForAllCustomersForPeriodItemsLoading;
#endif
                    this.ordersDataForAllCustomersForPeriod = value;
                    this.OnPropertyChanged("OrdersDataForAllCustomersForPeriod");
                }
            }
        }

        public void ClearLoadedOrderData()
        {
            this.OrdersDataForAllCustomersForPeriod = null;
        }

        public void UpdateChartDateRange()
        {
            this.OnPropertyChanged("AxisXMinValue");
            this.OnPropertyChanged("AxisXMaxValue");
            int selectedDaysCount = (this.Selection.End - this.Selection.Start).Days;
            if (selectedDaysCount <= 7)
            {
                this.AxisXStep = 1;
                this.AxisXDefaultLabelFormat = "ddd d.MM";
            }
            else if (selectedDaysCount <= 14)
            {
                this.AxisXStep = 2;
                this.AxisXDefaultLabelFormat = "ddd d.MM";
            }
            else if (selectedDaysCount <= 31)
            {
                this.AxisXStep = 3;
                this.AxisXDefaultLabelFormat = "d.MM";
            }
            else
            {
                this.AxisXStep = selectedDaysCount / 10;
                this.AxisXDefaultLabelFormat = "d MMM";
            }
        }

        void OnOrdersDataForAllCustomersForPeriodItemsLoading(object sender, VirtualQueryableCollectionViewItemsLoadingEventArgs e)
        {
#if SILVERLIGHT
            if (System.ComponentModel.DesignerProperties.IsInDesignTool)
                return;
            
            EntityQuery<OrdersDetails> query = this.repository.GetOrdersDataForAllCustomersForPeriodQuery(this.Selection.Start, this.Selection.End);
            query.IncludeTotalCount = true;
            query = query.OrderBy(od => od.OrderDate)
                         .Sort(this.OrdersDataForAllCustomersForPeriod.SortDescriptors)
                         .Skip(e.StartIndex)
                         .Take(e.ItemCount);

            this.repository.GetOrdersDataForAllCustomersForPeriod(query, (lo)=> 
            {
            	if (lo.TotalEntityCount != this.OrdersDataForAllCustomersForPeriod.VirtualItemCount)
                {
                    this.OrdersDataForAllCustomersForPeriod.VirtualItemCount = lo.TotalEntityCount;
                }

                this.OrdersDataForAllCustomersForPeriod.Load((int)lo.UserState, lo.Entities);
            }, e.StartIndex);
#else
            var query = this.repository.GetOrdersDataForAllCustomersForPeriodQuery(this.Selection.Start, this.Selection.End);

            query = query.OrderBy(od => od.OrderDate)
                         .Sort(this.OrdersDataForAllCustomersForPeriod.SortDescriptors)
                         .Skip(e.StartIndex)
                         .Take(e.ItemCount) as DataServiceQuery<OrdersDetails>;
            
            query = query.IncludeTotalCount();

            this.repository.GetOrdersDataForAllCustomersForPeriod(query, (result, totalCount) =>
            {
                this.OrdersDataForAllCustomersForPeriod.VirtualItemCount = totalCount;
                this.OrdersDataForAllCustomersForPeriod.Load(e.StartIndex, result);       
            }, e.StartIndex);
#endif
        }

        private void ResetViewData()
        {
            this.selectedSalesAmountsByCountriesAndProductCategories = null;
            this.actualTrendData = null;
            this.targetTrendData = null;
            this.selectedAmountsPerProductCategories = null;
            
            this.OnPropertyChanged("OrdersDataForAllCustomersForPeriod");
            
            this.OnPropertyChanged("SelectedSalesAmountsByCountriesAndProductCategories");
            this.OnPropertyChanged("SelectedDailySalesByProductCategories");

            //gauge
            this.OnPropertyChanged("SelectedAmountsPerProductCategories");
            this.OnPropertyChanged("MaxSalesPerProductValue");
            this.OnPropertyChanged("SelectedActualTotalSalesAmount");
        }

        private void OnRepositoryPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            this.OnPropertyChanged(e.PropertyName);
        }
    }
}
