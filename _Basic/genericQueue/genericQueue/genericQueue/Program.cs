using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Order> orders = new Queue<Order>();

            {
                Order order = new Order { OrderNumber = 111111, Title = "C# Cookbook" };
                orders.Enqueue(order);
            }
            {
                Order order = new Order { OrderNumber = 222222, Title = "VB.NET Cookbook" };
                orders.Enqueue(order);
            }
            {
                Order order = new Order { OrderNumber = 333333, Title = "LINQ Cookbook" };
                orders.Enqueue(order);
            }

            Console.WriteLine("Your orders are:");
            foreach (var order in orders)
                Console.WriteLine(order.ShowIt());

            Order orderToProcess = orders.Dequeue();
            orderToProcess.Process();

            Console.WriteLine("Your orders are:");
            foreach (var order in orders)
                Console.WriteLine(order.ShowIt());

            Console.ReadLine();
        }
    }

    public class Order
    {
        public int OrderNumber { get; set; }
        public string Title { get; set; }

        internal string ShowIt()
        {
            return String.Format("{0}: {1}", OrderNumber, Title);
        }

        internal void Process()
        {
            Console.WriteLine("processed order #{0}", OrderNumber);
        }
    }

}
