namespace XIN2012
{
    partial class fmQryDeliveryList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmQryDeliveryList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this.btnQuery = new System.Windows.Forms.Button();
            this.BeginDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Label4 = new System.Windows.Forms.Label();
            this.EndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.RadioButton2);
            this.Panel1.Controls.Add(this.RadioButton1);
            this.Panel1.Controls.Add(this.btnQuery);
            this.Panel1.Controls.Add(this.BeginDateDateTimePicker);
            this.Panel1.Controls.Add(this.Label4);
            this.Panel1.Controls.Add(this.EndDateDateTimePicker);
            this.Panel1.Controls.Add(this.Label3);
            this.Panel1.Controls.Add(this.CustomerIDTextBox);
            this.Panel1.Controls.Add(this.Label2);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Controls.Add(this.CompanyNameTextBox);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(992, 120);
            this.Panel1.TabIndex = 6;
            // 
            // RadioButton2
            // 
            this.RadioButton2.AutoSize = true;
            this.RadioButton2.Location = new System.Drawing.Point(176, 88);
            this.RadioButton2.Margin = new System.Windows.Forms.Padding(5);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.Size = new System.Drawing.Size(91, 24);
            this.RadioButton2.TabIndex = 55;
            this.RadioButton2.Text = "出貨退回";
            this.RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton1
            // 
            this.RadioButton1.AutoSize = true;
            this.RadioButton1.Checked = true;
            this.RadioButton1.Location = new System.Drawing.Point(92, 88);
            this.RadioButton1.Margin = new System.Windows.Forms.Padding(5);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.Size = new System.Drawing.Size(59, 24);
            this.RadioButton1.TabIndex = 54;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "出貨";
            this.RadioButton1.UseVisualStyleBackColor = true;
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.Location = new System.Drawing.Point(516, 48);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(108, 56);
            this.btnQuery.TabIndex = 53;
            this.btnQuery.Text = "查詢";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // BeginDateDateTimePicker
            // 
            this.BeginDateDateTimePicker.Location = new System.Drawing.Point(92, 48);
            this.BeginDateDateTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.BeginDateDateTimePicker.Name = "BeginDateDateTimePicker";
            this.BeginDateDateTimePicker.Size = new System.Drawing.Size(160, 29);
            this.BeginDateDateTimePicker.TabIndex = 46;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(260, 52);
            this.Label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(25, 20);
            this.Label4.TabIndex = 48;
            this.Label4.Text = "～";
            // 
            // EndDateDateTimePicker
            // 
            this.EndDateDateTimePicker.Location = new System.Drawing.Point(296, 48);
            this.EndDateDateTimePicker.Margin = new System.Windows.Forms.Padding(5);
            this.EndDateDateTimePicker.Name = "EndDateDateTimePicker";
            this.EndDateDateTimePicker.Size = new System.Drawing.Size(160, 29);
            this.EndDateDateTimePicker.TabIndex = 47;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 52);
            this.Label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(73, 20);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "出貨日期";
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(92, 8);
            this.CustomerIDTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.ReadOnly = true;
            this.CustomerIDTextBox.Size = new System.Drawing.Size(84, 29);
            this.CustomerIDTextBox.TabIndex = 1;
            this.CustomerIDTextBox.TabStop = false;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(228, 12);
            this.Label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 20);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "客戶名稱";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 12);
            this.Label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(73, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "客戶編號";
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(308, 8);
            this.CompanyNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.ReadOnly = true;
            this.CompanyNameTextBox.Size = new System.Drawing.Size(315, 29);
            this.CompanyNameTextBox.TabIndex = 2;
            this.CompanyNameTextBox.TabStop = false;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.Location = new System.Drawing.Point(0, 120);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(992, 397);
            this.DataGridView1.TabIndex = 7;
            // 
            // fmQryDeliveryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 517);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmQryDeliveryList";
            this.ShowInTaskbar = false;
            this.Text = "客戶出貨（出貨退回）記錄查詢";
            this.Load += new System.EventHandler(this.fmQryDeliveryList_Load);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.RadioButton RadioButton2;
        internal System.Windows.Forms.RadioButton RadioButton1;
        internal System.Windows.Forms.Button btnQuery;
        internal System.Windows.Forms.DateTimePicker BeginDateDateTimePicker;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.DateTimePicker EndDateDateTimePicker;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox CustomerIDTextBox;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox CompanyNameTextBox;
        internal System.Windows.Forms.DataGridView DataGridView1;
    }
}