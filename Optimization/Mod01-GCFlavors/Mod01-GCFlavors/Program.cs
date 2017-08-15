using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Mod01_GCFlavors
{
    class Program
    {
        const int ITERATIONS = 100000;
        const int DUMP_EVERY_N = 100;

        static int overallProgress = 0;
        static int totalIterations;

        static void AllocateALot()
        {
            XmlDocument document = new XmlDocument();
            XmlElement root = document.CreateElement("Root");
            document.AppendChild(root);
            for (int i = 0; i < ITERATIONS; ++i)
            {
                root.AppendChild(document.CreateElement("Child"));
                if (i != 0 && i % DUMP_EVERY_N == 0)
                {
                    string xmlAsString = document.OuterXml;
                    Interlocked.Add(ref overallProgress, DUMP_EVERY_N);
                }
            }
        }

        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            int numProcessors = Environment.ProcessorCount;
            totalIterations = numProcessors * ITERATIONS;
            var tasks = from _ in Enumerable.Range(0, numProcessors)
                        select Task.Factory.StartNew(AllocateALot, TaskCreationOptions.LongRunning);
            Task.WhenAll(tasks.ToArray()).ContinueWith(_ =>
            {
                Console.Clear();
                Console.WriteLine("Elapsed time: {0}ms", sw.ElapsedMilliseconds);
                Environment.Exit(0);
            });

            string processName = Path.GetFileNameWithoutExtension(Process.GetCurrentProcess().ProcessName);
            PerformanceCounter cpu = new PerformanceCounter("Process", "% Processor Time", processName);
            PerformanceCounter allocs = new PerformanceCounter(".NET CLR Memory", "Allocated Bytes/sec", processName);
            PerformanceCounter gccpu = new PerformanceCounter(".NET CLR Memory", "% Time in GC", processName);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Full GC count      {0}", GC.CollectionCount(2));
                Console.WriteLine("Overall progress   {0:0.00}%", overallProgress * 100.0 / totalIterations);
                Console.WriteLine("CPU utilization    {0:0.00}%", cpu.NextValue());
                Console.WriteLine("Alloc rate         {0:0.00}MB/sec", allocs.RawValue / 1048576.0);
                Console.WriteLine("CPU time in GC     {0:0.00}%", gccpu.NextValue());
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
    }
}
