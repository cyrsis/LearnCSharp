using ExecutiveDashboard.Web.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using Telerik.Windows.Controls;

namespace ExecutiveDashboard
{
    //public class ViewModel : ViewModelBase
    //{
    //    private IEnumerable<SalesAmountExtract> selectedAmountsPerProductCategories;
    //    private IEnumerable<SalesAmountExtract> selectedAmountsPerCountries;
    //    private IEnumerable<SalesAmountExtractWrapper> actualTrendData;
    //    private bool isAxisXAutoRange;
    //    private double axisXStep;
    //    private double axisXMaxValue;
    //    private double axisXMinValue;
    //    private string axisXDefaultLabelFormat;
    //    private bool showPointMarks;
    //    private DateTime selectionStart;
    //    private DateTime selectionEnd;
    //    private bool isBusyByProducts;
    //    private bool isBusyByCountry;


    //    public ViewModel()
    //    {
    //        this.selectionStart = new DateTime(2007, 2, 1);
    //        this.selectionEnd = new DateTime(2007, 4, 1);
    //        this.UpdateChartDateRange();
    //    }

    //    public bool IsBusyByProducts
    //    {
    //        get
    //        {
    //            return isBusyByProducts;
    //        }
    //        set
    //        {
    //            isBusyByProducts = value;
    //            this.OnPropertyChanged("IsBusyByProducts");
    //        }
    //    }
        
    //    public bool IsBusyByCountry
    //    {
    //        get
    //        {
    //            return isBusyByCountry;
    //        }
    //        set
    //        {
    //            isBusyByCountry = value;
    //            this.OnPropertyChanged("IsBusyByCountry");
    //        }
    //    }

    //    public IEnumerable<SalesAmountExtractWrapper> ActualTrendData
    //    {
    //        get
    //        {
    //            return this.actualTrendData;
    //        }
    //        set
    //        {
    //            this.actualTrendData = value;
    //            this.OnPropertyChanged("ActualTrendData");
    //            this.OnPropertyChanged("TargetTrendData");
    //            this.OnPropertyChanged("MaxActualYValue");
    //            this.OnPropertyChanged("MinActualYValue");
    //        }
    //    }

    //    public IEnumerable<SalesAmountExtractWrapper> TargetTrendData
    //    {
    //        get
    //        {
    //            if (this.ActualTrendData != null)
    //            {
    //                return this.ActualTrendData.Where(a=> a.TargetValue != null && a.TargetValue != 0d);
    //            }
    //            return null;
    //        }
    //    }

    //    public decimal SelectedActualTotalSalesAmount
    //    {
    //        get
    //        {
    //            if (this.SelectedAmountsPerProductCategories == null) return decimal.One;
    //            return this.SelectedAmountsPerProductCategories.Sum(a => a.ActualValue);
    //        }
    //    }

    //    public decimal SelectedTargetTotalSalesAmount
    //    {
    //        get
    //        {
    //            if (this.SelectedAmountsPerProductCategories == null) return decimal.One;
    //            return this.SelectedAmountsPerProductCategories.Sum(a => a.TargetValue);
    //        }
    //    }

    //    public decimal MaxSelectedTotalSalesAmount
    //    {
    //        get
    //        {
    //            var max = Math.Max(this.SelectedActualTotalSalesAmount, this.SelectedTargetTotalSalesAmount);
    //            return max + max * 0.05M;
    //        }
    //    }

    //    public decimal TotalActualVsTargetDecimalDifference
    //    {
    //        get
    //        {
    //            return this.SelectedActualTotalSalesAmount - this.SelectedTargetTotalSalesAmount;
    //        }
    //    }

    //    public decimal TotalActualVsTargetPercentageDifference
    //    {
    //        get
    //        {
    //            return ((this.SelectedActualTotalSalesAmount / this.SelectedTargetTotalSalesAmount) * 100m - 100) / 100m;
    //        }
    //    }

    //    public IEnumerable<SalesAmountExtract> SelectedAmountsPerProductCategories
    //    {
    //        get
    //        {
    //            return this.selectedAmountsPerProductCategories;
    //        }
    //        set
    //        {
    //            this.selectedAmountsPerProductCategories = value;
    //            this.OnPropertyChanged("SelectedAmountsPerProductCategories");
    //            this.OnPropertyChanged("MaxSalesPerProductValue");
    //            this.OnPropertyChanged("Step");
    //            this.OnPropertyChanged("SelectedActualTotalSalesAmount");
    //            this.OnPropertyChanged("SelectedTargetTotalSalesAmount");
    //            this.OnPropertyChanged("MaxSelectedTotalSalesAmount");
    //            this.OnPropertyChanged("TotalActualVsTargetDecimalDifference");
    //            this.OnPropertyChanged("TotalActualVsTargetPercentageDifference");
    //        }
    //    }

    //    public IEnumerable<SalesAmountExtract> SelectedAmountsPerCountry
    //    {
    //        get
    //        {
    //            return this.selectedAmountsPerCountries;
    //        }
    //        set
    //        {
    //            this.selectedAmountsPerCountries = value;
    //            this.OnPropertyChanged("SelectedAmountsPerCountry");
    //            this.OnPropertyChanged("MaxSalesPerCountriesValue");
    //        }
    //    }

