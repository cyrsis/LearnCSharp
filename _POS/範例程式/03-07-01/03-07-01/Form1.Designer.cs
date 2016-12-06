namespace _03_07_01
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
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.btnFindRows = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnClearValue = new System.Windows.Forms.Button();
            this.btnClearField = new System.Windows.Forms.Button();
            this.btnAddValue = new System.Windows.Forms.Button();
            this.btnAddField = new System.Windows.Forms.Button();
            this.listValue = new System.Windows.Forms.ListBox();
            this.comboField = new System.Windows.Forms.ComboBox();
            this.listField = new System.Windows.Forms.ListBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 16;
            this.ListBox1.Location = new System.Drawing.Point(12, 480);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(656, 164);
            this.ListBox1.TabIndex = 56;
            // 
            // btnFindRows
            // 
            this.btnFindRows.Location = new System.Drawing.Point(12, 440);
            this.btnFindRows.Name = "btnFindRows";
            this.btnFindRows.Size = new System.Drawing.Size(656, 32);
            this.btnFindRows.TabIndex = 55;
            this.btnFindRows.Text = "FindRows";
            this.btnFindRows.UseVisualStyleBackColor = true;
            this.btnFindRows.Click += new System.EventHandler(this.btnFindRows_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(288, 32);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(296, 27);
            this.txtValue.TabIndex = 54;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(12, 160);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(656, 272);
            this.DataGridView1.TabIndex = 53;
            // 
            // btnClearValue
            // 
            this.btnClearValue.Location = new System.Drawing.Point(592, 76);
            this.btnClearValue.Name = "btnClearValue";
            this.btnClearValue.Size = new System.Drawing.Size(75, 32);
            this.btnClearValue.TabIndex = 52;
            this.btnClearValue.Text = "Clear";
            this.btnClearValue.UseVisualStyleBackColor = true;
            this.btnClearValue.Click += new System.EventHandler(this.btnClearValue_Click);
            // 
            // btnClearField
            // 
            this.btnClearField.Location = new System.Drawing.Point(188, 72);
            this.btnClearField.Name = "btnClearField";
            this.btnClearField.Size = new System.Drawing.Size(84, 32);
            this.btnClearField.TabIndex = 51;
            this.btnClearField.Text = "Clear";
            this.btnClearField.UseVisualStyleBackColor = true;
            this.btnClearField.Click += new System.EventHandler(this.btnClearField_Click);
            // 
            // btnAddValue
            // 
            this.btnAddValue.Location = new System.Drawing.Point(592, 32);
            this.btnAddValue.Name = "btnAddValue";
            this.btnAddValue.Size = new System.Drawing.Size(76, 36);
            this.btnAddValue.TabIndex = 50;
            this.btnAddValue.Text = "Add";
            this.btnAddValue.UseVisualStyleBackColor = true;
            this.btnAddValue.Click += new System.EventHandler(this.btnAddValue_Click);
            // 
            // btnAddField
            // 
            this.btnAddField.Location = new System.Drawing.Point(188, 32);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(84, 36);
            this.btnAddField.TabIndex = 49;
            this.btnAddField.Text = "Add";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // listValue
            // 
            this.listValue.FormattingEnabled = true;
            this.listValue.ItemHeight = 16;
            this.listValue.Location = new System.Drawing.Point(288, 64);
            this.listValue.Name = "listValue";
            this.listValue.Size = new System.Drawing.Size(296, 84);
            this.listValue.TabIndex = 48;
            // 
            // comboField
            // 
            this.comboField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboField.FormattingEnabled = true;
            this.comboField.Location = new System.Drawing.Point(8, 32);
            this.comboField.Name = "comboField";
            this.comboField.Size = new System.Drawing.Size(168, 24);
            this.comboField.TabIndex = 47;
            // 
            // listField
            // 
            this.listField.FormattingEnabled = true;
            this.listField.ItemHeight = 16;
            this.listField.Location = new System.Drawing.Point(8, 64);
            this.listField.Name = "listField";
            this.listField.Size = new System.Drawing.Size(168, 84);
            this.listField.TabIndex = 46;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(288, 8);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 16);
            this.Label2.TabIndex = 45;
            this.Label2.Text = "查詢的值";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(88, 16);
            this.Label1.TabIndex = 44;
            this.Label1.Text = "查詢的欄位";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 653);
            this.Controls.Add(this.ListBox1);
            this.Controls.Add(this.btnFindRows);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnClearValue);
            this.Controls.Add(this.btnClearField);
            this.Controls.Add(this.btnAddValue);
            this.Controls.Add(this.btnAddField);
            this.Controls.Add(this.listValue);
            this.Controls.Add(this.comboField);
            this.Controls.Add(this.listField);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "03-07-01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.Button btnFindRows;
        internal System.Windows.Forms.TextBox txtValue;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button btnClearValue;
        internal System.Windows.Forms.Button btnClearField;
        internal System.Windows.Forms.Button btnAddValue;
        internal System.Windows.Forms.Button btnAddField;
        internal System.Windows.Forms.ListBox listValue;
        internal System.Windows.Forms.ComboBox comboField;
        internal System.Windows.Forms.ListBox listField;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
    }
}

