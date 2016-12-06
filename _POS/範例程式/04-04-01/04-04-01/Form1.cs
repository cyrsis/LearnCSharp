using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_04_01
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

        //設定Windows控制項的狀態
        private void WindowsControlsEnableChanges()
        {
            btnOpen.Enabled = (cnSQL.State == ConnectionState.Closed);
            btnClose.Enabled = (cnSQL.State == ConnectionState.Open);
            txtDatabaseName.ReadOnly = (cnSQL.State == ConnectionState.Open);
            txtServerName.ReadOnly = (cnSQL.State == ConnectionState.Open);
            txtUserID.ReadOnly = (cnSQL.State == ConnectionState.Open);
            txtPassword.ReadOnly = (cnSQL.State == ConnectionState.Open);
            nudConnectionTimeout.ReadOnly = (cnSQL.State == ConnectionState.Open);
            chkSSPI.Enabled = (cnSQL.State == ConnectionState.Closed);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                cnSQL.ConnectionString = "Data Source=" + txtServerName.Text + ";" +
                                         "Initial Catalog=" + txtDatabaseName.Text + ";";
                if (chkSSPI.Checked)
                {
                    cnSQL.ConnectionString = cnSQL.ConnectionString + 
                                             "Integrated Security=SSPI;";
                }
                else
                {
                    cnSQL.ConnectionString = cnSQL.ConnectionString + 
                                             "Integrated Security=False;" +
                                             "User ID=" + txtUserID.Text + ";" + 
                                             "Password=" + txtPassword.Text + ";";
                }
                cnSQL.Open();
            }
            catch (System.Data.SqlClient.SqlException eErr)
            {
                String sErrMsg;
                foreach (System.Data.SqlClient.SqlError se in eErr.Errors)
                {
                    switch (se.Number)
                    {
                        case 17:
                            sErrMsg = "伺服器名稱錯誤";
                            break;
                        case 4060:
                            sErrMsg = "找不到資料庫";
                            break;
                        case 18452:
                            sErrMsg = "使用者登入失敗";
                            break;
                        case 18456:
                            sErrMsg = "錯誤的使用者名稱或密碼";
                            break;
                        default:
                            sErrMsg = "Message: " + se.Message;
                            break;
                    }
                    sErrMsg = sErrMsg + "\r\n" +
                          "Server: " + se.Server + "\r\n" +
                          "Source: " + se.Source + "\r\n" +
                          "Class: " + se.Class + "\r\n" +
                          "LineNumber:" + se.LineNumber + "\r\n" +
                          "Procedure: " + se.Procedure + "\r\n" +
                           "State: " + se.State;
                    MessageBox.Show(sErrMsg, "資料庫連線錯誤" + se.Number.ToString(), 
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = textBox1.Text + sErrMsg + "\r\n";
                }

            }
            catch (System.Exception eErr)
            {
                MessageBox.Show(eErr.Message, "不可預期的錯誤", 
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtUserID.Text = "";
                txtPassword.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cnSQL.Close();
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
