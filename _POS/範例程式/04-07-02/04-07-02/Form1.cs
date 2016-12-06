using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _04_07_02
{
    public partial class Form1 : Form
    {

        //定義與建立連線物件
        SqlConnection cnSQL = new SqlConnection();     

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnSQL.StateChange += new StateChangeEventHandler(cnSQL_StateChange);
            //定義與建立連線字串物件
            SqlConnectionStringBuilder ConnString = new SqlConnectionStringBuilder();
            listBox1.Items.Add("---  1  ----");
            //將連線參數加入連線字串物件
            ConnString.Add("Data Source", "localhost");
            ConnString.Add("Initial Catalog", "XIN");
            ConnString.Add("Integrated Security", "SSPI");
            //填入連線字串
            cnSQL.ConnectionString = ConnString.ConnectionString;
            //開啟連接物件
            cnSQL.Open();
            listBox1.Items.Add("連線參數個數 : " + Convert.ToString(ConnString.Count));
            listBox1.Items.Add("Initital Catalog的值:" + 
                                Convert.ToString(ConnString["Initial Catalog"]));
            //關閉連接物件
            cnSQL.Close();
            listBox1.Items.Add("---  2  ----");
            //清除連線字串物件內的連線參數
            listBox1.Items.Add("使用Clear方法清除連線字串物件內的連線參數");
            ConnString.Clear();
            listBox1.Items.Add("連線參數個數 : " + Convert.ToString(ConnString.Count));
            listBox1.Items.Add("---  3  ----");
            //重新建立連線字串
            ConnString.Add("Data Source", "localhost");
            ConnString.Add("Initial Catalog", "XIN");
            ConnString.Add("Integrated Security", "SSPI");
            ConnString.Add("Connect Timeout", 5);
            //填入連線字串
            cnSQL.ConnectionString = ConnString.ConnectionString;
            //開啟連接物件
            cnSQL.Open();
            listBox1.Items.Add("連線參數個數 : " + Convert.ToString(ConnString.Count));
            listBox1.Items.Add("Initital Catalog的值:" + ConnString["Initial Catalog"]);
            //關閉連接物件
            cnSQL.Close();
            listBox1.Items.Add("---  4  ----");
            //移除連線字串物件內的一個連線字串
            listBox1.Items.Add("移除連線字串物件內的一個連線字串:Connect Timeout");
            ConnString.Remove("Connect Timeout");
            //開啟連接物件
            cnSQL.Open();
            listBox1.Items.Add("連線參數個數 : " + Convert.ToString(ConnString.Count));
            //關閉連接物件
            cnSQL.Close();
            listBox1.Items.Add("---  5  ----");
            //修改連線字串內容
            listBox1.Items.Add("使用Item屬性修改連線字串內容");
            ConnString["Initial Catalog"] = "XIN";
            //開啟連接物件
            cnSQL.Open();
            //秀出目前的連線字串
            listBox1.Items.Add("目前的連線字串:" + cnSQL.ConnectionString);
            listBox1.Items.Add("---  6  ----");
            //秀出目前連線字串物件內的每一個值
            listBox1.Items.Add("秀出目前連線字串物件內的每一個值");
            foreach (String key in ConnString.Keys)
            {
                listBox1.Items.Add("連線字串的每一個Key: " + key.ToString() + ":" +
                                   ConnString[key]);
            }
            listBox1.Items.Add("---  7  ----");
            object value = null;
            //嘗試找出指定的連線參數"Initial Catalog"是否有值
            if (ConnString.TryGetValue("Initial Catalog", out value))
            {
                listBox1.Items.Add("找到連線參數為Initial Catalog, 它的值為" + value.ToString());
            }
            //嘗試找出指定的連線參數"ABC"是否有值
            if (!ConnString.TryGetValue("ABC", out value))
            {
                listBox1.Items.Add("找不到連線參數為ABC的值");
            }
            //關閉連接物件
            cnSQL.Close();
        }

        void cnSQL_StateChange(object sender, StateChangeEventArgs e)
        {
            listBox1.Items.Add("目前狀態:" + e.CurrentState.ToString());
        }
    }
}
