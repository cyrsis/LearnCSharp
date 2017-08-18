using System;

namespace ValueObjectsDemo
{
    class MoneyAmount
    {
        public decimal Amount { get; }
        public string CurrencySymbol { get; }

        public MoneyAmount(decimal amount, string currencySymbol)
        {
            this.Amount = amount;
            this.CurrencySymbol = currencySymbol;
        }

        public MoneyAmount Scale(decimal factor) =>
            new MoneyAmount(this.Amount * factor, this.CurrencySymbol);

        public static MoneyAmount operator *(MoneyAmount amount, decimal factor) => amount.Scale(factor);

        public override string ToString() => $"{this.Amount} {this.CurrencySymbol}";
    }
}
