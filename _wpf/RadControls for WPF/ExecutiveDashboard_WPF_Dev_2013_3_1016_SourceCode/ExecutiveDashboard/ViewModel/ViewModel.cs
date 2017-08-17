using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Telerik.Windows.Controls;
using Telerik.Windows.Data;
using System.Threading.Tasks;
#if SILVERLIGHT
using System.ServiceModel.DomainServices.Client;
using ExecutiveDashboard.Web;
using ExecutiveDashboard.Web.DomainServices;
using Telerik.Windows.Controls.DomainServices;
using System.Globalization;
using System.Windows;

#else
using Deployment = System.Windows.Application;
using ExecutiveDashboard.AWDWDomainService;
using AWDWDomainContext = ExecutiveDashboard.AWDWDomainService.AdventureWorksDWAZ2008R2XLabsEntities;
using SalesAmountExtract = ExecutiveDashboard.AWDWDomainService.SalesAmountExtract;
using System.Data.Services.Client;
#endif
namespace ExecutiveDashboard
{
    public class ViewModel : ViewModelBase
    {
        //private AWDWDomainContext context;
        private bool areChartYLabelsVisible = true;

        private double axisXStep;
        private string axisXDefaultLabelFormat;

        private IEnumerable<SalesAmountExtract> dailyActualsVsTargetsByProduct;
        private IEnumerable<SalesAmountExtractWrapper> selectedSalesAmountsByCountries;

        private IEnumerable<SalesAmountExtractWrapper> actualTrendData;
        private IEnumerable<SalesAmountExtractWrapper> targetTrendData;

        private IEnumerable<SalesAmountExtractWrapper> selectedAmountsPerProductCategories;

        private readonly MainRepository repository = new MainRepository();

        private bool showPointMarks;

        private bool isAxisXAutoRange;

        private IEnumerable<DailySalesInfoGrouping> selectedSalesTrendData;

        private bool shouldRefreshSelectedSalesTrendData = true;

        private SelectionRange<DateTime> selection;

        public ViewModel()
        {
            this.Selection = new SelectionRange<DateTime>(new DateTime(2007, 2, 1), new DateTime(2007, 4, 1));
            this.repository.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(OnRepositoryPropertyChanged);
        }

        public bool ShowPointMarks
        {
            get
            {
                return this.showPointMarks;
            }
            set
            {
                this.showPointMarks = value;
                this.OnPropertyChanged("ShowPointMarks");
            }
        }

