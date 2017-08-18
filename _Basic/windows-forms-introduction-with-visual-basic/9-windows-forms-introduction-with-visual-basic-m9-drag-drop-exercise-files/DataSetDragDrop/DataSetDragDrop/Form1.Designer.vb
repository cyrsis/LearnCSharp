<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim CategoryIDLabel As System.Windows.Forms.Label
        Dim QuantityPerUnitLabel As System.Windows.Forms.Label
        Dim UnitPriceLabel As System.Windows.Forms.Label
        Dim UnitsInStockLabel As System.Windows.Forms.Label
        Dim UnitsOnOrderLabel As System.Windows.Forms.Label
        Dim DiscontinuedLabel As System.Windows.Forms.Label
        Me.NorthwindDataSet = New DataSetDragDrop.NorthwindDataSet()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New DataSetDragDrop.NorthwindDataSetTableAdapters.ProductsTableAdapter()
        Me.TableAdapterManager = New DataSetDragDrop.NorthwindDataSetTableAdapters.TableAdapterManager()
        Me.ProductsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ProductsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
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
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NorthwindDataSet
        '
        Me.NorthwindDataSet.DataSetName = "NorthwindDataSet"
        Me.NorthwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.NorthwindDataSet
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriesTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.UpdateOrder = DataSetDragDrop.NorthwindDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductsBindingNavigator
        '
        Me.ProductsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ProductsBindingNavigator.BindingSource = Me.ProductsBindingSource
        Me.ProductsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ProductsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ProductsBindingNavigatorSaveItem})
        Me.ProductsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ProductsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductsBindingNavigator.Name = "ProductsBindingNavigator"
        Me.ProductsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductsBindingNavigator.Size = New System.Drawing.Size(380, 25)
        Me.ProductsBindingNavigator.TabIndex = 0
        Me.ProductsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 13)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ProductsBindingNavigatorSaveItem
        '
        Me.ProductsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ProductsBindingNavigatorSaveItem.Image = CType(resources.GetObject("ProductsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ProductsBindingNavigatorSaveItem.Name = "ProductsBindingNavigatorSaveItem"
        Me.ProductsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ProductsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Location = New System.Drawing.Point(12, 46)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(78, 13)
        ProductNameLabel.TabIndex = 1
        ProductNameLabel.Text = "Product Name:"
        '
        'ProductNameTextBox
        '
        Me.ProductNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "ProductName", True))
        Me.ProductNameTextBox.Location = New System.Drawing.Point(108, 43)
        Me.ProductNameTextBox.Name = "ProductNameTextBox"
        Me.ProductNameTextBox.ReadOnly = True
        Me.ProductNameTextBox.Size = New System.Drawing.Size(211, 20)
        Me.ProductNameTextBox.TabIndex = 2
        '
        'CategoryIDLabel
        '
        CategoryIDLabel.AutoSize = True
        CategoryIDLabel.Location = New System.Drawing.Point(12, 73)
        CategoryIDLabel.Name = "CategoryIDLabel"
        CategoryIDLabel.Size = New System.Drawing.Size(66, 13)
        CategoryIDLabel.TabIndex = 3
        CategoryIDLabel.Text = "Category ID:"
        '
        'CategoryIDLabel1
        '
        Me.CategoryIDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "CategoryID", True))
        Me.CategoryIDLabel1.Location = New System.Drawing.Point(108, 73)
        Me.CategoryIDLabel1.Name = "CategoryIDLabel1"
        Me.CategoryIDLabel1.Size = New System.Drawing.Size(104, 23)
        Me.CategoryIDLabel1.TabIndex = 4
        Me.CategoryIDLabel1.Text = "Label1"
        '
        'QuantityPerUnitLabel
        '
        QuantityPerUnitLabel.AutoSize = True
        QuantityPerUnitLabel.Location = New System.Drawing.Point(12, 102)
        QuantityPerUnitLabel.Name = "QuantityPerUnitLabel"
        QuantityPerUnitLabel.Size = New System.Drawing.Size(90, 13)
        QuantityPerUnitLabel.TabIndex = 5
        QuantityPerUnitLabel.Text = "Quantity Per Unit:"
        '
        'QuantityPerUnitTextBox
        '
        Me.QuantityPerUnitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "QuantityPerUnit", True))
        Me.QuantityPerUnitTextBox.Location = New System.Drawing.Point(108, 99)
        Me.QuantityPerUnitTextBox.Name = "QuantityPerUnitTextBox"
        Me.QuantityPerUnitTextBox.Size = New System.Drawing.Size(104, 20)
        Me.QuantityPerUnitTextBox.TabIndex = 6
        '
        'UnitPriceLabel
        '
        UnitPriceLabel.AutoSize = True
        UnitPriceLabel.Location = New System.Drawing.Point(12, 128)
        UnitPriceLabel.Name = "UnitPriceLabel"
        UnitPriceLabel.Size = New System.Drawing.Size(56, 13)
        UnitPriceLabel.TabIndex = 7
        UnitPriceLabel.Text = "Unit Price:"
        '
        'UnitPriceTextBox
        '
        Me.UnitPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "UnitPrice", True))
        Me.UnitPriceTextBox.Location = New System.Drawing.Point(108, 125)
        Me.UnitPriceTextBox.Name = "UnitPriceTextBox"
        Me.UnitPriceTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UnitPriceTextBox.TabIndex = 8
        '
        'UnitsInStockLabel
        '
        UnitsInStockLabel.AutoSize = True
        UnitsInStockLabel.Location = New System.Drawing.Point(12, 154)
        UnitsInStockLabel.Name = "UnitsInStockLabel"
        UnitsInStockLabel.Size = New System.Drawing.Size(77, 13)
        UnitsInStockLabel.TabIndex = 9
        UnitsInStockLabel.Text = "Units In Stock:"
        '
        'UnitsInStockTextBox
        '
        Me.UnitsInStockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "UnitsInStock", True))
        Me.UnitsInStockTextBox.Location = New System.Drawing.Point(108, 151)
        Me.UnitsInStockTextBox.Name = "UnitsInStockTextBox"
        Me.UnitsInStockTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UnitsInStockTextBox.TabIndex = 10
        '
        'UnitsOnOrderLabel
        '
        UnitsOnOrderLabel.AutoSize = True
        UnitsOnOrderLabel.Location = New System.Drawing.Point(12, 180)
        UnitsOnOrderLabel.Name = "UnitsOnOrderLabel"
        UnitsOnOrderLabel.Size = New System.Drawing.Size(80, 13)
        UnitsOnOrderLabel.TabIndex = 11
        UnitsOnOrderLabel.Text = "Units On Order:"
        '
        'UnitsOnOrderTextBox
        '
        Me.UnitsOnOrderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "UnitsOnOrder", True))
        Me.UnitsOnOrderTextBox.Location = New System.Drawing.Point(108, 177)
        Me.UnitsOnOrderTextBox.Name = "UnitsOnOrderTextBox"
        Me.UnitsOnOrderTextBox.Size = New System.Drawing.Size(104, 20)
        Me.UnitsOnOrderTextBox.TabIndex = 12
        '
        'DiscontinuedLabel
        '
        DiscontinuedLabel.AutoSize = True
        DiscontinuedLabel.Location = New System.Drawing.Point(12, 208)
        DiscontinuedLabel.Name = "DiscontinuedLabel"
        DiscontinuedLabel.Size = New System.Drawing.Size(72, 13)
        DiscontinuedLabel.TabIndex = 13
        DiscontinuedLabel.Text = "Discontinued:"
        '
        'DiscontinuedCheckBox
        '
        Me.DiscontinuedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ProductsBindingSource, "Discontinued", True))
        Me.DiscontinuedCheckBox.Location = New System.Drawing.Point(108, 203)
        Me.DiscontinuedCheckBox.Name = "DiscontinuedCheckBox"
        Me.DiscontinuedCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.DiscontinuedCheckBox.TabIndex = 14
        Me.DiscontinuedCheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 318)
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
        Me.Controls.Add(Me.ProductsBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductsBindingNavigator.ResumeLayout(False)
        Me.ProductsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NorthwindDataSet As DataSetDragDrop.NorthwindDataSet
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsTableAdapter As DataSetDragDrop.NorthwindDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents TableAdapterManager As DataSetDragDrop.NorthwindDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProductsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryIDLabel1 As System.Windows.Forms.Label
    Friend WithEvents QuantityPerUnitTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitsInStockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UnitsOnOrderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscontinuedCheckBox As System.Windows.Forms.CheckBox

End Class
