using System;

namespace Demo
{
    public interface IWarrantyRulesFactory
    {
        IWarrantyRules Create(Action<Action> claimMoneyBack,
                              Action<Action> claimNotOperationalWarranty, 
                              Action<Action> claimCircuitryWarranty);
    }
}