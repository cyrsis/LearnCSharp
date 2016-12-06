using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_04_01
{
    public partial class Form1 : Form
    {

        DataSet dsXIN;
        DataTable dtCustomer;
        BindingSource bsCustomer;       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dsXIN = new DataSet("XIN");
            CreateCustomerTable();
            BindingData();
            bsCustomer.AddingNew += new AddingNewEventHandler(bsCustomer_AddingNew);
            bsCustomer.ListChanged += new ListChangedEventHandler(bsCustomer_ListChanged);
            bsCustomer.PositionChanged += new EventHandler(bsCustomer_PositionChanged);
        }

        private void CreateCustomerTable()
        {
            dtCustomer = new DataTable("Customer");
            dsXIN.Tables.Add(dtCustomer);
            //客戶編號
            DataColumn colCustomerID = new DataColumn("CustomerID");
            colCustomerID.DataType = System.Type.GetType("System.String");
            colCustomerID.MaxLength = 8;
            colCustomerID.AllowDBNull = false;
            //公司名稱
            DataColumn colCompanyName = new DataColumn("CompanyName");
            colCompanyName.DataType = System.Type.GetType("System.String");
            colCompanyName.MaxLength = 40;
            colCompanyName.AllowDBNull = false;
            //連絡人
            DataColumn colContact = new DataColumn("Contact");
            colContact.DataType = System.Type.GetType("System.String");
            colContact.MaxLength = 12;
            colContact.AllowDBNull = false;
            //電話
            DataColumn colPhone = new DataColumn("Phone");
            colPhone.DataType = System.Type.GetType("System.String");
            colPhone.MaxLength = 20;
            //傳真
            DataColumn colFax = new DataColumn("Fax");
            colFax.DataType = System.Type.GetType("System.String");
            colFax.MaxLength = 20;
            //地址
            DataColumn colAddress = new DataColumn("Address");
            colAddress.DataType = System.Type.GetType("System.String");
            colAddress.MaxLength = 60;
            //建立欄位並加入客戶資料表
            dtCustomer.Columns.Add(colCustomerID);
            dtCustomer.Columns.Add(colCompanyName);
            dtCustomer.Columns.Add(colContact);
            dtCustomer.Columns.Add(colPhone);
            dtCustomer.Columns.Add(colFax);
            dtCustomer.Columns.Add(colAddress);

            dtCustomer.PrimaryKey = new DataColumn[] { colCustomerID };

            dtCustomer.Rows.Add(new Object[] { "SS", "三星科技股份有限公司",
                            "陳政輝", "06-2306611", "06-2306000", 
                            "台南縣歸仁鄉南興村中山路三段355-6號" });
            dtCustomer.Rows.Add(new Object[] { "MIRDC", "金屬工業研究發展中心",
                            "徐學慈", "07-3513121", "07-3527246",
                            "高雄市楠梓區高楠公路1001號" });
            dtCustomer.Rows.Add(new Object[] {"PLX", "普愛資訊管理股份有限公司", 
                            "潘委倫", "09-3293019", 
                            "09-3293020", "台北市內湖區中正路200號20樓"});
            dtCustomer.Rows.Add(new Object[] { "SATALL", "薩托爾貿易有限公司",
                            "鄭宏輝", "02-68902902", "02-68902904",
                            "基隆市東光路三段25號" });
            dtCustomer.Rows.Add(new Object[] {"TEMP", "暫時科技有限公司", 
                            "鄭宏輝", "02-33789512", 
                            "02-33789515", "台北市中正區中強路109號33樓"});
        }

        private void BindingData()
        {
            //建立BindingSource物件
            bsCustomer = new BindingSource(dsXIN, "Customer");
            //設定TextBox控制項的資料繫結
            txtCustomerID.DataBindings.Add("Text", bsCustomer, "CustomerID");
            txtCompanyName.DataBindings.Add("Text", bsCustomer, "CompanyName");
            txtContact.DataBindings.Add("Text", bsCustomer, "Contact");
            txtPhone.DataBindings.Add("Text", bsCustomer, "Phone");
            txtFax.DataBindings.Add("Text", bsCustomer, "Fax");
            txtAddress.DataBindings.Add("Text", bsCustomer, "Address");
            //設定DataGridView1控制項顯示BindingSource的資料來源
            DataGridView1.DataSource = bsCustomer;
            //將DataColumn載入ComboBox,做為排序或尋找的參考欄位
            comboSortDataColumn.Items.Clear();
            comboFindDataColumn.Items.Clear();
            int i;
            for (i = 0; i <= dtCustomer.Columns.Count - 1; i++)
            {
                comboSortDataColumn.Items.Add(dtCustomer.Columns[i].ColumnName);
                comboFindDataColumn.Items.Add(dtCustomer.Columns[i].ColumnName);
            }
            comboSortDataColumn.SelectedIndex = 0;
            comboFindDataColumn.SelectedIndex = 0;
        }

        //AddingNew事件
        private void bsCustomer_AddingNew(object sender, AddingNewEventArgs e)
        {
            txtCustomerID.Focus();
        }

        //ListChanged事件
        private void bsCustomer_ListChanged(object sender, ListChangedEventArgs e)
        {
            ListBox1.Items.Add(e.ListChangedType);
            ListBox1.Items.Add(e.NewIndex);
            ListBox1.Items.Add(e.OldIndex);
        }

        //利用PositionChanged改變記錄指標按鈕的狀態
        private void bsCustomer_PositionChanged(Object sender, EventArgs e)
        {
            btnMoveFirst.Enabled = (bsCustomer.Position > 0);
            btnMovePrevious.Enabled = (bsCustomer.Position > 0);
            btnMoveNext.Enabled = (bsCustomer.Position < bsCustomer.Count - 1);
            btnMoveLast.Enabled = (bsCustomer.Position < bsCustomer.Count - 1);
        }

        private void btnMoveFirst_Click(object sender, EventArgs e)
        {
            //移到第一筆記錄
            bsCustomer.MoveFirst();
        }

        private void btnMovePrevious_Click(object sender, EventArgs e)
        {
            //移到上一筆記錄
            bsCustomer.MovePrevious();
        }

        private void btnMoveNext_Click(object sender, EventArgs e)
        {
            //移到下一筆記錄
            bsCustomer.MoveNext();
        }

        private void btnMoveLast_Click(object sender, EventArgs e)
        {
            //移到最後一筆記錄
            bsCustomer.MoveLast();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //新增一筆空的記錄
            bsCustomer.AddNew();
        }

        private void btnEndEdit_Click(object sender, EventArgs e)
        {
            //儲存編輯
            bsCustomer.EndEdit();
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            //取消編輯
            bsCustomer.CancelEdit();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //移除目前記錄指標的記錄
            bsCustomer.RemoveCurrent();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //記錄篩選
            bsCustomer.Filter = txtFilter.Text;
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //執行排序
            if (radioASC.Checked)
            {
                //升冪
                bsCustomer.Sort = comboSortDataColumn.Text + " " + "ASC";
            }
            else
            {
                //降冪
                bsCustomer.Sort = comboSortDataColumn.Text + " " + "DESC";
            }
        }

        private void btnRemoveFilter_Click(object sender, EventArgs e)
        {
            //移除篩選條件
            bsCustomer.RemoveFilter();
        }

        private void btnRemoveSort_Click(object sender, EventArgs e)
        {
            //移除排序條件
            bsCustomer.RemoveSort();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //尋找記錄
            int foundIndex = bsCustomer.Find(comboFindDataColumn.Text, 
                                             txtFindValue.Text);
            if (foundIndex > -1)
            {
                bsCustomer.Position = foundIndex;
            }
            else
            {
                MessageBox.Show("找不到要尋找的記錄!");
            }
        }
    }
}
