using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sixeyed.SpecFlowItAll.Domain.Model;

namespace Sixeyed.SpecFlowItAll.MvcApplication.Controllers
{
    public class ProductsController : Controller
    {
        //
        // GET: /Products/

        public ActionResult Index()
        {
            var products = new List<Product>();
            using (var context = new ShopContext())
            {
                products.AddRange(context.Products);
            }
            return View(products);
        }

        //
        // GET: /Products/fish-heads

        public ActionResult Details(string id)
        {
            Product product = null;
            using (var context = new ShopContext())
            {
                product = context.Products.FirstOrDefault(x => x.Code == id);
            }
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
    }
}
