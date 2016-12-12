using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xdoc = XDocument.Load(@"C:\test\test123.xml");
            Console.WriteLine(xdoc);

            var youngCustomers = from c in xdoc.Elements("customers").Elements("customer")
                                where (int)c.Element("age") < 30
                                select c;

            foreach (var youngCustomer in youngCustomers)
            {
                string firstName = youngCustomer.Element("firstName").Value;
                string lastName = youngCustomer.Element("lastName").Value;
                int age = Convert.ToInt32(youngCustomer.Element("age").Value);
                Console.WriteLine("{0}, {1} ({2})", lastName, firstName, age);
            }


            string xml = @"
            <files>
                <file>
                    <name>file1.txt</name>
                    <size>43938</size>
                </file>
                <file>
                    <name>file2.txt</name>
                    <size>33938</size>
                </file>
                <file>
                    <name>file3.txt</name>
                    <size>23938</size>
                </file>
                <file>
                    <name>file4.txt</name>
                    <size>13938</size>
                </file>
            </files>";

            XDocument xdoc2 = XDocument.Parse(xml);
            var files = from f in xdoc2.Elements("files").Elements("file")
                        select f;
            foreach (var file in files)
            {
                string name = file.Element("name").Value;
                int size = Convert.ToInt32(file.Element("size").Value);
                Console.WriteLine("{0}, {1} bytes", name, size);
            }

            var singleFile = (from f in xdoc2.Descendants("file")
                             where f.Element("name").Value == "file2.txt"
                             select f).SingleOrDefault();

            Console.WriteLine("SINGLE FILE: {0}, {1} bytes", singleFile.Element("name").Value, singleFile.Element("size").Value);

            Console.ReadLine();
        }
    }
}
