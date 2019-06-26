<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseVendor
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
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnChoose = New System.Windows.Forms.Button()
        Me.DataGridViewListCustomer = New System.Windows.Forms.DataGridView()
        Me.CodeNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewListCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(164, 225)
        Me.btnNew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(56, 19)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(92, 225)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(56, 19)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnChoose
        '
        Me.btnChoose.Location = New System.Drawing.Point(21, 225)
        Me.btnChoose.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChoose.Name = "btnChoose"
        Me.btnChoose.Size = New System.Drawing.Size(56, 19)
        Me.btnChoose.TabIndex = 5
        Me.btnChoose.Text = "Choose"
        Me.btnChoose.UseVisualStyleBackColor = True
        '
        'DataGridViewListCustomer
        '
        Me.DataGridViewListCustomer.AllowUserToAddRows = False
        Me.DataGridViewListCustomer.AllowUserToDeleteRows = False
        Me.DataGridViewListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewListCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodeNum, Me.Description})
        Me.DataGridViewListCustomer.Location = New System.Drawing.Point(21, 20)
        Me.DataGridViewListCustomer.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewListCustomer.Name = "DataGridViewListCustomer"
        Me.DataGridViewListCustomer.ReadOnly = True
        Me.DataGridViewListCustomer.RowTemplate.Height = 24
        Me.DataGridViewListCustomer.Size = New System.Drawing.Size(488, 161)
        Me.DataGridViewListCustomer.TabIndex = 4
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
        'ChooseVendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 259)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnChoose)
        Me.Controls.Add(Me.DataGridViewListCustomer)
        Me.Name = "ChooseVendor"
        Me.Text = "ChooseVendor"
        CType(Me.DataGridViewListCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnChoose As System.Windows.Forms.Button
    Friend WithEvents DataGridViewListCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents CodeNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
