using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Commerce.Common.DataModels;
using System.Collections.Generic;
using Commerce.Common.Entities;
using Moq;
using Commerce.Common.Contracts;
using Commerce.Common.Modules;
using Commerce.Engine.Contracts;
using Commerce.Engine;

namespace Commerce.Tests
{
    [TestClass]
    public class CommerceManagerTests
    {
        [TestMethod]
        public void TestProcessOrder()
        {
            OrderData orderData = new OrderData()
            {
                CustomerEmail = "miguelcastro67@gmail.com",
                CreditCard = "1234123412341234",
                ExpirationDate = "012020",
                LineItems = new List<OrderLineItemData>()
                    {
                        new OrderLineItemData() { Sku = 1, Quantity = 5, PurchasePrice = 10.00 },
                        new OrderLineItemData() { Sku = 2, Quantity = 7, PurchasePrice = 12.00 }
                    }
            };

            Customer customer = new Customer()
            {
                Name = "Miguel Castro",
                Email = "miguelcastro67@gmail.com",
                Purchases = new List<PurchasedItem>()
            };

            List<Product> products = new List<Product>()
                {
                	new Product() { Sku = 1, Description = "Item 1", UnitPrice = 10.00 },
                    new Product() { Sku = 2, Description = "Item 2", UnitPrice = 12.00 }
                };

            List<Inventory> inventory = new List<Inventory>()
                {
                	new Inventory() { Sku = 1, QuantityInStock = 100 },
                    new Inventory() { Sku = 2, QuantityInStock = 100 }
                };

            Mock<IStoreRepository> mockStoreRepository = new Mock<IStoreRepository>();
            mockStoreRepository.Setup(obj => obj.GetCustomerByEmail(orderData.CustomerEmail)).Returns(customer);
            mockStoreRepository.Setup(obj => obj.Products).Returns(products);
            mockStoreRepository.Setup(obj => obj.ProductInventory).Returns(inventory);

            Mock<IPaymentProcessor> mockPaymentProcessor = new Mock<IPaymentProcessor>();
            mockPaymentProcessor.Setup(obj => obj.ProcessCreditCard(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<double>())).Returns(true);

            Mock<IMailer> mockMailer = new Mock<IMailer>();
            mockMailer.Setup(obj => obj.SendInvoiceEmail(orderData)).Verifiable();

            CommerceEvents commerceEvents = new CommerceEvents();

            Mock<IConfigurationFactory> mockConfigurationFactory = new Mock<IConfigurationFactory>();
            mockConfigurationFactory.Setup(obj => obj.GetPaymentProcessor()).Returns(mockPaymentProcessor.Object);
            mockConfigurationFactory.Setup(obj => obj.GetMailer()).Returns(mockMailer.Object);
            mockConfigurationFactory.Setup(obj => obj.GetEvents()).Returns(commerceEvents);

            CommerceManager commerceManager = new CommerceManager(mockStoreRepository.Object, mockConfigurationFactory.Object);
            commerceManager.ProcessOrder(orderData);

            // any assertions go here
        }
    }
}
