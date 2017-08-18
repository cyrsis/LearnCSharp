using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace csharp_clr
{
    public class Downloads
    {
        static void DoIt(string[] args)
        {
            DownloadConcurently();

            Console.WriteLine("Waiting to finish on thread {0} ...",
                    Thread.CurrentThread.ManagedThreadId);

            Console.ReadLine();
        }

        private static void DownloadConcurently()
        {
            string[] urls =
                {
                    "http://www.pluralsight-training.net/microsoft/",
                    "http://www.microsoft.com/en/us/default.aspx",
                    "http://twitter.com/odetocode"
                };

            Parallel.ForEach(urls, url =>
            {
                var client = new WebClient();
                var html = client.DownloadString(url.ToString());
                Console.WriteLine("Download {0} chars from {1} on thread {2}",
                     html.Length, url, Thread.CurrentThread.ManagedThreadId);
            });
        }

        private static void Download(string url)
        {
            var client = new WebClient();
            client.DownloadStringCompleted += client_DownloadStringCompleted;
            client.DownloadStringAsync(new Uri(url), url);

        }

        static void client_DownloadStringCompleted(object sender,
            DownloadStringCompletedEventArgs e)
        {
            var html = e.Result;
            var url = e.UserState as string;
            Console.WriteLine("Download {0} chars from {1} on thread {2}",
                 html.Length, url, Thread.CurrentThread.ManagedThreadId);
        }
    }
}