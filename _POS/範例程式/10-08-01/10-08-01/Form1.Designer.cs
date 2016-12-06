namespace _10_08_01
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
            System.Windows.Forms.Label AttribNameLabel;
            System.Windows.Forms.Label CommentLabel;
            System.Windows.Forms.Label CompanyAddressLabel;
            System.Windows.Forms.Label CompanyNameLabel;
            System.Windows.Forms.Label CustomerIDLabel;
            System.Windows.Forms.Label DeliveryAddressLabel;
            System.Windows.Forms.Label EarNoLabel;
            System.Windows.Forms.Label FaxLabel;
            System.Windows.Forms.Label JoinManLabel;
            System.Windows.Forms.Label LastDeliveryDateLabel;
            System.Windows.Forms.Label MobilePhoneLabel;
            System.Windows.Forms.Label Tel1Label;
            System.Windows.Forms.Label Tel2Label;
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.attribNameTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.companyAddressTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.deliveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.earNoTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.joinManTextBox = new System.Windows.Forms.TextBox();
            this.mobilePhoneTextBox = new System.Windows.Forms.TextBox();
            this.tel1TextBox = new System.Windows.Forms.TextBox();
            this.tel2TextBox = new System.Windows.Forms.TextBox();
            this.lastDeliveryDateTextBox = new System.Windows.Forms.TextBox();
            AttribNameLabel = new System.Windows.Forms.Label();
            CommentLabel = new System.Windows.Forms.Label();
            CompanyAddressLabel = new System.Windows.Forms.Label();
            CompanyNameLabel = new System.Windows.Forms.Label();
            CustomerIDLabel = new System.Windows.Forms.Label();
            DeliveryAddressLabel = new System.Windows.Forms.Label();
            EarNoLabel = new System.Windows.Forms.Label();
            FaxLabel = new System.Windows.Forms.Label();
            JoinManLabel = new System.Windows.Forms.Label();
            LastDeliveryDateLabel = new System.Windows.Forms.Label();
            MobilePhoneLabel = new System.Windows.Forms.Label();
            Tel1Label = new System.Windows.Forms.Label();
            Tel2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).BeginInit();
            this.customerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(_10_08_01.Customer);
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
            this.customerBindingNavigator.Size = new System.Drawing.Size(550, 25);
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
            // customerBindingNavigatorSaveItem
            // 
            this.customerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.customerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("customerBindingNavigatorSaveItem.Image")));
            this.customerBindingNavigatorSaveItem.Name = "customerBindingNavigatorSaveItem";
            this.customerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.customerBindingNavigatorSaveItem.Text = "儲存資料";
            this.customerBindingNavigatorSaveItem.Click += new System.EventHandler(this.customerBindingNavigatorSaveItem_Click);
            // 
            // attribNameTextBox
            // 
            this.attribNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "AttribName", true));
            this.attribNameTextBox.Location = new System.Drawing.Point(448, 36);
            this.attribNameTextBox.Name = "attribNameTextBox";
            this.attribNameTextBox.Size = new System.Drawing.Size(96, 27);
            this.attribNameTextBox.TabIndex = 1;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(92, 292);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(448, 96);
            this.commentTextBox.TabIndex = 11;
            // 
            // companyAddressTextBox
            // 
            this.companyAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CompanyAddress", true));
            this.companyAddressTextBox.Location = new System.Drawing.Point(92, 228);
            this.companyAddressTextBox.Name = "companyAddressTextBox";
            this.companyAddressTextBox.Size = new System.Drawing.Size(448, 27);
            this.companyAddressTextBox.TabIndex = 9;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(92, 68);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(264, 27);
            this.companyNameTextBox.TabIndex = 2;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(92, 36);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(100, 27);
            this.customerIDTextBox.TabIndex = 0;
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "DeliveryAddress", true));
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(92, 260);
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(448, 27);
            this.deliveryAddressTextBox.TabIndex = 10;
            // 
            // earNoTextBox
            // 
            this.earNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "EarNo", true));
            this.earNoTextBox.Location = new System.Drawing.Point(92, 100);
            this.earNoTextBox.Name = "earNoTextBox";
            this.earNoTextBox.Size = new System.Drawing.Size(108, 27);
            this.earNoTextBox.TabIndex = 3;
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(92, 196);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(164, 27);
            this.faxTextBox.TabIndex = 8;
            // 
            // joinManTextBox
            // 
            this.joinManTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "JoinMan", true));
            this.joinManTextBox.Location = new System.Drawing.Point(92, 132);
            this.joinManTextBox.Name = "joinManTextBox";
            this.joinManTextBox.Size = new System.Drawing.Size(124, 27);
            this.joinManTextBox.TabIndex = 4;
            // 
            // mobilePhoneTextBox
            // 
            this.mobilePhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "MobilePhone", true));
            this.mobilePhoneTextBox.Location = new System.Drawing.Point(416, 132);
            this.mobilePhoneTextBox.Name = "mobilePhoneTextBox";
            this.mobilePhoneTextBox.Size = new System.Drawing.Size(128, 27);
            this.mobilePhoneTextBox.TabIndex = 5;
            // 
            // tel1TextBox
            // 
            this.tel1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Tel1", true));
            this.tel1TextBox.Location = new System.Drawing.Point(92, 164);
            this.tel1TextBox.Name = "tel1TextBox";
            this.tel1TextBox.Size = new System.Drawing.Size(164, 27);
            this.tel1TextBox.TabIndex = 6;
            // 
            // tel2TextBox
            // 
            this.tel2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Tel2", true));
            this.tel2TextBox.Location = new System.Drawing.Point(380, 164);
            this.tel2TextBox.Name = "tel2TextBox";
            this.tel2TextBox.Size = new System.Drawing.Size(164, 27);
            this.tel2TextBox.TabIndex = 7;
            // 
            // AttribNameLabel
            // 
            AttribNameLabel.AutoSize = true;
            AttribNameLabel.Location = new System.Drawing.Point(368, 40);
            AttribNameLabel.Name = "AttribNameLabel";
            AttribNameLabel.Size = new System.Drawing.Size(76, 16);
            AttribNameLabel.TabIndex = 65;
            AttribNameLabel.Text = "客戶簡稱:";
            // 
            // CommentLabel
            // 
            CommentLabel.AutoSize = true;
            CommentLabel.Location = new System.Drawing.Point(8, 296);
            CommentLabel.Name = "CommentLabel";
            CommentLabel.Size = new System.Drawing.Size(44, 16);
            CommentLabel.TabIndex = 66;
            CommentLabel.Text = "備註:";
            // 
            // CompanyAddressLabel
            // 
            CompanyAddressLabel.AutoSize = true;
            CompanyAddressLabel.Location = new System.Drawing.Point(8, 236);
            CompanyAddressLabel.Name = "CompanyAddressLabel";
            CompanyAddressLabel.Size = new System.Drawing.Size(76, 16);
            CompanyAddressLabel.TabIndex = 67;
            CompanyAddressLabel.Text = "公司地址:";
            // 
            // CompanyNameLabel
            // 
            CompanyNameLabel.AutoSize = true;
            CompanyNameLabel.Location = new System.Drawing.Point(8, 72);
            CompanyNameLabel.Name = "CompanyNameLabel";
            CompanyNameLabel.Size = new System.Drawing.Size(76, 16);
            CompanyNameLabel.TabIndex = 68;
            CompanyNameLabel.Text = "公司名稱:";
            // 
            // CustomerIDLabel
            // 
            CustomerIDLabel.AutoSize = true;
            CustomerIDLabel.Location = new System.Drawing.Point(8, 40);
            CustomerIDLabel.Name = "CustomerIDLabel";
            CustomerIDLabel.Size = new System.Drawing.Size(76, 16);
            CustomerIDLabel.TabIndex = 69;
            CustomerIDLabel.Text = "客戶編號:";
            // 
            // DeliveryAddressLabel
            // 
            DeliveryAddressLabel.AutoSize = true;
            DeliveryAddressLabel.Location = new System.Drawing.Point(8, 264);
            DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            DeliveryAddressLabel.Size = new System.Drawing.Size(76, 16);
            DeliveryAddressLabel.TabIndex = 70;
            DeliveryAddressLabel.Text = "出貨地址:";
            // 
            // EarNoLabel
            // 
            EarNoLabel.AutoSize = true;
            EarNoLabel.Location = new System.Drawing.Point(8, 104);
            EarNoLabel.Name = "EarNoLabel";
            EarNoLabel.Size = new System.Drawing.Size(76, 16);
            EarNoLabel.TabIndex = 71;
            EarNoLabel.Text = "統一編號:";
            // 
            // FaxLabel
            // 
            FaxLabel.AutoSize = true;
            FaxLabel.Location = new System.Drawing.Point(8, 204);
            FaxLabel.Name = "FaxLabel";
            FaxLabel.Size = new System.Drawing.Size(44, 16);
            FaxLabel.TabIndex = 72;
            FaxLabel.Text = "傳真:";
            // 
            // JoinManLabel
            // 
            JoinManLabel.AutoSize = true;
            JoinManLabel.Location = new System.Drawing.Point(8, 136);
            JoinManLabel.Name = "JoinManLabel";
            JoinManLabel.Size = new System.Drawing.Size(60, 16);
            JoinManLabel.TabIndex = 73;
            JoinManLabel.Text = "聯絡人:";
            // 
            // LastDeliveryDateLabel
            // 
            LastDeliveryDateLabel.AutoSize = true;
            LastDeliveryDateLabel.Location = new System.Drawing.Point(352, 104);
            LastDeliveryDateLabel.Name = "LastDeliveryDateLabel";
            LastDeliveryDateLabel.Size = new System.Drawing.Size(92, 16);
            LastDeliveryDateLabel.TabIndex = 74;
            LastDeliveryDateLabel.Text = "最近出貨日:";
            // 
            // MobilePhoneLabel
            // 
            MobilePhoneLabel.AutoSize = true;
            MobilePhoneLabel.Location = new System.Drawing.Point(336, 136);
            MobilePhoneLabel.Name = "MobilePhoneLabel";
            MobilePhoneLabel.Size = new System.Drawing.Size(76, 16);
            MobilePhoneLabel.TabIndex = 75;
            MobilePhoneLabel.Text = "行動電話:";
            // 
            // Tel1Label
            // 
            Tel1Label.AutoSize = true;
            Tel1Label.Location = new System.Drawing.Point(8, 172);
            Tel1Label.Name = "Tel1Label";
            Tel1Label.Size = new System.Drawing.Size(52, 16);
            Tel1Label.TabIndex = 76;
            Tel1Label.Text = "電話1:";
            // 
            // Tel2Label
            // 
            Tel2Label.AutoSize = true;
            Tel2Label.Location = new System.Drawing.Point(324, 172);
            Tel2Label.Name = "Tel2Label";
            Tel2Label.Size = new System.Drawing.Size(52, 16);
            Tel2Label.TabIndex = 77;
            Tel2Label.Text = "電話2:";
            // 
            // lastDeliveryDateTextBox
            // 
            this.lastDeliveryDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "LastDeliveryDate", true));
            this.lastDeliveryDateTextBox.Location = new System.Drawing.Point(448, 100);
            this.lastDeliveryDateTextBox.Name = "lastDeliveryDateTextBox";
            this.lastDeliveryDateTextBox.ReadOnly = true;
            this.lastDeliveryDateTextBox.Size = new System.Drawing.Size(96, 27);
            this.lastDeliveryDateTextBox.TabIndex = 78;
            this.lastDeliveryDateTextBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 397);
            this.Controls.Add(this.lastDeliveryDateTextBox);
            this.Controls.Add(AttribNameLabel);
            this.Controls.Add(CommentLabel);
            this.Controls.Add(CompanyAddressLabel);
            this.Controls.Add(CompanyNameLabel);
            this.Controls.Add(CustomerIDLabel);
            this.Controls.Add(DeliveryAddressLabel);
            this.Controls.Add(EarNoLabel);
            this.Controls.Add(FaxLabel);
            this.Controls.Add(JoinManLabel);
            this.Controls.Add(LastDeliveryDateLabel);
            this.Controls.Add(MobilePhoneLabel);
            this.Controls.Add(Tel1Label);
            this.Controls.Add(Tel2Label);
            this.Controls.Add(this.attribNameTextBox);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.companyAddressTextBox);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(this.deliveryAddressTextBox);
            this.Controls.Add(this.earNoTextBox);
            this.Controls.Add(this.faxTextBox);
            this.Controls.Add(this.joinManTextBox);
            this.Controls.Add(this.mobilePhoneTextBox);
            this.Controls.Add(this.tel1TextBox);
            this.Controls.Add(this.tel2TextBox);
            this.Controls.Add(this.customerBindingNavigator);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "10-08-01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingNavigator)).EndInit();
            this.customerBindingNavigator.ResumeLayout(false);
            this.customerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource customerBindingSource;
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
        private System.Windows.Forms.TextBox attribNameTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox companyAddressTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox deliveryAddressTextBox;
        private System.Windows.Forms.TextBox earNoTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox joinManTextBox;
        private System.Windows.Forms.TextBox mobilePhoneTextBox;
        private System.Windows.Forms.TextBox tel1TextBox;
        private System.Windows.Forms.TextBox tel2TextBox;
        private System.Windows.Forms.TextBox lastDeliveryDateTextBox;
    }
}

