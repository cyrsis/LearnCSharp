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
    public partial class fmQryProduct : XIN2012.fmBaseDialog
    {
        public fmQryProduct()
        {
            InitializeComponent();
        }

        private void GetAllProduct()
        {
            using (var context = new XINEntities())
            {
                //取得廠商資料表所有的記錄
                var qry = context.Product.Execute(MergeOption.OverwriteChanges);
                //將取得的結果指派給BindingSource控制項的DataSource
                productBindingSource.DataSource = qry;
            }
        }

        private void fmQryProduct_Load(object sender, EventArgs e)
        {
            //預設的查詢依據-商品編號
            SearchByComboBox.SelectedIndex = 0;
            //取得商品資料表所有的記錄
            GetAllProduct();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == String.Empty)
            {
                //查詢資料為空字串，取得所有的廠商記錄
                GetAllProduct();
            }
            else
            {
                switch (SearchByComboBox.SelectedIndex)
                {
                    case 0:
                        //依商品編號查詢
                        using (var context = new XINEntities())
                        {
                            //取得商品資料表商品編號條件的記錄
                            var qry = context.Product
                                             .Execute(MergeOption.OverwriteChanges)
                                             .Where(M => M.ProductID
                                                 .StartsWith(SearchTextBox.Text));
                            //將取得的結果指派給BindingSource控制項的DataSource
                            productBindingSource.DataSource = qry;
                        }
                        break;
                    case 1:
                        //依商品名稱查詢
                        using (var context = new XINEntities())
                        {
                            //取得商品資料符合商品名稱條件的記錄
                            var qry = context.Product
                                             .Execute(MergeOption.OverwriteChanges)
                                             .Where(M => M.ProductName
                                                 .StartsWith(SearchTextBox.Text));
                            //將取得的結果指派給BindingSource控制項的DataSource
                            productBindingSource.DataSource = qry;
                        }
                        break;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CanClose = true;
        }

        public string ProductID
        {
            get
            {
                //回覆使用者所選擇的商品編號
                return productDataGridView.Rows[productBindingSource.Position]
                                          .Cells[0].Value.ToString();
            }
        }

        private void productDataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            CanClose = true;
            this.Close();
        }
    }

    public class TListProductID
    {
        string FProductID;

        public string ProductID
        {
            get
            {
                //取得商品編號->顯示商品選單視窗
                FProductID = ShowProductID();
                return FProductID;
            }
            set
            {
                //設定商品編號
                FProductID = value;
            }
        }

        public string ShowProductID()
        {
            string qryProductID = FProductID;
            fmQryProduct fmQuery = new fmQryProduct();
            if (fmQuery.ShowDialog() == DialogResult.OK)
            {
                qryProductID = fmQuery.ProductID;
            }
            else
            {
                qryProductID = "";
            }
            return qryProductID;
        }
    }
}
