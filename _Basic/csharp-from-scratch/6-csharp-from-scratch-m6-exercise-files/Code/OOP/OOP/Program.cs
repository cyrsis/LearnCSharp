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
            var newWarehouse = new Warehouse("Warehouse 1", 101);
            var myItem = newWarehouse.FindAndReturnItem(101);
            Console.WriteLine("my new item is " + myItem.Name);
        }
    }
}
