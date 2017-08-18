using System;
using System.Collections.Generic;
using System.Linq;
using Commerce.Common.Modules;

namespace Commerce.Modules
{
    [CommerceModule(Name = "SkuMiner")]
    public class SkuMinerModule : ICommerceModule
    {
        public void Initialize(CommerceEvents events)
        {
            events.OrderItemProcessed += OnOrderItemProcessed;
        }

        public void OnOrderItemProcessed(OrderItemProcessedEventArgs e)
        {
            if (e.OrderLineItemData.Sku == 101)
            {
                Console.WriteLine("Sku 101 was purchased on {0} and the data was mined.", DateTime.Now.ToString());
            }
        }
    }
}
