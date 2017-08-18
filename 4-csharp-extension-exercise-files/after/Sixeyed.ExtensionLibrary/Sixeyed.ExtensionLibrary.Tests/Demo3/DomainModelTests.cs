using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sixeyed.ExtensionLibrary.Domain.Model;

namespace Sixeyed.Extensions.Samples.Test
{
    [TestClass]
    public class ModelTests
    {
        [TestMethod]
        public void SaveChanges()
        {
            using (var container = new DomainModelContainer())
            {
                var product1 = new Product
                {
                    Name = "Item 1"
                };
                var product2 = new Product
                {
                    Name = "Item 2"
                };
                var customer = new Customer
                {
                    FirstName = "Elton",
                    LastName = "Stoneman"
                };
                var order = new Order
                {
                    Reference = Guid.NewGuid().ToString(),
                    Customer = customer
                };
                order.Products.Add(product1);
                order.Products.Add(product2);
                container.Orders.Add(order);
                container.Save();
            }
        }

        [TestMethod]
        public void UpdateOrder()
        {
            using (var container = new DomainModelContainer())
            {
                var order = container.Orders.First();
                order.Reference += ".1";
                container.Save();
            }
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void UpdateProduct()
        {
            using (var container = new DomainModelContainer())
            {
                var product = container.Products.First();
                product.Name += " - new!";
                container.Save();
            }
        }
    }
}
