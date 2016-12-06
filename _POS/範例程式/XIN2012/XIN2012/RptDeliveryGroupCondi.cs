using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XIN2012
{
    public partial class fmRptDeliveryGroupCondi : XIN2012.fmBaseDialog
    {

        XINFunction XIN = new XINFunction();
        
        public fmRptDeliveryGroupCondi()
        {
            InitializeComponent();
        }

        private void customerIDTextBox_Validated(object sender, EventArgs e)
        {
            if (customerIDTextBox.Text == String.Empty)
            {
                //假如沒有輸入客戶編號，清空客戶簡稱
                attribNameTextBox.Text = "";
            }
            else
            {
                //取得客戶簡稱
                attribNameTextBox.Text = XIN.GetCustomerAttribName(
                            customerIDTextBox.Text);
            }
        }

        private void btnQryCustomer_Click(object sender, EventArgs e)
        {
            TListCustomerID SelectCustomerID = new TListCustomerID();
            customerIDTextBox.Text = SelectCustomerID.CustomerID;
            customerIDTextBox.Focus();
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

        private void btnQryProduct_Click(object sender, EventArgs e)
        {
            TListProductID SelectProductID = new TListProductID();
            productIDTextBox.Text = SelectProductID.ProductID;
            productIDTextBox.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            fmRptDeliveryGroup RptDeliveryGroup = new fmRptDeliveryGroup();
            //出貨日期(起)
            RptDeliveryGroup.BeginDate = Convert.ToDateTime(BeginDate.Value.ToShortDateString());
            //出貨日期(迄)
            RptDeliveryGroup.EndDate = Convert.ToDateTime(EndDate.Value.ToShortDateString());
            //客戶編號
            RptDeliveryGroup.CustomerID = customerIDTextBox.Text;
            //商品編號
            RptDeliveryGroup.ProductID = productIDTextBox.Text;
            RptDeliveryGroup.MdiParent = this.ParentForm;
            RptDeliveryGroup.Show();
            CanClose = true;
            this.Close();
        }
    }
}
