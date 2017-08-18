using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastIndexOf_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLastIndexOf_Click(object sender, EventArgs e)
        {
            string filePath;
            filePath = @"C:\WINDOWS\System32\notepad.exe";

            int index = filePath.LastIndexOf("\\");

            string fileName = filePath.Substring(index + 1);

            MessageBox.Show(filePath + "\n其檔案名稱為[" +
                fileName + "]", "LastIndexOf()方法");
        }
    }
}
