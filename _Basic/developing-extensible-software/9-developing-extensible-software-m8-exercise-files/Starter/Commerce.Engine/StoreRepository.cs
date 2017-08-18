using System;
using System.Collections.Generic;
using System.Linq;
using Commerce.Common.Contracts;
using Commerce.Common.Entities;

namespace Commerce.Engine.Data
{
    public class StoreRepository : IStoreRepository
    {
        public StoreRepository()
        {
            Initialize(); // mock-up data
        }

        List<Product> _Products = null;
        List<Inventory> _ProductInventory = null;
        List<Customer> _Customers = null;

        public List<Product> Products
        {
            get { return _Products; }
        }

        public List<Inventory> ProductInventory
        {
            get { return _ProductInventory; }
        }

        public List<Customer> Customers
        {
            get { return _Customers; }
        }

        public void Initialize()
        {
            _Products = new List<Product>()
                {
                    new Product() { Sku = 101, Description = "Asus GX 780ti GPU", UnitPrice = 659.00 },
                    new Product() { Sku = 102, Description = "Asus Rampage IV Black Motherboard", UnitPrice = 479.00 },
                    new Product() { Sku = 103, Description = "Intel I7 4930 Ivy Bridge CPU", UnitPrice = 529.00 },
                    new Product() { Sku = 104, Description = "Dell U2713 Monitor", UnitPrice = 609.00 },
                    new Product() { Sku = 105, Description = "Dell U3014 Monitor", UnitPrice = 1059.00 },
                    new Product() { Sku = 106, Description = "Samsung 840EVO SSD 1TB", UnitPrice = 589.00 },
                    new Product() { Sku = 107, Description = "Samsung 840EVO SSD 500GB", UnitPrice = 359.00 },
                    new Product() { Sku = 108, Description = "Cooler Master Cosmos II Tower Case", UnitPrice = 329.00 }
                };

            _ProductInventory = new List<Inventory>()
                {
                    new Inventory() { Sku = 101, QuantityInStock = 5 },
                    new Inventory() { Sku = 102, QuantityInStock = 2 },
                    new Inventory() { Sku = 103, QuantityInStock = 10 },
                    new Inventory() { Sku = 104, QuantityInStock = 15 },
                    new Inventory() { Sku = 105, QuantityInStock = 12 },
                    new Inventory() { Sku = 106, QuantityInStock = 8 },
                    new Inventory() { Sku = 107, QuantityInStock = 8 },
                    new Inventory() { Sku = 108, QuantityInStock = 3 }
                };

            _Customers = new List<Customer>()
                {
                	new Customer() { Email = "miguelcastro67@gmail.com", Name = "Miguel Castro", Purchases = new List<PurchasedItem>() },
                    new Customer() { Email = "jason.salmond@pluralsight.com", Name = "Jason Salmond", Purchases = new List<PurchasedItem>() },
                    new Customer() { Email = "aason.skonnard@pluralsight.com", Name = "Aaron Skonnard", Purchases = new List<PurchasedItem>() }
                };
        }

        public Customer GetCustomerByEmail(string email)
        {
            return _Customers.Where(item => item.Email == email).FirstOrDefault();
        }
    }
}
