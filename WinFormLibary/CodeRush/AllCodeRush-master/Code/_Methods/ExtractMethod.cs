using System;
using System.Data;

namespace AllCodeRush.Code.Methods
{
  /* •———————————————————————————————————————————————————————•
      Feature: Extract Method
        
      Use Case: Extracts selected code to a new method, 
      inserting appropriate calling code into the source 
      method or property.
         
      Available: 
       - When one or more statements are selected.
       - When an expression is selected.
         
      See also: Inline Method, Extract Method to Type
     •———————————————————————————————————————————————————————• */
  public class ExtractMethod
  {
    public void DynamicCreate(ref string idStr)
    {
      DataSet dataSet = new DataSet();
      DataTable table = new DataTable();
      table.Columns.Add(new DataColumn("ID", Type.GetType("System.Int32")));
      table.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));

      int id = 0;
      string workStr = idStr;

      if (workStr != null && id != -1 && !int.TryParse(idStr, out id))
      {
        idStr = string.Format("Error: \"{0}\" is not an integer.", idStr);
        id = -1;
      }
      
      string name = "first row";

      idStr = workStr;

      // Add the row:
      DataRow row = table.NewRow();
      row["ID"] = id;
      row["Name"] = name;
      table.Rows.Add(row);

      // TODO: Add more rows...

      dataSet.Tables.Add(table);
      for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
        Console.WriteLine(dataSet.Tables[0].Rows[i].ItemArray[0] + " -- " + dataSet.Tables[0].Rows[i].ItemArray[1]);
    }

    
  }
}
