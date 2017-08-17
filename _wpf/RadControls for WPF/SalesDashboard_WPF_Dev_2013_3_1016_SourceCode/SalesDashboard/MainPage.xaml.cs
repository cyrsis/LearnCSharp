using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

using System.Windows;
using System.Windows.Controls;
using Telerik.Windows.Controls;
using System.Windows.Media.Imaging;

#if SILVERLIGHT
using System.ServiceModel.DomainServices.Client;
using System.Windows.Browser;
#endif

namespace SalesDashboard
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            LocalizationManager.DefaultCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = LocalizationManager.DefaultCulture;
            Thread.CurrentThread.CurrentUICulture = LocalizationManager.DefaultCulture;

            InitializeComponent();
        }

        private void OnTwitterButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
#if SILVERLIGHT
            string twitterShareUrl = string.Format("http://twitter.com/share?text={0}&url={1}&related=Telerik",
                                                   HttpUtility.UrlEncode(string.Format("A dashboard done right! By #Telerik. ")),
                                                   "http://demos.telerik.com/silverlight/salesmanagerdashboard/Default.aspx?utm_source=twitter&utm_medium=game&utm_campaign=demo");
            HtmlPage.Window.Navigate(new Uri(twitterShareUrl), "_blank");
#else            
            string twitterShareUrl = @"http://twitter.com/share?text=A+dashboard+done+right%21+By+%23Telerik.+&url=http%3A%2F%2Fdemos.telerik.com%2Fsilverlight%2Fsalesmanagerdashboard%2FDefault.aspx?utm_source=twitter&utm_medium=game&utm_campaign=demo&related=Telerik";
            System.Diagnostics.Process.Start(twitterShareUrl);
#endif
        }

		private void OnDownloadButtonClick(object sender, System.Windows.RoutedEventArgs e)
		{
#if SILVERLIGHT
            var url = @"http://www.telerik.com/account/your-products/trial-product-versions/trial-single-download.aspx?pmvid=0&pid=571";
			HtmlPage.Window.Navigate(new Uri(url), "_blank");
#else
            var url = @"http://www.telerik.com/account/your-products/trial-product-versions/trial-single-download.aspx?pmvid=0&pid=601";
            System.Diagnostics.Process.Start(url);
#endif
		}
    }
}
