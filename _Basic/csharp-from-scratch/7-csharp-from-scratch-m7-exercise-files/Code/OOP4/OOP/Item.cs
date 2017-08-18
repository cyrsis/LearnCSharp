using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP
{
    class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual void Purchase()
        {
            Console.WriteLine("Purchasing {0}", Name);
        }

        public static List<Item> GetItems(int numToGet)
        {
            var random = new Random();
            var newList = new List<Item>();
            Item newItem;
            for (int i = 0; i < numToGet; i++)
            {
                newItem = new Item() { ID = random.Next(), Name = "MyItem" + i.ToString() };
                newList.Add(newItem);
            }
            return newList;
            
        }
    }

    class Software : Item
    {
        public string ISBN { get; set; }
        public override void Purchase()
        {
            Console.WriteLine("My ID is {0} and my ISBN is {1}",
                                    ID, ISBN);
        }
    }

    class Hardware : Item
    {
        public string SerialNumber { get; set; }
    }

    class Computer : Hardware
    {
        public string CPUType { get; set; }
        public string Disks { get; set; }
        public override void Purchase()
        {
            base.Purchase();
            Console.WriteLine("myCPUType is {0}", CPUType);
        }
    }

    class Peripheral : Hardware
    {
        public string Description { get; set; }
    }


}
