namespace _10_07_01
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
            System.Windows.Forms.Label employeeNameLabel;
            System.Windows.Forms.Label employeeNoLabel;
            System.Windows.Forms.Label passwordCodeLabel;
            this.xINUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeNoTextBox = new System.Windows.Forms.TextBox();
            this.passwordCodeTextBox = new System.Windows.Forms.TextBox();
            employeeNameLabel = new System.Windows.Forms.Label();
            employeeNoLabel = new System.Windows.Forms.Label();
            passwordCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersBindingNavigator)).BeginInit();
            this.xINUsersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // xINUsersBindingSource
            // 
            this.xINUsersBindingSource.DataSource = typeof(_10_07_01.XINUsers);
            // 
            // xINUsersBindingNavigator
            // 
            this.xINUsersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.xINUsersBindingNavigator.BindingSource = this.xINUsersBindingSource;
            this.xINUsersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.xINUsersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
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
            this.xINUsersBindingNavigatorSaveItem});
            this.xINUsersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.xINUsersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.xINUsersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.xINUsersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.xINUsersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.xINUsersBindingNavigator.Name = "xINUsersBindingNavigator";
            this.xINUsersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.xINUsersBindingNavigator.Size = new System.Drawing.Size(305, 25);
            this.xINUsersBindingNavigator.TabIndex = 0;
            this.xINUsersBindingNavigator.Text = "bindingNavigator1";
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
            // xINUsersBindingNavigatorSaveItem
            // 
            this.xINUsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.xINUsersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("xINUsersBindingNavigatorSaveItem.Image")));
            this.xINUsersBindingNavigatorSaveItem.Name = "xINUsersBindingNavigatorSaveItem";
            this.xINUsersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.xINUsersBindingNavigatorSaveItem.Text = "儲存資料";
            this.xINUsersBindingNavigatorSaveItem.Click += new System.EventHandler(this.xINUsersBindingNavigatorSaveItem_Click);
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new System.Drawing.Point(16, 43);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new System.Drawing.Size(76, 16);
            employeeNameLabel.TabIndex = 1;
            employeeNameLabel.Text = "員工名稱:";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xINUsersBindingSource, "EmployeeName", true));
            this.employeeNameTextBox.Location = new System.Drawing.Point(140, 40);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(100, 27);
            this.employeeNameTextBox.TabIndex = 2;
            // 
            // employeeNoLabel
            // 
            employeeNoLabel.AutoSize = true;
            employeeNoLabel.Location = new System.Drawing.Point(16, 76);
            employeeNoLabel.Name = "employeeNoLabel";
            employeeNoLabel.Size = new System.Drawing.Size(76, 16);
            employeeNoLabel.TabIndex = 3;
            employeeNoLabel.Text = "員工代碼:";
            // 
            // employeeNoTextBox
            // 
            this.employeeNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xINUsersBindingSource, "EmployeeNo", true));
            this.employeeNoTextBox.Location = new System.Drawing.Point(140, 73);
            this.employeeNoTextBox.Name = "employeeNoTextBox";
            this.employeeNoTextBox.Size = new System.Drawing.Size(100, 27);
            this.employeeNoTextBox.TabIndex = 4;
            // 
            // passwordCodeLabel
            // 
            passwordCodeLabel.AutoSize = true;
            passwordCodeLabel.Location = new System.Drawing.Point(16, 109);
            passwordCodeLabel.Name = "passwordCodeLabel";
            passwordCodeLabel.Size = new System.Drawing.Size(44, 16);
            passwordCodeLabel.TabIndex = 5;
            passwordCodeLabel.Text = "密碼:";
            // 
            // passwordCodeTextBox
            // 
            this.passwordCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xINUsersBindingSource, "PasswordCode", true));
            this.passwordCodeTextBox.Location = new System.Drawing.Point(140, 106);
            this.passwordCodeTextBox.Name = "passwordCodeTextBox";
            this.passwordCodeTextBox.PasswordChar = '*';
            this.passwordCodeTextBox.Size = new System.Drawing.Size(100, 27);
            this.passwordCodeTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 150);
            this.Controls.Add(employeeNameLabel);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(employeeNoLabel);
            this.Controls.Add(this.employeeNoTextBox);
            this.Controls.Add(passwordCodeLabel);
            this.Controls.Add(this.passwordCodeTextBox);
            this.Controls.Add(this.xINUsersBindingNavigator);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "10-07-01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersBindingNavigator)).EndInit();
            this.xINUsersBindingNavigator.ResumeLayout(false);
            this.xINUsersBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox employeeNoTextBox;
        private System.Windows.Forms.TextBox passwordCodeTextBox;
    }
}

