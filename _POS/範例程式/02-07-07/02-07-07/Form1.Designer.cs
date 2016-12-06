namespace _02_07_07
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbNewRow = new System.Windows.Forms.RadioButton();
            this.rbBeginEdit = new System.Windows.Forms.RadioButton();
            this.rbEndEdit = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rbAcceptChanges = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbBeginEdit);
            this.groupBox1.Controls.Add(this.rbNewRow);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(168, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增/修改";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.rbEndEdit);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(164, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改選項";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.rbAcceptChanges);
            this.groupBox3.Location = new System.Drawing.Point(12, 208);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(164, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "認可更新";
            // 
            // rbNewRow
            // 
            this.rbNewRow.AutoSize = true;
            this.rbNewRow.Checked = true;
            this.rbNewRow.Location = new System.Drawing.Point(28, 32);
            this.rbNewRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbNewRow.Name = "rbNewRow";
            this.rbNewRow.Size = new System.Drawing.Size(58, 20);
            this.rbNewRow.TabIndex = 0;
            this.rbNewRow.TabStop = true;
            this.rbNewRow.Text = "新增";
            this.rbNewRow.UseVisualStyleBackColor = true;
            // 
            // rbBeginEdit
            // 
            this.rbBeginEdit.AutoSize = true;
            this.rbBeginEdit.Location = new System.Drawing.Point(28, 64);
            this.rbBeginEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbBeginEdit.Name = "rbBeginEdit";
            this.rbBeginEdit.Size = new System.Drawing.Size(58, 20);
            this.rbBeginEdit.TabIndex = 1;
            this.rbBeginEdit.TabStop = true;
            this.rbBeginEdit.Text = "修改";
            this.rbBeginEdit.UseVisualStyleBackColor = true;
            // 
            // rbEndEdit
            // 
            this.rbEndEdit.AutoSize = true;
            this.rbEndEdit.Checked = true;
            this.rbEndEdit.Location = new System.Drawing.Point(24, 32);
            this.rbEndEdit.Name = "rbEndEdit";
            this.rbEndEdit.Size = new System.Drawing.Size(86, 20);
            this.rbEndEdit.TabIndex = 0;
            this.rbEndEdit.TabStop = true;
            this.rbEndEdit.Text = "EndEdit()";
            this.rbEndEdit.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(24, 56);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(104, 20);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "CancelEdit()";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // rbAcceptChanges
            // 
            this.rbAcceptChanges.AutoSize = true;
            this.rbAcceptChanges.Checked = true;
            this.rbAcceptChanges.Location = new System.Drawing.Point(20, 32);
            this.rbAcceptChanges.Name = "rbAcceptChanges";
            this.rbAcceptChanges.Size = new System.Drawing.Size(134, 20);
            this.rbAcceptChanges.TabIndex = 0;
            this.rbAcceptChanges.TabStop = true;
            this.rbAcceptChanges.Text = "AcceptChanges()";
            this.rbAcceptChanges.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(20, 68);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(129, 20);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "RejectChanges()";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "執行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(188, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(420, 340);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 364);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "02-07-07";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbBeginEdit;
        private System.Windows.Forms.RadioButton rbNewRow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton rbEndEdit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton rbAcceptChanges;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

