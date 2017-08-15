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
            //using (var cn = new System.Data.SqlClient.SqlConnection(ConnectionString))
            //{
            //    cn.Open();

            //    IEnumerable<Customer> allCustomers = 
            //        cn.Query<Customer>("SELECT * FROM CUSTOMER");

            //    foreach (Customer customer in allCustomers)
            //    {
            //        WriteLine($"{customer.FirstName} {customer.SecondName} {customer.Height} {customer.Age}");
            //    }
            //}

            using (var cn = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                cn.Open();

                IEnumerable<dynamic> allCustomers = cn.Query("SELECT * FROM CUSTOMER");

                foreach (dynamic customer in allCustomers)
                {
                    WriteLine($"{customer.FirstName} {customer.SecondName} {customer.Height} {customer.Age}");
                }
            }




            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }
    }
  
}
