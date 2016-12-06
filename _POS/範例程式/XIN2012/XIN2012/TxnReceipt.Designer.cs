namespace XIN2012
{
    partial class fmTxnReceipt
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
            System.Windows.Forms.Label invoiceNoLabel;
            System.Windows.Forms.Label receiptDateLabel;
            System.Windows.Forms.Label receiptTypeLabel;
            System.Windows.Forms.Label shipAddressLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTxnReceipt));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.attribNameLabel = new System.Windows.Forms.Label();
            this.btnQrySupplier = new System.Windows.Forms.Button();
            this.receiptDateTextBox = new System.Windows.Forms.TextBox();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shipAddressTextBox = new System.Windows.Forms.TextBox();
            this.supplierIDTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.receiptIDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.invoiceNoTextBox = new System.Windows.Forms.TextBox();
            this.receiptTypeTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.valueAddTaxTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.valueAddTaxLabel = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.receiptDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.colReceiptSeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            commentLabel = new System.Windows.Forms.Label();
            invoiceNoLabel = new System.Windows.Forms.Label();
            receiptDateLabel = new System.Windows.Forms.Label();
            receiptTypeLabel = new System.Windows.Forms.Label();
            shipAddressLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(8, 8);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(41, 20);
            commentLabel.TabIndex = 3;
            commentLabel.Text = "備註";
            // 
            // invoiceNoLabel
            // 
            invoiceNoLabel.AutoSize = true;
            invoiceNoLabel.Location = new System.Drawing.Point(12, 84);
            invoiceNoLabel.Name = "invoiceNoLabel";
            invoiceNoLabel.Size = new System.Drawing.Size(73, 20);
            invoiceNoLabel.TabIndex = 5;
            invoiceNoLabel.Text = "發票號碼";
            // 
            // receiptDateLabel
            // 
            receiptDateLabel.AutoSize = true;
            receiptDateLabel.Location = new System.Drawing.Point(12, 12);
            receiptDateLabel.Name = "receiptDateLabel";
            receiptDateLabel.Size = new System.Drawing.Size(73, 20);
            receiptDateLabel.TabIndex = 7;
            receiptDateLabel.Text = "進貨日期";
            // 
            // receiptTypeLabel
            // 
            receiptTypeLabel.AutoSize = true;
            receiptTypeLabel.Location = new System.Drawing.Point(28, 48);
            receiptTypeLabel.Name = "receiptTypeLabel";
            receiptTypeLabel.Size = new System.Drawing.Size(57, 20);
            receiptTypeLabel.TabIndex = 11;
            receiptTypeLabel.Text = "進貨別";
            // 
            // shipAddressLabel
            // 
            shipAddressLabel.AutoSize = true;
            shipAddressLabel.Location = new System.Drawing.Point(12, 84);
            shipAddressLabel.Name = "shipAddressLabel";
            shipAddressLabel.Size = new System.Drawing.Size(73, 20);
            shipAddressLabel.TabIndex = 13;
            shipAddressLabel.Text = "廠商地址";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(12, 48);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(73, 20);
            supplierIDLabel.TabIndex = 17;
            supplierIDLabel.Text = "廠商編號";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.attribNameLabel);
            this.panel1.Controls.Add(this.btnQrySupplier);
            this.panel1.Controls.Add(this.receiptDateTextBox);
            this.panel1.Controls.Add(receiptDateLabel);
            this.panel1.Controls.Add(shipAddressLabel);
            this.panel1.Controls.Add(this.shipAddressTextBox);
            this.panel1.Controls.Add(supplierIDLabel);
            this.panel1.Controls.Add(this.supplierIDTextBox);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 117);
            this.panel1.TabIndex = 2;
            // 
            // attribNameLabel
            // 
            this.attribNameLabel.AutoSize = true;
            this.attribNameLabel.Location = new System.Drawing.Point(268, 48);
            this.attribNameLabel.Name = "attribNameLabel";
            this.attribNameLabel.Size = new System.Drawing.Size(96, 20);
            this.attribNameLabel.TabIndex = 57;
            this.attribNameLabel.Text = "attribName";
            // 
            // btnQrySupplier
            // 
            this.btnQrySupplier.Image = ((System.Drawing.Image)(resources.GetObject("btnQrySupplier.Image")));
            this.btnQrySupplier.Location = new System.Drawing.Point(220, 44);
            this.btnQrySupplier.Name = "btnQrySupplier";
            this.btnQrySupplier.Size = new System.Drawing.Size(40, 28);
            this.btnQrySupplier.TabIndex = 56;
            this.btnQrySupplier.TabStop = false;
            this.btnQrySupplier.UseVisualStyleBackColor = true;
            this.btnQrySupplier.Click += new System.EventHandler(this.btnQrySupplier_Click);
            // 
            // receiptDateTextBox
            // 
            this.receiptDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "ReceiptDate", true));
            this.receiptDateTextBox.Location = new System.Drawing.Point(92, 8);
            this.receiptDateTextBox.MaxLength = 10;
            this.receiptDateTextBox.Name = "receiptDateTextBox";
            this.receiptDateTextBox.Size = new System.Drawing.Size(120, 29);
            this.receiptDateTextBox.TabIndex = 0;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataSource = typeof(XIN2012.Receipt);
            // 
            // shipAddressTextBox
            // 
            this.shipAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "ShipAddress", true));
            this.shipAddressTextBox.Location = new System.Drawing.Point(92, 80);
            this.shipAddressTextBox.MaxLength = 50;
            this.shipAddressTextBox.Name = "shipAddressTextBox";
            this.shipAddressTextBox.Size = new System.Drawing.Size(496, 29);
            this.shipAddressTextBox.TabIndex = 2;
            // 
            // supplierIDTextBox
            // 
            this.supplierIDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.supplierIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "SupplierID", true));
            this.supplierIDTextBox.Location = new System.Drawing.Point(92, 44);
            this.supplierIDTextBox.MaxLength = 8;
            this.supplierIDTextBox.Name = "supplierIDTextBox";
            this.supplierIDTextBox.Size = new System.Drawing.Size(120, 29);
            this.supplierIDTextBox.TabIndex = 1;
            this.supplierIDTextBox.Validated += new System.EventHandler(this.supplierIDTextBox_Validated);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.receiptIDLabel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(invoiceNoLabel);
            this.panel3.Controls.Add(this.invoiceNoTextBox);
            this.panel3.Controls.Add(this.receiptTypeTextBox);
            this.panel3.Controls.Add(receiptTypeLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(708, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 117);
            this.panel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "進貨單號";
            // 
            // receiptIDLabel
            // 
            this.receiptIDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "ReceiptID", true));
            this.receiptIDLabel.Location = new System.Drawing.Point(92, 12);
            this.receiptIDLabel.Name = "receiptIDLabel";
            this.receiptIDLabel.Size = new System.Drawing.Size(100, 23);
            this.receiptIDLabel.TabIndex = 14;
            this.receiptIDLabel.Text = "receiptID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "(1:進貨 2:退出)";
            // 
            // invoiceNoTextBox
            // 
            this.invoiceNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "InvoiceNo", true));
            this.invoiceNoTextBox.Location = new System.Drawing.Point(92, 80);
            this.invoiceNoTextBox.MaxLength = 10;
            this.invoiceNoTextBox.Name = "invoiceNoTextBox";
            this.invoiceNoTextBox.Size = new System.Drawing.Size(116, 29);
            this.invoiceNoTextBox.TabIndex = 0;
            // 
            // receiptTypeTextBox
            // 
            this.receiptTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "ReceiptType", true));
            this.receiptTypeTextBox.Location = new System.Drawing.Point(92, 44);
            this.receiptTypeTextBox.MaxLength = 1;
            this.receiptTypeTextBox.Name = "receiptTypeTextBox";
            this.receiptTypeTextBox.Size = new System.Drawing.Size(28, 29);
            this.receiptTypeTextBox.TabIndex = 12;
            this.receiptTypeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.receiptTypeTextBox_Validating);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(commentLabel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.commentTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 119);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.amountTextBox);
            this.panel4.Controls.Add(this.subTotalTextBox);
            this.panel4.Controls.Add(this.valueAddTaxTextBox);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.subTotalLabel);
            this.panel4.Controls.Add(this.amountLabel);
            this.panel4.Controls.Add(this.valueAddTaxLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(708, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 119);
            this.panel4.TabIndex = 0;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(92, 80);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.ReadOnly = true;
            this.amountTextBox.Size = new System.Drawing.Size(124, 29);
            this.amountTextBox.TabIndex = 29;
            this.amountTextBox.TabStop = false;
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Location = new System.Drawing.Point(92, 8);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.ReadOnly = true;
            this.subTotalTextBox.Size = new System.Drawing.Size(124, 29);
            this.subTotalTextBox.TabIndex = 28;
            this.subTotalTextBox.TabStop = false;
            this.subTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valueAddTaxTextBox
            // 
            this.valueAddTaxTextBox.Location = new System.Drawing.Point(92, 44);
            this.valueAddTaxTextBox.Name = "valueAddTaxTextBox";
            this.valueAddTaxTextBox.ReadOnly = true;
            this.valueAddTaxTextBox.Size = new System.Drawing.Size(124, 29);
            this.valueAddTaxTextBox.TabIndex = 27;
            this.valueAddTaxTextBox.TabStop = false;
            this.valueAddTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "進貨金額";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "營業稅";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "總計金額";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "SubTotal", true));
            this.subTotalLabel.Location = new System.Drawing.Point(96, 80);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.subTotalLabel.TabIndex = 23;
            this.subTotalLabel.Text = "subTotal";
            // 
            // amountLabel
            // 
            this.amountLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "Amount", true));
            this.amountLabel.Location = new System.Drawing.Point(112, 48);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(100, 23);
            this.amountLabel.TabIndex = 22;
            this.amountLabel.Text = "amount";
            // 
            // valueAddTaxLabel
            // 
            this.valueAddTaxLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "ValueAddTax", true));
            this.valueAddTaxLabel.Location = new System.Drawing.Point(92, 12);
            this.valueAddTaxLabel.Name = "valueAddTaxLabel";
            this.valueAddTaxLabel.Size = new System.Drawing.Size(100, 23);
            this.valueAddTaxLabel.TabIndex = 21;
            this.valueAddTaxLabel.Text = "valueAddTax";
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.receiptBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(52, 8);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(548, 104);
            this.commentTextBox.TabIndex = 0;
            // 
            // receiptDetailsDataGridView
            // 
            this.receiptDetailsDataGridView.AutoGenerateColumns = false;
            this.receiptDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receiptDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReceiptSeq,
            this.colSEQ,
            this.colProductID,
            this.colProductName,
            this.colQuantity,
            this.colUnit,
            this.colUnitPrice,
            this.colAmount});
            this.receiptDetailsDataGridView.DataSource = this.receiptDetailsBindingSource;
            this.receiptDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.receiptDetailsDataGridView.Location = new System.Drawing.Point(0, 160);
            this.receiptDetailsDataGridView.Name = "receiptDetailsDataGridView";
            this.receiptDetailsDataGridView.RowTemplate.Height = 24;
            this.receiptDetailsDataGridView.Size = new System.Drawing.Size(956, 183);
            this.receiptDetailsDataGridView.TabIndex = 3;
            this.receiptDetailsDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.receiptDetailsDataGridView_CellValidated);
            this.receiptDetailsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.receiptDetailsDataGridView_CellValidating);
            this.receiptDetailsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.receiptDetailsDataGridView_CellValueChanged);
            this.receiptDetailsDataGridView.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.receiptDetailsDataGridView_CellValueNeeded);
            this.receiptDetailsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.receiptDetailsDataGridView_DataError);
            this.receiptDetailsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.receiptDetailsDataGridView_DefaultValuesNeeded);
            this.receiptDetailsDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.receiptDetailsDataGridView_RowPrePaint);
            this.receiptDetailsDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.receiptDetailsDataGridView_RowsRemoved);
            this.receiptDetailsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.receiptDetailsDataGridView_UserDeletingRow);
            this.receiptDetailsDataGridView.Enter += new System.EventHandler(this.receiptDetailsDataGridView_Enter);
            this.receiptDetailsDataGridView.Leave += new System.EventHandler(this.receiptDetailsDataGridView_Leave);
            // 
            // colReceiptSeq
            // 
            this.colReceiptSeq.DataPropertyName = "ReceiptSeq";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colReceiptSeq.DefaultCellStyle = dataGridViewCellStyle1;
            this.colReceiptSeq.HeaderText = "#";
            this.colReceiptSeq.Name = "colReceiptSeq";
            this.colReceiptSeq.ReadOnly = true;
            this.colReceiptSeq.Width = 50;
            // 
            // colSEQ
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colSEQ.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colProductName.DefaultCellStyle = dataGridViewCellStyle3;
            this.colProductName.HeaderText = "商品名稱";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 350;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.colQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.colQuantity.HeaderText = "數量";
            this.colQuantity.MaxInputLength = 8;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 80;
            // 
            // colUnit
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colUnit.DefaultCellStyle = dataGridViewCellStyle5;
            this.colUnit.HeaderText = "單位";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.Width = 70;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.colUnitPrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.colUnitPrice.HeaderText = "單價";
            this.colUnitPrice.MaxInputLength = 8;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Width = 90;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.colAmount.HeaderText = "金額";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 120;
            // 
            // receiptDetailsBindingSource
            // 
            this.receiptDetailsBindingSource.DataMember = "ReceiptDetails";
            this.receiptDetailsBindingSource.DataSource = this.receiptBindingSource;
            // 
            // fmTxnReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(956, 462);
            this.Controls.Add(this.receiptDetailsDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(972, 500);
            this.Name = "fmTxnReceipt";
            this.Text = "進貨（退出）單維護";
            this.Load += new System.EventHandler(this.fmTxnReceipt_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.receiptDetailsDataGridView, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private System.Windows.Forms.TextBox receiptDateTextBox;
        private System.Windows.Forms.TextBox shipAddressTextBox;
        private System.Windows.Forms.TextBox supplierIDTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox invoiceNoTextBox;
        private System.Windows.Forms.TextBox receiptTypeTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.BindingSource receiptDetailsBindingSource;
        private System.Windows.Forms.DataGridView receiptDetailsDataGridView;
        internal System.Windows.Forms.Button btnQrySupplier;
        private System.Windows.Forms.Label attribNameLabel;
        private System.Windows.Forms.Label receiptIDLabel;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label valueAddTaxLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox valueAddTaxTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceiptSeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}
