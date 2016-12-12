using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsMainApplication
{
    public partial class AutoImageSizeByForm : Form
    {
        public AutoImageSizeByForm()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("test.jpg");//設定視窗的背景圖片
            this.BackgroundImageLayout = ImageLayout.Stretch;//使圖片自動適應視窗大小
        }
    }
}
