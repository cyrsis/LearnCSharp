using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnSQL.StateChange += new StateChangeEventHandler(cnSQL_StateChange);
            WindowsControlsEnableChanges();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string DataSource, Database, UserID, Password;
            bool SSPI;
            //取得專案屬性設定的值
            DataSource = Properties.Settings.Default.DataSource;
            Database = Properties.Settings.Default.Database;
            UserID = Properties.Settings.Default.UserID;
            Password = Properties.Settings.Default.Password;
            SSPI = Properties.Settings.Default.SSPI;
            txtServerName.Text = DataSource;
            txtDatabaseName.Text = Database;
            txtUserID.Text = UserID;
            txtPassword.Text = Password;
            if (SSPI)
            {
                txtSSPI.Text = "Y";
            }
            else
            {
                txtSSPI.Text = "N";
            }
            //填入連接字串
            cnSQL.ConnectionString = "Data Source=" + DataSource + ";" +
                                     "Initial Catalog=" + Database + ";";
            if (SSPI)
            {
                cnSQL.ConnectionString = cnSQL.ConnectionString + 
                                         "Integrated Security=SSPI;";
            }
            else
            {
                cnSQL.ConnectionString = cnSQL.ConnectionString +
                                         "Integrated Security=False;" + 
                                         "User ID=" + UserID + ";" + 
                                         "Password=" + Password + ";";
            }
            cnSQL.Open();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cnSQL.Close();
        }

        //設定Windows控制項的狀態
        private void WindowsControlsEnableChanges()
        {
            btnOpen.Enabled = (cnSQL.State == ConnectionState.Closed);
            btnClose.Enabled = (cnSQL.State == ConnectionState.Open);
        }

        void cnSQL_StateChange(object sender, StateChangeEventArgs e)
        {
            textBox1.Text = textBox1.Text + "Connection原來的狀態:";
            ConnectionStateDescription(e.OriginalState);

            textBox1.Text = textBox1.Text + "Connection目前的狀態:";
            ConnectionStateDescription(e.CurrentState);

            WindowsControlsEnableChanges();
        }

        //SqlConnection物件的狀態說明
        private void ConnectionStateDescription(ConnectionState MyState)
        {
            switch (MyState)
            {
                case ConnectionState.Broken:
                    //16
                    textBox1.Text = textBox1.Text + "中斷\r\n";
                    break;
                case ConnectionState.Closed:
                    //0
                    textBox1.Text = textBox1.Text + "關閉\r\n";
                    break;
                case ConnectionState.Connecting:
                    //2
                    textBox1.Text = textBox1.Text + "正在連接到資料源\r\n";
                    break;
                case ConnectionState.Executing:
                    //4
                    textBox1.Text = textBox1.Text + "正在執行命令\r\n";
                    break;
                case ConnectionState.Fetching:
                    //8
                    textBox1.Text = textBox1.Text + "正在從資料來源讀取資料出來\r\n";
                    break;
                case ConnectionState.Open:
                    //1
                    textBox1.Text = textBox1.Text + "開啟\r\n";
                    break;
            }
        }
    }
}
