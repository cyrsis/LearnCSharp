using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Common;

namespace XIN2012
{
    public partial class fmBase : Form
    {
       
        //資料狀態
        byte FTBStatus;
        //主索引鍵值
        string FPrimaryID;
        //被刪除的主索引鍵值
        string FDeleteID;
        //資料表名稱
        string FTableName;
        //資料表主索引鍵的欄位名稱
        string FIDFieldName;
        //允許更新
        bool FAllowAddNew = true;
        //允許修改
        bool FAllowEdit = true;
        //允許刪除
        bool FAllowDelete = false;
        //允許列印表單
        bool FAllowPrint = false;
        //BindingSource物件
        BindingSource FBindingSource;
        //取得目前作業的程式名稱
        string FProgramID;
        //建立存取共用類別的變數
        XINFunction XIN;

        
        public fmBase()
        {
            InitializeComponent();
        }

        private void SetButtons()
        {
            //FStatus:
            // 0:瀏覽模式
            // 1:新增模式
            // 2:修改模式
            btnFirst.Enabled = (FTBStatus == 0);
            btnPrior.Enabled = (FTBStatus == 0);
            btnNext.Enabled = (FTBStatus == 0);
            btnLast.Enabled = (FTBStatus == 0);
            btnAddNew.Enabled = (FTBStatus == 0) && (AllowAddNew);
            btnEdit.Enabled = (FTBStatus == 0) && (FPrimaryID != "") && (FAllowEdit);
            btnDelete.Enabled = (FTBStatus == 0) && (FPrimaryID != "") && (FAllowDelete);
            btnSaveChange.Enabled = ((FTBStatus == 1) || (FTBStatus == 2));
            btnCancelEdit.Enabled = ((FTBStatus == 1) || (FTBStatus == 2));
            btnSearch.Enabled = (FTBStatus == 0) && (tbxSearch.Text != "");
            tbxSearch.ReadOnly = (FTBStatus != 0);
            if (FAllowPrint)
            {
                btnPrint.Visible = true;
                btnPrint.Enabled = (FTBStatus == 0) && (FPrimaryID != String.Empty);
            }
            else
            {
                btnPrint.Visible = false;
            }
        }

        //取得或設定資料表狀態的屬性
        public byte TBStatus
        {
            get
            {
                return FTBStatus;
            }
            set
            {
                FTBStatus = value;
            }
        }

        //取得或設定BindingSource物件的屬性
        public BindingSource BS 
        {
            get
            {
                return FBindingSource;
            }
            set
            {
                FBindingSource = value;
                BaseBindingNavigator.BindingSource = value;
            }
        }

        //取得或設定主索引鍵值的屬性
        public string PrimaryID
        {
            get
            {
                return FPrimaryID;
            }
            set
            {
                FPrimaryID = value;
            }
        }

        //取得或設定被刪除的主索引鍵的值
        public string DeleteID
        {
            get
            {
                return FDeleteID;
            }
            set
            {
                FDeleteID = value;
            }
        }

        //取得或設定資料表的名稱
        public string TableName
        {
            get
            {
                return FTableName;
            }
            set
            {
                FTableName = value;
            }
        }

        //取得或設定主索引鍵的欄位名稱
        public string IDFieldName
        {
            get
            {
                return FIDFieldName;
            }
            set
            {
                FIDFieldName = value;
            }
        }

        //取得或設定是否允許列印表單的權限
        public bool AllowPrint
        {
            get
            {
                return FAllowPrint;
            }
            set
            {
                FAllowPrint = value;
                SetButtons();
            }
        }

        //取得或設定是否允許新增記錄的權限
        public bool AllowAddNew
        {
            get
            {
                return FAllowAddNew;
            }
            set
            {
                FAllowAddNew = value;
                SetButtons();
            }
        }

        //取得或設定是否允許修改記錄的權限
        public bool AllowEdit
        {
            get
            {
                return FAllowEdit;
            }
            set
            {
                FAllowEdit = value;
                SetButtons();
            }
        }

