using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Data.Objects;
using System.Data.Common;

namespace XIN2012
{
    public partial class fmTxnDelivery : XIN2012.fmBase
    {

        XINEntities context;
        XINFunction XIN = new XINFunction();
        //記錄目前是否有進入DataGridView
        bool blnEnterGrid;
        //記錄刪除的出貨別
        string DeleteDeliveryType;        
        
        public fmTxnDelivery()
        {
            InitializeComponent();
        }

        private void fmTxnDelivery_Load(object sender, EventArgs e)
        {
            context = new XINEntities();
            //建立context的SavingChanges事件
            context.SavingChanges += new EventHandler(this.context_SavingChanges);
            //建立明細BindingSource的PositionChanged事件
            deliveryDetailsBindingSource.PositionChanged += new EventHandler(
                 this.deliveryDetailsBindingSource_PositionChanged);
            //指定BindingSource物件
            BS = deliveryBindingSource;
            //指定主索引鍵的欄位名稱
            IDFieldName = "DeliveryID";
            //指定主索引鍵的資料表名稱
            TableName = "Delivery";
            string NewID;
            //取得主索引鍵最大值的LINQ to Entities
            NewID = (from M in context.Delivery
                     orderby M.DeliveryID descending
                     select M.DeliveryID).FirstOrDefault();
            if (NewID != null)
            {
                PrimaryID = NewID;
            }
            else
            {
                PrimaryID = "";
            }
            //移至主索引鍵最大值的記錄
            FillData();
            //載入資料後要處理顯示的資料
            AfterLoad();
            //允許刪除
            AllowDelete = true;
            //提供列印的功能
            AllowPrint = true;
        }

        public override void FillData()
        {
            var qry = from M in context.Delivery
                      where M.DeliveryID == PrimaryID
                      select M;
            //將BindingSource物件繫結至資料來源
            deliveryBindingSource.DataSource = qry;
        }

