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

namespace _06_02_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnFill_Click(sender, e);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dsXIN1.HasChanges())
            {
                if (MessageBox.Show("尚有未更新的記錄,仍要離開程式?", 
                                    "異動記錄未更新", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (dsXIN1.HasChanges())
            {
                if (MessageBox.Show("尚有未更新的記錄,仍要重新載入記錄?", 
                                    "異動記錄未更新", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            adapter.Fill(dsXIN1, "Customer");
        }

        private void AddTempleteCustomerID()
        {
            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.Connection = cn;
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            //新增一筆暫時性的客戶編號
            cmdSQL.CommandText = "INSERT INTO Customer " +
                                 "(CustomerID, CompanyName) " +
                                 "VALUES " +
                                 "('00000000', '臨時')";
            cmdSQL.ExecuteNonQuery();
        }

        private void DeleteTempleteCustomerID()
        {
            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.Connection = cn;
            //刪除暫時性客編
            cmdSQL.CommandText = "DELETE FROM Customer " +
                                 "WHERE CustomerID = '00000000' ";
            cmdSQL.ExecuteNonQuery();
        }

        //修改出貨的客戶編號
        private void ModifyDelivery(String NewCustomerID, String OldCustomerID)
        {
            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.Connection = cn;
            cmdSQL.CommandText = "UPDATE Delivery SET " + 
                                 "CustomerID = '" + NewCustomerID + "' " +
                                 "WHERE CustomerID = '" + OldCustomerID + "'";
            cmdSQL.ExecuteNonQuery();
        }

        private void DeletedDelivery(String CustomerID)
        {
            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.Connection = cn;
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            //刪除所有的出貨明細資料
            cmdSQL.CommandText = "DELETE FROM DeliveryDetails " +
                                 "WHERE DeliveryID IN " +
                                 "(SELECT DeliveryID FROM Delivery " +
                                 "WHERE CustomerID = '" + CustomerID + "')";
            cmdSQL.ExecuteNonQuery();
            //刪除客戶所有的出貨單
            cmdSQL.CommandText = "DELETE FROM Delivery " + 
                                 "WHERE CustomerID = '" + CustomerID + "'";
            cmdSQL.ExecuteNonQuery();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //查看是否有任何變更
            if ((!dsXIN1.HasChanges()) || (dsXIN1.HasErrors))
            {
                //如果沒有任何資料的異動, 或有錯誤, 就離開本程序
                return;
            }
            //
            String OldCustID, NewCustID;
            //先建立一個儲存異動資料的DataSet
            DataSet dsChanges;
            //建立待會要下SQL指令用的SqlCommand
            SqlCommand cmdSQL = new SqlCommand();
            //指定連線物件的Connection
            cmdSQL.Connection = cn;
            try
            {
                //更新資料-修改
                if (dsXIN1.HasChanges(DataRowState.Modified))
                {
                    //抓出修改的資料出來到dsChanges
                    dsChanges = dsXIN1.GetChanges(DataRowState.Modified);
                    //從dsChanges裡的每一列記錄一筆筆抓出來處理
                    foreach (DataRow drCustomer in dsChanges.Tables["Customer"].Rows)
                    {
                        //如果客戶編號修改前與修改後的不一樣
                        if (drCustomer["CustomerID", DataRowVersion.Original] != 
                            drCustomer["CustomerID", DataRowVersion.Current])
                        {
                            //原客戶編號
                            OldCustID = Convert.ToString(drCustomer["CustomerID", 
                                                         DataRowVersion.Original]);
                            //新客戶編號
                            NewCustID = Convert.ToString(drCustomer["CustomerID", 
                                                         DataRowVersion.Current]);
                            //新增一筆暫時性的客戶編號
                            AddTempleteCustomerID();
                            //將原客戶編號的出貨單之改為暫時客戶編號
                            ModifyDelivery("00000000", OldCustID);
                            //更新資料, 原客戶編號已修改
                            adapter.Update(dsChanges);
                            //再把暫時性客戶編號的出貨單改成新的客戶編號
                            ModifyDelivery(NewCustID, "00000000");
                            //刪除暫時性客編
                            DeleteTempleteCustomerID();
                        }
                        else
                        {
                            //修改更新
                            adapter.Update(dsChanges);
                        }
                    }
                }
                //更新資料-刪除
                if (dsXIN1.HasChanges(DataRowState.Deleted))
                {
                    //抓出刪除的資料出來到dsChanges
                    dsChanges = dsXIN1.GetChanges(DataRowState.Deleted);
                    //從dsTestChange裡的每一列記錄一筆筆抓出來處理
                    foreach (DataRow drCustomer in dsChanges.Tables["Customer"].Rows)
                    {
                        DeletedDelivery(Convert.ToString(drCustomer["CustomerID", 
                                                         DataRowVersion.Original]));
                    }
                    //更新資料, 客戶編號已刪除
                    adapter.Update(dsChanges);
                }
                //更新資料-新增
                if (dsXIN1.HasChanges(DataRowState.Added))
                {
                    //抓出新增的資料出來到dsChanges
                    dsChanges = dsXIN1.GetChanges(DataRowState.Added);
                    //更新資料, 客戶編號已新增改
                    adapter.Update(dsChanges);
                }
                dsXIN1.AcceptChanges();
            }
            catch (System.SystemException err)
            {
                //說明發生錯誤的原因
                MessageBox.Show(err.ToString());
                //取消所有的更新
                dsXIN1.RejectChanges();
            }
            finally
            {
                //無論如何,最後都要關閉SqlConnection
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
    }
}
