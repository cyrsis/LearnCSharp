using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsMainApplication
{
    public partial class ClearFormBack : Form
    {
        public ClearFormBack()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("test.jpg");//設定視窗的背景圖片
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();//建立繪圖物件
            graphics.Clear(Color.White);//清空背景
            graphics.Dispose();//釋放繪圖資源
        }
    }
}
