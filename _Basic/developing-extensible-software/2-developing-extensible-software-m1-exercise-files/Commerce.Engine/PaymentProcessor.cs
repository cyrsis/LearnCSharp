using System;
using System.Collections.Generic;
using System.Linq;

namespace Commerce.Engine
{
    public class PaymentProcessor
    {
        public bool ProcessCreditCard(string customerName, string creditCard, string expirationDate, double amount)
        {
            // process credit card using Acme Payment Gateway and return success or failure
            Console.WriteLine("Credit card processed with Acme Payment Gateway for {0:c}.", amount);

            return true;
        }
    }
}
