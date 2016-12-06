namespace XIN2012
{
    partial class fmDtnPassword
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
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.OrignalPasswordTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(192, 152);
            this.btnOK.TabIndex = 4;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(304, 152);
            this.btnCancel.TabIndex = 5;
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(196, 100);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(213, 29);
            this.ConfirmPasswordTextBox.TabIndex = 2;
            // 
            // NewPasswordTextBox
            // 
            this.NewPasswordTextBox.Location = new System.Drawing.Point(196, 64);
            this.NewPasswordTextBox.Name = "NewPasswordTextBox";
            this.NewPasswordTextBox.PasswordChar = '*';
            this.NewPasswordTextBox.Size = new System.Drawing.Size(213, 29);
            this.NewPasswordTextBox.TabIndex = 1;
            // 
            // OrignalPasswordTextBox
            // 
            this.OrignalPasswordTextBox.Location = new System.Drawing.Point(196, 28);
            this.OrignalPasswordTextBox.Name = "OrignalPasswordTextBox";
            this.OrignalPasswordTextBox.PasswordChar = '*';
            this.OrignalPasswordTextBox.Size = new System.Drawing.Size(213, 29);
            this.OrignalPasswordTextBox.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(36, 32);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(141, 20);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "請輸入原來的密碼:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(36, 104);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(157, 20);
            this.Label3.TabIndex = 23;
            this.Label3.Text = "請再確認一次新密碼:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(36, 68);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(121, 20);
            this.Label2.TabIndex = 22;
            this.Label2.Text = "請輸入新密碼：";
            // 
            // fmDtnPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(457, 211);
            this.Controls.Add(this.ConfirmPasswordTextBox);
            this.Controls.Add(this.NewPasswordTextBox);
            this.Controls.Add(this.OrignalPasswordTextBox);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Name = "fmDtnPassword";
            this.Text = "使用者密碼變更";
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.Label2, 0);
            this.Controls.SetChildIndex(this.Label3, 0);
            this.Controls.SetChildIndex(this.Label1, 0);
            this.Controls.SetChildIndex(this.OrignalPasswordTextBox, 0);
            this.Controls.SetChildIndex(this.NewPasswordTextBox, 0);
            this.Controls.SetChildIndex(this.ConfirmPasswordTextBox, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        internal System.Windows.Forms.TextBox NewPasswordTextBox;
        internal System.Windows.Forms.TextBox OrignalPasswordTextBox;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
    }
}
