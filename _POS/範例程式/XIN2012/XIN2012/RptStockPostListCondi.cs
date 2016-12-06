using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace XIN2012
{
    public partial class fmRptStockPostListCondi : XIN2012.fmBaseDialog
    {

        XINFunction XIN = new XINFunction();

        public fmRptStockPostListCondi()
        {
            InitializeComponent();
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
            fmRptStockPostList RptStockPostList = new fmRptStockPostList();
            //異動日期(起)
            RptStockPostList.BeginDate = Convert.ToDateTime(
                                                 BeginDate.Value.ToShortDateString());
            //異動日期(迄)
            RptStockPostList.EndDate = Convert.ToDateTime(
                                              EndDate.Value.ToShortDateString());
            //商品編號
            RptStockPostList.ProductID = productIDTextBox.Text;
            RptStockPostList.MdiParent = this.ParentForm;
            //顯示報表畫面
            RptStockPostList.Show();
            //允許關閉此視窗
            CanClose = true;
            //關閉此視窗
            this.Close();
        }
    }
}
