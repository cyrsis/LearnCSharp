using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Commerce.Engine.Configuration;
using Commerce.Engine.Contracts;
using Commerce.Common;
using Commerce.Common.Contracts;

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
            }
        }

        IPaymentProcessor _PaymentProcessor;
        IMailer _Mailer;

        IPaymentProcessor IConfigurationFactory.GetPaymentProcessor()
        {
            return _PaymentProcessor;
        }

        IMailer IConfigurationFactory.GetMailer()
        {
            return _Mailer;
        }
    }
}
