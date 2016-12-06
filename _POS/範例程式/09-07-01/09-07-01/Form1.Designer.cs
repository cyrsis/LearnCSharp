namespace _09_07_01
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
            this.Label1 = new System.Windows.Forms.Label();
            this.radioLINQtoEntities = new System.Windows.Forms.RadioButton();
            this.radioEntitySQL = new System.Windows.Forms.RadioButton();
            this.radioQueryBuilderMethods = new System.Windows.Forms.RadioButton();
            this.btnAny = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(92, 16);
            this.Label1.TabIndex = 35;
            this.Label1.Text = "查詢類型 ：";
            // 
            // radioLINQtoEntities
            // 
            this.radioLINQtoEntities.AutoSize = true;
            this.radioLINQtoEntities.Checked = true;
            this.radioLINQtoEntities.Location = new System.Drawing.Point(12, 40);
            this.radioLINQtoEntities.Margin = new System.Windows.Forms.Padding(5);
            this.radioLINQtoEntities.Name = "radioLINQtoEntities";
            this.radioLINQtoEntities.Size = new System.Drawing.Size(128, 20);
            this.radioLINQtoEntities.TabIndex = 25;
            this.radioLINQtoEntities.TabStop = true;
            this.radioLINQtoEntities.Text = "LINQ to Entities";
            this.radioLINQtoEntities.UseVisualStyleBackColor = true;
            // 
            // radioEntitySQL
            // 
            this.radioEntitySQL.AutoSize = true;
            this.radioEntitySQL.Location = new System.Drawing.Point(12, 72);
            this.radioEntitySQL.Margin = new System.Windows.Forms.Padding(5);
            this.radioEntitySQL.Name = "radioEntitySQL";
            this.radioEntitySQL.Size = new System.Drawing.Size(95, 20);
            this.radioEntitySQL.TabIndex = 26;
            this.radioEntitySQL.Text = "Entity SQL";
            this.radioEntitySQL.UseVisualStyleBackColor = true;
            // 
            // radioQueryBuilderMethods
            // 
            this.radioQueryBuilderMethods.AutoSize = true;
            this.radioQueryBuilderMethods.Location = new System.Drawing.Point(12, 104);
            this.radioQueryBuilderMethods.Margin = new System.Windows.Forms.Padding(5);
            this.radioQueryBuilderMethods.Name = "radioQueryBuilderMethods";
            this.radioQueryBuilderMethods.Size = new System.Drawing.Size(106, 20);
            this.radioQueryBuilderMethods.TabIndex = 28;
            this.radioQueryBuilderMethods.Text = "查詢產生器";
            this.radioQueryBuilderMethods.UseVisualStyleBackColor = true;
            // 
            // btnAny
            // 
            this.btnAny.Location = new System.Drawing.Point(4, 424);
            this.btnAny.Margin = new System.Windows.Forms.Padding(5);
            this.btnAny.Name = "btnAny";
            this.btnAny.Size = new System.Drawing.Size(276, 38);
            this.btnAny.TabIndex = 34;
            this.btnAny.Text = "是否有任何一筆的售價大於500(Any)";
            this.btnAny.UseVisualStyleBackColor = true;
            this.btnAny.Click += new System.EventHandler(this.btnAny_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(4, 376);
            this.btnAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(276, 38);
            this.btnAll.TabIndex = 33;
            this.btnAll.Text = "是否所有的售價皆大於500(All)";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(4, 328);
            this.btnCount.Margin = new System.Windows.Forms.Padding(5);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(276, 38);
            this.btnCount.TabIndex = 32;
            this.btnCount.Text = "累計出貨單筆數(Count)";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(4, 280);
            this.btnMin.Margin = new System.Windows.Forms.Padding(5);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(276, 38);
            this.btnMin.TabIndex = 31;
            this.btnMin.Text = "金額最小的出貨明細(Min)";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(4, 232);
            this.btnMax.Margin = new System.Windows.Forms.Padding(5);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(276, 38);
            this.btnMax.TabIndex = 30;
            this.btnMax.Text = "單筆最高的出貨金額(Max)";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(4, 184);
            this.btnAverage.Margin = new System.Windows.Forms.Padding(5);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(276, 38);
            this.btnAverage.TabIndex = 29;
            this.btnAverage.Text = "出貨單平均接單金額(Average)";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(4, 136);
            this.btnSum.Margin = new System.Windows.Forms.Padding(5);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(276, 38);
            this.btnSum.TabIndex = 27;
            this.btnSum.Text = "出貨金額統計(Sum)";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(292, 8);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(452, 452);
            this.listBox1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 470);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.radioLINQtoEntities);
            this.Controls.Add(this.radioEntitySQL);
            this.Controls.Add(this.radioQueryBuilderMethods);
            this.Controls.Add(this.btnAny);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "09-07-01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.RadioButton radioLINQtoEntities;
        internal System.Windows.Forms.RadioButton radioEntitySQL;
        internal System.Windows.Forms.RadioButton radioQueryBuilderMethods;
        internal System.Windows.Forms.Button btnAny;
        internal System.Windows.Forms.Button btnAll;
        internal System.Windows.Forms.Button btnCount;
        internal System.Windows.Forms.Button btnMin;
        internal System.Windows.Forms.Button btnMax;
        internal System.Windows.Forms.Button btnAverage;
        internal System.Windows.Forms.Button btnSum;
        internal System.Windows.Forms.ListBox listBox1;
    }
}

