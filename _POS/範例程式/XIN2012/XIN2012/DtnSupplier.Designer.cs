namespace XIN2012
{
    partial class fmDtnSupplier
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
            System.Windows.Forms.Label attribNameLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label companyAddressLabel;
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label deliveryAddressLabel;
            System.Windows.Forms.Label earNoLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label joinManLabel;
            System.Windows.Forms.Label lastReceiptDateLabel;
            System.Windows.Forms.Label mobilePhoneLabel;
            System.Windows.Forms.Label supplierIDLabel;
            System.Windows.Forms.Label tel1Label;
            System.Windows.Forms.Label tel2Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDtnSupplier));
            this.attribNameTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.companyAddressTextBox = new System.Windows.Forms.TextBox();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.deliveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.earNoTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.joinManTextBox = new System.Windows.Forms.TextBox();
            this.mobilePhoneTextBox = new System.Windows.Forms.TextBox();
            this.supplierIDTextBox = new System.Windows.Forms.TextBox();
            this.tel1TextBox = new System.Windows.Forms.TextBox();
            this.tel2TextBox = new System.Windows.Forms.TextBox();
            this.lastReceiptDateTextBox = new System.Windows.Forms.TextBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnQryReceiptList = new System.Windows.Forms.Button();
            attribNameLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            companyAddressLabel = new System.Windows.Forms.Label();
            companyNameLabel = new System.Windows.Forms.Label();
            deliveryAddressLabel = new System.Windows.Forms.Label();
            earNoLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            joinManLabel = new System.Windows.Forms.Label();
            lastReceiptDateLabel = new System.Windows.Forms.Label();
            mobilePhoneLabel = new System.Windows.Forms.Label();
            supplierIDLabel = new System.Windows.Forms.Label();
            tel1Label = new System.Windows.Forms.Label();
            tel2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // attribNameLabel
            // 
            attribNameLabel.AutoSize = true;
            attribNameLabel.Location = new System.Drawing.Point(8, 92);
            attribNameLabel.Name = "attribNameLabel";
            attribNameLabel.Size = new System.Drawing.Size(73, 20);
            attribNameLabel.TabIndex = 1;
            attribNameLabel.Text = "廠商簡稱";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(36, 308);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(41, 20);
            commentLabel.TabIndex = 3;
            commentLabel.Text = "備註";
            // 
            // companyAddressLabel
            // 
            companyAddressLabel.AutoSize = true;
            companyAddressLabel.Location = new System.Drawing.Point(8, 236);
            companyAddressLabel.Name = "companyAddressLabel";
            companyAddressLabel.Size = new System.Drawing.Size(73, 20);
            companyAddressLabel.TabIndex = 5;
            companyAddressLabel.Text = "公司地址";
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(4, 128);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(73, 20);
            companyNameLabel.TabIndex = 7;
            companyNameLabel.Text = "廠商名稱";
            // 
            // deliveryAddressLabel
            // 
            deliveryAddressLabel.AutoSize = true;
            deliveryAddressLabel.Location = new System.Drawing.Point(8, 272);
            deliveryAddressLabel.Name = "deliveryAddressLabel";
            deliveryAddressLabel.Size = new System.Drawing.Size(73, 20);
            deliveryAddressLabel.TabIndex = 9;
            deliveryAddressLabel.Text = "出貨地址";
            // 
            // earNoLabel
            // 
            earNoLabel.AutoSize = true;
            earNoLabel.Location = new System.Drawing.Point(564, 128);
            earNoLabel.Name = "earNoLabel";
            earNoLabel.Size = new System.Drawing.Size(73, 20);
            earNoLabel.TabIndex = 11;
            earNoLabel.Text = "統一編號";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(544, 164);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(41, 20);
            faxLabel.TabIndex = 13;
            faxLabel.Text = "傳真";
            // 
            // joinManLabel
            // 
            joinManLabel.AutoSize = true;
            joinManLabel.Location = new System.Drawing.Point(24, 164);
            joinManLabel.Name = "joinManLabel";
            joinManLabel.Size = new System.Drawing.Size(57, 20);
            joinManLabel.TabIndex = 15;
            joinManLabel.Text = "聯絡人";
            // 
            // lastReceiptDateLabel
            // 
            lastReceiptDateLabel.AutoSize = true;
            lastReceiptDateLabel.Location = new System.Drawing.Point(548, 92);
            lastReceiptDateLabel.Name = "lastReceiptDateLabel";
            lastReceiptDateLabel.Size = new System.Drawing.Size(89, 20);
            lastReceiptDateLabel.TabIndex = 17;
            lastReceiptDateLabel.Text = "最近進貨日";
            // 
            // mobilePhoneLabel
            // 
            mobilePhoneLabel.AutoSize = true;
            mobilePhoneLabel.Location = new System.Drawing.Point(8, 200);
            mobilePhoneLabel.Name = "mobilePhoneLabel";
            mobilePhoneLabel.Size = new System.Drawing.Size(73, 20);
            mobilePhoneLabel.TabIndex = 19;
            mobilePhoneLabel.Text = "行動電話";
            // 
            // supplierIDLabel
            // 
            supplierIDLabel.AutoSize = true;
            supplierIDLabel.Location = new System.Drawing.Point(8, 56);
            supplierIDLabel.Name = "supplierIDLabel";
            supplierIDLabel.Size = new System.Drawing.Size(73, 20);
            supplierIDLabel.TabIndex = 21;
            supplierIDLabel.Text = "廠商編號";
            // 
            // tel1Label
            // 
            tel1Label.AutoSize = true;
            tel1Label.Location = new System.Drawing.Point(292, 164);
            tel1Label.Name = "tel1Label";
            tel1Label.Size = new System.Drawing.Size(50, 20);
            tel1Label.TabIndex = 23;
            tel1Label.Text = "電話1";
            // 
            // tel2Label
            // 
            tel2Label.AutoSize = true;
            tel2Label.Location = new System.Drawing.Point(292, 200);
            tel2Label.Name = "tel2Label";
            tel2Label.Size = new System.Drawing.Size(50, 20);
            tel2Label.TabIndex = 25;
            tel2Label.Text = "電話2";
            // 
            // attribNameTextBox
            // 
            this.attribNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "AttribName", true));
            this.attribNameTextBox.Location = new System.Drawing.Point(88, 88);
            this.attribNameTextBox.MaxLength = 10;
            this.attribNameTextBox.Name = "attribNameTextBox";
            this.attribNameTextBox.Size = new System.Drawing.Size(112, 29);
            this.attribNameTextBox.TabIndex = 1;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(84, 304);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(660, 136);
            this.commentTextBox.TabIndex = 11;
            // 
            // companyAddressTextBox
            // 
            this.companyAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "CompanyAddress", true));
            this.companyAddressTextBox.Location = new System.Drawing.Point(88, 232);
            this.companyAddressTextBox.MaxLength = 50;
            this.companyAddressTextBox.Name = "companyAddressTextBox";
            this.companyAddressTextBox.Size = new System.Drawing.Size(496, 29);
            this.companyAddressTextBox.TabIndex = 9;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(88, 124);
            this.companyNameTextBox.MaxLength = 50;
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(412, 29);
            this.companyNameTextBox.TabIndex = 2;
            // 
            // deliveryAddressTextBox
            // 
            this.deliveryAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "DeliveryAddress", true));
            this.deliveryAddressTextBox.Location = new System.Drawing.Point(88, 268);
            this.deliveryAddressTextBox.MaxLength = 50;
            this.deliveryAddressTextBox.Name = "deliveryAddressTextBox";
            this.deliveryAddressTextBox.Size = new System.Drawing.Size(496, 29);
            this.deliveryAddressTextBox.TabIndex = 10;
            // 
            // earNoTextBox
            // 
            this.earNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "EarNo", true));
            this.earNoTextBox.Location = new System.Drawing.Point(644, 124);
            this.earNoTextBox.MaxLength = 8;
            this.earNoTextBox.Name = "earNoTextBox";
            this.earNoTextBox.Size = new System.Drawing.Size(100, 29);
            this.earNoTextBox.TabIndex = 3;
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(592, 160);
            this.faxTextBox.MaxLength = 20;
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(152, 29);
            this.faxTextBox.TabIndex = 8;
            // 
            // joinManTextBox
            // 
            this.joinManTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "JoinMan", true));
            this.joinManTextBox.Location = new System.Drawing.Point(88, 160);
            this.joinManTextBox.MaxLength = 20;
            this.joinManTextBox.Name = "joinManTextBox";
            this.joinManTextBox.Size = new System.Drawing.Size(188, 29);
            this.joinManTextBox.TabIndex = 4;
            // 
            // mobilePhoneTextBox
            // 
            this.mobilePhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "MobilePhone", true));
            this.mobilePhoneTextBox.Location = new System.Drawing.Point(88, 196);
            this.mobilePhoneTextBox.MaxLength = 10;
            this.mobilePhoneTextBox.Name = "mobilePhoneTextBox";
            this.mobilePhoneTextBox.Size = new System.Drawing.Size(112, 29);
            this.mobilePhoneTextBox.TabIndex = 5;
            // 
            // supplierIDTextBox
            // 
            this.supplierIDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.supplierIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupplierID", true));
            this.supplierIDTextBox.Location = new System.Drawing.Point(88, 52);
            this.supplierIDTextBox.MaxLength = 8;
            this.supplierIDTextBox.Name = "supplierIDTextBox";
            this.supplierIDTextBox.Size = new System.Drawing.Size(112, 29);
            this.supplierIDTextBox.TabIndex = 0;
            // 
            // tel1TextBox
            // 
            this.tel1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Tel1", true));
            this.tel1TextBox.Location = new System.Drawing.Point(348, 160);
            this.tel1TextBox.MaxLength = 20;
            this.tel1TextBox.Name = "tel1TextBox";
            this.tel1TextBox.Size = new System.Drawing.Size(152, 29);
            this.tel1TextBox.TabIndex = 6;
            // 
            // tel2TextBox
            // 
            this.tel2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "Tel2", true));
            this.tel2TextBox.Location = new System.Drawing.Point(348, 196);
            this.tel2TextBox.MaxLength = 20;
            this.tel2TextBox.Name = "tel2TextBox";
            this.tel2TextBox.Size = new System.Drawing.Size(152, 29);
            this.tel2TextBox.TabIndex = 7;
            // 
            // lastReceiptDateTextBox
            // 
            this.lastReceiptDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "LastReceiptDate", true));
            this.lastReceiptDateTextBox.Location = new System.Drawing.Point(644, 88);
            this.lastReceiptDateTextBox.Name = "lastReceiptDateTextBox";
            this.lastReceiptDateTextBox.ReadOnly = true;
            this.lastReceiptDateTextBox.Size = new System.Drawing.Size(100, 29);
            this.lastReceiptDateTextBox.TabIndex = 27;
            this.lastReceiptDateTextBox.TabStop = false;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(XIN2012.Supplier);
            // 
            // btnQryReceiptList
            // 
            this.btnQryReceiptList.Image = ((System.Drawing.Image)(resources.GetObject("btnQryReceiptList.Image")));
            this.btnQryReceiptList.Location = new System.Drawing.Point(208, 52);
            this.btnQryReceiptList.Name = "btnQryReceiptList";
            this.btnQryReceiptList.Size = new System.Drawing.Size(128, 40);
            this.btnQryReceiptList.TabIndex = 36;
            this.btnQryReceiptList.TabStop = false;
            this.btnQryReceiptList.Text = "進貨記錄";
            this.btnQryReceiptList.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQryReceiptList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQryReceiptList.UseVisualStyleBackColor = true;
            this.btnQryReceiptList.Click += new System.EventHandler(this.btnQryReceiptList_Click);
            // 
            // fmDtnSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(754, 450);
            this.Controls.Add(this.btnQryReceiptList);
            this.Controls.Add(this.lastReceiptDateTextBox);
            this.Controls.Add(attribNameLabel);
            this.Controls.Add(this.attribNameTextBox);
            this.Controls.Add(commentLabel);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(companyAddressLabel);
            this.Controls.Add(this.companyAddressTextBox);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(deliveryAddressLabel);
            this.Controls.Add(this.deliveryAddressTextBox);
            this.Controls.Add(earNoLabel);
            this.Controls.Add(this.earNoTextBox);
            this.Controls.Add(faxLabel);
            this.Controls.Add(this.faxTextBox);
            this.Controls.Add(joinManLabel);
            this.Controls.Add(this.joinManTextBox);
            this.Controls.Add(lastReceiptDateLabel);
            this.Controls.Add(mobilePhoneLabel);
            this.Controls.Add(this.mobilePhoneTextBox);
            this.Controls.Add(supplierIDLabel);
            this.Controls.Add(this.supplierIDTextBox);
            this.Controls.Add(tel1Label);
            this.Controls.Add(this.tel1TextBox);
            this.Controls.Add(tel2Label);
            this.Controls.Add(this.tel2TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmDtnSupplier";
            this.Text = "廠商基本資料維護";
            this.Load += new System.EventHandler(this.fmDtnSupplier_Load);
            this.Controls.SetChildIndex(this.tel2TextBox, 0);
            this.Controls.SetChildIndex(tel2Label, 0);
            this.Controls.SetChildIndex(this.tel1TextBox, 0);
            this.Controls.SetChildIndex(tel1Label, 0);
            this.Controls.SetChildIndex(this.supplierIDTextBox, 0);
            this.Controls.SetChildIndex(supplierIDLabel, 0);
            this.Controls.SetChildIndex(this.mobilePhoneTextBox, 0);
            this.Controls.SetChildIndex(mobilePhoneLabel, 0);
            this.Controls.SetChildIndex(lastReceiptDateLabel, 0);
            this.Controls.SetChildIndex(this.joinManTextBox, 0);
            this.Controls.SetChildIndex(joinManLabel, 0);
            this.Controls.SetChildIndex(this.faxTextBox, 0);
            this.Controls.SetChildIndex(faxLabel, 0);
            this.Controls.SetChildIndex(this.earNoTextBox, 0);
            this.Controls.SetChildIndex(earNoLabel, 0);
            this.Controls.SetChildIndex(this.deliveryAddressTextBox, 0);
            this.Controls.SetChildIndex(deliveryAddressLabel, 0);
            this.Controls.SetChildIndex(this.companyNameTextBox, 0);
            this.Controls.SetChildIndex(companyNameLabel, 0);
            this.Controls.SetChildIndex(this.companyAddressTextBox, 0);
            this.Controls.SetChildIndex(companyAddressLabel, 0);
            this.Controls.SetChildIndex(this.commentTextBox, 0);
            this.Controls.SetChildIndex(commentLabel, 0);
            this.Controls.SetChildIndex(this.attribNameTextBox, 0);
            this.Controls.SetChildIndex(attribNameLabel, 0);
            this.Controls.SetChildIndex(this.lastReceiptDateTextBox, 0);
            this.Controls.SetChildIndex(this.btnQryReceiptList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.TextBox attribNameTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox companyAddressTextBox;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox deliveryAddressTextBox;
        private System.Windows.Forms.TextBox earNoTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox joinManTextBox;
        private System.Windows.Forms.TextBox mobilePhoneTextBox;
        private System.Windows.Forms.TextBox supplierIDTextBox;
        private System.Windows.Forms.TextBox tel1TextBox;
        private System.Windows.Forms.TextBox tel2TextBox;
        private System.Windows.Forms.TextBox lastReceiptDateTextBox;
        internal System.Windows.Forms.Button btnQryReceiptList;
    }
}
