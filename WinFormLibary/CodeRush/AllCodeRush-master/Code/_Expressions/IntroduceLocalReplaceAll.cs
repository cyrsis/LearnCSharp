using System;
using System.Data;
using System.Drawing;

namespace AllCodeRush.Code.Expressions
{
	/* •———————————————————————————————————————————————————————•
			Feature: Introduce Local (Replace All)
        
			Use Case: Creates a new local variable 
			initialized with the selected expression. 
			Note: This operation replaces other instances of the 
			expression with same local.
         
			Available: When an expression is selected.
        
			See also: Inline Local, Introduce Local
		 •———————————————————————————————————————————————————————• */

	public class IntroduceLocalReplaceAll
	{
    public double GetDistanceBetweenPoints(Point pt1, Point pt2)
    {
      return Math.Sqrt((pt2.X - pt1.X) * (pt2.X - pt1.X) + (pt2.Y - pt1.Y) * (pt2.Y - pt1.Y));
    }

		public void DynamicCreate()
		{
			DataSet dataSet = new DataSet();
			DataTable dt = new DataTable();
			dt.Columns.Add(new DataColumn("ID", Type.GetType("System.Int32")));
			dt.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
			AddRow(dt, 1, "First Row");
			AddRow(dt, 2, "Second Row");
			dataSet.Tables.Add(dt);
			for (int i = 0; i <= dataSet.Tables[0].Rows.Count - 1; i++)
				Console.WriteLine(dataSet.Tables[0].Rows[i].ItemArray[0] + " -- " + dataSet.Tables[0].Rows[i].ItemArray[1]);
		}

		private static void AddRow(DataTable dt, int id, string name)
		{
			DataRow dr = dt.NewRow();
			dr["ID"] = id;
			dr["Name"] = name;
			dt.Rows.Add(dr);
		}
	}
}

