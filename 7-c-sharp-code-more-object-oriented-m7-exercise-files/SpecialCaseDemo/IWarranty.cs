using System;

namespace SpecialCaseDemo
{
    internal interface IWarranty
    {
        void Claim(DateTime onDate, Action onValidClaim);
    }
}