using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace XIN2012
{
    public partial class fmLogin : XIN2012.fmBaseDialog
    {

        int iCheckTimes;
        
        public fmLogin()
        {
            InitializeComponent();
        }

        private void fmLogin_Load(object sender, EventArgs e)
        {
            //認證次數
            iCheckTimes = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            CanClose = false;
            using (var context = new XINEntities())
            {
                var qry = (from M in context.XINUsers
                           where M.EmployeeNo == txtEmployeeNo.Text &&
                           M.PasswordCode == txtPasswordCode.Text
                           select new 
                           { 
                               M.EmployeeNo, M.EmployeeName 
                           }).FirstOrDefault();
                if (qry == null)
                {
                    //找不到記錄
                    MessageBox.Show("使用者代碼或密碼錯誤！", "認證失敗",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    fmMain.FPowerCheck = false;
                    iCheckTimes = iCheckTimes + 1;
                    if (iCheckTimes == 3)
                    {
                        MessageBox.Show("認證失敗已達3次，系統將結束！", "認證失敗",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CanClose = true;
                      }
                }
                else
                {                    
                    fmMain.FPowerCheck = true;
                    fmMain.FEmployeeNo = qry.EmployeeNo;
                    fmMain.FEmployeeName = qry.EmployeeName;
                    CanClose = true;
                }
            }
        }

        private void fmLogin_Shown(object sender, EventArgs e)
        {
            txtEmployeeNo.Focus();
        }
    }
}
