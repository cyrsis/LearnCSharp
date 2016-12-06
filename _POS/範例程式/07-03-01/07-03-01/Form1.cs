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

namespace _07_03_01
{
    public partial class Form1 : Form
    {

        //記錄現在的操作模式  0:瀏覽 1:新增  2:修改
        int tbStatus = 0;
        //記錄刪除的出貨單的出貨別
        string DeliveryType;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //載入商品資料表
            this.productTableAdapter.Fill(this.xINDataSet.Product);
            //載入客戶資料表
            this.customerTableAdapter.Fill(this.xINDataSet.Customer);
            //載入出貨單資料表
            this.deliveryTableAdapter.Fill(this.xINDataSet.Delivery);
            //載入出貨單明細資料表
            this.deliveryDetailsTableAdapter.Fill(this.xINDataSet.DeliveryDetails);
            //設定控制項的ReadOnly屬性與按鈕的Enabled屬性
            SetControl();
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

        private void SetControl()
        {
            btnFirst.Enabled = (tbStatus == 0);
            btnPrevious.Enabled = (tbStatus == 0);
            btnNext.Enabled = (tbStatus == 0);
            btnLast.Enabled = (tbStatus == 0);
            btnAdd.Enabled = (tbStatus == 0);
            btnEdit.Enabled = (tbStatus == 0);
            btnDelete.Enabled = (tbStatus == 0);
            btnSave.Enabled = (tbStatus != 0);
            btnCancel.Enabled = (tbStatus != 0);
            deliveryDateTextBox.ReadOnly = (tbStatus != 1);
            deliveryTypeTextBox.ReadOnly = (tbStatus != 1);
            companyNameComboBox.Visible = (tbStatus != 0);
            companyNameTextBox.Visible = (tbStatus == 0);
            joinManTextBox.ReadOnly = (tbStatus == 0);
            shipAddressTextBox.ReadOnly = (tbStatus == 0);
            invoiceNoTextBox.ReadOnly = (tbStatus == 0);
            commentTextBox.ReadOnly = (tbStatus == 0);
            dgvDetails.ReadOnly = (tbStatus == 0);
            colDeliverySeq.ReadOnly = true;
            colAmount.ReadOnly = true;
        }

        private void CalcTotals()
        {
            //用來計算總出貨金額的變數
            int iSubTotal = 0;
            int I;
            for (I = 0; I <= (dgvDetails.Rows.Count - 1); I++)
            {
                if (dgvDetails.Rows[I].Cells["colAmount"].Value != null)
                {
                    iSubTotal = iSubTotal + (int)dgvDetails.Rows[I].Cells["colAmount"].Value;
                }
            }
            //銷售金額    
            subTotalTextBox.Text = iSubTotal.ToString("#,##0");
            //營業稅  
            valueAddTaxTextBox.Text = (iSubTotal * 0.05).ToString("#,##0");
            //總計金額  
            amountTextBox.Text = (iSubTotal + iSubTotal * 0.05).ToString("#,##0");
        }

        private void GetDeliveryID()
        {
            //新增出貨單要給單號
            string NewID, MaxID, tmpDate;
            DateTime dt = Convert.ToDateTime(deliveryDateTextBox.Text);
            tmpDate = Convert.ToDateTime(
                              deliveryDateTextBox.Text).ToString("yy/MM/dd");
            MaxID = deliveryTableAdapter.GetMaxDeliveryID(dt);
            if (MaxID == null)
            {
                deliveryIDTextBox.Text = tmpDate.Substring(0, 2) +
                              tmpDate.Substring(3, 2) +
                              tmpDate.Substring(6, 2) + "001";
            }
            else
            {
                NewID = Convert.ToString(
                                    Convert.ToInt16(MaxID.Substring(6, 3)) + 1);
                deliveryIDTextBox.Text = MaxID.Substring(0, 6) + NewID.PadLeft(3, '0');
            }
        }

        private void deliveryDateTextBox_Validated(object sender, EventArgs e)
        {           
            if (dgvDetails.RowCount == 0)
            {
                GetDeliveryID();
            }
        }

