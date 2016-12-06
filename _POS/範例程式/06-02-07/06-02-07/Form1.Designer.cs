namespace _06_02_07
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cn = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.adapter = new System.Data.SqlClient.SqlDataAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gridUnchanged = new System.Windows.Forms.DataGridView();
            this.gridAdded = new System.Windows.Forms.DataGridView();
            this.gridOriginal = new System.Windows.Forms.DataGridView();
            this.gridCurrent = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioOverwriteChanges = new System.Windows.Forms.RadioButton();
            this.radioPreserveChanges = new System.Windows.Forms.RadioButton();
            this.radioUpsert = new System.Windows.Forms.RadioButton();
            this.dsXIN1 = new _06_02_07.dsXIN();
            this.btnFill = new System.Windows.Forms.Button();
            this.gridDeleted = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attribNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnchanged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCurrent)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsXIN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeleted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "原來的記錄：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "未修改的記錄：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "新增的記錄：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "修改前的記錄：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "修改後的記錄：";
            // 
            // cn
            // 
            this.cn.ConnectionString = "Data Source=BENNY-VAIO;Initial Catalog=XIN;Integrated Security=True";
            this.cn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT         CustomerID, AttribName\r\nFROM              Customer";
            this.sqlSelectCommand1.Connection = this.cn;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Customer] ([CustomerID], [AttribName]) VALUES (@CustomerID, @AttribN" +
    "ame);\r\nSELECT CustomerID, AttribName FROM Customer WHERE (CustomerID = @Customer" +
    "ID)";
            this.sqlInsertCommand1.Connection = this.cn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.VarChar, 0, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@AttribName", System.Data.SqlDbType.NVarChar, 0, "AttribName")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.cn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.VarChar, 0, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@AttribName", System.Data.SqlDbType.NVarChar, 0, "AttribName"),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AttribName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AttribName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AttribName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AttribName", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = "DELETE FROM [Customer] WHERE (([CustomerID] = @Original_CustomerID) AND ((@IsNull" +
    "_AttribName = 1 AND [AttribName] IS NULL) OR ([AttribName] = @Original_AttribNam" +
    "e)))";
            this.sqlDeleteCommand1.Connection = this.cn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_AttribName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "AttribName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_AttribName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AttribName", System.Data.DataRowVersion.Original, null)});
            // 
            // adapter
            // 
            this.adapter.DeleteCommand = this.sqlDeleteCommand1;
            this.adapter.InsertCommand = this.sqlInsertCommand1;
            this.adapter.SelectCommand = this.sqlSelectCommand1;
            this.adapter.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customer", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("AttribName", "AttribName")})});
            this.adapter.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.attribNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(268, 160);
            this.dataGridView1.TabIndex = 5;
            // 
            // gridUnchanged
            // 
            this.gridUnchanged.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUnchanged.Location = new System.Drawing.Point(16, 292);
            this.gridUnchanged.Name = "gridUnchanged";
            this.gridUnchanged.RowTemplate.Height = 24;
            this.gridUnchanged.Size = new System.Drawing.Size(272, 168);
            this.gridUnchanged.TabIndex = 6;
            // 
            // gridAdded
            // 
            this.gridAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAdded.Location = new System.Drawing.Point(316, 96);
            this.gridAdded.Name = "gridAdded";
            this.gridAdded.RowTemplate.Height = 24;
            this.gridAdded.Size = new System.Drawing.Size(268, 72);
            this.gridAdded.TabIndex = 7;
            // 
            // gridOriginal
            // 
            this.gridOriginal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOriginal.Location = new System.Drawing.Point(316, 192);
            this.gridOriginal.Name = "gridOriginal";
            this.gridOriginal.RowTemplate.Height = 24;
            this.gridOriginal.Size = new System.Drawing.Size(268, 68);
            this.gridOriginal.TabIndex = 8;
            // 
            // gridCurrent
            // 
            this.gridCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCurrent.Location = new System.Drawing.Point(316, 292);
            this.gridCurrent.Name = "gridCurrent";
            this.gridCurrent.RowTemplate.Height = 24;
            this.gridCurrent.Size = new System.Drawing.Size(268, 68);
            this.gridCurrent.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioUpsert);
            this.groupBox1.Controls.Add(this.radioPreserveChanges);
            this.groupBox1.Controls.Add(this.radioOverwriteChanges);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 56);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FillLoadOption";
            // 
            // radioOverwriteChanges
            // 
            this.radioOverwriteChanges.AutoSize = true;
            this.radioOverwriteChanges.Checked = true;
            this.radioOverwriteChanges.Location = new System.Drawing.Point(12, 28);
            this.radioOverwriteChanges.Name = "radioOverwriteChanges";
            this.radioOverwriteChanges.Size = new System.Drawing.Size(142, 20);
            this.radioOverwriteChanges.TabIndex = 0;
            this.radioOverwriteChanges.TabStop = true;
            this.radioOverwriteChanges.Text = "OverwriteChanges";
            this.radioOverwriteChanges.UseVisualStyleBackColor = true;
            // 
            // radioPreserveChanges
            // 
            this.radioPreserveChanges.AutoSize = true;
            this.radioPreserveChanges.Location = new System.Drawing.Point(176, 28);
            this.radioPreserveChanges.Name = "radioPreserveChanges";
            this.radioPreserveChanges.Size = new System.Drawing.Size(133, 20);
            this.radioPreserveChanges.TabIndex = 1;
            this.radioPreserveChanges.Text = "PreserveChanges";
            this.radioPreserveChanges.UseVisualStyleBackColor = true;
            // 
            // radioUpsert
            // 
            this.radioUpsert.AutoSize = true;
            this.radioUpsert.Location = new System.Drawing.Point(336, 28);
            this.radioUpsert.Name = "radioUpsert";
            this.radioUpsert.Size = new System.Drawing.Size(67, 20);
            this.radioUpsert.TabIndex = 2;
            this.radioUpsert.Text = "Upsert";
            this.radioUpsert.UseVisualStyleBackColor = true;
            // 
            // dsXIN1
            // 
            this.dsXIN1.DataSetName = "dsXIN";
            this.dsXIN1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnFill
            // 
            this.btnFill.Location = new System.Drawing.Point(452, 8);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(132, 56);
            this.btnFill.TabIndex = 11;
            this.btnFill.Text = "Fill";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // gridDeleted
            // 
            this.gridDeleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDeleted.Location = new System.Drawing.Point(320, 392);
            this.gridDeleted.Name = "gridDeleted";
            this.gridDeleted.RowTemplate.Height = 24;
            this.gridDeleted.Size = new System.Drawing.Size(268, 68);
            this.gridDeleted.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "刪除的記錄：";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.dsXIN1;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // attribNameDataGridViewTextBoxColumn
            // 
            this.attribNameDataGridViewTextBoxColumn.DataPropertyName = "AttribName";
            this.attribNameDataGridViewTextBoxColumn.HeaderText = "AttribName";
            this.attribNameDataGridViewTextBoxColumn.Name = "attribNameDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 470);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridDeleted);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridCurrent);
            this.Controls.Add(this.gridOriginal);
            this.Controls.Add(this.gridAdded);
            this.Controls.Add(this.gridUnchanged);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "06-02-07";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUnchanged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCurrent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsXIN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeleted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Data.SqlClient.SqlConnection cn;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter adapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView gridUnchanged;
        private System.Windows.Forms.DataGridView gridAdded;
        private System.Windows.Forms.DataGridView gridOriginal;
        private System.Windows.Forms.DataGridView gridCurrent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioUpsert;
        private System.Windows.Forms.RadioButton radioPreserveChanges;
        private System.Windows.Forms.RadioButton radioOverwriteChanges;
        private dsXIN dsXIN1;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DataGridView gridDeleted;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn attribNameDataGridViewTextBoxColumn;
    }
}

