using System;
using System.Collections.Generic;
using System.Linq;

namespace Commerce.Engine.Contracts
{
    public interface IPaymentProcessor
    {
        bool ProcessCreditCard(string customerName, string creditCard, string expirationDate, double amount);
    }
}
