using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreetingLogic
{
    public class Greeting
    {
        // returns a time-appropriate greeting
        public string GetString()
        {
            string greeting = "Hello";
            int hour = DateTime.Now.Hour;
            if (hour < 12)
            {
                greeting = "Good Morning";
            }
            else if (hour > 18)
            {
                greeting = "Good Evening";
            }
#if DEBUG
            greeting += " (this is the debug build)";
#endif
            return greeting;
        }
        public static System.Data.DataTable GetData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("ID", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Name", System.Type.GetType("System.String"));
            dt.Columns.Add("DueDate", System.Type.GetType("System.DateTime"));

            System.Data.DataRow dr = dt.NewRow();
            dr["ID"] = 1;
            dr["Name"] = "Phase 1";
            dr["DueDate"] = DateTime.Now.AddDays(14);
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["ID"] = 2;
            dr["Name"] = "Phase 2";
            dr["DueDate"] = DateTime.Now.AddDays(28);

            dt.Rows.Add(dr);

            return dt;
        }
    }
}

