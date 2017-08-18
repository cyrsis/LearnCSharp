namespace LastIndexOf_ex
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
            this.btnLastIndexOf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLastIndexOf
            // 
            this.btnLastIndexOf.Location = new System.Drawing.Point(64, 31);
            this.btnLastIndexOf.Name = "btnLastIndexOf";
            this.btnLastIndexOf.Size = new System.Drawing.Size(151, 51);
            this.btnLastIndexOf.TabIndex = 1;
            this.btnLastIndexOf.Text = "搜尋最後一個符合位置";
            this.btnLastIndexOf.UseVisualStyleBackColor = true;
            this.btnLastIndexOf.Click += new System.EventHandler(this.btnLastIndexOf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 113);
            this.Controls.Add(this.btnLastIndexOf);
            this.Name = "Form1";
            this.Text = "LastIndexOf範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLastIndexOf;
    }
}

