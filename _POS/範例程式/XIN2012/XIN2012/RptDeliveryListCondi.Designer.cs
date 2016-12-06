namespace XIN2012
{
    partial class fmRptDeliveryListCondi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmRptDeliveryListCondi));
            this.label3 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.BeginDate = new System.Windows.Forms.DateTimePicker();
            this.btnQryCustomer = new System.Windows.Forms.Button();
            this.attribNameTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(288, 188);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(408, 188);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "～";
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(356, 52);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(160, 29);
            this.EndDate.TabIndex = 69;
            // 
            // BeginDate
            // 
            this.BeginDate.Location = new System.Drawing.Point(148, 52);
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.Size = new System.Drawing.Size(160, 29);
            this.BeginDate.TabIndex = 68;
            // 
            // btnQryCustomer
            // 
            this.btnQryCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnQryCustomer.Image")));
            this.btnQryCustomer.Location = new System.Drawing.Point(268, 92);
            this.btnQryCustomer.Name = "btnQryCustomer";
            this.btnQryCustomer.Size = new System.Drawing.Size(40, 28);
            this.btnQryCustomer.TabIndex = 67;
            this.btnQryCustomer.TabStop = false;
            this.btnQryCustomer.UseVisualStyleBackColor = true;
            this.btnQryCustomer.Click += new System.EventHandler(this.btnQryCustomer_Click);
            // 
            // attribNameTextBox
            // 
            this.attribNameTextBox.Location = new System.Drawing.Point(316, 92);
            this.attribNameTextBox.Name = "attribNameTextBox";
            this.attribNameTextBox.ReadOnly = true;
            this.attribNameTextBox.Size = new System.Drawing.Size(200, 29);
            this.attribNameTextBox.TabIndex = 66;
            this.attribNameTextBox.TabStop = false;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.Location = new System.Drawing.Point(148, 92);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(112, 29);
            this.customerIDTextBox.TabIndex = 65;
            this.customerIDTextBox.Validated += new System.EventHandler(this.customerIDTextBox_Validated);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(236, 140);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 24);
            this.radioButton2.TabIndex = 64;
            this.radioButton2.Text = "出貨退回";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(152, 140);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 24);
            this.radioButton1.TabIndex = 63;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "出貨";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "客戶：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "出貨日期：";
            // 
            // fmRptDeliveryListCondi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(569, 272);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.BeginDate);
            this.Controls.Add(this.btnQryCustomer);
            this.Controls.Add(this.attribNameTextBox);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmRptDeliveryListCondi";
            this.Text = "出貨明細表條件輸入";
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.radioButton1, 0);
            this.Controls.SetChildIndex(this.radioButton2, 0);
            this.Controls.SetChildIndex(this.customerIDTextBox, 0);
            this.Controls.SetChildIndex(this.attribNameTextBox, 0);
            this.Controls.SetChildIndex(this.btnQryCustomer, 0);
            this.Controls.SetChildIndex(this.BeginDate, 0);
            this.Controls.SetChildIndex(this.EndDate, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker BeginDate;
        internal System.Windows.Forms.Button btnQryCustomer;
        private System.Windows.Forms.TextBox attribNameTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
