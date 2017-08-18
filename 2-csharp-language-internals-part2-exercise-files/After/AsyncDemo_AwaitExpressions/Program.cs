using System;
using System.Net;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static async Task<int> QuxAsync(Uri uri)
        {
            Console.Write("Downloading in a second... ");

            await Task.Delay(1000);

            Console.Write("Starting... ");
            var wc = new WebClient();

            var html = await wc.DownloadStringTaskAsync(uri);

            Console.WriteLine("Done.");

            return html.Length;
        }
    }
}
