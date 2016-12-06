using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sqlConnection1_StateChange(object sender, StateChangeEventArgs e)
        {
            listBox1.Items.Add("Connection原來的狀態:");
            ConnectionStateDescription(e.OriginalState);
            listBox1.Items.Add("Connection原來的狀態:");
            ConnectionStateDescription(e.CurrentState);
            listBox1.Items.Add("");
            ButtonStateChanges();
        }

        //取得按鈕的狀態
        private void ButtonStateChanges()
        {
            btnOpen.Enabled = (sqlConnection1.State == ConnectionState.Closed);
            btnClose.Enabled = (sqlConnection1.State == ConnectionState.Open);
        }

        //SqlConnection物件的狀態說明
        private void ConnectionStateDescription(ConnectionState MyState)
        {
            switch (MyState)
            {
                case ConnectionState.Broken:
                    //16
                    listBox1.Items.Add("中斷");
                    break;
                case ConnectionState.Closed:
                    //0
                    listBox1.Items.Add("關閉");
                    break;
                case ConnectionState.Connecting:
                    //2
                    listBox1.Items.Add("正在連接到資料源");
                    break;
                case ConnectionState.Executing:
                    //4
                    listBox1.Items.Add("正在執行命令");
                    break;
                case ConnectionState.Fetching:
                    //8
                    listBox1.Items.Add("正在從資料來源讀取資料出來");
                    break;
                case ConnectionState.Open:
                    //1
                    listBox1.Items.Add("開啟");
                    break;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            sqlConnection1.Close();
        }

    }
}