        public bool IsActualsByCountriesLoading
        {
            get
            {
                return this.repository.IsActualsByCountriesLoading;
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
                this.OnPropertyChanged("SelectedSalesTrendData");
                //gauge
                this.OnPropertyChanged("SelectedAmountsPerProductCategories");
                this.OnPropertyChanged("Step");
                this.OnPropertyChanged("MaxSalesPerProductValue");
                this.OnPropertyChanged("SelectedActualTotalSalesAmount");
                this.OnPropertyChanged("SelectedTargetTotalSalesAmount");
                this.OnPropertyChanged("TotalActualVsTargetDecimalDifference");
                this.OnPropertyChanged("TotalActualVsTargetPercentageDifference");
                this.OnPropertyChanged("MaxSelectedTotalSalesAmount");
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

        public IEnumerable<SalesAmountExtractWrapper> SelectedSalesAmountsByCountries
        {
            get
            {
                if (this.selectedSalesAmountsByCountries == null)
                {
                    this.repository.GetActualsByCountries(this.Selection.Start, this.Selection.End, (result) =>
                    {
                        var sortedResult = result.Select(x => { return new SalesAmountExtractWrapper(x); }).ToList();
                        this.SelectedSalesAmountsByCountries = sortedResult;
                    });
                }

                return this.selectedSalesAmountsByCountries;
            }
            set
            {
                this.selectedSalesAmountsByCountries = value;
                this.OnPropertyChanged("SelectedSalesAmountsByCountries");
                this.OnPropertyChanged("MaxSelectedSalesAmountsByCountries");
            }
        }

        public decimal MaxSelectedSalesAmountsByCountries
        {
            get
            {
                if (this.SelectedSalesAmountsByCountries == null || SelectedSalesAmountsByCountries.Count() == 0)
                {
                    return 0;
                }

                decimal maximum = (decimal)this.SelectedSalesAmountsByCountries.Max(x => x.ActualValue);
                return maximum;
            }
        }

        public decimal MaxSelectedTotalSalesAmount
        {
            get
            {
                var max = Math.Max(this.SelectedActualTotalSalesAmount, this.SelectedTargetTotalSalesAmount);
                return max + max * 0.05M;
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

        public IEnumerable<DailySalesInfoGrouping> SelectedSalesTrendData
        {
            get
            {
                if (this.shouldRefreshSelectedSalesTrendData && this.DailyActualsVsTargetsByProduct != null && this.DailyActualsVsTargetsByProduct.Count() > 0)
                {
                    Task.Factory.StartNew(() =>
                    {
                        this.selectedSalesTrendData = from dailySales in this.DailyActualsVsTargetsByProduct where dailySales.OrderDate >= this.Selection.Start && dailySales.OrderDate <= this.Selection.End group dailySales by dailySales.OrderDate into result select new DailySalesInfoGrouping
                        {
                            Date = result.Key,
                            AccessoriesValue = result.Any(x => x.ProductCategory.Contains("Accessories")) ? result.FirstOrDefault(x => x.ProductCategory.Contains("Accessories")).ActualAmount : 0,
                            BikesValue = result.Any(x => x.ProductCategory.Contains("Bikes")) ? result.FirstOrDefault(x => x.ProductCategory.Contains("Bikes")).ActualAmount : 0,
                            ClothingValue = result.Any(x => x.ProductCategory.Contains("Clothing")) ? result.FirstOrDefault(x => x.ProductCategory.Contains("Clothing")).ActualAmount : 0,
                            ComponentsValue = result.Any(x => x.ProductCategory.Contains("Components")) ? result.FirstOrDefault(x => x.ProductCategory.Contains("Components")).ActualAmount : 0,
                            TotalActualValue = result.Sum(x => x.ActualAmount),
                            TotalTargetValue = result.Sum(x => x.TargetAmount.HasValue ? x.TargetAmount.Value : 0)
                        };
                    }).ContinueWith((task) =>
                    {
                        this.shouldRefreshSelectedSalesTrendData = false;
                        Deployment.Current.Dispatcher.BeginInvoke(new Action(() => { this.OnPropertyChanged("SelectedSalesTrendData"); }));
                    });
                }

                return this.selectedSalesTrendData;
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

        public decimal SelectedTargetTotalSalesAmount
        {
            get
            {
                if (this.SelectedAmountsPerProductCategories == null)
                    return decimal.One;
                return (decimal)this.SelectedAmountsPerProductCategories.Sum(a => a.TargetValue);
            }
        }

        public IEnumerable<SalesAmountExtractWrapper> SelectedAmountsPerProductCategories
        {
            get
            {
                if (this.selectedAmountsPerProductCategories == null && this.DailyActualsVsTargetsByProduct != null && this.DailyActualsVsTargetsByProduct.Count() > 0)
                {
                    Task.Factory.StartNew(() =>
                    {
                        var data = from all in this.DailyActualsVsTargetsByProduct where all.OrderDate > this.Selection.Start && all.OrderDate <= this.Selection.End group all by all.ProductCategory into result select new SalesAmountExtractWrapper(new SalesAmountExtract()
                        {
                            ActualAmount = result.Sum(s => s.ActualAmount),
                            TargetAmount = result.Sum(s => s.TargetAmount),
                            ProductCategory = result.Key
                        });
                        var sortedData = data.ToList();
                        sortedData.Sort(new SalesAmountExtractWrapperProductCategoryComparer());
                        this.selectedAmountsPerProductCategories = sortedData.Count() != 0 ? sortedData : null;
                    }).ContinueWith((task) =>
                    {
                        Deployment.Current.Dispatcher.BeginInvoke(new Action(() =>
                        {
                            this.OnPropertyChanged("SelectedAmountsPerProductCategories");
                            this.OnPropertyChanged("MaxSalesPerProductValue");
                            this.OnPropertyChanged("Step");
                            this.OnPropertyChanged("SelectedActualTotalSalesAmount");
                            this.OnPropertyChanged("SelectedTargetTotalSalesAmount");
                            this.OnPropertyChanged("MaxSelectedTotalSalesAmount");
                            this.OnPropertyChanged("TotalActualVsTargetDecimalDifference");
                            this.OnPropertyChanged("TotalActualVsTargetPercentageDifference");
                        }));
                    });
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
                return 0.0001m; // TODO: using this instead of 0, because of BulletGraph bug in 2013 Q2 SP1
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

        public decimal TotalActualVsTargetDecimalDifference
        {
            get
            {
                return this.SelectedActualTotalSalesAmount - this.SelectedTargetTotalSalesAmount;
            }
        }

        public decimal TotalActualVsTargetPercentageDifference
        {
            get
            {
                return ((this.SelectedActualTotalSalesAmount / this.SelectedTargetTotalSalesAmount) * 100m - 100) / 100m;
            }
        }

        public decimal MaxSalesPerCountryValue
        {
            get
            {
                if (this.SelectedSalesAmountsByCountries != null && this.SelectedSalesAmountsByCountries.Count() > 0)
                {
                    decimal maximum = (decimal)Math.Max(this.SelectedSalesAmountsByCountries.Max(v => v.ActualValue), this.SelectedSalesAmountsByCountries.Max(v => v.TargetValue.GetValueOrDefault()));
                    return maximum;
                }
                return 0;
            }
        }

        public int Step
        {
            get
            {
                return (int)this.MaxSalesPerProductValue / 4;
            }
        }

        public bool IsAxisXAutoRange
        {
            get
            {
                return this.isAxisXAutoRange;
            }
            set
            {
                this.isAxisXAutoRange = value;
                this.OnPropertyChanged("IsAxisXAutoRange");
            }
        }

        public void UpdateChartDateRange()
        {
            int selectedDaysCount = (this.Selection.End - this.Selection.Start).Days;

            this.IsAxisXAutoRange = false;
            this.OnPropertyChanged("AxisXMinValue");
            this.OnPropertyChanged("AxisXMaxValue");
            if (selectedDaysCount <= 14)
            {
                this.AxisXStep = 1;
                this.AxisXDefaultLabelFormat = "ddd dd.MM";
            }
            else if (selectedDaysCount <= 31)
            {
                this.AxisXStep = 2;
                this.AxisXDefaultLabelFormat = "dd.MM";
            }
            else
            {
                this.AxisXStep = selectedDaysCount / 15;
                this.AxisXDefaultLabelFormat = "dd.MM";
            }

            this.ShowPointMarks = selectedDaysCount < 200;
        }

        private void ResetViewData()
        {
            this.selectedSalesAmountsByCountries = null;
            this.selectedAmountsPerProductCategories = null;
            this.shouldRefreshSelectedSalesTrendData = true;
            
            this.OnPropertyChanged("SelectedSalesAmountsByCountries");
            this.OnPropertyChanged("MaxSalesPerCountryValue");
            this.OnPropertyChanged("SelectedSalesTrendData");

            //gauge
            this.OnPropertyChanged("SelectedAmountsPerProductCategories");
            this.OnPropertyChanged("MaxSalesPerProductValue");
            this.OnPropertyChanged("Step");
            this.OnPropertyChanged("SelectedActualTotalSalesAmount");
            this.OnPropertyChanged("SelectedTargetTotalSalesAmount");

            this.OnPropertyChanged("MaxSelectedTotalSalesAmount");
            this.OnPropertyChanged("TotalActualVsTargetDecimalDifference");
            this.OnPropertyChanged("TotalActualVsTargetPercentageDifference");
        }

        private void OnRepositoryPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            this.OnPropertyChanged(e.PropertyName);
        }
    }
}
