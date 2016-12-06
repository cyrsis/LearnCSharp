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
    public partial class fmQryDeliveryList : Form
    {

        //查詢的客戶編號
        internal string QryCustomerID;
        //查詢的客戶名稱
        internal string QryCompanyName;
        //查詢的出貨別
        string QryDeliveryType;
        
        public fmQryDeliveryList()
        {
            InitializeComponent();
        }

        private void fmQryDeliveryList_Load(object sender, EventArgs e)
        {
            //顯示客戶編號
            CustomerIDTextBox.Text = QryCustomerID;
            //顯示客戶名稱
            CompanyNameTextBox.Text = QryCompanyName;
            //預設的起始日期為系統日期的所在月份的第1天
            DateTime dt = DateTime.Now;
            BeginDateDateTimePicker.Value =
                Convert.ToDateTime(dt.ToString("yyyy/MM") + "/01");
            //預設的截止日期為系統日期
            EndDateDateTimePicker.Value = DateTime.Now;
            //預設為查詢出貨
            RadioButton1.Checked = true;
            //執行查詢客戶出貨（出貨退回）記錄
            QryDeliveryData();
        }

        private void QryDeliveryData()
        {
            using (var context = new XINEntities())
            {
                var qry = from M in context.Delivery
                          join D in context.DeliveryDetails
                              on M.DeliveryID equals D.DeliveryID
                          join P in context.Product
                              on D.ProductID equals P.ProductID
                          where M.CustomerID == QryCustomerID
                          && M.DeliveryDate >= BeginDateDateTimePicker.Value
                          && M.DeliveryDate <= EndDateDateTimePicker.Value
                          && M.DeliveryType == QryDeliveryType
                          orderby M.DeliveryID, D.DeliverySeq
                          select new
                          {
                              M.DeliveryDate, M.DeliveryID, D.DeliverySeq,
                              D.ProductID, P.ProductName, P.Unit,
                              D.Quantity, D.UnitPrice, D.Amount
                          };
                //定義儲存格的樣式(針對數值欄位)
                DataGridViewCellStyle columnStyle = new DataGridViewCellStyle();
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
                DataGridView1.Columns[0].HeaderText = "出貨日期";
                DataGridView1.Columns[1].HeaderText = "出貨單號";
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
                QryDeliveryType = "1";
            }
            else
            {
                QryDeliveryType = "2";
            }
            QryDeliveryData();
        }
    }
}
