using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class Note : Storable
    {
        public void Write(object obj)
        {
            Console.WriteLine("Writing obj to disk...");
        }

        public string Read()
        {
            return "Reading note from disk";
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

        public void OtherMethod()
        {
            Console.WriteLine("Some other method of Note");
        }


    }
}
