using Newtonsoft.Json;
using Sixeyed.SpecFlowItAll.Domain.Model;
using System.IO;
using System.Messaging;
using System.Text;

namespace Sixeyed.SpecFlowItAll.Domain.Suppliers.ReorderStrategies
{
    public class MessagingReorderStrategy : IReorderStrategy
    {
        public Supplier Supplier { get; set; }

        public void Reorder(string productCode)
        {
            var reorderMessage = new ReorderMessage
                {
                    CustomerId = "ATTAP",
                    ProductCode = productCode
                };
            var messageJson = JsonConvert.SerializeObject(reorderMessage);
            using (var messageStream = new MemoryStream(Encoding.Default.GetBytes(messageJson)))
            {
                var outbound = new Message();
                outbound.BodyStream = messageStream;
                using (var queue = new MessageQueue(Supplier.ReorderAddress))
                {
                    queue.Send(outbound);
                }
            }
        }

        private class ReorderMessage
        {
            public string ProductCode { get; set; }
            public string CustomerId { get; set; }
        }
    }
}
