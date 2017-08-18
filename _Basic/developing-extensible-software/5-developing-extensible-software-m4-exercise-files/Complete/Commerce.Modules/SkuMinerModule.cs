using Commerce.Common.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commerce.Modules
{
    public class SkuMinerModule : ICommerceModule
    {
        public SkuMinerModule()
        {
        }

        public SkuMinerModule(IMinerRepository minerRepository)
        {
            _MinerRepository = minerRepository;
        }

        public void Initialize(CommerceEvents events)
        {
            events.OrderItemProcessed += OnOrderItemProcessed;
        }

        IMinerRepository _MinerRepository = null;

        public void OnOrderItemProcessed(OrderItemProcessedEventArgs e)
        {
            // e.StoreRepository can be used here to access the hosting app's database

            if (_MinerRepository == null)
                _MinerRepository = new MinerRepository();

            if (e.OrderLineItemData.Sku == 101)
            {
                Console.WriteLine("Sku 101 was purchased on {0} and the data was mined.", DateTime.Now.ToString());
            }
        }
    }

    public interface IMinerRepository
    {
        void AccessDbHere();
    }
    public class MinerRepository : IMinerRepository
    {
        public void AccessDbHere()
        {
            
        }
    }
}
