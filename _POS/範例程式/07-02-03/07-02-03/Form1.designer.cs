namespace _07_02_03
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label deliveryIDLabel;
            System.Windows.Forms.Label deliveryDateLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label joinManLabel;
            System.Windows.Forms.Label deliveryTypeLabel;
            System.Windows.Forms.Label invoiceNoLabel;
            System.Windows.Forms.Label subTotalLabel;
            System.Windows.Forms.Label valueAddTaxLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label shipAddressLabel;
            System.Windows.Forms.Label commentLabel;
            this.deliveryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.deliveryBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.deliveryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.DeliverySeq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryIDTextBox = new System.Windows.Forms.TextBox();
            this.deliveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.joinManTextBox = new System.Windows.Forms.TextBox();
            this.deliveryTypeTextBox = new System.Windows.Forms.TextBox();
            this.invoiceNoTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.valueAddTaxTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.shipAddressTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xINDataSet = new _07_02_03.XINDataSet();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryTableAdapter = new _07_02_03.XINDataSetTableAdapters.DeliveryTableAdapter();
            this.tableAdapterManager = new _07_02_03.XINDataSetTableAdapters.TableAdapterManager();
            this.deliveryDetailsTableAdapter = new _07_02_03.XINDataSetTableAdapters.DeliveryDetailsTableAdapter();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new _07_02_03.XINDataSetTableAdapters.ProductTableAdapter();
            companyNameLabel = new System.Windows.Forms.Label();
            deliveryIDLabel = new System.Windows.Forms.Label();
            deliveryDateLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            joinManLabel = new System.Windows.Forms.Label();
            deliveryTypeLabel = new System.Windows.Forms.Label();
            invoiceNoLabel = new System.Windows.Forms.Label();
            subTotalLabel = new System.Windows.Forms.Label();
            valueAddTaxLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            shipAddressLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingNavigator)).BeginInit();
            this.deliveryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xINDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // deliveryBindingNavigator
            // 
            this.deliveryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.deliveryBindingNavigator.BindingSource = this.deliveryBindingSource;
            this.deliveryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.deliveryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.deliveryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.deliveryBindingNavigatorSaveItem});
            this.deliveryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.deliveryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.deliveryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.deliveryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.deliveryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.deliveryBindingNavigator.Name = "deliveryBindingNavigator";
            this.deliveryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.deliveryBindingNavigator.Size = new System.Drawing.Size(711, 25);
            this.deliveryBindingNavigator.TabIndex = 0;
            this.deliveryBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "移到最前面";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "移到上一個";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "目前的位置";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(28, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "加入新的";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // deliveryBindingNavigatorSaveItem
            // 
            this.deliveryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deliveryBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("deliveryBindingNavigatorSaveItem.Image")));
            this.deliveryBindingNavigatorSaveItem.Name = "deliveryBindingNavigatorSaveItem";
            this.deliveryBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.deliveryBindingNavigatorSaveItem.Text = "儲存資料";
            this.deliveryBindingNavigatorSaveItem.Click += new System.EventHandler(this.deliveryBindingNavigatorSaveItem_Click);
            // 
            // deliveryDetailsBindingSource
            // 
            this.deliveryDetailsBindingSource.DataMember = "FK_DeliveryDetails_Delivery";
            this.deliveryDetailsBindingSource.DataSource = this.deliveryBindingSource;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(12, 104);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(76, 16);
            companyNameLabel.TabIndex = 96;
            companyNameLabel.Text = "客戶名稱:";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(96, 100);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.ReadOnly = true;
            this.companyNameTextBox.Size = new System.Drawing.Size(288, 27);
            this.companyNameTextBox.TabIndex = 97;
            this.companyNameTextBox.TabStop = false;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AutoGenerateColumns = false;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeliverySeq,
            this.colProductID,
            this.colProductName,
            this.Quantity,
            this.UnitPrice,
            this.dataGridViewTextBoxColumn6});
            this.dgvDetails.DataSource = this.deliveryDetailsBindingSource;
            this.dgvDetails.Location = new System.Drawing.Point(16, 168);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.Size = new System.Drawing.Size(680, 220);
            this.dgvDetails.TabIndex = 95;
            // 
            // DeliverySeq
            // 
            this.DeliverySeq.DataPropertyName = "DeliverySeq";
            this.DeliverySeq.HeaderText = "項次";
            this.DeliverySeq.Name = "DeliverySeq";
            this.DeliverySeq.Width = 70;
            // 
            // colProductID
            // 
            this.colProductID.DataPropertyName = "ProductID";
            this.colProductID.HeaderText = "商品編號";
            this.colProductID.Name = "colProductID";
            // 
            // colProductName
            // 
            this.colProductName.DataPropertyName = "ProductName";
            this.colProductName.HeaderText = "商品名稱";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            this.colProductName.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "數量";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 80;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "單價";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 80;
            // 
            // deliveryIDLabel
            // 
            deliveryIDLabel.AutoSize = true;
            deliveryIDLabel.Location = new System.Drawing.Point(508, 40);
            deliveryIDLabel.Name = "deliveryIDLabel";
            deliveryIDLabel.Size = new System.Drawing.Size(76, 16);
            deliveryIDLabel.TabIndex = 73;
            deliveryIDLabel.Text = "出貨單號:";
            // 
            // deliveryIDTextBox
            // 
            this.deliveryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "DeliveryID", true));
            this.deliveryIDTextBox.Location = new System.Drawing.Point(588, 36);
            this.deliveryIDTextBox.Name = "deliveryIDTextBox";
            this.deliveryIDTextBox.Size = new System.Drawing.Size(108, 27);
            this.deliveryIDTextBox.TabIndex = 74;
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new System.Drawing.Point(12, 40);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(76, 16);
            deliveryDateLabel.TabIndex = 75;
            deliveryDateLabel.Text = "出貨日期:";
            // 
            // deliveryDateDateTimePicker
            // 
            this.deliveryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.deliveryBindingSource, "DeliveryDate", true));
            this.deliveryDateDateTimePicker.Location = new System.Drawing.Point(96, 36);
            this.deliveryDateDateTimePicker.Name = "deliveryDateDateTimePicker";
            this.deliveryDateDateTimePicker.Size = new System.Drawing.Size(144, 27);
            this.deliveryDateDateTimePicker.TabIndex = 76;
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(12, 72);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(76, 16);
            customerIDLabel.TabIndex = 77;
            customerIDLabel.Text = "客戶編號:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "CustomerID", true));
            this.txtCustomerID.Location = new System.Drawing.Point(96, 68);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(104, 27);
            this.txtCustomerID.TabIndex = 78;
            // 
            // joinManLabel
            // 
            joinManLabel.AutoSize = true;
            joinManLabel.Location = new System.Drawing.Point(220, 72);
            joinManLabel.Name = "joinManLabel";
            joinManLabel.Size = new System.Drawing.Size(60, 16);
            joinManLabel.TabIndex = 79;
            joinManLabel.Text = "聯絡人:";
            // 
            // joinManTextBox
            // 
            this.joinManTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "JoinMan", true));
            this.joinManTextBox.Location = new System.Drawing.Point(280, 68);
            this.joinManTextBox.Name = "joinManTextBox";
            this.joinManTextBox.Size = new System.Drawing.Size(104, 27);
            this.joinManTextBox.TabIndex = 80;
            // 
            // deliveryTypeLabel
            // 
            deliveryTypeLabel.AutoSize = true;
            deliveryTypeLabel.Location = new System.Drawing.Point(512, 108);
            deliveryTypeLabel.Name = "deliveryTypeLabel";
            deliveryTypeLabel.Size = new System.Drawing.Size(76, 16);
            deliveryTypeLabel.TabIndex = 81;
            deliveryTypeLabel.Text = "出貨類別:";
            // 
            // deliveryTypeTextBox
            // 
            this.deliveryTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "DeliveryType", true));
            this.deliveryTypeTextBox.Location = new System.Drawing.Point(592, 100);
            this.deliveryTypeTextBox.Name = "deliveryTypeTextBox";
            this.deliveryTypeTextBox.Size = new System.Drawing.Size(36, 27);
            this.deliveryTypeTextBox.TabIndex = 82;
            // 
            // invoiceNoLabel
            // 
            invoiceNoLabel.AutoSize = true;
            invoiceNoLabel.Location = new System.Drawing.Point(512, 140);
            invoiceNoLabel.Name = "invoiceNoLabel";
            invoiceNoLabel.Size = new System.Drawing.Size(76, 16);
            invoiceNoLabel.TabIndex = 83;
            invoiceNoLabel.Text = "發票號碼:";
            // 
            // invoiceNoTextBox
            // 
            this.invoiceNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "InvoiceNo", true));
            this.invoiceNoTextBox.Location = new System.Drawing.Point(592, 132);
            this.invoiceNoTextBox.Name = "invoiceNoTextBox";
            this.invoiceNoTextBox.Size = new System.Drawing.Size(108, 27);
            this.invoiceNoTextBox.TabIndex = 84;
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(480, 400);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(76, 16);
            subTotalLabel.TabIndex = 85;
            subTotalLabel.Text = "銷售金額:";
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "SubTotal", true));
            this.subTotalTextBox.Location = new System.Drawing.Point(560, 396);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new System.Drawing.Size(136, 27);
            this.subTotalTextBox.TabIndex = 86;
            // 
            // valueAddTaxLabel
            // 
            valueAddTaxLabel.AutoSize = true;
            valueAddTaxLabel.Location = new System.Drawing.Point(496, 432);
            valueAddTaxLabel.Name = "valueAddTaxLabel";
            valueAddTaxLabel.Size = new System.Drawing.Size(60, 16);
            valueAddTaxLabel.TabIndex = 87;
            valueAddTaxLabel.Text = "營業稅:";
            // 
            // valueAddTaxTextBox
            // 
            this.valueAddTaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "ValueAddTax", true));
            this.valueAddTaxTextBox.Location = new System.Drawing.Point(560, 428);
            this.valueAddTaxTextBox.Name = "valueAddTaxTextBox";
            this.valueAddTaxTextBox.Size = new System.Drawing.Size(136, 27);
            this.valueAddTaxTextBox.TabIndex = 88;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(480, 464);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(76, 16);
            amountLabel.TabIndex = 89;
            amountLabel.Text = "總計金額:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(560, 460);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(136, 27);
            this.amountTextBox.TabIndex = 90;
            // 
            // shipAddressLabel
            // 
            shipAddressLabel.AutoSize = true;
            shipAddressLabel.Location = new System.Drawing.Point(12, 140);
            shipAddressLabel.Name = "shipAddressLabel";
            shipAddressLabel.Size = new System.Drawing.Size(76, 16);
            shipAddressLabel.TabIndex = 91;
            shipAddressLabel.Text = "出貨地址:";
            // 
            // shipAddressTextBox
            // 
            this.shipAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "ShipAddress", true));
            this.shipAddressTextBox.Location = new System.Drawing.Point(96, 132);
            this.shipAddressTextBox.Name = "shipAddressTextBox";
            this.shipAddressTextBox.Size = new System.Drawing.Size(388, 27);
            this.shipAddressTextBox.TabIndex = 92;
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(16, 400);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(44, 16);
            commentLabel.TabIndex = 93;
            commentLabel.Text = "備註:";
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(64, 396);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(388, 92);
            this.commentTextBox.TabIndex = 94;
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "Delivery";
            this.deliveryBindingSource.DataSource = this.xINDataSet;
            // 
            // xINDataSet
            // 
            this.xINDataSet.DataSetName = "XINDataSet";
            this.xINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn6.HeaderText = "金額";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DeliveryDetailsTableAdapter = this.deliveryDetailsTableAdapter;
            this.tableAdapterManager.DeliveryTableAdapter = this.deliveryTableAdapter;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _07_02_03.XINDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // deliveryDetailsTableAdapter
            // 
            this.deliveryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.xINDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 500);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(deliveryIDLabel);
            this.Controls.Add(this.deliveryIDTextBox);
            this.Controls.Add(deliveryDateLabel);
            this.Controls.Add(this.deliveryDateDateTimePicker);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(joinManLabel);
            this.Controls.Add(this.joinManTextBox);
            this.Controls.Add(deliveryTypeLabel);
            this.Controls.Add(this.deliveryTypeTextBox);
            this.Controls.Add(invoiceNoLabel);
            this.Controls.Add(this.invoiceNoTextBox);
            this.Controls.Add(subTotalLabel);
            this.Controls.Add(this.subTotalTextBox);
            this.Controls.Add(valueAddTaxLabel);
            this.Controls.Add(this.valueAddTaxTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(shipAddressLabel);
            this.Controls.Add(this.shipAddressTextBox);
            this.Controls.Add(commentLabel);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.deliveryBindingNavigator);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "07-02-03";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingNavigator)).EndInit();
            this.deliveryBindingNavigator.ResumeLayout(false);
            this.deliveryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xINDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XINDataSet xINDataSet;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private XINDataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter;
        private XINDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator deliveryBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton deliveryBindingNavigatorSaveItem;
        private XINDataSetTableAdapters.DeliveryDetailsTableAdapter deliveryDetailsTableAdapter;
        private System.Windows.Forms.BindingSource deliveryDetailsBindingSource;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliverySeq;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TextBox deliveryIDTextBox;
        private System.Windows.Forms.DateTimePicker deliveryDateDateTimePicker;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox joinManTextBox;
        private System.Windows.Forms.TextBox deliveryTypeTextBox;
        private System.Windows.Forms.TextBox invoiceNoTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox valueAddTaxTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox shipAddressTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private XINDataSetTableAdapters.ProductTableAdapter productTableAdapter;
    }
}