using System;
using System.Collections.Generic;
using System.Linq;

namespace Commerce.Common.Modules
{
    public interface ICommerceModule
    {
        void Initialize(CommerceEvents events);
    }
}
