<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmDialog
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.YesButton = New System.Windows.Forms.Button()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 71)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Are you sure you want to close?"
        '
        'YesButton
        '
        Me.YesButton.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.YesButton.Location = New System.Drawing.Point(124, 77)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(75, 23)
        Me.YesButton.TabIndex = 1
        Me.YesButton.Text = "Yes"
        Me.YesButton.UseVisualStyleBackColor = True
        '
        'NoButton
        '
        Me.NoButton.DialogResult = System.Windows.Forms.DialogResult.No
        Me.NoButton.Location = New System.Drawing.Point(205, 77)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(75, 23)
        Me.NoButton.TabIndex = 2
        Me.NoButton.Text = "No"
        Me.NoButton.UseVisualStyleBackColor = True
        '
        'ConfirmDialog
        '
        Me.AcceptButton = Me.YesButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.NoButton
        Me.ClientSize = New System.Drawing.Size(292, 109)
        Me.ControlBox = False
        Me.Controls.Add(Me.NoButton)
        Me.Controls.Add(Me.YesButton)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ConfirmDialog"
        Me.Text = "Confirm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents YesButton As System.Windows.Forms.Button
    Friend WithEvents NoButton As System.Windows.Forms.Button
End Class
