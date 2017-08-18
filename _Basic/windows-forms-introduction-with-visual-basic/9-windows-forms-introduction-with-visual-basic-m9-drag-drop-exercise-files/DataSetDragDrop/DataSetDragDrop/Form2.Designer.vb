<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim CategoryIDLabel As System.Windows.Forms.Label
        Dim CategoryNameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Me.NorthwindDataSet = New DataSetDragDrop.NorthwindDataSet()
        Me.CategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriesTableAdapter = New DataSetDragDrop.NorthwindDataSetTableAdapters.CategoriesTableAdapter()
        Me.TableAdapterManager = New DataSetDragDrop.NorthwindDataSetTableAdapters.TableAdapterManager()
        Me.CategoriesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CategoriesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CategoryIDTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryNameTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsTableAdapter = New DataSetDragDrop.NorthwindDataSetTableAdapters.ProductsTableAdapter()
        Me.ProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CategoryIDLabel = New System.Windows.Forms.Label()
        CategoryNameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CategoriesBindingNavigator.SuspendLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'CategoriesBindingNavigator
        '
        Me.CategoriesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CategoriesBindingNavigator.BindingSource = Me.CategoriesBindingSource
        Me.CategoriesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CategoriesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CategoriesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CategoriesBindingNavigatorSaveItem})
        Me.CategoriesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CategoriesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CategoriesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CategoriesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CategoriesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CategoriesBindingNavigator.Name = "CategoriesBindingNavigator"
        Me.CategoriesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CategoriesBindingNavigator.Size = New System.Drawing.Size(473, 25)
        Me.CategoriesBindingNavigator.TabIndex = 0
        Me.CategoriesBindingNavigator.Text = "BindingNavigator1"
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
        'CategoriesBindingNavigatorSaveItem
        '
        Me.CategoriesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CategoriesBindingNavigatorSaveItem.Image = CType(resources.GetObject("CategoriesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CategoriesBindingNavigatorSaveItem.Name = "CategoriesBindingNavigatorSaveItem"
        Me.CategoriesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CategoriesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CategoryIDLabel
        '
        CategoryIDLabel.AutoSize = True
        CategoryIDLabel.Location = New System.Drawing.Point(13, 47)
        CategoryIDLabel.Name = "CategoryIDLabel"
        CategoryIDLabel.Size = New System.Drawing.Size(66, 13)
        CategoryIDLabel.TabIndex = 1
        CategoryIDLabel.Text = "Category ID:"
        '
        'CategoryIDTextBox
        '
        Me.CategoryIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriesBindingSource, "CategoryID", True))
        Me.CategoryIDTextBox.Location = New System.Drawing.Point(102, 44)
        Me.CategoryIDTextBox.Name = "CategoryIDTextBox"
        Me.CategoryIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CategoryIDTextBox.TabIndex = 2
        '
        'CategoryNameLabel
        '
        CategoryNameLabel.AutoSize = True
        CategoryNameLabel.Location = New System.Drawing.Point(13, 73)
        CategoryNameLabel.Name = "CategoryNameLabel"
        CategoryNameLabel.Size = New System.Drawing.Size(83, 13)
        CategoryNameLabel.TabIndex = 3
        CategoryNameLabel.Text = "Category Name:"
        '
        'CategoryNameTextBox
        '
        Me.CategoryNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriesBindingSource, "CategoryName", True))
        Me.CategoryNameTextBox.Location = New System.Drawing.Point(102, 70)
        Me.CategoryNameTextBox.Name = "CategoryNameTextBox"
        Me.CategoryNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CategoryNameTextBox.TabIndex = 4
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(13, 99)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 5
        DescriptionLabel.Text = "Description:"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CategoriesBindingSource, "Description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(102, 96)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DescriptionTextBox.TabIndex = 6
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
        'ProductsDataGridView
        '
        Me.ProductsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductsDataGridView.AutoGenerateColumns = False
        Me.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewCheckBoxColumn1})
        Me.ProductsDataGridView.DataSource = Me.ProductsBindingSource
        Me.ProductsDataGridView.Location = New System.Drawing.Point(16, 138)
        Me.ProductsDataGridView.Name = "ProductsDataGridView"
        Me.ProductsDataGridView.Size = New System.Drawing.Size(445, 299)
        Me.ProductsDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProductName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SupplierID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SupplierID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CategoryID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CategoryID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "QuantityPerUnit"
        Me.DataGridViewTextBoxColumn5.HeaderText = "QuantityPerUnit"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn6.HeaderText = "UnitPrice"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UnitsInStock"
        Me.DataGridViewTextBoxColumn7.HeaderText = "UnitsInStock"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UnitsOnOrder"
        Me.DataGridViewTextBoxColumn8.HeaderText = "UnitsOnOrder"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ReorderLevel"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ReorderLevel"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Discontinued"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Discontinued"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 449)
        Me.Controls.Add(Me.ProductsDataGridView)
        Me.Controls.Add(CategoryIDLabel)
        Me.Controls.Add(Me.CategoryIDTextBox)
        Me.Controls.Add(CategoryNameLabel)
        Me.Controls.Add(Me.CategoryNameTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(Me.CategoriesBindingNavigator)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.NorthwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CategoriesBindingNavigator.ResumeLayout(False)
        Me.CategoriesBindingNavigator.PerformLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NorthwindDataSet As DataSetDragDrop.NorthwindDataSet
    Friend WithEvents CategoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriesTableAdapter As DataSetDragDrop.NorthwindDataSetTableAdapters.CategoriesTableAdapter
    Friend WithEvents TableAdapterManager As DataSetDragDrop.NorthwindDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoriesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CategoriesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents CategoryIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductsTableAdapter As DataSetDragDrop.NorthwindDataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ProductsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
