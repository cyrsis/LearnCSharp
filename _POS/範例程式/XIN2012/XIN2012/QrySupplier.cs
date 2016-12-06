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
    public partial class fmQrySupplier : XIN2012.fmBaseDialog
    {
        public fmQrySupplier()
        {
            InitializeComponent();
        }

        private void GetAllSupplier()
        {
            using (var context = new XINEntities())
            {
                //取得廠商資料表所有的記錄
                var qry = context.Supplier.Execute(MergeOption.OverwriteChanges);
                //將取得的結果指派給BindingSource控制項的DataSource
                supplierBindingSource.DataSource = qry;
            }
        }

        private void fmQrySupplier_Load(object sender, EventArgs e)
        {
            //預設的查詢依據-廠商編號
            SearchByComboBox.SelectedIndex = 0;
            //取得廠商資料表所有的記錄
            GetAllSupplier();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchTextBox.Text == String.Empty)
            {
                //查詢資料為空字串，取得所有的廠商記錄
                GetAllSupplier();
            }
            else
            {
                switch (SearchByComboBox.SelectedIndex)
                {
                    case 0:
                        //依廠商編號查詢
                        using (var context = new XINEntities())
                        {
                            //取得廠商資料表符合廠商編條件的記錄
                             var qry = context.Supplier
                                              .Execute(MergeOption.OverwriteChanges)
                                              .Where(M => M.SupplierID
                                                  .StartsWith(SearchTextBox.Text));
                            //將取得的結果指派給BindingSource控制項的DataSource
                            supplierBindingSource.DataSource = qry;
                        }
                        break;
                    case 1:
                        //依廠商簡稱查詢
                        using (var context = new XINEntities())
                        {
                            //取得廠商資料表符合廠商簡稱條件的記錄
                            var qry = context.Supplier
                                             .Execute(MergeOption.OverwriteChanges)
                                             .Where(M => M.AttribName
                                                 .StartsWith(SearchTextBox.Text));
                            //將取得的結果指派給BindingSource控制項的DataSource
                            supplierBindingSource.DataSource = qry;
                        }
                        break;
                    case 2:
                        //依統一編號查詢
                        using (var context = new XINEntities())
                        {
                            //取得廠商資料表符合統一編號條件的記錄
                            var qry = context.Supplier
                                             .Execute(MergeOption.OverwriteChanges)
                                             .Where(M => M.EarNo
                                                 .StartsWith(SearchTextBox.Text));
                            //將取得的結果指派給BindingSource控制項的DataSource
                            supplierBindingSource.DataSource = qry;
                        }
                        break;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            CanClose = true;
        }

        public string SupplierID
        {
            get
            {
                //回覆使用者所選擇的廠商編號
                return supplierDataGridView.Rows[supplierBindingSource.Position]
                                           .Cells[0].Value.ToString();
            }
        }

        private void supplierDataGridView_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            CanClose = true;
            this.Close();
        }
    }

    public class TListSupplierID
    {
        string FSupplierID;

        public string SupplierID
        {
            get
            {
                //取得廠商編號->顯示廠商選單視窗
                FSupplierID = ShowSupplierID();
                return FSupplierID;
            }
            set
            {
                //設定廠商編號
                FSupplierID = value;
            }
        }

        public string ShowSupplierID()
        {
            string qrySupplierID = FSupplierID;
            fmQrySupplier fmQuery = new fmQrySupplier();
            if (fmQuery.ShowDialog() == DialogResult.OK)
            {
                qrySupplierID = fmQuery.SupplierID;
            }
            return qrySupplierID;
        }
    }
}




