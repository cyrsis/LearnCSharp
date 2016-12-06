namespace interface_EX
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
            this.btnShipNew = new System.Windows.Forms.Button();
            this.btnStockNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShipNew
            // 
            this.btnShipNew.Location = new System.Drawing.Point(214, 47);
            this.btnShipNew.Name = "btnShipNew";
            this.btnShipNew.Size = new System.Drawing.Size(119, 52);
            this.btnShipNew.TabIndex = 0;
            this.btnShipNew.Text = "出貨單新增";
            this.btnShipNew.UseVisualStyleBackColor = true;
            this.btnShipNew.Click += new System.EventHandler(this.btnShipNew_Click);
            // 
            // btnStockNew
            // 
            this.btnStockNew.Location = new System.Drawing.Point(51, 47);
            this.btnStockNew.Name = "btnStockNew";
            this.btnStockNew.Size = new System.Drawing.Size(112, 52);
            this.btnStockNew.TabIndex = 1;
            this.btnStockNew.Text = "進貨單新增";
            this.btnStockNew.UseVisualStyleBackColor = true;
            this.btnStockNew.Click += new System.EventHandler(this.btnStockNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 142);
            this.Controls.Add(this.btnStockNew);
            this.Controls.Add(this.btnShipNew);
            this.Name = "Form1";
            this.Text = "介面多型範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShipNew;
        private System.Windows.Forms.Button btnStockNew;
    }
}

