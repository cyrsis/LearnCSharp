namespace FormOverloading
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
            this.btnCustomerDetails = new System.Windows.Forms.Button();
            this.btnManufacturerDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomerDetails
            // 
            this.btnCustomerDetails.Location = new System.Drawing.Point(27, 52);
            this.btnCustomerDetails.Name = "btnCustomerDetails";
            this.btnCustomerDetails.Size = new System.Drawing.Size(154, 58);
            this.btnCustomerDetails.TabIndex = 0;
            this.btnCustomerDetails.Text = "客戶明細表";
            this.btnCustomerDetails.UseVisualStyleBackColor = true;
            this.btnCustomerDetails.Click += new System.EventHandler(this.btnCustomerDetails_Click);
            // 
            // btnManufacturerDetails
            // 
            this.btnManufacturerDetails.Location = new System.Drawing.Point(222, 52);
            this.btnManufacturerDetails.Name = "btnManufacturerDetails";
            this.btnManufacturerDetails.Size = new System.Drawing.Size(158, 58);
            this.btnManufacturerDetails.TabIndex = 1;
            this.btnManufacturerDetails.Text = "廠商明細表";
            this.btnManufacturerDetails.UseVisualStyleBackColor = true;
            this.btnManufacturerDetails.Click += new System.EventHandler(this.btnManufacturerDetails_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 153);
            this.Controls.Add(this.btnManufacturerDetails);
            this.Controls.Add(this.btnCustomerDetails);
            this.Name = "Form1";
            this.Text = "表單建構子多載範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerDetails;
        private System.Windows.Forms.Button btnManufacturerDetails;
    }
}

