namespace MyTest
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
            this.btnMy = new System.Windows.Forms.Button();
            this.btnMyString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMy
            // 
            this.btnMy.Location = new System.Drawing.Point(41, 39);
            this.btnMy.Name = "btnMy";
            this.btnMy.Size = new System.Drawing.Size(96, 52);
            this.btnMy.TabIndex = 0;
            this.btnMy.Text = "My";
            this.btnMy.UseVisualStyleBackColor = true;
            this.btnMy.Click += new System.EventHandler(this.btnMy_Click);
            // 
            // btnMyString
            // 
            this.btnMyString.Location = new System.Drawing.Point(180, 39);
            this.btnMyString.Name = "btnMyString";
            this.btnMyString.Size = new System.Drawing.Size(109, 52);
            this.btnMyString.TabIndex = 1;
            this.btnMyString.Text = "MyString";
            this.btnMyString.UseVisualStyleBackColor = true;
            this.btnMyString.Click += new System.EventHandler(this.btnMyString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 149);
            this.Controls.Add(this.btnMyString);
            this.Controls.Add(this.btnMy);
            this.Name = "Form1";
            this.Text = "My物件範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMy;
        private System.Windows.Forms.Button btnMyString;
    }
}

