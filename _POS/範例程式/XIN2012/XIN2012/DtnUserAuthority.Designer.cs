namespace XIN2012
{
    partial class fmDtnUserAuthority
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.xINUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeNoTextBox = new System.Windows.Forms.TextBox();
            this.userAuthorityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userAuthorityDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProgramName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            employeeNameLabel = new System.Windows.Forms.Label();
            employeeNoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAuthorityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAuthorityDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new System.Drawing.Point(40, 48);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new System.Drawing.Size(73, 20);
            employeeNameLabel.TabIndex = 0;
            employeeNameLabel.Text = "員工名稱";
            // 
            // employeeNoLabel
            // 
            employeeNoLabel.AutoSize = true;
            employeeNoLabel.Location = new System.Drawing.Point(40, 12);
            employeeNoLabel.Name = "employeeNoLabel";
            employeeNoLabel.Size = new System.Drawing.Size(73, 20);
            employeeNoLabel.TabIndex = 2;
            employeeNoLabel.Text = "員工代碼";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(employeeNameLabel);
            this.panel1.Controls.Add(this.employeeNameTextBox);
            this.panel1.Controls.Add(employeeNoLabel);
            this.panel1.Controls.Add(this.employeeNoTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 85);
            this.panel1.TabIndex = 2;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xINUsersBindingSource, "EmployeeName", true));
            this.employeeNameTextBox.Location = new System.Drawing.Point(120, 44);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.ReadOnly = true;
            this.employeeNameTextBox.Size = new System.Drawing.Size(188, 29);
            this.employeeNameTextBox.TabIndex = 1;
            this.employeeNameTextBox.TabStop = false;
            // 
            // xINUsersBindingSource
            // 
            this.xINUsersBindingSource.DataSource = typeof(XIN2012.XINUsers);
            // 
            // employeeNoTextBox
            // 
            this.employeeNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.xINUsersBindingSource, "EmployeeNo", true));
            this.employeeNoTextBox.Location = new System.Drawing.Point(120, 8);
            this.employeeNoTextBox.Name = "employeeNoTextBox";
            this.employeeNoTextBox.ReadOnly = true;
            this.employeeNoTextBox.Size = new System.Drawing.Size(188, 29);
            this.employeeNoTextBox.TabIndex = 3;
            this.employeeNoTextBox.TabStop = false;
            // 
            // userAuthorityBindingSource
            // 
            this.userAuthorityBindingSource.DataMember = "UserAuthority";
            this.userAuthorityBindingSource.DataSource = this.xINUsersBindingSource;
            // 
            // userAuthorityDataGridView
            // 
            this.userAuthorityDataGridView.AllowUserToAddRows = false;
            this.userAuthorityDataGridView.AllowUserToDeleteRows = false;
            this.userAuthorityDataGridView.AutoGenerateColumns = false;
            this.userAuthorityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userAuthorityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.colProgramName,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4});
            this.userAuthorityDataGridView.DataSource = this.userAuthorityBindingSource;
            this.userAuthorityDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userAuthorityDataGridView.Location = new System.Drawing.Point(0, 128);
            this.userAuthorityDataGridView.Name = "userAuthorityDataGridView";
            this.userAuthorityDataGridView.RowTemplate.Height = 24;
            this.userAuthorityDataGridView.Size = new System.Drawing.Size(860, 261);
            this.userAuthorityDataGridView.TabIndex = 2;
            this.userAuthorityDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.userAuthorityDataGridView_RowPrePaint);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProgramID";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "程式代碼";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // colProgramName
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colProgramName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colProgramName.HeaderText = "程式名稱";
            this.colProgramName.Name = "colProgramName";
            this.colProgramName.ReadOnly = true;
            this.colProgramName.Width = 200;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Run";
            this.dataGridViewCheckBoxColumn1.FalseValue = "false";
            this.dataGridViewCheckBoxColumn1.HeaderText = "執行";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.TrueValue = "true";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Append";
            this.dataGridViewCheckBoxColumn2.FalseValue = "false";
            this.dataGridViewCheckBoxColumn2.HeaderText = "新增";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.TrueValue = "true";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "Edit";
            this.dataGridViewCheckBoxColumn3.FalseValue = "false";
            this.dataGridViewCheckBoxColumn3.HeaderText = "修改";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            this.dataGridViewCheckBoxColumn3.TrueValue = "true";
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Report";
            this.dataGridViewCheckBoxColumn4.FalseValue = "false";
            this.dataGridViewCheckBoxColumn4.HeaderText = "報表";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            this.dataGridViewCheckBoxColumn4.TrueValue = "true";
            // 
            // fmDtnUserAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(860, 389);
            this.Controls.Add(this.userAuthorityDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "fmDtnUserAuthority";
            this.Text = "使用者執行權限維護";
            this.Load += new System.EventHandler(this.fmDtnUserAuthority_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.userAuthorityDataGridView, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xINUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAuthorityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAuthorityDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.BindingSource xINUsersBindingSource;
        private System.Windows.Forms.TextBox employeeNoTextBox;
        private System.Windows.Forms.BindingSource userAuthorityBindingSource;
        private System.Windows.Forms.DataGridView userAuthorityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProgramName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
    }
}
