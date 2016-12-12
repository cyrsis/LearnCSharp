using System;
using System.Windows.Forms;

namespace WindowsFormsMainApplication
{
    public partial class BubbleShowForm : Form
    {
        public BubbleShowForm()
        {
            InitializeComponent();
        }

        private void clewButton_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = true;//設定提示控制元件可見
            this.notifyIcon1.ShowBalloonTip(1000, "目前時間：", DateTime.Now.ToLocalTime().ToString(), ToolTipIcon.Info);//顯示氣泡提示
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = false;//設定提示控制元件不可見
        }

        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            this.notifyIcon1.ShowBalloonTip(1000, "目前時間：", DateTime.Now.ToLocalTime().ToString(), ToolTipIcon.Info);//顯示氣泡提示
        }
    }
}
