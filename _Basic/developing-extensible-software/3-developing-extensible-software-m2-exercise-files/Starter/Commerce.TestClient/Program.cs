using System;
using System.Collections.Generic;
using System.Linq;
using Commerce.Engine;
using Commerce.Engine.Data;
using Commerce.Engine.DataModels;

namespace Commerce.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreRepository storeRepository = new StoreRepository();
            storeRepository.Initialize();

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

            CommerceManager commerceEngine = new CommerceManager(storeRepository);
            commerceEngine.ProcessOrder(orderData);

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to exit.");
            Console.ReadLine();
        }
    }
}
