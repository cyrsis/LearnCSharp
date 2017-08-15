using System;
using System.IO;
using Newtonsoft.Json;
using static System.Console;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic jsonData = JsonConvert.DeserializeObject(File.ReadAllText("customers.json"));            

            dynamic excel = Activator.CreateInstance(Type.GetTypeFromProgID("Excel.Application", throwOnError: true));
            excel.Visible = true;
            excel.Workbooks.Add();
            dynamic defaultWorksheet = excel.ActiveSheet;

            int currentRow = 1;
            foreach (dynamic customer in jsonData.customers)
            {
                defaultWorksheet.Cells[currentRow, "A"] = customer.firstName;
                defaultWorksheet.Cells[currentRow, "B"] = customer.secondName;
                currentRow ++;
            }
            
            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }        
    }  
}
