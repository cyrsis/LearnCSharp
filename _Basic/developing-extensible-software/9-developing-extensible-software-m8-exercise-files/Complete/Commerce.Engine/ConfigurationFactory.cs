using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Configuration;
using System.Linq;
using System.Reflection;
using Commerce.Common.Contracts;
using Commerce.Common.Modules;
using Commerce.Engine.Contracts;

namespace Commerce.Engine
{
    [Export(typeof(IConfigurationFactory))]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public class ConfigurationFactory : IConfigurationFactory
    {
        [ImportingConstructor]
        public ConfigurationFactory(IPaymentProcessor paymentProcessor, IMailer mailer, [ImportMany]IEnumerable<ICommerceModule> modules)
        {
            mailer.FromAddress = ConfigurationManager.AppSettings["mailerFromAddress"];
            mailer.SmtpServer = ConfigurationManager.AppSettings["mailerSmtpServer"];

            _PaymentProcessor = paymentProcessor;
            _Mailer = mailer;

            //// handle modules
            _Events = new CommerceEvents();
            if (modules == null || modules.Count() == 0) Console.WriteLine("NO MODULES");

            foreach (ICommerceModule module in modules)
            {
                IEnumerable<Attribute> attrs = module.GetType().GetCustomAttributes(typeof(CommerceModuleAttribute));
                if (attrs.Count() > 0)
                {
                    CommerceModuleAttribute moduleAttr = attrs.ToArray()[0] as CommerceModuleAttribute;
                    Console.WriteLine("Initializing module '{0}'.", moduleAttr.Name);
                    module.Initialize(_Events);
                }
            }
        }

        IPaymentProcessor _PaymentProcessor;
        IMailer _Mailer;
        CommerceEvents _Events;

        IPaymentProcessor IConfigurationFactory.GetPaymentProcessor()
        {
            return _PaymentProcessor;
        }

        IMailer IConfigurationFactory.GetMailer()
        {
            return _Mailer;
        }

        CommerceEvents IConfigurationFactory.GetEvents()
        {
            return _Events;
        }
    }
}
