namespace XIN2012
{
    partial class fmDtnProduct
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
            System.Windows.Forms.Label lastDeliveryDateLabel;
            System.Windows.Forms.Label lastReceiptDateLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label productIDLabel;
            System.Windows.Forms.Label 商品名稱;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label unitLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDtnProduct));
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picturePictureBox = new System.Windows.Forms.PictureBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.productIDTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.stopSalesCheckBox = new System.Windows.Forms.CheckBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.lastDeliveryDateTextBox = new System.Windows.Forms.TextBox();
            this.lastReceiptDateTextBox = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            lastDeliveryDateLabel = new System.Windows.Forms.Label();
            lastReceiptDateLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            productIDLabel = new System.Windows.Forms.Label();
            商品名稱 = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            unitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lastDeliveryDateLabel
            // 
            lastDeliveryDateLabel.AutoSize = true;
            lastDeliveryDateLabel.Location = new System.Drawing.Point(416, 120);
            lastDeliveryDateLabel.Name = "lastDeliveryDateLabel";
            lastDeliveryDateLabel.Size = new System.Drawing.Size(89, 20);
            lastDeliveryDateLabel.TabIndex = 3;
            lastDeliveryDateLabel.Text = "最近出貨日";
            // 
            // lastReceiptDateLabel
            // 
            lastReceiptDateLabel.AutoSize = true;
            lastReceiptDateLabel.Location = new System.Drawing.Point(416, 84);
            lastReceiptDateLabel.Name = "lastReceiptDateLabel";
            lastReceiptDateLabel.Size = new System.Drawing.Size(89, 20);
            lastReceiptDateLabel.TabIndex = 5;
            lastReceiptDateLabel.Text = "最近進貨日";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(12, 120);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(73, 20);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "建議售價";
            // 
            // productIDLabel
            // 
            productIDLabel.AutoSize = true;
            productIDLabel.Location = new System.Drawing.Point(12, 12);
            productIDLabel.Name = "productIDLabel";
            productIDLabel.Size = new System.Drawing.Size(73, 20);
            productIDLabel.TabIndex = 11;
            productIDLabel.Text = "商品編號";
            // 
            // 商品名稱
            // 
            商品名稱.AutoSize = true;
            商品名稱.Location = new System.Drawing.Point(12, 48);
            商品名稱.Name = "商品名稱";
            商品名稱.Size = new System.Drawing.Size(73, 20);
            商品名稱.TabIndex = 13;
            商品名稱.Text = "商品名稱";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(232, 120);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(57, 20);
            stockLabel.TabIndex = 15;
            stockLabel.Text = "庫存量";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.Location = new System.Drawing.Point(40, 84);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new System.Drawing.Size(41, 20);
            unitLabel.TabIndex = 19;
            unitLabel.Text = "單位";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(XIN2012.Product);
            // 
            // picturePictureBox
            // 
            this.picturePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productBindingSource, "Picture", true));
            this.picturePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePictureBox.Location = new System.Drawing.Point(0, 0);
            this.picturePictureBox.Name = "picturePictureBox";
            this.picturePictureBox.Size = new System.Drawing.Size(372, 418);
            this.picturePictureBox.TabIndex = 8;
            this.picturePictureBox.TabStop = false;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Price", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.priceTextBox.Location = new System.Drawing.Point(92, 116);
            this.priceTextBox.MaxLength = 10;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(92, 29);
            this.priceTextBox.TabIndex = 3;
            this.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // productIDTextBox
            // 
            this.productIDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.productIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductID", true));
            this.productIDTextBox.Location = new System.Drawing.Point(92, 8);
            this.productIDTextBox.MaxLength = 10;
            this.productIDTextBox.Name = "productIDTextBox";
            this.productIDTextBox.Size = new System.Drawing.Size(120, 29);
            this.productIDTextBox.TabIndex = 0;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProductName", true));
            this.productNameTextBox.Location = new System.Drawing.Point(92, 44);
            this.productNameTextBox.MaxLength = 50;
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(544, 29);
            this.productNameTextBox.TabIndex = 1;
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Stock", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.stockTextBox.Location = new System.Drawing.Point(292, 116);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.ReadOnly = true;
            this.stockTextBox.Size = new System.Drawing.Size(96, 29);
            this.stockTextBox.TabIndex = 16;
            this.stockTextBox.TabStop = false;
            this.stockTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // stopSalesCheckBox
            // 
            this.stopSalesCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "StopSales", true));
            this.stopSalesCheckBox.Location = new System.Drawing.Point(544, 12);
            this.stopSalesCheckBox.Name = "stopSalesCheckBox";
            this.stopSalesCheckBox.Size = new System.Drawing.Size(92, 24);
            this.stopSalesCheckBox.TabIndex = 18;
            this.stopSalesCheckBox.TabStop = false;
            this.stopSalesCheckBox.Text = "停止銷售";
            this.stopSalesCheckBox.UseVisualStyleBackColor = true;
            // 
            // unitTextBox
            // 
            this.unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Unit", true));
            this.unitTextBox.Location = new System.Drawing.Point(92, 80);
            this.unitTextBox.MaxLength = 4;
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(60, 29);
            this.unitTextBox.TabIndex = 2;
            // 
            // lastDeliveryDateTextBox
            // 
            this.lastDeliveryDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "LastDeliveryDate", true));
            this.lastDeliveryDateTextBox.Location = new System.Drawing.Point(512, 116);
            this.lastDeliveryDateTextBox.Name = "lastDeliveryDateTextBox";
            this.lastDeliveryDateTextBox.ReadOnly = true;
            this.lastDeliveryDateTextBox.Size = new System.Drawing.Size(124, 29);
            this.lastDeliveryDateTextBox.TabIndex = 21;
            this.lastDeliveryDateTextBox.TabStop = false;
            // 
            // lastReceiptDateTextBox
            // 
            this.lastReceiptDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "LastReceiptDate", true));
            this.lastReceiptDateTextBox.Location = new System.Drawing.Point(512, 80);
            this.lastReceiptDateTextBox.Name = "lastReceiptDateTextBox";
            this.lastReceiptDateTextBox.ReadOnly = true;
            this.lastReceiptDateTextBox.Size = new System.Drawing.Size(124, 29);
            this.lastReceiptDateTextBox.TabIndex = 22;
            this.lastReceiptDateTextBox.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(104, 8);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 38);
            this.btnClear.TabIndex = 55;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "清除";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.Location = new System.Drawing.Point(8, 8);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(5);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(89, 38);
            this.btnLoad.TabIndex = 54;
            this.btnLoad.TabStop = false;
            this.btnLoad.Text = "載入";
            this.btnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.Title = "選取商品圖片檔案";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.commentTextBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 418);
            this.panel1.TabIndex = 56;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Comment", true));
            this.commentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentTextBox.Location = new System.Drawing.Point(0, 156);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(648, 262);
            this.commentTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.productNameTextBox);
            this.panel2.Controls.Add(this.unitTextBox);
            this.panel2.Controls.Add(unitLabel);
            this.panel2.Controls.Add(this.lastReceiptDateTextBox);
            this.panel2.Controls.Add(this.stopSalesCheckBox);
            this.panel2.Controls.Add(this.lastDeliveryDateTextBox);
            this.panel2.Controls.Add(this.stockTextBox);
            this.panel2.Controls.Add(stockLabel);
            this.panel2.Controls.Add(lastDeliveryDateLabel);
            this.panel2.Controls.Add(商品名稱);
            this.panel2.Controls.Add(lastReceiptDateLabel);
            this.panel2.Controls.Add(this.productIDTextBox);
            this.panel2.Controls.Add(productIDLabel);
            this.panel2.Controls.Add(priceLabel);
            this.panel2.Controls.Add(this.priceTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 156);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.picturePictureBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(648, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 418);
            this.panel3.TabIndex = 57;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLoad);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 364);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(372, 54);
            this.panel4.TabIndex = 56;
            // 
            // fmDtnProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.ClientSize = new System.Drawing.Size(1020, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "fmDtnProduct";
            this.Text = "商品基本資料維護";
            this.Load += new System.EventHandler(this.fmDtnProduct_Load);
            this.Shown += new System.EventHandler(this.fmDtnProduct_Shown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.PictureBox picturePictureBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox productIDTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.CheckBox stopSalesCheckBox;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.TextBox lastDeliveryDateTextBox;
        private System.Windows.Forms.TextBox lastReceiptDateTextBox;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
