using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using Commerce.Common.DataModels;
using Commerce.Engine.Contracts;
using Commerce.Engine.Data;
using Commerce.Providers;
using System.Configuration;

namespace Commerce.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            AggregateCatalog catalog = new AggregateCatalog();

            catalog.Catalogs.Add(new AssemblyCatalog(typeof(StoreRepository).Assembly));
            catalog.Catalogs.Add(new AssemblyCatalog(typeof(AcmePaymentProcessor).Assembly));
            catalog.Catalogs.Add(new DirectoryCatalog(ConfigurationManager.AppSettings["moduleFolder"]));

            CompositionContainer container = new CompositionContainer(catalog);

            OrderData orderData = new OrderData()
            {
                CustomerEmail = "miguelcastro67@gmail.com",
                LineItems = new List<OrderLineItemData>()
                {
                    new OrderLineItemData() { Sku = 102, PurchasePrice = 479.00, Quantity = 1 },
                    new OrderLineItemData() { Sku = 101, PurchasePrice = 659.00, Quantity = 2 },
                    new OrderLineItemData() { Sku = 103, PurchasePrice = 529.00, Quantity = 1 },
                    new OrderLineItemData() { Sku = 104, PurchasePrice = 609.00, Quantity = 3 }
                },
                CreditCard = "1234123412341234",
                ExpirationDate = "1217"
            };

            ICommerceManager commerceEngine = container.GetExportedValue<ICommerceManager>();
            commerceEngine.ProcessOrder(orderData);

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to exit.");
            Console.ReadLine();
        }
    }
}
