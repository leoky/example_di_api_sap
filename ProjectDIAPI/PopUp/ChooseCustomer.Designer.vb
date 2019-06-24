<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseCustomer
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
        Me.DataGridViewListCustomer = New System.Windows.Forms.DataGridView()
        Me.CodeNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnChoose = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        CType(Me.DataGridViewListCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewListCustomer
        '
        Me.DataGridViewListCustomer.AllowUserToAddRows = False
        Me.DataGridViewListCustomer.AllowUserToDeleteRows = False
        Me.DataGridViewListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewListCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeNum, Me.Description})
        Me.DataGridViewListCustomer.Location = New System.Drawing.Point(12, 26)
        Me.DataGridViewListCustomer.Name = "DataGridViewListCustomer"
        Me.DataGridViewListCustomer.ReadOnly = True
        Me.DataGridViewListCustomer.RowTemplate.Height = 24
        Me.DataGridViewListCustomer.Size = New System.Drawing.Size(650, 198)
        Me.DataGridViewListCustomer.TabIndex = 0
        '
        'CodeNum
        '
        Me.CodeNum.Frozen = True
        Me.CodeNum.HeaderText = "Code Num"
        Me.CodeNum.Name = "CodeNum"
        Me.CodeNum.ReadOnly = True
        '
        'Description
        '
        Me.Description.Frozen = True
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'btnChoose
        '
        Me.btnChoose.Location = New System.Drawing.Point(12, 278)
        Me.btnChoose.Name = "btnChoose"
        Me.btnChoose.Size = New System.Drawing.Size(75, 23)
        Me.btnChoose.TabIndex = 1
        Me.btnChoose.Text = "Choose"
        Me.btnChoose.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(107, 278)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(202, 278)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'ChooseCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 312)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnChoose)
        Me.Controls.Add(Me.DataGridViewListCustomer)
        Me.Name = "ChooseCustomer"
        Me.Text = "Choose Customer"
        CType(Me.DataGridViewListCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewListCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents CodeNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnChoose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
End Class
