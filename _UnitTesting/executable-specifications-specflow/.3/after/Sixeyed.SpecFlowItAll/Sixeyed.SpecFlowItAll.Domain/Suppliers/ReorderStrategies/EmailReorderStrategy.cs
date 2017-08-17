using Sixeyed.SpecFlowItAll.Domain.Model;
using System.Net.Mail;

namespace Sixeyed.SpecFlowItAll.Domain.Suppliers.ReorderStrategies
{
    public class EmailReorderStrategy : IReorderStrategy
    {
        public Supplier Supplier { get; set; }

        public void Reorder(string productCode)
        {
            var toAddress = Supplier.ReorderAddress;
            var fromAddress = "buyer@attap.com";
            var subject = "Order request - product code: " + productCode;
            var body = "Hi, please can we have some more " + productCode + ", thanks.";
            
            var email = new MailMessage(fromAddress, toAddress, subject, body);
            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Send(email);
            }
        }
    }
}
