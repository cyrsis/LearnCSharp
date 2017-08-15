using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overdraft_Account
{
    class OverdraftAccount : BankAccount
    {
        public override decimal Balance
        {
            get { return base.Balance; }

            set
            {
                _Balance = value;

                if (_Balance < -100)
                {
                    OverdrawnEventArgs args = new OverdrawnEventArgs();
                    args.Account = this;
                    OnOverdrawn(args);
                }
                else if (_Balance < 0)
                {
                    OverdrawnEventArgs args = new OverdrawnEventArgs();
                    args.Account = this;
                    OnOverdraftCovered(args);
                }
            }
        }

        // Add a new OverdraftCovered event.
        // It can reuse the OverdrawnEventArgs parameter type.
        public event EventHandler<OverdrawnEventArgs> OverdraftCovered;
        protected virtual void OnOverdraftCovered(OverdrawnEventArgs args)
        {
            if (OverdraftCovered != null)
                OverdraftCovered(this, args);
        }
    }
}
