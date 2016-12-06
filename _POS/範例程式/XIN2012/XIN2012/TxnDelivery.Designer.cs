namespace XIN2012
{
    partial class fmTxnDelivery
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label deliveryDateLabel;
            System.Windows.Forms.Label deliveryTypeLabel;
            System.Windows.Forms.Label invoiceNoLabel;
            System.Windows.Forms.Label joinManLabel;
            System.Windows.Forms.Label shipAddressLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTxnDelivery));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQryCustomer = new System.Windows.Forms.Button();
            this.attribNameLabel = new System.Windows.Forms.Label();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.deliveryDateTextBox = new System.Windows.Forms.TextBox();
            this.joinManTextBox = new System.Windows.Forms.TextBox();
            this.shipAddressTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deliveryIDLabel = new System.Windows.Forms.Label();
            this.deliveryTypeTextBox = new System.Windows.Forms.TextBox();
            this.invoiceNoTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.valueAddTaxTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.valueAddTaxLabel = new System.Windows.Forms.Label();
            this.deliveryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.colDeliverySeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            commentLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            deliveryDateLabel = new System.Windows.Forms.Label();
            deliveryTypeLabel = new System.Windows.Forms.Label();
            invoiceNoLabel = new System.Windows.Forms.Label();
            joinManLabel = new System.Windows.Forms.Label();
            shipAddressLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(12, 12);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(41, 20);
            commentLabel.TabIndex = 3;
            commentLabel.Text = "備註";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(12, 48);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(73, 20);
            customerIDLabel.TabIndex = 5;
            customerIDLabel.Text = "客戶編號";
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new System.Drawing.Point(12, 12);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(73, 20);
            deliveryDateLabel.TabIndex = 7;
            deliveryDateLabel.Text = "出貨日期";
            // 
            // deliveryTypeLabel
            // 
            deliveryTypeLabel.AutoSize = true;
            deliveryTypeLabel.Location = new System.Drawing.Point(24, 48);
            deliveryTypeLabel.Name = "deliveryTypeLabel";
            deliveryTypeLabel.Size = new System.Drawing.Size(57, 20);
            deliveryTypeLabel.TabIndex = 11;
            deliveryTypeLabel.Text = "出貨別";
            // 
            // invoiceNoLabel
            // 
            invoiceNoLabel.AutoSize = true;
            invoiceNoLabel.Location = new System.Drawing.Point(8, 84);
            invoiceNoLabel.Name = "invoiceNoLabel";
            invoiceNoLabel.Size = new System.Drawing.Size(73, 20);
            invoiceNoLabel.TabIndex = 13;
            invoiceNoLabel.Text = "發票號碼";
            // 
            // joinManLabel
            // 
            joinManLabel.AutoSize = true;
            joinManLabel.Location = new System.Drawing.Point(440, 48);
            joinManLabel.Name = "joinManLabel";
            joinManLabel.Size = new System.Drawing.Size(57, 20);
            joinManLabel.TabIndex = 15;
            joinManLabel.Text = "聯絡人";
            // 
            // shipAddressLabel
            // 
            shipAddressLabel.AutoSize = true;
            shipAddressLabel.Location = new System.Drawing.Point(12, 84);
            shipAddressLabel.Name = "shipAddressLabel";
            shipAddressLabel.Size = new System.Drawing.Size(73, 20);
            shipAddressLabel.TabIndex = 17;
            shipAddressLabel.Text = "出貨地址";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnQryCustomer);
            this.panel1.Controls.Add(this.attribNameLabel);
            this.panel1.Controls.Add(customerIDLabel);
            this.panel1.Controls.Add(this.customerIDTextBox);
            this.panel1.Controls.Add(deliveryDateLabel);
            this.panel1.Controls.Add(this.deliveryDateTextBox);
            this.panel1.Controls.Add(joinManLabel);
            this.panel1.Controls.Add(this.joinManTextBox);
            this.panel1.Controls.Add(shipAddressLabel);
            this.panel1.Controls.Add(this.shipAddressTextBox);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 117);
            this.panel1.TabIndex = 2;
            // 
            // btnQryCustomer
            // 
            this.btnQryCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnQryCustomer.Image")));
            this.btnQryCustomer.Location = new System.Drawing.Point(220, 44);
            this.btnQryCustomer.Name = "btnQryCustomer";
            this.btnQryCustomer.Size = new System.Drawing.Size(40, 28);
            this.btnQryCustomer.TabIndex = 57;
            this.btnQryCustomer.TabStop = false;
            this.btnQryCustomer.UseVisualStyleBackColor = true;
            this.btnQryCustomer.Click += new System.EventHandler(this.btnQryCustomer_Click);
            // 
            // attribNameLabel
            // 
            this.attribNameLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "Customer.AttribName", true));
            this.attribNameLabel.Location = new System.Drawing.Point(268, 48);
            this.attribNameLabel.Name = "attribNameLabel";
            this.attribNameLabel.Size = new System.Drawing.Size(120, 23);
            this.attribNameLabel.TabIndex = 19;
            this.attribNameLabel.Text = "attribNameLabel";
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataSource = typeof(XIN2012.Delivery);
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(92, 44);
            this.customerIDTextBox.MaxLength = 8;
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(120, 29);
            this.customerIDTextBox.TabIndex = 6;
            this.customerIDTextBox.Validated += new System.EventHandler(this.customerIDTextBox_Validated);
            // 
            // deliveryDateTextBox
            // 
            this.deliveryDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "DeliveryDate", true));
            this.deliveryDateTextBox.Location = new System.Drawing.Point(92, 8);
            this.deliveryDateTextBox.MaxLength = 10;
            this.deliveryDateTextBox.Name = "deliveryDateTextBox";
            this.deliveryDateTextBox.Size = new System.Drawing.Size(120, 29);
            this.deliveryDateTextBox.TabIndex = 8;
            // 
            // joinManTextBox
            // 
            this.joinManTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "JoinMan", true));
            this.joinManTextBox.Location = new System.Drawing.Point(504, 44);
            this.joinManTextBox.MaxLength = 20;
            this.joinManTextBox.Name = "joinManTextBox";
            this.joinManTextBox.Size = new System.Drawing.Size(164, 29);
            this.joinManTextBox.TabIndex = 16;
            // 
            // shipAddressTextBox
            // 
            this.shipAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "ShipAddress", true));
            this.shipAddressTextBox.Location = new System.Drawing.Point(92, 80);
            this.shipAddressTextBox.MaxLength = 50;
            this.shipAddressTextBox.Name = "shipAddressTextBox";
            this.shipAddressTextBox.Size = new System.Drawing.Size(576, 29);
            this.shipAddressTextBox.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.deliveryIDLabel);
            this.panel3.Controls.Add(deliveryTypeLabel);
            this.panel3.Controls.Add(this.deliveryTypeTextBox);
            this.panel3.Controls.Add(invoiceNoLabel);
            this.panel3.Controls.Add(this.invoiceNoTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(708, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 117);
            this.panel3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "(1:出貨 2:退回)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "出貨單號";
            // 
            // deliveryIDLabel
            // 
            this.deliveryIDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "DeliveryID", true));
            this.deliveryIDLabel.Location = new System.Drawing.Point(84, 12);
            this.deliveryIDLabel.Name = "deliveryIDLabel";
            this.deliveryIDLabel.Size = new System.Drawing.Size(128, 23);
            this.deliveryIDLabel.TabIndex = 15;
            this.deliveryIDLabel.Text = "deliveryIDLabel";
            // 
            // deliveryTypeTextBox
            // 
            this.deliveryTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "DeliveryType", true));
            this.deliveryTypeTextBox.Location = new System.Drawing.Point(88, 44);
            this.deliveryTypeTextBox.MaxLength = 1;
            this.deliveryTypeTextBox.Name = "deliveryTypeTextBox";
            this.deliveryTypeTextBox.Size = new System.Drawing.Size(28, 29);
            this.deliveryTypeTextBox.TabIndex = 12;
            this.deliveryTypeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.deliveryTypeTextBox_Validating);
            // 
            // invoiceNoTextBox
            // 
            this.invoiceNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "InvoiceNo", true));
            this.invoiceNoTextBox.Location = new System.Drawing.Point(88, 80);
            this.invoiceNoTextBox.MaxLength = 10;
            this.invoiceNoTextBox.Name = "invoiceNoTextBox";
            this.invoiceNoTextBox.Size = new System.Drawing.Size(100, 29);
            this.invoiceNoTextBox.TabIndex = 14;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(56, 8);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(548, 104);
            this.commentTextBox.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(commentLabel);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.commentTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(956, 123);
            this.panel2.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.amountTextBox);
            this.panel4.Controls.Add(this.valueAddTaxTextBox);
            this.panel4.Controls.Add(this.subTotalTextBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.subTotalLabel);
            this.panel4.Controls.Add(this.amountLabel);
            this.panel4.Controls.Add(this.valueAddTaxLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(708, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 123);
            this.panel4.TabIndex = 0;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(100, 80);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.ReadOnly = true;
            this.amountTextBox.Size = new System.Drawing.Size(124, 29);
            this.amountTextBox.TabIndex = 11;
            this.amountTextBox.TabStop = false;
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // valueAddTaxTextBox
            // 
            this.valueAddTaxTextBox.Location = new System.Drawing.Point(100, 44);
            this.valueAddTaxTextBox.Name = "valueAddTaxTextBox";
            this.valueAddTaxTextBox.ReadOnly = true;
            this.valueAddTaxTextBox.Size = new System.Drawing.Size(124, 29);
            this.valueAddTaxTextBox.TabIndex = 10;
            this.valueAddTaxTextBox.TabStop = false;
            this.valueAddTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Location = new System.Drawing.Point(100, 8);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.ReadOnly = true;
            this.subTotalTextBox.Size = new System.Drawing.Size(124, 29);
            this.subTotalTextBox.TabIndex = 9;
            this.subTotalTextBox.TabStop = false;
            this.subTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "總計金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "營業稅";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "銷售金額";
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "SubTotal", true));
            this.subTotalLabel.Location = new System.Drawing.Point(100, 12);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(100, 23);
            this.subTotalLabel.TabIndex = 5;
            this.subTotalLabel.Text = "subTotalLabel";
            // 
            // amountLabel
            // 
            this.amountLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "Amount", true));
            this.amountLabel.Location = new System.Drawing.Point(100, 84);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(100, 23);
            this.amountLabel.TabIndex = 3;
            this.amountLabel.Text = "amountLabel";
            // 
            // valueAddTaxLabel
            // 
            this.valueAddTaxLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "ValueAddTax", true));
            this.valueAddTaxLabel.Location = new System.Drawing.Point(100, 44);
            this.valueAddTaxLabel.Name = "valueAddTaxLabel";
            this.valueAddTaxLabel.Size = new System.Drawing.Size(100, 23);
            this.valueAddTaxLabel.TabIndex = 1;
            this.valueAddTaxLabel.Text = "valueAddTaxLabel1";
            // 
            // deliveryDetailsBindingSource
            // 
            this.deliveryDetailsBindingSource.DataMember = "DeliveryDetails";
            this.deliveryDetailsBindingSource.DataSource = this.deliveryBindingSource;
            // 
            // deliveryDetailsDataGridView
            // 
            this.deliveryDetailsDataGridView.AutoGenerateColumns = false;
            this.deliveryDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveryDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDeliverySeq,
            this.colSEQ,
            this.colProductID,
            this.colProductName,
            this.colQuantity,
            this.colUnit,
            this.colUnitPrice,
            this.colAmount});
            this.deliveryDetailsDataGridView.DataSource = this.deliveryDetailsBindingSource;
            this.deliveryDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deliveryDetailsDataGridView.Location = new System.Drawing.Point(0, 160);
            this.deliveryDetailsDataGridView.Name = "deliveryDetailsDataGridView";
            this.deliveryDetailsDataGridView.RowTemplate.Height = 24;
            this.deliveryDetailsDataGridView.Size = new System.Drawing.Size(956, 179);
            this.deliveryDetailsDataGridView.TabIndex = 3;
            this.deliveryDetailsDataGridView.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.deliveryDetailsDataGridView_CellValidated);
            this.deliveryDetailsDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.deliveryDetailsDataGridView_CellValidating);
            this.deliveryDetailsDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.deliveryDetailsDataGridView_CellValueChanged);
            this.deliveryDetailsDataGridView.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.deliveryDetailsDataGridView_CellValueNeeded);
            this.deliveryDetailsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.deliveryDetailsDataGridView_DataError);
            this.deliveryDetailsDataGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.deliveryDetailsDataGridView_DefaultValuesNeeded);
            this.deliveryDetailsDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.deliveryDetailsDataGridView_RowPrePaint);
            this.deliveryDetailsDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.deliveryDetailsDataGridView_RowsRemoved);
            this.deliveryDetailsDataGridView.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.deliveryDetailsDataGridView_UserDeletingRow);
            this.deliveryDetailsDataGridView.Enter += new System.EventHandler(this.deliveryDetailsDataGridView_Enter);
            this.deliveryDetailsDataGridView.Leave += new System.EventHandler(this.deliveryDetailsDataGridView_Leave);
            // 
            // colDeliverySeq
            // 
            this.colDeliverySeq.DataPropertyName = "DeliverySeq";
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colDeliverySeq.DefaultCellStyle = dataGridViewCellStyle8;
            this.colDeliverySeq.HeaderText = "#";
            this.colDeliverySeq.Name = "colDeliverySeq";
            this.colDeliverySeq.ReadOnly = true;
            this.colDeliverySeq.Width = 50;
            // 
            // colSEQ
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colSEQ.DefaultCellStyle = dataGridViewCellStyle9;
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
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colProductName.DefaultCellStyle = dataGridViewCellStyle10;
            this.colProductName.HeaderText = "商品名稱";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 350;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle11.Format = "N0";
            dataGridViewCellStyle11.NullValue = null;
            this.colQuantity.DefaultCellStyle = dataGridViewCellStyle11;
            this.colQuantity.HeaderText = "數量";
            this.colQuantity.MaxInputLength = 8;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Width = 80;
            // 
            // colUnit
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.colUnit.DefaultCellStyle = dataGridViewCellStyle12;
            this.colUnit.HeaderText = "單位";
            this.colUnit.Name = "colUnit";
            this.colUnit.ReadOnly = true;
            this.colUnit.Width = 70;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle13.Format = "N0";
            dataGridViewCellStyle13.NullValue = null;
            this.colUnitPrice.DefaultCellStyle = dataGridViewCellStyle13;
            this.colUnitPrice.HeaderText = "單價";
            this.colUnitPrice.MaxInputLength = 8;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Width = 90;
            // 
            // colAmount
            // 
            this.colAmount.DataPropertyName = "Amount";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle14.Format = "N0";
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle14;
            this.colAmount.HeaderText = "金額";
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            this.colAmount.Width = 120;
            // 
            // fmTxnDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(956, 462);
            this.Controls.Add(this.deliveryDetailsDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(972, 500);
            this.Name = "fmTxnDelivery";
            this.Text = "出貨（退回）單維護";
            this.Load += new System.EventHandler(this.fmTxnDelivery_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.deliveryDetailsDataGridView, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private System.Windows.Forms.TextBox deliveryDateTextBox;
        private System.Windows.Forms.TextBox joinManTextBox;
        private System.Windows.Forms.TextBox shipAddressTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox deliveryTypeTextBox;
        private System.Windows.Forms.TextBox invoiceNoTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label valueAddTaxLabel;
        private System.Windows.Forms.BindingSource deliveryDetailsBindingSource;
        private System.Windows.Forms.DataGridView deliveryDetailsDataGridView;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox valueAddTaxTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label deliveryIDLabel;
        private System.Windows.Forms.Label attribNameLabel;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button btnQryCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliverySeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
    }
}
