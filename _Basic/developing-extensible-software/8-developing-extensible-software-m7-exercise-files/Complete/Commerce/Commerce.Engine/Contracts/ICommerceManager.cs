using System;
using System.Collections.Generic;
using System.Linq;
using Commerce.Engine.DataModels;

namespace Commerce.Engine.Contracts
{
    public interface ICommerceManager
    {
        DefaultMailer Mailer { get; set; }
        DefaultPaymentProcessor PaymentProcessor { get; set; }
        void ProcessOrder(OrderData orderData);
    }
}
