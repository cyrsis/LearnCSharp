using System;

namespace Demo
{
    interface IWarranty
    {
        void Claim(DateTime onDate, Action onValidClaim);
    }
}