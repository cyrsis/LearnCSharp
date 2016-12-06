namespace _10_06_06
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
            this.xINUsersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.xINUsersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.xINUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAppendOnly = new System.Windows.Forms.ToolStripButton();
            this.btnEntityState = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAcceptChanges = new System.Windows.Forms.ToolStripButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.xINUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colEmployeeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersBindingNavigator)).BeginInit();
            this.xINUsersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // xINUsersBindingNavigator
            // 
            this.xINUsersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.xINUsersBindingNavigator.BindingSource = this.xINUsersBindingSource;
            this.xINUsersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.xINUsersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.xINUsersBindingNavigator.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
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
            this.btnAppendOnly,
            this.toolStripSeparator1,
            this.btnEntityState,
            this.toolStripSeparator2,
            this.btnAcceptChanges});
            this.xINUsersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.xINUsersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.xINUsersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.xINUsersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.xINUsersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.xINUsersBindingNavigator.Name = "xINUsersBindingNavigator";
            this.xINUsersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.xINUsersBindingNavigator.Size = new System.Drawing.Size(614, 27);
            this.xINUsersBindingNavigator.TabIndex = 0;
            this.xINUsersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(34, 24);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 24);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // xINUsersBindingNavigatorSaveItem
            // 
            this.xINUsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.xINUsersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("xINUsersBindingNavigatorSaveItem.Image")));
            this.xINUsersBindingNavigatorSaveItem.Name = "xINUsersBindingNavigatorSaveItem";
            this.xINUsersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 24);
            this.xINUsersBindingNavigatorSaveItem.Text = "儲存資料";
            this.xINUsersBindingNavigatorSaveItem.Click += new System.EventHandler(this.xINUsersBindingNavigatorSaveItem_Click);
            // 
            // xINUsersDataGridView
            // 
            this.xINUsersDataGridView.AutoGenerateColumns = false;
            this.xINUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.xINUsersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colEmployeeNo,
            this.colEmployeeName});
            this.xINUsersDataGridView.DataSource = this.xINUsersBindingSource;
            this.xINUsersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xINUsersDataGridView.Location = new System.Drawing.Point(0, 27);
            this.xINUsersDataGridView.Name = "xINUsersDataGridView";
            this.xINUsersDataGridView.RowTemplate.Height = 24;
            this.xINUsersDataGridView.Size = new System.Drawing.Size(614, 322);
            this.xINUsersDataGridView.TabIndex = 9;
            // 
            // btnAppendOnly
            // 
            this.btnAppendOnly.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAppendOnly.Image = ((System.Drawing.Image)(resources.GetObject("btnAppendOnly.Image")));
            this.btnAppendOnly.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAppendOnly.Name = "btnAppendOnly";
            this.btnAppendOnly.Size = new System.Drawing.Size(93, 24);
            this.btnAppendOnly.Text = "AppendOnly";
            this.btnAppendOnly.Click += new System.EventHandler(this.btnAppendOnly_Click);
            // 
            // btnEntityState
            // 
            this.btnEntityState.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEntityState.Image = ((System.Drawing.Image)(resources.GetObject("btnEntityState.Image")));
            this.btnEntityState.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEntityState.Name = "btnEntityState";
            this.btnEntityState.Size = new System.Drawing.Size(79, 24);
            this.btnEntityState.Text = "EntityState";
            this.btnEntityState.Click += new System.EventHandler(this.btnEntityState_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btnAcceptChanges
            // 
            this.btnAcceptChanges.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAcceptChanges.Image = ((System.Drawing.Image)(resources.GetObject("btnAcceptChanges.Image")));
            this.btnAcceptChanges.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAcceptChanges.Name = "btnAcceptChanges";
            this.btnAcceptChanges.Size = new System.Drawing.Size(110, 24);
            this.btnAcceptChanges.Text = "AcceptChanges";
            this.btnAcceptChanges.Click += new System.EventHandler(this.btnAcceptChanges_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 217);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(614, 132);
            this.listBox1.TabIndex = 10;
            this.listBox1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 214);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(614, 3);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // xINUsersBindingSource
            // 
            this.xINUsersBindingSource.DataSource = typeof(_10_06_06.XINUsers);
            // 
            // colEmployeeNo
            // 
            this.colEmployeeNo.DataPropertyName = "EmployeeNo";
            this.colEmployeeNo.HeaderText = "員工代碼";
            this.colEmployeeNo.Name = "colEmployeeNo";
            this.colEmployeeNo.Width = 200;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.DataPropertyName = "EmployeeName";
            this.colEmployeeName.HeaderText = "員工名稱";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 349);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.xINUsersDataGridView);
            this.Controls.Add(this.xINUsersBindingNavigator);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "10-06-06";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersBindingNavigator)).EndInit();
            this.xINUsersBindingNavigator.ResumeLayout(false);
            this.xINUsersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btnAppendOnly;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnEntityState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAcceptChanges;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeName;
    }
}

