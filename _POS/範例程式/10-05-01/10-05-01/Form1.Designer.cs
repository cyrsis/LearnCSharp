namespace _10_05_01
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
            System.Windows.Forms.Label programIDLabel;
            System.Windows.Forms.Label programNameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.programsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.programsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.programsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.programIDTextBox = new System.Windows.Forms.TextBox();
            this.programNameTextBox = new System.Windows.Forms.TextBox();
            this.userAuthorityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userAuthorityDataGridView = new System.Windows.Forms.DataGridView();
            this.EmplNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmplName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.runDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.appendDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.editDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.reportDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            programIDLabel = new System.Windows.Forms.Label();
            programNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingNavigator)).BeginInit();
            this.programsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAuthorityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAuthorityDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // programsBindingSource
            // 
            this.programsBindingSource.DataSource = typeof(_10_05_01.Programs);
            // 
            // programsBindingNavigator
            // 
            this.programsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.programsBindingNavigator.BindingSource = this.programsBindingSource;
            this.programsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.programsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.programsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.programsBindingNavigatorSaveItem});
            this.programsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.programsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.programsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.programsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.programsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.programsBindingNavigator.Name = "programsBindingNavigator";
            this.programsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.programsBindingNavigator.Size = new System.Drawing.Size(537, 25);
            this.programsBindingNavigator.TabIndex = 0;
            this.programsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(28, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // programsBindingNavigatorSaveItem
            // 
            this.programsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.programsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("programsBindingNavigatorSaveItem.Image")));
            this.programsBindingNavigatorSaveItem.Name = "programsBindingNavigatorSaveItem";
            this.programsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.programsBindingNavigatorSaveItem.Text = "儲存資料";
            this.programsBindingNavigatorSaveItem.Click += new System.EventHandler(this.programsBindingNavigatorSaveItem_Click);
            // 
            // programIDLabel
            // 
            programIDLabel.AutoSize = true;
            programIDLabel.Location = new System.Drawing.Point(20, 44);
            programIDLabel.Name = "programIDLabel";
            programIDLabel.Size = new System.Drawing.Size(88, 16);
            programIDLabel.TabIndex = 1;
            programIDLabel.Text = "程式代碼：";
            // 
            // programIDTextBox
            // 
            this.programIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programsBindingSource, "ProgramID", true));
            this.programIDTextBox.Location = new System.Drawing.Point(112, 36);
            this.programIDTextBox.Name = "programIDTextBox";
            this.programIDTextBox.Size = new System.Drawing.Size(276, 27);
            this.programIDTextBox.TabIndex = 2;
            // 
            // programNameLabel
            // 
            programNameLabel.AutoSize = true;
            programNameLabel.Location = new System.Drawing.Point(20, 76);
            programNameLabel.Name = "programNameLabel";
            programNameLabel.Size = new System.Drawing.Size(88, 16);
            programNameLabel.TabIndex = 3;
            programNameLabel.Text = "程式名稱：";
            // 
            // programNameTextBox
            // 
            this.programNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programsBindingSource, "ProgramName", true));
            this.programNameTextBox.Location = new System.Drawing.Point(112, 72);
            this.programNameTextBox.Name = "programNameTextBox";
            this.programNameTextBox.Size = new System.Drawing.Size(276, 27);
            this.programNameTextBox.TabIndex = 4;
            // 
            // userAuthorityBindingSource
            // 
            this.userAuthorityBindingSource.DataMember = "UserAuthority";
            this.userAuthorityBindingSource.DataSource = this.programsBindingSource;
            // 
            // userAuthorityDataGridView
            // 
            this.userAuthorityDataGridView.AutoGenerateColumns = false;
            this.userAuthorityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userAuthorityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmplNo,
            this.EmplName,
            this.runDataGridViewCheckBoxColumn,
            this.appendDataGridViewCheckBoxColumn,
            this.editDataGridViewCheckBoxColumn,
            this.reportDataGridViewCheckBoxColumn});
            this.userAuthorityDataGridView.DataSource = this.userAuthorityBindingSource;
            this.userAuthorityDataGridView.Location = new System.Drawing.Point(20, 112);
            this.userAuthorityDataGridView.Name = "userAuthorityDataGridView";
            this.userAuthorityDataGridView.RowTemplate.Height = 24;
            this.userAuthorityDataGridView.Size = new System.Drawing.Size(504, 372);
            this.userAuthorityDataGridView.TabIndex = 5;
            this.userAuthorityDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.userAuthorityDataGridView_CellValidated);
            this.userAuthorityDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.userAuthorityDataGridView_CellValueChanged);
            this.userAuthorityDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.userAuthorityDataGridView_RowPrePaint);
            // 
            // EmplNo
            // 
            this.EmplNo.DataPropertyName = "EmployeeNo";
            this.EmplNo.HeaderText = "員工代碼";
            this.EmplNo.Name = "EmplNo";
            // 
            // EmplName
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EmplName.DefaultCellStyle = dataGridViewCellStyle1;
            this.EmplName.HeaderText = "員工姓名";
            this.EmplName.Name = "EmplName";
            this.EmplName.ReadOnly = true;
            // 
            // runDataGridViewCheckBoxColumn
            // 
            this.runDataGridViewCheckBoxColumn.DataPropertyName = "Run";
            this.runDataGridViewCheckBoxColumn.HeaderText = "執行";
            this.runDataGridViewCheckBoxColumn.Name = "runDataGridViewCheckBoxColumn";
            this.runDataGridViewCheckBoxColumn.Width = 60;
            // 
            // appendDataGridViewCheckBoxColumn
            // 
            this.appendDataGridViewCheckBoxColumn.DataPropertyName = "Append";
            this.appendDataGridViewCheckBoxColumn.HeaderText = "新增";
            this.appendDataGridViewCheckBoxColumn.Name = "appendDataGridViewCheckBoxColumn";
            this.appendDataGridViewCheckBoxColumn.Width = 60;
            // 
            // editDataGridViewCheckBoxColumn
            // 
            this.editDataGridViewCheckBoxColumn.DataPropertyName = "Edit";
            this.editDataGridViewCheckBoxColumn.HeaderText = "修改";
            this.editDataGridViewCheckBoxColumn.Name = "editDataGridViewCheckBoxColumn";
            this.editDataGridViewCheckBoxColumn.Width = 60;
            // 
            // reportDataGridViewCheckBoxColumn
            // 
            this.reportDataGridViewCheckBoxColumn.DataPropertyName = "Report";
            this.reportDataGridViewCheckBoxColumn.HeaderText = "報表";
            this.reportDataGridViewCheckBoxColumn.Name = "reportDataGridViewCheckBoxColumn";
            this.reportDataGridViewCheckBoxColumn.Width = 60;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 491);
            this.Controls.Add(this.userAuthorityDataGridView);
            this.Controls.Add(programIDLabel);
            this.Controls.Add(this.programIDTextBox);
            this.Controls.Add(programNameLabel);
            this.Controls.Add(this.programNameTextBox);
            this.Controls.Add(this.programsBindingNavigator);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "10-05-01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingNavigator)).EndInit();
            this.programsBindingNavigator.ResumeLayout(false);
            this.programsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAuthorityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAuthorityDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource programsBindingSource;
        private System.Windows.Forms.BindingNavigator programsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton programsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox programIDTextBox;
        private System.Windows.Forms.TextBox programNameTextBox;
        private System.Windows.Forms.BindingSource userAuthorityBindingSource;
        private System.Windows.Forms.DataGridView userAuthorityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmplNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmplName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn runDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn appendDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn editDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn reportDataGridViewCheckBoxColumn;
    }
}

