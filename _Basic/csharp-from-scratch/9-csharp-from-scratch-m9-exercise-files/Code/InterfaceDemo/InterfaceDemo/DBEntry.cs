using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class DBEntry : Storable
    {
        public void Write(object obj)
        {
            Console.WriteLine("Writing obj to database...");
        }

        public string Read()
        {
            return "Reading entry from database";
        }

        private ReturnStatus status;
        public ReturnStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
    }
}
