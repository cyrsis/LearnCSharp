using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;//

namespace My
{
    public class MyGlobal
    {
        private static string ConnString;
        public static string SQLConnectionString
        {
            get
            {
                //使用應用程式組態檔連線方式,需加入參考[System.configuration.dll]
                ConnectionStringSettings settings;
                settings = ConfigurationManager.ConnectionStrings["SQLConnectionString"];

                ConnString = settings.ConnectionString;
                return ConnString;
            }
        }

    }
}
