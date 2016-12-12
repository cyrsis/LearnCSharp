using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AccessToExcel
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AccessToExel()); //讀取Access資料到Excel
            //Application.Run(new AcuteImage()); //讀取Access資料到Excel

        }
    }
}
