using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //新增命名空間 for SQL Server
using System.Collections;
using System.Data; //for DataTable

namespace FrmLogin
{
    class DBClsLogin
    {
        public string TableName = "Login";
        string errorMsg;
        string ConnString;

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        #region "資料庫初始化"

        //資料庫初始化
        public void InitDB()
        {


            ConnString = My.MyGlobal.SQLConnectionString;

            conn = new SqlConnection(ConnString);
            conn.Open();
        }

        #endregion


        #region "驗證帳號與密碼"

        /// <summary>
        /// 驗證帳號與密碼
        /// </summary>
        /// <param name="UserID">使用者帳號</param>
        /// <param name="Password">密碼</param>
        /// <returns></returns>
        public bool VerifyPWD(string UserID, string Password)
        {
            InitDB();
            string selectCmd;

            selectCmd = "Select * From " + TableName + " Where UserID='"
                + UserID + "' And Pwd='" + Password + "' And IsValid=1";
            //注意：欄位名稱不可為Password

            try
            {
                cmd = new SqlCommand(selectCmd, conn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                errorMsg = ex.Message;
                conn.Close();
                //throw new Exception(ex.Message.ToString());
                return false;
            }

        }

        #endregion
    }
}
