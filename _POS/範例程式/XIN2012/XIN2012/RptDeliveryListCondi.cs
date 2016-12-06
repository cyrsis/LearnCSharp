using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XIN2012
{
    public partial class fmRptDeliveryListCondi : XIN2012.fmBaseDialog
    {

        XINFunction XIN = new XINFunction();

        public fmRptDeliveryListCondi()
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            fmRptDeliveryList RptDeliveryList = new fmRptDeliveryList();
            //出貨日期(起)
            RptDeliveryList.BeginDate = Convert.ToDateTime(
                                             BeginDate.Value.ToShortDateString());
            //出貨日期(迄)
            RptDeliveryList.EndDate = Convert.ToDateTime(
                                             EndDate.Value.ToShortDateString());
            //客戶編號
            RptDeliveryList.CustomerID = customerIDTextBox.Text;
            if (radioButton1.Checked)
            {
                //出貨別：出貨
                RptDeliveryList.DeliveryType = "1";
            }
            else
            {
                //出貨別：出貨退回
                RptDeliveryList.DeliveryType = "2";
            }
            RptDeliveryList.MdiParent = this.ParentForm;
            RptDeliveryList.Show();
            CanClose = true;
            this.Close();
        }
    }
}
