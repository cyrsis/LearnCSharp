using System.Windows.Forms;

namespace WindowsFormsMainApplication
{
    public partial class ChangeFocus : Form
    {
        public ChangeFocus()
        {
            InitializeComponent();
        }
        // 回車切換控制元件焦點//要想使這個方法起到作用先將視窗的keypreview屬性改為true
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//判斷是否按下Enter鍵
            {
                this.SelectNextControl(//激活下一個控制元件
                    this.ActiveControl, true, true, true, true);
            }
            base.OnKeyPress(e);//呼叫基底類別的OnKeyPress方法
        }
    }
}
