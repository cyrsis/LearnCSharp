namespace XIN2012
{
    partial class fmDtnXINUsers
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
            System.Windows.Forms.Label employeeNameLabel;
            System.Windows.Forms.Label employeeNoLabel;
            System.Windows.Forms.Label passwordCodeLabel;
            this.xINUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.employeeNoTextBox = new System.Windows.Forms.TextBox();
            this.passwordCodeTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPasswordCodeLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordCodeTextBox = new System.Windows.Forms.TextBox();
            employeeNameLabel = new System.Windows.Forms.Label();
            employeeNoLabel = new System.Windows.Forms.Label();
            passwordCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new System.Drawing.Point(60, 96);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new System.Drawing.Size(73, 20);
            employeeNameLabel.TabIndex = 1;
            employeeNameLabel.Text = "員工名稱";
            // 
            // employeeNoLabel
            // 
            employeeNoLabel.AutoSize = true;
            employeeNoLabel.Location = new System.Drawing.Point(60, 56);
            employeeNoLabel.Name = "employeeNoLabel";
            employeeNoLabel.Size = new System.Drawing.Size(73, 20);
            employeeNoLabel.TabIndex = 3;
            employeeNoLabel.Text = "員工代碼";
            // 
            // passwordCodeLabel
            // 
            passwordCodeLabel.AutoSize = true;
            passwordCodeLabel.Location = new System.Drawing.Point(88, 136);
            passwordCodeLabel.Name = "passwordCodeLabel";
            passwordCodeLabel.Size = new System.Drawing.Size(41, 20);
            passwordCodeLabel.TabIndex = 5;
            passwordCodeLabel.Text = "密碼";
            // 
            // xINUsersBindingSource
            // 
            this.xINUsersBindingSource.DataSource = typeof(XIN2012.XINUsers);
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xINUsersBindingSource, "EmployeeName", true));
            this.employeeNameTextBox.Location = new System.Drawing.Point(136, 92);
            this.employeeNameTextBox.MaxLength = 10;
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(176, 29);
            this.employeeNameTextBox.TabIndex = 1;
            // 
            // employeeNoTextBox
            // 
            this.employeeNoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.employeeNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xINUsersBindingSource, "EmployeeNo", true));
            this.employeeNoTextBox.Location = new System.Drawing.Point(136, 52);
            this.employeeNoTextBox.MaxLength = 10;
            this.employeeNoTextBox.Name = "employeeNoTextBox";
            this.employeeNoTextBox.Size = new System.Drawing.Size(176, 29);
            this.employeeNoTextBox.TabIndex = 0;
            // 
            // passwordCodeTextBox
            // 
            this.passwordCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xINUsersBindingSource, "PasswordCode", true));
            this.passwordCodeTextBox.Location = new System.Drawing.Point(136, 132);
            this.passwordCodeTextBox.MaxLength = 10;
            this.passwordCodeTextBox.Name = "passwordCodeTextBox";
            this.passwordCodeTextBox.PasswordChar = '*';
            this.passwordCodeTextBox.Size = new System.Drawing.Size(176, 29);
            this.passwordCodeTextBox.TabIndex = 2;
            // 
            // ConfirmPasswordCodeLabel
            // 
            this.ConfirmPasswordCodeLabel.AutoSize = true;
            this.ConfirmPasswordCodeLabel.Location = new System.Drawing.Point(60, 176);
            this.ConfirmPasswordCodeLabel.Name = "ConfirmPasswordCodeLabel";
            this.ConfirmPasswordCodeLabel.Size = new System.Drawing.Size(73, 20);
            this.ConfirmPasswordCodeLabel.TabIndex = 7;
            this.ConfirmPasswordCodeLabel.Text = "確認密碼";
            // 
            // ConfirmPasswordCodeTextBox
            // 
            this.ConfirmPasswordCodeTextBox.Location = new System.Drawing.Point(136, 172);
            this.ConfirmPasswordCodeTextBox.MaxLength = 10;
            this.ConfirmPasswordCodeTextBox.Name = "ConfirmPasswordCodeTextBox";
            this.ConfirmPasswordCodeTextBox.PasswordChar = '*';
            this.ConfirmPasswordCodeTextBox.Size = new System.Drawing.Size(176, 29);
            this.ConfirmPasswordCodeTextBox.TabIndex = 3;
            // 
            // fmDtnXINUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(801, 216);
            this.Controls.Add(this.ConfirmPasswordCodeTextBox);
            this.Controls.Add(this.ConfirmPasswordCodeLabel);
            this.Controls.Add(employeeNameLabel);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(employeeNoLabel);
            this.Controls.Add(this.employeeNoTextBox);
            this.Controls.Add(passwordCodeLabel);
            this.Controls.Add(this.passwordCodeTextBox);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximumSize = new System.Drawing.Size(817, 254);
            this.MinimumSize = new System.Drawing.Size(817, 254);
            this.Name = "fmDtnXINUsers";
            this.Text = "使用者代碼維護";
            this.Load += new System.EventHandler(this.fmDtnXINUsers_Load);
            this.Controls.SetChildIndex(this.passwordCodeTextBox, 0);
            this.Controls.SetChildIndex(passwordCodeLabel, 0);
            this.Controls.SetChildIndex(this.employeeNoTextBox, 0);
            this.Controls.SetChildIndex(employeeNoLabel, 0);
            this.Controls.SetChildIndex(this.employeeNameTextBox, 0);
            this.Controls.SetChildIndex(employeeNameLabel, 0);
            this.Controls.SetChildIndex(this.ConfirmPasswordCodeLabel, 0);
            this.Controls.SetChildIndex(this.ConfirmPasswordCodeTextBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource xINUsersBindingSource;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox employeeNoTextBox;
        private System.Windows.Forms.TextBox passwordCodeTextBox;
        private System.Windows.Forms.Label ConfirmPasswordCodeLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordCodeTextBox;
    }
}
