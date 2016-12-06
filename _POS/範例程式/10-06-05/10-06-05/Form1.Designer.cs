namespace _10_06_05
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xINUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xINUsersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.xINUsersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEntityState = new System.Windows.Forms.ToolStripButton();
            this.xINUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.colEmployeeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioAppendOnly = new System.Windows.Forms.RadioButton();
            this.radioOverwriteChanges = new System.Windows.Forms.RadioButton();
            this.radioPreserveChanges = new System.Windows.Forms.RadioButton();
            this.radioNoTracking = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersBindingNavigator)).BeginInit();
            this.xINUsersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // xINUsersBindingSource
            // 
            this.xINUsersBindingSource.DataSource = typeof(_10_06_05.XINUsers);
            // 
            // xINUsersBindingNavigator
            // 
            this.xINUsersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.xINUsersBindingNavigator.BindingSource = this.xINUsersBindingSource;
            this.xINUsersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.xINUsersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.xINUsersBindingNavigator.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xINUsersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.xINUsersBindingNavigatorSaveItem,
            this.btnLoad,
            this.toolStripSeparator1,
            this.btnEntityState});
            this.xINUsersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.xINUsersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.xINUsersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.xINUsersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.xINUsersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.xINUsersBindingNavigator.Name = "xINUsersBindingNavigator";
            this.xINUsersBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.xINUsersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.xINUsersBindingNavigator.Size = new System.Drawing.Size(558, 29);
            this.xINUsersBindingNavigator.TabIndex = 0;
            this.xINUsersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 26);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 29);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 26);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 29);
            // 
            // xINUsersBindingNavigatorSaveItem
            // 
            this.xINUsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.xINUsersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("xINUsersBindingNavigatorSaveItem.Image")));
            this.xINUsersBindingNavigatorSaveItem.Name = "xINUsersBindingNavigatorSaveItem";
            this.xINUsersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 26);
            this.xINUsersBindingNavigatorSaveItem.Text = "儲存資料";
            this.xINUsersBindingNavigatorSaveItem.Click += new System.EventHandler(this.xINUsersBindingNavigatorSaveItem_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(77, 26);
            this.btnLoad.Text = "載入資料";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 29);
            // 
            // btnEntityState
            // 
            this.btnEntityState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEntityState.Image = ((System.Drawing.Image)(resources.GetObject("btnEntityState.Image")));
            this.btnEntityState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEntityState.Name = "btnEntityState";
            this.btnEntityState.Size = new System.Drawing.Size(95, 26);
            this.btnEntityState.Text = "EntityState";
            this.btnEntityState.Click += new System.EventHandler(this.btnEntityState_Click);
            // 
            // xINUsersDataGridView
            // 
            this.xINUsersDataGridView.AutoGenerateColumns = false;
            this.xINUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xINUsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployeeNo,
            this.colEmployeeName});
            this.xINUsersDataGridView.DataSource = this.xINUsersBindingSource;
            this.xINUsersDataGridView.Location = new System.Drawing.Point(8, 76);
            this.xINUsersDataGridView.Name = "xINUsersDataGridView";
            this.xINUsersDataGridView.RowTemplate.Height = 24;
            this.xINUsersDataGridView.Size = new System.Drawing.Size(272, 204);
            this.xINUsersDataGridView.TabIndex = 3;
            this.xINUsersDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.xINUsersDataGridView_CellEnter);
            // 
            // colEmployeeNo
            // 
            this.colEmployeeNo.DataPropertyName = "EmployeeNo";
            this.colEmployeeNo.HeaderText = "員工代碼";
            this.colEmployeeNo.Name = "colEmployeeNo";
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.DataPropertyName = "EmployeeName";
            this.colEmployeeName.HeaderText = "員工名稱";
            this.colEmployeeName.Name = "colEmployeeName";
            // 
            // radioAppendOnly
            // 
            this.radioAppendOnly.AutoSize = true;
            this.radioAppendOnly.Checked = true;
            this.radioAppendOnly.Location = new System.Drawing.Point(12, 44);
            this.radioAppendOnly.Name = "radioAppendOnly";
            this.radioAppendOnly.Size = new System.Drawing.Size(107, 20);
            this.radioAppendOnly.TabIndex = 4;
            this.radioAppendOnly.TabStop = true;
            this.radioAppendOnly.Text = "AppendOnly";
            this.radioAppendOnly.UseVisualStyleBackColor = true;
            // 
            // radioOverwriteChanges
            // 
            this.radioOverwriteChanges.AutoSize = true;
            this.radioOverwriteChanges.Location = new System.Drawing.Point(136, 44);
            this.radioOverwriteChanges.Name = "radioOverwriteChanges";
            this.radioOverwriteChanges.Size = new System.Drawing.Size(142, 20);
            this.radioOverwriteChanges.TabIndex = 5;
            this.radioOverwriteChanges.Text = "OverwriteChanges";
            this.radioOverwriteChanges.UseVisualStyleBackColor = true;
            // 
            // radioPreserveChanges
            // 
            this.radioPreserveChanges.AutoSize = true;
            this.radioPreserveChanges.Location = new System.Drawing.Point(292, 44);
            this.radioPreserveChanges.Name = "radioPreserveChanges";
            this.radioPreserveChanges.Size = new System.Drawing.Size(133, 20);
            this.radioPreserveChanges.TabIndex = 6;
            this.radioPreserveChanges.Text = "PreserveChanges";
            this.radioPreserveChanges.UseVisualStyleBackColor = true;
            // 
            // radioNoTracking
            // 
            this.radioNoTracking.AutoSize = true;
            this.radioNoTracking.Location = new System.Drawing.Point(444, 44);
            this.radioNoTracking.Name = "radioNoTracking";
            this.radioNoTracking.Size = new System.Drawing.Size(101, 20);
            this.radioNoTracking.TabIndex = 7;
            this.radioNoTracking.Text = "NoTracking";
            this.radioNoTracking.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 76);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(260, 204);
            this.textBox1.TabIndex = 8;
            this.textBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 287);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioNoTracking);
            this.Controls.Add(this.radioPreserveChanges);
            this.Controls.Add(this.radioOverwriteChanges);
            this.Controls.Add(this.radioAppendOnly);
            this.Controls.Add(this.xINUsersDataGridView);
            this.Controls.Add(this.xINUsersBindingNavigator);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "10-06-05";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersBindingNavigator)).EndInit();
            this.xINUsersBindingNavigator.ResumeLayout(false);
            this.xINUsersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource xINUsersBindingSource;
        private System.Windows.Forms.BindingNavigator xINUsersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton xINUsersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView xINUsersDataGridView;
        private System.Windows.Forms.ToolStripButton btnLoad;
        private System.Windows.Forms.RadioButton radioAppendOnly;
        private System.Windows.Forms.RadioButton radioOverwriteChanges;
        private System.Windows.Forms.RadioButton radioPreserveChanges;
        private System.Windows.Forms.RadioButton radioNoTracking;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEntityState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeName;
    }
}

