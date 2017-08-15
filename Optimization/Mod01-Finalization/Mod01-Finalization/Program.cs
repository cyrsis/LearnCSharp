using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod01_Finalization
{
    class Program
    {
        static void Main(string[] args)
        {
            File file = new File("log.txt");
            byte[] data = file.Read(200);
            Console.WriteLine(Encoding.UTF8.GetString(data));
        }
    }
}
