using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mod02_MemoryLeak
{
    class DbConnection
    {
        public void Open()
        {
            // Simulate connecting to a database
            Thread.Sleep(10);
        }

        public byte[] GenerateResponse(Guid requestId)
        {
            return new byte[1000];
        }

        public void Close()
        {
            // Simulate disconnecting from the database
            Thread.Sleep(20);
        }
    }
}
