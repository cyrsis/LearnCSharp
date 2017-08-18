using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox_ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string text = "訊息";
            string caption = "標題";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;//所要顯示按鈕
            MessageBoxIcon icon = MessageBoxIcon.Information;     //所要顯示圖示
            DialogResult result; //接收所按下按鈕的回傳值
            result = MessageBox.Show(text, caption, buttons, icon);
        }
    }
}
