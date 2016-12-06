namespace XIN2012
{
    partial class fmDtnProgramAuthority
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
            System.Windows.Forms.Label programIDLabel;
            System.Windows.Forms.Label programNameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.programsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.programIDTextBox = new System.Windows.Forms.TextBox();
            this.programNameTextBox = new System.Windows.Forms.TextBox();
            this.userAuthorityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userAuthorityDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            programIDLabel = new System.Windows.Forms.Label();
            programNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAuthorityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAuthorityDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // programIDLabel
            // 
            programIDLabel.AutoSize = true;
            programIDLabel.Location = new System.Drawing.Point(20, 16);
            programIDLabel.Name = "programIDLabel";
            programIDLabel.Size = new System.Drawing.Size(73, 20);
            programIDLabel.TabIndex = 0;
            programIDLabel.Text = "程式代碼";
            // 
            // programNameLabel
            // 
            programNameLabel.AutoSize = true;
            programNameLabel.Location = new System.Drawing.Point(20, 52);
            programNameLabel.Name = "programNameLabel";
            programNameLabel.Size = new System.Drawing.Size(73, 20);
            programNameLabel.TabIndex = 2;
            programNameLabel.Text = "程式名稱";
            // 
            // programsBindingSource
            // 
            this.programsBindingSource.DataSource = typeof(XIN2012.Programs);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(programIDLabel);
            this.panel1.Controls.Add(this.programIDTextBox);
            this.panel1.Controls.Add(programNameLabel);
            this.panel1.Controls.Add(this.programNameTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 97);
            this.panel1.TabIndex = 2;
            // 
            // programIDTextBox
            // 
            this.programIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programsBindingSource, "ProgramID", true));
            this.programIDTextBox.Location = new System.Drawing.Point(100, 12);
            this.programIDTextBox.Name = "programIDTextBox";
            this.programIDTextBox.ReadOnly = true;
            this.programIDTextBox.Size = new System.Drawing.Size(300, 29);
            this.programIDTextBox.TabIndex = 1;
            this.programIDTextBox.TabStop = false;
            // 
            // programNameTextBox
            // 
            this.programNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.programsBindingSource, "ProgramName", true));
            this.programNameTextBox.Location = new System.Drawing.Point(100, 48);
            this.programNameTextBox.Name = "programNameTextBox";
            this.programNameTextBox.ReadOnly = true;
            this.programNameTextBox.Size = new System.Drawing.Size(300, 29);
            this.programNameTextBox.TabIndex = 3;
            this.programNameTextBox.TabStop = false;
            // 
            // userAuthorityBindingSource
            // 
            this.userAuthorityBindingSource.DataMember = "UserAuthority";
            this.userAuthorityBindingSource.DataSource = this.programsBindingSource;
            this.userAuthorityBindingSource.Filter = "";
            // 
            // userAuthorityDataGridView
            // 
            this.userAuthorityDataGridView.AllowUserToAddRows = false;
            this.userAuthorityDataGridView.AllowUserToDeleteRows = false;
            this.userAuthorityDataGridView.AutoGenerateColumns = false;
            this.userAuthorityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userAuthorityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colEmployeeName,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4});
            this.userAuthorityDataGridView.DataSource = this.userAuthorityBindingSource;
            this.userAuthorityDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userAuthorityDataGridView.Location = new System.Drawing.Point(0, 140);
            this.userAuthorityDataGridView.Name = "userAuthorityDataGridView";
            this.userAuthorityDataGridView.RowTemplate.Height = 24;
            this.userAuthorityDataGridView.Size = new System.Drawing.Size(850, 276);
            this.userAuthorityDataGridView.TabIndex = 2;
            this.userAuthorityDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.userAuthorityDataGridView_RowPrePaint);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EmployeeNo";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "員工代碼";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // colEmployeeName
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colEmployeeName.DefaultCellStyle = dataGridViewCellStyle2;
            this.colEmployeeName.HeaderText = "員工名稱";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Width = 150;
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
            // fmDtnProgramAuthority
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(850, 416);
            this.Controls.Add(this.userAuthorityDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "fmDtnProgramAuthority";
            this.Text = "程式使用權限維護";
            this.Load += new System.EventHandler(this.DtnProgramAuthority_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.userAuthorityDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.programsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userAuthorityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAuthorityDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource programsBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox programIDTextBox;
        private System.Windows.Forms.TextBox programNameTextBox;
        private System.Windows.Forms.BindingSource userAuthorityBindingSource;
        private System.Windows.Forms.DataGridView userAuthorityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmployeeName;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
    }
}
