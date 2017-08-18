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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.LargeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SmallImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ViewToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(729, 428)
        Me.SplitContainer1.SplitterDistance = 242
        Me.SplitContainer1.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.AliceBlue
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(242, 428)
        Me.TreeView1.TabIndex = 0
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.AliceBlue
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.LargeImageList = Me.LargeImageList
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(483, 428)
        Me.ListView1.SmallImageList = Me.SmallImageList
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'LargeImageList
        '
        Me.LargeImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.LargeImageList.ImageSize = New System.Drawing.Size(32, 32)
        Me.LargeImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'SmallImageList
        '
        Me.SmallImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.SmallImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.SmallImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ViewToolStripComboBox})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(729, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(33, 22)
        Me.ToolStripLabel1.Text = "View:"
        '
        'ViewToolStripComboBox
        '
        Me.ViewToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ViewToolStripComboBox.Items.AddRange(New Object() {"Large Icons", "Small Icons", "Details"})
        Me.ViewToolStripComboBox.Name = "ViewToolStripComboBox"
        Me.ViewToolStripComboBox.Size = New System.Drawing.Size(121, 25)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 453)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Form1"
        Me.Text = "Explorer-Style Application"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents LargeImageList As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents SmallImageList As System.Windows.Forms.ImageList
    Friend WithEvents ViewToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel

End Class
