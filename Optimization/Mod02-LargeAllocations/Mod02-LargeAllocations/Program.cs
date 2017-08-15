using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mod02_LargeAllocations
{
    class Program
    {
        private const int DATA_SIZE_MIN = 8 * 1024;        //8 KB
        private const int DATA_SIZE_MAX = 4 * 1024 * 1024; //4 MB
        private const int LOAD_MIN = 0;
        private const int LOAD_MAX = 2;

        private static int _requestsProcessed = 0;
        private static long _totalRequestsSize = 0;
        private static Stopwatch _stopwatch;

        static void PrintStatistics(object state)
        {
            Console.Clear();
            double totalReqSizeInMB = _totalRequestsSize / 1048576.0;
            Console.WriteLine("Req processed = {0}\tReq total size = {1:0.00}MB\tProcessing rate = {2:0.00}MB/sec",
                _requestsProcessed,
                totalReqSizeInMB,
                totalReqSizeInMB / _stopwatch.Elapsed.TotalSeconds);
            Console.WriteLine("Full GC count = {0}\tGC heap size   = {1:0.00}MB",
                GC.CollectionCount(2), GC.GetTotalMemory(forceFullCollection: false) / 1024576.0);
        }

        static void Main(string[] args)
        {
            // In a separate thread, print statistics
            _stopwatch = Stopwatch.StartNew();
            Timer timer = new Timer(PrintStatistics, null, TimeSpan.Zero, TimeSpan.FromSeconds(1));

            // Simulate a request-processing loop
            var requestProcessor = new PoolingRequestProcessor();
            Random rand = new Random();
            while (!Console.KeyAvailable)
            {
                int dataSize = rand.Next(DATA_SIZE_MIN, DATA_SIZE_MAX);
                int load = rand.Next(LOAD_MIN, LOAD_MAX);
                requestProcessor.ProcessRequest(dataSize, load);
                Interlocked.Increment(ref _requestsProcessed);
                Interlocked.Add(ref _totalRequestsSize, dataSize);
            }

            GC.KeepAlive(timer);
        }
    }
}
