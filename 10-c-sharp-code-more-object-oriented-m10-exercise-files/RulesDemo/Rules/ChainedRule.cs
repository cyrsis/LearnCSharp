using System;

namespace Demo.Rules
{
    abstract class ChainedRule : IWarrantyRules
    {
        private IWarrantyRules Next { get; }

        protected ChainedRule(IWarrantyRules next)
        {
            this.Next = next;
        }

        protected void Forward(Action onValidClaim) => this.Next.Claim(onValidClaim);

        public void CircuitryOperational()
        {
            this.HandleCircuitryOperational();
            this.Next.CircuitryOperational();
        }

        public void CircuitryFailed()
        {
            this.HandleCircuitryFailed();
            this.Next.CircuitryFailed();
        }

        public void VisiblyDamaged()
        {
            this.HandleVisiblyDamaged();
            this.Next.VisiblyDamaged();
        }

        public void NotOperational()
        {
            this.HandleNotOperational();
            this.Next.NotOperational();
        }

        public void Operational()
        {
            this.HandleOperational();
            this.Next.Operational();
        }

        protected virtual void HandleCircuitryOperational() { }
        protected virtual void HandleCircuitryFailed() { }
        protected virtual void HandleVisiblyDamaged() { }
        protected virtual void HandleNotOperational() { }
        protected virtual void HandleOperational() { }

        public Action<Action> Claim { get; protected set; }
    }
}