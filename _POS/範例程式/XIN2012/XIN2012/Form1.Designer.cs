namespace XIN2012
{
    partial class fmForm1
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
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label transferDateLabel;
            System.Windows.Forms.Label transferIDLabel;
            System.Windows.Forms.Label transferTypeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmForm1));
            this.transferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transferBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.transferBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.transferDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.transferIDTextBox = new System.Windows.Forms.TextBox();
            this.transferTypeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            amountLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            transferDateLabel = new System.Windows.Forms.Label();
            transferIDLabel = new System.Windows.Forms.Label();
            transferTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferBindingNavigator)).BeginInit();
            this.transferBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(92, 83);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(46, 12);
            amountLabel.TabIndex = 1;
            amountLabel.Text = "Amount:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(92, 111);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(54, 12);
            commentLabel.TabIndex = 3;
            commentLabel.Text = "Comment:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(92, 139);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 12);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // transferDateLabel
            // 
            transferDateLabel.AutoSize = true;
            transferDateLabel.Location = new System.Drawing.Point(92, 168);
            transferDateLabel.Name = "transferDateLabel";
            transferDateLabel.Size = new System.Drawing.Size(71, 12);
            transferDateLabel.TabIndex = 7;
            transferDateLabel.Text = "Transfer Date:";
            // 
            // transferIDLabel
            // 
            transferIDLabel.AutoSize = true;
            transferIDLabel.Location = new System.Drawing.Point(92, 195);
            transferIDLabel.Name = "transferIDLabel";
            transferIDLabel.Size = new System.Drawing.Size(62, 12);
            transferIDLabel.TabIndex = 9;
            transferIDLabel.Text = "Transfer ID:";
            // 
            // transferTypeLabel
            // 
            transferTypeLabel.AutoSize = true;
            transferTypeLabel.Location = new System.Drawing.Point(92, 223);
            transferTypeLabel.Name = "transferTypeLabel";
            transferTypeLabel.Size = new System.Drawing.Size(74, 12);
            transferTypeLabel.TabIndex = 11;
            transferTypeLabel.Text = "Transfer Type:";
            // 
            // transferBindingSource
            // 
            this.transferBindingSource.DataSource = typeof(XIN2012.Transfer);
            // 
            // transferBindingNavigator
            // 
            this.transferBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.transferBindingNavigator.BindingSource = this.transferBindingSource;
            this.transferBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.transferBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.transferBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.transferBindingNavigatorSaveItem});
            this.transferBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.transferBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.transferBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.transferBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.transferBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.transferBindingNavigator.Name = "transferBindingNavigator";
            this.transferBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.transferBindingNavigator.Size = new System.Drawing.Size(815, 25);
            this.transferBindingNavigator.TabIndex = 0;
            this.transferBindingNavigator.Text = "bindingNavigator1";
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
            // transferBindingNavigatorSaveItem
            // 
            this.transferBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.transferBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("transferBindingNavigatorSaveItem.Image")));
            this.transferBindingNavigatorSaveItem.Name = "transferBindingNavigatorSaveItem";
            this.transferBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.transferBindingNavigatorSaveItem.Text = "儲存資料";
            this.transferBindingNavigatorSaveItem.Click += new System.EventHandler(this.transferBindingNavigatorSaveItem_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transferBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(172, 80);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(200, 22);
            this.amountTextBox.TabIndex = 2;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transferBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(172, 108);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(200, 22);
            this.commentTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transferBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(172, 136);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(200, 22);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // transferDateDateTimePicker
            // 
            this.transferDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.transferBindingSource, "TransferDate", true));
            this.transferDateDateTimePicker.Location = new System.Drawing.Point(172, 164);
            this.transferDateDateTimePicker.Name = "transferDateDateTimePicker";
            this.transferDateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.transferDateDateTimePicker.TabIndex = 8;
            // 
            // transferIDTextBox
            // 
            this.transferIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transferBindingSource, "TransferID", true));
            this.transferIDTextBox.Location = new System.Drawing.Point(172, 192);
            this.transferIDTextBox.Name = "transferIDTextBox";
            this.transferIDTextBox.Size = new System.Drawing.Size(200, 22);
            this.transferIDTextBox.TabIndex = 10;
            // 
            // transferTypeTextBox
            // 
            this.transferTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transferBindingSource, "TransferType", true));
            this.transferTypeTextBox.Location = new System.Drawing.Point(172, 220);
            this.transferTypeTextBox.Name = "transferTypeTextBox";
            this.transferTypeTextBox.Size = new System.Drawing.Size(200, 22);
            this.transferTypeTextBox.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(88, 272);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(652, 160);
            this.listBox1.TabIndex = 14;
            // 
            // fmForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 471);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(commentLabel);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(transferDateLabel);
            this.Controls.Add(this.transferDateDateTimePicker);
            this.Controls.Add(transferIDLabel);
            this.Controls.Add(this.transferIDTextBox);
            this.Controls.Add(transferTypeLabel);
            this.Controls.Add(this.transferTypeTextBox);
            this.Controls.Add(this.transferBindingNavigator);
            this.Name = "fmForm1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferBindingNavigator)).EndInit();
            this.transferBindingNavigator.ResumeLayout(false);
            this.transferBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource transferBindingSource;
        private System.Windows.Forms.BindingNavigator transferBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton transferBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.DateTimePicker transferDateDateTimePicker;
        private System.Windows.Forms.TextBox transferIDTextBox;
        private System.Windows.Forms.TextBox transferTypeTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}