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

namespace _07_02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void deliveryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.deliveryBindingSource.EndEdit();
            if (!xINDataSet.HasChanges())
            {
                MessageBox.Show("沒有異動的記錄必須更新.", "無異動記錄", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string strProductID;
            int intQty;
            TransactionScope tsMyTransactionScope = new TransactionScope();
            using (tsMyTransactionScope)
            {
                //取得DeliveryDetails刪除的記錄
                xINDataSet.DeliveryDetailsDataTable DeleteDeliveryDetails =
                         (xINDataSet.DeliveryDetailsDataTable)
                         xINDataSet.DeliveryDetails.GetChanges(DataRowState.Deleted);
                //取得DeliveryDetails新增的記錄
                xINDataSet.DeliveryDetailsDataTable NewDeliveryDetails =
                         (xINDataSet.DeliveryDetailsDataTable)
                         (xINDataSet.DeliveryDetails.GetChanges(DataRowState.Added));
                //取得DeliveryDetails修改的記錄
                xINDataSet.DeliveryDetailsDataTable ModifyDeliveryDetails =
                         (xINDataSet.DeliveryDetailsDataTable)
                         (xINDataSet.DeliveryDetails.GetChanges(DataRowState.Modified));

                try
                {
                    //刪除出貨單明細資料表
                    if (DeleteDeliveryDetails != null)
                    {
                        foreach (DataRow dr in DeleteDeliveryDetails.Rows)
                        {
                            strProductID = Convert.ToString(dr["ProductID", 
                                DataRowVersion.Original]);
                            intQty = Convert.ToInt32(dr["Quantity", 
                                DataRowVersion.Original]);
                            UpdateStock(strProductID, intQty * -1);
                        }
                    }

                    //新增出貨單明細資料表
                    if (NewDeliveryDetails != null)
                    {
                        foreach (DataRow dr in NewDeliveryDetails.Rows)
                        {
                            strProductID = Convert.ToString(dr["ProductID", 
                                DataRowVersion.Current]);
                            intQty = Convert.ToInt32(dr["Quantity", 
                                DataRowVersion.Current]);
                            UpdateStock(strProductID, intQty);
                        }
                    }

                    //修改出貨單明細資料表
                    if (ModifyDeliveryDetails != null)
                    {
                        foreach (DataRow dr in ModifyDeliveryDetails.Rows)
                        {
                            strProductID = Convert.ToString(dr["ProductID", 
                                DataRowVersion.Original]);
                            intQty = Convert.ToInt32(dr["Quantity", 
                                DataRowVersion.Original]);
                            UpdateStock(strProductID, intQty * -1);
                            strProductID = Convert.ToString(dr["ProductID", 
                                DataRowVersion.Current]);
                            intQty = Convert.ToInt32(dr["Quantity", 
                                DataRowVersion.Current]);
                            UpdateStock(strProductID, intQty);
                        }
                    }
                    this.tableAdapterManager.UpdateAll(this.xINDataSet);
                    tsMyTransactionScope.Complete();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    if (DeleteDeliveryDetails != null)
                    {
                        DeleteDeliveryDetails.Dispose();
                    }
                    if (NewDeliveryDetails != null)
                    {
                        NewDeliveryDetails.Dispose();
                    }
                    if (ModifyDeliveryDetails != null)
                    {
                        ModifyDeliveryDetails.Dispose();
                    }
                }
            }
        }

        //更新庫存量
        private void UpdateStock(string strProductID, int intQty)
        {
            int intRowIndex;
            intRowIndex = productBindingSource.Find("ProductID", strProductID);
            DataRow dr;
            dr = xINDataSet.Product.Rows[intRowIndex];
            dr.BeginEdit();
            dr["Stock"] = (int)dr["Stock"] + intQty;
            dr.EndEdit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'xINDataSet.Product' 資料表。您可以視需要進行移動或移除。
            this.productTableAdapter.Fill(this.xINDataSet.Product);
            // TODO: 這行程式碼會將資料載入 'xINDataSet.DeliveryDetails' 資料表。您可以視需要進行移動或移除。
            this.taDetails.Fill(this.xINDataSet.DeliveryDetails);
            // TODO: 這行程式碼會將資料載入 'xINDataSet.Delivery' 資料表。您可以視需要進行移動或移除。
            this.taDelivery.Fill(this.xINDataSet.Delivery);
        }

        private void dgvDetails_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //認可父資料表的記錄
            deliveryBindingSource.EndEdit();
        }

        private void txtCustomerID_Validated(object sender, EventArgs e)
        {
            //依客戶編號帶出客戶名稱
            companyNameTextBox.Text = taDelivery.GetCompanyName(txtCustomerID.Text);
        }

        private void dgvDetails_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            //依商品編號帶出商品名稱
            if (dgvDetails.Columns[e.ColumnIndex].Name == "colProductID")
            {
                //如果商品編號是空值,就將商品名稱清成空白
                if (DBNull.Value.Equals(dgvDetails.Rows[e.RowIndex].Cells[
                                     "colProductID"].Value))
                {
                    dgvDetails.Rows[e.RowIndex].Cells["colProductName"].Value = "";
                }
                else
                {
                    dgvDetails.Rows[e.RowIndex].Cells["colProductName"].Value =
                           taDetails.GetProductName(Convert.ToString(
                           dgvDetails.Rows[e.RowIndex].Cells["colProductID"].Value));
                }
            }
        }
    }
}
