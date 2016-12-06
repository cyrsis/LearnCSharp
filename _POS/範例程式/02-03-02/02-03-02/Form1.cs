using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_03_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet dsKings = new DataSet("XIN");
            try
            {
                dsKings.Tables.Add("Product");
                dsKings.Tables.Add("Product");
            }
            catch (System.Data.DuplicateNameException eErr)
            {
                MessageBox.Show("在資料集建立資料表名稱重覆的資料表，" + 
                                "這是不允許的。\r\n" + eErr.Message);
            }
        }
    }
}
