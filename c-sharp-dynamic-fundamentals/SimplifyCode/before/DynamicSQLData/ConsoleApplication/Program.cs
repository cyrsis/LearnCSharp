using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using static System.Console;

namespace ConsoleApplication
{
    class Program
    {
        private const string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=PSDynamicCS;Integrated Security=True";
        static void Main(string[] args)
        {



            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }
    }
  
}
