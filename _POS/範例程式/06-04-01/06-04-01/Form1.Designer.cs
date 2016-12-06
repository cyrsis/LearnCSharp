namespace _06_04_01
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
            System.Windows.Forms.Label deliveryIDLabel;
            System.Windows.Forms.Label deliveryDateLabel;
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label joinManLabel;
            System.Windows.Forms.Label deliveryTypeLabel;
            System.Windows.Forms.Label invoiceNoLabel;
            System.Windows.Forms.Label subTotalLabel;
            System.Windows.Forms.Label valueAddTaxLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label shipAddressLabel;
            System.Windows.Forms.Label commentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cn = new System.Data.SqlClient.SqlConnection();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.daDelivery = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlSelectCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand2 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand2 = new System.Data.SqlClient.SqlCommand();
            this.daDeliveryDetails = new System.Data.SqlClient.SqlDataAdapter();
            this.dsXIN1 = new _06_04_01.dsXIN();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnFill = new System.Windows.Forms.ToolStripButton();
            this.deliveryIDTextBox = new System.Windows.Forms.TextBox();
            this.deliveryDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.joinManTextBox = new System.Windows.Forms.TextBox();
            this.deliveryTypeTextBox = new System.Windows.Forms.TextBox();
            this.invoiceNoTextBox = new System.Windows.Forms.TextBox();
            this.subTotalTextBox = new System.Windows.Forms.TextBox();
            this.valueAddTaxTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.shipAddressTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.deliveryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deliveryDetailsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            deliveryIDLabel = new System.Windows.Forms.Label();
            deliveryDateLabel = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            joinManLabel = new System.Windows.Forms.Label();
            deliveryTypeLabel = new System.Windows.Forms.Label();
            invoiceNoLabel = new System.Windows.Forms.Label();
            subTotalLabel = new System.Windows.Forms.Label();
            valueAddTaxLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            shipAddressLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsXIN1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingNavigator)).BeginInit();
            this.deliveryBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDetailsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDetailsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deliveryIDLabel
            // 
            deliveryIDLabel.AutoSize = true;
            deliveryIDLabel.Location = new System.Drawing.Point(456, 16);
            deliveryIDLabel.Name = "deliveryIDLabel";
            deliveryIDLabel.Size = new System.Drawing.Size(72, 16);
            deliveryIDLabel.TabIndex = 1;
            deliveryIDLabel.Text = "出貨單號";
            // 
            // deliveryDateLabel
            // 
            deliveryDateLabel.AutoSize = true;
            deliveryDateLabel.Location = new System.Drawing.Point(20, 16);
            deliveryDateLabel.Name = "deliveryDateLabel";
            deliveryDateLabel.Size = new System.Drawing.Size(72, 16);
            deliveryDateLabel.TabIndex = 3;
            deliveryDateLabel.Text = "出貨日期";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(20, 52);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(72, 16);
            customerIDLabel.TabIndex = 5;
            customerIDLabel.Text = "客戶編號";
            // 
            // joinManLabel
            // 
            joinManLabel.AutoSize = true;
            joinManLabel.Location = new System.Drawing.Point(24, 88);
            joinManLabel.Name = "joinManLabel";
            joinManLabel.Size = new System.Drawing.Size(56, 16);
            joinManLabel.TabIndex = 7;
            joinManLabel.Text = "聯絡人";
            // 
            // deliveryTypeLabel
            // 
            deliveryTypeLabel.AutoSize = true;
            deliveryTypeLabel.Location = new System.Drawing.Point(456, 48);
            deliveryTypeLabel.Name = "deliveryTypeLabel";
            deliveryTypeLabel.Size = new System.Drawing.Size(72, 16);
            deliveryTypeLabel.TabIndex = 9;
            deliveryTypeLabel.Text = "出貨類別";
            // 
            // invoiceNoLabel
            // 
            invoiceNoLabel.AutoSize = true;
            invoiceNoLabel.Location = new System.Drawing.Point(456, 84);
            invoiceNoLabel.Name = "invoiceNoLabel";
            invoiceNoLabel.Size = new System.Drawing.Size(72, 16);
            invoiceNoLabel.TabIndex = 11;
            invoiceNoLabel.Text = "發票號碼";
            // 
            // subTotalLabel
            // 
            subTotalLabel.AutoSize = true;
            subTotalLabel.Location = new System.Drawing.Point(456, 14);
            subTotalLabel.Name = "subTotalLabel";
            subTotalLabel.Size = new System.Drawing.Size(72, 16);
            subTotalLabel.TabIndex = 13;
            subTotalLabel.Text = "銷售金額";
            // 
            // valueAddTaxLabel
            // 
            valueAddTaxLabel.AutoSize = true;
            valueAddTaxLabel.Location = new System.Drawing.Point(456, 52);
            valueAddTaxLabel.Name = "valueAddTaxLabel";
            valueAddTaxLabel.Size = new System.Drawing.Size(56, 16);
            valueAddTaxLabel.TabIndex = 15;
            valueAddTaxLabel.Text = "營業稅";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(456, 88);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(72, 16);
            amountLabel.TabIndex = 17;
            amountLabel.Text = "總計金額";
            // 
            // shipAddressLabel
            // 
            shipAddressLabel.AutoSize = true;
            shipAddressLabel.Location = new System.Drawing.Point(20, 124);
            shipAddressLabel.Name = "shipAddressLabel";
            shipAddressLabel.Size = new System.Drawing.Size(72, 16);
            shipAddressLabel.TabIndex = 19;
            shipAddressLabel.Text = "出貨地址";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(12, 12);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(40, 16);
            commentLabel.TabIndex = 21;
            commentLabel.Text = "備註";
            // 
            // cn
            // 
            this.cn.ConnectionString = "Data Source=BENNY-VAIO;Initial Catalog=XIN;Integrated Security=True";
            this.cn.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT          Delivery.*\r\nFROM              Delivery";
            this.sqlSelectCommand1.Connection = this.cn;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.cn;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@DeliveryID", System.Data.SqlDbType.VarChar, 0, "DeliveryID"),
            new System.Data.SqlClient.SqlParameter("@DeliveryDate", System.Data.SqlDbType.Date, 0, "DeliveryDate"),
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.VarChar, 0, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@JoinMan", System.Data.SqlDbType.NVarChar, 0, "JoinMan"),
            new System.Data.SqlClient.SqlParameter("@DeliveryType", System.Data.SqlDbType.Char, 0, "DeliveryType"),
            new System.Data.SqlClient.SqlParameter("@InvoiceNo", System.Data.SqlDbType.VarChar, 0, "InvoiceNo"),
            new System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Int, 0, "SubTotal"),
            new System.Data.SqlClient.SqlParameter("@ValueAddTax", System.Data.SqlDbType.Int, 0, "ValueAddTax"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Int, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 0, "ShipAddress"),
            new System.Data.SqlClient.SqlParameter("@Comment", System.Data.SqlDbType.NText, 0, "Comment")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.cn;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@DeliveryID", System.Data.SqlDbType.VarChar, 0, "DeliveryID"),
            new System.Data.SqlClient.SqlParameter("@DeliveryDate", System.Data.SqlDbType.Date, 0, "DeliveryDate"),
            new System.Data.SqlClient.SqlParameter("@CustomerID", System.Data.SqlDbType.VarChar, 0, "CustomerID"),
            new System.Data.SqlClient.SqlParameter("@JoinMan", System.Data.SqlDbType.NVarChar, 0, "JoinMan"),
            new System.Data.SqlClient.SqlParameter("@DeliveryType", System.Data.SqlDbType.Char, 0, "DeliveryType"),
            new System.Data.SqlClient.SqlParameter("@InvoiceNo", System.Data.SqlDbType.VarChar, 0, "InvoiceNo"),
            new System.Data.SqlClient.SqlParameter("@SubTotal", System.Data.SqlDbType.Int, 0, "SubTotal"),
            new System.Data.SqlClient.SqlParameter("@ValueAddTax", System.Data.SqlDbType.Int, 0, "ValueAddTax"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Int, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@ShipAddress", System.Data.SqlDbType.NVarChar, 0, "ShipAddress"),
            new System.Data.SqlClient.SqlParameter("@Comment", System.Data.SqlDbType.NText, 0, "Comment"),
            new System.Data.SqlClient.SqlParameter("@Original_DeliveryID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DeliveryID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DeliveryDate", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DeliveryDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_JoinMan", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "JoinMan", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_JoinMan", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JoinMan", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DeliveryType", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DeliveryType", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InvoiceNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InvoiceNo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InvoiceNo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InvoiceNo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SubTotal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ValueAddTax", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ValueAddTax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ShipAddress", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.cn;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_DeliveryID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DeliveryID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DeliveryDate", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DeliveryDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_JoinMan", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "JoinMan", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_JoinMan", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "JoinMan", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DeliveryType", System.Data.SqlDbType.Char, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DeliveryType", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_InvoiceNo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "InvoiceNo", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_InvoiceNo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "InvoiceNo", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_SubTotal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "SubTotal", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ValueAddTax", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ValueAddTax", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_ShipAddress", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_ShipAddress", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ShipAddress", System.Data.DataRowVersion.Original, null)});
            // 
            // daDelivery
            // 
            this.daDelivery.DeleteCommand = this.sqlDeleteCommand1;
            this.daDelivery.InsertCommand = this.sqlInsertCommand1;
            this.daDelivery.SelectCommand = this.sqlSelectCommand1;
            this.daDelivery.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Delivery", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("DeliveryID", "DeliveryID"),
                        new System.Data.Common.DataColumnMapping("DeliveryDate", "DeliveryDate"),
                        new System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"),
                        new System.Data.Common.DataColumnMapping("JoinMan", "JoinMan"),
                        new System.Data.Common.DataColumnMapping("DeliveryType", "DeliveryType"),
                        new System.Data.Common.DataColumnMapping("InvoiceNo", "InvoiceNo"),
                        new System.Data.Common.DataColumnMapping("SubTotal", "SubTotal"),
                        new System.Data.Common.DataColumnMapping("ValueAddTax", "ValueAddTax"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount"),
                        new System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"),
                        new System.Data.Common.DataColumnMapping("Comment", "Comment")})});
            this.daDelivery.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlSelectCommand2
            // 
            this.sqlSelectCommand2.CommandText = "SELECT          DeliveryDetails.*\r\nFROM              DeliveryDetails";
            this.sqlSelectCommand2.Connection = this.cn;
            // 
            // sqlInsertCommand2
            // 
            this.sqlInsertCommand2.CommandText = resources.GetString("sqlInsertCommand2.CommandText");
            this.sqlInsertCommand2.Connection = this.cn;
            this.sqlInsertCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@DeliveryID", System.Data.SqlDbType.VarChar, 0, "DeliveryID"),
            new System.Data.SqlClient.SqlParameter("@DeliverySeq", System.Data.SqlDbType.TinyInt, 0, "DeliverySeq"),
            new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.VarChar, 0, "ProductID"),
            new System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.Int, 0, "Quantity"),
            new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Int, 0, "UnitPrice"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Int, 0, "Amount")});
            // 
            // sqlUpdateCommand2
            // 
            this.sqlUpdateCommand2.CommandText = resources.GetString("sqlUpdateCommand2.CommandText");
            this.sqlUpdateCommand2.Connection = this.cn;
            this.sqlUpdateCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@DeliveryID", System.Data.SqlDbType.VarChar, 0, "DeliveryID"),
            new System.Data.SqlClient.SqlParameter("@DeliverySeq", System.Data.SqlDbType.TinyInt, 0, "DeliverySeq"),
            new System.Data.SqlClient.SqlParameter("@ProductID", System.Data.SqlDbType.VarChar, 0, "ProductID"),
            new System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.Int, 0, "Quantity"),
            new System.Data.SqlClient.SqlParameter("@UnitPrice", System.Data.SqlDbType.Int, 0, "UnitPrice"),
            new System.Data.SqlClient.SqlParameter("@Amount", System.Data.SqlDbType.Int, 0, "Amount"),
            new System.Data.SqlClient.SqlParameter("@Original_DeliveryID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DeliveryID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DeliverySeq", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DeliverySeq", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantity", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand2
            // 
            this.sqlDeleteCommand2.CommandText = resources.GetString("sqlDeleteCommand2.CommandText");
            this.sqlDeleteCommand2.Connection = this.cn;
            this.sqlDeleteCommand2.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_DeliveryID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DeliveryID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DeliverySeq", System.Data.SqlDbType.TinyInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DeliverySeq", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_ProductID", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ProductID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Quantity", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Quantity", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UnitPrice", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UnitPrice", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_Amount", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "Amount", System.Data.DataRowVersion.Original, null)});
            // 
            // daDeliveryDetails
            // 
            this.daDeliveryDetails.DeleteCommand = this.sqlDeleteCommand2;
            this.daDeliveryDetails.InsertCommand = this.sqlInsertCommand2;
            this.daDeliveryDetails.SelectCommand = this.sqlSelectCommand2;
            this.daDeliveryDetails.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "DeliveryDetails", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("DeliveryID", "DeliveryID"),
                        new System.Data.Common.DataColumnMapping("DeliverySeq", "DeliverySeq"),
                        new System.Data.Common.DataColumnMapping("ProductID", "ProductID"),
                        new System.Data.Common.DataColumnMapping("Quantity", "Quantity"),
                        new System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"),
                        new System.Data.Common.DataColumnMapping("Amount", "Amount")})});
            this.daDeliveryDetails.UpdateCommand = this.sqlUpdateCommand2;
            // 
            // dsXIN1
            // 
            this.dsXIN1.DataSetName = "dsXIN";
            this.dsXIN1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "Delivery";
            this.deliveryBindingSource.DataSource = this.dsXIN1;
            // 
            // deliveryBindingNavigator
            // 
            this.deliveryBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.deliveryBindingNavigator.BindingSource = this.deliveryBindingSource;
            this.deliveryBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.deliveryBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.deliveryBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnUpdate,
            this.btnFill});
            this.deliveryBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.deliveryBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.deliveryBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.deliveryBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.deliveryBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.deliveryBindingNavigator.Name = "deliveryBindingNavigator";
            this.deliveryBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.deliveryBindingNavigator.Size = new System.Drawing.Size(666, 25);
            this.deliveryBindingNavigator.TabIndex = 0;
            this.deliveryBindingNavigator.Text = "bindingNavigator1";
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
            // btnUpdate
            // 
            this.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(23, 22);
            this.btnUpdate.Text = "儲存資料";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFill
            // 
            this.btnFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFill.Image = ((System.Drawing.Image)(resources.GetObject("btnFill.Image")));
            this.btnFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(36, 22);
            this.btnFill.Text = "載入";
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // deliveryIDTextBox
            // 
            this.deliveryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "DeliveryID", true));
            this.deliveryIDTextBox.Location = new System.Drawing.Point(536, 8);
            this.deliveryIDTextBox.Name = "deliveryIDTextBox";
            this.deliveryIDTextBox.Size = new System.Drawing.Size(104, 27);
            this.deliveryIDTextBox.TabIndex = 2;
            // 
            // deliveryDateDateTimePicker
            // 
            this.deliveryDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.deliveryBindingSource, "DeliveryDate", true));
            this.deliveryDateDateTimePicker.Location = new System.Drawing.Point(100, 12);
            this.deliveryDateDateTimePicker.Name = "deliveryDateDateTimePicker";
            this.deliveryDateDateTimePicker.Size = new System.Drawing.Size(152, 27);
            this.deliveryDateDateTimePicker.TabIndex = 4;
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(100, 48);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.Size = new System.Drawing.Size(112, 27);
            this.customerIDTextBox.TabIndex = 6;
            // 
            // joinManTextBox
            // 
            this.joinManTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "JoinMan", true));
            this.joinManTextBox.Location = new System.Drawing.Point(100, 84);
            this.joinManTextBox.Name = "joinManTextBox";
            this.joinManTextBox.Size = new System.Drawing.Size(200, 27);
            this.joinManTextBox.TabIndex = 8;
            // 
            // deliveryTypeTextBox
            // 
            this.deliveryTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "DeliveryType", true));
            this.deliveryTypeTextBox.Location = new System.Drawing.Point(536, 44);
            this.deliveryTypeTextBox.Name = "deliveryTypeTextBox";
            this.deliveryTypeTextBox.Size = new System.Drawing.Size(40, 27);
            this.deliveryTypeTextBox.TabIndex = 10;
            // 
            // invoiceNoTextBox
            // 
            this.invoiceNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "InvoiceNo", true));
            this.invoiceNoTextBox.Location = new System.Drawing.Point(536, 80);
            this.invoiceNoTextBox.Name = "invoiceNoTextBox";
            this.invoiceNoTextBox.Size = new System.Drawing.Size(100, 27);
            this.invoiceNoTextBox.TabIndex = 12;
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "SubTotal", true));
            this.subTotalTextBox.Location = new System.Drawing.Point(532, 8);
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new System.Drawing.Size(112, 27);
            this.subTotalTextBox.TabIndex = 14;
            // 
            // valueAddTaxTextBox
            // 
            this.valueAddTaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "ValueAddTax", true));
            this.valueAddTaxTextBox.Location = new System.Drawing.Point(532, 44);
            this.valueAddTaxTextBox.Name = "valueAddTaxTextBox";
            this.valueAddTaxTextBox.Size = new System.Drawing.Size(112, 27);
            this.valueAddTaxTextBox.TabIndex = 16;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(532, 80);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(112, 27);
            this.amountTextBox.TabIndex = 18;
            // 
            // shipAddressTextBox
            // 
            this.shipAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "ShipAddress", true));
            this.shipAddressTextBox.Location = new System.Drawing.Point(96, 120);
            this.shipAddressTextBox.Name = "shipAddressTextBox";
            this.shipAddressTextBox.Size = new System.Drawing.Size(544, 27);
            this.shipAddressTextBox.TabIndex = 20;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.deliveryBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(56, 12);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(316, 100);
            this.commentTextBox.TabIndex = 22;
            // 
            // deliveryDetailsBindingSource
            // 
            this.deliveryDetailsBindingSource.DataMember = "FK_Delivery_DeliveryDetails";
            this.deliveryDetailsBindingSource.DataSource = this.deliveryBindingSource;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.deliveryDateDateTimePicker);
            this.panel1.Controls.Add(this.shipAddressTextBox);
            this.panel1.Controls.Add(this.deliveryTypeTextBox);
            this.panel1.Controls.Add(this.deliveryIDTextBox);
            this.panel1.Controls.Add(deliveryIDLabel);
            this.panel1.Controls.Add(shipAddressLabel);
            this.panel1.Controls.Add(this.invoiceNoTextBox);
            this.panel1.Controls.Add(deliveryTypeLabel);
            this.panel1.Controls.Add(deliveryDateLabel);
            this.panel1.Controls.Add(invoiceNoLabel);
            this.panel1.Controls.Add(this.joinManTextBox);
            this.panel1.Controls.Add(customerIDLabel);
            this.panel1.Controls.Add(joinManLabel);
            this.panel1.Controls.Add(this.customerIDTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 163);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(commentLabel);
            this.panel2.Controls.Add(this.commentTextBox);
            this.panel2.Controls.Add(this.amountTextBox);
            this.panel2.Controls.Add(subTotalLabel);
            this.panel2.Controls.Add(amountLabel);
            this.panel2.Controls.Add(this.subTotalTextBox);
            this.panel2.Controls.Add(this.valueAddTaxTextBox);
            this.panel2.Controls.Add(valueAddTaxLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 119);
            this.panel2.TabIndex = 25;
            // 
            // deliveryDetailsDataGridView
            // 
            this.deliveryDetailsDataGridView.AutoGenerateColumns = false;
            this.deliveryDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deliveryDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.deliveryDetailsDataGridView.DataSource = this.deliveryDetailsBindingSource;
            this.deliveryDetailsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deliveryDetailsDataGridView.Location = new System.Drawing.Point(0, 188);
            this.deliveryDetailsDataGridView.Name = "deliveryDetailsDataGridView";
            this.deliveryDetailsDataGridView.RowTemplate.Height = 24;
            this.deliveryDetailsDataGridView.Size = new System.Drawing.Size(666, 156);
            this.deliveryDetailsDataGridView.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DeliveryID";
            this.dataGridViewTextBoxColumn1.HeaderText = "出貨單號";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DeliverySeq";
            this.dataGridViewTextBoxColumn2.HeaderText = "項次";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn3.HeaderText = "商品編號";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "數量";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "單價";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn6.HeaderText = "金額";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 463);
            this.Controls.Add(this.deliveryDetailsDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deliveryBindingNavigator);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "06-04-01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsXIN1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingNavigator)).EndInit();
            this.deliveryBindingNavigator.ResumeLayout(false);
            this.deliveryBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDetailsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDetailsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlConnection cn;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter daDelivery;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand2;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand2;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand2;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand2;
        private System.Data.SqlClient.SqlDataAdapter daDeliveryDetails;
        private dsXIN dsXIN1;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private System.Windows.Forms.BindingNavigator deliveryBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.TextBox deliveryIDTextBox;
        private System.Windows.Forms.DateTimePicker deliveryDateDateTimePicker;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox joinManTextBox;
        private System.Windows.Forms.TextBox deliveryTypeTextBox;
        private System.Windows.Forms.TextBox invoiceNoTextBox;
        private System.Windows.Forms.TextBox subTotalTextBox;
        private System.Windows.Forms.TextBox valueAddTaxTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox shipAddressTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.BindingSource deliveryDetailsBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView deliveryDetailsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripButton btnFill;
    }
}

