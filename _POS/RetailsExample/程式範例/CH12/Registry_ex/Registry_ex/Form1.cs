using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registry_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            My.MyWinAPI.CreateSubKeyAndSetValue("CurrentUser", @"Software\MySIS\V1.0\SysProfile", 
                "SystemTitle", "超級進銷存系統");
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            if (My.MyWinAPI.SubKeyExist("CurrentUser",@"Software\MySIS\V1.0\SysProfile"))
            {
                MessageBox.Show(@"Software\MySIS\V1.0\SysProfile","機碼存在");
            }
            else
            {
                MessageBox.Show(@"Software\MySIS\V1.0\SysProfile", "機碼不存在");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            var SystemTitle = My.MyWinAPI.GetSubKeyValue("CurrentUser", 
                                               @"Software\MySIS\V1.0\SysProfile", "SystemTitle");
            MessageBox.Show(SystemTitle.ToString(), "SystemTitle");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            My.MyWinAPI.DeleteSubKeyValue("CurrentUser",
                                               @"Software\MySIS\V1.0\SysProfile", "SystemTitle");
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            var ListKeys = My.MyWinAPI.GetAllSubKeyNames("CurrentUser",@"Software\SIS\V1.0\");
            string msg = "";
            foreach (string tmp in ListKeys)
            {
                msg = msg + tmp + "\n";
            }
            MessageBox.Show(msg, "取得所有登錄子機碼");
        }
    }
}
