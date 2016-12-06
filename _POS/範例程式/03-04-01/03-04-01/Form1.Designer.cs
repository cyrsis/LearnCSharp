namespace _03_04_01
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
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFindValue = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.comboFindDataColumn = new System.Windows.Forms.ComboBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveFilter = new System.Windows.Forms.Button();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveSort = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.radioDESC = new System.Windows.Forms.RadioButton();
            this.radioASC = new System.Windows.Forms.RadioButton();
            this.Label7 = new System.Windows.Forms.Label();
            this.comboSortDataColumn = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnEndEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnMoveLast = new System.Windows.Forms.Button();
            this.btnMoveNext = new System.Windows.Forms.Button();
            this.btnMovePrevious = new System.Windows.Forms.Button();
            this.btnMoveFirst = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.txtFindValue);
            this.GroupBox4.Controls.Add(this.btnFind);
            this.GroupBox4.Controls.Add(this.Label9);
            this.GroupBox4.Controls.Add(this.Label8);
            this.GroupBox4.Controls.Add(this.comboFindDataColumn);
            this.GroupBox4.Location = new System.Drawing.Point(12, 404);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(208, 136);
            this.GroupBox4.TabIndex = 110;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "計錄尋找";
            // 
            // txtFindValue
            // 
            this.txtFindValue.Location = new System.Drawing.Point(60, 60);
            this.txtFindValue.Name = "txtFindValue";
            this.txtFindValue.Size = new System.Drawing.Size(140, 27);
            this.txtFindValue.TabIndex = 5;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(116, 96);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(83, 28);
            this.btnFind.TabIndex = 59;
            this.btnFind.Text = "尋找";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(12, 64);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(24, 16);
            this.Label9.TabIndex = 4;
            this.Label9.Text = "值";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(12, 32);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(40, 16);
            this.Label8.TabIndex = 3;
            this.Label8.Text = "欄位";
            // 
            // comboFindDataColumn
            // 
            this.comboFindDataColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFindDataColumn.FormattingEnabled = true;
            this.comboFindDataColumn.Location = new System.Drawing.Point(60, 28);
            this.comboFindDataColumn.Name = "comboFindDataColumn";
            this.comboFindDataColumn.Size = new System.Drawing.Size(140, 24);
            this.comboFindDataColumn.TabIndex = 2;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.ListBox1);
            this.GroupBox3.Location = new System.Drawing.Point(500, 240);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(172, 156);
            this.GroupBox3.TabIndex = 109;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "ListChanged";
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 16;
            this.ListBox1.Location = new System.Drawing.Point(8, 28);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(160, 116);
            this.ListBox1.TabIndex = 0;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnRemoveFilter);
            this.GroupBox2.Controls.Add(this.txtFilter);
            this.GroupBox2.Controls.Add(this.btnFilter);
            this.GroupBox2.Location = new System.Drawing.Point(440, 404);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(236, 136);
            this.GroupBox2.TabIndex = 108;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "記錄篩選";
            // 
            // btnRemoveFilter
            // 
            this.btnRemoveFilter.Location = new System.Drawing.Point(16, 96);
            this.btnRemoveFilter.Name = "btnRemoveFilter";
            this.btnRemoveFilter.Size = new System.Drawing.Size(100, 28);
            this.btnRemoveFilter.TabIndex = 12;
            this.btnRemoveFilter.Text = "移除篩選";
            this.btnRemoveFilter.UseVisualStyleBackColor = true;
            this.btnRemoveFilter.Click += new System.EventHandler(this.btnRemoveFilter_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(12, 36);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(216, 27);
            this.txtFilter.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(140, 96);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(83, 28);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "篩選";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(12, 276);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(72, 16);
            this.Label6.TabIndex = 106;
            this.Label6.Text = "公司名稱";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.btnRemoveSort);
            this.GroupBox1.Controls.Add(this.btnSort);
            this.GroupBox1.Controls.Add(this.radioDESC);
            this.GroupBox1.Controls.Add(this.radioASC);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.comboSortDataColumn);
            this.GroupBox1.Location = new System.Drawing.Point(228, 404);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(200, 136);
            this.GroupBox1.TabIndex = 107;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "記錄排序";
            // 
            // btnRemoveSort
            // 
            this.btnRemoveSort.Location = new System.Drawing.Point(16, 96);
            this.btnRemoveSort.Name = "btnRemoveSort";
            this.btnRemoveSort.Size = new System.Drawing.Size(84, 28);
            this.btnRemoveSort.TabIndex = 5;
            this.btnRemoveSort.Text = "移除排序";
            this.btnRemoveSort.UseVisualStyleBackColor = true;
            this.btnRemoveSort.Click += new System.EventHandler(this.btnRemoveSort_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(108, 96);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(88, 28);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "排序";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // radioDESC
            // 
            this.radioDESC.AutoSize = true;
            this.radioDESC.Location = new System.Drawing.Point(120, 68);
            this.radioDESC.Name = "radioDESC";
            this.radioDESC.Size = new System.Drawing.Size(58, 20);
            this.radioDESC.TabIndex = 3;
            this.radioDESC.Text = "降冪";
            this.radioDESC.UseVisualStyleBackColor = true;
            // 
            // radioASC
            // 
            this.radioASC.AutoSize = true;
            this.radioASC.Checked = true;
            this.radioASC.Location = new System.Drawing.Point(40, 68);
            this.radioASC.Name = "radioASC";
            this.radioASC.Size = new System.Drawing.Size(58, 20);
            this.radioASC.TabIndex = 2;
            this.radioASC.TabStop = true;
            this.radioASC.Text = "升冪";
            this.radioASC.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(8, 32);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(40, 16);
            this.Label7.TabIndex = 1;
            this.Label7.Text = "欄位";
            // 
            // comboSortDataColumn
            // 
            this.comboSortDataColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSortDataColumn.FormattingEnabled = true;
            this.comboSortDataColumn.Location = new System.Drawing.Point(68, 28);
            this.comboSortDataColumn.Name = "comboSortDataColumn";
            this.comboSortDataColumn.Size = new System.Drawing.Size(124, 24);
            this.comboSortDataColumn.TabIndex = 0;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(12, 376);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(40, 16);
            this.Label5.TabIndex = 105;
            this.Label5.Text = "地址";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 308);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(56, 16);
            this.Label4.TabIndex = 104;
            this.Label4.Text = "連絡人";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(284, 344);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 16);
            this.Label3.TabIndex = 103;
            this.Label3.Text = "傳真";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 340);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 16);
            this.Label2.TabIndex = 102;
            this.Label2.Text = "電話";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 244);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 16);
            this.Label1.TabIndex = 101;
            this.Label1.Text = "客戶編號";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(88, 368);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(404, 27);
            this.txtAddress.TabIndex = 100;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(88, 336);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(164, 27);
            this.txtPhone.TabIndex = 98;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(328, 336);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(164, 27);
            this.txtFax.TabIndex = 99;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(88, 304);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 27);
            this.txtContact.TabIndex = 97;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(88, 272);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(312, 27);
            this.txtCompanyName.TabIndex = 96;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(88, 240);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 27);
            this.txtCustomerID.TabIndex = 95;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(596, 8);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 28);
            this.btnRemove.TabIndex = 94;
            this.btnRemove.Text = "刪除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Location = new System.Drawing.Point(520, 8);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(72, 28);
            this.btnCancelEdit.TabIndex = 93;
            this.btnCancelEdit.Text = "取消";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnEndEdit
            // 
            this.btnEndEdit.Location = new System.Drawing.Point(440, 8);
            this.btnEndEdit.Name = "btnEndEdit";
            this.btnEndEdit.Size = new System.Drawing.Size(75, 28);
            this.btnEndEdit.TabIndex = 92;
            this.btnEndEdit.Text = "儲存";
            this.btnEndEdit.UseVisualStyleBackColor = true;
            this.btnEndEdit.Click += new System.EventHandler(this.btnEndEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(360, 8);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 28);
            this.btnAddNew.TabIndex = 91;
            this.btnAddNew.Text = "新增";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnMoveLast
            // 
            this.btnMoveLast.Location = new System.Drawing.Point(248, 8);
            this.btnMoveLast.Name = "btnMoveLast";
            this.btnMoveLast.Size = new System.Drawing.Size(88, 28);
            this.btnMoveLast.TabIndex = 90;
            this.btnMoveLast.Text = "最後一筆";
            this.btnMoveLast.UseVisualStyleBackColor = true;
            this.btnMoveLast.Click += new System.EventHandler(this.btnMoveLast_Click);
            // 
            // btnMoveNext
            // 
            this.btnMoveNext.Location = new System.Drawing.Point(168, 8);
            this.btnMoveNext.Name = "btnMoveNext";
            this.btnMoveNext.Size = new System.Drawing.Size(75, 28);
            this.btnMoveNext.TabIndex = 89;
            this.btnMoveNext.Text = "下一筆";
            this.btnMoveNext.UseVisualStyleBackColor = true;
            this.btnMoveNext.Click += new System.EventHandler(this.btnMoveNext_Click);
            // 
            // btnMovePrevious
            // 
            this.btnMovePrevious.Location = new System.Drawing.Point(88, 8);
            this.btnMovePrevious.Name = "btnMovePrevious";
            this.btnMovePrevious.Size = new System.Drawing.Size(75, 28);
            this.btnMovePrevious.TabIndex = 88;
            this.btnMovePrevious.Text = "上一筆";
            this.btnMovePrevious.UseVisualStyleBackColor = true;
            this.btnMovePrevious.Click += new System.EventHandler(this.btnMovePrevious_Click);
            // 
            // btnMoveFirst
            // 
            this.btnMoveFirst.Location = new System.Drawing.Point(8, 8);
            this.btnMoveFirst.Name = "btnMoveFirst";
            this.btnMoveFirst.Size = new System.Drawing.Size(75, 28);
            this.btnMoveFirst.TabIndex = 87;
            this.btnMoveFirst.Text = "第一筆";
            this.btnMoveFirst.UseVisualStyleBackColor = true;
            this.btnMoveFirst.Click += new System.EventHandler(this.btnMoveFirst_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(8, 44);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(664, 192);
            this.DataGridView1.TabIndex = 86;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 545);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnCancelEdit);
            this.Controls.Add(this.btnEndEdit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnMoveLast);
            this.Controls.Add(this.btnMoveNext);
            this.Controls.Add(this.btnMovePrevious);
            this.Controls.Add(this.btnMoveFirst);
            this.Controls.Add(this.DataGridView1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "03-04-01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox4;
        internal System.Windows.Forms.TextBox txtFindValue;
        internal System.Windows.Forms.Button btnFind;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ComboBox comboFindDataColumn;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.ListBox ListBox1;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnRemoveFilter;
        internal System.Windows.Forms.TextBox txtFilter;
        internal System.Windows.Forms.Button btnFilter;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnRemoveSort;
        internal System.Windows.Forms.Button btnSort;
        internal System.Windows.Forms.RadioButton radioDESC;
        internal System.Windows.Forms.RadioButton radioASC;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ComboBox comboSortDataColumn;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.TextBox txtPhone;
        internal System.Windows.Forms.TextBox txtFax;
        internal System.Windows.Forms.TextBox txtContact;
        internal System.Windows.Forms.TextBox txtCompanyName;
        internal System.Windows.Forms.TextBox txtCustomerID;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.Button btnCancelEdit;
        internal System.Windows.Forms.Button btnEndEdit;
        internal System.Windows.Forms.Button btnAddNew;
        internal System.Windows.Forms.Button btnMoveLast;
        internal System.Windows.Forms.Button btnMoveNext;
        internal System.Windows.Forms.Button btnMovePrevious;
        internal System.Windows.Forms.Button btnMoveFirst;
        internal System.Windows.Forms.DataGridView DataGridView1;
    }
}

