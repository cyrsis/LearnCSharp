using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_EX
{
    class Stock:SIS
    {
        private int amount;
        public override int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (value < 0)
                {
                    amount = 0;
                }
                else
                {
                    amount = value;
                }
            }
        }

        public override int getTotals()
        {
            return 2000;
        }
        public override int getInventory()
        {
            return 100;
        }

    }
}
