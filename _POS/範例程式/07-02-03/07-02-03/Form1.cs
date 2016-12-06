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

namespace _07_02_03
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
                XINDataSet.DeliveryDetailsDataTable DeleteDeliveryDetails =
                         (XINDataSet.DeliveryDetailsDataTable)
                         (xINDataSet.DeliveryDetails.GetChanges(DataRowState.Deleted));
                //取得DeliveryDetails新增的記錄
                XINDataSet.DeliveryDetailsDataTable NewDeliveryDetails =
                         (XINDataSet.DeliveryDetailsDataTable)
                         (xINDataSet.DeliveryDetails.GetChanges(DataRowState.Added));
                //取得DeliveryDetails修改的記錄
                XINDataSet.DeliveryDetailsDataTable ModifyDeliveryDetails =
                         (XINDataSet.DeliveryDetailsDataTable)
                         (xINDataSet.DeliveryDetails.GetChanges(DataRowState.Modified));

                //取得系統的連接字串做為新建連接物件的連接字串
                SqlConnection cnSQL = new SqlConnection(
                    Properties.Settings.Default.XINConnectionString);

                //指定每一個TableAdapter類別的Connection物件
                deliveryTableAdapter.Connection = cnSQL;
                deliveryDetailsTableAdapter.Connection = cnSQL;
                productTableAdapter.Connection = cnSQL;

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
                    //使用TableAdapter類別的Update()方法來更新異動的記錄
                    this.deliveryDetailsTableAdapter.Update(
                        this.xINDataSet.DeliveryDetails);
                    this.deliveryTableAdapter.Update(this.xINDataSet.Delivery);
                    this.productTableAdapter.Update(this.xINDataSet.Product);
                    //認可交易
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
            this.deliveryDetailsTableAdapter.Fill(this.xINDataSet.DeliveryDetails);
            // TODO: 這行程式碼會將資料載入 'xINDataSet.Delivery' 資料表。您可以視需要進行移動或移除。
            this.deliveryTableAdapter.Fill(this.xINDataSet.Delivery);
        }
    }
}
