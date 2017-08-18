using System;
using System.Collections.Generic;
using System.Linq;
using Commerce.Common.DataModels;

namespace Commerce.Common.Contracts
{
    public interface IMailer
    {
        void SendInvoiceEmail(OrderData orderData);
        void SendRejectionEmail(OrderData orderData);

        string FromAddress { get; set; }
        string SmtpServer { get; set; }
    }
}
