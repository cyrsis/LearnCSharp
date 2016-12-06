using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogResult_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string Msg = "是否要進行客戶[" + txtCustomerID.Text + "-" + txtName.Text + "]刪除動作?\r\n";

            DialogResult DR;
            DR = MessageBox.Show(Msg, "刪除客戶", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (DR == DialogResult.Yes)
            {
                MessageBox.Show("執行客戶刪除動作!!", "刪除客戶");
            }
            else
            {
                MessageBox.Show("取消客戶刪除動作!!", "刪除客戶");
            }
        }
    }
}
