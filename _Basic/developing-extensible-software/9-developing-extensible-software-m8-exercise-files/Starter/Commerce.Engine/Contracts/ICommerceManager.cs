using System;
using System.Collections.Generic;
using System.Linq;
using Commerce.Common.DataModels;

namespace Commerce.Engine.Contracts
{
    public interface ICommerceManager
    {
        void ProcessOrder(OrderData orderData);
    }
}
