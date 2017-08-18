<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProductForm
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
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrderTextBox = New System.Windows.Forms.TextBox()
        Me.DiscontinuedCheckBox = New System.Windows.Forms.CheckBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.Location = New System.Drawing.Point(120, 38)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.ReadOnly = True
        Me.CategoryTextBox.Size = New System.Drawing.Size(209, 20)
        Me.CategoryTextBox.TabIndex = 3
        Me.CategoryTextBox.TabStop = False
        '
        'CancelButton
        '
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(254, 191)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 15
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OKButton.Location = New System.Drawing.Point(173, 191)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 14
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Category"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 173)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Discontinued"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Units on Order"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Units in Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Unit Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Quantity Per Unit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'OrderTextBox
        '
        Me.OrderTextBox.Location = New System.Drawing.Point(120, 143)
        Me.OrderTextBox.Name = "OrderTextBox"
        Me.OrderTextBox.Size = New System.Drawing.Size(209, 20)
        Me.OrderTextBox.TabIndex = 11
        '
        'DiscontinuedCheckBox
        '
        Me.DiscontinuedCheckBox.AutoSize = True
        Me.DiscontinuedCheckBox.Location = New System.Drawing.Point(120, 173)
        Me.DiscontinuedCheckBox.Name = "DiscontinuedCheckBox"
        Me.DiscontinuedCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.DiscontinuedCheckBox.TabIndex = 13
        Me.DiscontinuedCheckBox.UseVisualStyleBackColor = True
        '
        'StockTextBox
        '
        Me.StockTextBox.Location = New System.Drawing.Point(120, 117)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(209, 20)
        Me.StockTextBox.TabIndex = 9
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(120, 91)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(209, 20)
        Me.PriceTextBox.TabIndex = 7
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(120, 65)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(209, 20)
        Me.QuantityTextBox.TabIndex = 5
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(120, 12)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(209, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'AddProductForm
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 226)
        Me.ControlBox = False
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OrderTextBox)
        Me.Controls.Add(Me.DiscontinuedCheckBox)
        Me.Controls.Add(Me.StockTextBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddProductForm"
        Me.Text = "Add Product"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OrderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscontinuedCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents StockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
End Class
