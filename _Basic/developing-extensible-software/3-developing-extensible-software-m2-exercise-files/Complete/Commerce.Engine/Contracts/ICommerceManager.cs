using System;
using System.Collections.Generic;
using System.Linq;
using Commerce.Engine.DataModels;

namespace Commerce.Engine.Contracts
{
    public interface ICommerceManager
    {
        void ProcessOrder(OrderData orderData);
    }
}
