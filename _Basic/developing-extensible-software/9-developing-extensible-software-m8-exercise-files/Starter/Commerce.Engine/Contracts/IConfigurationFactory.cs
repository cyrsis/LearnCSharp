using System;
using System.Collections.Generic;
using System.Linq;
using Commerce.Engine.Configuration;
using Commerce.Common;
using Commerce.Common.Contracts;
using Commerce.Common.Modules;

namespace Commerce.Engine.Contracts
{
    public interface IConfigurationFactory
    {
        IPaymentProcessor GetPaymentProcessor();
        IMailer GetMailer();
        CommerceEvents GetEvents();
    }
}
