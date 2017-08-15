using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overdraft_Account
{
    class OverdrawnEventArgs : EventArgs
    {
        public BankAccount Account;
    }

    class BankAccount
    {
        public event EventHandler<OverdrawnEventArgs> Overdrawn;

        protected decimal _Balance = 0;
        public virtual decimal Balance
        {
            get { return _Balance; }
            set
            {
                _Balance = value;

                if (_Balance < 0)
                {
                    OverdrawnEventArgs args = new OverdrawnEventArgs();
                    args.Account = this;
                    OnOverdrawn(args);
                }
            }
        }

        protected virtual void OnOverdrawn(OverdrawnEventArgs args)
        {
            if (Overdrawn != null) Overdrawn(this, args);
        }
    }
}
