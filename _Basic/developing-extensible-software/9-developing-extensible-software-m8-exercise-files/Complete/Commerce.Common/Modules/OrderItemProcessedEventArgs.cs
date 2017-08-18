using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Commerce.Common.DataModels;
using Commerce.Common.Entities;
using Commerce.Common.Contracts;

namespace Commerce.Common.Modules
{
    public class OrderItemProcessedEventArgs : CancelEventArgs
    {
        public OrderItemProcessedEventArgs(Customer customer, OrderLineItemData orderLineItemData,
            IStoreRepository storeRepository)            
        {
            Customer = customer;
            OrderLineItemData = orderLineItemData;
            MessageText = String.Empty;
            StoreRepository = storeRepository;
        }

        public Customer Customer { get; set; }
        public OrderLineItemData OrderLineItemData { get; set; }
        public string MessageText { get; set; }
        public IStoreRepository StoreRepository { get; set; }
    }
}
