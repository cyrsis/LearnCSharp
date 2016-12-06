namespace _02_09_01
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxQuantity = new System.Windows.Forms.TextBox();
            this.txtMinQuantity = new System.Windows.Forms.TextBox();
            this.txtAvgQuantity = new System.Windows.Forms.TextBox();
            this.txtTitleCount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAppraisal = new System.Windows.Forms.TextBox();
            this.txtSubBookID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(628, 264);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "最大銷量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "最小銷量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "平均銷量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(472, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "商品總數";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "銷售評價";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "售價說明";
            // 
            // txtMaxQuantity
            // 
            this.txtMaxQuantity.Location = new System.Drawing.Point(96, 284);
            this.txtMaxQuantity.Name = "txtMaxQuantity";
            this.txtMaxQuantity.ReadOnly = true;
            this.txtMaxQuantity.Size = new System.Drawing.Size(100, 27);
            this.txtMaxQuantity.TabIndex = 7;
            this.txtMaxQuantity.TabStop = false;
            // 
            // txtMinQuantity
            // 
            this.txtMinQuantity.Location = new System.Drawing.Point(96, 316);
            this.txtMinQuantity.Name = "txtMinQuantity";
            this.txtMinQuantity.ReadOnly = true;
            this.txtMinQuantity.Size = new System.Drawing.Size(100, 27);
            this.txtMinQuantity.TabIndex = 8;
            this.txtMinQuantity.TabStop = false;
            // 
            // txtAvgQuantity
            // 
            this.txtAvgQuantity.Location = new System.Drawing.Point(344, 284);
            this.txtAvgQuantity.Name = "txtAvgQuantity";
            this.txtAvgQuantity.ReadOnly = true;
            this.txtAvgQuantity.Size = new System.Drawing.Size(100, 27);
            this.txtAvgQuantity.TabIndex = 9;
            this.txtAvgQuantity.TabStop = false;
            // 
            // txtTitleCount
            // 
            this.txtTitleCount.Location = new System.Drawing.Point(548, 284);
            this.txtTitleCount.Name = "txtTitleCount";
            this.txtTitleCount.ReadOnly = true;
            this.txtTitleCount.Size = new System.Drawing.Size(100, 27);
            this.txtTitleCount.TabIndex = 10;
            this.txtTitleCount.TabStop = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(96, 348);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(552, 27);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.TabStop = false;
            // 
            // txtAppraisal
            // 
            this.txtAppraisal.Location = new System.Drawing.Point(548, 316);
            this.txtAppraisal.Name = "txtAppraisal";
            this.txtAppraisal.ReadOnly = true;
            this.txtAppraisal.Size = new System.Drawing.Size(100, 27);
            this.txtAppraisal.TabIndex = 12;
            this.txtAppraisal.TabStop = false;
            // 
            // txtSubBookID
            // 
            this.txtSubBookID.Location = new System.Drawing.Point(344, 316);
            this.txtSubBookID.Name = "txtSubBookID";
            this.txtSubBookID.ReadOnly = true;
            this.txtSubBookID.Size = new System.Drawing.Size(100, 27);
            this.txtSubBookID.TabIndex = 13;
            this.txtSubBookID.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "商品編號第2~5碼";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 389);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSubBookID);
            this.Controls.Add(this.txtAppraisal);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitleCount);
            this.Controls.Add(this.txtAvgQuantity);
            this.Controls.Add(this.txtMinQuantity);
            this.Controls.Add(this.txtMaxQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "02-09-01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxQuantity;
        private System.Windows.Forms.TextBox txtMinQuantity;
        private System.Windows.Forms.TextBox txtAvgQuantity;
        private System.Windows.Forms.TextBox txtTitleCount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAppraisal;
        private System.Windows.Forms.TextBox txtSubBookID;
        private System.Windows.Forms.Label label7;
    }
}

