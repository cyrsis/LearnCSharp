using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer> {
                            new Customer {FirstName="Jim", LastName="Smith", Age=27},
                            new Customer {FirstName="Hank", LastName="Moore", Age=28},
                            new Customer {FirstName="Jay", LastName="Smythe", Age=44},
                            new Customer {FirstName="Angie", LastName="Thompson", Age=25},
                            new Customer {FirstName="Sarah", LastName="Conners", Age=66}
                        };

            Console.WriteLine(BuildXmlWithStringContatentation(customers));
            Console.WriteLine(BuildXmlWithXmlWriter(customers));
            Console.WriteLine(BuildXmlWithLINQ(customers));
            Console.WriteLine(BuildXmlWithLINQ2(customers));
            Console.WriteLine(BuildXmlWithLINQ3(customers));


            Console.ReadLine();
        }

        private static string BuildXmlWithLINQ3(List<Customer> customers)
        {
            XDocument xdoc = new XDocument
            (
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("customers",
                    from c in customers
                    select
                        new XElement("customer",
                        new XElement("firstName", c.FirstName),
                        new XElement("lastName", c.LastName)
                        )
                )
            );

            xdoc.Save(@"C:\Test\test123.xml");

            return xdoc.Declaration.ToString() + xdoc.ToString();
        }

        private static string BuildXmlWithLINQ2(List<Customer> customers)
        {
            XDocument xdoc = new XDocument
            (
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("customers",
                    customers.ConvertAll(c => new XElement("customer",
                        new XElement("firstName", c.FirstName),
                        new XElement("lastName", c.LastName),
                        new XElement("age", c.Age.ToString())
                        )
                    )
                )
            );

            return xdoc.Declaration.ToString() + xdoc.ToString();            
        }

        private static string BuildXmlWithLINQ(List<Customer> customers)
        {
            XDocument xdoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes")
            );
            XElement xRoot = new XElement("customers");
            xdoc.Add(xRoot);

            foreach (var customer in customers)
            {
                XElement xElement = new XElement("customer",
                    new XElement("firstName", customer.FirstName),
                    new XElement("lastName", customer.LastName),
                    new XElement("age", customer.Age)
                );
                xRoot.Add(xElement);
            }
            return xdoc.Declaration.ToString() + xdoc.ToString();
        }

        private static string BuildXmlWithXmlWriter(List<Customer> customers)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.NewLineHandling = NewLineHandling.Entitize;
            settings.Indent = true;
            settings.IndentChars = "\t";

            StringBuilder sb = new StringBuilder();
            using (XmlWriter xw = XmlWriter.Create(sb, settings))
            {
                xw.WriteStartDocument();
                xw.WriteStartElement("customers");
                foreach (var customer in customers)
                {
                    xw.WriteStartElement("customer");

                    xw.WriteStartElement("firstName");
                    xw.WriteString(customer.FirstName);
                    xw.WriteEndElement();

                    xw.WriteStartElement("lastName");
                    xw.WriteString(customer.LastName);
                    xw.WriteEndElement();

                    xw.WriteStartElement("age");
                    xw.WriteString(customer.Age.ToString());
                    xw.WriteEndElement();

                    xw.WriteEndElement();
                }
                xw.WriteEndElement();
                xw.WriteEndDocument();
                xw.Close();
            }
            return sb.ToString();
        }

        private static string BuildXmlWithStringContatentation(List<Customer> customers)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");

            sb.AppendLine(String.Format("<{0}>", "customers"));
            foreach (var customer in customers)
            {
                sb.AppendLine(String.Format("\t<{0}>", "customer"));
                sb.AppendLine(String.Format("\t\t<firstName>{0}</firstName>", customer.FirstName));
                sb.AppendLine(String.Format("\t\t<lastName>{0}</lastName>", customer.LastName));
                sb.AppendLine(String.Format("\t\t<age>{0}</age>", customer.Age));
                sb.AppendLine(String.Format("\t</{0}>", "customer"));
            }

            sb.AppendLine(String.Format("</{0}>", "customers"));
            return sb.ToString();
        }
    }

    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }

}
