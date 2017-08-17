using Newtonsoft.Json;
using Sixeyed.SpecFlowItAll.Domain.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Sixeyed.SpecFlowItAll.WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadGrid();
        }

        private async void LoadGrid()
        {
            var relativeUrl = "products?fields=supplier";
            var products = await GetResponse<IEnumerable<Product>>(relativeUrl);
            var productViewSource = ((CollectionViewSource) (this.FindResource("productViewSource")));
            productViewSource.Source = products;
        }

        private void Reorder_Click(object sender, RoutedEventArgs e)
        {
            var productCode = ((Button)sender).CommandParameter as string;
            UpdateProduct(productCode, true);
        }

        private void Discontinue_Click(object sender, RoutedEventArgs e)
        {
            var productCode = ((Button)sender).CommandParameter as string;
            UpdateProduct(productCode, false);
        }

        private async Task<T> GetResponse<T>(string relativeUrl, params object[] args)
        {
            relativeUrl = string.Format(relativeUrl, args);
            using (var client = GetApiClient())
            {
                var json = await client.GetStringAsync(relativeUrl);
                return JsonConvert.DeserializeObject<T>(json);
            }
        }

        private async void UpdateProduct(string productCode, bool isAvailable)
        {
            var partialProduct = new {
                stockCount = 0,
                isAvailable = isAvailable
            };
            var putJson = JsonConvert.SerializeObject(partialProduct);
            var relativeUrl = string.Format("products/{0}", productCode);
            using (var client = GetApiClient())
            {
                using (var content = new StringContent(putJson))
                {
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    await client.PutAsync(relativeUrl, content);
                }
            }
            LoadGrid();
        }

        private HttpClient GetApiClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["api.url"]);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("x-api-key", ConfigurationManager.AppSettings["api.key"]);
            return client;
        }
    }
}
