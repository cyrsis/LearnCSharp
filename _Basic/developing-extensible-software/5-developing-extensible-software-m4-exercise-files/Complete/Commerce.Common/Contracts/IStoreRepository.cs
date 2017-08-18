using System;
using System.Collections.Generic;
using System.Linq;
using Commerce.Common.Entities;

namespace Commerce.Common.Contracts
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
