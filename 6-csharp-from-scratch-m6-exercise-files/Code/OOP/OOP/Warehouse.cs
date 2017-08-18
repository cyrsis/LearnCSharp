using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Warehouse
    {
        public int ID { get; set; }
        public string WarehouseName { get; set; }

        public Warehouse(string Name, int ID)
        {
            WarehouseName = Name;
            this.ID = ID;
        }
        public Item FindAndReturnItem(int itemID)
        {
            Item returnItem = new Item() { ID = itemID, Name="Microsoft Office" };
            return returnItem;
        }
    }
}
