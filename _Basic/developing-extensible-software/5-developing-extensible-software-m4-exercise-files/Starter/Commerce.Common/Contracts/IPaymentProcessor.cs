using System;
using System.Collections.Generic;
using System.Linq;

namespace Commerce.Common.Contracts
{
    public interface IPaymentProcessor
    {
        bool ProcessCreditCard(string customerName, string creditCard, string expirationDate, double amount);
    }
}