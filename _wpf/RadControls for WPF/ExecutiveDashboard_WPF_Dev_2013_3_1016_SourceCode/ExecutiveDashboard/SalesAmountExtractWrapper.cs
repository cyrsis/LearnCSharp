using System;
#if SILVERLIGHT
using ExecutiveDashboard.Web;
#else
using SalesAmountExtract = ExecutiveDashboard.AWDWDomainService.SalesAmountExtract;
#endif
namespace ExecutiveDashboard
{
    /// <summary>
    /// a wrapper class over SalesAmountExtract needed to expose decimal type properties as double
    /// </summary>
    public class SalesAmountExtractWrapper
    {
        public SalesAmountExtract SalesAmountExtract { get; private set; }

        public SalesAmountExtractWrapper(SalesAmountExtract sae)
        {
            this.SalesAmountExtract = sae;
        }

        public string ProductCategory
        {
            get
            {
                return this.SalesAmountExtract.ProductCategory;
            }
        }

        public string Country
        {
            get
            {
                return this.SalesAmountExtract.Country;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return this.SalesAmountExtract.OrderDate;
            }
        }

        public double ActualValue
        {
            get
            {
                return (double)this.SalesAmountExtract.ActualAmount;
            }
        }

        public double? TargetValue
        {
            get
            {
                if (this.SalesAmountExtract.TargetAmount == 0)
                    return null;
                return (double)this.SalesAmountExtract.TargetAmount;
            }
        }

        public decimal GrowthPercentage
        {
            get
            {
                if (this.TargetValue.GetValueOrDefault() == 0)
                    return 0;
                return ((decimal)(this.ActualValue / this.TargetValue.Value) * 100m - 100) / 100m;
            }
        }

        public double Profit
        {
            get
            {
                return this.ActualValue - (this.TargetValue.HasValue ? this.TargetValue.Value : 0);
            }
        }
    }
}