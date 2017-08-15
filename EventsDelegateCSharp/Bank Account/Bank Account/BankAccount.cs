using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account
{
    class BankAccount
    {
        public event Action<BankAccount> Overdrawn;
        public event Action<BankAccount> BadlyOverdrawn;

        private decimal _Balance = 0;
        public decimal Balance
        {
            get { return _Balance; }
            set
            {
                _Balance = value;
                if (_Balance < -100)
                {
                    if (BadlyOverdrawn != null)
                        BadlyOverdrawn(this);
                }
                else if (_Balance < 0)
                {
                    if (Overdrawn != null)
                        Overdrawn(this);
                }
            }
        }
    }
}
