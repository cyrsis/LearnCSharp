using System;
using System.Windows.Forms;

namespace WindowsFormsMainApplication
{
    public partial class AddHyperLink : Form
    {
        public AddHyperLink()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            rtbox_HyperLink.AppendText(//向控制元件中新增文字訊息
                @"明日科技：http://www.mingrisoft.com/
谷歌：http://www.google.cn/
網易：http://www.163.com/
百度：http://www.baidu.com/
CSDN：http://www.csdn.net/
騰訊：http://www.qq.com/
QQ書籤：http://shuqian.qq.com/
QQ空間：http://qzone.qq.com/
校內網：http://www.xiaonei.com/");
        }

        private void rtbox_HyperLink_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(//使用IE打開指定網址
                "iexplore.exe", e.LinkText);
        }
    }
}
