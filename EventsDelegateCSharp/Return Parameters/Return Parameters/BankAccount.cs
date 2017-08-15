using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Parameters
{
    class OverdrawnEventArgs : EventArgs
    {
        public BankAccount Account;
        public decimal NewBalance;
        public bool AllowOverdraft;
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
                if (value >= 0) _Balance = value;
                else
                {
                    OverdrawnEventArgs args = new OverdrawnEventArgs();
                    args.Account = this;
                    args.NewBalance = value;
                    args.AllowOverdraft = false;

                    OnOverdrawn(args);

                    if (args.AllowOverdraft) _Balance = value;
                }
            }
        }

        protected virtual void OnOverdrawn(OverdrawnEventArgs args)
        {
            if (Overdrawn != null) Overdrawn(this, args);
        }
    }
}
