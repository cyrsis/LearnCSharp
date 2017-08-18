using System;

namespace Demo
{
    public interface IWarrantyRules
    {
        void CircuitryOperational();
        void CircuitryFailed();
        void VisiblyDamaged();
        void NotOperational();
        void Operational();
        Action<Action> Claim { get; }
    }
}