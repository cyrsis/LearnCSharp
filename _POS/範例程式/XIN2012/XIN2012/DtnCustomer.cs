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
    public partial class fmDtnCustomer : XIN2012.fmBase
    {

        XINEntities context = new XINEntities();
        
        public fmDtnCustomer()
        {
            InitializeComponent();
        }

        private void fmDtnCustomer_Load(object sender, EventArgs e)
        {
            //指定BindingSource物件
            BS = customerBindingSource;
            //指定主索引鍵的欄位名稱
            IDFieldName = "CustomerID";
            //指定主索引鍵的資料表名稱
            TableName = "Customer";
            string NewID;
            //取得主索引鍵最大值的LINQ to Entities
            NewID = (from M in context.Customer
                     orderby M.CustomerID descending
                     select M.CustomerID).FirstOrDefault();
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
            var qry = from M in context.Customer
                      where M.CustomerID == PrimaryID
                      select M;
            //將BindingSource物件繫結至資料來源
            customerBindingSource.DataSource = qry;
        }

        public override bool BeforeEndEdit()
        {
            if (TBStatus == 1)
            {
                if (customerIDTextBox.Text == string.Empty)
                {
                    MessageBox.Show("請輸入客戶編號！", "錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    customerIDTextBox.Focus();
                    return false;
                }
                var qry = context.Customer.Execute(MergeOption.OverwriteChanges)
                                 .Where(S => S.CustomerID
                                        == customerIDTextBox.Text)
                                 .FirstOrDefault();
                if (qry != null)
                {
                    MessageBox.Show("客戶編號重複！", "錯誤", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    customerIDTextBox.Focus();
                    return false;
                }
            }
            if (attribNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("請輸入客戶簡稱！", "錯誤",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                attribNameTextBox.Focus();
                return false;
            }
            if (companyNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("請輸入客戶名稱！", "錯誤",
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
                customerBindingSource.EndEdit();
                PrimaryID = customerIDTextBox.Text;
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
            customerIDTextBox.ReadOnly = (TBStatus == 0) || (TBStatus == 2);
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
            btnQryDeliveryList.Enabled = (TBStatus == 0);
        }

        public override void AfterAddNew()
        {
            customerIDTextBox.Focus();
        }

        public override bool BeforeDelete()
        {
            if (MessageBox.Show(string.Format(
                "刪除本筆客戶資料？\r\n\r\n客戶編號：{0}", customerIDTextBox.Text),
                "刪除記錄", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return false;
            }
            //檢查Delivery資料表是否有要刪除的客戶編號之記錄
            var Delivery = (from M in context.Delivery
                            where M.CustomerID == customerIDTextBox.Text
                            select M.CustomerID).FirstOrDefault();
            if (Delivery != null)
            {
                MessageBox.Show(String.Format("客戶編號{0}已有出貨(退回)記錄，" +
                               "無法刪除。", customerIDTextBox.Text), "參考警告",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //進行刪除記錄的程序
            DeleteID = customerIDTextBox.Text;
            return true;
        }

        public override bool DeleteData()
        {
            try
            {
                //找出目前的客戶記錄的物件
                var rowCustomer = (Customer)(customerBindingSource.Current);
                if (rowCustomer != null)
                {
                    //刪除客戶記錄
                    context.DeleteObject(rowCustomer);
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
            PrimaryID = customerIDTextBox.Text;
            return true;
        }

        private void btnQryDeliveryList_Click(object sender, EventArgs e)
        {
            //查詢出貨記錄
            if (customerIDTextBox.Text == String.Empty)
            {
                return;
            }
            fmQryDeliveryList QryDelivery = new fmQryDeliveryList();
            QryDelivery.QryCustomerID = customerIDTextBox.Text;
            QryDelivery.QryCompanyName = companyNameTextBox.Text;
            QryDelivery.ShowDialog();
        }        
    }
}
