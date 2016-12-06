using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIN2012
{
    public partial class fmQryTransfer : Form
    {

        XINFunction XIN = new XINFunction();
       
        public fmQryTransfer()
        {
            InitializeComponent();
        }

        private void fmQryTransfer_Load(object sender, EventArgs e)
        {
            //預設的起始日期為系統日期的所在月份的第1天
            DateTime dt;
            dt = DateTime.Now;
            BeginDateDateTimePicker.Value = Convert.ToDateTime(dt.ToString("yyyy/MM") + "/01");
            //預設的截止日期為系統日期
            EndDateDateTimePicker.Value = DateTime.Now;
            //設定顯示的索引頁籤
            TabControl1.SelectedIndex = 0;
        }

        private void btnQryProduct_Click(object sender, EventArgs e)
        {
            //開窗查詢商品編號
            TListProductID SelectProductID = new TListProductID();
            ProductIDTextBox.Text = SelectProductID.ProductID;
            ProductIDTextBox.Focus();
        }

        private void ProductIDTextBox_Validated(object sender, EventArgs e)
        {
            //顯示商品名稱
            ProductNameTextBox.Text = XIN.GetProductName(ProductIDTextBox.Text);
            //顯示單位
            UnitTextBox.Text = XIN.GetUnit(ProductIDTextBox.Text);
        }

        //執行查詢商品別庫存異動記錄
        private void btnQuery_Click(object sender, EventArgs e)
        {         
            //定義儲存格的樣式(針對庫存量)
            DataGridViewCellStyle columnStyle = new DataGridViewCellStyle();
            //靠右顯示
            columnStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            //格式顯示的內容，依數值，無小數點
            columnStyle.Format = "N0";
            using (var context = new XINEntities())
            {
                //進貨
                var qry1 = from M in context.Receipt
                           join D in context.ReceiptDetails
                               on M.ReceiptID equals D.ReceiptID
                           join S in context.Supplier
                               on M.SupplierID equals S.SupplierID
                           where D.ProductID == ProductIDTextBox.Text
                           && M.ReceiptDate >= BeginDateDateTimePicker.Value
                           && M.ReceiptDate <= EndDateDateTimePicker.Value
                           && M.ReceiptType == "1"
                           orderby M.ReceiptID, D.ReceiptSeq
                           select new
                           {
                               M.ReceiptDate,
                               M.ReceiptID,
                               M.SupplierID,
                               S.AttribName,
                               D.ReceiptSeq,
                               D.Quantity,
                               D.UnitPrice,
                               D.Amount
                           };
                //接收資料來源
                DataGridView1.DataSource = qry1;
                //欄位寬度
                DataGridView1.Columns[0].Width = 100;
                DataGridView1.Columns[1].Width = 100;
                DataGridView1.Columns[2].Width = 100;
                DataGridView1.Columns[3].Width = 100;
                DataGridView1.Columns[4].Width = 65;
                DataGridView1.Columns[5].Width = 70;
                DataGridView1.Columns[6].Width = 70;
                DataGridView1.Columns[7].Width = 90;
                //欄位抬頭
                DataGridView1.Columns[0].HeaderText = "進貨日期";
                DataGridView1.Columns[1].HeaderText = "進貨單號";
                DataGridView1.Columns[2].HeaderText = "廠商編號";
                DataGridView1.Columns[3].HeaderText = "廠商簡稱";
                DataGridView1.Columns[4].HeaderText = "項次";
                DataGridView1.Columns[5].HeaderText = "數量";
                DataGridView1.Columns[6].HeaderText = "單價";
                DataGridView1.Columns[7].HeaderText = "金額";
                //配置資料類型為數值欄位的顯示樣式
                DataGridView1.Columns[5].DefaultCellStyle = columnStyle;
                DataGridView1.Columns[6].DefaultCellStyle = columnStyle;
                DataGridView1.Columns[7].DefaultCellStyle = columnStyle;
                //進貨退出
                var qry2 = from M in context.Receipt
                           join D in context.ReceiptDetails
                               on M.ReceiptID equals D.ReceiptID
                           join S in context.Supplier
                               on M.SupplierID equals S.SupplierID
                           where D.ProductID == ProductIDTextBox.Text
                           && M.ReceiptDate >= BeginDateDateTimePicker.Value
                           && M.ReceiptDate <= EndDateDateTimePicker.Value
                           && M.ReceiptType == "2"
                           orderby M.ReceiptID, D.ReceiptSeq
                           select new
                           {
                               M.ReceiptDate,
                               M.ReceiptID,
                               M.SupplierID,
                               S.AttribName,
                               D.ReceiptSeq,
                               D.Quantity,
                               D.UnitPrice,
                               D.Amount
                           };
                //接收資料來源
                DataGridView2.DataSource = qry2;
                //欄位寬度
                DataGridView2.Columns[0].Width = 100;
                DataGridView2.Columns[1].Width = 100;
                DataGridView2.Columns[2].Width = 100;
                DataGridView2.Columns[3].Width = 100;
                DataGridView2.Columns[4].Width = 65;
                DataGridView2.Columns[5].Width = 70;
                DataGridView2.Columns[6].Width = 70;
                DataGridView2.Columns[7].Width = 90;
                //欄位抬頭
                DataGridView2.Columns[0].HeaderText = "進貨日期";
                DataGridView2.Columns[1].HeaderText = "進貨單號";
                DataGridView2.Columns[2].HeaderText = "廠商編號";
                DataGridView2.Columns[3].HeaderText = "廠商簡稱";
                DataGridView2.Columns[4].HeaderText = "項次";
                DataGridView2.Columns[5].HeaderText = "數量";
                DataGridView2.Columns[6].HeaderText = "單價";
                DataGridView2.Columns[7].HeaderText = "金額";
                //配置資料類型為數值欄位的顯示樣式
                DataGridView2.Columns[5].DefaultCellStyle = columnStyle;
                DataGridView2.Columns[6].DefaultCellStyle = columnStyle;
                DataGridView2.Columns[7].DefaultCellStyle = columnStyle;
                //出貨
                var qry3 = from M in context.Delivery
                           join D in context.DeliveryDetails
                               on M.DeliveryID equals D.DeliveryID
                           join R in context.Customer
                               on M.CustomerID equals R.CustomerID
                           where D.ProductID == ProductIDTextBox.Text
                           && M.DeliveryDate >= BeginDateDateTimePicker.Value
                           && M.DeliveryDate <= EndDateDateTimePicker.Value
                           && M.DeliveryType == "1"
                           orderby M.DeliveryID, D.DeliverySeq
                           select new
                           {
                               M.DeliveryDate,
                               M.DeliveryID,
                               M.CustomerID,
                               R.AttribName,
                               D.DeliverySeq,
                               D.Quantity,
                               D.UnitPrice,
                               D.Amount
                           };
                //接收資料來源
                DataGridView3.DataSource = qry3;
                //欄位寬度
                DataGridView3.Columns[0].Width = 100;
                DataGridView3.Columns[1].Width = 100;
                DataGridView3.Columns[2].Width = 100;
                DataGridView3.Columns[3].Width = 100;
                DataGridView3.Columns[4].Width = 65;
                DataGridView3.Columns[5].Width = 70;
                DataGridView3.Columns[6].Width = 70;
                DataGridView3.Columns[7].Width = 90;
                //欄位抬頭
                DataGridView3.Columns[0].HeaderText = "出貨日期";
                DataGridView3.Columns[1].HeaderText = "出貨單號";
                DataGridView3.Columns[2].HeaderText = "客戶編號";
                DataGridView3.Columns[3].HeaderText = "客戶簡稱";
                DataGridView3.Columns[4].HeaderText = "項次";
                DataGridView3.Columns[5].HeaderText = "數量";
                DataGridView3.Columns[6].HeaderText = "單價";
                DataGridView3.Columns[7].HeaderText = "金額";
                //配置資料類型為數值欄位的顯示樣式
                DataGridView3.Columns[5].DefaultCellStyle = columnStyle;
                DataGridView3.Columns[6].DefaultCellStyle = columnStyle;
                DataGridView3.Columns[7].DefaultCellStyle = columnStyle;
                //出貨退回
                var qry4 = from M in context.Delivery
                           join D in context.DeliveryDetails
                               on M.DeliveryID equals D.DeliveryID
                           join R in context.Customer
                               on M.CustomerID equals R.CustomerID
                           where D.ProductID == ProductIDTextBox.Text
                           && M.DeliveryDate >= BeginDateDateTimePicker.Value
                           && M.DeliveryDate <= EndDateDateTimePicker.Value
                           && M.DeliveryType == "2"
                           orderby M.DeliveryID, D.DeliverySeq
                           select new
                           {
                               M.DeliveryDate,
                               M.DeliveryID,
                               M.CustomerID,
                               R.AttribName,
                               D.DeliverySeq,
                               D.Quantity,
                               D.UnitPrice,
                               D.Amount
                           };
                //接收資料來源
                DataGridView4.DataSource = qry4;
                //欄位寬度
                DataGridView4.Columns[0].Width = 100;
                DataGridView4.Columns[1].Width = 100;
                DataGridView4.Columns[2].Width = 100;
                DataGridView4.Columns[3].Width = 100;
                DataGridView4.Columns[4].Width = 65;
                DataGridView4.Columns[5].Width = 70;
                DataGridView4.Columns[6].Width = 70;
                DataGridView4.Columns[7].Width = 90;
                //欄位抬頭
                DataGridView4.Columns[0].HeaderText = "出貨日期";
                DataGridView4.Columns[1].HeaderText = "出貨單號";
                DataGridView4.Columns[2].HeaderText = "客戶編號";
                DataGridView4.Columns[3].HeaderText = "客戶簡稱";
                DataGridView4.Columns[4].HeaderText = "項次";
                DataGridView4.Columns[5].HeaderText = "數量";
                DataGridView4.Columns[6].HeaderText = "單價";
                DataGridView4.Columns[7].HeaderText = "金額";
                //配置資料類型為數值欄位的顯示樣式
                DataGridView4.Columns[5].DefaultCellStyle = columnStyle;
                DataGridView4.Columns[6].DefaultCellStyle = columnStyle;
                DataGridView4.Columns[7].DefaultCellStyle = columnStyle;
                //存貨入庫
                var qry5 = from M in context.Transfer
                           join D in context.TransferDetails
                               on M.TransferID equals D.TransferID
                           where D.ProductID == ProductIDTextBox.Text
                           && M.TransferDate >= BeginDateDateTimePicker.Value
                           && M.TransferDate <= EndDateDateTimePicker.Value
                           && M.TransferType == "1"
                           orderby M.TransferID, D.Seq
                           select new
                           {
                               M.TransferDate,
                               M.TransferID,
                               D.Seq,
                               D.Quantity,
                               D.Amount
                           };
                //接收資料來源
                DataGridView5.DataSource = qry5;
                //欄位寬度
                DataGridView5.Columns[0].Width = 100;
                DataGridView5.Columns[1].Width = 100;
                DataGridView5.Columns[2].Width = 65;
                DataGridView5.Columns[3].Width = 70;
                DataGridView5.Columns[4].Width = 90;
                //欄位抬頭
                DataGridView5.Columns[0].HeaderText = "異動日期";
                DataGridView5.Columns[1].HeaderText = "異動單號";
                DataGridView5.Columns[2].HeaderText = "項次";
                DataGridView5.Columns[3].HeaderText = "數量";
                DataGridView5.Columns[4].HeaderText = "金額";
                //配置資料類型為數值欄位的顯示樣式
                DataGridView5.Columns[3].DefaultCellStyle = columnStyle;
                DataGridView5.Columns[4].DefaultCellStyle = columnStyle;
                //
                //存貨出庫
                var qry6 = from M in context.Transfer
                           join D in context.TransferDetails
                               on M.TransferID equals D.TransferID
                           where D.ProductID == ProductIDTextBox.Text
                           && M.TransferDate >= BeginDateDateTimePicker.Value
                           && M.TransferDate <= EndDateDateTimePicker.Value
                           && M.TransferType == "2"
                           orderby M.TransferID, D.Seq
                           select new
                           {
                               M.TransferDate,
                               M.TransferID,
                               D.Seq,
                               D.Quantity,
                               D.Amount
                           };
                //接收資料來源
                DataGridView6.DataSource = qry6;
                //欄位寬度
                DataGridView6.Columns[0].Width = 100;
                DataGridView6.Columns[1].Width = 100;
                DataGridView6.Columns[2].Width = 65;
                DataGridView6.Columns[3].Width = 70;
                DataGridView6.Columns[4].Width = 90;
                //欄位抬頭
                DataGridView6.Columns[0].HeaderText = "異動日期";
                DataGridView6.Columns[1].HeaderText = "異動單號";
                DataGridView6.Columns[2].HeaderText = "項次";
                DataGridView6.Columns[3].HeaderText = "數量";
                DataGridView6.Columns[4].HeaderText = "金額";
                //配置資料類型為數值欄位的顯示樣式
                DataGridView6.Columns[3].DefaultCellStyle = columnStyle;
                DataGridView6.Columns[4].DefaultCellStyle = columnStyle;
            }   
        }
    }
}
