using System;
using System.Collections.Generic;
using System.Linq;

namespace Commerce.Common.Modules
{
    public class CommerceEvents
    {
        public CommerceModuleDelegate<OrderItemProcessedEventArgs> OrderItemProcessed { get; set; }
    }
}
