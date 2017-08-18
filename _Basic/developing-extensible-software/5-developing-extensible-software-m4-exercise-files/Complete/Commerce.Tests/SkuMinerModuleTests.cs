using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Commerce.Modules;
using Commerce.Common.Entities;
using Commerce.Common.DataModels;
using Commerce.Common.Modules;
using Commerce.Common.Contracts;

namespace Commerce.Tests
{
    [TestClass]
    public class SkuMinerModuleTests
    {
        [TestMethod]
        public void TestSelfContainedSkuMining()
        {
            Mock<IMinerRepository> mockMinerRepository = new Mock<IMinerRepository>();
            mockMinerRepository.Setup(obj => obj.AccessDbHere());

            SkuMinerModule module = new SkuMinerModule(mockMinerRepository.Object);

            Customer customer = new Customer(); // setup up any properties needed
            OrderLineItemData orderLineItemData = new OrderLineItemData(); // setup properties here

            OrderItemProcessedEventArgs args = new OrderItemProcessedEventArgs(customer, orderLineItemData, null);

            module.OnOrderItemProcessed(args);
            
            // make assertions here
        }

        [TestMethod]
        public void TestCoupledSkuMining()
        {
            Mock<IStoreRepository> mockStoreRepository = new Mock<IStoreRepository>();

            SkuMinerModule module = new SkuMinerModule();

            Customer customer = new Customer(); // setup up any properties needed
            OrderLineItemData orderLineItemData = new OrderLineItemData(); // setup properties here

            OrderItemProcessedEventArgs args = new OrderItemProcessedEventArgs(
                customer, orderLineItemData, mockStoreRepository.Object);

            module.OnOrderItemProcessed(args);

            // make assertions here
        }
    }
}