    //    public double MaxActualYValue
    //    {
    //        get
    //        {
    //            if (this.ActualTrendData != null)
    //            {
    //                return Math.Max(this.ActualTrendData.Max(v => v.ActualValue), this.TargetTrendData.Max(v => v.TargetValue.Value));
    //            }
    //            return 0;
    //        }
    //    }

    //    public double MinActualYValue
    //    {
    //        get
    //        {
    //            if (this.ActualTrendData != null)
    //            {
    //                return Math.Min(this.ActualTrendData.Min(v => v.ActualValue), this.TargetTrendData.Min(v => v.TargetValue.Value));
    //            }
    //            return 0;
    //        }
    //    }

    //    public decimal MaxSalesPerProductValue
    //    {
    //        get
    //        {
    //            if (this.SelectedAmountsPerProductCategories != null)
    //            {
    //                var maximum = Math.Max(this.SelectedAmountsPerProductCategories.Max(v => v.ActualValue), this.SelectedAmountsPerProductCategories.Max(v => v.TargetValue));
    //                return maximum;
    //            }
    //            return 0;
    //        }
    //    }

    //    public decimal MaxSalesPerCountryValue
    //    {
    //        get
    //        {
    //            if (this.SelectedAmountsPerCountry != null)
    //            {
    //                var maximum = Math.Max(this.SelectedAmountsPerCountry.Max(v => v.ActualValue), this.SelectedAmountsPerCountry.Max(v => v.TargetValue));
    //                return maximum;
    //            }
    //            return 0;
    //        }
    //    }
        
    //    public int Step
    //    {
    //        get
    //        {
    //            return (int)this.MaxSalesPerProductValue / 4;
    //        }
    //    }

    //    public DateTime SelectionStart
    //    {
    //        get
    //        {
    //            return this.selectionStart;
    //        }
    //        set
    //        {
    //            this.selectionStart = value;
    //            this.OnPropertyChanged("SelectionStart");
    //        }
    //    }

    //    public DateTime SelectionEnd
    //    {
    //        get
    //        {
    //            return this.selectionEnd;
    //        }
    //        set
    //        {
    //            this.selectionEnd = value;
    //            this.OnPropertyChanged("SelectionEnd");
    //        }
    //    }

    //    public bool IsAxisXAutoRange
    //    {
    //        get
    //        {
    //            return this.isAxisXAutoRange;
    //        }
    //        set
    //        {
    //            this.isAxisXAutoRange = value;
    //            this.OnPropertyChanged("IsAxisXAutoRange");
    //        }
    //    }

    //    public double AxisXStep
    //    {
    //        get
    //        {
    //            return this.axisXStep;
    //        }
    //        set
    //        {
    //            this.axisXStep = value;
    //            this.OnPropertyChanged("AxisXStep");
    //        }
    //    }

    //    public double AxisXMinValue
    //    {
    //        get
    //        {
    //            return this.axisXMinValue;
    //        }
    //        set
    //        {
    //            this.axisXMinValue = value;
    //            this.OnPropertyChanged("AxisXMinValue");
    //        }
    //    }

    //    public double AxisXMaxValue
    //    {
    //        get
    //        {
    //            return this.axisXMaxValue;
    //        }
    //        set
    //        {
    //            this.axisXMaxValue = value;
    //            this.OnPropertyChanged("AxisXMaxValue");
    //        }
    //    }

    //    public string AxisXDefaultLabelFormat
    //    {
    //        get
    //        {
    //            return this.axisXDefaultLabelFormat;
    //        }
    //        set
    //        {
    //            this.axisXDefaultLabelFormat = value;
    //            this.OnPropertyChanged("AxisXDefaultLabelFormat");
    //        }
    //    }

    //    public bool ShowPointMarks
    //    {
    //        get
    //        {
    //            return this.showPointMarks;
    //        }
    //        set
    //        {
    //            this.showPointMarks = value;
    //            this.OnPropertyChanged("ShowPointMarks");
    //        }
    //    }

    //    public IEnumerable<SalesAmountExtract> ActualTrendData1
    //    {
    //        get
    //        {
    //            return null;
    //        }
    //        set
    //        {
    //            this.ActualTrendData = from all in value select new SalesAmountExtractWrapper(all);
    //        }
    //    }

    //    public void UpdateChartDateRange()
    //    {
    //        int selectedDaysCount = (this.SelectionEnd - this.SelectionStart).Days;

    //        this.IsAxisXAutoRange = false;
    //        this.AxisXMinValue = this.SelectionStart.ToOADate();
    //        this.AxisXMaxValue = this.SelectionEnd.ToOADate();

    //        if (selectedDaysCount <= 14)
    //        {
    //            this.AxisXStep = 1;
    //            this.AxisXDefaultLabelFormat = "ddd dd.MM";
    //        }
    //        else if (selectedDaysCount <= 31)
    //        {
    //            this.AxisXStep = 2;
    //            this.AxisXDefaultLabelFormat = "dd.MM";
    //        }
    //        else
    //        {
    //            this.AxisXStep = (int)(selectedDaysCount / 15);
    //            this.AxisXDefaultLabelFormat = "dd.MM";
    //        }

    //        this.ShowPointMarks = selectedDaysCount < 200;
    //    }

    //}
}