        //取得或設定是否允許刪除記錄的權限
        public bool AllowDelete
        {
            get
            {
                return FAllowDelete;
            }
            set
            {
                FAllowDelete = value;
                SetButtons();
            }
        }

        public virtual bool BeforeAddNew()
        {
            //虛擬方法，供繼承者實作，預設值為true
            //按下btnAddNew按鈕新增記錄之前
            return true;
        }

        public virtual void AfterAddNew()
        {
            //虛擬方法，供繼承者實作
            //按下btnAddNew按鈕來新增記錄之後
        }

        public virtual bool BeforeEdit()
        {
            //虛擬方法，供繼承者實作，預設值為true
            //按下btnEdit按鈕編輯記錄之前
            return true;
        }

        public virtual void AfterEdit()
        {
            //虛擬方法，供繼承者實作
            //按下btnEdit按鈕編輯記錄之後
        }

        public virtual bool BeforeEndEdit()
        {
            //虛擬方法，供繼承者實作，預設值為true
            //儲存資料之後(執行EndEdit方法之前)
            return true;
        }

        public virtual void AfterEndEdit()
        {
            //虛擬方法，供繼承者實作
            //儲存資料之後(執行EndEdit方法之後)
        }

        public virtual bool BeforeCancelEdit()
        {
            //虛擬方法，供繼承者實作，預設值為true
            //執行BS物件的CancelEdit方法之前
            return true;
        }

        public virtual void AfterCancelEdit()
        {
            //虛擬方法，供繼承者實作
            //執行BS物件的CancelEdit()方法之後
        }

        public virtual bool BeforeDelete()
        {
            //虛擬方法，供繼承者實作，預設值為true
            //刪除記錄前要處理的事情
            return true;
        }

        public virtual void AfterDelete()
        {
            //虛擬方法，供繼承者實作
            //刪除記錄後要處理的事情
        }

        public virtual void BeforeLoad()
        {
            //虛擬方法，供繼承者實作
            //載入資料之前(執行FillData方法之前)
        }

        public virtual void AfterLoad()
        {
            //虛擬方法，供繼承者實作
            //載入資料之後(執行FillData方法之後)
        }

        public virtual bool BeforeScroll()
        {
            //虛擬方法，供繼承者實作，預設值為true
            //移動記錄之前
            return true;
        }

        public virtual void AfterScroll()
        {
            //虛擬方法，供繼承者實作
            //移動記錄之後
        }

        public virtual void FillData()
        {
            //虛擬方法，供繼承者實作
            //載入資料
        }

        public virtual bool UpdateData()
        {
            //虛擬方法，供繼承者實作，預設值為true
            //用來執行更新的記錄至資料庫
            return true;
        }

        public virtual bool DeleteData()
        {
            //虛擬方法，供繼承者實作，預設值為true
            //用來執行更新的記錄至資料庫
            return true;
        }

        public virtual void SetControls()
        {
            //虛擬方法，供繼承者實作
            //設定所有控制項的ReadOnly或Enabled屬性
        }

        public virtual void SetDefaultValue()
        {
            //虛擬方法，供繼承者實作
            //設定新增記錄時的預設值，觸發於狀態為新增時
        }

        public virtual void DoPrint()
        {
            //虛擬方法，供繼承者實作
            //用於執行列印表單的任務
        }

        private void FBindingSource_PositionChanged(Object sender, EventArgs e)
        {
            //利用PositionChanged改變記錄指標按鈕的狀態
            SetButtons();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            //按下btnFirst按鈕
            if (BeforeScroll())
            {               
                using (var context = new XINEntities())
                {
                    //找出指定資料表的第一筆記錄
                    string ESQL = "SELECT MIN(T." + FIDFieldName + ") AS ID " +
                                  "FROM XINEntities." + FTableName + " AS T ";
                    DbDataRecord rec = new ObjectQuery<DbDataRecord>
                                           (ESQL, context).FirstOrDefault();
                    if (rec[0] != null)
                    {
                        PrimaryID = (string)(rec[0]);
                        BeforeLoad();
                        FillData();
                        AfterLoad();
                    }
                }
                TBStatus = 0;
                AfterScroll();
            }
            SetButtons();        
        }

