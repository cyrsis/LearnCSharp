namespace _10_02_02
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
            this.txtLastReceiptDate = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtQrySupplierID = new System.Windows.Forms.TextBox();
            this.Label15 = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.txtJoinMan = new System.Windows.Forms.TextBox();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.txtEarNo = new System.Windows.Forms.TextBox();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtAttribName = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLastReceiptDate
            // 
            this.txtLastReceiptDate.Location = new System.Drawing.Point(405, 266);
            this.txtLastReceiptDate.Name = "txtLastReceiptDate";
            this.txtLastReceiptDate.ReadOnly = true;
            this.txtLastReceiptDate.Size = new System.Drawing.Size(139, 27);
            this.txtLastReceiptDate.TabIndex = 116;
            this.txtLastReceiptDate.TabStop = false;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(285, 270);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(120, 16);
            this.Label16.TabIndex = 115;
            this.Label16.Text = "最後進貨日期：";
            // 
            // txtQrySupplierID
            // 
            this.txtQrySupplierID.Location = new System.Drawing.Point(216, 48);
            this.txtQrySupplierID.Name = "txtQrySupplierID";
            this.txtQrySupplierID.Size = new System.Drawing.Size(100, 27);
            this.txtQrySupplierID.TabIndex = 113;
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(8, 52);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(200, 16);
            this.Label15.TabIndex = 114;
            this.Label15.Text = "請輸入要查詢的廠商編號：";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(320, 48);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 29);
            this.btnQuery.TabIndex = 112;
            this.btnQuery.Text = "查詢";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label1.Location = new System.Drawing.Point(8, 8);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(177, 35);
            this.Label1.TabIndex = 111;
            this.Label1.Text = "廠商修改作業";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(468, 500);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 110;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(99, 378);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(445, 115);
            this.txtComment.TabIndex = 108;
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Location = new System.Drawing.Point(405, 340);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(100, 27);
            this.txtMobilePhone.TabIndex = 106;
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(405, 302);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(139, 27);
            this.txtFax.TabIndex = 104;
            // 
            // txtTel2
            // 
            this.txtTel2.Location = new System.Drawing.Point(100, 340);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(139, 27);
            this.txtTel2.TabIndex = 103;
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(100, 302);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(139, 27);
            this.txtTel1.TabIndex = 100;
            // 
            // txtJoinMan
            // 
            this.txtJoinMan.Location = new System.Drawing.Point(100, 267);
            this.txtJoinMan.Name = "txtJoinMan";
            this.txtJoinMan.Size = new System.Drawing.Size(100, 27);
            this.txtJoinMan.TabIndex = 98;
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Location = new System.Drawing.Point(100, 232);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(445, 27);
            this.txtDeliveryAddress.TabIndex = 97;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Location = new System.Drawing.Point(100, 197);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(444, 27);
            this.txtCompanyAddress.TabIndex = 94;
            // 
            // txtEarNo
            // 
            this.txtEarNo.Location = new System.Drawing.Point(100, 162);
            this.txtEarNo.Name = "txtEarNo";
            this.txtEarNo.Size = new System.Drawing.Size(100, 27);
            this.txtEarNo.TabIndex = 92;
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(100, 127);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(444, 27);
            this.txtCompanyName.TabIndex = 89;
            // 
            // txtAttribName
            // 
            this.txtAttribName.Location = new System.Drawing.Point(440, 92);
            this.txtAttribName.Name = "txtAttribName";
            this.txtAttribName.Size = new System.Drawing.Size(100, 27);
            this.txtAttribName.TabIndex = 88;
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Location = new System.Drawing.Point(104, 92);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.ReadOnly = true;
            this.txtSupplierID.Size = new System.Drawing.Size(100, 27);
            this.txtSupplierID.TabIndex = 86;
            this.txtSupplierID.TabStop = false;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(12, 377);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(56, 16);
            this.Label14.TabIndex = 109;
            this.Label14.Text = "備註：";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(12, 234);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(88, 16);
            this.Label12.TabIndex = 107;
            this.Label12.Text = "送貨地址：";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(12, 199);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(88, 16);
            this.Label11.TabIndex = 105;
            this.Label11.Text = "公司地址：";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(317, 343);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(88, 16);
            this.Label10.TabIndex = 102;
            this.Label10.Text = "行動電話：";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(349, 305);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(56, 16);
            this.Label9.TabIndex = 101;
            this.Label9.Text = "傳真：";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(12, 342);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(64, 16);
            this.Label8.TabIndex = 99;
            this.Label8.Text = "電話2：";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(12, 306);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(64, 16);
            this.Label7.TabIndex = 96;
            this.Label7.Text = "電話1：";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(12, 268);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(72, 16);
            this.Label6.TabIndex = 95;
            this.Label6.Text = "聯絡人：";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(12, 164);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(88, 16);
            this.Label5.TabIndex = 93;
            this.Label5.Text = "統一編號：";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(348, 96);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(88, 16);
            this.Label4.TabIndex = 91;
            this.Label4.Text = "廠商簡稱：";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(10, 129);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(88, 16);
            this.Label3.TabIndex = 90;
            this.Label3.Text = "廠商名稱：";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(11, 94);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(88, 16);
            this.Label2.TabIndex = 87;
            this.Label2.Text = "廠商編號：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 540);
            this.Controls.Add(this.txtLastReceiptDate);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.txtQrySupplierID);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtMobilePhone);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.txtTel1);
            this.Controls.Add(this.txtJoinMan);
            this.Controls.Add(this.txtDeliveryAddress);
            this.Controls.Add(this.txtCompanyAddress);
            this.Controls.Add(this.txtEarNo);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.txtAttribName);
            this.Controls.Add(this.txtSupplierID);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "10-02-02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtLastReceiptDate;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox txtQrySupplierID;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Button btnQuery;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.TextBox txtComment;
        internal System.Windows.Forms.TextBox txtMobilePhone;
        internal System.Windows.Forms.TextBox txtFax;
        internal System.Windows.Forms.TextBox txtTel2;
        internal System.Windows.Forms.TextBox txtTel1;
        internal System.Windows.Forms.TextBox txtJoinMan;
        internal System.Windows.Forms.TextBox txtDeliveryAddress;
        internal System.Windows.Forms.TextBox txtCompanyAddress;
        internal System.Windows.Forms.TextBox txtEarNo;
        internal System.Windows.Forms.TextBox txtCompanyName;
        internal System.Windows.Forms.TextBox txtAttribName;
        internal System.Windows.Forms.TextBox txtSupplierID;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
    }
}

