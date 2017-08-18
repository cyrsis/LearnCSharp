using System;
using System.Collections.Generic;
using System.Linq;
using Commerce.Common.Modules;

namespace Commerce.Modules
{
    [CommerceModule(Name = "ItemPromotion")]
    public class ItemPromotionModule : ICommerceModule
    {
        public void Initialize(CommerceEvents events)
        {
            events.OrderItemProcessed += OnOrderItemProcessed;
        }

        void OnOrderItemProcessed(OrderItemProcessedEventArgs e)
        {
            if (e.OrderLineItemData.Sku == 102)
            {
                e.OrderLineItemData.PurchasePrice -= 30.00;
            }
        }
    }
}
