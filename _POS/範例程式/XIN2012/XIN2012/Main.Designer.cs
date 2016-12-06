namespace XIN2012
{
    partial class fmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UserLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miBase = new System.Windows.Forms.ToolStripMenuItem();
            this.miDtnProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.miDtnSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.miDtnCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miRptProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.miRptSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.miRptCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.miReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.miTxnReceipt = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miRptReceiptList = new System.Windows.Forms.ToolStripMenuItem();
            this.miRptReceiptGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.miRptReceiptRank = new System.Windows.Forms.ToolStripMenuItem();
            this.miRptReceiptYear = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelivery = new System.Windows.Forms.ToolStripMenuItem();
            this.miTxnDelivery = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.miRptDeliveryList = new System.Windows.Forms.ToolStripMenuItem();
            this.miRptDeliveryGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.miRptDeliveryRank = new System.Windows.Forms.ToolStripMenuItem();
            this.miRptDeliveryYear = new System.Windows.Forms.ToolStripMenuItem();
            this.miStock = new System.Windows.Forms.ToolStripMenuItem();
            this.miTxnTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.miQryTransfer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.miRptStockList = new System.Windows.Forms.ToolStripMenuItem();
            this.miRptStockPostList = new System.Windows.Forms.ToolStripMenuItem();
            this.miRptStockPostGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.miRptDullSales = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.miCascad = new System.Windows.Forms.ToolStripMenuItem();
            this.miAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.miDtnXINUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.miDtnProgramAuthority = new System.Windows.Forms.ToolStripMenuItem();
            this.miDtnUserAuthority = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.miDtnPassword = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 23, 0);
            this.statusStrip1.Size = new System.Drawing.Size(646, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // UserLabel
            // 
            this.UserLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(186, 20);
            this.UserLabel.Text = "使用者：(BENNY)陳惟彬";
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBase,
            this.miReceipt,
            this.miDelivery,
            this.miStock,
            this.miWindows,
            this.miAdmin});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.MdiWindowListItem = this.miWindows;
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(17, 5, 0, 5);
            this.MenuStrip1.Size = new System.Drawing.Size(646, 34);
            this.MenuStrip1.TabIndex = 3;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // miBase
            // 
            this.miBase.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDtnProduct,
            this.miDtnSupplier,
            this.miDtnCustomer,
            this.ToolStripMenuItem1,
            this.miRptProduct,
            this.miRptSupplier,
            this.miRptCustomer,
            this.ToolStripMenuItem10,
            this.miClose});
            this.miBase.Name = "miBase";
            this.miBase.Size = new System.Drawing.Size(85, 24);
            this.miBase.Text = "基本資料";
            // 
            // miDtnProduct
            // 
            this.miDtnProduct.Name = "miDtnProduct";
            this.miDtnProduct.Size = new System.Drawing.Size(206, 24);
            this.miDtnProduct.Text = "商品基本資料維護";
            this.miDtnProduct.Click += new System.EventHandler(this.miDtnProduct_Click);
            // 
            // miDtnSupplier
            // 
            this.miDtnSupplier.Name = "miDtnSupplier";
            this.miDtnSupplier.Size = new System.Drawing.Size(206, 24);
            this.miDtnSupplier.Text = "廠商基本資料維護";
            this.miDtnSupplier.Click += new System.EventHandler(this.miDtnSupplier_Click);
            // 
            // miDtnCustomer
            // 
            this.miDtnCustomer.Name = "miDtnCustomer";
            this.miDtnCustomer.Size = new System.Drawing.Size(206, 24);
            this.miDtnCustomer.Text = "客戶基本資料維護";
            this.miDtnCustomer.Click += new System.EventHandler(this.miDtnCustomer_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
            // 
            // miRptProduct
            // 
            this.miRptProduct.Name = "miRptProduct";
            this.miRptProduct.Size = new System.Drawing.Size(206, 24);
            this.miRptProduct.Text = "商品基本資料表";
            this.miRptProduct.Click += new System.EventHandler(this.miRptProduct_Click);
            // 
            // miRptSupplier
            // 
            this.miRptSupplier.Name = "miRptSupplier";
            this.miRptSupplier.Size = new System.Drawing.Size(206, 24);
            this.miRptSupplier.Text = "廠商基本資料表";
            this.miRptSupplier.Click += new System.EventHandler(this.miRptSupplier_Click);
            // 
            // miRptCustomer
            // 
            this.miRptCustomer.Name = "miRptCustomer";
            this.miRptCustomer.Size = new System.Drawing.Size(206, 24);
            this.miRptCustomer.Text = "客戶基本資料表";
            this.miRptCustomer.Click += new System.EventHandler(this.miRptCustomer_Click);
            // 
            // ToolStripMenuItem10
            // 
            this.ToolStripMenuItem10.Name = "ToolStripMenuItem10";
            this.ToolStripMenuItem10.Size = new System.Drawing.Size(203, 6);
            // 
            // miClose
            // 
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(206, 24);
            this.miClose.Text = "結束系統";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // miReceipt
            // 
            this.miReceipt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTxnReceipt,
            this.ToolStripMenuItem2,
            this.miRptReceiptList,
            this.miRptReceiptGroup,
            this.miRptReceiptRank,
            this.miRptReceiptYear});
            this.miReceipt.Name = "miReceipt";
            this.miReceipt.Size = new System.Drawing.Size(85, 24);
            this.miReceipt.Text = "進貨作業";
            // 
            // miTxnReceipt
            // 
            this.miTxnReceipt.Name = "miTxnReceipt";
            this.miTxnReceipt.Size = new System.Drawing.Size(174, 24);
            this.miTxnReceipt.Text = "進貨(退出)單";
            this.miTxnReceipt.Click += new System.EventHandler(this.miTxnReceipt_Click);
            // 
            // ToolStripMenuItem2
            // 
            this.ToolStripMenuItem2.Name = "ToolStripMenuItem2";
            this.ToolStripMenuItem2.Size = new System.Drawing.Size(171, 6);
            // 
            // miRptReceiptList
            // 
            this.miRptReceiptList.Name = "miRptReceiptList";
            this.miRptReceiptList.Size = new System.Drawing.Size(174, 24);
            this.miRptReceiptList.Text = "進貨明細表";
            this.miRptReceiptList.Click += new System.EventHandler(this.miRptReceiptList_Click);
            // 
            // miRptReceiptGroup
            // 
            this.miRptReceiptGroup.Name = "miRptReceiptGroup";
            this.miRptReceiptGroup.Size = new System.Drawing.Size(174, 24);
            this.miRptReceiptGroup.Text = "進貨統計表";
            this.miRptReceiptGroup.Click += new System.EventHandler(this.miRptReceiptGroup_Click);
            // 
            // miRptReceiptRank
            // 
            this.miRptReceiptRank.Name = "miRptReceiptRank";
            this.miRptReceiptRank.Size = new System.Drawing.Size(174, 24);
            this.miRptReceiptRank.Text = "進貨排行榜";
            this.miRptReceiptRank.Click += new System.EventHandler(this.miRptReceiptRank_Click);
            // 
            // miRptReceiptYear
            // 
            this.miRptReceiptYear.Name = "miRptReceiptYear";
            this.miRptReceiptYear.Size = new System.Drawing.Size(174, 24);
            this.miRptReceiptYear.Text = "進貨年統計表";
            this.miRptReceiptYear.Click += new System.EventHandler(this.miRptReceiptYear_Click);
            // 
            // miDelivery
            // 
            this.miDelivery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTxnDelivery,
            this.ToolStripMenuItem3,
            this.miRptDeliveryList,
            this.miRptDeliveryGroup,
            this.miRptDeliveryRank,
            this.miRptDeliveryYear});
            this.miDelivery.Name = "miDelivery";
            this.miDelivery.Size = new System.Drawing.Size(85, 24);
            this.miDelivery.Text = "出貨作業";
            // 
            // miTxnDelivery
            // 
            this.miTxnDelivery.Name = "miTxnDelivery";
            this.miTxnDelivery.Size = new System.Drawing.Size(174, 24);
            this.miTxnDelivery.Text = "出貨(退回)單";
            this.miTxnDelivery.Click += new System.EventHandler(this.miTxnDelivery_Click);
            // 
            // ToolStripMenuItem3
            // 
            this.ToolStripMenuItem3.Name = "ToolStripMenuItem3";
            this.ToolStripMenuItem3.Size = new System.Drawing.Size(171, 6);
            // 
            // miRptDeliveryList
            // 
            this.miRptDeliveryList.Name = "miRptDeliveryList";
            this.miRptDeliveryList.Size = new System.Drawing.Size(174, 24);
            this.miRptDeliveryList.Text = "出貨明細表";
            this.miRptDeliveryList.Click += new System.EventHandler(this.miRptDeliveryList_Click);
            // 
            // miRptDeliveryGroup
            // 
            this.miRptDeliveryGroup.Name = "miRptDeliveryGroup";
            this.miRptDeliveryGroup.Size = new System.Drawing.Size(174, 24);
            this.miRptDeliveryGroup.Text = "出貨統計表";
            this.miRptDeliveryGroup.Click += new System.EventHandler(this.miRptDeliveryGroup_Click);
            // 
            // miRptDeliveryRank
            // 
            this.miRptDeliveryRank.Name = "miRptDeliveryRank";
            this.miRptDeliveryRank.Size = new System.Drawing.Size(174, 24);
            this.miRptDeliveryRank.Text = "出貨排行榜";
            this.miRptDeliveryRank.Click += new System.EventHandler(this.miRptDeliveryRank_Click);
            // 
            // miRptDeliveryYear
            // 
            this.miRptDeliveryYear.Name = "miRptDeliveryYear";
            this.miRptDeliveryYear.Size = new System.Drawing.Size(174, 24);
            this.miRptDeliveryYear.Text = "出貨年統計表";
            this.miRptDeliveryYear.Click += new System.EventHandler(this.miRptDeliveryYear_Click);
            // 
            // miStock
            // 
            this.miStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTxnTransfer,
            this.ToolStripMenuItem5,
            this.miQryTransfer,
            this.toolStripMenuItem4,
            this.miRptStockList,
            this.miRptStockPostList,
            this.miRptStockPostGroup,
            this.miRptDullSales});
            this.miStock.Name = "miStock";
            this.miStock.Size = new System.Drawing.Size(85, 24);
            this.miStock.Text = "庫存管理";
            // 
            // miTxnTransfer
            // 
            this.miTxnTransfer.Name = "miTxnTransfer";
            this.miTxnTransfer.Size = new System.Drawing.Size(222, 24);
            this.miTxnTransfer.Text = "存貨異動單";
            this.miTxnTransfer.Click += new System.EventHandler(this.miTxnTransfer_Click);
            // 
            // ToolStripMenuItem5
            // 
            this.ToolStripMenuItem5.Name = "ToolStripMenuItem5";
            this.ToolStripMenuItem5.Size = new System.Drawing.Size(219, 6);
            // 
            // miQryTransfer
            // 
            this.miQryTransfer.Name = "miQryTransfer";
            this.miQryTransfer.Size = new System.Drawing.Size(222, 24);
            this.miQryTransfer.Text = "商品別異動記錄查詢";
            this.miQryTransfer.Click += new System.EventHandler(this.miQryTransfer_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(219, 6);
            // 
            // miRptStockList
            // 
            this.miRptStockList.Name = "miRptStockList";
            this.miRptStockList.Size = new System.Drawing.Size(222, 24);
            this.miRptStockList.Text = "庫存盤點表";
            this.miRptStockList.Click += new System.EventHandler(this.miRptStockList_Click);
            // 
            // miRptStockPostList
            // 
            this.miRptStockPostList.Name = "miRptStockPostList";
            this.miRptStockPostList.Size = new System.Drawing.Size(222, 24);
            this.miRptStockPostList.Text = "商品異動明細表";
            this.miRptStockPostList.Click += new System.EventHandler(this.miRptStockPostList_Click);
            // 
            // miRptStockPostGroup
            // 
            this.miRptStockPostGroup.Name = "miRptStockPostGroup";
            this.miRptStockPostGroup.Size = new System.Drawing.Size(222, 24);
            this.miRptStockPostGroup.Text = "商品異動彙總表";
            this.miRptStockPostGroup.Click += new System.EventHandler(this.miRptStockPostGroup_Click);
            // 
            // miRptDullSales
            // 
            this.miRptDullSales.Name = "miRptDullSales";
            this.miRptDullSales.Size = new System.Drawing.Size(222, 24);
            this.miRptDullSales.Text = "商品呆滯銷分析表";
            this.miRptDullSales.Click += new System.EventHandler(this.miRptDullSales_Click);
            // 
            // miWindows
            // 
            this.miWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCascad});
            this.miWindows.Name = "miWindows";
            this.miWindows.Size = new System.Drawing.Size(53, 24);
            this.miWindows.Text = "視窗";
            // 
            // miCascad
            // 
            this.miCascad.Name = "miCascad";
            this.miCascad.Size = new System.Drawing.Size(142, 24);
            this.miCascad.Text = "重疊顯示";
            this.miCascad.Click += new System.EventHandler(this.miCascad_Click);
            // 
            // miAdmin
            // 
            this.miAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDtnXINUsers,
            this.miDtnProgramAuthority,
            this.miDtnUserAuthority,
            this.ToolStripMenuItem8,
            this.miDtnPassword,
            this.ToolStripMenuItem9,
            this.miAbout});
            this.miAdmin.Name = "miAdmin";
            this.miAdmin.Size = new System.Drawing.Size(85, 24);
            this.miAdmin.Text = "系統管理";
            // 
            // miDtnXINUsers
            // 
            this.miDtnXINUsers.Name = "miDtnXINUsers";
            this.miDtnXINUsers.Size = new System.Drawing.Size(222, 24);
            this.miDtnXINUsers.Text = "使用者代碼維護";
            this.miDtnXINUsers.Click += new System.EventHandler(this.miDtnXINUsers_Click);
            // 
            // miDtnProgramAuthority
            // 
            this.miDtnProgramAuthority.Name = "miDtnProgramAuthority";
            this.miDtnProgramAuthority.Size = new System.Drawing.Size(222, 24);
            this.miDtnProgramAuthority.Text = "程式使用權限維護";
            this.miDtnProgramAuthority.Click += new System.EventHandler(this.miDtnProgramAuthority_Click);
            // 
            // miDtnUserAuthority
            // 
            this.miDtnUserAuthority.Name = "miDtnUserAuthority";
            this.miDtnUserAuthority.Size = new System.Drawing.Size(222, 24);
            this.miDtnUserAuthority.Text = "使用者執行權限維護";
            this.miDtnUserAuthority.Click += new System.EventHandler(this.miDtnUserAuthority_Click);
            // 
            // ToolStripMenuItem8
            // 
            this.ToolStripMenuItem8.Name = "ToolStripMenuItem8";
            this.ToolStripMenuItem8.Size = new System.Drawing.Size(219, 6);
            // 
            // miDtnPassword
            // 
            this.miDtnPassword.Name = "miDtnPassword";
            this.miDtnPassword.Size = new System.Drawing.Size(222, 24);
            this.miDtnPassword.Text = "使用者密碼變更";
            this.miDtnPassword.Click += new System.EventHandler(this.miDtnPassword_Click);
            // 
            // ToolStripMenuItem9
            // 
            this.ToolStripMenuItem9.Name = "ToolStripMenuItem9";
            this.ToolStripMenuItem9.Size = new System.Drawing.Size(219, 6);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(222, 24);
            this.miAbout.Text = "關於進銷存管理系統";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 399);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fmMain";
            this.Text = "進銷存管理系統";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmMain_FormClosing);
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel UserLabel;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem miBase;
        internal System.Windows.Forms.ToolStripMenuItem miDtnProduct;
        internal System.Windows.Forms.ToolStripMenuItem miDtnSupplier;
        internal System.Windows.Forms.ToolStripMenuItem miDtnCustomer;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem miRptProduct;
        internal System.Windows.Forms.ToolStripMenuItem miRptSupplier;
        internal System.Windows.Forms.ToolStripMenuItem miRptCustomer;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem10;
        internal System.Windows.Forms.ToolStripMenuItem miClose;
        internal System.Windows.Forms.ToolStripMenuItem miReceipt;
        internal System.Windows.Forms.ToolStripMenuItem miTxnReceipt;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem2;
        internal System.Windows.Forms.ToolStripMenuItem miRptReceiptList;
        internal System.Windows.Forms.ToolStripMenuItem miRptReceiptGroup;
        internal System.Windows.Forms.ToolStripMenuItem miRptReceiptRank;
        internal System.Windows.Forms.ToolStripMenuItem miRptReceiptYear;
        internal System.Windows.Forms.ToolStripMenuItem miDelivery;
        internal System.Windows.Forms.ToolStripMenuItem miTxnDelivery;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem3;
        internal System.Windows.Forms.ToolStripMenuItem miRptDeliveryList;
        internal System.Windows.Forms.ToolStripMenuItem miRptDeliveryGroup;
        internal System.Windows.Forms.ToolStripMenuItem miRptDeliveryRank;
        internal System.Windows.Forms.ToolStripMenuItem miRptDeliveryYear;
        internal System.Windows.Forms.ToolStripMenuItem miStock;
        internal System.Windows.Forms.ToolStripMenuItem miTxnTransfer;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem5;
        internal System.Windows.Forms.ToolStripMenuItem miRptStockList;
        internal System.Windows.Forms.ToolStripMenuItem miRptStockPostList;
        internal System.Windows.Forms.ToolStripMenuItem miRptStockPostGroup;
        internal System.Windows.Forms.ToolStripMenuItem miRptDullSales;
        internal System.Windows.Forms.ToolStripMenuItem miAdmin;
        internal System.Windows.Forms.ToolStripMenuItem miDtnXINUsers;
        internal System.Windows.Forms.ToolStripMenuItem miDtnProgramAuthority;
        internal System.Windows.Forms.ToolStripMenuItem miDtnUserAuthority;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem8;
        internal System.Windows.Forms.ToolStripMenuItem miDtnPassword;
        internal System.Windows.Forms.ToolStripSeparator ToolStripMenuItem9;
        internal System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStripMenuItem miQryTransfer;
        private System.Windows.Forms.ToolStripMenuItem miWindows;
        private System.Windows.Forms.ToolStripMenuItem miCascad;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;

    }
}

