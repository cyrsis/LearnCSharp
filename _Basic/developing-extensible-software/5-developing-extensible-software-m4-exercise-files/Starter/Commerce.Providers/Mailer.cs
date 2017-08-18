using System;
using System.Collections.Generic;
using System.Linq;
using Commerce.Common.Contracts;
using Commerce.Common.DataModels;

namespace Commerce.Providers
{
    public class Mailer : IMailer
    {
        public void SendInvoiceEmail(OrderData orderData)
        {
            Console.WriteLine("The following is your invoice for the order, sent to {0} using {1} from {2}.", orderData.CustomerEmail, SmtpServer, FromAddress);
        }

        public void SendRejectionEmail(OrderData orderData)
        {
            Console.WriteLine("I'm sorry {0}, your order could not be processed at this time.", orderData.CustomerEmail);
        }

        public string FromAddress { get; set; }

        public string SmtpServer { get; set; }
    }
}
