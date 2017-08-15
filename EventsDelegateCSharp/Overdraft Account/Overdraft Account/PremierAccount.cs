using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overdraft_Account
{
    class PremierAccount : OverdraftAccount
    {
        // Raise the OverdraftCovered event if -1000 <= Balance < 0.
        // Raise the Overdrawn event if Balance < -1000.
        public override decimal Balance
        {
            get { return base.Balance; }

            set
            {
                _Balance = value;

                if (_Balance < -1000)
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
    }
}
