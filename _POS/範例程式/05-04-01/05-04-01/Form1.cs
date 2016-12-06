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

namespace _05_04_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //清空欄位的內容
            txtCustomerID.Text = "";
            txtCompanyName.Text = "";
            txtJoinMan.Text = "";
            txtTel1.Text = "";
            txtFax.Text = "";
            txtCompanyAddress.Text = "";

            int I, intFieldCount;

            if (comboBox1.SelectedIndex == 0)
            {
                //依客戶編號來查詢, 使用@CustomerID的SqlParameter
                sqlCommand1.Parameters["@CustomerID"].Value = txtValue.Text;
                sqlCommand1.Parameters["@CompanyName"].Value = "";
            }
            else
            {
                //依公司名稱來查詢, 使用@CompanyName的SqlParameter
                sqlCommand1.Parameters["@CustomerID"].Value = "";
                sqlCommand1.Parameters["@CompanyName"].Value = txtValue.Text;
            }
            //開啟連接
            sqlConnection1.Open();
            //建立SqlDataReaader物件
            SqlDataReader rdCustomer;
            //ExecuteReader會傳回一個DataReader, 把它丟給rdCustomer
            rdCustomer = sqlCommand1.ExecuteReader(CommandBehavior.SingleRow);
            //read = True, 代表有資料
            if (rdCustomer.Read())
            {
                //取得SqlDataReader欄位數目
                intFieldCount = rdCustomer.FieldCount;
                //逐欄位取得資料
                for (I = 0; I <= intFieldCount - 1; I++)
                {
                    //判斷欄位是否為空值
                    if (!rdCustomer.IsDBNull(I))
                    {
                        //取得欄位的名稱並顯示在適當的控制項
                        if (rdCustomer.GetName(I) == "CustomerID")
                        {
                            txtCustomerID.Text = rdCustomer.GetString(I);
                        }
                        else if (rdCustomer.GetName(I) == "CompanyName")
                        {
                            txtCompanyName.Text = rdCustomer.GetString(I);
                        }
                        else if (rdCustomer.GetName(I) == "JoinMan")
                        {
                            txtJoinMan.Text = rdCustomer.GetString(I);
                        }
                        else if (rdCustomer.GetName(I) == "Tel1")
                        {
                            txtTel1.Text = rdCustomer.GetString(I);
                        }
                        else if (rdCustomer.GetName(I) == "Fax")
                        {
                            txtFax.Text = rdCustomer.GetString(I);
                        }
                        else if (rdCustomer.GetName(I) == "CompanyAddress")
                        {
                            txtCompanyAddress.Text = rdCustomer.GetString(I);
                        }
                    }
                }
            }
            else
            {
                //read = False, 表示無資料可讀取
                MessageBox.Show("找不到指定條件的客戶記錄!", 
                                "查詢", MessageBoxButtons.OK);
            }
            //閉SqlDataReader
            rdCustomer.Close();
            //關閉連接
            sqlConnection1.Close();
        }
    }
}
