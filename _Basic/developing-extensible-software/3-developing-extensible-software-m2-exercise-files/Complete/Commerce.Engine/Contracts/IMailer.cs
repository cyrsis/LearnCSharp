using System;
using System.Collections.Generic;
using System.Linq;
using Commerce.Engine.DataModels;

namespace Commerce.Engine.Contracts
{
    public interface IMailer
    {
        void SendInvoiceEmail(OrderData orderData);
        void SendRejectionEmail(OrderData orderData);
    }
}
