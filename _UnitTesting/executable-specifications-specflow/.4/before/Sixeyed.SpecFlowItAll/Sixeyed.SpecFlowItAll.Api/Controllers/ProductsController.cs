using Sixeyed.SpecFlowItAll.Api.ActionFilters;
using Sixeyed.SpecFlowItAll.Domain.Model;
using Sixeyed.SpecFlowItAll.Domain.Suppliers;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace Sixeyed.SpecFlowItAll.Api.Controllers
{
    public class ProductsController : ApiController
    {
        [RequiresKey(Permission=Permission.Read)]
        public IHttpActionResult GetList(string fields = "")
        {
            var products = GetProducts(x=>x.Products, fields);
            return Ok(products);
        }

        [RequiresKey(Permission = Permission.Read)]
        public IHttpActionResult Get(string id, string fields = "")
        {
            var products = GetProducts(x => x.Products.Where(y => y.Code == id) as DbQuery<Product>, fields);
            if (!products.Any())
            {
                return NotFound();
            }
            return Ok(products.First());
        }

        [RequiresKey(Permission = Permission.Update)]
        public IHttpActionResult Put(string id, [FromBody]Product product)
        {
            using (var context = new ShopContext())
            {
                var originalProduct = context.Products.FirstOrDefault(x => x.Code == id);
                if (originalProduct == null)
                {
                    return NotFound();
                }
                originalProduct.StockCount = product.StockCount;
                originalProduct.IsAvailable = product.IsAvailable;
                context.SaveChanges();
            }

            //reorder if no stock but still for sale:
            if (product.StockCount == 0 && product.IsAvailable)
            {
                Supplier supplier = null;
                using (var context = new ShopContext())
                {
                    supplier = context.Products.FirstOrDefault(x => x.Code == id).Supplier;
                }
                var reorderStrategy = SupplierReorderStrategyFactory.Get(supplier);
                reorderStrategy.Reorder(id);
                return StatusCode(HttpStatusCode.Accepted);
            }

            return Ok();
        }

        private static List<Product> GetProducts(Func<ShopContext, DbQuery<Product>> queryBuilder, string fields)
        {
            var includes = fields.ToLower().Split(',');
            var products = new List<Product>();
            using (var context = new ShopContext())
            {
                context.Configuration.LazyLoadingEnabled = false;
                DbQuery<Product> query = queryBuilder(context);
                if (includes.Contains("supplier"))
                {
                    query = query.Include("Supplier");
                }
                products.AddRange(query);
                //dereference the supplier's products:
                products.ForEach(x =>
                {
                    if (x.Supplier != null)
                    {
                        x.Supplier.Products = null;
                    }
                });
            }
            return products;
        }
    }
}