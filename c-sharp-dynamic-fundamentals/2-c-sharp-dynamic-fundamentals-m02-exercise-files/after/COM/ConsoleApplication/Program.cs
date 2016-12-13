using System;
using static System.Console;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Type excelType = Type.GetTypeFromProgID("Excel.Application", true);

            dynamic excel = Activator.CreateInstance(excelType);

            excel.Visible = true;
            excel.Workbooks.Add();

            dynamic defaultWorksheet = excel.ActiveSheet;

            defaultWorksheet.Cells[1, "A"] = "This is the Name column";
            defaultWorksheet.Columns[1].AutoFit();


            WriteLine("\n\nPress enter to exit...");
            ReadLine();
        }
    }  
}
