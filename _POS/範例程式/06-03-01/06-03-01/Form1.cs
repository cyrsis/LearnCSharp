using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            adapter.Fill(dsXIN1);
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, 
            EventArgs e)
        {
            //預設無作用的控制項, 更新異動記錄回資料庫
            adapter.Update(dsXIN1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adapter.Fill(dsXIN1);
        }
    }
}
