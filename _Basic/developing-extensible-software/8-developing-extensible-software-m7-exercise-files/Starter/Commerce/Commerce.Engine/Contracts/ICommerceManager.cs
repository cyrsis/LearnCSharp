using System;
using System.Collections.Generic;
using System.Linq;
using Commerce.Engine.DataModels;

namespace Commerce.Engine.Contracts
{
    public interface ICommerceManager
    {
        string FromAddress { get; set; }
        string SmtpServer { get; set; }
        void ProcessOrder(OrderData orderData);
    }
}
