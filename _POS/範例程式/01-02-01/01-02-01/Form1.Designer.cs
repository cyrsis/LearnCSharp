namespace _01_02_01
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
            this.btnMessage = new System.Windows.Forms.Button();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnToString = new System.Windows.Forms.Button();
            this.btnAllErrors = new System.Windows.Forms.Button();
            this.btnNullReferenceException = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMessage
            // 
            this.btnMessage.Location = new System.Drawing.Point(28, 20);
            this.btnMessage.Name = "btnMessage";
            this.btnMessage.Size = new System.Drawing.Size(212, 36);
            this.btnMessage.TabIndex = 0;
            this.btnMessage.Text = "Message";
            this.btnMessage.UseVisualStyleBackColor = true;
            this.btnMessage.Click += new System.EventHandler(this.btnMessage_Click);
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(28, 64);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(212, 36);
            this.btnSource.TabIndex = 1;
            this.btnSource.Text = "Source";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // btnToString
            // 
            this.btnToString.Location = new System.Drawing.Point(28, 108);
            this.btnToString.Name = "btnToString";
            this.btnToString.Size = new System.Drawing.Size(212, 36);
            this.btnToString.TabIndex = 2;
            this.btnToString.Text = "ToString()";
            this.btnToString.UseVisualStyleBackColor = true;
            this.btnToString.Click += new System.EventHandler(this.btnToString_Click);
            // 
            // btnAllErrors
            // 
            this.btnAllErrors.Location = new System.Drawing.Point(28, 152);
            this.btnAllErrors.Name = "btnAllErrors";
            this.btnAllErrors.Size = new System.Drawing.Size(212, 36);
            this.btnAllErrors.TabIndex = 3;
            this.btnAllErrors.Text = "All Errors";
            this.btnAllErrors.UseVisualStyleBackColor = true;
            this.btnAllErrors.Click += new System.EventHandler(this.btnAllErrors_Click);
            // 
            // btnNullReferenceException
            // 
            this.btnNullReferenceException.Location = new System.Drawing.Point(28, 196);
            this.btnNullReferenceException.Name = "btnNullReferenceException";
            this.btnNullReferenceException.Size = new System.Drawing.Size(212, 36);
            this.btnNullReferenceException.TabIndex = 4;
            this.btnNullReferenceException.Text = "NullReferenceException";
            this.btnNullReferenceException.UseVisualStyleBackColor = true;
            this.btnNullReferenceException.Click += new System.EventHandler(this.btnNullReferenceException_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(28, 240);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(212, 36);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 244);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 27);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 294);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnNullReferenceException);
            this.Controls.Add(this.btnAllErrors);
            this.Controls.Add(this.btnToString);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.btnMessage);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "01-02-01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMessage;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnToString;
        private System.Windows.Forms.Button btnAllErrors;
        private System.Windows.Forms.Button btnNullReferenceException;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.TextBox textBox1;
    }
}

