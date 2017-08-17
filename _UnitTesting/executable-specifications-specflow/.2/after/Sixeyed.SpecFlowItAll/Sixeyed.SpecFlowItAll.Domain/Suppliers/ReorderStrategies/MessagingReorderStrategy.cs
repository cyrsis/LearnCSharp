using Newtonsoft.Json;
using Sixeyed.SpecFlowItAll.Domain.Model;
using System.Messaging;

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
            using (var queue = new MessageQueue(Supplier.ReorderAddress))
            {
                queue.Send(messageJson);
            }
        }

        private class ReorderMessage
        {
            public string ProductCode { get; set; }
            public string CustomerId { get; set; }
        }
    }
}
