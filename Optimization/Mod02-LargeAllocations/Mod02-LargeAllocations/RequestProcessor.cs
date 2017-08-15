using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod02_LargeAllocations
{
    class RequestProcessor
    {
        protected virtual byte[] GetBuffer(int size)
        {
            return new byte[size];
        }
        protected virtual void ReturnBuffer(byte[] buffer)
        {
        }

        public void ProcessRequest(int dataSize, int load)
        {
            byte[] buffer = GetBuffer(dataSize);

            // Simulate load
            Random rand = new Random();
            for (int i = 0; i < load; ++i)
            {
                for (int j = 0; j < dataSize; ++j)
                {
                    buffer[j] = (byte)rand.Next(byte.MinValue, byte.MaxValue);
                }
            }

            ReturnBuffer(buffer);
        }
    }
}
