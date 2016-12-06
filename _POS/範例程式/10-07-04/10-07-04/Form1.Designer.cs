namespace _10_07_04
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
            System.Windows.Forms.Label employeeNoLabel;
            System.Windows.Forms.Label passwordCodeLabel;
            System.Windows.Forms.Label employeeNameLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.employeeNo2TextBox = new System.Windows.Forms.TextBox();
            this.passwordCode2TextBox = new System.Windows.Forms.TextBox();
            this.employeeName2TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordCode1TextBox = new System.Windows.Forms.TextBox();
            this.employeeNo1TextBox = new System.Windows.Forms.TextBox();
            this.employeeName1TextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            employeeNoLabel = new System.Windows.Forms.Label();
            passwordCodeLabel = new System.Windows.Forms.Label();
            employeeNameLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(employeeNoLabel);
            this.groupBox2.Controls.Add(passwordCodeLabel);
            this.groupBox2.Controls.Add(employeeNameLabel);
            this.groupBox2.Controls.Add(this.employeeNo2TextBox);
            this.groupBox2.Controls.Add(this.passwordCode2TextBox);
            this.groupBox2.Controls.Add(this.employeeName2TextBox);
            this.groupBox2.Location = new System.Drawing.Point(316, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 128);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "第二筆使用者記錄";
            // 
            // employeeNoLabel
            // 
            employeeNoLabel.AutoSize = true;
            employeeNoLabel.Location = new System.Drawing.Point(40, 36);
            employeeNoLabel.Name = "employeeNoLabel";
            employeeNoLabel.Size = new System.Drawing.Size(76, 16);
            employeeNoLabel.TabIndex = 12;
            employeeNoLabel.Text = "員工代碼:";
            // 
            // passwordCodeLabel
            // 
            passwordCodeLabel.AutoSize = true;
            passwordCodeLabel.Location = new System.Drawing.Point(40, 98);
            passwordCodeLabel.Name = "passwordCodeLabel";
            passwordCodeLabel.Size = new System.Drawing.Size(44, 16);
            passwordCodeLabel.TabIndex = 13;
            passwordCodeLabel.Text = "密碼:";
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new System.Drawing.Point(40, 68);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new System.Drawing.Size(76, 16);
            employeeNameLabel.TabIndex = 11;
            employeeNameLabel.Text = "員工名稱:";
            // 
            // employeeNo2TextBox
            // 
            this.employeeNo2TextBox.Location = new System.Drawing.Point(120, 28);
            this.employeeNo2TextBox.Name = "employeeNo2TextBox";
            this.employeeNo2TextBox.Size = new System.Drawing.Size(100, 27);
            this.employeeNo2TextBox.TabIndex = 14;
            // 
            // passwordCode2TextBox
            // 
            this.passwordCode2TextBox.Location = new System.Drawing.Point(120, 92);
            this.passwordCode2TextBox.Name = "passwordCode2TextBox";
            this.passwordCode2TextBox.Size = new System.Drawing.Size(100, 27);
            this.passwordCode2TextBox.TabIndex = 16;
            // 
            // employeeName2TextBox
            // 
            this.employeeName2TextBox.Location = new System.Drawing.Point(120, 60);
            this.employeeName2TextBox.Name = "employeeName2TextBox";
            this.employeeName2TextBox.Size = new System.Drawing.Size(100, 27);
            this.employeeName2TextBox.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passwordCode1TextBox);
            this.groupBox1.Controls.Add(this.employeeNo1TextBox);
            this.groupBox1.Controls.Add(this.employeeName1TextBox);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 128);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "第一筆使用者記錄";
            // 
            // passwordCode1TextBox
            // 
            this.passwordCode1TextBox.Location = new System.Drawing.Point(120, 92);
            this.passwordCode1TextBox.Name = "passwordCode1TextBox";
            this.passwordCode1TextBox.Size = new System.Drawing.Size(100, 27);
            this.passwordCode1TextBox.TabIndex = 6;
            // 
            // employeeNo1TextBox
            // 
            this.employeeNo1TextBox.Location = new System.Drawing.Point(120, 28);
            this.employeeNo1TextBox.Name = "employeeNo1TextBox";
            this.employeeNo1TextBox.Size = new System.Drawing.Size(100, 27);
            this.employeeNo1TextBox.TabIndex = 4;
            // 
            // employeeName1TextBox
            // 
            this.employeeName1TextBox.Location = new System.Drawing.Point(120, 60);
            this.employeeName1TextBox.Name = "employeeName1TextBox";
            this.employeeName1TextBox.Size = new System.Drawing.Size(100, 27);
            this.employeeName1TextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(40, 96);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 16);
            label3.TabIndex = 10;
            label3.Text = "密碼:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 16);
            label2.TabIndex = 9;
            label2.Text = "員工代碼:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(40, 68);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(76, 16);
            label1.TabIndex = 8;
            label1.Text = "員工名稱:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "新增-TransactionScope";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 215);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "10-07-04";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox employeeNo2TextBox;
        private System.Windows.Forms.TextBox passwordCode2TextBox;
        private System.Windows.Forms.TextBox employeeName2TextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passwordCode1TextBox;
        private System.Windows.Forms.TextBox employeeNo1TextBox;
        private System.Windows.Forms.TextBox employeeName1TextBox;
        private System.Windows.Forms.Button button1;
    }
}

