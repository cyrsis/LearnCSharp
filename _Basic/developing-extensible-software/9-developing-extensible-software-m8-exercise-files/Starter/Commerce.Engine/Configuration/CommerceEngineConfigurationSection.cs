using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Commerce.Engine.Configuration
{
    public class CommerceEngineConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("paymentProcessor", IsRequired = true)]
        public PaymentProcessorElement PaymentProcessor
        {
            get { return (PaymentProcessorElement)base["paymentProcessor"]; }
            set { base["paymentProcessor"] = value; }
        }

        [ConfigurationProperty("mailer", IsRequired = true)]
        public MailerElement Mailer
        {
            get { return (MailerElement)base["mailer"]; }
            set { base["mailer"] = value; }
        }
    }
}
