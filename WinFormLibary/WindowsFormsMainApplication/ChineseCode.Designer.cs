﻿namespace WindowsFormsMainApplication
{
    partial class ChineseCode
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
            this.btn_Get = new System.Windows.Forms.Button();
            this.txt_Chinese = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Num = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Get
            // 
            this.btn_Get.Location = new System.Drawing.Point(30, 56);
            this.btn_Get.Name = "btn_Get";
            this.btn_Get.Size = new System.Drawing.Size(75, 23);
            this.btn_Get.TabIndex = 0;
            this.btn_Get.Text = "得到區位碼";
            this.btn_Get.UseVisualStyleBackColor = true;
            this.btn_Get.Click += new System.EventHandler(this.btn_Get_Click);
            // 
            // txt_Chinese
            // 
            this.txt_Chinese.Location = new System.Drawing.Point(94, 20);
            this.txt_Chinese.Name = "txt_Chinese";
            this.txt_Chinese.Size = new System.Drawing.Size(100, 21);
            this.txt_Chinese.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "輸入中文字：";
            // 
            // txt_Num
            // 
            this.txt_Num.Location = new System.Drawing.Point(111, 58);
            this.txt_Num.Name = "txt_Num";
            this.txt_Num.Size = new System.Drawing.Size(83, 21);
            this.txt_Num.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Chinese);
            this.groupBox1.Controls.Add(this.txt_Num);
            this.groupBox1.Controls.Add(this.btn_Get);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 102);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "轉換";
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 128);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Main";
            this.Text = "中文字與區位碼的轉換";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Get;
        private System.Windows.Forms.TextBox txt_Chinese;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Num;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
