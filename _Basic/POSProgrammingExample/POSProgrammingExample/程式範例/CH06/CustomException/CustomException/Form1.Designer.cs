namespace CustomException
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPWD = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(118, 37);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(127, 22);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼:";
            // 
            // txtPWD
            // 
            this.txtPWD.Location = new System.Drawing.Point(118, 77);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.Size = new System.Drawing.Size(127, 22);
            this.txtPWD.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(72, 127);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(83, 32);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(196, 127);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(75, 32);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "更改密碼";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 190);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPWD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "例外處理類別範例程式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPWD;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnChangePassword;
    }
}

