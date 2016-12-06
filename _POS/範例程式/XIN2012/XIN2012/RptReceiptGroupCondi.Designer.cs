namespace XIN2012
{
    partial class fmRptReceiptGroupCondi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmRptReceiptGroupCondi));
            this.label3 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.BeginDate = new System.Windows.Forms.DateTimePicker();
            this.btnQrySupplier = new System.Windows.Forms.Button();
            this.attribNameTextBox = new System.Windows.Forms.TextBox();
            this.supplierIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQryProduct = new System.Windows.Forms.Button();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(436, 176);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(552, 176);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "～";
            // 
            // EndDate
            // 
            this.EndDate.Location = new System.Drawing.Point(332, 32);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(160, 29);
            this.EndDate.TabIndex = 67;
            // 
            // BeginDate
            // 
            this.BeginDate.Location = new System.Drawing.Point(124, 32);
            this.BeginDate.Name = "BeginDate";
            this.BeginDate.Size = new System.Drawing.Size(160, 29);
            this.BeginDate.TabIndex = 66;
            // 
            // btnQrySupplier
            // 
            this.btnQrySupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnQrySupplier.Image")));
            this.btnQrySupplier.Location = new System.Drawing.Point(292, 72);
            this.btnQrySupplier.Name = "btnQrySupplier";
            this.btnQrySupplier.Size = new System.Drawing.Size(40, 28);
            this.btnQrySupplier.TabIndex = 65;
            this.btnQrySupplier.TabStop = false;
            this.btnQrySupplier.UseVisualStyleBackColor = true;
            this.btnQrySupplier.Click += new System.EventHandler(this.btnQrySupplier_Click);
            // 
            // attribNameTextBox
            // 
            this.attribNameTextBox.Location = new System.Drawing.Point(340, 72);
            this.attribNameTextBox.Name = "attribNameTextBox";
            this.attribNameTextBox.ReadOnly = true;
            this.attribNameTextBox.Size = new System.Drawing.Size(200, 29);
            this.attribNameTextBox.TabIndex = 64;
            this.attribNameTextBox.TabStop = false;
            // 
            // supplierIDTextBox
            // 
            this.supplierIDTextBox.Location = new System.Drawing.Point(124, 72);
            this.supplierIDTextBox.Name = "supplierIDTextBox";
            this.supplierIDTextBox.Size = new System.Drawing.Size(160, 29);
            this.supplierIDTextBox.TabIndex = 63;
            this.supplierIDTextBox.Validated += new System.EventHandler(this.supplierIDTextBox_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "廠商：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 61;
            this.label1.Text = "進貨日期：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "商品：";
            // 
            // btnQryProduct
            // 
            this.btnQryProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnQryProduct.Image")));
            this.btnQryProduct.Location = new System.Drawing.Point(292, 112);
            this.btnQryProduct.Name = "btnQryProduct";
            this.btnQryProduct.Size = new System.Drawing.Size(40, 28);
            this.btnQryProduct.TabIndex = 72;
            this.btnQryProduct.TabStop = false;
            this.btnQryProduct.UseVisualStyleBackColor = true;
            this.btnQryProduct.Click += new System.EventHandler(this.btnQryProduct_Click);
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(340, 112);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ReadOnly = true;
            this.productNameTextBox.Size = new System.Drawing.Size(316, 29);
            this.productNameTextBox.TabIndex = 71;
            this.productNameTextBox.TabStop = false;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.Location = new System.Drawing.Point(124, 112);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(160, 29);
            this.productIDTextBox.TabIndex = 70;
            this.productIDTextBox.Validated += new System.EventHandler(this.productIDTextBox_Validated);
            // 
            // fmRptReceiptGroupCondi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(707, 246);
            this.Controls.Add(this.btnQryProduct);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.BeginDate);
            this.Controls.Add(this.btnQrySupplier);
            this.Controls.Add(this.attribNameTextBox);
            this.Controls.Add(this.supplierIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmRptReceiptGroupCondi";
            this.Text = "進貨統計表條件輸入";
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.supplierIDTextBox, 0);
            this.Controls.SetChildIndex(this.attribNameTextBox, 0);
            this.Controls.SetChildIndex(this.btnQrySupplier, 0);
            this.Controls.SetChildIndex(this.BeginDate, 0);
            this.Controls.SetChildIndex(this.EndDate, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.productIDTextBox, 0);
            this.Controls.SetChildIndex(this.productNameTextBox, 0);
            this.Controls.SetChildIndex(this.btnQryProduct, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.DateTimePicker BeginDate;
        internal System.Windows.Forms.Button btnQrySupplier;
        private System.Windows.Forms.TextBox attribNameTextBox;
        private System.Windows.Forms.TextBox supplierIDTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnQryProduct;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productIDTextBox;
    }
}
