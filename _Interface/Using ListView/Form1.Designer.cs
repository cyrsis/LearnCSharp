namespace Using_ListView
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
            this.carListView = new System.Windows.Forms.ListView();
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.topSpeedCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.horsepowerCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.priceRadioButton = new System.Windows.Forms.RadioButton();
            this.descendingCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // carListView
            // 
            this.carListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameCol,
            this.priceCol,
            this.topSpeedCol,
            this.horsepowerCol});
            this.carListView.Location = new System.Drawing.Point(19, 50);
            this.carListView.Margin = new System.Windows.Forms.Padding(6);
            this.carListView.Name = "carListView";
            this.carListView.Size = new System.Drawing.Size(727, 347);
            this.carListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.carListView.TabIndex = 4;
            this.carListView.UseCompatibleStateImageBehavior = false;
            this.carListView.View = System.Windows.Forms.View.Details;
            // 
            // nameCol
            // 
            this.nameCol.Text = "Name";
            this.nameCol.Width = 300;
            // 
            // priceCol
            // 
            this.priceCol.Text = "Price";
            this.priceCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.priceCol.Width = 150;
            // 
            // topSpeedCol
            // 
            this.topSpeedCol.Text = "Top Speed";
            this.topSpeedCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.topSpeedCol.Width = 120;
            // 
            // horsepowerCol
            // 
            this.horsepowerCol.Text = "Horsepower";
            this.horsepowerCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.horsepowerCol.Width = 130;
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new System.Drawing.Point(19, 13);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(79, 28);
            this.nameRadioButton.TabIndex = 5;
            this.nameRadioButton.Text = "Name";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            this.nameRadioButton.Click += new System.EventHandler(this.nameRadioButton_Click);
            // 
            // priceRadioButton
            // 
            this.priceRadioButton.AutoSize = true;
            this.priceRadioButton.Location = new System.Drawing.Point(130, 13);
            this.priceRadioButton.Name = "priceRadioButton";
            this.priceRadioButton.Size = new System.Drawing.Size(71, 28);
            this.priceRadioButton.TabIndex = 6;
            this.priceRadioButton.Text = "Price";
            this.priceRadioButton.UseVisualStyleBackColor = true;
            this.priceRadioButton.Click += new System.EventHandler(this.priceRadioButton_Click);
            // 
            // descendingCheckBox
            // 
            this.descendingCheckBox.AutoSize = true;
            this.descendingCheckBox.Location = new System.Drawing.Point(623, 12);
            this.descendingCheckBox.Name = "descendingCheckBox";
            this.descendingCheckBox.Size = new System.Drawing.Size(131, 28);
            this.descendingCheckBox.TabIndex = 7;
            this.descendingCheckBox.Text = "Descending";
            this.descendingCheckBox.UseVisualStyleBackColor = true;
            this.descendingCheckBox.CheckedChanged += new System.EventHandler(this.descendingCheckBox_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 411);
            this.Controls.Add(this.descendingCheckBox);
            this.Controls.Add(this.carListView);
            this.Controls.Add(this.nameRadioButton);
            this.Controls.Add(this.priceRadioButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Using ListView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView carListView;
        private System.Windows.Forms.ColumnHeader nameCol;
        private System.Windows.Forms.ColumnHeader priceCol;
        private System.Windows.Forms.ColumnHeader topSpeedCol;
        private System.Windows.Forms.ColumnHeader horsepowerCol;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.RadioButton priceRadioButton;
        private System.Windows.Forms.CheckBox descendingCheckBox;
    }
}

