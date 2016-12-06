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

namespace _05_07_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            //將文字方塊的SQL指令指向SqlCommand物件的CommandText屬性
            cmd.CommandText = txtSQL.Text;
            try
            {
                //比對字串是否有SELECT
                if (txtSQL.Text.StartsWith("SELECT", 
                                StringComparison.CurrentCultureIgnoreCase))
                {
                    //連接物件若是關閉的就開啟
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                    Int32 i;
                    String sRecs;
                    //建立SqlDaaReader物件
                    SqlDataReader dr;
                    //執行查詢的SQL敘述
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    listBox1.Items.Clear();
                    //逐筆取得結果
                    while (dr.Read())
                    {
                        sRecs = "";
                        for (i = 0; i <= dr.FieldCount - 1; i++)
                        {
                            sRecs = sRecs + Convert.ToString(dr.GetValue(i)) + "\t";
                        }
                        listBox1.Items.Add(sRecs);
                    }
                    //關閉SqlDaaReader物件
                    dr.Close();
                }
                else
                {
                    //連接物件若是關閉的就開啟
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                    cmd.ExecuteNonQuery();
                    //連接物件若是開啟的就關閉
                    if (cn.State == ConnectionState.Open)
                    {
                        cn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //SqlCommand的事件
        private void cmd_StatementCompleted(object sender, 
                                            StatementCompletedEventArgs e)
        {
            listBox1.Items.Add("----- 執行結束 -----");
            listBox1.Items.Add("共影響筆數:" + e.RecordCount.ToString());
        }
    }
}
