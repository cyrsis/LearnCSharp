using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomException
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text == "Ryu" && txtPWD.Text == "123")
                {
                    MessageBox.Show("帳號密碼正確");
                }
                else
                {
                    ErrorType errType = new ErrorType(MainErrorType.LoginError);
                    errType.loginError = new LoginError();
                    errType.loginError.AccountOrPasswordError = true;
                    throw new MyExceptionHandler(errType);
                }
            }
            catch (MyExceptionHandler ex)
            {
                MessageBox.Show(ex.Message, "MyExceptionHandler");
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                bool isNodata = true;
                if (isNodata)
                {
                    ErrorType errType = new ErrorType(MainErrorType.DatabaseError);
                    errType.databaseError = new DatabaseError();
                    errType.databaseError.QueryNoData = true;
                    throw new MyExceptionHandler(errType);
                }
            }
            catch (MyExceptionHandler ex)
            {
                MessageBox.Show(ex.Message, "MyExceptionHandler");
            }
        }
    }
}
