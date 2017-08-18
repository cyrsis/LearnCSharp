namespace Data
{
    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.CategoryToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.SourceToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BackToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ForwardToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.AddToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.OrderTextBox = new System.Windows.Forms.TextBox();
            this.DiscontinuedCheckBox = new System.Windows.Forms.CheckBox();
            this.StockTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ProductsListBox = new System.Windows.Forms.ListBox();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.ToolStrip1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabel1,
            this.CategoryToolStripComboBox,
            this.ToolStripSeparator1,
            this.ToolStripLabel2,
            this.SourceToolStripComboBox,
            this.ToolStripSeparator2,
            this.BackToolStripButton,
            this.ForwardToolStripButton,
            this.ToolStripSeparator3,
            this.AddToolStripButton,
            this.DeleteToolStripButton,
            this.ToolStripSeparator4,
            this.SaveToolStripButton});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(704, 25);
            this.ToolStrip1.TabIndex = 1;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // ToolStripLabel1
            // 
            this.ToolStripLabel1.Name = "ToolStripLabel1";
            this.ToolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.ToolStripLabel1.Text = "Category:";
            // 
            // CategoryToolStripComboBox
            // 
            this.CategoryToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryToolStripComboBox.Name = "CategoryToolStripComboBox";
            this.CategoryToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.CategoryToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryToolStripComboBox_SelectedIndexChanged);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripLabel2
            // 
            this.ToolStripLabel2.Name = "ToolStripLabel2";
            this.ToolStripLabel2.Size = new System.Drawing.Size(44, 22);
            this.ToolStripLabel2.Text = "Source:";
            // 
            // SourceToolStripComboBox
            // 
            this.SourceToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SourceToolStripComboBox.Items.AddRange(new object[] {
            "Objects",
            "DataSet",
            "LINQ to SQL"});
            this.SourceToolStripComboBox.Name = "SourceToolStripComboBox";
            this.SourceToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.SourceToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.SourceToolStripComboBox_SelectedIndexChanged);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BackToolStripButton
            // 
            this.BackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BackToolStripButton.Image")));
            this.BackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackToolStripButton.Name = "BackToolStripButton";
            this.BackToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.BackToolStripButton.Text = "ToolStripButton1";
            this.BackToolStripButton.Click += new System.EventHandler(this.BackToolStripButton_Click);
            // 
            // ForwardToolStripButton
            // 
            this.ForwardToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ForwardToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ForwardToolStripButton.Image")));
            this.ForwardToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardToolStripButton.Name = "ForwardToolStripButton";
            this.ForwardToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ForwardToolStripButton.Text = "ToolStripButton1";
            this.ForwardToolStripButton.Click += new System.EventHandler(this.ForwardToolStripButton_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // AddToolStripButton
            // 
            this.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AddToolStripButton.Image")));
            this.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddToolStripButton.Name = "AddToolStripButton";
            this.AddToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AddToolStripButton.Text = "ToolStripButton1";
            this.AddToolStripButton.Click += new System.EventHandler(this.AddToolStripButton_Click);
            // 
            // DeleteToolStripButton
            // 
            this.DeleteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteToolStripButton.Image")));
            this.DeleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteToolStripButton.Name = "DeleteToolStripButton";
            this.DeleteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.DeleteToolStripButton.Text = "ToolStripButton1";
            this.DeleteToolStripButton.Click += new System.EventHandler(this.DeleteToolStripButton_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveToolStripButton
            // 
            this.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButton.Image")));
            this.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripButton.Name = "SaveToolStripButton";
            this.SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.SaveToolStripButton.Text = "ToolStripButton1";
            this.SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 25);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(704, 459);
            this.TabControl1.TabIndex = 2;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.Label7);
            this.TabPage1.Controls.Add(this.Label6);
            this.TabPage1.Controls.Add(this.Label5);
            this.TabPage1.Controls.Add(this.Label4);
            this.TabPage1.Controls.Add(this.Label3);
            this.TabPage1.Controls.Add(this.Label1);
            this.TabPage1.Controls.Add(this.OrderTextBox);
            this.TabPage1.Controls.Add(this.DiscontinuedCheckBox);
            this.TabPage1.Controls.Add(this.StockTextBox);
            this.TabPage1.Controls.Add(this.PriceTextBox);
            this.TabPage1.Controls.Add(this.QuantityTextBox);
            this.TabPage1.Controls.Add(this.NameTextBox);
            this.TabPage1.Controls.Add(this.ProductsListBox);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(696, 433);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Form";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(308, 158);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(69, 13);
            this.Label7.TabIndex = 26;
            this.Label7.Text = "Discontinued";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(308, 135);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(75, 13);
            this.Label6.TabIndex = 25;
            this.Label6.Text = "Units on Order";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(308, 109);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(73, 13);
            this.Label5.TabIndex = 24;
            this.Label5.Text = "Units in Stock";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(308, 83);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(53, 13);
            this.Label4.TabIndex = 23;
            this.Label4.Text = "Unit Price";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(308, 57);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(87, 13);
            this.Label3.TabIndex = 22;
            this.Label3.Text = "Quantity Per Unit";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(308, 30);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(35, 13);
            this.Label1.TabIndex = 21;
            this.Label1.Text = "Name";
            // 
            // OrderTextBox
            // 
            this.OrderTextBox.Location = new System.Drawing.Point(414, 128);
            this.OrderTextBox.Name = "OrderTextBox";
            this.OrderTextBox.Size = new System.Drawing.Size(209, 20);
            this.OrderTextBox.TabIndex = 20;
            // 
            // DiscontinuedCheckBox
            // 
            this.DiscontinuedCheckBox.AutoSize = true;
            this.DiscontinuedCheckBox.Location = new System.Drawing.Point(414, 158);
            this.DiscontinuedCheckBox.Name = "DiscontinuedCheckBox";
            this.DiscontinuedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.DiscontinuedCheckBox.TabIndex = 19;
            this.DiscontinuedCheckBox.UseVisualStyleBackColor = true;
            // 
            // StockTextBox
            // 
            this.StockTextBox.Location = new System.Drawing.Point(414, 102);
            this.StockTextBox.Name = "StockTextBox";
            this.StockTextBox.Size = new System.Drawing.Size(209, 20);
            this.StockTextBox.TabIndex = 18;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(414, 76);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(209, 20);
            this.PriceTextBox.TabIndex = 17;
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(414, 50);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(209, 20);
            this.QuantityTextBox.TabIndex = 16;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(414, 24);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.ReadOnly = true;
            this.NameTextBox.Size = new System.Drawing.Size(209, 20);
            this.NameTextBox.TabIndex = 15;
            // 
            // ProductsListBox
            // 
            this.ProductsListBox.FormattingEnabled = true;
            this.ProductsListBox.Location = new System.Drawing.Point(29, 24);
            this.ProductsListBox.Name = "ProductsListBox";
            this.ProductsListBox.Size = new System.Drawing.Size(247, 381);
            this.ProductsListBox.TabIndex = 1;
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.ProductsDataGridView);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(696, 433);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Grid";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // ProductsDataGridView
            // 
            this.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ProductsDataGridView.Name = "ProductsDataGridView";
            this.ProductsDataGridView.Size = new System.Drawing.Size(690, 427);
            this.ProductsDataGridView.TabIndex = 0;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 484);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "DataForm";
            this.Text = "Data Binding";
            this.Load += new System.EventHandler(this.DataForm_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel1;
        internal System.Windows.Forms.ToolStripComboBox CategoryToolStripComboBox;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripLabel ToolStripLabel2;
        internal System.Windows.Forms.ToolStripComboBox SourceToolStripComboBox;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton BackToolStripButton;
        internal System.Windows.Forms.ToolStripButton ForwardToolStripButton;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        internal System.Windows.Forms.ToolStripButton AddToolStripButton;
        internal System.Windows.Forms.ToolStripButton DeleteToolStripButton;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        internal System.Windows.Forms.ToolStripButton SaveToolStripButton;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage1;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox OrderTextBox;
        internal System.Windows.Forms.CheckBox DiscontinuedCheckBox;
        internal System.Windows.Forms.TextBox StockTextBox;
        internal System.Windows.Forms.TextBox PriceTextBox;
        internal System.Windows.Forms.TextBox QuantityTextBox;
        internal System.Windows.Forms.TextBox NameTextBox;
        internal System.Windows.Forms.ListBox ProductsListBox;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.DataGridView ProductsDataGridView;
    }
}

