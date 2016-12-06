using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Reflection;


namespace XIN2012
{
    public partial class fmMain : Form
    {

        //是否已經通過認證
        public static bool FPowerCheck = false;
        //登入的員工代碼與員工名稱
        public static string FEmployeeNo, FEmployeeName;

        public static string QryProductID;
        public static string QryProductName;

        public static fmMain FMain;

        public fmMain()
        {
            InitializeComponent();
            FMain = this;
        }

        private void SyncAdminUsers()
        {
            using (var context = new XINEntities())
            {
                //檢查使用者代碼資料表是否有ADMIN的使用者
                var qry = (from E in context.XINUsers
                           where E.EmployeeNo == "ADMIN"
                           select E.EmployeeNo).FirstOrDefault();
                if (qry == null)
                {
                    //新增ADMIN使用者
                    XINUsers NewXINUsers = new XINUsers();
                    NewXINUsers.EmployeeNo = "ADMIN";
                    NewXINUsers.EmployeeName = "系統管理員";
                    NewXINUsers.PasswordCode = "ADMIN";
                    //加入ADMIN使用者
                    context.AddObject("XINUsers", NewXINUsers);
                    //更新資料
                    context.SaveChanges();
                }
            }
        }

        private void SyncProgramID()
        {
            using (var context = new XINEntities())
            {
                try
                {
                    string sName;
                    string ProgramID, ProgramName;
                    //從MenuStrip1控制項集合找出每一個控制項
                    foreach (var tsmi in MenuStrip1.Items)
                    {
                        if (!(tsmi is ToolStripItem))
                        {
                            continue;
                        }
                        //找出MenuStrip1.Items的子控制項
                        foreach (var SubItem in 
                            ((ToolStripMenuItem)(tsmi)).DropDownItems)
                        {
                            //判斷找出的控制項是否為ToolStripMenuItem類別
                            if (!(SubItem is ToolStripMenuItem))
                            {
                                continue;
                            }
                            sName = ((ToolStripMenuItem)SubItem).Name.Substring(2, 3);
                            if ((sName == "Dtn") || (sName == "Txn") ||
                                (sName == "Rpt") || (sName == "Qry"))
                            {
                                //程式代碼
                                ProgramID = ((ToolStripMenuItem)SubItem).Name
                                                                        .Substring(2);
                                //程式名稱
                                ProgramName = ((ToolStripMenuItem)SubItem).Text;
                                //檢查程式代碼資料表是否有此程式代碼的記錄
                                var qry = (from P in context.Programs
                                           where P.ProgramID == ProgramID
                                           select P).FirstOrDefault();
                                if (qry == null)
                                {
                                    //新增程式代碼記錄
                                    Programs NewProgram = new Programs();
                                    NewProgram.ProgramID = ProgramID;
                                    NewProgram.ProgramName = ProgramName;
                                    //加入程式代碼
                                    context.AddObject("Programs", NewProgram);
                                    //更新資料
                                    //context.SaveChanges();
                                }
                                else
                                {
                                    //修改程式代碼記錄
                                    qry.ProgramName = ProgramName;
                                }
                                //更新資料 
                                context.SaveChanges();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "啟動錯誤", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void SyncUserAuthority()
        {
            using (var context = new XINEntities())
            {
                string EmployeeNo, ProgramID;
                try
                {
                    //找出所有的程式代碼記錄
                    var qryPrograms = from P in context.Programs
                                      select P.ProgramID;
                    //找出所有的使用者代碼記錄
                    var qrysUsers = from E in context.XINUsers
                                    select E.EmployeeNo;
                    foreach (var P in qryPrograms)
                    {
                        ProgramID = (string)P;
                        foreach (var U in qrysUsers)
                        {
                            EmployeeNo = (string)U;
                            var qry = (from A in context.UserAuthority
                                       where A.EmployeeNo == EmployeeNo
                                       && A.ProgramID == ProgramID
                                       select A).FirstOrDefault();
                            if (qry == null)
                            {
                                //新增使用權限記錄
                                UserAuthority NewAuthority = new UserAuthority();
                                NewAuthority.EmployeeNo = EmployeeNo;
                                NewAuthority.ProgramID = ProgramID;
                                NewAuthority.Run = true;
                                NewAuthority.Append = true;
                                NewAuthority.Edit = true;
                                NewAuthority.Report = true;
                                context.AddObject("UserAuthority", NewAuthority);
                            }
                        }
                    }
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "啟動錯誤", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        //檢查是否有執行指定程式代碼的執行權限
        private bool CheckProgramRight(string ProgramID)
        {
            var blnRun = false;
            //檢查指定的程式是否有執行權限
            using (var context = new XINEntities())
            {
                var qryAuth = (from M in context.UserAuthority
                               where M.EmployeeNo == FEmployeeNo
                               && M.ProgramID == ProgramID
                               select M).FirstOrDefault();
                if (qryAuth != null)
                {
                    blnRun = Convert.ToBoolean(qryAuth.Run);
                }
            }
            return blnRun;
        }

        private void SyncProgramsRight()
        {
            using (var context = new XINEntities())
            {
                try
                {
                    string sName, sProgramID;
                    //從MenuStrip1控制項集合找出每一個控制項
                    foreach (var tsmi in MenuStrip1.Items)
                    {
                        if (!(tsmi is ToolStripItem))
                        {
                            continue;
                        }
                        //找出MenuStrip1.Items的子控制項
                        foreach (var SubItem in 
                            ((ToolStripMenuItem)(tsmi)).DropDownItems)
                        {
                            //判斷找出的控制項是否為ToolStripMenuItem類別
                            if (!(SubItem is ToolStripMenuItem))
                            {
                                continue;
                            }
                            sName = ((ToolStripMenuItem)SubItem).Name.Substring(2, 3);
                            if ((sName == "Dtn") || (sName == "Txn") ||
                                (sName == "Rpt") || (sName == "Qry"))
                            {
                                //程式代碼
                                sProgramID = ((ToolStripMenuItem)SubItem).Name
                                                                         .Substring(2);
                                //取得是否有執行程式的權限
                                ((ToolStripMenuItem)SubItem).Enabled = 
                                    CheckProgramRight(sProgramID);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "啟動錯誤", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        //判斷要開啟的視窗是否已經開啟
        //若視窗已開啟，將該視窗帶到最上層
        private bool CheckWindowOpened(string ChildWindowName)
        {
            bool Opened = true;
            for (int iChildren = 0; iChildren < MdiChildren.Length; iChildren++)
            {
                if (MdiChildren[iChildren].Name == ChildWindowName)
                {
                    //將視窗帶到到最上層
                    MdiChildren[iChildren].BringToFront();
                    Opened = false;
                }
            }
            return Opened;
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            //顯示系統啟動畫面(版權宣告畫面)
            fmSplash Splash = new fmSplash();
            Splash.Show();
            Splash.Update();
            UserLabel.Text = "";
            //檢查使用者代碼資料表是否有ADMIN的使用者
            SyncAdminUsers();
            //同步所有的程式代碼
            SyncProgramID();
            //同步所有的使用者執行權限
            SyncUserAuthority();
            //開啟認證登入表單對話方塊
            fmLogin fmLogin = new fmLogin();
            //關閉系統啟動畫面(版權宣告畫面)
            Splash.Close();
            fmLogin.ShowDialog();
            //如果未通過認證，就結束系統
            if (!FPowerCheck)
            {
                this.Close();
            }
            //在狀態列顯示登入的使用者代碼與使用者名稱
            UserLabel.Text = "使用者:(" + FEmployeeNo + ")" + FEmployeeName;
            //檢查每一個程式項目對登入的使用者是否有執行權限
            SyncProgramsRight();
        }

        private void miCascad_Click(object sender, EventArgs e)
        {
            //垂直排列
            LayoutMdi(MdiLayout.Cascade);
        }

        private void miDtnProduct_Click(object sender, EventArgs e)
        {
            //商品基本資料維護
            if (CheckWindowOpened("fmDtnProduct")) 
            {                
                fmDtnProduct EditProduct = new fmDtnProduct();
                EditProduct.MdiParent = this;
                EditProduct.Show();
            }
        }

        private void miDtnSupplier_Click(object sender, EventArgs e)
        {
            //廠商基本資料維護
            if (CheckWindowOpened("fmDtnSupplier"))
            {
                fmDtnSupplier EditSupplier = new fmDtnSupplier();
                EditSupplier.MdiParent = this;
                EditSupplier.Show();
            }
        }

        private void miDtnCustomer_Click(object sender, EventArgs e)
        {
            //客戶基本資料維護
            if (CheckWindowOpened("fmDtnCustomer"))
            {
                fmDtnCustomer EditCustomer = new fmDtnCustomer();
                EditCustomer.MdiParent = this;
                EditCustomer.Show();
            }
        }

        private void miRptProduct_Click(object sender, EventArgs e)
        {
            //商品基本資料表
            if (CheckWindowOpened("fmRptProduct"))
            {
               fmRptProduct RptProduct = new fmRptProduct();
               RptProduct.MdiParent = this;
               RptProduct.Show();
            }
        }

        private void miRptSupplier_Click(object sender, EventArgs e)
        {
            //廠商基本資料表
            if (CheckWindowOpened("fmRptSupplier"))
            {
               fmRptSupplier RptSupplier = new fmRptSupplier();
               RptSupplier.MdiParent = this;
               RptSupplier.Show();
            }
        }

        private void miRptCustomer_Click(object sender, EventArgs e)
        {
            //客戶基本資料表
            if (CheckWindowOpened("fmRptCustomer"))
            {
                fmRptCustomer RptCustomer = new fmRptCustomer();
                RptCustomer.MdiParent = this;
                RptCustomer.Show();
            }
        }

        private void miTxnReceipt_Click(object sender, EventArgs e)
        {
            //進貨(退出)單
            if (CheckWindowOpened("fmTxnReceipt"))
            {
                fmTxnReceipt EditReceipt = new fmTxnReceipt();
                EditReceipt.MdiParent = this;
                EditReceipt.Show();
            }
        }

        private void miRptReceiptList_Click(object sender, EventArgs e)
        {
            //進貨明細表
            if (CheckWindowOpened("fmRptReceiptListCondi"))
            {
                fmRptReceiptListCondi RptReceiptListCondi = new fmRptReceiptListCondi();
                RptReceiptListCondi.MdiParent = this;
                RptReceiptListCondi.Show();
            }
        }

        private void miRptReceiptGroup_Click(object sender, EventArgs e)
        {
            //進貨統計表
            if (CheckWindowOpened("fmRptReceiptGroupCondi"))
            {
                fmRptDeliveryGroupCondi RptReceiptGroupCondi = new fmRptDeliveryGroupCondi();
                RptReceiptGroupCondi.MdiParent = this;
                RptReceiptGroupCondi.Show();
            }
        }

        private void miRptReceiptRank_Click(object sender, EventArgs e)
        {
            //進貨排行榜
            if (CheckWindowOpened("fmRptReceiptRankCondi"))
            {
                fmRptReceiptRankCondi RptReceiptRankCondi = new fmRptReceiptRankCondi();
                RptReceiptRankCondi.MdiParent = this;
                RptReceiptRankCondi.Show();
            }
        }

        private void miRptReceiptYear_Click(object sender, EventArgs e)
        {
            //進貨年統計表
            if (CheckWindowOpened("fmRptReceiptYearCondi"))
            {
                fmRptReceiptYearCondi RptReceiptYearCondi = new fmRptReceiptYearCondi();
                RptReceiptYearCondi.MdiParent = this;
                RptReceiptYearCondi.Show();
            }
        }

        private void miTxnDelivery_Click(object sender, EventArgs e)
        {
            //出貨(退回)單
            if (CheckWindowOpened("fmTxnDelivery"))
            {
                fmTxnDelivery EditDelivery = new fmTxnDelivery();
                EditDelivery.MdiParent = this;
                EditDelivery.Show();
            }
        }

        private void miRptDeliveryList_Click(object sender, EventArgs e)
        {
            //出貨明細表
            if (CheckWindowOpened("fmRptDeliveryListCondi"))
            {
                fmRptDeliveryListCondi RptDeliveryListCondi = new fmRptDeliveryListCondi();
                RptDeliveryListCondi.MdiParent = this;
                RptDeliveryListCondi.Show();
            }
        }

        private void miRptDeliveryGroup_Click(object sender, EventArgs e)
        {
            //出貨統計表
            if (CheckWindowOpened("fmRptDeliveryGroupCondi"))
            {
                fmRptDeliveryGroupCondi RptDeliveryGroupCondi;
                RptDeliveryGroupCondi = new fmRptDeliveryGroupCondi();
                RptDeliveryGroupCondi.MdiParent = this;
                RptDeliveryGroupCondi.Show();
            }
        }

        private void miRptDeliveryRank_Click(object sender, EventArgs e)
        {
            //出貨排行榜
            if (CheckWindowOpened("fmRptDeliveryRankCondi"))
            {
                fmRptDeliveryRankCondi RptDeliveryRankCondi;
                RptDeliveryRankCondi = new fmRptDeliveryRankCondi();
                RptDeliveryRankCondi.MdiParent = this;
                RptDeliveryRankCondi.Show();
            }
        }

        private void miRptDeliveryYear_Click(object sender, EventArgs e)
        {
            //出貨年統計表
            if (CheckWindowOpened("fmRptDeliveryYearCondi"))
            {
                fmRptDeliveryYearCondi RptDeliveryYearCondi;
                RptDeliveryYearCondi = new fmRptDeliveryYearCondi();
                RptDeliveryYearCondi.MdiParent = this;
                RptDeliveryYearCondi.Show();
            }
        }

        private void miTxnTransfer_Click(object sender, EventArgs e)
        {
            //存貨異動單
            if (CheckWindowOpened("fmTxnTransfer"))
            {
                fmTxnTransfer EditTransfer = new fmTxnTransfer();
                EditTransfer.MdiParent = this;
                EditTransfer.Show();
            }
        }

        private void miQryTransfer_Click(object sender, EventArgs e)
        {
            //商品別異動記錄查詢
            if (CheckWindowOpened("fmQryTransfer"))
            {
                fmQryTransfer QueryTransfer = new fmQryTransfer();
                QueryTransfer.MdiParent = this;
                QueryTransfer.Show();
            }
        }

        private void miRptStockList_Click(object sender, EventArgs e)
        {
            //庫存盤點表
            if (CheckWindowOpened("fmRptStockList"))
            {
                fmRptStockList RptStockList = new fmRptStockList();
                RptStockList.MdiParent = this;
                RptStockList.Show();
            }
        }

        private void miRptStockPostList_Click(object sender, EventArgs e)
        {
            //商品異動明細表
            if (CheckWindowOpened("fmRptStockPostListCondi"))
            {
                fmRptStockPostListCondi RptStockPostListCondi;
                RptStockPostListCondi = new fmRptStockPostListCondi();
                RptStockPostListCondi.MdiParent = this;
                RptStockPostListCondi.Show();
            }
        }

        private void miRptStockPostGroup_Click(object sender, EventArgs e)
        {
            //商品異動彙總表
            if (CheckWindowOpened("fmRptStockPostGroupCondi"))
            {
                fmRptStockPostGroupCondi RptStockPostGroupCondi;
                RptStockPostGroupCondi = new fmRptStockPostGroupCondi();
                RptStockPostGroupCondi.MdiParent = this;
                RptStockPostGroupCondi.Show();
            }
        }

        private void miRptDullSales_Click(object sender, EventArgs e)
        {
            //商品呆滯銷分析表
            if (CheckWindowOpened("fmRptDullSalesCondi"))
            {
                fmRptDullSalesCondi RptDullSalesCondi = new fmRptDullSalesCondi();
                RptDullSalesCondi.MdiParent = this;
                RptDullSalesCondi.Show();
            }
        }

        private void miDtnXINUsers_Click(object sender, EventArgs e)
        {
            //使用者代碼維護
            if (CheckWindowOpened("fmDtnXINUsers"))
            {
                fmDtnXINUsers fmDtnXINUsers = new fmDtnXINUsers();
                fmDtnXINUsers.MdiParent = this;
                fmDtnXINUsers.Show();
            }
        }

        private void miDtnProgramAuthority_Click(object sender, EventArgs e)
        {
            //程式使用權限維護
            if (CheckWindowOpened("fmDtnProgramAuthority"))
            {
                fmDtnProgramAuthority ProgAuth = new fmDtnProgramAuthority();
                ProgAuth.MdiParent = this;
                ProgAuth.Show();
            }
        }

        private void miDtnUserAuthority_Click(object sender, EventArgs e)
        {
            //使用者執行權限維護
            if (CheckWindowOpened("fmDtnUserAuthority"))
            {
                fmDtnUserAuthority UsersAuth = new fmDtnUserAuthority();
                UsersAuth.MdiParent = this;
                UsersAuth.Show();
            }
        }

        private void miDtnPassword_Click(object sender, EventArgs e)
        {
            //使用者密碼變更
            fmDtnPassword ChangePassword = new fmDtnPassword();
            ChangePassword.ShowDialog();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            //關於進銷存管理系統
            fmAboutBox frmAboutBox = new fmAboutBox();
            frmAboutBox.ShowDialog();
        }

        private void miClose_Click(object sender, EventArgs e)
        {
            //結束系統
            this.Close();
        }

        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //應用程式關閉前，檢查是否還有進行中的作業
            Form tempChild = this.ActiveMdiChild;
            e.Cancel = false;
            if (tempChild != null)
            {
                if (MessageBox.Show("尚有作業進行中，仍要結束本系統嗎？", "系統結束",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
