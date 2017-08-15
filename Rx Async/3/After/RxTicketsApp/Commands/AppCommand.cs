using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxTicketsApp.Commands
{
    public abstract class AppCommand
    {
        public DateTime Issued { get; private set; }
        public string Issuer { get; private set; }

        public AppCommand()
        {
            this.Issued = DateTime.Now;
            this.Issuer = "ekapic";
        }
    }
}
