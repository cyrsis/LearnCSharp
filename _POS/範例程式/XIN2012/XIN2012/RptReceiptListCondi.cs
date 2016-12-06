using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XIN2012
{
    public partial class fmRptReceiptListCondi : XIN2012.fmBaseDialog
    {

        XINFunction XIN = new XINFunction();

        public fmRptReceiptListCondi()
        {
            InitializeComponent();
        }

        private void supplierIDTextBox_Validated(object sender, EventArgs e)
        {
            if (supplierIDTextBox.Text == String.Empty)
            {
                //假如沒有輸入廠商編號，清空廠商簡稱
                attribNameTextBox.Text = "";
            }
            else
            {
                //取得廠商簡稱
                attribNameTextBox.Text = XIN.GetSupplierAttribName(
                    supplierIDTextBox.Text);
            }
        }

        private void btnQrySupplier_Click(object sender, EventArgs e)
        {
            TListSupplierID SelectSupplierID = new TListSupplierID();
            supplierIDTextBox.Text = SelectSupplierID.SupplierID;
            supplierIDTextBox.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            fmRptReceiptList RptReceiptList = new fmRptReceiptList();
            //進貨日期(起)
            RptReceiptList.BeginDate = Convert.ToDateTime
                                       (BeginDate.Value.ToShortDateString());
            //進貨日期(迄)
            RptReceiptList.EndDate = Convert.ToDateTime(
                                     EndDate.Value.ToShortDateString());
            //廠商編號
            RptReceiptList.SupplierID = supplierIDTextBox.Text;
            if (radioButton1.Checked)
            {
                //進貨別：進貨
                RptReceiptList.ReceiptType = "1";
            }
            else
            {
                //進貨別：進貨退出
                RptReceiptList.ReceiptType = "2";
            }
            RptReceiptList.MdiParent = this.ParentForm;
            RptReceiptList.Show();
            CanClose = true;
            this.Close();
        }
    }
}
