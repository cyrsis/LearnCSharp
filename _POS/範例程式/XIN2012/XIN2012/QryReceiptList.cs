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
    public partial class fmQryReceiptList : Form
    {

        //查詢的廠商編號
        internal string QrySupplierID;
        //查詢的廠商名稱
        internal string QryCompanyName;
        //查詢的進貨別
        string QryReceiptType;

        public fmQryReceiptList()
        {
            InitializeComponent();
        }

        private void fmQryReceiptList_Load(object sender, EventArgs e)
        {
            //顯示廠商編號
            SupplierIDTextBox.Text = QrySupplierID;
            //顯示廠商名稱
            CompanyNameTextBox.Text = QryCompanyName;
            //預設的起始日期為系統日期的所在月份的第1天
            DateTime dt = DateTime.Now;
            BeginDateDateTimePicker.Value = 
                Convert.ToDateTime(dt.ToString("yyyy/MM") + "/01");
            //預設的截止日期為系統日期
            EndDateDateTimePicker.Value = DateTime.Now;
            //預設為查詢進貨
            RadioButton1.Checked = true;
            //執行廠商進貨（進貨退出）記錄查詢
            QryReceiptData();
        }

        private void QryReceiptData()
        {
            using (var context = new XINEntities())
            {
                var qry = from M in context.Receipt
                          join D in context.ReceiptDetails
                              on M.ReceiptID equals D.ReceiptID
                          join P in context.Product
                              on D.ProductID equals P.ProductID
                          where M.SupplierID == QrySupplierID
                          && M.ReceiptDate >= BeginDateDateTimePicker.Value
                          && M.ReceiptDate <= EndDateDateTimePicker.Value
                          && M.ReceiptType == QryReceiptType
                          orderby M.ReceiptID, D.ReceiptSeq
                          select new
                          {
                              M.ReceiptDate, M.ReceiptID, D.ReceiptSeq,
                              D.ProductID, P.ProductName, P.Unit,
                              D.Quantity, D.UnitPrice, D.Amount
                          };
                //定義儲存格的樣式(針對數值欄位)
                DataGridViewCellStyle columnStyle  = new  DataGridViewCellStyle();
                //靠右顯示
                columnStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //格式顯示的內容，依數值，無小數點
                columnStyle.Format = "N0";
                //接收資料來源
                DataGridView1.DataSource = qry;
                //欄位寬度
                DataGridView1.Columns[0].Width = 100;
                DataGridView1.Columns[1].Width = 100;
                DataGridView1.Columns[2].Width = 65;
                DataGridView1.Columns[3].Width = 100;
                DataGridView1.Columns[4].Width = 250;
                DataGridView1.Columns[5].Width = 70;
                DataGridView1.Columns[6].Width = 70;
                DataGridView1.Columns[7].Width = 70;
                DataGridView1.Columns[8].Width = 90;
                //欄位抬頭
                DataGridView1.Columns[0].HeaderText = "進貨日期";
                DataGridView1.Columns[1].HeaderText = "進貨單號";
                DataGridView1.Columns[2].HeaderText = "項次";
                DataGridView1.Columns[3].HeaderText = "商品編號";
                DataGridView1.Columns[4].HeaderText = "商品名稱";
                DataGridView1.Columns[5].HeaderText = "單位";
                DataGridView1.Columns[6].HeaderText = "數量";
                DataGridView1.Columns[7].HeaderText = "單價";
                DataGridView1.Columns[8].HeaderText = "金額";
                //配置資料類型為數值欄位的顯示樣式
                DataGridView1.Columns[6].DefaultCellStyle = columnStyle;
                DataGridView1.Columns[7].DefaultCellStyle = columnStyle;
                DataGridView1.Columns[8].DefaultCellStyle = columnStyle;
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                QryReceiptType = "1";
            }
            else
            {
                QryReceiptType = "2";
            }
            QryReceiptData();
        }
    }
}
