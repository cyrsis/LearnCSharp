namespace MenuStrip_ex
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiStock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShip = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRMA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStock,
            this.tsmiShip,
            this.tsmiRMA,
            this.tsmiWindows});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiStock
            // 
            this.tsmiStock.Name = "tsmiStock";
            this.tsmiStock.Size = new System.Drawing.Size(43, 20);
            this.tsmiStock.Text = "進貨";
            this.tsmiStock.Click += new System.EventHandler(this.tsmiStock_Click);
            // 
            // tsmiShip
            // 
            this.tsmiShip.Name = "tsmiShip";
            this.tsmiShip.Size = new System.Drawing.Size(43, 20);
            this.tsmiShip.Text = "出貨";
            this.tsmiShip.Click += new System.EventHandler(this.tsmiShip_Click);
            // 
            // tsmiRMA
            // 
            this.tsmiRMA.Name = "tsmiRMA";
            this.tsmiRMA.Size = new System.Drawing.Size(43, 20);
            this.tsmiRMA.Text = "退貨";
            this.tsmiRMA.Click += new System.EventHandler(this.tsmiRMA_Click);
            // 
            // tsmiWindows
            // 
            this.tsmiWindows.Name = "tsmiWindows";
            this.tsmiWindows.Size = new System.Drawing.Size(43, 20);
            this.tsmiWindows.Text = "視窗";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 272);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MenuStrip範例程式";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiStock;
        private System.Windows.Forms.ToolStripMenuItem tsmiShip;
        private System.Windows.Forms.ToolStripMenuItem tsmiRMA;
        private System.Windows.Forms.ToolStripMenuItem tsmiWindows;

    }
}

