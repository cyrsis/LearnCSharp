﻿namespace RandomFileName
{
    partial class Frm_Main
    {
        /// <summary>
        /// 必需的設計器變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的資源。
        /// </summary>
        /// <param name="disposing">如果應釋放托管資源，為 true；否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 視窗設計器產生的程式碼

        /// <summary>
        /// 設計器支持所需的方法 - 不要
        /// 使用程式碼編輯器修改此方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_file = new System.Windows.Forms.Button();
            this.btn_Drictory = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(46, 30);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(75, 23);
            this.btn_file.TabIndex = 0;
            this.btn_file.Text = "建立檔案";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // btn_Drictory
            // 
            this.btn_Drictory.Location = new System.Drawing.Point(159, 30);
            this.btn_Drictory.Name = "btn_Drictory";
            this.btn_Drictory.Size = new System.Drawing.Size(75, 23);
            this.btn_Drictory.TabIndex = 1;
            this.btn_Drictory.Text = "建立資料夾";
            this.btn_Drictory.UseVisualStyleBackColor = true;
            this.btn_Drictory.Click += new System.EventHandler(this.btn_Drictory_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_file);
            this.groupBox1.Controls.Add(this.btn_Drictory);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 80);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "產生隨機檔案名稱或資料夾名稱";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.Button btn_Drictory;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

