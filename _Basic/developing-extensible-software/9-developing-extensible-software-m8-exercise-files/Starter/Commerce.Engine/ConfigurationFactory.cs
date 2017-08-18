using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Commerce.Engine.Configuration;
using Commerce.Engine.Contracts;
using Commerce.Common;
using Commerce.Common.Contracts;
using Commerce.Common.Modules;
using System.IO;
using System.Reflection;

namespace Commerce.Engine
{
    // this class can be singleton'd by the DI container
    public class ConfigurationFactory : IConfigurationFactory
    {
        public ConfigurationFactory()
        {
            CommerceEngineConfigurationSection config = ConfigurationManager.GetSection("commerceEngine") as CommerceEngineConfigurationSection;
            if (config != null)
            {
                IPaymentProcessor paymentProcessor = Activator.CreateInstance(Type.GetType(config.PaymentProcessor.Type)) as IPaymentProcessor;
                IMailer mailer = Activator.CreateInstance(Type.GetType(config.Mailer.Type)) as IMailer;
                mailer.FromAddress = config.Mailer.FromAddress;
                mailer.SmtpServer = config.Mailer.SmtpServer;

                _PaymentProcessor = paymentProcessor;
                _Mailer = mailer;

                // handle modules
                _Events = new CommerceEvents();
                string moduleFolder = ConfigurationManager.AppSettings["moduleFolder"];
                string[] files = Directory.GetFiles(moduleFolder, "*.dll");
                foreach (string file in files)
                {
                    Assembly assembly = Assembly.LoadFrom(file);
                    Type[] types = assembly.GetTypes();
                    foreach (Type type in types)
                    {
                        if (type.GetInterfaces().Contains(typeof(ICommerceModule)))
                        {
                            IEnumerable<Attribute> attrs = type.GetCustomAttributes(typeof(CommerceModuleAttribute));
                            if (attrs.Count() > 0)
                            {
                                CommerceModuleAttribute moduleAttr = attrs.ToArray()[0] as CommerceModuleAttribute;
                                Console.WriteLine("Initializing module '{0}'.", moduleAttr.Name);
                                ICommerceModule module = Activator.CreateInstance(type) as ICommerceModule;
                                module.Initialize(_Events);
                            }
                        }
                    }
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
