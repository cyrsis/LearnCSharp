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
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
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
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataSource = GetType(LinqDragDrop.Category)
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.CategoryBindingSource
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.ProductsBindingSource
        Me.ListBox1.DisplayMember = "ProductName"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 73)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(224, 303)
        Me.ListBox1.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CategoryBindingSource
        Me.ComboBox1.DisplayMember = "CategoryName"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(224, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Location = New System.Drawing.Point(270, 76)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(78, 13)
        ProductNameLabel.TabIndex = 3
        ProductNameLabel.Text = "Product Name:"
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(366, 73)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.ProductNameTextBox.TabIndex = 4
        '
        'CategoryIDLabel
        '
        CategoryIDLabel.AutoSize = True
        CategoryIDLabel.Location = New System.Drawing.Point(270, 96)
        CategoryIDLabel.Name = "CategoryIDLabel"
        CategoryIDLabel.Size = New System.Drawing.Size(66, 13)
        CategoryIDLabel.TabIndex = 5
        CategoryIDLabel.Text = "Category ID:"
        '
        'CategoryIDLabel1
        '
        Me.CategoryIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "CategoryID", True))
        Me.CategoryIDLabel1.Location = New System.Drawing.Point(366, 96)
        Me.CategoryIDLabel1.Name = "CategoryIDLabel1"
        Me.CategoryIDLabel1.Size = New System.Drawing.Size(104, 23)
        Me.CategoryIDLabel1.TabIndex = 6
        Me.CategoryIDLabel1.Text = "Label1"
        '
        'QuantityPerUnitLabel
        '
        QuantityPerUnitLabel.AutoSize = True
        QuantityPerUnitLabel.Location = New System.Drawing.Point(270, 125)
        QuantityPerUnitLabel.Name = "QuantityPerUnitLabel"
        QuantityPerUnitLabel.Size = New System.Drawing.Size(90, 13)
        QuantityPerUnitLabel.TabIndex = 7
        QuantityPerUnitLabel.Text = "Quantity Per Unit:"
        '
        'QuantityPerUnitTextBox
        '
        Me.QuantityPerUnitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "QuantityPerUnit", True))
        Me.QuantityPerUnitTextBox.Location = New System.Drawing.Point(366, 122)
        Me.QuantityPerUnitTextBox.Name = "QuantityPerUnitTextBox"
        Me.QuantityPerUnitTextBox.Size = New System.Drawing.Size(104, 20)
        Me.QuantityPerUnitTextBox.TabIndex = 8
        '
        'UnitPriceLabel
        '
        UnitPriceLabel.AutoSize = True
        UnitPriceLabel.Location = New System.Drawing.Point(270, 151)
        UnitPriceLabel.Name = "UnitPriceLabel"
        UnitPriceLabel.Size = New System.Drawing.Size(56, 13)
        UnitPriceLabel.TabIndex = 9
        UnitPriceLabel.Text = "Unit Price:"
        '
        'UnitPriceTextBox
        '
        Me.UnitPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "UnitPrice", True))
        Me.UnitPriceTextBox.Location = New System.Drawing.Point(366, 148)
        Me.UnitPriceTextBox.Name = "UnitPriceTextBox"
        Me.UnitPriceTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UnitPriceTextBox.TabIndex = 10
        '
        'UnitsInStockLabel
        '
        UnitsInStockLabel.AutoSize = True
        UnitsInStockLabel.Location = New System.Drawing.Point(270, 177)
        UnitsInStockLabel.Name = "UnitsInStockLabel"
        UnitsInStockLabel.Size = New System.Drawing.Size(77, 13)
        UnitsInStockLabel.TabIndex = 11
        UnitsInStockLabel.Text = "Units In Stock:"
        '
        'UnitsInStockTextBox
        '
        Me.UnitsInStockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "UnitsInStock", True))
        Me.UnitsInStockTextBox.Location = New System.Drawing.Point(366, 174)
        Me.UnitsInStockTextBox.Name = "UnitsInStockTextBox"
        Me.UnitsInStockTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UnitsInStockTextBox.TabIndex = 12
        '
        'UnitsOnOrderLabel
        '
        UnitsOnOrderLabel.AutoSize = True
        UnitsOnOrderLabel.Location = New System.Drawing.Point(270, 203)
        UnitsOnOrderLabel.Name = "UnitsOnOrderLabel"
        UnitsOnOrderLabel.Size = New System.Drawing.Size(80, 13)
        UnitsOnOrderLabel.TabIndex = 13
        UnitsOnOrderLabel.Text = "Units On Order:"
        '
        'UnitsOnOrderTextBox
        '
        Me.UnitsOnOrderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "UnitsOnOrder", True))
        Me.UnitsOnOrderTextBox.Location = New System.Drawing.Point(366, 200)
        Me.UnitsOnOrderTextBox.Name = "UnitsOnOrderTextBox"
        Me.UnitsOnOrderTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UnitsOnOrderTextBox.TabIndex = 14
        '
        'DiscontinuedLabel
        '
        DiscontinuedLabel.AutoSize = True
        DiscontinuedLabel.Location = New System.Drawing.Point(270, 231)
        DiscontinuedLabel.Name = "DiscontinuedLabel"
        DiscontinuedLabel.Size = New System.Drawing.Size(72, 13)
        DiscontinuedLabel.TabIndex = 15
        DiscontinuedLabel.Text = "Discontinued:"
        '
        'DiscontinuedCheckBox
        '
        Me.DiscontinuedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductsBindingSource, "Discontinued", True))
        Me.DiscontinuedCheckBox.Location = New System.Drawing.Point(366, 226)
        Me.DiscontinuedCheckBox.Name = "DiscontinuedCheckBox"
        Me.DiscontinuedCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.DiscontinuedCheckBox.TabIndex = 16
        Me.DiscontinuedCheckBox.Text = "CheckBox1"
        Me.DiscontinuedCheckBox.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 497)
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
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CategoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ProductNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents QuantityPerUnitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitsInStockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitsOnOrderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscontinuedCheckBox As System.Windows.Forms.CheckBox
End Class
