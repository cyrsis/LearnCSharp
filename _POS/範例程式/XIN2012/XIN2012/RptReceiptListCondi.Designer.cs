namespace XIN2012
{
    partial class fmRptReceiptListCondi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmRptReceiptListCondi));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.supplierIDTextBox = new System.Windows.Forms.TextBox();
            this.attribNameTextBox = new System.Windows.Forms.TextBox();
            this.btnQrySupplier = new System.Windows.Forms.Button();
            this.BeginDate = new System.Windows.Forms.DateTimePicker();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(272, 180);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(388, 180);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "進貨日期：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "廠商：";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(128, 132);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "進貨";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(212, 132);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 24);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "進貨退出";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // supplierIDTextBox
            // 
            this.supplierIDTextBox.Location = new System.Drawing.Point(124, 84);
            this.supplierIDTextBox.Name = "supplierIDTextBox";
            this.supplierIDTextBox.Size = new System.Drawing.Size(112, 29);
            this.supplierIDTextBox.TabIndex = 6;
            this.supplierIDTextBox.Validated += new System.EventHandler(this.supplierIDTextBox_Validated);
            // 
            // attribNameTextBox
            // 
            this.attribNameTextBox.Location = new System.Drawing.Point(292, 84);
            this.attribNameTextBox.Name = "attribNameTextBox";
            this.attribNameTextBox.ReadOnly = true;
            this.attribNameTextBox.Size = new System.Drawing.Size(200, 29);
            this.attribNameTextBox.TabIndex = 7;
            this.attribNameTextBox.TabStop = false;
            // 
            // btnQrySupplier
            // 
            this.btnQrySupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnQrySupplier.Image")));
            this.btnQrySupplier.Location = new System.Drawing.Point(244, 84);
            this.btnQrySupplier.Name = "btnQrySupplier";
            this.btnQrySupplier.Size = new System.Drawing.Size(40, 28);
            this.btnQrySupplier.TabIndex = 57;
            this.btnQrySupplier.TabStop = false;
            this.btnQrySupplier.UseVisualStyleBackColor = true;
            this.btnQrySupplier.Click += new System.EventHandler(this.btnQrySupplier_Click);
            // 
            // BeginDate
            // 
            this.BeginDate.Location = new System.Drawing.Point(124, 44);
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.Size = new System.Drawing.Size(160, 29);
            this.BeginDate.TabIndex = 58;
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(332, 44);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(160, 29);
            this.EndDate.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "～";
            // 
            // fmRptReceiptListCondi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(540, 248);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.BeginDate);
            this.Controls.Add(this.btnQrySupplier);
            this.Controls.Add(this.attribNameTextBox);
            this.Controls.Add(this.supplierIDTextBox);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmRptReceiptListCondi";
            this.Text = "進貨明細表條件輸入";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.radioButton1, 0);
            this.Controls.SetChildIndex(this.radioButton2, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.supplierIDTextBox, 0);
            this.Controls.SetChildIndex(this.attribNameTextBox, 0);
            this.Controls.SetChildIndex(this.btnQrySupplier, 0);
            this.Controls.SetChildIndex(this.BeginDate, 0);
            this.Controls.SetChildIndex(this.EndDate, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox supplierIDTextBox;
        private System.Windows.Forms.TextBox attribNameTextBox;
        internal System.Windows.Forms.Button btnQrySupplier;
        private System.Windows.Forms.DateTimePicker BeginDate;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label3;
    }
}
