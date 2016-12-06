namespace _03_05_03
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
            this.txtSort = new System.Windows.Forms.TextBox();
            this.radioProductTable = new System.Windows.Forms.RadioButton();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.txtRowFilterValue = new System.Windows.Forms.TextBox();
            this.cboRowFilterColumn = new System.Windows.Forms.ComboBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.radioDeliveryTable = new System.Windows.Forms.RadioButton();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.btnApplyRowFilterAndSort = new System.Windows.Forms.Button();
            this.RadioButton8 = new System.Windows.Forms.RadioButton();
            this.RadioButton7 = new System.Windows.Forms.RadioButton();
            this.RadioButton4 = new System.Windows.Forms.RadioButton();
            this.txtRowFilter = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.RadioButton5 = new System.Windows.Forms.RadioButton();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.radioPrimaryKey = new System.Windows.Forms.RadioButton();
            this.radioDESC = new System.Windows.Forms.RadioButton();
            this.radioASC = new System.Windows.Forms.RadioButton();
            this.cboSortDataColumn = new System.Windows.Forms.ComboBox();
            this.radioCustomerTable = new System.Windows.Forms.RadioButton();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButton6 = new System.Windows.Forms.RadioButton();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.GroupBox5.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSort
            // 
            this.txtSort.Location = new System.Drawing.Point(552, 44);
            this.txtSort.Name = "txtSort";
            this.txtSort.ReadOnly = true;
            this.txtSort.Size = new System.Drawing.Size(360, 27);
            this.txtSort.TabIndex = 34;
            this.txtSort.TabStop = false;
            // 
            // radioProductTable
            // 
            this.radioProductTable.AutoSize = true;
            this.radioProductTable.Location = new System.Drawing.Point(156, 32);
            this.radioProductTable.Name = "radioProductTable";
            this.radioProductTable.Size = new System.Drawing.Size(106, 20);
            this.radioProductTable.TabIndex = 1;
            this.radioProductTable.Text = "商品資料表";
            this.radioProductTable.UseVisualStyleBackColor = true;
            this.radioProductTable.Click += new System.EventHandler(this.radioProductTable_Click);
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.btnAdd);
            this.GroupBox5.Controls.Add(this.btnClear);
            this.GroupBox5.Controls.Add(this.Label3);
            this.GroupBox5.Controls.Add(this.ListBox1);
            this.GroupBox5.Controls.Add(this.txtRowFilterValue);
            this.GroupBox5.Location = new System.Drawing.Point(16, 256);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(432, 140);
            this.GroupBox5.TabIndex = 30;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "RowFilter的Value";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(340, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 28);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(340, 64);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 28);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(16, 68);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(37, 16);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "IN->";
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 16;
            this.ListBox1.Location = new System.Drawing.Point(60, 64);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(272, 68);
            this.ListBox1.TabIndex = 13;
            // 
            // txtRowFilterValue
            // 
            this.txtRowFilterValue.Location = new System.Drawing.Point(16, 28);
            this.txtRowFilterValue.Name = "txtRowFilterValue";
            this.txtRowFilterValue.Size = new System.Drawing.Size(316, 27);
            this.txtRowFilterValue.TabIndex = 0;
            // 
            // cboRowFilterColumn
            // 
            this.cboRowFilterColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRowFilterColumn.FormattingEnabled = true;
            this.cboRowFilterColumn.Location = new System.Drawing.Point(8, 28);
            this.cboRowFilterColumn.Name = "cboRowFilterColumn";
            this.cboRowFilterColumn.Size = new System.Drawing.Size(416, 24);
            this.cboRowFilterColumn.TabIndex = 0;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.Location = new System.Drawing.Point(32, 24);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(34, 20);
            this.RadioButton1.TabIndex = 0;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = ">";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // radioDeliveryTable
            // 
            this.radioDeliveryTable.AutoSize = true;
            this.radioDeliveryTable.Location = new System.Drawing.Point(300, 32);
            this.radioDeliveryTable.Name = "radioDeliveryTable";
            this.radioDeliveryTable.Size = new System.Drawing.Size(122, 20);
            this.radioDeliveryTable.TabIndex = 2;
            this.radioDeliveryTable.Text = "出貨單資料表";
            this.radioDeliveryTable.UseVisualStyleBackColor = true;
            this.radioDeliveryTable.Click += new System.EventHandler(this.radioDeliveryTable_Click);
            // 
            // RadioButton3
            // 
            this.RadioButton3.AutoSize = true;
            this.RadioButton3.Location = new System.Drawing.Point(128, 24);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.Size = new System.Drawing.Size(34, 20);
            this.RadioButton3.TabIndex = 2;
            this.RadioButton3.Text = "=";
            this.RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(32, 52);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(42, 20);
            this.RadioButton2.TabIndex = 1;
            this.RadioButton2.Text = ">=";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // btnApplyRowFilterAndSort
            // 
            this.btnApplyRowFilterAndSort.Location = new System.Drawing.Point(16, 508);
            this.btnApplyRowFilterAndSort.Name = "btnApplyRowFilterAndSort";
            this.btnApplyRowFilterAndSort.Size = new System.Drawing.Size(436, 39);
            this.btnApplyRowFilterAndSort.TabIndex = 29;
            this.btnApplyRowFilterAndSort.Text = "套用RowFilter與Sort";
            this.btnApplyRowFilterAndSort.UseVisualStyleBackColor = true;
            this.btnApplyRowFilterAndSort.Click += new System.EventHandler(this.btnApplyRowFilterAndSort_Click);
            // 
            // RadioButton8
            // 
            this.RadioButton8.AutoSize = true;
            this.RadioButton8.Location = new System.Drawing.Point(328, 52);
            this.RadioButton8.Name = "RadioButton8";
            this.RadioButton8.Size = new System.Drawing.Size(54, 20);
            this.RadioButton8.TabIndex = 7;
            this.RadioButton8.Text = "Like";
            this.RadioButton8.UseVisualStyleBackColor = true;
            // 
            // RadioButton7
            // 
            this.RadioButton7.AutoSize = true;
            this.RadioButton7.Location = new System.Drawing.Point(328, 24);
            this.RadioButton7.Name = "RadioButton7";
            this.RadioButton7.Size = new System.Drawing.Size(42, 20);
            this.RadioButton7.TabIndex = 6;
            this.RadioButton7.Text = "IN";
            this.RadioButton7.UseVisualStyleBackColor = true;
            // 
            // RadioButton4
            // 
            this.RadioButton4.AutoSize = true;
            this.RadioButton4.Location = new System.Drawing.Point(128, 52);
            this.RadioButton4.Name = "RadioButton4";
            this.RadioButton4.Size = new System.Drawing.Size(34, 20);
            this.RadioButton4.TabIndex = 3;
            this.RadioButton4.Text = "<";
            this.RadioButton4.UseVisualStyleBackColor = true;
            // 
            // txtRowFilter
            // 
            this.txtRowFilter.Location = new System.Drawing.Point(548, 8);
            this.txtRowFilter.Name = "txtRowFilter";
            this.txtRowFilter.ReadOnly = true;
            this.txtRowFilter.Size = new System.Drawing.Size(364, 27);
            this.txtRowFilter.TabIndex = 33;
            this.txtRowFilter.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(508, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(37, 16);
            this.Label2.TabIndex = 32;
            this.Label2.Text = "Sort:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(472, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(73, 16);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "RowFilter:";
            // 
            // RadioButton5
            // 
            this.RadioButton5.AutoSize = true;
            this.RadioButton5.Location = new System.Drawing.Point(212, 24);
            this.RadioButton5.Name = "RadioButton5";
            this.RadioButton5.Size = new System.Drawing.Size(42, 20);
            this.RadioButton5.TabIndex = 4;
            this.RadioButton5.Text = "<=";
            this.RadioButton5.UseVisualStyleBackColor = true;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.radioPrimaryKey);
            this.GroupBox4.Controls.Add(this.radioDESC);
            this.GroupBox4.Controls.Add(this.radioASC);
            this.GroupBox4.Controls.Add(this.cboSortDataColumn);
            this.GroupBox4.Location = new System.Drawing.Point(16, 404);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(432, 96);
            this.GroupBox4.TabIndex = 28;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "排序欄位";
            // 
            // radioPrimaryKey
            // 
            this.radioPrimaryKey.AutoSize = true;
            this.radioPrimaryKey.Location = new System.Drawing.Point(316, 68);
            this.radioPrimaryKey.Name = "radioPrimaryKey";
            this.radioPrimaryKey.Size = new System.Drawing.Size(90, 20);
            this.radioPrimaryKey.TabIndex = 10;
            this.radioPrimaryKey.TabStop = true;
            this.radioPrimaryKey.Text = "主索引鍵";
            this.radioPrimaryKey.UseVisualStyleBackColor = true;
            // 
            // radioDESC
            // 
            this.radioDESC.AutoSize = true;
            this.radioDESC.Location = new System.Drawing.Point(180, 68);
            this.radioDESC.Name = "radioDESC";
            this.radioDESC.Size = new System.Drawing.Size(58, 20);
            this.radioDESC.TabIndex = 9;
            this.radioDESC.Text = "降冪";
            this.radioDESC.UseVisualStyleBackColor = true;
            // 
            // radioASC
            // 
            this.radioASC.AutoSize = true;
            this.radioASC.Checked = true;
            this.radioASC.Location = new System.Drawing.Point(20, 68);
            this.radioASC.Name = "radioASC";
            this.radioASC.Size = new System.Drawing.Size(58, 20);
            this.radioASC.TabIndex = 8;
            this.radioASC.TabStop = true;
            this.radioASC.Text = "升冪";
            this.radioASC.UseVisualStyleBackColor = true;
            // 
            // cboSortDataColumn
            // 
            this.cboSortDataColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSortDataColumn.FormattingEnabled = true;
            this.cboSortDataColumn.Location = new System.Drawing.Point(16, 32);
            this.cboSortDataColumn.Name = "cboSortDataColumn";
            this.cboSortDataColumn.Size = new System.Drawing.Size(404, 24);
            this.cboSortDataColumn.TabIndex = 7;
            // 
            // radioCustomerTable
            // 
            this.radioCustomerTable.AutoSize = true;
            this.radioCustomerTable.Checked = true;
            this.radioCustomerTable.Location = new System.Drawing.Point(12, 32);
            this.radioCustomerTable.Name = "radioCustomerTable";
            this.radioCustomerTable.Size = new System.Drawing.Size(106, 20);
            this.radioCustomerTable.TabIndex = 0;
            this.radioCustomerTable.TabStop = true;
            this.radioCustomerTable.Text = "客戶資料表";
            this.radioCustomerTable.UseVisualStyleBackColor = true;
            this.radioCustomerTable.Click += new System.EventHandler(this.radioCustomerTable_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(464, 80);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(448, 464);
            this.DataGridView1.TabIndex = 27;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.cboRowFilterColumn);
            this.GroupBox3.Location = new System.Drawing.Point(12, 88);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(436, 60);
            this.GroupBox3.TabIndex = 26;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "RowFilter欄位";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.radioDeliveryTable);
            this.GroupBox1.Controls.Add(this.radioProductTable);
            this.GroupBox1.Controls.Add(this.radioCustomerTable);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(436, 64);
            this.GroupBox1.TabIndex = 25;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "資料表";
            // 
            // RadioButton6
            // 
            this.RadioButton6.AutoSize = true;
            this.RadioButton6.Location = new System.Drawing.Point(212, 52);
            this.RadioButton6.Name = "RadioButton6";
            this.RadioButton6.Size = new System.Drawing.Size(42, 20);
            this.RadioButton6.TabIndex = 5;
            this.RadioButton6.Text = "<>";
            this.RadioButton6.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.RadioButton8);
            this.GroupBox2.Controls.Add(this.RadioButton7);
            this.GroupBox2.Controls.Add(this.RadioButton6);
            this.GroupBox2.Controls.Add(this.RadioButton5);
            this.GroupBox2.Controls.Add(this.RadioButton4);
            this.GroupBox2.Controls.Add(this.RadioButton3);
            this.GroupBox2.Controls.Add(this.RadioButton2);
            this.GroupBox2.Controls.Add(this.RadioButton1);
            this.GroupBox2.Location = new System.Drawing.Point(16, 160);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(432, 84);
            this.GroupBox2.TabIndex = 24;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "運算子";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 552);
            this.Controls.Add(this.txtSort);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.btnApplyRowFilterAndSort);
            this.Controls.Add(this.txtRowFilter);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.GroupBox2);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "03-05-03";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtSort;
        internal System.Windows.Forms.RadioButton radioProductTable;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.TextBox txtRowFilterValue;
        internal System.Windows.Forms.ComboBox cboRowFilterColumn;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.RadioButton radioDeliveryTable;
        internal System.Windows.Forms.RadioButton RadioButton3;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.Button btnApplyRowFilterAndSort;
        internal System.Windows.Forms.RadioButton RadioButton8;
        internal System.Windows.Forms.RadioButton RadioButton7;
        internal System.Windows.Forms.RadioButton RadioButton4;
        internal System.Windows.Forms.TextBox txtRowFilter;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.RadioButton RadioButton5;
        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.RadioButton radioPrimaryKey;
        internal System.Windows.Forms.RadioButton radioDESC;
        internal System.Windows.Forms.RadioButton radioASC;
        internal System.Windows.Forms.ComboBox cboSortDataColumn;
        internal System.Windows.Forms.RadioButton radioCustomerTable;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.RadioButton RadioButton6;
        internal System.Windows.Forms.GroupBox GroupBox2;
    }
}

