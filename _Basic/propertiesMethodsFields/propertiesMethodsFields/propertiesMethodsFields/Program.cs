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
            Book book = new Book("JQuery Cookbook", "A good book.", 343);

            Console.WriteLine(book.Title);

            Console.WriteLine(book.GetHtml());


            Console.ReadLine();
        }
    }


    public class Book
    {
        //public string Title { get; set; }
        //public string Description { get; set; }
        //public int Pages { get; set; }

        public string Title
        {
            get
            {
                return _title;
            }
        }
        public List<string> Authors { get { return _authors; } }

        //public List<string> Authors { get; set; }

        private string _title;
        private string _description;
        private int _pages;
        private List<string> _authors = new List<string>();

        public Book(string title, string description, int pages)
        {
            _title = title;
            _description = description;
            _pages = pages;

            _authors.Add("Jim Smith");
        }

        public string GetHtml()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<h1>{0}</h1>\n", _title);
            sb.AppendFormat("<p>{0}</p>\n", _description);
            return sb.ToString();
        }

        public string GetExtendedTitle()
        {
            if (_title.Contains("C#"))
                return _title + " (on sale)";
            else
                return _title;
        }


    }
}
