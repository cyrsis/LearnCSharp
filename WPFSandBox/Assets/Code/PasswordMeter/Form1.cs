using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace PasswordMeter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        PasswordStrength pwdStrength = new PasswordStrength();
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            pwdStrength.SetPassword(txtPassword.Text);

            DataTable dt=pwdStrength.GetStrengthDetails();
            bindingSource1.DataSource = dt;
            lbScore.Text = String.Format("Score : {0} : {1}", pwdStrength.GetPasswordScore(),pwdStrength.GetPasswordStrength());
            passwordStrengthControl1.SetPassword(txtPassword.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
