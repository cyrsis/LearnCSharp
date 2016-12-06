using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Replace_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string SQL = "You Haven't Seen The Last Of Me ";
            string safeSQL = SQL.Replace("'", "''");

            string msg = "原先的字串為:" + SQL + "\n";
            msg = msg + "取代後字串為:" + safeSQL;
            MessageBox.Show(msg, "Replace()方法");
        }
    }
}
