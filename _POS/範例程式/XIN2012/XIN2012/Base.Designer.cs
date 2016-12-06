namespace XIN2012
{
    partial class fmBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmBase));
            this.BaseBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnFirst = new System.Windows.Forms.ToolStripButton();
            this.btnPrior = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnLast = new System.Windows.Forms.ToolStripButton();
            this.BindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAddNew = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveChange = new System.Windows.Forms.ToolStripButton();
            this.btnCancelEdit = new System.Windows.Forms.ToolStripButton();
            this.tbxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.BaseBindingNavigator)).BeginInit();
            this.BaseBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaseBindingNavigator
            // 
            this.BaseBindingNavigator.AddNewItem = null;
            this.BaseBindingNavigator.CountItem = null;
            this.BaseBindingNavigator.DeleteItem = null;
            this.BaseBindingNavigator.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BaseBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFirst,
            this.btnPrior,
            this.btnNext,
            this.btnLast,
            this.BindingNavigatorSeparator2,
            this.btnAddNew,
            this.btnEdit,
            this.btnDelete,
            this.ToolStripSeparator1,
            this.btnSaveChange,
            this.btnCancelEdit,
            this.tbxSearch,
            this.btnSearch,
            this.btnPrint});
            this.BaseBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.BaseBindingNavigator.MoveFirstItem = null;
            this.BaseBindingNavigator.MoveLastItem = null;
            this.BaseBindingNavigator.MoveNextItem = null;
            this.BaseBindingNavigator.MovePreviousItem = null;
            this.BaseBindingNavigator.Name = "BaseBindingNavigator";
            this.BaseBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.BaseBindingNavigator.PositionItem = null;
            this.BaseBindingNavigator.Size = new System.Drawing.Size(863, 43);
            this.BaseBindingNavigator.TabIndex = 1;
            this.BaseBindingNavigator.Text = "BindingNavigator1";
            // 
            // btnFirst
            // 
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(45, 40);
            this.btnFirst.Text = "首筆";
            this.btnFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrior
            // 
            this.btnPrior.Image = ((System.Drawing.Image)(resources.GetObject("btnPrior.Image")));
            this.btnPrior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrior.Name = "btnPrior";
            this.btnPrior.Size = new System.Drawing.Size(45, 40);
            this.btnPrior.Text = "前筆";
            this.btnPrior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrior.Click += new System.EventHandler(this.btnPrior_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(45, 40);
            this.btnNext.Text = "次筆";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(45, 40);
            this.btnLast.Text = "末筆";
            this.btnLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // BindingNavigatorSeparator2
            // 
            this.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2";
            this.BindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(45, 40);
            this.btnAddNew.Text = "新增";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 40);
            this.btnEdit.Text = "修改";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(45, 40);
            this.btnDelete.Text = "刪除";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveChange.Image")));
            this.btnSaveChange.ImageTransparentColor = System.Drawing.Color.Olive;
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(45, 40);
            this.btnSaveChange.Text = "儲存";
            this.btnSaveChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelEdit.Image")));
            this.btnCancelEdit.ImageTransparentColor = System.Drawing.Color.Olive;
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(45, 40);
            this.btnCancelEdit.Text = "取消";
            this.btnCancelEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(271, 43);
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Olive;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 40);
            this.btnSearch.Text = "查詢";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Olive;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(45, 40);
            this.btnPrint.Text = "列印";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // fmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 315);
            this.Controls.Add(this.BaseBindingNavigator);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fmBase";
            this.Text = "Base";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmBase_FormClosing);
            this.Load += new System.EventHandler(this.fmBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaseBindingNavigator)).EndInit();
            this.BaseBindingNavigator.ResumeLayout(false);
            this.BaseBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.BindingNavigator BaseBindingNavigator;
        internal System.Windows.Forms.ToolStripButton btnFirst;
        internal System.Windows.Forms.ToolStripButton btnPrior;
        internal System.Windows.Forms.ToolStripButton btnNext;
        internal System.Windows.Forms.ToolStripButton btnLast;
        internal System.Windows.Forms.ToolStripSeparator BindingNavigatorSeparator2;
        internal System.Windows.Forms.ToolStripButton btnAddNew;
        internal System.Windows.Forms.ToolStripButton btnEdit;
        internal System.Windows.Forms.ToolStripButton btnDelete;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton btnSaveChange;
        internal System.Windows.Forms.ToolStripButton btnCancelEdit;
        internal System.Windows.Forms.ToolStripTextBox tbxSearch;
        internal System.Windows.Forms.ToolStripButton btnSearch;
        internal System.Windows.Forms.ToolStripButton btnPrint;
    }
}