namespace XIN2012
{
    partial class fmTxnTransfer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label transferTypeLabel;
            System.Windows.Forms.Label transferDateLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.transferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.transferTypeTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.transferIDLabel = new System.Windows.Forms.Label();
            this.transferDateTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.amountLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.transferDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transferDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.colTransferSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            commentLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            transferTypeLabel = new System.Windows.Forms.Label();
            transferDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transferBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transferDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(8, 12);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(41, 20);
            commentLabel.TabIndex = 3;
            commentLabel.Text = "備註";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 48);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(73, 20);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "異動說明";
            // 
            // transferTypeLabel
            // 
            transferTypeLabel.AutoSize = true;
            transferTypeLabel.Location = new System.Drawing.Point(24, 48);
            transferTypeLabel.Name = "transferTypeLabel";
            transferTypeLabel.Size = new System.Drawing.Size(57, 20);
            transferTypeLabel.TabIndex = 11;
            transferTypeLabel.Text = "異動別";
            // 
            // transferDateLabel
            // 
            transferDateLabel.AutoSize = true;
            transferDateLabel.Location = new System.Drawing.Point(12, 12);
            transferDateLabel.Name = "transferDateLabel";
            transferDateLabel.Size = new System.Drawing.Size(73, 20);
            transferDateLabel.TabIndex = 0;
            transferDateLabel.Text = "異動日期";
            // 
            // transferBindingSource
            // 
            this.transferBindingSource.DataSource = typeof(XIN2012.Transfer);
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transferBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(92, 8);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.ReadOnly = true;
            this.amountTextBox.Size = new System.Drawing.Size(120, 29);
            this.amountTextBox.TabIndex = 2;
            this.amountTextBox.TabStop = false;
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transferBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(56, 8);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(428, 84);
            this.commentTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transferBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(92, 44);
            this.descriptionTextBox.MaxLength = 20;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(328, 29);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // transferTypeTextBox
            // 
            this.transferTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transferBindingSource, "TransferType", true));
            this.transferTypeTextBox.Location = new System.Drawing.Point(88, 44);
            this.transferTypeTextBox.MaxLength = 1;
            this.transferTypeTextBox.Name = "transferTypeTextBox";
            this.transferTypeTextBox.Size = new System.Drawing.Size(28, 29);
            this.transferTypeTextBox.TabIndex = 12;
            this.transferTypeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.transferTypeTextBox_Validating);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(transferDateLabel);
            this.panel1.Controls.Add(this.transferDateTextBox);
            this.panel1.Controls.Add(descriptionLabel);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 81);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.transferIDLabel);
            this.panel2.Controls.Add(this.transferTypeTextBox);
            this.panel2.Controls.Add(transferTypeLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(656, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 81);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "(1:入庫 2:出庫)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "異動單號";
            // 
            // transferIDLabel
            // 
            this.transferIDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transferBindingSource, "TransferID", true));
            this.transferIDLabel.Location = new System.Drawing.Point(92, 12);
            this.transferIDLabel.Name = "transferIDLabel";
            this.transferIDLabel.Size = new System.Drawing.Size(128, 23);
            this.transferIDLabel.TabIndex = 1;
            this.transferIDLabel.Text = "transferIDLabel";
            // 
            // transferDateTextBox
            // 
            this.transferDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transferBindingSource, "TransferDate", true));
            this.transferDateTextBox.Location = new System.Drawing.Point(92, 8);
            this.transferDateTextBox.Name = "transferDateTextBox";
            this.transferDateTextBox.Size = new System.Drawing.Size(120, 29);
            this.transferDateTextBox.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.commentTextBox);
            this.panel3.Controls.Add(commentLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 326);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(896, 100);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.amountTextBox);
            this.panel4.Controls.Add(this.amountLabel);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(672, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 100);
            this.panel4.TabIndex = 5;
            // 
            // amountLabel
            // 
            this.amountLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transferBindingSource, "Amount", true));
            this.amountLabel.Location = new System.Drawing.Point(100, 12);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(100, 23);
            this.amountLabel.TabIndex = 4;
            this.amountLabel.Text = "amountLabel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "總計金額";
            // 
            // transferDetailsBindingSource
            // 
            this.transferDetailsBindingSource.DataMember = "TransferDetails";
            this.transferDetailsBindingSource.DataSource = this.transferBindingSource;
            // 
            // transferDetailsDataGridView
            // 
            this.transferDetailsDataGridView.AutoGenerateColumns = false;
            this.transferDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transferDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransferSeq,
            this.colSEQ,
            this.colProductID,
            this.colProductName,
            this.colQuantity,
            this.colUnit,
            this.colAmount});
            this.transferDetailsDataGridView.DataSource = this.transferDetailsBindingSource;
            this.transferDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transferDetailsDataGridView.Location = new System.Drawing.Point(0, 124);
            this.transferDetailsDataGridView.Name = "transferDetailsDataGridView";
            this.transferDetailsDataGridView.RowTemplate.Height = 24;
            this.transferDetailsDataGridView.Size = new System.Drawing.Size(896, 202);
            this.transferDetailsDataGridView.TabIndex = 22;
            this.transferDetailsDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.transferDetailsDataGridView_CellValidated);
            this.transferDetailsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.transferDetailsDataGridView_CellValidating);
            this.transferDetailsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.transferDetailsDataGridView_CellValueChanged);
            this.transferDetailsDataGridView.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.transferDetailsDataGridView_CellValueNeeded);
            this.transferDetailsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.transferDetailsDataGridView_DataError);
            this.transferDetailsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.transferDetailsDataGridView_DefaultValuesNeeded);
            this.transferDetailsDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.transferDetailsDataGridView_RowPrePaint);
            this.transferDetailsDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.transferDetailsDataGridView_RowsRemoved);
            this.transferDetailsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.transferDetailsDataGridView_UserDeletingRow);
            this.transferDetailsDataGridView.Enter += new System.EventHandler(this.transferDetailsDataGridView_Enter);
            this.transferDetailsDataGridView.Leave += new System.EventHandler(this.transferDetailsDataGridView_Leave);
            // 
            // colTransferSeq
            // 
            this.colTransferSeq.DataPropertyName = "Seq";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colTransferSeq.DefaultCellStyle = dataGridViewCellStyle7;
            this.colTransferSeq.HeaderText = "#";
            this.colTransferSeq.Name = "colTransferSeq";
            this.colTransferSeq.ReadOnly = true;
            this.colTransferSeq.Width = 50;
            // 
            // colSEQ
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colSEQ.DefaultCellStyle = dataGridViewCellStyle8;
            this.colSEQ.HeaderText = "#";
            this.colSEQ.Name = "colSEQ";
            this.colSEQ.ReadOnly = true;
            this.colSEQ.Width = 50;
            // 
            // colProductID
            // 
            this.colProductID.DataPropertyName = "ProductID";
            this.colProductID.HeaderText = "商品編號";
            this.colProductID.MaxInputLength = 10;
            this.colProductID.Name = "colProductID";
            // 
            // colProductName
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colProductName.DefaultCellStyle = dataGridViewCellStyle9;
            this.colProductName.HeaderText = "商品名稱";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 400;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "N0";
            this.colQuantity.DefaultCellStyle = dataGridViewCellStyle10;
            this.colQuantity.HeaderText = "數量";
            this.colQuantity.MaxInputLength = 8;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 80;
            // 
            // colUnit
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colUnit.DefaultCellStyle = dataGridViewCellStyle11;
            this.colUnit.HeaderText = "單位";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.Width = 70;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle12.Format = "N0";
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle12;
            this.colAmount.HeaderText = "金額";
            this.colAmount.MaxInputLength = 8;
            this.colAmount.Name = "colAmount";
            // 
            // fmTxnTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(896, 426);
            this.Controls.Add(this.transferDetailsDataGridView);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(912, 464);
            this.Name = "fmTxnTransfer";
            this.Text = "存貨異動單維護";
            this.Load += new System.EventHandler(this.fmTxnTransfer_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.transferDetailsDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.transferBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transferDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource transferBindingSource;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox transferTypeTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label transferIDLabel;
        private System.Windows.Forms.TextBox transferDateTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource transferDetailsBindingSource;
        private System.Windows.Forms.DataGridView transferDetailsDataGridView;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTransferSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;

    }
}
