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
using Microsoft.VisualBasic;

namespace _04_02_02
{
    public partial class Form1 : Form
    {

        //定義與建立連線物件
        SqlConnection cnXIN = new SqlConnection();
        string strConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnXIN.StateChange += new StateChangeEventHandler(cnXIN_StateChange);
            ButtonStateChanges();
        }

        //SqlConnection物件的StateChange事件
        private void cnXIN_StateChange(Object sender, StateChangeEventArgs e)
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
            btnOpen.Enabled = (cnXIN.State == ConnectionState.Closed);
            btnClose.Enabled = (cnXIN.State == ConnectionState.Open);
            btnChangePassword.Enabled = (cnXIN.State == ConnectionState.Open);
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
            strConnectionString =
                "Data Source=BENNY-VAIO;" +
                "Initial Catalog=XIN;" +
                "User ID=" + textUserID.Text + ";" +
                "Password=" + textPassword.Text + ";";
            cnXIN.ConnectionString = strConnectionString;
            cnXIN.Open();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cnXIN.Close();
        }

        //變更密碼
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            String NewPassword;
            NewPassword = ChangeUserPassword();
            if (NewPassword != "")
            {
                try
                {
                    SqlConnection.ChangePassword(strConnectionString, NewPassword);
                    MessageBox.Show("密碼變更成功!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //輸入新的密碼
        private String ChangeUserPassword()
        {
            if (textNewPassword.Text != textConfirmPassword.Text)
            {
                MessageBox.Show("新密碼與確認密碼不相符, 密碼設定失效!");
                textNewPassword.Text = "";
            }
            return (textNewPassword.Text);
        }
    }
}
