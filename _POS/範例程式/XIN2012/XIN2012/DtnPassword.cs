using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Linq;

namespace XIN2012
{
    public partial class fmDtnPassword : XIN2012.fmBaseDialog
    {
    
        public fmDtnPassword()
        {
            InitializeComponent();
        }

        private void fmDtnPassword_Shown(object sender, EventArgs e)
        {
            OrignalPasswordTextBox.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CanClose = false;
            try
            {
                if (NewPasswordTextBox.Text == "" )
                {
                    MessageBox.Show("新密碼不可空白！", "錯誤", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NewPasswordTextBox.Focus();
                    return;
                }
                if (NewPasswordTextBox.Text != ConfirmPasswordTextBox.Text)
                {
                    MessageBox.Show("新密碼與確認新密碼不一致！", "錯誤", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NewPasswordTextBox.Focus();
                    return;
                }
                using (var context = new XINEntities())
                {
                    var qry = (from U in context.XINUsers 
                               where U.EmployeeNo == fmMain.FEmployeeNo
                               && U.PasswordCode == OrignalPasswordTextBox.Text 
                               select U).FirstOrDefault();
                    if (qry == null)
                    {
                        MessageBox.Show("原來的密碼輸入錯誤！", "錯誤", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        OrignalPasswordTextBox.Focus();
                        return;
                    }
                    //開始更新使用者的密碼
                    qry.PasswordCode = NewPasswordTextBox.Text;
                    context.SaveChanges();
                    MessageBox.Show("密碼變更完成", "變更密碼", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
            }
            //成功完成密碼變更，允許關閉視窗
            CanClose = true;
        }
    }
}
