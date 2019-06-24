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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxUDFEditSize = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxTable
        '
        Me.ComboBoxTable.FormattingEnabled = True
        Me.ComboBoxTable.Items.AddRange(New Object() {"Sales Order"})
        Me.ComboBoxTable.Location = New System.Drawing.Point(103, 27)
        Me.ComboBoxTable.Name = "ComboBoxTable"
        Me.ComboBoxTable.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTable.TabIndex = 0
        '
        'LabelTable
        '
        Me.LabelTable.AutoSize = True
        Me.LabelTable.Location = New System.Drawing.Point(25, 30)
        Me.LabelTable.Name = "LabelTable"
        Me.LabelTable.Size = New System.Drawing.Size(34, 13)
        Me.LabelTable.TabIndex = 1
        Me.LabelTable.Text = "Table"
        '
        'TextBoxUDFName
        '
        Me.TextBoxUDFName.Location = New System.Drawing.Point(103, 64)
        Me.TextBoxUDFName.Name = "TextBoxUDFName"
        Me.TextBoxUDFName.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxUDFName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Description"
        '
        'TextBoxUDFDescription
        '
        Me.TextBoxUDFDescription.Location = New System.Drawing.Point(103, 100)
        Me.TextBoxUDFDescription.Name = "TextBoxUDFDescription"
        Me.TextBoxUDFDescription.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxUDFDescription.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Edit Size"
        '
        'TextBoxUDFEditSize
        '
        Me.TextBoxUDFEditSize.Location = New System.Drawing.Point(103, 139)
        Me.TextBoxUDFEditSize.Name = "TextBoxUDFEditSize"
        Me.TextBoxUDFEditSize.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxUDFEditSize.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(103, 183)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UDFData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxUDFEditSize)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxUDFDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxUDFName)
        Me.Controls.Add(Me.LabelTable)
        Me.Controls.Add(Me.ComboBoxTable)
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxUDFEditSize As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
