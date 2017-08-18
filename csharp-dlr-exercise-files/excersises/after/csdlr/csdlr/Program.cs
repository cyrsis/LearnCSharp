using System;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;


namespace csdlr
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = IronRuby.Ruby.CreateEngine();
            var scope = engine.CreateScope();
            scope.SetVariable("employee", new Employee { FirstName="Scott C#"});            
            engine.ExecuteFile("Program.rb", scope);

            dynamic ruby = engine.Runtime.Globals;
            dynamic person = ruby.Person.@new();
            person.firstName = "Scott Ruby";
            person.speak();
        }

        private static void ReadXmlDynamic()
        {
            dynamic doc = new DynamicXml("Employees.xml");
            foreach (var employee in doc.Employees)
            {
                Console.WriteLine(employee.FirstName);
            }
        }

        private static void ReadXmlExpando()
        {
            var doc = XDocument.Load("Employees.xml").AsExpando();
            foreach (var employee in doc.Employees)
            {
                Console.WriteLine(employee.FirstName);
            }
        }

        private static void ReadXml()
        {
            var doc = XDocument.Load("Employees.xml");
            foreach(var element in doc.Element("Employees")
                .Elements("Employee"))
            {
                Console.WriteLine(element.Element("FirstName").Value);   
            }
        }


        private static void AutomateExcel()
        {
            Type excelType = Type.GetTypeFromProgID("Excel.Application");
            dynamic excel = Activator.CreateInstance(excelType);
            excel.Visible = true;

            excel.Workbooks.Add();

            dynamic sheet = excel.ActiveSheet;

            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                sheet.Cells[i + 1, "A"] = processes[i].ProcessName;
                sheet.Cells[i + 1, "B"] = processes[i].Threads.Count;
            }
        }

        private static object GetASpeaker()
        {
            return new Employee {FirstName = "Scott"};
        }
    }
}
