﻿namespace CompareTo_ex
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
            this.btnCompareTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompareTo
            // 
            this.btnCompareTo.Location = new System.Drawing.Point(79, 31);
            this.btnCompareTo.Name = "btnCompareTo";
            this.btnCompareTo.Size = new System.Drawing.Size(152, 47);
            this.btnCompareTo.TabIndex = 0;
            this.btnCompareTo.Text = "字串比較";
            this.btnCompareTo.UseVisualStyleBackColor = true;
            this.btnCompareTo.Click += new System.EventHandler(this.btnCompareTo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 115);
            this.Controls.Add(this.btnCompareTo);
            this.Name = "Form1";
            this.Text = "CompareTo範例程式";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCompareTo;
    }
}

