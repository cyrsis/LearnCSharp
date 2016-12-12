using System;
using System.Windows.Forms;

namespace WindowsFormsMainApplication
{
    public partial class ButtonShortCut : Form
    {
        public ButtonShortCut()
        {
            InitializeComponent();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            MessageBox.Show(//彈出消息對話框
              "點擊了確定！", "提示！");
        }
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(//彈出消息對話框
             "點擊了退出！", "提示！");
        }
    }
}
