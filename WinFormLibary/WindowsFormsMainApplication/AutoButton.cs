using System;
using System.Windows.Forms;

namespace WindowsFormsMainApplication
{
    public partial class AutoButton : Form
    {
        public AutoButton()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            btn_One.AutoSize = true;//設定按鈕基於內容自動調整大小
            btn_One.Text = txt_Name.Text;//設定按鈕文字內容
        }
    }
}
