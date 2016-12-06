namespace _03_02_02
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
            this.radioNone = new System.Windows.Forms.RadioButton();
            this.radioSetDefault = new System.Windows.Forms.RadioButton();
            this.radioSetNull = new System.Windows.Forms.RadioButton();
            this.radioCascade = new System.Windows.Forms.RadioButton();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioNone
            // 
            this.radioNone.AutoSize = true;
            this.radioNone.Location = new System.Drawing.Point(328, 184);
            this.radioNone.Name = "radioNone";
            this.radioNone.Size = new System.Drawing.Size(60, 20);
            this.radioNone.TabIndex = 39;
            this.radioNone.Text = "None";
            this.radioNone.UseVisualStyleBackColor = true;
            this.radioNone.Click += new System.EventHandler(this.radioNone_Click);
            // 
            // radioSetDefault
            // 
            this.radioSetDefault.AutoSize = true;
            this.radioSetDefault.Location = new System.Drawing.Point(328, 148);
            this.radioSetDefault.Name = "radioSetDefault";
            this.radioSetDefault.Size = new System.Drawing.Size(91, 20);
            this.radioSetDefault.TabIndex = 38;
            this.radioSetDefault.Text = "SetDefault";
            this.radioSetDefault.UseVisualStyleBackColor = true;
            this.radioSetDefault.Click += new System.EventHandler(this.radioSetDefault_Click);
            // 
            // radioSetNull
            // 
            this.radioSetNull.AutoSize = true;
            this.radioSetNull.Location = new System.Drawing.Point(328, 104);
            this.radioSetNull.Name = "radioSetNull";
            this.radioSetNull.Size = new System.Drawing.Size(72, 20);
            this.radioSetNull.TabIndex = 37;
            this.radioSetNull.Text = "SetNull";
            this.radioSetNull.UseVisualStyleBackColor = true;
            this.radioSetNull.Click += new System.EventHandler(this.radioSetNull_Click);
            // 
            // radioCascade
            // 
            this.radioCascade.AutoSize = true;
            this.radioCascade.Checked = true;
            this.radioCascade.Location = new System.Drawing.Point(328, 64);
            this.radioCascade.Name = "radioCascade";
            this.radioCascade.Size = new System.Drawing.Size(78, 20);
            this.radioCascade.TabIndex = 36;
            this.radioCascade.TabStop = true;
            this.radioCascade.Text = "Cascade";
            this.radioCascade.UseVisualStyleBackColor = true;
            this.radioCascade.Click += new System.EventHandler(this.radioCascade_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(424, 12);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 16);
            this.Label2.TabIndex = 35;
            this.Label2.Text = "Delivery:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(16, 16);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(72, 16);
            this.Label1.TabIndex = 34;
            this.Label1.Text = "Customer:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(424, 36);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(332, 296);
            this.dataGridView2.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(300, 296);
            this.dataGridView1.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 347);
            this.Controls.Add(this.radioNone);
            this.Controls.Add(this.radioSetDefault);
            this.Controls.Add(this.radioSetNull);
            this.Controls.Add(this.radioCascade);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "03-02-02";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.RadioButton radioNone;
        internal System.Windows.Forms.RadioButton radioSetDefault;
        internal System.Windows.Forms.RadioButton radioSetNull;
        internal System.Windows.Forms.RadioButton radioCascade;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dataGridView2;
        internal System.Windows.Forms.DataGridView dataGridView1;
    }
}

