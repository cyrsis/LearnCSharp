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
            //private: accessible inside the class
            //protected: accessible to classes from subclasses
            //internal: accessible anywhere within the assembly but not from another assembly
            //public: accessible anywhere

            Catalog catalog = new Catalog("JQuery Cookbook");
            Console.WriteLine(catalog.Display());

            Console.ReadLine();
        }
    }

    public class Book
    {

        protected string _title;

        public Book(string title)
        {
            _title = title;
        }

        internal string Display()
        {
            return "*** " + _title + " ***";
        }

    }

    public class Catalog : Book
    {
        public Catalog(string title) : base(title)
        {
            _title = "CATALOG: " + _title;
        }
    }

}
