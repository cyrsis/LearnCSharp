using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mod02_MemoryLeak
{
    class Program
    {
        private static int _requestsProcessed = 0;

        static void PrintStatistics(object state)
        {
            Console.Clear();
            Console.WriteLine("Requests processed: {0}", _requestsProcessed);
        }

        static void Main(string[] args)
        {
            // Print processing statistics in a separate thread
            Timer timer = new Timer(PrintStatistics, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));

            // Handle an infinite stream of requests
            while (true)
            {
                Request request = Request.NextRequest();
                Response response = new Response(request);
                response.Send();
                Interlocked.Increment(ref _requestsProcessed);
            }

            GC.KeepAlive(timer);
        }
    }
}
