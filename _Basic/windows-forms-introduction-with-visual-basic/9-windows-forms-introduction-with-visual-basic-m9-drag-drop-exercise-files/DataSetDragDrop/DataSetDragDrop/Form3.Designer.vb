<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim CategoryIDLabel As System.Windows.Forms.Label
        Dim QuantityPerUnitLabel As System.Windows.Forms.Label
        Dim UnitPriceLabel As System.Windows.Forms.Label
        Dim UnitsInStockLabel As System.Windows.Forms.Label
        Dim UnitsOnOrderLabel As System.Windows.Forms.Label
        Dim DiscontinuedLabel As System.Windows.Forms.Label
        Me.NorthwindDataSet = New DataSetDragDrop.NorthwindDataSet()
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriesTableAdapter = New DataSetDragDrop.NorthwindDataSetTableAdapters.CategoriesTableAdapter()
        Me.TableAdapterManager = New DataSetDragDrop.NorthwindDataSetTableAdapters.TableAdapterManager()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New DataSetDragDrop.NorthwindDataSetTableAdapters.ProductsTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryIDLabel1 = New System.Windows.Forms.Label()
        Me.QuantityPerUnitTextBox = New System.Windows.Forms.TextBox()
        Me.UnitPriceTextBox = New System.Windows.Forms.TextBox()
        Me.UnitsInStockTextBox = New System.Windows.Forms.TextBox()
        Me.UnitsOnOrderTextBox = New System.Windows.Forms.TextBox()
        Me.DiscontinuedCheckBox = New System.Windows.Forms.CheckBox()
        ProductNameLabel = New System.Windows.Forms.Label()
        CategoryIDLabel = New System.Windows.Forms.Label()
        QuantityPerUnitLabel = New System.Windows.Forms.Label()
        UnitPriceLabel = New System.Windows.Forms.Label()
        UnitsInStockLabel = New System.Windows.Forms.Label()
        UnitsOnOrderLabel = New System.Windows.Forms.Label()
        DiscontinuedLabel = New System.Windows.Forms.Label()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NorthwindDataSet
        '
        Me.NorthwindDataSet.DataSetName = "NorthwindDataSet"
        Me.NorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CategoriesBindingSource
        '
        Me.CategoriesBindingSource.DataMember = "Categories"
        Me.CategoriesBindingSource.DataSource = Me.NorthwindDataSet
        '
        'CategoriesTableAdapter
        '
        Me.CategoriesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriesTableAdapter = Me.CategoriesTableAdapter
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.UpdateOrder = DataSetDragDrop.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "FK_Products_Categories"
        Me.ProductsBindingSource.DataSource = Me.CategoriesBindingSource
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CategoriesBindingSource
        Me.ComboBox1.DisplayMember = "CategoryName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(224, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.ProductsBindingSource
        Me.ListBox1.DisplayMember = "ProductName"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 65)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(224, 303)
        Me.ListBox1.TabIndex = 1
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Location = New System.Drawing.Point(269, 68)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(78, 13)
        ProductNameLabel.TabIndex = 2
        ProductNameLabel.Text = "Product Name:"
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(365, 65)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.ProductNameTextBox.TabIndex = 3
        '
        'CategoryIDLabel
        '
        CategoryIDLabel.AutoSize = True
        CategoryIDLabel.Location = New System.Drawing.Point(269, 88)
        CategoryIDLabel.Name = "CategoryIDLabel"
        CategoryIDLabel.Size = New System.Drawing.Size(66, 13)
        CategoryIDLabel.TabIndex = 4
        CategoryIDLabel.Text = "Category ID:"
        '
        'CategoryIDLabel1
        '
        Me.CategoryIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "CategoryID", True))
        Me.CategoryIDLabel1.Location = New System.Drawing.Point(365, 88)
        Me.CategoryIDLabel1.Name = "CategoryIDLabel1"
        Me.CategoryIDLabel1.Size = New System.Drawing.Size(104, 23)
        Me.CategoryIDLabel1.TabIndex = 5
        Me.CategoryIDLabel1.Text = "Label1"
        '
        'QuantityPerUnitLabel
        '
        QuantityPerUnitLabel.AutoSize = True
        QuantityPerUnitLabel.Location = New System.Drawing.Point(269, 117)
        QuantityPerUnitLabel.Name = "QuantityPerUnitLabel"
        QuantityPerUnitLabel.Size = New System.Drawing.Size(90, 13)
        QuantityPerUnitLabel.TabIndex = 6
        QuantityPerUnitLabel.Text = "Quantity Per Unit:"
        '
        'QuantityPerUnitTextBox
        '
        Me.QuantityPerUnitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "QuantityPerUnit", True))
        Me.QuantityPerUnitTextBox.Location = New System.Drawing.Point(365, 114)
        Me.QuantityPerUnitTextBox.Name = "QuantityPerUnitTextBox"
        Me.QuantityPerUnitTextBox.Size = New System.Drawing.Size(104, 20)
        Me.QuantityPerUnitTextBox.TabIndex = 7
        '
        'UnitPriceLabel
        '
        UnitPriceLabel.AutoSize = True
        UnitPriceLabel.Location = New System.Drawing.Point(269, 143)
        UnitPriceLabel.Name = "UnitPriceLabel"
        UnitPriceLabel.Size = New System.Drawing.Size(56, 13)
        UnitPriceLabel.TabIndex = 8
        UnitPriceLabel.Text = "Unit Price:"
        '
        'UnitPriceTextBox
        '
        Me.UnitPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "UnitPrice", True))
        Me.UnitPriceTextBox.Location = New System.Drawing.Point(365, 140)
        Me.UnitPriceTextBox.Name = "UnitPriceTextBox"
        Me.UnitPriceTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UnitPriceTextBox.TabIndex = 9
        '
        'UnitsInStockLabel
        '
        UnitsInStockLabel.AutoSize = True
        UnitsInStockLabel.Location = New System.Drawing.Point(269, 169)
        UnitsInStockLabel.Name = "UnitsInStockLabel"
        UnitsInStockLabel.Size = New System.Drawing.Size(77, 13)
        UnitsInStockLabel.TabIndex = 10
        UnitsInStockLabel.Text = "Units In Stock:"
        '
        'UnitsInStockTextBox
        '
        Me.UnitsInStockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "UnitsInStock", True))
        Me.UnitsInStockTextBox.Location = New System.Drawing.Point(365, 166)
        Me.UnitsInStockTextBox.Name = "UnitsInStockTextBox"
        Me.UnitsInStockTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UnitsInStockTextBox.TabIndex = 11
        '
        'UnitsOnOrderLabel
        '
        UnitsOnOrderLabel.AutoSize = True
        UnitsOnOrderLabel.Location = New System.Drawing.Point(269, 195)
        UnitsOnOrderLabel.Name = "UnitsOnOrderLabel"
        UnitsOnOrderLabel.Size = New System.Drawing.Size(80, 13)
        UnitsOnOrderLabel.TabIndex = 12
        UnitsOnOrderLabel.Text = "Units On Order:"
        '
        'UnitsOnOrderTextBox
        '
        Me.UnitsOnOrderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "UnitsOnOrder", True))
        Me.UnitsOnOrderTextBox.Location = New System.Drawing.Point(365, 192)
        Me.UnitsOnOrderTextBox.Name = "UnitsOnOrderTextBox"
        Me.UnitsOnOrderTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UnitsOnOrderTextBox.TabIndex = 13
        '
        'DiscontinuedLabel
        '
        DiscontinuedLabel.AutoSize = True
        DiscontinuedLabel.Location = New System.Drawing.Point(269, 223)
        DiscontinuedLabel.Name = "DiscontinuedLabel"
        DiscontinuedLabel.Size = New System.Drawing.Size(72, 13)
        DiscontinuedLabel.TabIndex = 14
        DiscontinuedLabel.Text = "Discontinued:"
        '
        'DiscontinuedCheckBox
        '
        Me.DiscontinuedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductsBindingSource, "Discontinued", True))
        Me.DiscontinuedCheckBox.Location = New System.Drawing.Point(365, 218)
        Me.DiscontinuedCheckBox.Name = "DiscontinuedCheckBox"
        Me.DiscontinuedCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.DiscontinuedCheckBox.TabIndex = 15
        Me.DiscontinuedCheckBox.Text = "CheckBox1"
        Me.DiscontinuedCheckBox.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 436)
        Me.Controls.Add(ProductNameLabel)
        Me.Controls.Add(Me.ProductNameTextBox)
        Me.Controls.Add(CategoryIDLabel)
        Me.Controls.Add(Me.CategoryIDLabel1)
        Me.Controls.Add(QuantityPerUnitLabel)
        Me.Controls.Add(Me.QuantityPerUnitTextBox)
        Me.Controls.Add(UnitPriceLabel)
        Me.Controls.Add(Me.UnitPriceTextBox)
        Me.Controls.Add(UnitsInStockLabel)
        Me.Controls.Add(Me.UnitsInStockTextBox)
        Me.Controls.Add(UnitsOnOrderLabel)
        Me.Controls.Add(Me.UnitsOnOrderTextBox)
        Me.Controls.Add(DiscontinuedLabel)
        Me.Controls.Add(Me.DiscontinuedCheckBox)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NorthwindDataSet As DataSetDragDrop.NorthwindDataSet
    Friend WithEvents CategoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriesTableAdapter As DataSetDragDrop.NorthwindDataSetTableAdapters.CategoriesTableAdapter
    Friend WithEvents TableAdapterManager As DataSetDragDrop.NorthwindDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductsTableAdapter As DataSetDragDrop.NorthwindDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ProductNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents QuantityPerUnitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitsInStockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitsOnOrderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscontinuedCheckBox As System.Windows.Forms.CheckBox
End Class
