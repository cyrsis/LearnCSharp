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
using System.Transactions;

namespace _07_02_01
{
    public partial class Form1 : Form
    {

        //建立Transaction物件
        SqlTransaction trnXIN;

        public Form1()
        {
            InitializeComponent();
        }

        private void FillData()
        {
            //暫時關閉條件約束
            dsXIN1.EnforceConstraints = false;
            //載入資料
            daDelivery.Fill(dsXIN1, "Delivery");
            daDeliveryDetails.Fill(dsXIN1, "DeliveryDetails");
            //開啟條件約束
            dsXIN1.EnforceConstraints = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillData();
        }


        private void btnFill_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void deliveryDetailsDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            deliveryBindingSource.EndEdit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {           
            //終止目前所有的資料異動   
            //明細先儲存再儲存主檔
            deliveryDetailsBindingSource.EndEdit();
            deliveryBindingSource.EndEdit();
            if (!dsXIN1.HasChanges())
            {
                MessageBox.Show("沒有異動的記錄必須更新.", "無異動記錄", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            //** 1.指派Transaction物件初始值為Nothing
            trnXIN = null;
            try
            {
                //** 2. 開啟Connection物件
                cn.Open();
                //** 3. 初始化交易物件
                trnXIN = cn.BeginTransaction(System.Data.IsolationLevel.Serializable);
                //為SqlDataAdapter物件內的每個SqlCommand物件指派SqlTransaction物件
                daDelivery.InsertCommand.Transaction = trnXIN;
                daDelivery.UpdateCommand.Transaction = trnXIN;
                daDelivery.DeleteCommand.Transaction = trnXIN;
                daDeliveryDetails.InsertCommand.Transaction = trnXIN;
                daDeliveryDetails.UpdateCommand.Transaction = trnXIN;
                daDeliveryDetails.DeleteCommand.Transaction = trnXIN;
                //有刪除的資料嗎?
                if (dsXIN1.HasChanges(DataRowState.Deleted))
                {
                    //先更新明細檔再更新主檔
                    daDeliveryDetails.Update(dsXIN1, "DeliveryDetails");
                    daDelivery.Update(dsXIN1, "Delivery");
                }
                else
                {
                    //先更新主檔再更新明細檔
                    daDelivery.Update(dsXIN1, "Delivery");
                    daDeliveryDetails.Update(dsXIN1, "DeliveryDetails");
                }
                dsXIN1.AcceptChanges();
                //** 4.  確認交易
                trnXIN.Commit();
                MessageBox.Show("資料更新成功！", "07-02-01");
            }
            catch (Exception err)
            {
                //** 5. 回復交易
                trnXIN.Rollback();
                MessageBox.Show(err.Message, "資料更新發生錯誤！");
            }
            finally
            {
                //** 6.  關閉Connection物件
                cn.Close();
            }
        }

        //更新庫存量
        private void UpdateStock(string strProductID, int intQty)
        {
            //定義SqlCommand物件
            SqlCommand cmdSQL = new SqlCommand();
            cmdSQL.Connection = cn;
            //指派SqlTransaction物件
            cmdSQL.Transaction = trnXIN;
            cmdSQL.CommandText = "UPDATE Product SET Stock = Stock + @Stock " +
                                 "WHERE ProductID = @ProductID ";
            cmdSQL.Parameters.AddWithValue("ProductID", strProductID);
            cmdSQL.Parameters.AddWithValue("Stock", intQty);
            cmdSQL.ExecuteNonQuery();
        }

        private void daDeliveryDetails_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            int Qty;
            string ProductID;
            //刪除的記錄
            if (e.StatementType == StatementType.Delete)
            {
                Qty = Convert.ToInt32(e.Row["Quantity", DataRowVersion.Original]);
                ProductID = Convert.ToString(e.Row["ProductID", 
                                                   DataRowVersion.Original]);
                UpdateStock(ProductID, Qty);
            }
            //新增的記錄
            if (e.StatementType == StatementType.Insert)
            {
                Qty = Convert.ToInt32(e.Row["Quantity", DataRowVersion.Current]);
                ProductID = Convert.ToString(e.Row["ProductID", 
                                                   DataRowVersion.Current]);
                UpdateStock(ProductID, Qty * -1);
            }
            //修改的記錄
            if (e.StatementType == StatementType.Update)
            {
                Qty = Convert.ToInt32(e.Row["Quantity", DataRowVersion.Original]);
                ProductID = Convert.ToString(e.Row["ProductID", DataRowVersion.Original]);
                UpdateStock(ProductID, Qty);
                Qty = Convert.ToInt32(e.Row["Quantity", DataRowVersion.Current]);
                ProductID = Convert.ToString(e.Row["ProductID", 
                                                    DataRowVersion.Current]);
                UpdateStock(ProductID, Qty *-1);
            }
        }
    }
}
