namespace sisMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbStock = new System.Windows.Forms.ToolStripButton();
            this.tsbShip = new System.Windows.Forms.ToolStripButton();
            this.tsbRMA = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbStock,
            this.tsbShip,
            this.tsbRMA});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(498, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbStock
            // 
            this.tsbStock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbStock.Image = ((System.Drawing.Image)(resources.GetObject("tsbStock.Image")));
            this.tsbStock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStock.Name = "tsbStock";
            this.tsbStock.Size = new System.Drawing.Size(35, 22);
            this.tsbStock.Text = "進貨";
            this.tsbStock.Click += new System.EventHandler(this.tsbStock_Click);
            // 
            // tsbShip
            // 
            this.tsbShip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbShip.Image = ((System.Drawing.Image)(resources.GetObject("tsbShip.Image")));
            this.tsbShip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbShip.Name = "tsbShip";
            this.tsbShip.Size = new System.Drawing.Size(35, 22);
            this.tsbShip.Text = "出貨";
            this.tsbShip.Click += new System.EventHandler(this.tsbShip_Click);
            // 
            // tsbRMA
            // 
            this.tsbRMA.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRMA.Image = ((System.Drawing.Image)(resources.GetObject("tsbRMA.Image")));
            this.tsbRMA.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRMA.Name = "tsbRMA";
            this.tsbRMA.Size = new System.Drawing.Size(35, 22);
            this.tsbRMA.Text = "退貨";
            this.tsbRMA.Click += new System.EventHandler(this.tsbRMA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 161);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "超級進銷存系統MDI主表單";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbStock;
        private System.Windows.Forms.ToolStripButton tsbShip;
        private System.Windows.Forms.ToolStripButton tsbRMA;
    }
}

