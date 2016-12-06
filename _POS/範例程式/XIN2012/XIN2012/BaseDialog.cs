using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIN2012
{
    public partial class fmBaseDialog : Form
    {

        //允許關閉對話方塊
        bool FCanClose = false;
        
        public fmBaseDialog()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FCanClose = true;
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        //取得或設定是否允許關閉對話方塊
        public bool CanClose
        {
            get
            {
                return FCanClose;
            }
            set
            {
                FCanClose = value;
            }
        }

        private void fmBaseDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (!FCanClose);
        }
    }
}
