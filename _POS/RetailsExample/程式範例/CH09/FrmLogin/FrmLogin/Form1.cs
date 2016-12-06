using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (RunLogin())
            {
                MessageBox.Show("帳號:" + txtUserID.Text ,"登入成功");
            }
            else
            {
                MessageBox.Show("帳號:" + txtUserID.Text, "登入失敗");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         #region "欄位檢查"

        /// <summary>
        /// 欄位檢查
        /// </summary>
        /// <returns></returns>
        public bool CheckField()
        {
            if (txtUserID.Text == "" || txtUserID.Text.Length == 0)
            {
                MessageBox.Show(this, "帳號不得為空白", "欄位檢查");
                txtUserID.Focus();
                return false;
            }

            if (txtPwd.Text.Length <= 3)
            {
                MessageBox.Show(this, "密碼長度必須4個以上", "欄位檢查");
                txtPwd.Focus();
                return false;
            }
            return true;

        }

        #endregion

        public bool RunLogin()
        {
            if (CheckField())
            {
                string UserID;
                string HashPwd;
                string encryptFormat;//加密格式設定
                encryptFormat = "SHA1";
                UserID = txtUserID.Text;
                HashPwd = My.MyMethod.HashEncryption(encryptFormat, txtPwd.Text);

                DBClsLogin DbLogin = new DBClsLogin();
                bool VerifyResult = false;
                try
                {
                    VerifyResult = DbLogin.VerifyPWD(UserID, HashPwd);
                    if (VerifyResult)
                        return true;
                    else
                        return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "發生例外");
                    return false;
                }
            }
            else  {  return false;  }
        }
    }
}