        private void btnPrior_Click(object sender, EventArgs e)
        {
            //按下btnPrior按鈕
            if (BeforeScroll())
            {               
                using (var context = new XINEntities())
                {
                    //找出指定資料表的的目前記錄的上一筆記錄
                    string ESQL = "SELECT T." + FIDFieldName + " AS ID " +
                                  "FROM XINEntities." + FTableName + " AS T " +
                                  "WHERE T." + FIDFieldName + 
                                  " < '" + FPrimaryID + "'" +
                                  "ORDER BY T." + FIDFieldName + " DESC";
                    DbDataRecord rec = new ObjectQuery<DbDataRecord>
                                           (ESQL, context).FirstOrDefault();
                    if (rec != null)
                    {
                        if (rec[0] != null)
                        {
                            PrimaryID = (string)(rec[0]);
                            BeforeLoad();
                            FillData();
                            AfterLoad();
                        }
                    }
                }
                TBStatus = 0;
                AfterScroll();
            }
            SetButtons();        
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //按下btnNext按鈕
            if (BeforeScroll())
            {
                using (var context = new XINEntities())
                {
                    //找出指定資料表的的目前記錄的下一筆記錄
                    string ESQL = "SELECT T." + FIDFieldName + " AS ID " +
                                  "FROM XINEntities." + FTableName + " AS T " +
                                  "WHERE T." + FIDFieldName + 
                                  " > '" + FPrimaryID + "'" +
                                  "ORDER BY T." + FIDFieldName;
                    DbDataRecord rec = new ObjectQuery<DbDataRecord>
                                           (ESQL, context).FirstOrDefault();
                    if (rec != null)
                    {
                        if (rec[0] != null)
                        {
                            PrimaryID = (string)(rec[0]);
                            BeforeLoad();
                            FillData();
                            AfterLoad();
                        }
                    }
                }
                TBStatus = 0;
                AfterScroll();
            }
            SetButtons();        
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            //按下btnLast按鈕
            if (BeforeScroll())
            {               
                using (var context = new XINEntities())
                {
                    //找出指定資料表的第一筆記錄
                    string ESQL = "SELECT MAX(T." + FIDFieldName + ") AS ID " +
                                  "FROM XINEntities." + FTableName + " AS T ";
                    DbDataRecord rec = new ObjectQuery<DbDataRecord>
                                           (ESQL, context).FirstOrDefault();
                    if (rec[0] != null)
                    {
                        PrimaryID = (string)(rec[0]);
                        BeforeLoad();
                        FillData();
                        AfterLoad();
                    }
                }
                TBStatus = 0;
                AfterScroll();
            }
            SetButtons();   
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (! XIN.CheckAuthority(FProgramID, 1))
            {
                MessageBox.Show("您沒有新增記錄的權限。", "操作禁止", 
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            //按下btnAddNew按鈕
            if (BeforeAddNew())
            {
                BS.AddNew();
                TBStatus = 1;
                SetControls();
                SetDefaultValue();
                AfterAddNew();
            }
            SetButtons();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!XIN.CheckAuthority(FProgramID, 2))
            {
                MessageBox.Show("您沒有修改記錄的權限。", "操作禁止", 
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            //按下btnEdit按鈕
            if (BeforeEdit() && (PrimaryID != null))
            {
                TBStatus = 2;
                SetControls();
                AfterEdit();
            }
            SetButtons();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!XIN.CheckAuthority(FProgramID, 3))
            {
                MessageBox.Show("您沒有刪除記錄的權限。", "操作禁止", 
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            //按下btnDelete按鈕
            if (BeforeDelete() && (PrimaryID != null))
            {
                if (DeleteData())
                {
                    string ESQL;
                    DbDataRecord rec;
                    using (var context = new XINEntities())
                    {
                        //找出指定資料表的目前被刪除的記錄的下一筆記錄
                        ESQL = "SELECT T." + FIDFieldName + " AS ID " +
                               "FROM XINEntities." + FTableName + " AS T " +
                               "WHERE T." + FIDFieldName + 
                               " > '" + FDeleteID + "'" +
                               "ORDER BY T." + FIDFieldName;
                        rec = new ObjectQuery<DbDataRecord>
                                             (ESQL, context).FirstOrDefault();
                        if (rec != null)
                        {
                            PrimaryID = (string)(rec[0]);
                            BeforeLoad();
                            FillData();
                            AfterLoad();
                        }
                        else
                        {
                            //找出指定資料表的的目前記錄的上一筆記錄
                            ESQL = "SELECT T." + FIDFieldName + " AS ID " +
                                   "FROM XINEntities." + FTableName + " AS T " +
                                   "WHERE T." + FIDFieldName + 
                                   " < '" + FDeleteID + "'" +
                                   "ORDER BY T." + FIDFieldName + " DESC";
                            rec = new ObjectQuery<DbDataRecord>
                                                  (ESQL, context).FirstOrDefault();
                            if (rec != null)
                            {
                                PrimaryID = (string)(rec[0]);
                                BeforeLoad();
                                FillData();
                                AfterLoad();
                            }
                        }
                    }
                    SetControls();
                    AfterDelete();
                }
            }
            SetButtons();
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            //按btnSaveChange按鈕
            BS.EndEdit();
            if (BeforeEndEdit())
            {
                byte PrevTableStatus = TBStatus;
                try
                {
                    if (UpdateData())
                    {
                        TBStatus = 0;
                        SetControls();
                        AfterEndEdit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "操作錯誤", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBStatus = PrevTableStatus;
                }
                SetButtons();
            }
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            //按下btnCancelEdit按鈕
            if (BeforeCancelEdit())
            {
                if (FTBStatus == 1)
                {
                    BS.RemoveCurrent();
                }
                BS.CancelEdit();
                TBStatus = 0;
                SetControls();
                FillData();
                AfterCancelEdit();
            }
            SetButtons();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //按下btnSearch按鈕
            PrimaryID = tbxSearch.Text;
            if (PrimaryID != null)
            {
                string ESQL;
                DbDataRecord rec;
                using (var context = new XINEntities())
                {
                    ESQL = "SELECT T." + FIDFieldName + " AS ID " +
                           "FROM XINEntities." + FTableName + " AS T " +
                           "WHERE T." + FIDFieldName + 
                           " = '" + (string)PrimaryID + "'";
                    rec = new ObjectQuery<DbDataRecord>
                                         (ESQL, context).FirstOrDefault();
                    if (rec == null)
                    {
                        MessageBox.Show("找不到指定的記錄。", "警告", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (rec[0] != null) 
                        {
                            PrimaryID = (string)(rec[0]);
                            BeforeLoad();
                            FillData();
                            AfterLoad();
                        }
                    }
                }
                TBStatus = 0;
                AfterScroll();
            }
         }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch.Enabled = (FTBStatus == 0) && (tbxSearch.Text != "");
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!XIN.CheckAuthority(FProgramID, 4))
            {
                MessageBox.Show("您沒有列印記錄的權限。", "操作禁止", 
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            //按下btnPrint按鈕
            DoPrint();
        }

        private void fmBase_Load(object sender, EventArgs e)
        {
            FBindingSource = new BindingSource();
            FBindingSource.PositionChanged += 
                new EventHandler(this.FBindingSource_PositionChanged);
            //建立共用函數類別
            XIN = new XINFunction();
            //預設狀態為瀏覽模式
            TBStatus = 0;
            //所有按鈕的狀態
            SetButtons();
            //設定所有輸入控制項的唯讀狀態
            SetControls();
            //視窗位置
            this.Left = 0;
            this.Top = 0;
            //取得程式代碼
            FProgramID = this.Name.Substring(2);
        }

        private void fmBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TBStatus !=0)
            {
                if (MessageBox.Show("資料尚未儲存，仍要離開本作業嗎？", "資料未儲存", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }
    }
}
