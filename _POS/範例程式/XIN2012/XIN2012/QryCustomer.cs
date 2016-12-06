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
    public partial class fmQryCustomer : XIN2012.fmBaseDialog
    {
        public fmQryCustomer()
        {
            InitializeComponent();
        }

        private void GetAllCustomer()
        {
            using (var context = new XINEntities())
            {
                //取得客戶資料表所有的記錄
                var qry = context.Customer.Execute(MergeOption.OverwriteChanges);
                //將取得的結果指派給BindingSource控制項的DataSource
                customerBindingSource.DataSource = qry;
            }
        }

        private void fmQryCustomer_Load(object sender, EventArgs e)
        {
            //預設的查詢依據-客戶編號
            SearchByComboBox.SelectedIndex = 0;
            //取得客戶資料表所有的記錄
            GetAllCustomer();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == String.Empty)
            {
                //查詢資料為空字串，取得所有的客戶記錄
                GetAllCustomer();
            }
            else
            {
                switch (SearchByComboBox.SelectedIndex)
                {
                    case 0:
                        //依客戶編號查詢
                        using (var context = new XINEntities())
                        {
                            //取得客戶資料表符合客戶編號條件的記錄
                            var qry = context.Customer
                                             .Execute(MergeOption.OverwriteChanges)
                                             .Where(M => M.CustomerID
                                                 .StartsWith(SearchTextBox.Text));
                            //將取得的結果指派給BindingSource控制項的DataSource
                            customerBindingSource.DataSource = qry;
                        }
                        break;
                    case 1:
                        //依客戶簡稱查詢
                        using (var context = new XINEntities())
                        {
                            //取得客戶資料表符合客戶簡稱條件的記錄
                            var qry = context.Customer
                                             .Execute(MergeOption.OverwriteChanges)
                                             .Where(M => M.AttribName
                                                 .StartsWith(SearchTextBox.Text));
                            //將取得的結果指派給BindingSource控制項的DataSource
                            customerBindingSource.DataSource = qry;
                        }
                        break;
                    case 2:
                        //依統一編號查詢
                        using (var context = new XINEntities())
                        {
                            //取得客戶資料表符合統一編號條件的記錄
                            var qry = context.Customer
                                             .Execute(MergeOption.OverwriteChanges)
                                             .Where(M => M.EarNo
                                                 .StartsWith(SearchTextBox.Text));
                            //將取得的結果指派給BindingSource控制項的DataSource
                            customerBindingSource.DataSource = qry;
                        }
                        break;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CanClose = true;
        }

        public string CustomerID
        {
            get
            {
                //回覆使用者所選擇的廠商編號
                return customerDataGridView.Rows[customerBindingSource.Position]
                                           .Cells[0].Value.ToString();
            }
        }

        private void customerDataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            CanClose = true;
            this.Close();
        }
    }

    public class TListCustomerID
    {
        string FCustomerD;

        public string CustomerID
        {
            get
            {
                //取得廠商編號->顯示廠商選單視窗
                FCustomerD = ShowCustomerID();
                return FCustomerD;
            }
            set
            {
                //設定廠商編號
                FCustomerD = value;
            }
        }

        public string ShowCustomerID()
        {
            string qryCustomerID = FCustomerD;
            fmQryCustomer fmQuery = new fmQryCustomer();
            if (fmQuery.ShowDialog() == DialogResult.OK)
            {
                qryCustomerID = fmQuery.CustomerID;
            }
            return qryCustomerID;
        }
    }
}
