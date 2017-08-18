using System;
using OptionDemo.Common;
using OptionDemo.Common.Interfaces;

namespace OptionDemo
{
    class SoldArticle
    {

        public IWarranty MoneyBackGuarantee { get; private set; }
        public IWarranty ExpressWarranty { get; private set; }

        private IWarranty NotOperationalWarranty { get; }

        private IOption<Part> Circuitry { get; set; } = Option<Part>.None();
        private IWarranty FailedCircuitryWarranty { get; set; }
        private IWarranty CircuitryWarranty { get; set; }

        public SoldArticle(IWarranty moneyBack, IWarranty express)
        {
            if (moneyBack == null)
                throw new ArgumentNullException(nameof(moneyBack));
            if (express == null)
                throw new ArgumentNullException(nameof(express));

            this.MoneyBackGuarantee = moneyBack;
            this.ExpressWarranty = VoidWarranty.Instance;
            this.NotOperationalWarranty = express;
            this.CircuitryWarranty = VoidWarranty.Instance;

        }

        public void VisibleDamage()
        {
            this.MoneyBackGuarantee = VoidWarranty.Instance;
        }

        public void NotOperational()
        {
            this.MoneyBackGuarantee = VoidWarranty.Instance;
            this.ExpressWarranty = this.NotOperationalWarranty;
        }

        public void InstallCircuitry(Part circuitry, IWarranty extendedWarranty)
        {
            this.Circuitry = Option<Part>.Some(circuitry);
            this.FailedCircuitryWarranty = extendedWarranty;
        }

        public void CircuitryNotOperational(DateTime detectedOn)
        {
            this.Circuitry.WhenSome().Do(
                circuitry =>
                {
                    circuitry.MarkDefective(detectedOn);
                    this.CircuitryWarranty = this.FailedCircuitryWarranty;
                });
        }

        public void ClaimCircuitryWarranty(Action onValidClaim)
        {
            this.Circuitry.WhenSome().Do(
                circuitry => 
                    this.CircuitryWarranty.Claim(circuitry.DefectDetectedOn, onValidClaim));
        }

    }
}
