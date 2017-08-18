namespace SIS_EX
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
            this.btnShip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShip
            // 
            this.btnShip.Location = new System.Drawing.Point(104, 22);
            this.btnShip.Name = "btnShip";
            this.btnShip.Size = new System.Drawing.Size(155, 49);
            this.btnShip.TabIndex = 0;
            this.btnShip.Text = "執行出貨";
            this.btnShip.UseVisualStyleBackColor = true;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 98);
            this.Controls.Add(this.btnShip);
            this.Name = "Form1";
            this.Text = "類別設計-進銷存操作";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShip;
    }
}

