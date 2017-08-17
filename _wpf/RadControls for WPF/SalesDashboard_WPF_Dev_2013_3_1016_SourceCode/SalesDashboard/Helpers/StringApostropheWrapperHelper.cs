namespace SalesDashboard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class StringApostropheWrapperHelper
    {
        public static string WrapWithApostrophes(string text)
        {
            return string.Format("'{0}'", text);
        }
    }
}
