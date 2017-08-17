using Sixeyed.SpecFlowItAll.Domain.Model;
using Sixeyed.SpecFlowItAll.Domain.ServiceAgents.OrderService;

namespace Sixeyed.SpecFlowItAll.Domain.Suppliers.ReorderStrategies
{
    public class ServiceReorderStrategy : IReorderStrategy
    {
        public Supplier Supplier { get; set; }

        public void Reorder(string productCode)
        {
            using (var client = new OrderServiceClient("OrderServiceClient", Supplier.ReorderAddress))
            {
                client.Place("ATTAP", productCode);
            }
        }
    }
}
