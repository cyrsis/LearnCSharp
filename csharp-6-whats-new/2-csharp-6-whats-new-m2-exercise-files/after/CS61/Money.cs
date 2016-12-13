using System;

namespace CS61
{
    public struct Money(decimal amount, string currency)
    {
        public Money(int amount) : this(amount, "eur")
        {

        }
        
        public string Currency { get; } = Check.ArgNotNull("currency", currency);
        public decimal Amount { get; } = amount;
    }
}
