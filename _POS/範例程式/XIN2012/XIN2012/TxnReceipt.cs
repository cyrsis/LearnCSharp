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
    public partial class fmTxnReceipt : XIN2012.fmBase
    {

        XINEntities context;
        XINFunction XIN = new XINFunction();
        //記錄目前是否有進入DataGridView
        bool blnEnterGrid;
        //記錄刪除的進貨別
        string DeleteReceiptType;
       
        public fmTxnReceipt()
        {
            InitializeComponent();
        }

        private void fmTxnReceipt_Load(object sender, EventArgs e)
        {
            context = new XINEntities();
            //建立context的SavingChanges事件
            context.SavingChanges += new EventHandler(this.context_SavingChanges);
            //建立明細BindingSource的PositionChanged事件
            receiptDetailsBindingSource.PositionChanged += new EventHandler(
                this.receiptDetailsBindingSource_PositionChanged);
            //指定BindingSource物件
            BS = receiptBindingSource;
            //指定主索引鍵的欄位名稱
            IDFieldName = "ReceiptID";
            //指定主索引鍵的資料表名稱
            TableName = "Receipt";
            string NewID;
            //取得主索引鍵最大值的LINQ to Entities
            NewID = (from M in context.Receipt
                     orderby M.ReceiptID descending 
                     select M.ReceiptID).FirstOrDefault();
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
            var qry = from M in context.Receipt
                      where M.ReceiptID == PrimaryID
                      select M;
            //將BindingSource物件繫結至資料來源
            receiptBindingSource.DataSource = qry;
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
                receiptBindingSource.EndEdit();
                //更新廠商的最近進貨日
                if (receiptTypeTextBox.Text == "1")
                {
                    var Supplier = (from S in context.Supplier
                                    where S.SupplierID == supplierIDTextBox.Text
                                    select S).FirstOrDefault();
                    if (Supplier != null)
                    {
                        Supplier.LastReceiptDate = 
                            Convert.ToDateTime(receiptDateTextBox.Text);
                    }
                }
                //更新資料
                context.SaveChanges();
                PrimaryID = receiptIDLabel.Text;
            }
            catch (Exception ex)
            {
                //回復交易
                db.Rollback();
                MessageBox.Show(ex.Message, "更新錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message,"內部錯誤訊息",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //變更DataGridView控制項的虛擬模式
                receiptDetailsDataGridView.VirtualMode = true;
                return false;
            }
            //確認交易
            db.Commit();
            return true;
        }

        public override void SetControls()
        {
            receiptDateTextBox.ReadOnly = (TBStatus == 0);
            supplierIDTextBox.ReadOnly = (TBStatus == 0);
            receiptTypeTextBox.ReadOnly = (TBStatus != 1);
            shipAddressTextBox.ReadOnly = (TBStatus == 0);
            invoiceNoTextBox.ReadOnly = (TBStatus == 0);
            commentTextBox.ReadOnly = (TBStatus == 0);
            btnQrySupplier.Enabled = (TBStatus != 0);
            receiptDetailsDataGridView.ReadOnly = (TBStatus == 0);
            receiptDetailsDataGridView.AllowUserToAddRows = (TBStatus != 0);
            receiptDetailsDataGridView.AllowUserToDeleteRows = (TBStatus != 0);
            colReceiptSeq.ReadOnly = true;
            colProductName.ReadOnly = true;
            colUnit.ReadOnly = true;
            colAmount.ReadOnly = true;
            colSEQ.ReadOnly = true;
            colReceiptSeq.Visible = (TBStatus == 1);
            colSEQ.Visible = (TBStatus != 1);
        }

        public override void AfterAddNew()
        {
            supplierIDTextBox.Focus();            
            //變更DataGridView控制項的虛擬模式
            receiptDetailsDataGridView.VirtualMode = true;
        }

        public override void SetDefaultValue()
        {
            receiptIDLabel.Text = "新進貨單";
            receiptDateTextBox.Text = DateTime.Today.ToShortDateString();
            receiptTypeTextBox.Text = "1";
            supplierIDTextBox.Text = "";
            shipAddressTextBox.Text = "";
            subTotalTextBox.Text = "0";
            subTotalLabel.Text = "0";
            valueAddTaxTextBox.Text = "0";
            valueAddTaxLabel.Text = "0";
            amountTextBox.Text = "0";
            amountLabel.Text = "0";
            attribNameLabel.Text = "";
            receiptBindingSource.EndEdit();
        }

        public override bool BeforeCancelEdit()
        {
            //取消編輯前，明細要先取消
            //receiptDetailsDataGridView.CancelEdit();
//            receiptDetailsBindingSource.CancelEdit();
            return true;
        }

        public override void AfterCancelEdit()
        {
            context.Refresh(RefreshMode.StoreWins, 
                            context.Receipt.First(p => p.ReceiptID == PrimaryID));
            context.Refresh(RefreshMode.StoreWins, 
                            context.ReceiptDetails.Where(p => p.ReceiptID == PrimaryID));
            //取得所有新增的進貨單明細
            foreach (var AddedEntry in context.ObjectStateManager
                                       .GetObjectStateEntries(EntityState.Added))
            {
                if (!AddedEntry.IsRelationship)
                {
                    if (AddedEntry.Entity is ReceiptDetails)
                    {
                        var curr = ((ReceiptDetails)(AddedEntry.Entity));
                        receiptDetailsBindingSource.Remove(curr);
                    }
                }
            }
            //取消後
            if (receiptIDLabel.Text == String.Empty)
            {
                //取消後若無記錄，廠商簡稱、進貨金額、5%營業稅與總計金額清空
                attribNameLabel.Text = "";
                subTotalTextBox.Text = "";
                valueAddTaxTextBox.Text = "";
                amountTextBox.Text = "";
            }
            else
            {
                //取消後若有記錄，取得目前廠商的：
                //廠商簡稱、進貨金額、5%營業稅與總計金額
                //廠商簡稱
                attribNameLabel.Text = XIN.GetSupplierAttribName(
                                                        supplierIDTextBox.Text);
                ////進貨金額
                subTotalTextBox.Text = ((Receipt)(receiptBindingSource.Current))
                                                 .SubTotal.ToString("#,##0");
                //營業稅
                valueAddTaxTextBox.Text = ((Receipt)(receiptBindingSource.Current))
                                                    .ValueAddTax.ToString("#,##0");
                //總計金額
                amountTextBox.Text = ((Receipt)(receiptBindingSource.Current))
                                               .Amount.ToString("#,##0");
            }
            //變更DataGridView控制項的虛擬模式
            receiptDetailsDataGridView.VirtualMode = false;
        }

        public override void AfterLoad()
        {
            //廠商簡稱
            attribNameLabel.Text = XIN.GetSupplierAttribName(supplierIDTextBox.Text);
            //沒進貨記錄，離開
            if (receiptBindingSource.Current == null)
            {
                return;
            }
            //進貨金額    
            subTotalTextBox.Text = ((Receipt)(receiptBindingSource.Current))
                                             .SubTotal.ToString("#,##0");
            //營業稅  
            valueAddTaxTextBox.Text = ((Receipt)(receiptBindingSource.Current))
                                                 .ValueAddTax.ToString("#,##0");
            //總計金額  
            amountTextBox.Text = ((Receipt)(receiptBindingSource.Current))
                                           .Amount.ToString("#,##0");
        }

        private void CalcTotals()
        {
            //用來計算總進貨金額的變數
            int iSubTotal = 0;
            int I;
            DataGridView Grid = receiptDetailsDataGridView;
            for (I = 0; I <= (Grid.Rows.Count - 1); I++)
            {
                if (Grid.Rows[I].Cells["colAmount"].Value != null)
                {
                    iSubTotal = iSubTotal + (int)Grid.Rows[I].Cells["colAmount"].Value;
                }
            }
            //進貨金額    
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
            //檢視是否有輸入進貨明細
            if (receiptDetailsBindingSource.Count == 0)
            {
                MessageBox.Show("無進貨明細資料，無法儲存！", "儲存錯誤", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //避免用戶偷跑
            DataGridView Grid = receiptDetailsDataGridView;
            for (int intRow = 0; intRow <= (Grid.Rows.Count - 2); intRow++)
            {
                if ((string)Grid.Rows[intRow].Cells["colProductID"].Value == null)
                {
                    MessageBox.Show(String.Format(
                        "第{0}筆進貨明細的商品編號必須要輸入。", 
                        Convert.ToString(intRow + 1)), "儲存錯誤", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            //新增模式產生進貨單號
            if (TBStatus == 1)
            {
                //找出指定資料表的第一筆記錄
                DateTime dt = Convert.ToDateTime(receiptDateTextBox.Text);
                var rec = (from M in context.Receipt
                           where M.ReceiptDate == dt
                           orderby M.ReceiptID descending
                           select M.ReceiptID).FirstOrDefault();
                if (rec == null)
                {
                    string tmpDate;
                    tmpDate = Convert.ToDateTime(
                                      receiptDateTextBox.Text).ToString("yy/MM/dd");
                    receiptIDLabel.Text = tmpDate.Substring(0, 2) +
                                  tmpDate.Substring(3, 2) +
                                  tmpDate.Substring(6, 2) + "001";
                }
                else
                {
                    string NewID, OriginalID;
                    OriginalID = rec;
                    NewID = Convert.ToString(
                                    Convert.ToInt16(OriginalID.Substring(6, 3)) + 1);
                    receiptIDLabel.Text = OriginalID.Substring(0, 6) + 
                                          NewID.PadLeft(3, '0');
                }
            }
            //檢查廠商編號是否有輸入
            if (supplierIDTextBox.Text == string.Empty)
            {
                MessageBox.Show("請輸入廠商編號！", "錯誤",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                supplierIDTextBox.Focus();
                return false;
            }
            //檢查廠商編號是否正確
            if (! XIN.CheckSupplierID(supplierIDTextBox.Text))
            {
                supplierIDTextBox.Focus();
                return false;
            }
            //變更DataGridView控制項的虛擬模式
            receiptDetailsDataGridView.VirtualMode = false;
            return true;
        }

        private void supplierIDTextBox_Validated(object sender, EventArgs e)
        {
            if (TBStatus == 0)
            {
                return;
            }
            if (supplierIDTextBox.Text == String.Empty)
            {
                //假如沒有輸入廠商編號，清空廠商簡稱但保留現有的進貨地址
                attribNameLabel.Text = "";
            }
            else
            {
                //取得廠商簡稱
                attribNameLabel.Text = XIN.GetSupplierAttribName(
                    supplierIDTextBox.Text);
                if (shipAddressTextBox.Text == String.Empty)
                {
                    //取得進貨地址
                    shipAddressTextBox.Text = XIN.GetSupplierAddress(
                        supplierIDTextBox.Text);
                }
            }
        }

        private void btnQrySupplier_Click(object sender, EventArgs e)
        {
            TListSupplierID SelectSupplierID = new TListSupplierID();
            supplierIDTextBox.Text = SelectSupplierID.SupplierID;
            supplierIDTextBox.Focus();
        }

        private void receiptTypeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if ((receiptTypeTextBox.Text != "1") && (receiptTypeTextBox.Text != "2"))
            {
                MessageBox.Show("進貨別必須為1(進貨)或2(進貨退出)。", "進貨別錯誤", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                receiptTypeTextBox.Text = "1";
                e.Cancel = true;
            }
        }

        private void receiptDetailsDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
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
            if ((receiptDetailsDataGridView.Rows.Count - iCounts) >= e.RowIndex)
            {
                DataGridView Grid = receiptDetailsDataGridView;
                //顯示項次-顯示用，與資料庫無關
                Grid.Rows[e.RowIndex].Cells[colSEQ.Index].Value = e.RowIndex + 1;
                ReceiptDetails rowDetails;
                //取得目前的ReceiptDetails
                rowDetails = (ReceiptDetails)receiptDetailsBindingSource[e.RowIndex];
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

        private void receiptDetailsDataGridView_CellValidating(object sender, 
            DataGridViewCellValidatingEventArgs e)
        {
            if (TBStatus == 0)
            {
                return;
            }
            DataGridView Grid = receiptDetailsDataGridView;
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

        private void receiptDetailsDataGridView_CellValidated(object sender,
            DataGridViewCellEventArgs e)
        {
            if (TBStatus == 0)
            {
                return;
            }
            DataGridView Grid = receiptDetailsDataGridView;
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
            }
        }

        private void receiptDetailsDataGridView_CellValueNeeded(object sender, 
            DataGridViewCellValueEventArgs e)
        {
            if (TBStatus == 0)
            {
                return;
            }
            DataGridView Grid = receiptDetailsDataGridView;
            if ((Grid.Columns[e.ColumnIndex].Name == "colProductName") ||
                (Grid.Columns[e.ColumnIndex].Name == "colUnit"))
            {
                string ProductID;
                //取得目前的商品編號
                ProductID = (string)Grid.Rows[e.RowIndex].Cells["colProductID"].Value;
                //取得目前的商品名
                if (Grid.Columns[e.ColumnIndex].Name == "colProductName")
                {
                    e.Value = XIN.GetProductName(ProductID);
                }
                if (Grid.Columns[e.ColumnIndex].Name == "colUnit")
                {
                    e.Value = XIN.GetUnit(ProductID);
                }
            }
        }

        private void receiptDetailsDataGridView_CellValueChanged(object sender, 
            DataGridViewCellEventArgs e)
        {
            if (TBStatus == 0)
            {
                return;
            }
            DataGridView Grid = receiptDetailsDataGridView;
            int iQty, iPrice, iAmount;
            iQty = 0;
            iPrice = 0;
            //數量被改變
            if (Grid.Columns[e.ColumnIndex].Name == "colQuantity")
            {
                //計算進貨明細每一筆的金額
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
                //計算進貨明細每一筆的金額
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
            if ((TBStatus == 2) && (Grid.Columns[e.ColumnIndex].Name == "colProductID"))
            {
                //商品編號被改變
                string ProductID;
                //取得目前的商品編號
                ProductID = (string)Grid.Rows[e.RowIndex].Cells["colProductID"].Value;
                //取得商品名稱
                Grid.Rows[e.RowIndex].Cells["colProductName"].Value = 
                    XIN.GetProductName(ProductID);
                //取得單位
                Grid.Rows[e.RowIndex].Cells["colUnit"].Value = XIN.GetUnit(ProductID);
            }
        }

        private void receiptDetailsDataGridView_DefaultValuesNeeded(object sender, 
            DataGridViewRowEventArgs e)
        {
            int R, iSEQ, iRecs;
            //取得目前的記錄筆數
            iRecs = receiptDetailsDataGridView.Rows.Count;
            e.Row.Cells["colSEQ"].Value = iRecs;
            receiptDetailsDataGridView.Update();
            //找出明細最大的項次
            iSEQ = 0;
            for (R = 1; R <= receiptDetailsDataGridView.Rows.Count - 1; R++)
            {
                if (receiptDetailsDataGridView.Rows[R - 1].Cells[
                    "colReceiptSeq"].Value != null)
                {
                    if (Convert.ToInt32(
                        receiptDetailsDataGridView.Rows[
                              R - 1].Cells["colReceiptSeq"].Value) >= iSEQ)
                    {
                        iSEQ = Convert.ToInt32(receiptDetailsDataGridView.Rows[
                                               R - 1].Cells["colReceiptSeq"].Value);
                    }
                }
            } 
            //項次
            e.Row.Cells["colReceiptSeq"].Value = iSEQ + 1;
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

        private void receiptDetailsDataGridView_UserDeletingRow(object sender, 
            DataGridViewRowCancelEventArgs e)
        {
            if (TBStatus == 0)
            {
                e.Cancel = true;
                return;
            }
            if (MessageBox.Show("要刪除本筆進貨明細？", "刪除", 
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void receiptDetailsDataGridView_RowsRemoved(object sender, 
            DataGridViewRowsRemovedEventArgs e)
        {
            //重排項次
            if (TBStatus == 1)
            {
                for (int I = 1; I <= receiptDetailsDataGridView.Rows.Count - 1; I++)
                {
                    receiptDetailsDataGridView.Rows[I - 1].Cells["colReceiptSeq"].Value = I;
                    receiptDetailsDataGridView.Rows[I - 1].Cells["colSEQ"].Value = I;
                }
            }
            if (TBStatus == 2)
            {
                for (int I = 1; I <= receiptDetailsDataGridView.Rows.Count - 1; I++)
                {
                    receiptDetailsDataGridView.Rows[I - 1].Cells["colSEQ"].Value = I;
                }
            }
        }

        private void receiptDetailsBindingSource_PositionChanged(
            Object sender, EventArgs e)
        {
            if (TBStatus != 0)
            {
                CalcTotals();
            }
        }

        private void receiptDetailsDataGridView_DataError(object sender, 
            DataGridViewDataErrorEventArgs e)
        {
            string Msg;
            Msg = "在進貨明細輸入了不合法的資料或發生錯誤：\r\n\r\n" +
                  "第" + Convert.ToString(e.ColumnIndex) + "個欄位\r\n" +
                  "第" + Convert.ToString(e.RowIndex + 1) + "筆記錄\r\n\r\n" +
                  "系統錯誤訊息:\r\n\r\n" +
                  Convert.ToString(e.Exception) + "\r\n\r\n" +
                 "請按Esc鍵來取消進貨單明細的編輯或輸入一個正確且合法的資料。";
            MessageBox.Show(Msg, "資料輸入錯誤", MessageBoxButtons.OK, 
                MessageBoxIcon.Exclamation);
        }

        private void receiptDetailsDataGridView_Enter(object sender, EventArgs e)
        {
            //設定DataGridView控制項目前具有焦點
            blnEnterGrid = true;
        }

        private void receiptDetailsDataGridView_Leave(object sender, EventArgs e)
        {
            //設定DataGridView控制項目前沒有焦點
            blnEnterGrid = false;
        }

        private void context_SavingChanges(Object sender, EventArgs e)
        {
            string NewProductID, OldProductID;
            int NewQuantity, OldQuantity;
            //取得所有新增的進貨單明細
            foreach (var AddedEntry in context.ObjectStateManager
                                       .GetObjectStateEntries(EntityState.Added))
            {
                if (!AddedEntry.IsRelationship)
                {
                    if (AddedEntry.Entity is ReceiptDetails)
                    {
                        NewProductID = ((ReceiptDetails)(AddedEntry.Entity)).ProductID;
                        //判斷進貨別
                        if (receiptTypeTextBox.Text == "1")
                        {
                            //進貨別=進貨，要更新庫存量與更新商品的最近進貨日
                            //更新庫存量
                            XIN.IncStock(context, NewProductID, 
                                ((ReceiptDetails)(AddedEntry.Entity)).Quantity);
                            //更新商品的最近進貨日
                            var qry = (from P in context.Product
                                       where P.ProductID == NewProductID
                                       select P).FirstOrDefault();
                            qry.LastReceiptDate = Convert.ToDateTime(
                                                           receiptDateTextBox.Text);
                        }
                        else
                        {
                            //進貨別=進貨退出，只要更新庫存量
                            XIN.DecStock(context, NewProductID, 
                                   ((ReceiptDetails)(AddedEntry.Entity)).Quantity);
                        }
                    }
                }
            }
            //取得所有修改的進貨單明細
            foreach (var ModifiedEntry in context.ObjectStateManager
                                          .GetObjectStateEntries(EntityState.Modified))
            {
                if (!ModifiedEntry.IsRelationship)
                {
                    if (ModifiedEntry.Entity is ReceiptDetails)
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
                        //判斷進貨別
                        if (receiptTypeTextBox.Text == "1")
                        {
                            //進貨別=進貨，要更新庫存量與更新商品的最近進貨日
                            //增加目前的商品編號的庫存量
                            XIN.IncStock(context, NewProductID, NewQuantity);
                            //減少原來的商品編號的庫存量
                            XIN.DecStock(context, OldProductID, OldQuantity);
                            //更新商品的最近進貨日
                            var qry = (from P in context.Product
                                       where P.ProductID == NewProductID
                                       select P).FirstOrDefault();
                            qry.LastReceiptDate = Convert.ToDateTime(
                                                          receiptDateTextBox.Text);
                        }
                        else
                        {
                            //進貨別=進貨退出，只要更新庫存量
                            //增加原來的商品編號的庫存量
                            XIN.IncStock(context, OldProductID, OldQuantity);
                            //減少目前的商品編號的庫存量
                            XIN.DecStock(context, NewProductID, NewQuantity);
                        }
                    }
                }
            }
            //取得所有刪除的進貨單明細
            foreach (var DeletedEntry in context.ObjectStateManager
                                          .GetObjectStateEntries(EntityState.Deleted))
            {
                if (!DeletedEntry.IsRelationship)
                {
                    if (DeletedEntry.Entity is ReceiptDetails)
                    {
                        OldProductID = ((ReceiptDetails)
                                         (DeletedEntry.Entity)).ProductID;                        
                        //判斷進貨別
                        if (DeleteReceiptType == "1")
                        {
                            //進貨別=進貨，要更新庫存量
                            //更新庫存量
                            XIN.DecStock(context, OldProductID, 
                                ((ReceiptDetails)(DeletedEntry.Entity)).Quantity);
                        }
                        else
                        {
                            //進貨別=進貨退出，只要更新庫存量
                            XIN.IncStock(context, OldProductID,
                                ((ReceiptDetails)(DeletedEntry.Entity)).Quantity);
                        }
                    }
                }
            }
        }

        public override bool BeforeDelete()
        {
            if (MessageBox.Show(string.Format(
                "刪除本筆進貨單？\r\n\r\n進貨單號：{0}", receiptIDLabel.Text),
                "刪除記錄", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return false;
            }
            //進行刪除記錄的程序
            DeleteReceiptType = receiptTypeTextBox.Text;
            DeleteID = receiptIDLabel.Text;
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
                //找出目前的進貨單記錄的物件
                var rowReceipt = (Receipt)(receiptBindingSource.Current);
                if (rowReceipt != null)
                {
                    //刪除進貨單明細記錄
                    if (rowReceipt.ReceiptDetails.Count != 0)
                    {
                        context.DeleteObject(rowReceipt.ReceiptDetails.First());
                    }
                    //刪除進貨單記錄
                    context.DeleteObject(rowReceipt);
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
            PrimaryID = receiptIDLabel.Text;
            //確認交易
            db.Commit();
            return true;
        }

        public override void DoPrint()
        {
            fmRptReceipt RptReceipt = new fmRptReceipt();
            RptReceipt.MdiParent = this.ParentForm;
            RptReceipt.ReceiptID = receiptIDLabel.Text;
            RptReceipt.Show();
        }
    }
}
