namespace _10_04_01
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
            System.Windows.Forms.Label CommentLabel;
            System.Windows.Forms.Label LastDeliveryDateLabel;
            System.Windows.Forms.Label LastReceiptDateLabel;
            System.Windows.Forms.Label PictureLabel;
            System.Windows.Forms.Label PriceALabel;
            System.Windows.Forms.Label ProductIDLabel;
            System.Windows.Forms.Label ProductNameLabel;
            System.Windows.Forms.Label UnitLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Button1 = new System.Windows.Forms.Button();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.stopSalesCheckBox = new System.Windows.Forms.CheckBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.lastDeliveryDateTextBox = new System.Windows.Forms.TextBox();
            this.lastReceiptDateTextBox = new System.Windows.Forms.TextBox();
            this.productBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.productBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            CommentLabel = new System.Windows.Forms.Label();
            LastDeliveryDateLabel = new System.Windows.Forms.Label();
            LastReceiptDateLabel = new System.Windows.Forms.Label();
            PictureLabel = new System.Windows.Forms.Label();
            PriceALabel = new System.Windows.Forms.Label();
            ProductIDLabel = new System.Windows.Forms.Label();
            ProductNameLabel = new System.Windows.Forms.Label();
            UnitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).BeginInit();
            this.productBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommentLabel
            // 
            CommentLabel.AutoSize = true;
            CommentLabel.Location = new System.Drawing.Point(4, 192);
            CommentLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            CommentLabel.Name = "CommentLabel";
            CommentLabel.Size = new System.Drawing.Size(44, 16);
            CommentLabel.TabIndex = 24;
            CommentLabel.Text = "備註:";
            // 
            // LastDeliveryDateLabel
            // 
            LastDeliveryDateLabel.AutoSize = true;
            LastDeliveryDateLabel.Location = new System.Drawing.Point(448, 84);
            LastDeliveryDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            LastDeliveryDateLabel.Name = "LastDeliveryDateLabel";
            LastDeliveryDateLabel.Size = new System.Drawing.Size(92, 16);
            LastDeliveryDateLabel.TabIndex = 27;
            LastDeliveryDateLabel.Text = "最近出貨日:";
            // 
            // LastReceiptDateLabel
            // 
            LastReceiptDateLabel.AutoSize = true;
            LastReceiptDateLabel.Location = new System.Drawing.Point(448, 116);
            LastReceiptDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            LastReceiptDateLabel.Name = "LastReceiptDateLabel";
            LastReceiptDateLabel.Size = new System.Drawing.Size(92, 16);
            LastReceiptDateLabel.TabIndex = 30;
            LastReceiptDateLabel.Text = "最近進貨日:";
            // 
            // PictureLabel
            // 
            PictureLabel.AutoSize = true;
            PictureLabel.Location = new System.Drawing.Point(440, 192);
            PictureLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            PictureLabel.Name = "PictureLabel";
            PictureLabel.Size = new System.Drawing.Size(44, 16);
            PictureLabel.TabIndex = 31;
            PictureLabel.Text = "圖片:";
            // 
            // PriceALabel
            // 
            PriceALabel.AutoSize = true;
            PriceALabel.Location = new System.Drawing.Point(4, 156);
            PriceALabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            PriceALabel.Name = "PriceALabel";
            PriceALabel.Size = new System.Drawing.Size(76, 16);
            PriceALabel.TabIndex = 34;
            PriceALabel.Text = "建議售價:";
            // 
            // ProductIDLabel
            // 
            ProductIDLabel.AutoSize = true;
            ProductIDLabel.Location = new System.Drawing.Point(4, 39);
            ProductIDLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            ProductIDLabel.Name = "ProductIDLabel";
            ProductIDLabel.Size = new System.Drawing.Size(76, 16);
            ProductIDLabel.TabIndex = 36;
            ProductIDLabel.Text = "商品編號:";
            // 
            // ProductNameLabel
            // 
            ProductNameLabel.AutoSize = true;
            ProductNameLabel.Location = new System.Drawing.Point(4, 78);
            ProductNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            ProductNameLabel.Name = "ProductNameLabel";
            ProductNameLabel.Size = new System.Drawing.Size(76, 16);
            ProductNameLabel.TabIndex = 37;
            ProductNameLabel.Text = "商品名稱:";
            // 
            // UnitLabel
            // 
            UnitLabel.AutoSize = true;
            UnitLabel.Location = new System.Drawing.Point(4, 117);
            UnitLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            UnitLabel.Name = "UnitLabel";
            UnitLabel.Size = new System.Drawing.Size(44, 16);
            UnitLabel.TabIndex = 39;
            UnitLabel.Text = "單位:";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(600, 404);
            this.Button1.Margin = new System.Windows.Forms.Padding(5);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(65, 38);
            this.Button1.TabIndex = 35;
            this.Button1.Text = "載入";
            this.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(80, 189);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(346, 251);
            this.commentTextBox.TabIndex = 32;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(_10_04_01.Product);
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productBindingSource, "Picture", true));
            this.picturePictureBox.Location = new System.Drawing.Point(492, 188);
            this.picturePictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(172, 208);
            this.picturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePictureBox.TabIndex = 33;
            this.picturePictureBox.TabStop = false;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Price", true));
            this.priceTextBox.Location = new System.Drawing.Point(80, 153);
            this.priceTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(116, 27);
            this.priceTextBox.TabIndex = 29;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(80, 36);
            this.productIDTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(118, 27);
            this.productIDTextBox.TabIndex = 22;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(80, 75);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(346, 27);
            this.productNameTextBox.TabIndex = 23;
            // 
            // stopSalesCheckBox
            // 
            this.stopSalesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "StopSales", true));
            this.stopSalesCheckBox.Location = new System.Drawing.Point(564, 36);
            this.stopSalesCheckBox.Margin = new System.Windows.Forms.Padding(5);
            this.stopSalesCheckBox.Name = "stopSalesCheckBox";
            this.stopSalesCheckBox.Size = new System.Drawing.Size(101, 40);
            this.stopSalesCheckBox.TabIndex = 38;
            this.stopSalesCheckBox.TabStop = false;
            this.stopSalesCheckBox.Text = "停止銷售";
            this.stopSalesCheckBox.UseVisualStyleBackColor = true;
            // 
            // unitTextBox
            // 
            this.unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Unit", true));
            this.unitTextBox.Location = new System.Drawing.Point(80, 114);
            this.unitTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(72, 27);
            this.unitTextBox.TabIndex = 25;
            // 
            // lastDeliveryDateTextBox
            // 
            this.lastDeliveryDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "LastDeliveryDate", true));
            this.lastDeliveryDateTextBox.Location = new System.Drawing.Point(544, 76);
            this.lastDeliveryDateTextBox.Name = "lastDeliveryDateTextBox";
            this.lastDeliveryDateTextBox.ReadOnly = true;
            this.lastDeliveryDateTextBox.Size = new System.Drawing.Size(120, 27);
            this.lastDeliveryDateTextBox.TabIndex = 40;
            this.lastDeliveryDateTextBox.TabStop = false;
            // 
            // lastReceiptDateTextBox
            // 
            this.lastReceiptDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "LastReceiptDate", true));
            this.lastReceiptDateTextBox.Location = new System.Drawing.Point(544, 112);
            this.lastReceiptDateTextBox.Name = "lastReceiptDateTextBox";
            this.lastReceiptDateTextBox.ReadOnly = true;
            this.lastReceiptDateTextBox.Size = new System.Drawing.Size(120, 27);
            this.lastReceiptDateTextBox.TabIndex = 41;
            this.lastReceiptDateTextBox.TabStop = false;
            // 
            // productBindingNavigator
            // 
            this.productBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.productBindingNavigator.BindingSource = this.productBindingSource;
            this.productBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.productBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.productBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.productBindingNavigatorSaveItem});
            this.productBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.productBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.productBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.productBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.productBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.productBindingNavigator.Name = "productBindingNavigator";
            this.productBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.productBindingNavigator.Size = new System.Drawing.Size(682, 25);
            this.productBindingNavigator.TabIndex = 42;
            this.productBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(28, 22);
            this.bindingNavigatorCountItem.Text = "/{0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目總數";
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // productBindingNavigatorSaveItem
            // 
            this.productBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.productBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("productBindingNavigatorSaveItem.Image")));
            this.productBindingNavigatorSaveItem.Name = "productBindingNavigatorSaveItem";
            this.productBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.productBindingNavigatorSaveItem.Text = "儲存資料";
            this.productBindingNavigatorSaveItem.Click += new System.EventHandler(this.productBindingNavigatorSaveItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 452);
            this.Controls.Add(this.productBindingNavigator);
            this.Controls.Add(this.lastReceiptDateTextBox);
            this.Controls.Add(this.lastDeliveryDateTextBox);
            this.Controls.Add(this.Button1);
            this.Controls.Add(CommentLabel);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(LastDeliveryDateLabel);
            this.Controls.Add(LastReceiptDateLabel);
            this.Controls.Add(PictureLabel);
            this.Controls.Add(this.picturePictureBox);
            this.Controls.Add(PriceALabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(ProductIDLabel);
            this.Controls.Add(this.productIDTextBox);
            this.Controls.Add(ProductNameLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.stopSalesCheckBox);
            this.Controls.Add(UnitLabel);
            this.Controls.Add(this.unitTextBox);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "10-04-01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingNavigator)).EndInit();
            this.productBindingNavigator.ResumeLayout(false);
            this.productBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox commentTextBox;
        internal System.Windows.Forms.PictureBox picturePictureBox;
        internal System.Windows.Forms.TextBox priceTextBox;
        internal System.Windows.Forms.TextBox productIDTextBox;
        internal System.Windows.Forms.TextBox productNameTextBox;
        internal System.Windows.Forms.CheckBox stopSalesCheckBox;
        internal System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.TextBox lastDeliveryDateTextBox;
        private System.Windows.Forms.TextBox lastReceiptDateTextBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingNavigator productBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton productBindingNavigatorSaveItem;
    }
}

