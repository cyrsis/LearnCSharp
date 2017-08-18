using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var storableObjects = new List<Storable>();
            Note myNote = new Note();
            storableObjects.Add(myNote);
            DBEntry myDBEntry = new DBEntry();
            storableObjects.Add(myDBEntry);
            myDBEntry = new DBEntry();
            storableObjects.Add(myDBEntry);
            myNote = new Note();
            storableObjects.Add(myNote);
            myNote = new Note();
            storableObjects.Add(myNote);

            foreach (Storable storable in storableObjects)
            {
                storable.Write(null);
                Console.WriteLine(storable.Read());

            }

        }
    }
}
