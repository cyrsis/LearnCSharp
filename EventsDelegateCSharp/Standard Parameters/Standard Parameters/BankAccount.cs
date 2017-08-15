using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standard_Parameters
{
    class DebitedEventArgs : EventArgs
    {
        public BankAccount Account;
    }

    class OverdrawnEventArgs : EventArgs
    {
        public BankAccount Account;
    }

    class BankAccount
    {
        //public event Action<object, OverdrawnEventArgs> Overdrawn;
        public event EventHandler<OverdrawnEventArgs> Overdrawn;

        public event EventHandler<DebitedEventArgs> Debited;
         
        private decimal _Balance = 0;
        public decimal Balance
        {
            get { return _Balance; }
            set
            {
                bool isDebit = (value < _Balance);

                _Balance = value;

                if (isDebit)
                    if (Debited != null)
                    {
                        DebitedEventArgs args = new DebitedEventArgs();
                        args.Account = this;
                        Debited(this, args);
                    }

                if (_Balance < 0)
                    if (Overdrawn != null)
                    {
                        OverdrawnEventArgs args =
                            new OverdrawnEventArgs();
                        args.Account = this;
                        Overdrawn(this, args);
                    }
            }
        }
    }
}
