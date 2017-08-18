using System;
using Demo.Rules;

namespace Demo
{
    class Program
    {

        static void Main(string[] args)
        {

            IWarranty moneyBackGuraantee =
                new TimeLimitedWarranty(DateTime.Today, TimeSpan.FromDays(7));

            IWarranty expressWarranty =
                new TimeLimitedWarranty(DateTime.Today, TimeSpan.FromDays(365));

            IWarranty circuitryWarranty =
                new LifetimeWarranty(DateTime.Today);

            SoldArticle article = new SoldArticle(moneyBackGuraantee, expressWarranty, new ChristmassRules());
            article.InstallCircuitry(new Part(DateTime.Now), circuitryWarranty);

            Console.ReadLine();

        }
    }
}
