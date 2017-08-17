using Newtonsoft.Json;
using Sixeyed.SpecFlowItAll.Domain.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Sixeyed.SpecFlowItAll.MvcApplication.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/
        public async Task<ActionResult> Index()
        {
            var json = string.Empty;
            using (var client = GetApiClient())
            {
                json = await client.GetStringAsync("products");
            }
            var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);
            return View(products);
        }

        //
        // GET: /Products/fish-heads
        public async Task<ActionResult> Details(string id)
        {
            Product product = null;
            var json = string.Empty;
            using (var client = GetApiClient())
            {
                json = await client.GetStringAsync(string.Format("products/{0}", id));
            }
            product = JsonConvert.DeserializeObject<Product>(json);
            if (!product.IsAvailable)
            {
                return View("Unavailable", product);
            }
            else if (product.StockCount == 0)
            {
                return View("OnOrder", product);
            }
            return View(product);
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
