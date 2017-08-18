using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpProvider_ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //顯示[?]鈕必須要將最大化與最小化按鈕關閉
            this.HelpButton = true;
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.helpProvider1.SetHelpString(txtUserID, "請輸入使用者[帳號]!");
            this.helpProvider1.SetHelpString(txtPwd, "請輸入[密碼]!");
            this.helpProvider1.SetHelpString(btnSure, "按下[確定]鈕,以進行系統身份驗證動作!");
            this.helpProvider1.SetHelpString(btnCancel, "按下[取消]鈕,以取消系統登入動作!");
        }
    }
}