        public override bool UpdateData()
        {
            //建立交易物件
            DbTransaction db;
            //如果ObjectContext類別的連接物件未開啟，就把它給開啟
            if (context.Connection.State != ConnectionState.Open)
            {
                context.Connection.Open();
            }
            //開啟交易
            db = context.Connection.BeginTransaction();
            try
            {
                this.Validate();
                //結束編輯
                deliveryBindingSource.EndEdit();
                //更新廠商的最近出貨日
                if (deliveryTypeTextBox.Text == "1")
                {
                    var Customer = (from R in context.Customer
                                    where R.CustomerID == customerIDTextBox.Text
                                    select R).FirstOrDefault();
                    if (Customer != null)
                    {
                        Customer.LastDeliveryDate =
                            Convert.ToDateTime(deliveryDateTextBox.Text);
                    }
                }
                //更新資料
                context.SaveChanges();
                PrimaryID = deliveryIDLabel.Text;
            }
            catch (Exception ex)
            {
                //回復交易
                db.Rollback();
                MessageBox.Show(ex.Message, "更新錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message, "內部錯誤訊息",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //變更DataGridView控制項的虛擬模式
                deliveryDetailsDataGridView.VirtualMode = true;
                return false;
            }
            //確認交易
            db.Commit();
            return true;
        }

        public override void SetControls()
        {
            deliveryDateTextBox.ReadOnly = (TBStatus == 0);
            customerIDTextBox.ReadOnly = (TBStatus == 0);
            joinManTextBox.ReadOnly = (TBStatus == 0);
            deliveryTypeTextBox.ReadOnly = (TBStatus != 1);
            shipAddressTextBox.ReadOnly = (TBStatus == 0);
            invoiceNoTextBox.ReadOnly = (TBStatus == 0);
            commentTextBox.ReadOnly = (TBStatus == 0);
            btnQryCustomer.Enabled = (TBStatus != 0);
            deliveryDetailsDataGridView.ReadOnly = (TBStatus == 0);
            deliveryDetailsDataGridView.AllowUserToAddRows = (TBStatus != 0);
            deliveryDetailsDataGridView.AllowUserToDeleteRows = (TBStatus != 0);
            colDeliverySeq.ReadOnly = true;
            colProductName.ReadOnly = true;
            colUnit.ReadOnly = true;
            colAmount.ReadOnly = true;
            colSEQ.ReadOnly = true;
            colDeliverySeq.Visible = (TBStatus == 1);
            colSEQ.Visible = (TBStatus != 1);
        }

        public override void AfterAddNew()
        {
            customerIDTextBox.Focus();
            //變更DataGridView控制項的虛擬模式
            deliveryDetailsDataGridView.VirtualMode = true;
        }

        public override void SetDefaultValue()
        {
            deliveryIDLabel.Text = "新出貨單";
            deliveryDateTextBox.Text = DateTime.Today.ToShortDateString();
            deliveryTypeTextBox.Text = "1";
            customerIDTextBox.Text = "";
            joinManTextBox.Text = "";
            shipAddressTextBox.Text = "";
            subTotalTextBox.Text = "0";
            subTotalLabel.Text = "0";
            valueAddTaxTextBox.Text = "0";
            valueAddTaxLabel.Text = "0";
            amountTextBox.Text = "0";
            amountLabel.Text = "0";
            attribNameLabel.Text = "";
            deliveryBindingSource.EndEdit();
        }

        public override bool BeforeCancelEdit()
        {
            //取消編輯前，明細要先取消
            deliveryDetailsDataGridView.CancelEdit();
            return true;
        }

        public override void AfterCancelEdit()
        {
            context.Refresh(RefreshMode.StoreWins,
                            context.Delivery.First(p => p.DeliveryID == PrimaryID));
            context.Refresh(RefreshMode.StoreWins,
                            context.DeliveryDetails.Where(p => p.DeliveryID == PrimaryID));
            //取得所有新增的出貨單明細
            foreach (var AddedEntry in context.ObjectStateManager
                                       .GetObjectStateEntries(EntityState.Added))
            {
                if (!AddedEntry.IsRelationship)
                {
                    if (AddedEntry.Entity is DeliveryDetails)
                    {
                        var curr = ((DeliveryDetails)(AddedEntry.Entity));
                        deliveryDetailsBindingSource.Remove(curr);
                    }
                }
            }
            //取消後
            if (deliveryIDLabel.Text == String.Empty)
            {
                //取消後若無記錄，客戶簡稱、銷售金額、營業稅與總計金額清空
                attribNameLabel.Text = "";
                subTotalTextBox.Text = "";
                valueAddTaxTextBox.Text = "";
                amountTextBox.Text = "";
            }
            else
            {
                //取消後若有記錄，取得目前客戶的：
                //客戶簡稱、銷售金額、營業稅與總計金額
                //客戶簡稱
                attribNameLabel.Text = XIN.GetCustomerAttribName(
                                                        customerIDTextBox.Text);
                //銷售金額
                subTotalTextBox.Text = ((Delivery)(deliveryBindingSource.Current))
                                                 .SubTotal.ToString("#,##0");
                //營業稅
                valueAddTaxTextBox.Text = ((Delivery)(deliveryBindingSource.Current))
                                                    .ValueAddTax.ToString("#,##0");
                //總計金額
                amountTextBox.Text = ((Delivery)(deliveryBindingSource.Current))
                                               .Amount.ToString("#,##0");
            }
            //變更DataGridView控制項的虛擬模式
            deliveryDetailsDataGridView.VirtualMode = false;
        }

        public override void AfterLoad()
        {
            //客戶簡稱
            attribNameLabel.Text = XIN.GetCustomerAttribName(customerIDTextBox.Text);
            //沒出貨記錄，離開
            if (deliveryBindingSource.Current == null)
            {
                return;
            }
            //銷售金額    
            subTotalTextBox.Text = ((Delivery)(deliveryBindingSource.Current))
                                             .SubTotal.ToString("#,##0");
            //營業稅  
            valueAddTaxTextBox.Text = ((Delivery)(deliveryBindingSource.Current))
                                                 .ValueAddTax.ToString("#,##0");
            //總計金額  
            amountTextBox.Text = ((Delivery)(deliveryBindingSource.Current))
                                           .Amount.ToString("#,##0");
        }

        private void CalcTotals()
        {
            //用來計算總出貨金額的變數
            int iSubTotal = 0;
            int I;
            DataGridView Grid = deliveryDetailsDataGridView;
            for (I = 0; I <= (Grid.Rows.Count - 1); I++)
            {
                if (Grid.Rows[I].Cells["colAmount"].Value != null)
                {
                    iSubTotal = iSubTotal + (int)Grid.Rows[I].Cells["colAmount"].Value;
                }
            }
            //銷售金額    
            subTotalTextBox.Text = iSubTotal.ToString("#,##0");
            subTotalLabel.Text = iSubTotal.ToString("#,##0");
            //營業稅  
            valueAddTaxTextBox.Text = (iSubTotal * 0.05).ToString("#,##0");
            valueAddTaxLabel.Text = (iSubTotal * 0.05).ToString("#,##0");
            //總計金額  
            amountTextBox.Text = (iSubTotal + iSubTotal * 0.05).ToString("#,##0");
            amountLabel.Text = (iSubTotal + iSubTotal * 0.05).ToString("#,##0");
        }

        public override bool BeforeEndEdit()
        {
            //儲存前，再計算一次總金額
            CalcTotals();
            //檢視是否有輸入出貨明細
            if (deliveryDetailsBindingSource.Count == 0)
            {
                MessageBox.Show("無出貨明細資料，無法儲存！", "儲存錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //避免用戶偷跑
            DataGridView Grid = deliveryDetailsDataGridView;
            for (int intRow = 0; intRow <= (Grid.Rows.Count - 2); intRow++)
            {
                if ((string)Grid.Rows[intRow].Cells["colProductID"].Value == null)
                {
                    MessageBox.Show(String.Format(
                        "第{0}筆出貨明細的商品編號必須要輸入。",
                        Convert.ToString(intRow + 1)), "儲存錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            //新增模式產生出貨單號
            if (TBStatus == 1)
            {
                //找出指定資料表的第一筆記錄
                DateTime dt = Convert.ToDateTime(deliveryDateTextBox.Text);
                var rec = (from M in context.Delivery
                           where M.DeliveryDate == dt
                           orderby M.DeliveryID descending
                           select M.DeliveryID).FirstOrDefault();
                if (rec == null)
                {
                    string tmpDate;
                    tmpDate = Convert.ToDateTime(
                                      deliveryDateTextBox.Text).ToString("yy/MM/dd");
                    deliveryIDLabel.Text = tmpDate.Substring(0, 2) +
                                  tmpDate.Substring(3, 2) +
                                  tmpDate.Substring(6, 2) + "001";
                }
                else
                {
                    string NewID, OriginalID;
                    OriginalID = rec;
                    NewID = Convert.ToString(
                                    Convert.ToInt16(OriginalID.Substring(6, 3)) + 1);
                    deliveryIDLabel.Text = OriginalID.Substring(0, 6) +
                                          NewID.PadLeft(3, '0');
                }
            }
            //檢查客戶編號是否有輸入
            if (customerIDTextBox.Text == string.Empty)
            {
                MessageBox.Show("請輸入客戶編號！", "錯誤",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                customerIDTextBox.Focus();
                return false;
            }
            //檢查客戶編號是否正確
            if (!XIN.CheckCustomerID(customerIDTextBox.Text))
            {
                customerIDTextBox.Focus();
                return false;
            }
            //變更DataGridView控制項的虛擬模式
            deliveryDetailsDataGridView.VirtualMode = false;
            return true;
        }

        private void customerIDTextBox_Validated(object sender, EventArgs e)
        {
            if (TBStatus == 0)
            {
                return;
            }
            if (customerIDTextBox.Text == String.Empty)
            {
                //假如沒有輸入客戶編號，清空客戶簡稱與聯路人但保留現有的出貨地址
                attribNameLabel.Text = "";
                joinManTextBox.Text = "";
            }
            else
            {
                //取得客戶簡稱
                attribNameLabel.Text = XIN.GetCustomerAttribName(
                    customerIDTextBox.Text);
                //取得聯路人
                joinManTextBox.Text = XIN.GetCustomerJoinMan(customerIDTextBox.Text);
                if (shipAddressTextBox.Text == String.Empty)
                {
                    //取得出貨地址
                    shipAddressTextBox.Text = XIN.GetCustomerAddress(
                        customerIDTextBox.Text);
                }
            }
        }

        private void btnQryCustomer_Click(object sender, EventArgs e)
        {
            TListCustomerID SelectCustomerID = new TListCustomerID();
            customerIDTextBox.Text = SelectCustomerID.CustomerID;
            customerIDTextBox.Focus();
        }

        private void deliveryTypeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if ((deliveryTypeTextBox.Text != "1") && (deliveryTypeTextBox.Text != "2"))
            {
                MessageBox.Show("出貨別必須為1(出貨)或2(出貨退回)。", "出貨別錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                deliveryTypeTextBox.Text = "1";
                e.Cancel = true;
            }
        }

        private void deliveryDetailsDataGridView_RowPrePaint(object sender, 
            DataGridViewRowPrePaintEventArgs e)
        {
            int iCounts;
            if (TBStatus == 0)
            {
                iCounts = 1;
            }
            else
            {
                iCounts = 2;
            }
            if ((deliveryDetailsDataGridView.Rows.Count - iCounts) >= e.RowIndex)
            {
                DataGridView Grid = deliveryDetailsDataGridView;
                //顯示項次-顯示用，與資料庫無關
                Grid.Rows[e.RowIndex].Cells[colSEQ.Index].Value = e.RowIndex + 1;
                DeliveryDetails rowDetails;
                //取得目前的DeliveryDetails
                rowDetails = (DeliveryDetails)deliveryDetailsBindingSource[e.RowIndex];
                if (rowDetails.Product != null)
                {
                    //商品名稱
                    Grid.Rows[e.RowIndex].Cells[colProductName.Index].Value =
                                          rowDetails.Product.ProductName;
                    //單位
                    Grid.Rows[e.RowIndex].Cells[colUnit.Index].Value =
                                          rowDetails.Product.Unit;
                }
            }
        }

        private void deliveryDetailsDataGridView_CellValidating(object sender, 
            DataGridViewCellValidatingEventArgs e)
        {
            if (TBStatus == 0)
            {
                return;
            }
            DataGridView Grid = deliveryDetailsDataGridView;
            if (Grid.Columns[e.ColumnIndex].Name == "colProductID")
            {
                string strProductID;
                strProductID = e.FormattedValue.ToString();
                //判斷是否有輸入商品編號
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    //沒有輸入商品編號，帶出商品編號挑選視窗
                    //檢查目前DataGridView控制項是不是還具有焦點
                    if (blnEnterGrid)
                    {
                        TListProductID SelectProductID = new TListProductID();
                        strProductID = SelectProductID.ProductID;
                        //取得所挑選的商品編號
                        Grid.Rows[e.RowIndex].Cells["colProductID"].Value = strProductID;
                        Grid.Rows[e.RowIndex].Cells["colProductID"].Selected = true;
                    }
                }
                //檢查商品編號是否輸入正確
                if (XIN.CheckProductID(strProductID))
                {
                    e.Cancel = false;
                }
                else
                {
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

        private void deliveryDetailsDataGridView_CellValueNeeded(object sender, 
            DataGridViewCellValueEventArgs e)
        {
            if (TBStatus == 0)
            {
                return;
            }
            DataGridView Grid = deliveryDetailsDataGridView;
            if ((Grid.Columns[e.ColumnIndex].Name == "colProductName") ||
                (Grid.Columns[e.ColumnIndex].Name == "colUnit"))
            {
                string ProductID;
                //取得目前的商品編號
                ProductID = (string)Grid.Rows[e.RowIndex].Cells["colProductID"].Value;
                //取得目前的商品名稱
                if (Grid.Columns[e.ColumnIndex].Name == "colProductName")
                {
                    e.Value = XIN.GetProductName(ProductID);
                }
                //取得目前的商品單位
                if (Grid.Columns[e.ColumnIndex].Name == "colUnit")
                {
                    e.Value = XIN.GetUnit(ProductID);
                }
            }
        }

        private void deliveryDetailsDataGridView_CellValidated(object sender,
            DataGridViewCellEventArgs e)
        {
            if (TBStatus == 0)
            {
                return;
            }
            DataGridView Grid = deliveryDetailsDataGridView;
            if (Grid.Columns[e.ColumnIndex].Name != "colProductID")
            {
                return;
            }
            string ProductID;
            ProductID = Convert.ToString(Grid.Rows[e.RowIndex]
                                             .Cells["colProductID"].Value);
            if (ProductID == String.Empty)
            {
                //沒輸入商品編號，清空商品名稱與單位
                Grid.Rows[e.RowIndex].Cells["colProductName"].Value = "";
                Grid.Rows[e.RowIndex].Cells["colUnit"].Value = "";
            }
            else
            {
                //取得商品名稱
                Grid.Rows[e.RowIndex].Cells["colProductName"].Value =
                    XIN.GetProductName(ProductID);
                //取得單位
                Grid.Rows[e.RowIndex].Cells["colUnit"].Value = XIN.GetUnit(ProductID);
                //取得目前商品的建議售價
                Grid.Rows[e.RowIndex].Cells["colUnitPrice"].Value = 
                                      XIN.GetPrice(ProductID);
            }
        }

        private void deliveryDetailsDataGridView_CellValueChanged(object sender, 
            DataGridViewCellEventArgs e)
        {
            if (TBStatus == 0)
            {
                return;
            }
            DataGridView Grid = deliveryDetailsDataGridView;
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

        private void deliveryDetailsDataGridView_DefaultValuesNeeded(object sender, 
            DataGridViewRowEventArgs e)
        {
            int R, iSEQ, iRecs;
            //取得目前的記錄筆數
            iRecs = deliveryDetailsDataGridView.Rows.Count;
            e.Row.Cells["colSEQ"].Value = iRecs;
            deliveryDetailsDataGridView.Update();
            //找出明細最大的項次
            iSEQ = 0;
            for (R = 1; R <= deliveryDetailsDataGridView.Rows.Count - 1; R++)
            {
                if (deliveryDetailsDataGridView.Rows[R - 1].Cells[
                    "colDeliverySeq"].Value != null)
                {
                    if (Convert.ToInt32(
                        deliveryDetailsDataGridView.Rows[
                              R - 1].Cells["colDeliverySeq"].Value) >= iSEQ)
                    {
                        iSEQ = Convert.ToInt32(deliveryDetailsDataGridView.Rows[
                                               R - 1].Cells["colDeliverySeq"].Value);
                    }
                }
            }
            //項次
            e.Row.Cells["colDeliverySeq"].Value = iSEQ + 1;
            //數量
            //e.Row.Cells["colQuantity"].Value = 1;
            e.Row.Cells["colQuantity"].Value = 0;
            //單價
            e.Row.Cells["colUnitPrice"].Value = 0;
            //金額
            e.Row.Cells["colAmount"].Value = 0;
            for (int I = 0; I <= 6; I++)
            {
                e.Row.Cells[I].Selected = false;
            }
            //讓商品編號欄位擁有焦點
            e.Row.Cells["colProductID"].Selected = true;
        }

        private void deliveryDetailsDataGridView_UserDeletingRow(object sender, 
            DataGridViewRowCancelEventArgs e)
        {
            if (TBStatus == 0)
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

        private void deliveryDetailsDataGridView_RowsRemoved(object sender, 
            DataGridViewRowsRemovedEventArgs e)
        {
            //重排項次
            if (TBStatus == 1)
            {
                for (int I = 1; I <= deliveryDetailsDataGridView.Rows.Count - 1; I++)
                {
                    deliveryDetailsDataGridView.Rows[I - 1]
                                               .Cells["colDeliverySeq"].Value = I;
                    deliveryDetailsDataGridView.Rows[I - 1].Cells["colSEQ"].Value = I;
                }
            }
            if (TBStatus == 2)
            {
                for (int I = 1; I <= deliveryDetailsDataGridView.Rows.Count - 1; I++)
                {
                    deliveryDetailsDataGridView.Rows[I - 1].Cells["colSEQ"].Value = I;
                }
            }
        }

        private void deliveryDetailsBindingSource_PositionChanged(
            Object sender, EventArgs e)
        {
            if (TBStatus != 0)
            {
                CalcTotals();
            }
        }

        private void deliveryDetailsDataGridView_DataError(object sender, 
            DataGridViewDataErrorEventArgs e)
        {
            string Msg;
            Msg = "在出貨明細輸入了不合法的資料或發生錯誤：\r\n\r\n" +
                  "第" + Convert.ToString(e.ColumnIndex) + "個欄位\r\n" +
                  "第" + Convert.ToString(e.RowIndex + 1) + "筆記錄\r\n\r\n" +
                  "系統錯誤訊息:\r\n\r\n" +
                  Convert.ToString(e.Exception) + "\r\n\r\n" +
                 "請按Esc鍵來取消出貨單明細的編輯或輸入一個正確且合法的資料。";
            MessageBox.Show(Msg, "資料輸入錯誤", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        private void deliveryDetailsDataGridView_Enter(object sender, EventArgs e)
        {
            //設定DataGridView控制項目前具有焦點
            blnEnterGrid = true;
        }

        private void deliveryDetailsDataGridView_Leave(object sender, EventArgs e)
        {
            //設定DataGridView控制項目前沒有焦點
            blnEnterGrid = false;
        }

        private void context_SavingChanges(Object sender, EventArgs e)
        {
            string NewProductID, OldProductID;
            int NewQuantity, OldQuantity;
            //取得所有新增的出貨單明細
            foreach (var AddedEntry in context.ObjectStateManager
                                       .GetObjectStateEntries(EntityState.Added))
            {
                if (!AddedEntry.IsRelationship)
                {
                    if (AddedEntry.Entity is DeliveryDetails)
                    {
                        NewProductID = ((DeliveryDetails)(AddedEntry.Entity)).ProductID;
                        //判斷出貨別
                        if (deliveryTypeTextBox.Text == "1")
                        {
                            //出貨別=出貨，要更新庫存量與更新商品的最近出貨日
                            //更新庫存量
                            XIN.DecStock(context, NewProductID,
                                ((DeliveryDetails)(AddedEntry.Entity)).Quantity);
                            //更新商品的最近出貨日
                            var qry = (from P in context.Product
                                       where P.ProductID == NewProductID
                                       select P).FirstOrDefault();
                            qry.LastDeliveryDate = Convert.ToDateTime(
                                                           deliveryDateTextBox.Text);
                        }
                        else
                        {
                            //出貨別=出貨退回，只要更新庫存量
                            XIN.IncStock(context, NewProductID,
                                   ((DeliveryDetails)(AddedEntry.Entity)).Quantity);
                        }
                    }
                }
            }
            //取得所有修改的出貨單明細
            foreach (var ModifiedEntry in context.ObjectStateManager
                                          .GetObjectStateEntries(EntityState.Modified))
            {
                if (!ModifiedEntry.IsRelationship)
                {
                    if (ModifiedEntry.Entity is DeliveryDetails)
                    {
                        //取得目前的商品編號與數量
                        CurrentValueRecord curr = ModifiedEntry.CurrentValues;
                        NewProductID = (string)(curr.GetValue(
                                                curr.GetOrdinal("ProductID")));
                        NewQuantity = (int)
                                      (curr.GetValue(curr.GetOrdinal("Quantity")));
                        //取得原來的商品編號與數量
                        OriginalValueRecord org =
                                        ModifiedEntry.GetUpdatableOriginalValues();
                        OldProductID = (string)
                                       (org.GetValue(curr.GetOrdinal("ProductID")));
                        OldQuantity = (int)(org.GetValue(curr.GetOrdinal("Quantity")));
                        //判斷出貨別
                        if (deliveryTypeTextBox.Text == "1")
                        {
                            //出貨別=出貨，要更新庫存量與更新商品的最近出貨日
                            //增加原來的商品編號的庫存量
                            XIN.IncStock(context, OldProductID, OldQuantity);
                            //減少目前的商品編號的庫存量
                            XIN.DecStock(context, NewProductID, NewQuantity);
                            //更新商品的最近出貨日
                            var qry = (from P in context.Product
                                       where P.ProductID == NewProductID
                                       select P).FirstOrDefault();
                            qry.LastDeliveryDate = Convert.ToDateTime(
                                                          deliveryDateTextBox.Text);
                        }
                        else
                        {
                            //出貨別=出貨退回，只要更新庫存量
                            //增加目前的商品編號的庫存量
                            XIN.IncStock(context, NewProductID, NewQuantity);
                            //減少原來的商品編號的庫存量
                            XIN.DecStock(context, OldProductID, OldQuantity);
                        }
                    }
                }
            }
            //取得所有刪除的出貨單明細
            foreach (var DeletedEntry in context.ObjectStateManager
                                          .GetObjectStateEntries(EntityState.Deleted))
            {
                if (!DeletedEntry.IsRelationship)
                {
                    if (DeletedEntry.Entity is DeliveryDetails)
                    {
                        OldProductID = ((DeliveryDetails)
                                         (DeletedEntry.Entity)).ProductID;
                        //判斷出貨別
                        if (DeleteDeliveryType == "1")
                        {
                            //出貨別=出貨，要更新庫存量
                            //更新庫存量
                            XIN.IncStock(context, OldProductID,
                                ((DeliveryDetails)(DeletedEntry.Entity)).Quantity);
                        }
                        else
                        {
                            //出貨別=出貨退回，只要更新庫存量
                            XIN.DecStock(context, OldProductID,
                                ((DeliveryDetails)(DeletedEntry.Entity)).Quantity);
                        }
                    }
                }
            }
        }

        public override bool BeforeDelete()
        {
            if (MessageBox.Show(string.Format(
                "刪除本筆出貨單？\r\n\r\n出貨單號：{0}", deliveryIDLabel.Text),
                "刪除記錄", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return false;
            }
            //進行刪除記錄的程序
            DeleteDeliveryType = deliveryTypeTextBox.Text;
            DeleteID = deliveryIDLabel.Text;
            return true;
        }

        public override bool DeleteData()
        {
            //建立交易物件
            DbTransaction db;
            //如果ObjectContext類別的連接物件未開啟，就把它給開啟
            if (context.Connection.State != ConnectionState.Open)
            {
                context.Connection.Open();
            }
            //開啟交易
            db = context.Connection.BeginTransaction();
            try
            {
                //找出目前的出貨單記錄的物件
                var rowDelivery = (Delivery)(deliveryBindingSource.Current);
                if (rowDelivery != null)
                {
                    //刪除出貨單明細記錄
                    if (rowDelivery.DeliveryDetails.Count != 0)
                    {
                        context.DeleteObject(rowDelivery.DeliveryDetails.First());
                    }
                    //刪除出貨單記錄
                    context.DeleteObject(rowDelivery);
                    //更新資料
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //回復交易
                db.Rollback();
                //秀出錯誤訊息
                MessageBox.Show(ex.Message, "刪除錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            PrimaryID = deliveryIDLabel.Text;
            //確認交易
            db.Commit();
            return true;
        }

        public override void DoPrint()
        {
            fmRptDelivery RptDelivery = new fmRptDelivery();
            RptDelivery.MdiParent = this.ParentForm;
            RptDelivery.DeliveryID = deliveryIDLabel.Text;
            RptDelivery.Show();
        }
    }
}
