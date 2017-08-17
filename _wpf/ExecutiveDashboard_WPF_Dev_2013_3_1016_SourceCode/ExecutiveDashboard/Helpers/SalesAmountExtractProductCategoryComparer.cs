namespace ExecutiveDashboard
{
    using System;
    using System.Collections.Generic;
#if !SILVERLIGHT
    using SalesAmountExtract = ExecutiveDashboard.AWDWDomainService.SalesAmountExtract;
#else
    using ExecutiveDashboard.Web;
#endif
    public class SalesAmountExtractProductCategoryComparer : IComparer<SalesAmountExtract>
    {
        public int Compare(SalesAmountExtract x, SalesAmountExtract y)
        {
            if (y.ProductCategory.Equals("bikes", StringComparison.InvariantCultureIgnoreCase))
                return 1;
            else if (x.ProductCategory.Equals("bikes", StringComparison.InvariantCultureIgnoreCase))
                return -1;
            else if (y.ProductCategory.Equals("components", StringComparison.InvariantCultureIgnoreCase))
                return 1;
            else if (x.ProductCategory.Equals("components", StringComparison.InvariantCultureIgnoreCase))
                return -1;
            else if (y.ProductCategory.Equals("clothing", StringComparison.InvariantCultureIgnoreCase))
                return 1;
            else if (x.ProductCategory.Equals("clothing", StringComparison.InvariantCultureIgnoreCase))
                return -1;
            else if (y.ProductCategory.Equals("accessories", StringComparison.InvariantCultureIgnoreCase))
                return 1;
            else if (x.ProductCategory.Equals("accessories", StringComparison.InvariantCultureIgnoreCase))
                return -1;
            return 0;
        }
    }    
    
    public class SalesAmountExtractWrapperProductCategoryComparer : IComparer<SalesAmountExtractWrapper>
    {
        public int Compare(SalesAmountExtractWrapper x, SalesAmountExtractWrapper y)
        {
            return new SalesAmountExtractProductCategoryComparer().Compare(x.SalesAmountExtract, y.SalesAmountExtract);
        }
    }
}