using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private string ID = "Ryu"; //預設使用帳號
        private string Password = "123";//預設使用密碼
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text == ID && txtPassword.Text == Password)
            {
                MessageBox.Show("帳號密碼正確","登入成功");
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤", "登入失敗");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtPassword.Text = "";
        }

        //新增二個屬性
         [ Bindable(true),
        Category("設計"),
        DefaultValue(""),
        Description("使用者名稱") ]
        public string UserName { get; set; }
          [Bindable(true),
       Category("設計"),
       DefaultValue(""),
       Description("使用者密碼")]
        public string UserPassword { get; set; }
    }
}
