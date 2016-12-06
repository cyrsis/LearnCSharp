using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Linq;
using System.Data.Common;

namespace XIN2012
{
    public partial class fmDtnSupplier : XIN2012.fmBase
    {

        XINEntities context = new XINEntities();
        
        public fmDtnSupplier()
        {
            InitializeComponent();
        }

        private void fmDtnSupplier_Load(object sender, EventArgs e)
        {
            //指定BindingSource物件
            BS = supplierBindingSource;
            //指定主索引鍵的欄位名稱
            IDFieldName = "SupplierID";
            //指定主索引鍵的資料表名稱
            TableName = "Supplier";
            string NewID;
            //取得主索引鍵最大值的LINQ to Entities
            NewID = (from M in context.Supplier
                     orderby M.SupplierID descending
                     select M.SupplierID).FirstOrDefault();
            if (NewID != null)
            {
                PrimaryID = NewID;
            }
            else
            {
                PrimaryID = "";
            }
            //移至主索引鍵最大值的記錄
            FillData();
            //是否允許刪除
            AllowDelete = true;
        }

        public override void FillData()
        {
            var qry = from M in context.Supplier
                      where M.SupplierID == PrimaryID
                      select M;
            //將BindingSource物件繫結至資料來源
            supplierBindingSource.DataSource = qry;     
        }

        public override bool BeforeEndEdit()
        {
            if (TBStatus == 1)
            {
                if (supplierIDTextBox.Text == string.Empty)
                {
                    MessageBox.Show("請輸入廠商編號！", "錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    supplierIDTextBox.Focus();
                    return false;
                }
                var qry = context.Supplier.Execute(MergeOption.OverwriteChanges)
                                 .Where(S => S.SupplierID
                                        == supplierIDTextBox.Text)
                                 .FirstOrDefault();
                if (qry != null)
                {
                    MessageBox.Show("廠商編號重複！", "錯誤", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    supplierIDTextBox.Focus();
                    return false;
                }
            }
            if (attribNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("請輸入廠商簡稱！", "錯誤",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                attribNameTextBox.Focus();
                return false;
            }
            if (companyNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("請輸入廠商名稱！", "錯誤",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                companyNameTextBox.Focus();
                return false;
            }
            return true;
        }

        public override bool UpdateData()
        {
            try
            {
                this.Validate();
                //結束編輯
                supplierBindingSource.EndEdit();
                PrimaryID = supplierIDTextBox.Text;
                //更新資料
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "更新錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public override void SetControls()
        {
            supplierIDTextBox.ReadOnly = (TBStatus == 0) || (TBStatus == 2);
            attribNameTextBox.ReadOnly = (TBStatus == 0);
            earNoTextBox.ReadOnly = (TBStatus == 0);
            companyNameTextBox.ReadOnly = (TBStatus == 0);
            joinManTextBox.ReadOnly = (TBStatus == 0);
            mobilePhoneTextBox.ReadOnly = (TBStatus == 0);
            tel1TextBox.ReadOnly = (TBStatus == 0);
            tel2TextBox.ReadOnly = (TBStatus == 0);
            faxTextBox.ReadOnly = (TBStatus == 0);
            companyAddressTextBox.ReadOnly = (TBStatus == 0);
            deliveryAddressTextBox.ReadOnly = (TBStatus == 0);
            commentTextBox.ReadOnly = (TBStatus == 0);
            btnQryReceiptList.Enabled = (TBStatus == 0);
        }

        public override void AfterAddNew()
        {
            supplierIDTextBox.Focus();
        }

        public override bool BeforeDelete()
        {
            if (MessageBox.Show(string.Format(
                "刪除本筆廠商資料？\r\n\r\n廠商編號：{0}", supplierIDTextBox.Text),
                "刪除記錄", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return false;
            }
            //檢查Receipt資料表是否有要刪除的廠商編號之記錄
            var Receipr = (from M in context.Receipt
                           where M.SupplierID == supplierIDTextBox.Text
                           select M.SupplierID).FirstOrDefault();
            if (Receipr != null)
            {
                MessageBox.Show(String.Format("廠商編號{0}已有進貨(退出)記錄，" +
                                "無法刪除。", supplierIDTextBox.Text), "參考警告",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //進行刪除記錄的程序
            DeleteID = supplierIDTextBox.Text;
            return true;
        }

        public override bool DeleteData()
        {
            try
            {
                //找出目前的廠商記錄的物件
                var rowSupplier = (Supplier)(supplierBindingSource.Current);
                if (rowSupplier != null)
                {
                    //刪除廠商記錄
                    context.DeleteObject(rowSupplier);
                    //更新資料
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //秀出錯誤訊息
                MessageBox.Show(ex.Message, "刪除錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            PrimaryID = supplierIDTextBox.Text;
            return true;
        }

        private void btnQryReceiptList_Click(object sender, EventArgs e)
        {
            //查詢進貨記錄
            if (supplierIDTextBox.Text == String.Empty)
            {
                return;
            }
            fmQryReceiptList QryReceipt = new fmQryReceiptList();
            QryReceipt.QrySupplierID = supplierIDTextBox.Text;
            QryReceipt.QryCompanyName = companyNameTextBox.Text;
            QryReceipt.ShowDialog();
        }
    }
}
