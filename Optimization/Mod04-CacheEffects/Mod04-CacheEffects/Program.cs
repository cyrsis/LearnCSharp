using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod04_CacheEffects
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage: <list | matrix | integration>");
                return;
            }
            switch (args[0])
            {
                case "list":
                    ListTraversal.Measure();
                    break;
                case "matrix":
                    MatrixMultiplication.Measure();
                    break;
                case "integration":
                    Integration.Measure();
                    break;
            }
        }
    }
}