        private void companyNameComboBox_Validated(object sender, EventArgs e)
        {
            companyNameTextBox.Text = companyNameComboBox.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //新增出貨單給予預設值
            deliveryDateTextBox.Text = DateTime.Today.ToShortDateString();
            GetDeliveryID();
            deliveryTypeTextBox.Text = "1";
            joinManTextBox.Text = "";
            shipAddressTextBox.Text = "";
            subTotalTextBox.Text = "0";
            valueAddTaxTextBox.Text = "0";
            amountTextBox.Text = "0";
            //新增模式
            tbStatus = 1;
            SetControl();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //修改
            tbStatus = 2;
            SetControl();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CalcTotals();
            this.Validate();
            this.deliveryBindingSource.EndEdit();
            this.deliveryDetailsBindingSource.EndEdit();
            string strProductID;
            int intQty;
            string DeliveryType = deliveryTypeTextBox.Text;
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
                            if (DeliveryType == "1")
                            {
                                UpdateStock(strProductID, intQty);
                            }
                            else
                            {
                                UpdateStock(strProductID, intQty * -1);
                            }
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
                            UpdateStock(strProductID, intQty * -1);
                            if (DeliveryType == "1")
                            {
                                UpdateStock(strProductID, intQty * -1);
                            }
                            else
                            {
                                UpdateStock(strProductID, intQty);
                            }
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
                            if (DeliveryType == "1")
                            {
                                UpdateStock(strProductID, intQty);
                            }
                            else
                            {
                                UpdateStock(strProductID, intQty * -1);
                            }
                            strProductID = Convert.ToString(dr["ProductID",
                                DataRowVersion.Current]);
                            intQty = Convert.ToInt32(dr["Quantity",
                                DataRowVersion.Current]);
                            if (DeliveryType == "1")
                            {
                                UpdateStock(strProductID, intQty * -1);
                            }
                            else
                            {
                                UpdateStock(strProductID, intQty);
                            }
                        }
                    }
                    //使用TableAdapter類別的Update()方法來更新異動的記錄
                    this.productTableAdapter.Update(this.xINDataSet.Product);
                    if (tbStatus == 1)
                    {
                        //先更新出貨單資料表
                        this.deliveryTableAdapter.Update(this.xINDataSet.Delivery);
                        //再更新出貨單明細資料表
                        this.deliveryDetailsTableAdapter.Update(
                            this.xINDataSet.DeliveryDetails);
                    }
                    else
                    {
                        //再更新出貨單明細資料表
                        this.deliveryDetailsTableAdapter.Update(
                            this.xINDataSet.DeliveryDetails);
                        //先更新出貨單資料表
                        this.deliveryTableAdapter.Update(this.xINDataSet.Delivery);
                    }
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
                //存檔完成，變回瀏覽模式
                tbStatus = 0;
                SetControl();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeliveryType = deliveryTypeTextBox.Text;
            deliveryBindingSource.RemoveCurrent();
            this.Validate();
            this.deliveryBindingSource.EndEdit();
            string strProductID;
            int intQty;
            TransactionScope tsMyTransactionScope = new TransactionScope();
            using (tsMyTransactionScope)
            {
                //取得DeliveryDetails刪除的記錄
                XINDataSet.DeliveryDetailsDataTable DeleteDeliveryDetails =
                         (XINDataSet.DeliveryDetailsDataTable)
                         (xINDataSet.DeliveryDetails.GetChanges(DataRowState.Deleted));
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
                            if (DeliveryType == "1")
                            {
                                UpdateStock(strProductID, intQty);
                            }
                            else
                            {
                                UpdateStock(strProductID, intQty * -1);
                            }
                        }
                    }
                    //使用TableAdapter類別的Update()方法來更新異動的記錄
                    this.productTableAdapter.Update(this.xINDataSet.Product);
                    this.deliveryDetailsTableAdapter.Update(
                        this.xINDataSet.DeliveryDetails);
                    this.deliveryTableAdapter.Update(this.xINDataSet.Delivery);
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
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //放棄編輯
            deliveryDetailsBindingSource.CancelEdit();
            deliveryBindingSource.CancelEdit();
            //變回瀏覽模式
            tbStatus = 0;
            SetControl();
        }
        
        private void dgvDetails_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (tbStatus == 0)
            {
                return;
            }
            try
            {                
                deliveryBindingSource.EndEdit();
                deliveryDateTextBox.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤");            }            
        }

        private void dgvDetails_CellValidating(object sender, 
            DataGridViewCellValidatingEventArgs e)
        {
            if (tbStatus == 0)
            {
                return;
            }
            DataGridView Grid = dgvDetails;
            if (Grid.Columns[e.ColumnIndex].Name == "colProductID")
            {
                string strProductID;
                strProductID = e.FormattedValue.ToString();
                //判斷是否有輸入商品編號
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    MessageBox.Show("請輸入出貨商品！", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            int I = 0;
            //數量檢查
            if (Grid.Columns[e.ColumnIndex].Name == "colQuantity")
            {
                if ((!int.TryParse(e.FormattedValue.ToString(), out I)) || (I < 0))
                {
                    MessageBox.Show("數量必須大於0！", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            //單價檢查
            if (Grid.Columns[e.ColumnIndex].Name == "colUnitPrice")
            {
                if ((!int.TryParse(e.FormattedValue.ToString(), out I)) || (I < 0))
                {
                    MessageBox.Show("單價不可小於0！", "輸入錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
        }

        private void dgvDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (tbStatus == 0)
            {
                return;
            }
            DataGridView Grid = dgvDetails;
            int iQty, iPrice, iAmount;
            iQty = 0;
            iPrice = 0;
            //數量被改變
            if (Grid.Columns[e.ColumnIndex].Name == "colQuantity")
            {
                //計算出貨明細每一筆的金額
                if (Grid.Rows[e.RowIndex].Cells["colQuantity"].Value != null)
                {
                    iQty = (int)(Grid.Rows[e.RowIndex].Cells["colQuantity"].Value);
                }
                if (Grid.Rows[e.RowIndex].Cells["colUnitPrice"].Value != null)
                {
                    iPrice = (int)(Grid.Rows[e.RowIndex].Cells["colUnitPrice"].Value);
                }
                iAmount = iQty * iPrice;
                Grid.Rows[e.RowIndex].Cells["colAmount"].Value = (iAmount).ToString();
            }
            //單價被改變
            if (Grid.Columns[e.ColumnIndex].Name == "colUnitPrice")
            {
                //計算出貨明細每一筆的金額
                if (Grid.Rows[e.RowIndex].Cells["colQuantity"].Value != null)
                {
                    iQty = (int)(Grid.Rows[e.RowIndex].Cells["colQuantity"].Value);
                }
                if (Grid.Rows[e.RowIndex].Cells["colUnitPrice"].Value != null)
                {
                    iPrice = (int)(Grid.Rows[e.RowIndex].Cells["colUnitPrice"].Value);
                }
                iAmount = iQty * iPrice;
                Grid.Rows[e.RowIndex].Cells["colAmount"].Value = (iAmount).ToString();
            }
        }

        private void dgvDetails_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            //項次
            e.Row.Cells["colDeliverySeq"].Value = dgvDetails.Rows.Count;
            //數量
            e.Row.Cells["colQuantity"].Value = 1;
            //單價
            e.Row.Cells["colUnitPrice"].Value = 0;
            //金額
            e.Row.Cells["colAmount"].Value = 0;
            for (int I = 0; I <= 4; I++)
            {
                e.Row.Cells[I].Selected = false;
            }
            //讓商品編號欄位擁有焦點
            e.Row.Cells["colProductID"].Selected = true;
        }

        private void deliveryDetailsBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (tbStatus != 0)
            {
                CalcTotals();
            }
        }

        private void dgvDetails_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (tbStatus == 0)
            {
                e.Cancel = true;
                return;
            }
            if (MessageBox.Show("要刪除本筆出貨明細？", "刪除",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgvDetails_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int I = 1; I <= dgvDetails.Rows.Count - 1; I++)
            {
                dgvDetails.Rows[I - 1].Cells["colDeliverySeq"].Value = I;
            }
        }
    }
}
