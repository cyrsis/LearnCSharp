namespace _06_05_01
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label attribNameLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label earNoLabel;
            System.Windows.Forms.Label joinManLabel;
            System.Windows.Forms.Label tel1Label;
            System.Windows.Forms.Label tel2Label;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label mobilePhoneLabel;
            System.Windows.Forms.Label companyAddressLabel;
            System.Windows.Forms.Label deliveryAddressLabel;
            System.Windows.Forms.Label lastDeliveryDateLabel;
            System.Windows.Forms.Label commentLabel;
            this.xINDataSet = new _06_05_01.XINDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new _06_05_01.XINDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new _06_05_01.XINDataSetTableAdapters.TableAdapterManager();
            this.customerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.customerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.attribNameTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.earNoTextBox = new System.Windows.Forms.TextBox();
            this.joinManTextBox = new System.Windows.Forms.TextBox();
            this.tel1TextBox = new System.Windows.Forms.TextBox();
            this.tel2TextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.mobilePhoneTextBox = new System.Windows.Forms.TextBox();
            this.companyAddressTextBox = new System.Windows.Forms.TextBox();
            this.deliveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.lastDeliveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryTableAdapter = new _06_05_01.XINDataSetTableAdapters.DeliveryTableAdapter();
            this.deliveryDataGridView = new System.Windows.Forms.DataGridView();
            this.deliveryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryDetailsTableAdapter = new _06_05_01.XINDataSetTableAdapters.DeliveryDetailsTableAdapter();
            this.deliveryDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            customerIDLabel = new System.Windows.Forms.Label();
            attribNameLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            earNoLabel = new System.Windows.Forms.Label();
            joinManLabel = new System.Windows.Forms.Label();
            tel1Label = new System.Windows.Forms.Label();
            tel2Label = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            mobilePhoneLabel = new System.Windows.Forms.Label();
            companyAddressLabel = new System.Windows.Forms.Label();
            deliveryAddressLabel = new System.Windows.Forms.Label();
            lastDeliveryDateLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xINDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // xINDataSet
            // 
            this.xINDataSet.DataSetName = "XINDataSet";
            this.xINDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.xINDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.DeliveryDetailsTableAdapter = this.deliveryDetailsTableAdapter;
            this.tableAdapterManager.DeliveryTableAdapter = this.deliveryTableAdapter;
            this.tableAdapterManager.UpdateOrder = _06_05_01.XINDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerBindingNavigator
            // 
            this.customerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.customerBindingNavigator.BindingSource = this.customerBindingSource;
            this.customerBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.customerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.customerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.customerBindingNavigatorSaveItem});
            this.customerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.customerBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.customerBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.customerBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.customerBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.customerBindingNavigator.Name = "customerBindingNavigator";
            this.customerBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.customerBindingNavigator.Size = new System.Drawing.Size(1013, 25);
            this.customerBindingNavigator.TabIndex = 0;
            this.customerBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(28, 16);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "移到下一個";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "移到最後面";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "刪除";
            // 
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.customerBindingNavigatorSaveItem.Text = "儲存資料";
            this.customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerBindingNavigatorSaveItem_Click_1);
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(8, 39);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(76, 16);
            customerIDLabel.TabIndex = 1;
            customerIDLabel.Text = "客戶編號:";
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(88, 36);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(92, 27);
            this.customerIDTextBox.TabIndex = 2;
            // 
            // attribNameLabel
            // 
            attribNameLabel.AutoSize = true;
            attribNameLabel.Location = new System.Drawing.Point(188, 40);
            attribNameLabel.Name = "attribNameLabel";
            attribNameLabel.Size = new System.Drawing.Size(76, 16);
            attribNameLabel.TabIndex = 3;
            attribNameLabel.Text = "客戶簡稱:";
            // 
            // attribNameTextBox
            // 
            this.attribNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "AttribName", true));
            this.attribNameTextBox.Location = new System.Drawing.Point(268, 36);
            this.attribNameTextBox.Name = "attribNameTextBox";
            this.attribNameTextBox.Size = new System.Drawing.Size(128, 27);
            this.attribNameTextBox.TabIndex = 4;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(8, 72);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(76, 16);
            companyNameLabel.TabIndex = 5;
            companyNameLabel.Text = "客戶名稱:";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(88, 68);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(308, 27);
            this.companyNameTextBox.TabIndex = 6;
            // 
            // earNoLabel
            // 
            earNoLabel.AutoSize = true;
            earNoLabel.Location = new System.Drawing.Point(416, 40);
            earNoLabel.Name = "earNoLabel";
            earNoLabel.Size = new System.Drawing.Size(76, 16);
            earNoLabel.TabIndex = 7;
            earNoLabel.Text = "統一編號:";
            // 
            // earNoTextBox
            // 
            this.earNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "EarNo", true));
            this.earNoTextBox.Location = new System.Drawing.Point(496, 36);
            this.earNoTextBox.Name = "earNoTextBox";
            this.earNoTextBox.Size = new System.Drawing.Size(84, 27);
            this.earNoTextBox.TabIndex = 8;
            // 
            // joinManLabel
            // 
            joinManLabel.AutoSize = true;
            joinManLabel.Location = new System.Drawing.Point(8, 104);
            joinManLabel.Name = "joinManLabel";
            joinManLabel.Size = new System.Drawing.Size(60, 16);
            joinManLabel.TabIndex = 9;
            joinManLabel.Text = "聯絡人:";
            // 
            // joinManTextBox
            // 
            this.joinManTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "JoinMan", true));
            this.joinManTextBox.Location = new System.Drawing.Point(88, 100);
            this.joinManTextBox.Name = "joinManTextBox";
            this.joinManTextBox.Size = new System.Drawing.Size(124, 27);
            this.joinManTextBox.TabIndex = 10;
            // 
            // tel1Label
            // 
            tel1Label.AutoSize = true;
            tel1Label.Location = new System.Drawing.Point(4, 136);
            tel1Label.Name = "tel1Label";
            tel1Label.Size = new System.Drawing.Size(52, 16);
            tel1Label.TabIndex = 11;
            tel1Label.Text = "電話1:";
            // 
            // tel1TextBox
            // 
            this.tel1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Tel1", true));
            this.tel1TextBox.Location = new System.Drawing.Point(88, 132);
            this.tel1TextBox.Name = "tel1TextBox";
            this.tel1TextBox.Size = new System.Drawing.Size(124, 27);
            this.tel1TextBox.TabIndex = 12;
            // 
            // tel2Label
            // 
            tel2Label.AutoSize = true;
            tel2Label.Location = new System.Drawing.Point(220, 136);
            tel2Label.Name = "tel2Label";
            tel2Label.Size = new System.Drawing.Size(52, 16);
            tel2Label.TabIndex = 13;
            tel2Label.Text = "電話2:";
            // 
            // tel2TextBox
            // 
            this.tel2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Tel2", true));
            this.tel2TextBox.Location = new System.Drawing.Point(272, 132);
            this.tel2TextBox.Name = "tel2TextBox";
            this.tel2TextBox.Size = new System.Drawing.Size(124, 27);
            this.tel2TextBox.TabIndex = 14;
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(224, 104);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(44, 16);
            faxLabel.TabIndex = 15;
            faxLabel.Text = "傳真:";
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(272, 100);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(124, 27);
            this.faxTextBox.TabIndex = 16;
            // 
            // mobilePhoneLabel
            // 
            mobilePhoneLabel.AutoSize = true;
            mobilePhoneLabel.Location = new System.Drawing.Point(8, 168);
            mobilePhoneLabel.Name = "mobilePhoneLabel";
            mobilePhoneLabel.Size = new System.Drawing.Size(76, 16);
            mobilePhoneLabel.TabIndex = 17;
            mobilePhoneLabel.Text = "行動電話:";
            // 
            // mobilePhoneTextBox
            // 
            this.mobilePhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "MobilePhone", true));
            this.mobilePhoneTextBox.Location = new System.Drawing.Point(88, 164);
            this.mobilePhoneTextBox.Name = "mobilePhoneTextBox";
            this.mobilePhoneTextBox.Size = new System.Drawing.Size(124, 27);
            this.mobilePhoneTextBox.TabIndex = 18;
            // 
            // companyAddressLabel
            // 
            companyAddressLabel.AutoSize = true;
            companyAddressLabel.Location = new System.Drawing.Point(416, 76);
            companyAddressLabel.Name = "companyAddressLabel";
            companyAddressLabel.Size = new System.Drawing.Size(76, 16);
            companyAddressLabel.TabIndex = 19;
            companyAddressLabel.Text = "公司地址:";
            // 
            // companyAddressTextBox
            // 
            this.companyAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CompanyAddress", true));
            this.companyAddressTextBox.Location = new System.Drawing.Point(496, 68);
            this.companyAddressTextBox.Name = "companyAddressTextBox";
            this.companyAddressTextBox.Size = new System.Drawing.Size(424, 27);
            this.companyAddressTextBox.TabIndex = 20;
            // 
            // deliveryAddressLabel
            // 
            deliveryAddressLabel.AutoSize = true;
            deliveryAddressLabel.Location = new System.Drawing.Point(416, 104);
            deliveryAddressLabel.Name = "deliveryAddressLabel";
            deliveryAddressLabel.Size = new System.Drawing.Size(76, 16);
            deliveryAddressLabel.TabIndex = 21;
            deliveryAddressLabel.Text = "出貨地址:";
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "DeliveryAddress", true));
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(496, 100);
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(503, 27);
            this.deliveryAddressTextBox.TabIndex = 22;
            // 
            // lastDeliveryDateLabel
            // 
            lastDeliveryDateLabel.AutoSize = true;
            lastDeliveryDateLabel.Location = new System.Drawing.Point(692, 40);
            lastDeliveryDateLabel.Name = "lastDeliveryDateLabel";
            lastDeliveryDateLabel.Size = new System.Drawing.Size(92, 16);
            lastDeliveryDateLabel.TabIndex = 23;
            lastDeliveryDateLabel.Text = "最近出貨日:";
            // 
            // lastDeliveryDateDateTimePicker
            // 
            this.lastDeliveryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.customerBindingSource, "LastDeliveryDate", true));
            this.lastDeliveryDateDateTimePicker.Location = new System.Drawing.Point(784, 36);
            this.lastDeliveryDateDateTimePicker.Name = "lastDeliveryDateDateTimePicker";
            this.lastDeliveryDateDateTimePicker.Size = new System.Drawing.Size(136, 27);
            this.lastDeliveryDateDateTimePicker.TabIndex = 24;
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(416, 136);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(44, 16);
            commentLabel.TabIndex = 25;
            commentLabel.Text = "備註:";
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(496, 132);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(503, 56);
            this.commentTextBox.TabIndex = 26;
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "FK_Delivery_Customer";
            this.deliveryBindingSource.DataSource = this.customerBindingSource;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // deliveryDataGridView
            // 
            this.deliveryDataGridView.AutoGenerateColumns = false;
            this.deliveryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.deliveryDataGridView.DataSource = this.deliveryBindingSource;
            this.deliveryDataGridView.Location = new System.Drawing.Point(12, 200);
            this.deliveryDataGridView.Name = "deliveryDataGridView";
            this.deliveryDataGridView.RowTemplate.Height = 24;
            this.deliveryDataGridView.Size = new System.Drawing.Size(988, 168);
            this.deliveryDataGridView.TabIndex = 27;
            // 
            // deliveryDetailsBindingSource
            // 
            this.deliveryDetailsBindingSource.DataMember = "FK_DeliveryDetails_Delivery";
            this.deliveryDetailsBindingSource.DataSource = this.deliveryBindingSource;
            // 
            // deliveryDetailsTableAdapter
            // 
            this.deliveryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // deliveryDetailsDataGridView
            // 
            this.deliveryDetailsDataGridView.AutoGenerateColumns = false;
            this.deliveryDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveryDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.deliveryDetailsDataGridView.DataSource = this.deliveryDetailsBindingSource;
            this.deliveryDetailsDataGridView.Location = new System.Drawing.Point(12, 376);
            this.deliveryDetailsDataGridView.Name = "deliveryDetailsDataGridView";
            this.deliveryDetailsDataGridView.RowTemplate.Height = 24;
            this.deliveryDetailsDataGridView.Size = new System.Drawing.Size(988, 188);
            this.deliveryDetailsDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DeliveryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "出貨單號";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DeliveryDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "出貨日期";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn3.HeaderText = "客戶編號";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "JoinMan";
            this.dataGridViewTextBoxColumn4.HeaderText = "聯絡人";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DeliveryType";
            this.dataGridViewTextBoxColumn5.HeaderText = "出貨類別";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "InvoiceNo";
            this.dataGridViewTextBoxColumn6.HeaderText = "發票號碼";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SubTotal";
            this.dataGridViewTextBoxColumn7.HeaderText = "銷售金額";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ValueAddTax";
            this.dataGridViewTextBoxColumn8.HeaderText = "營業稅";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn9.HeaderText = "總計金額";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ShipAddress";
            this.dataGridViewTextBoxColumn10.HeaderText = "出貨地址";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn11.HeaderText = "備註";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "DeliveryID";
            this.dataGridViewTextBoxColumn12.HeaderText = "出貨單號";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "DeliverySeq";
            this.dataGridViewTextBoxColumn13.HeaderText = "項次";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn14.HeaderText = "商品編號";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn15.HeaderText = "數量";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn16.HeaderText = "單價";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn17.HeaderText = "金額";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 576);
            this.Controls.Add(this.deliveryDetailsDataGridView);
            this.Controls.Add(this.deliveryDataGridView);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(attribNameLabel);
            this.Controls.Add(this.attribNameTextBox);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(earNoLabel);
            this.Controls.Add(this.earNoTextBox);
            this.Controls.Add(joinManLabel);
            this.Controls.Add(this.joinManTextBox);
            this.Controls.Add(tel1Label);
            this.Controls.Add(this.tel1TextBox);
            this.Controls.Add(tel2Label);
            this.Controls.Add(this.tel2TextBox);
            this.Controls.Add(faxLabel);
            this.Controls.Add(this.faxTextBox);
            this.Controls.Add(mobilePhoneLabel);
            this.Controls.Add(this.mobilePhoneTextBox);
            this.Controls.Add(companyAddressLabel);
            this.Controls.Add(this.companyAddressTextBox);
            this.Controls.Add(deliveryAddressLabel);
            this.Controls.Add(this.deliveryAddressTextBox);
            this.Controls.Add(lastDeliveryDateLabel);
            this.Controls.Add(this.lastDeliveryDateDateTimePicker);
            this.Controls.Add(commentLabel);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.customerBindingNavigator);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "06-05-01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xINDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
            this.customerBindingNavigator.ResumeLayout(false);
            this.customerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XINDataSet xINDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private XINDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private XINDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator customerBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton customerBindingNavigatorSaveItem;
        private XINDataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox attribNameTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox earNoTextBox;
        private System.Windows.Forms.TextBox joinManTextBox;
        private System.Windows.Forms.TextBox tel1TextBox;
        private System.Windows.Forms.TextBox tel2TextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox mobilePhoneTextBox;
        private System.Windows.Forms.TextBox companyAddressTextBox;
        private System.Windows.Forms.TextBox deliveryAddressTextBox;
        private System.Windows.Forms.DateTimePicker lastDeliveryDateDateTimePicker;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private XINDataSetTableAdapters.DeliveryDetailsTableAdapter deliveryDetailsTableAdapter;
        private System.Windows.Forms.DataGridView deliveryDataGridView;
        private System.Windows.Forms.BindingSource deliveryDetailsBindingSource;
        private System.Windows.Forms.DataGridView deliveryDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;

    }
}

