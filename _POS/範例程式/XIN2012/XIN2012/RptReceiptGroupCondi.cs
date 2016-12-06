using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XIN2012
{
    public partial class fmRptReceiptGroupCondi : XIN2012.fmBaseDialog
    {

        XINFunction XIN = new XINFunction();
        
        public fmRptReceiptGroupCondi()
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

        private void productIDTextBox_Validated(object sender, EventArgs e)
        {
            if (productIDTextBox.Text == String.Empty)
            {
                //假如沒有輸入商品編號，清空商品名稱
                productNameTextBox.Text = "";
            }
            else
            {
                //取得商品名稱
                productNameTextBox.Text = XIN.GetProductName(
                    productIDTextBox.Text);
            }
        }

        private void btnQrySupplier_Click(object sender, EventArgs e)
        {
            TListSupplierID SelectSupplierID = new TListSupplierID();
            supplierIDTextBox.Text = SelectSupplierID.SupplierID;
            supplierIDTextBox.Focus();
        }

        private void btnQryProduct_Click(object sender, EventArgs e)
        {
            TListProductID SelectProductID = new TListProductID();
            productIDTextBox.Text = SelectProductID.ProductID;
            productIDTextBox.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            fmRptReceiptGroup RptReceiptGroup = new fmRptReceiptGroup();
            //進貨日期(起)
            RptReceiptGroup.BeginDate = Convert.ToDateTime(BeginDate.Value.ToShortDateString());
            //進貨日期(迄)
            RptReceiptGroup.EndDate = Convert.ToDateTime(EndDate.Value.ToShortDateString());
            //廠商編號
            RptReceiptGroup.SupplierID = supplierIDTextBox.Text;
            //商品編號
            RptReceiptGroup.ProductID = productIDTextBox.Text;
            RptReceiptGroup.MdiParent = this.ParentForm;
            RptReceiptGroup.Show();
            CanClose = true;
            this.Close();
        }
    }
}
