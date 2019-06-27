<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UDFData
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
        Me.ComboBoxTable = New System.Windows.Forms.ComboBox()
        Me.LabelTable = New System.Windows.Forms.Label()
        Me.TextBoxUDFName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxUDFDescription = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxTable
        '
        Me.ComboBoxTable.FormattingEnabled = True
        Me.ComboBoxTable.Items.AddRange(New Object() {"Sales Order", "Purchase Order"})
        Me.ComboBoxTable.Location = New System.Drawing.Point(189, 50)
        Me.ComboBoxTable.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ComboBoxTable.Name = "ComboBoxTable"
        Me.ComboBoxTable.Size = New System.Drawing.Size(219, 32)
        Me.ComboBoxTable.TabIndex = 0
        '
        'LabelTable
        '
        Me.LabelTable.AutoSize = True
        Me.LabelTable.Location = New System.Drawing.Point(46, 55)
        Me.LabelTable.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LabelTable.Name = "LabelTable"
        Me.LabelTable.Size = New System.Drawing.Size(62, 25)
        Me.LabelTable.TabIndex = 1
        Me.LabelTable.Text = "Table"
        '
        'TextBoxUDFName
        '
        Me.TextBoxUDFName.Location = New System.Drawing.Point(189, 118)
        Me.TextBoxUDFName.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBoxUDFName.Name = "TextBoxUDFName"
        Me.TextBoxUDFName.Size = New System.Drawing.Size(219, 29)
        Me.TextBoxUDFName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 124)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 190)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Description"
        '
        'TextBoxUDFDescription
        '
        Me.TextBoxUDFDescription.Location = New System.Drawing.Point(189, 185)
        Me.TextBoxUDFDescription.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.TextBoxUDFDescription.Name = "TextBoxUDFDescription"
        Me.TextBoxUDFDescription.Size = New System.Drawing.Size(219, 29)
        Me.TextBoxUDFDescription.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(189, 338)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 42)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UDFData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 482)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxUDFDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxUDFName)
        Me.Controls.Add(Me.LabelTable)
        Me.Controls.Add(Me.ComboBoxTable)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "UDFData"
        Me.Text = "UDFData"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxTable As System.Windows.Forms.ComboBox
    Friend WithEvents LabelTable As System.Windows.Forms.Label
    Friend WithEvents TextBoxUDFName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUDFDescription As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
