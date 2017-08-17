using Sixeyed.SpecFlowItAll.Domain.Model;
using Sixeyed.SpecFlowItAll.Domain.Model.Enums;
using Sixeyed.SpecFlowItAll.Domain.Suppliers.ReorderStrategies;

namespace Sixeyed.SpecFlowItAll.Domain.Suppliers
{
    public static class SupplierReorderStrategyFactory
    {
        public static IReorderStrategy Get(Supplier supplier)
        {
            IReorderStrategy strategy = null;
            switch ((ReorderType) supplier.ReorderType)
            {
                case ReorderType.Email:
                    strategy = new EmailReorderStrategy();
                    break;
                case ReorderType.Messaging:
                    strategy = new MessagingReorderStrategy();
                    break;
                case ReorderType.Service:
                    strategy = new ServiceReorderStrategy();
                    break;
            }
            strategy.Supplier = supplier;
            return strategy;
        }
    }
}
