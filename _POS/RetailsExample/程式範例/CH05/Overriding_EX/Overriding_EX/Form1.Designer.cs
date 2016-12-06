namespace Overriding_EX
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
            this.btnParent = new System.Windows.Forms.Button();
            this.btnChild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnParent
            // 
            this.btnParent.Location = new System.Drawing.Point(35, 41);
            this.btnParent.Name = "btnParent";
            this.btnParent.Size = new System.Drawing.Size(120, 55);
            this.btnParent.TabIndex = 0;
            this.btnParent.Text = "父類別操作";
            this.btnParent.UseVisualStyleBackColor = true;
            this.btnParent.Click += new System.EventHandler(this.btnParent_Click);
            // 
            // btnChild
            // 
            this.btnChild.Location = new System.Drawing.Point(194, 41);
            this.btnChild.Name = "btnChild";
            this.btnChild.Size = new System.Drawing.Size(128, 55);
            this.btnChild.TabIndex = 1;
            this.btnChild.Text = "子類別操作";
            this.btnChild.UseVisualStyleBackColor = true;
            this.btnChild.Click += new System.EventHandler(this.btnChild_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 150);
            this.Controls.Add(this.btnChild);
            this.Controls.Add(this.btnParent);
            this.Name = "Form1";
            this.Text = "Overriding範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnParent;
        private System.Windows.Forms.Button btnChild;
    }
}

