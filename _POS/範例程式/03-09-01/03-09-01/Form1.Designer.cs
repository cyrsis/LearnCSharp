namespace _03_09_01
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
            this.btnRejectChanges = new System.Windows.Forms.Button();
            this.btnAcceptChanges = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.DataGridViewDeleted = new System.Windows.Forms.DataGridView();
            this.DataGridViewCurrentRows = new System.Windows.Forms.DataGridView();
            this.DataGridViewModifiedCurrent = new System.Windows.Forms.DataGridView();
            this.DataGridViewUnchanged = new System.Windows.Forms.DataGridView();
            this.DataGridViewAdded = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDeleted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCurrentRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewModifiedCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUnchanged)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAdded)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRejectChanges
            // 
            this.btnRejectChanges.Location = new System.Drawing.Point(496, 48);
            this.btnRejectChanges.Name = "btnRejectChanges";
            this.btnRejectChanges.Size = new System.Drawing.Size(140, 32);
            this.btnRejectChanges.TabIndex = 35;
            this.btnRejectChanges.Text = "RejectChanges";
            this.btnRejectChanges.UseVisualStyleBackColor = true;
            this.btnRejectChanges.Click += new System.EventHandler(this.btnRejectChanges_Click);
            // 
            // btnAcceptChanges
            // 
            this.btnAcceptChanges.Location = new System.Drawing.Point(496, 8);
            this.btnAcceptChanges.Name = "btnAcceptChanges";
            this.btnAcceptChanges.Size = new System.Drawing.Size(140, 32);
            this.btnAcceptChanges.TabIndex = 34;
            this.btnAcceptChanges.Text = "AcceptChanges";
            this.btnAcceptChanges.UseVisualStyleBackColor = true;
            this.btnAcceptChanges.Click += new System.EventHandler(this.btnAcceptChanges_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(24, 256);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(40, 16);
            this.Label5.TabIndex = 33;
            this.Label5.Text = "修改";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 432);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(56, 16);
            this.Label4.TabIndex = 32;
            this.Label4.Text = "未異動";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(24, 344);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(40, 16);
            this.Label3.TabIndex = 31;
            this.Label3.Text = "刪除";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(28, 164);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 16);
            this.Label2.TabIndex = 30;
            this.Label2.Text = "新增";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(56, 16);
            this.Label1.TabIndex = 29;
            this.Label1.Text = "原資料";
            // 
            // DataGridViewDeleted
            // 
            this.DataGridViewDeleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewDeleted.Location = new System.Drawing.Point(72, 340);
            this.DataGridViewDeleted.Name = "DataGridViewDeleted";
            this.DataGridViewDeleted.ReadOnly = true;
            this.DataGridViewDeleted.RowTemplate.Height = 24;
            this.DataGridViewDeleted.Size = new System.Drawing.Size(412, 84);
            this.DataGridViewDeleted.TabIndex = 28;
            this.DataGridViewDeleted.TabStop = false;
            // 
            // DataGridViewCurrentRows
            // 
            this.DataGridViewCurrentRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewCurrentRows.Location = new System.Drawing.Point(72, 8);
            this.DataGridViewCurrentRows.Name = "DataGridViewCurrentRows";
            this.DataGridViewCurrentRows.RowTemplate.Height = 24;
            this.DataGridViewCurrentRows.Size = new System.Drawing.Size(412, 144);
            this.DataGridViewCurrentRows.TabIndex = 27;
            // 
            // DataGridViewModifiedCurrent
            // 
            this.DataGridViewModifiedCurrent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewModifiedCurrent.Location = new System.Drawing.Point(72, 252);
            this.DataGridViewModifiedCurrent.Name = "DataGridViewModifiedCurrent";
            this.DataGridViewModifiedCurrent.ReadOnly = true;
            this.DataGridViewModifiedCurrent.RowTemplate.Height = 24;
            this.DataGridViewModifiedCurrent.Size = new System.Drawing.Size(412, 80);
            this.DataGridViewModifiedCurrent.TabIndex = 26;
            this.DataGridViewModifiedCurrent.TabStop = false;
            // 
            // DataGridViewUnchanged
            // 
            this.DataGridViewUnchanged.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewUnchanged.Location = new System.Drawing.Point(72, 432);
            this.DataGridViewUnchanged.Name = "DataGridViewUnchanged";
            this.DataGridViewUnchanged.ReadOnly = true;
            this.DataGridViewUnchanged.RowTemplate.Height = 24;
            this.DataGridViewUnchanged.Size = new System.Drawing.Size(412, 116);
            this.DataGridViewUnchanged.TabIndex = 25;
            this.DataGridViewUnchanged.TabStop = false;
            // 
            // DataGridViewAdded
            // 
            this.DataGridViewAdded.AllowUserToAddRows = false;
            this.DataGridViewAdded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewAdded.Location = new System.Drawing.Point(72, 160);
            this.DataGridViewAdded.Name = "DataGridViewAdded";
            this.DataGridViewAdded.ReadOnly = true;
            this.DataGridViewAdded.RowTemplate.Height = 24;
            this.DataGridViewAdded.Size = new System.Drawing.Size(412, 84);
            this.DataGridViewAdded.TabIndex = 24;
            this.DataGridViewAdded.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 556);
            this.Controls.Add(this.btnRejectChanges);
            this.Controls.Add(this.btnAcceptChanges);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DataGridViewDeleted);
            this.Controls.Add(this.DataGridViewCurrentRows);
            this.Controls.Add(this.DataGridViewModifiedCurrent);
            this.Controls.Add(this.DataGridViewUnchanged);
            this.Controls.Add(this.DataGridViewAdded);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "03-09-01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewDeleted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCurrentRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewModifiedCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUnchanged)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAdded)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnRejectChanges;
        internal System.Windows.Forms.Button btnAcceptChanges;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView DataGridViewDeleted;
        internal System.Windows.Forms.DataGridView DataGridViewCurrentRows;
        internal System.Windows.Forms.DataGridView DataGridViewModifiedCurrent;
        internal System.Windows.Forms.DataGridView DataGridViewUnchanged;
        internal System.Windows.Forms.DataGridView DataGridViewAdded;
    }
}

