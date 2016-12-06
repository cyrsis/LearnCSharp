using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS
{
    class Ship
    {
        public string ShipID { get; set; }
        public string ShipDate { get; set; }
        public int TotalAfterTax { get; set; }
        public string Customer { get; set; }
        public int AmountPaid { get; set; }
        public int UnpiadAmount { get; set; }
        public string ShipStaff { get; set; }
        public string PaymentType { get; set; }
        public List<Items> ShipItems {get;set;}
        public string Notes { get; set; }

        public double getTaxTotals()
        {
            double sum = 0;
            foreach (var obj in ShipItems)
            {
                 sum =sum +( obj.Price * obj.Quantity * 1.06);
            }
            return sum;
        }
    }
}
