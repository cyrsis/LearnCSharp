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
            Item newItem = Item.GetItem();
            Console.WriteLine("New item ID = {0}, name = {1}",
                                newItem.ID, newItem.Name);
        }
    }
}
