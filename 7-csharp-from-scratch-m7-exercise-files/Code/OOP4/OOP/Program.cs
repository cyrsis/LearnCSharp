using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Item> myItems = Item.GetItems(20);
            foreach (Item item in myItems)
            {
                Console.WriteLine("New item ID = {0}, name = {1}",
                                    item.ID, item.Name);

            }
        }
    }
}
