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
using System.IO;

namespace _05_03_02
{
    public partial class Form1 : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        String strCn;      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Data Source=localhost;" +
                                  "Initial Catalog=XIN;" +
                                  "Integrated Security=SSPI";
            cmd.Connection = cn;
            cmd.CommandText = "SELECT ProductID FROM Product ";
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            comboBox1.SelectedIndex = 0;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //建立SqlDataReader
            SqlDataReader dr;
            //BOLB資料用BinaryWriter型態來存放
            BinaryWriter writer;
            //設定緩衝區的大小
            int bufferSize = 100;
            //設定接收讀取的檔案大小
            Byte[] outByte = new Byte[bufferSize];
            //GetBytes()傳回的值是Long型態
            long retval;
            //讀取BLOB檔案的開始位置
            long startIndex = 0;
            //取得商品名稱
            cmd.CommandText = "SELECT ProductName " +
                              "FROM Product " +
                              "WHERE ProductID = '" + comboBox1.Text + "'";
            //開啟SqlConnection
            cn.Open();
            dr = cmd.ExecuteReader(CommandBehavior.SingleRow);
            if (dr.Read())
            {
                txtProductName.Text = dr.GetString(0);
            }
            if (!dr.IsClosed)
            {
                dr.Close();
            }
            //取得圖片的SQL敘述
            cmd.CommandText = "SELECT Picture " +
                              "FROM Product " +
                              "WHERE ProductID = '" + comboBox1.Text + "'";
            dr = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
            pictureBox1.Image = null;
            if (dr.Read())
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    writer = new BinaryWriter(stream);
                    //將讀取起始位置歸0
                    startIndex = 0;
                    //讀出資料
                    retval = dr.GetBytes(0, startIndex, outByte, 0, bufferSize);
                    //繼續讀出資料到讀完為止 (讀出位元組<緩衝區就是讀完了)
                    while (retval == bufferSize)
                    {
                        //寫入接收的位元組陣列
                        writer.Write(outByte);
                        //確認寫入
                        writer.Flush();
                        //變更起始位置
                        startIndex += bufferSize;
                        //繼續讀出資料
                        retval = dr.GetBytes(0, startIndex, outByte, 0, bufferSize);
                    }
                    //寫入接收的位元組陣列
                    writer.Write(outByte);
                    //確認寫入
                    writer.Flush();
                    //在PictureBox1控制項顯示圖形
                    pictureBox1.Image = Image.FromStream(stream);
                }
                //關閉BinaryWriter
                writer.Close();
            }
            //關閉SqlDataReader
            dr.Close();
            //關閉SqlConnection
            cn.Close();
        }
    }
}
