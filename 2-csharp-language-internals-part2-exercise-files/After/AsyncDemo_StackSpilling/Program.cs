using System;
using System.Threading.Tasks;

namespace AsyncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static async Task<int> FooAsync()
        {
            return F() + (F() + (F() + (F() + (F() + (F() + (F() + (F() + G() * await T())))))));
        }

        static int F()
        {
            return 1;
        }

        static int G()
        {
            return 1;
        }

        static Task<int> T()
        {
            throw new NotImplementedException();
        }
    }
}
