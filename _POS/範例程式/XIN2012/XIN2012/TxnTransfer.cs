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
    public partial class fmTxnTransfer : XIN2012.fmBase
    {

        XINEntities context;
        XINFunction XIN = new XINFunction();
        //記錄目前是否有進入DataGridView
        bool blnEnterGrid;
        //記錄刪除的異動別
        string DeleteTransferType;        

        public fmTxnTransfer()
        {
            InitializeComponent();
        }

        private void fmTxnTransfer_Load(object sender, EventArgs e)
        {
            context = new XINEntities();
            //建立context的SavingChanges事件
            context.SavingChanges += new EventHandler(this.context_SavingChanges);
            //建立明細BindingSource的PositionChanged事件
            transferDetailsBindingSource.PositionChanged += new EventHandler(
                 this.transferDetailsBindingSource_PositionChanged);
            //指定BindingSource物件
            BS = transferBindingSource;
            //指定主索引鍵的欄位名稱
            IDFieldName = "TransferID";
            //指定主索引鍵的資料表名稱
            TableName = "Transfer";
            string NewID;
            //取得主索引鍵最大值的LINQ to Entities
            NewID = (from M in context.Transfer
                     orderby M.TransferID descending
                     select M.TransferID).FirstOrDefault();
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
            var qry = from M in context.Transfer
                      where M.TransferID == PrimaryID
                       select M;
            //將BindingSource物件繫結至資料來源
            transferBindingSource.DataSource = qry;
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
                transferBindingSource.EndEdit();
                //更新資料
                context.SaveChanges();
                PrimaryID = transferIDLabel.Text;
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
                transferDetailsDataGridView.VirtualMode = true;
                return false;
            }
            //確認交易
            db.Commit();
            return true;
        }

        public override void SetControls()
        {
            transferDateTextBox.ReadOnly = (TBStatus == 0);
            descriptionTextBox.ReadOnly = (TBStatus == 0);
            transferTypeTextBox.ReadOnly = (TBStatus != 1);
            commentTextBox.ReadOnly = (TBStatus == 0);
            transferDetailsDataGridView.ReadOnly = (TBStatus == 0);
            transferDetailsDataGridView.AllowUserToAddRows = (TBStatus != 0);
            transferDetailsDataGridView.AllowUserToDeleteRows = (TBStatus != 0);
            colTransferSeq.ReadOnly = true;
            colProductName.ReadOnly = true;
            colUnit.ReadOnly = true;
            colSEQ.ReadOnly = true;
            colTransferSeq.Visible = (TBStatus == 1);
            colSEQ.Visible = (TBStatus != 1);
        }

        public override void AfterAddNew()
        {
            descriptionTextBox.Focus();
            //變更DataGridView控制項的虛擬模式
            transferDetailsDataGridView.VirtualMode = true;
        }

        public override void SetDefaultValue()
        {
            transferIDLabel.Text = "新異動單";
            transferDateTextBox.Text = DateTime.Today.ToShortDateString();
            transferTypeTextBox.Text = "1";
            descriptionTextBox.Text = "";
            amountTextBox.Text = "0";
            amountLabel.Text = "0";
            transferBindingSource.EndEdit();
        }

        public override bool BeforeCancelEdit()
        {
            //取消編輯前，明細要先取消
            transferDetailsDataGridView.CancelEdit();
            return true;
        }

        public override void AfterCancelEdit()
        {
            context.Refresh(RefreshMode.StoreWins,
                            context.Transfer.First(p => p.TransferID == PrimaryID));
            context.Refresh(RefreshMode.StoreWins,
                            context.TransferDetails.Where(p => p.TransferID == PrimaryID));
            //取得所有新增的存貨異動單明細
            foreach (var AddedEntry in context.ObjectStateManager
                                       .GetObjectStateEntries(EntityState.Added))
            {
                if (!AddedEntry.IsRelationship)
                {
                    if (AddedEntry.Entity is TransferDetails)
                    {
                        var curr = ((TransferDetails)(AddedEntry.Entity));
                        transferDetailsBindingSource.Remove(curr);
                    }
                }
            }
            //取消後
            if (transferIDLabel.Text == String.Empty)
            {
                //取消後若無記錄，總計金額清空
                amountTextBox.Text = "";
            }
            else
            {
                //取消後若有記錄，取得總計金額
                //總計金額
                amountTextBox.Text = ((Transfer)(transferBindingSource.Current))
                                               .Amount.ToString("#,##0");
            }
            //變更DataGridView控制項的虛擬模式
            transferDetailsDataGridView.VirtualMode = false;
        }

        public override void AfterLoad()
        {
            //沒出貨記錄，離開
            if (transferBindingSource.Current == null)
            {
                return;
            }
            //總計金額  
            amountTextBox.Text = ((Transfer)(transferBindingSource.Current))
                                           .Amount.ToString("#,##0");
        }

        private void CalcTotals()
        {
            //用來計算總計金額的變數
            int iAmount = 0;
            int I;
            DataGridView Grid = transferDetailsDataGridView;
            for (I = 0; I <= (Grid.Rows.Count - 1); I++)
            {
                if (Grid.Rows[I].Cells["colAmount"].Value != null)
                {
                    iAmount = iAmount + (int)Grid.Rows[I].Cells["colAmount"].Value;
                }
            }
            //總計金額  
            amountTextBox.Text = (iAmount).ToString("#,##0");
            amountLabel.Text = (iAmount).ToString("#,##0");
        }

        public override bool BeforeEndEdit()
        {
            //儲存前，再計算一次總金額
            CalcTotals();
            //檢視是否有輸入存貨異動明細
            if (transferBindingSource.Count == 0)
            {
                MessageBox.Show("無存貨異動明細資料，無法儲存！", "儲存錯誤",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //避免用戶偷跑
            DataGridView Grid = transferDetailsDataGridView;
            for (int intRow = 0; intRow <= (Grid.Rows.Count - 2); intRow++)
            {
                if ((string)Grid.Rows[intRow].Cells["colProductID"].Value == null)
                {
                    MessageBox.Show(String.Format(
                        "第{0}筆存貨異動明細的商品編號必須要輸入。",
                        Convert.ToString(intRow + 1)), "儲存錯誤",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            //新增模式產生存貨異動單號
            if (TBStatus == 1)
            {
                //找出指定資料表的第一筆記錄
                DateTime dt = Convert.ToDateTime(transferDateTextBox.Text);
                var rec = (from M in context.Transfer
                           where M.TransferDate == dt
                           orderby M.TransferID descending
                           select M.TransferID).FirstOrDefault();
                if (rec == null)
                {
                    string tmpDate;
                    tmpDate = Convert.ToDateTime(
                                      transferDateTextBox.Text).ToString("yy/MM/dd");
                    transferIDLabel.Text = tmpDate.Substring(0, 2) +
                                  tmpDate.Substring(3, 2) +
                                  tmpDate.Substring(6, 2) + "001";
                }
                else
                {
                    string NewID, OriginalID;
                    OriginalID = rec;
                    NewID = Convert.ToString(
                                    Convert.ToInt16(OriginalID.Substring(6, 3)) + 1);
                    transferIDLabel.Text = OriginalID.Substring(0, 6) +
                                          NewID.PadLeft(3, '0');
                }
            }
            //變更DataGridView控制項的虛擬模式
            transferDetailsDataGridView.VirtualMode = false;
            return true;
        }

        private void transferTypeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if ((transferTypeTextBox.Text != "1") && (transferTypeTextBox.Text != "2"))
            {
                MessageBox.Show("異動別必須為1(入庫)或2(出庫)。", "異動別錯誤",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                transferTypeTextBox.Text = "1";
                e.Cancel = true;
            }
        }

        private void transferDetailsDataGridView_RowPrePaint(object sender, 
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
            if ((transferDetailsDataGridView.Rows.Count - iCounts) >= e.RowIndex)
            {
                DataGridView Grid = transferDetailsDataGridView;
                //顯示項次-顯示用，與資料庫無關
                Grid.Rows[e.RowIndex].Cells[colSEQ.Index].Value = e.RowIndex + 1;
                TransferDetails rowDetails;
                //取得目前的DeliveryDetails
                rowDetails = (TransferDetails)transferDetailsBindingSource[e.RowIndex];
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

        private void transferDetailsDataGridView_CellValidating(object sender,
            DataGridViewCellValidatingEventArgs e)
        {
            if (TBStatus == 0)
            {
                return;
            }
            DataGridView Grid = transferDetailsDataGridView;
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
        }

        private void transferDetailsDataGridView_CellValidated(object sender, 
            DataGridViewCellEventArgs e)
        {
            if (TBStatus == 0)
            {
                return;
            }
            DataGridView Grid = transferDetailsDataGridView;
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

        private void transferDetailsDataGridView_CellValueNeeded(object sender, 
            DataGridViewCellValueEventArgs e)
        {
            if (TBStatus == 0)
            {
                return;
            }
            DataGridView Grid = transferDetailsDataGridView;
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

        private void transferDetailsDataGridView_CellValueChanged(object sender,
            DataGridViewCellEventArgs e)
        {
            if (TBStatus == 0)
            {
                return;
            }
            DataGridView Grid = transferDetailsDataGridView;
            //商品編號被改變
            if ((TBStatus == 2) && (Grid.Columns[e.ColumnIndex].Name == "colProductID"))
            {                
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

        private void transferDetailsDataGridView_DefaultValuesNeeded(object sender, 
            DataGridViewRowEventArgs e)
        {
            int R, iSEQ, iRecs;
            //取得目前的記錄筆數
            iRecs = transferDetailsDataGridView.Rows.Count;
            e.Row.Cells["colSEQ"].Value = iRecs;
            transferDetailsDataGridView.Update();
            //找出明細最大的項次
            iSEQ = 0;
            for (R = 1; R <= transferDetailsDataGridView.Rows.Count - 1; R++)
            {
                if (transferDetailsDataGridView.Rows[R - 1].Cells[
                    "colTransferSeq"].Value != null)
                {
                    if (Convert.ToInt32(
                        transferDetailsDataGridView.Rows[
                              R - 1].Cells["colTransferSeq"].Value) >= iSEQ)
                    {
                        iSEQ = Convert.ToInt32(transferDetailsDataGridView
                                      .Rows[R - 1].Cells["colTransferSeq"].Value);
                    }
                }
            }
            //項次
            e.Row.Cells["colTransferSeq"].Value = iSEQ + 1;
            //數量
            //e.Row.Cells["colQuantity"].Value = 1;
            e.Row.Cells["colQuantity"].Value = 0;
            //金額
            e.Row.Cells["colAmount"].Value = 0;
            for (int I = 0; I <= 6; I++)
            {
                e.Row.Cells[I].Selected = false;
            }
            //讓商品編號欄位擁有焦點
            e.Row.Cells["colProductID"].Selected = true;
        }

        private void transferDetailsDataGridView_UserDeletingRow(object sender, 
            DataGridViewRowCancelEventArgs e)
        {
            if (TBStatus == 0)
            {
                e.Cancel = true;
                return;
            }
            if (MessageBox.Show("要刪除本筆存貨異動明細？", "刪除",
                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void transferDetailsDataGridView_RowsRemoved(object sender, 
            DataGridViewRowsRemovedEventArgs e)
        {
            //重排項次
            if (TBStatus == 1)
            {
                for (int I = 1; I <= transferDetailsDataGridView.Rows.Count - 1; I++)
                {
                    transferDetailsDataGridView.Rows[I - 1]
                                               .Cells["colTransferSeq"].Value = I;
                    transferDetailsDataGridView.Rows[I - 1].Cells["colSEQ"].Value = I;
                }
            }
            if (TBStatus == 2)
            {
                for (int I = 1; I <= transferDetailsDataGridView.Rows.Count - 1; I++)
                {
                    transferDetailsDataGridView.Rows[I - 1].Cells["colSEQ"].Value = I;
                }
            }
        }

        private void transferDetailsBindingSource_PositionChanged(
            Object sender, EventArgs e)
        {
            if (TBStatus != 0)
            {
                CalcTotals();
            }
        }

        private void transferDetailsDataGridView_DataError(object sender, 
            DataGridViewDataErrorEventArgs e)
        {
            string Msg;
            Msg = "在存貨異動明細輸入了不合法的資料或發生錯誤：\r\n\r\n" +
                  "第" + Convert.ToString(e.ColumnIndex) + "個欄位\r\n" +
                  "第" + Convert.ToString(e.RowIndex + 1) + "筆記錄\r\n\r\n" +
                  "系統錯誤訊息:\r\n\r\n" +
                  Convert.ToString(e.Exception) + "\r\n\r\n" +
                 "請按Esc鍵來取消存貨異動單明細的編輯或輸入一個正確且合法的資料。";
            MessageBox.Show(Msg, "資料輸入錯誤", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        private void transferDetailsDataGridView_Enter(object sender, EventArgs e)
        {
            //設定DataGridView控制項目前具有焦點
            blnEnterGrid = true;
        }

        private void transferDetailsDataGridView_Leave(object sender, EventArgs e)
        {
            //設定DataGridView控制項目前沒有焦點
            blnEnterGrid = false;
        }

        private void context_SavingChanges(Object sender, EventArgs e)
        {
            string NewProductID, OldProductID;
            int NewQuantity, OldQuantity;
            //取得所有新增的存貨異動單明細
            foreach (var AddedEntry in context.ObjectStateManager
                                       .GetObjectStateEntries(EntityState.Added))
            {
                if (!AddedEntry.IsRelationship)
                {
                    if (AddedEntry.Entity is TransferDetails)
                    {
                        NewProductID = ((TransferDetails)(AddedEntry.Entity)).ProductID;
                        //判斷異動別
                        if (transferTypeTextBox.Text == "1")
                        {
                            //異動別=入庫，要更新庫存量
                            XIN.IncStock(context, NewProductID,
                                ((TransferDetails)(AddedEntry.Entity)).Quantity);
                        }
                        else
                        {
                            //異動別=出庫，要更新庫存量
                            XIN.DecStock(context, NewProductID,
                                   ((TransferDetails)(AddedEntry.Entity)).Quantity);
                        }
                    }
                }
            }
            //取得所有修改的存貨異動單明細
            foreach (var ModifiedEntry in context.ObjectStateManager
                                          .GetObjectStateEntries(EntityState.Modified))
            {
                if (!ModifiedEntry.IsRelationship)
                {
                    if (ModifiedEntry.Entity is TransferDetails)
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
                        //判斷異動別
                        if (transferTypeTextBox.Text == "1")
                        {
                            //異動別=入庫
                            //增加目前的商品編號的庫存量
                            XIN.IncStock(context, NewProductID, NewQuantity);
                            //減少原來的商品編號的庫存量
                            XIN.DecStock(context, OldProductID, OldQuantity);                            
                        }
                        else
                        {
                            //異動別=出庫
                            //增加原來的商品編號的庫存量
                            XIN.IncStock(context, OldProductID, OldQuantity);
                            //減少目前的商品編號的庫存量
                            XIN.DecStock(context, NewProductID, NewQuantity);
                        }
                    }
                }
            }
            //取得所有刪除的存貨異動單明細
            foreach (var DeletedEntry in context.ObjectStateManager
                                          .GetObjectStateEntries(EntityState.Deleted))
            {
                if (!DeletedEntry.IsRelationship)
                {
                    if (DeletedEntry.Entity is TransferDetails)
                    {
                        OldProductID = ((TransferDetails)
                                         (DeletedEntry.Entity)).ProductID;
                        //判斷異動別
                        if (DeleteTransferType == "1")
                        {
                            //異動別=入庫，更新庫存量
                            XIN.DecStock(context, OldProductID,
                                ((TransferDetails)(DeletedEntry.Entity)).Quantity);
                        }
                        else
                        {
                            //異動別=出庫，更新庫存量
                            XIN.IncStock(context, OldProductID,
                                ((TransferDetails)(DeletedEntry.Entity)).Quantity);
                        }
                    }
                }
            }
        }

        public override bool BeforeDelete()
        {
            if (MessageBox.Show(string.Format(
                "刪除本筆存貨異動單？\r\n\r\n異動單號：{0}", transferIDLabel.Text),
                "刪除記錄", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
            {
                return false;
            }
            //進行刪除記錄的程序
            DeleteTransferType = transferTypeTextBox.Text;
            DeleteID = transferIDLabel.Text;
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
                //找出目前的存貨異動單記錄的物件
                var rowDelivery = (Transfer)(transferBindingSource.Current);
                if (rowDelivery != null)
                {
                    //刪除存貨異動單明細記錄
                    if (rowDelivery.TransferDetails.Count != 0)
                    {
                        context.DeleteObject(rowDelivery.TransferDetails.First());
                    }
                    //刪除存貨異動單記錄
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
            PrimaryID = transferIDLabel.Text;
            //確認交易
            db.Commit();
            return true;
        }

        public override void DoPrint()
        {
            fmRptTransfer RptTransfer = new fmRptTransfer();
            RptTransfer.MdiParent = this.ParentForm;
            RptTransfer.TransferID = transferIDLabel.Text;
            RptTransfer.Show();
        }
    }
}
