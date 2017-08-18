using System;
using System.Collections.Generic;
using System.Linq;
using Commerce.Engine;
using Commerce.Engine.Contracts;
using Commerce.Engine.DataModels;
using Commerce.Engine.Entities;

namespace Commerce.Engine.Contracts
{
    public interface IStoreRepository
    {
        List<Product> Products { get; }
        List<Inventory> ProductInventory { get; }
        List<Customer> Customers { get; }
        void Initialize();
        Customer GetCustomerByEmail(string email);
    }
}
