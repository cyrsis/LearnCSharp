using System;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static async void FooAsync()
        {
            return;
        }

        static async Task BarAsync()
        {
            throw new NotImplementedException();
        }

        static async Task<int> QuxAsync(Uri uri)
        {
            return 42;
        }
    }
}
