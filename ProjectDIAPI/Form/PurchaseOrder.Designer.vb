<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseOrder
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxDocNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.ItemCode = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.DateTimePickerTaxDate = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerDocDueDate = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerDocDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxBPName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxBPCode = New System.Windows.Forms.TextBox()
        Me.btnChooseCustomer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxDocStatus = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ComboBoxCopyTo = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2288, 524)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 17)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "Total"
        '
        'TextBoxDocNumber
        '
        Me.TextBoxDocNumber.Enabled = False
        Me.TextBoxDocNumber.Location = New System.Drawing.Point(153, 137)
        Me.TextBoxDocNumber.Name = "TextBoxDocNumber"
        Me.TextBoxDocNumber.Size = New System.Drawing.Size(129, 22)
        Me.TextBoxDocNumber.TabIndex = 118
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Doc Number"
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCode, Me.ItemName, Me.Quantity, Me.UnitPrice})
        Me.DataGridView.Location = New System.Drawing.Point(20, 245)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.Size = New System.Drawing.Size(931, 253)
        Me.DataGridView.TabIndex = 116
        '
        'ItemCode
        '
        Me.ItemCode.HeaderText = "Item No"
        Me.ItemCode.Name = "ItemCode"
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Item Description"
        Me.ItemName.MinimumWidth = 200
        Me.ItemName.Name = "ItemName"
        Me.ItemName.Width = 200
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Quantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'UnitPrice
        '
        Me.UnitPrice.HeaderText = "Unit Price"
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UnitPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(919, 63)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(33, 25)
        Me.btnPrevious.TabIndex = 114
        Me.btnPrevious.Text = ">"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(879, 63)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(35, 25)
        Me.btnNext.TabIndex = 115
        Me.btnNext.Text = "<"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(52, 90)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 36)
        Me.btnFind.TabIndex = 111
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(212, 90)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 36)
        Me.btnUpdate.TabIndex = 113
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(132, 90)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 36)
        Me.btnAdd.TabIndex = 112
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(132, 579)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 32)
        Me.btnCancel.TabIndex = 110
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(20, 579)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(93, 32)
        Me.BtnOK.TabIndex = 109
        Me.BtnOK.Text = "Add"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'DateTimePickerTaxDate
        '
        Me.DateTimePickerTaxDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerTaxDate.Location = New System.Drawing.Point(688, 149)
        Me.DateTimePickerTaxDate.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerTaxDate.Name = "DateTimePickerTaxDate"
        Me.DateTimePickerTaxDate.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePickerTaxDate.TabIndex = 108
        Me.DateTimePickerTaxDate.Value = New Date(2019, 6, 22, 23, 37, 16, 0)
        '
        'DateTimePickerDocDueDate
        '
        Me.DateTimePickerDocDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerDocDueDate.Location = New System.Drawing.Point(688, 121)
        Me.DateTimePickerDocDueDate.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerDocDueDate.Name = "DateTimePickerDocDueDate"
        Me.DateTimePickerDocDueDate.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePickerDocDueDate.TabIndex = 107
        Me.DateTimePickerDocDueDate.Value = New Date(2019, 6, 22, 23, 36, 58, 0)
        '
        'DateTimePickerDocDate
        '
        Me.DateTimePickerDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerDocDate.Location = New System.Drawing.Point(688, 94)
        Me.DateTimePickerDocDate.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerDocDate.Name = "DateTimePickerDocDate"
        Me.DateTimePickerDocDate.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePickerDocDate.TabIndex = 106
        Me.DateTimePickerDocDate.Value = New Date(2019, 6, 22, 23, 37, 9, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(571, 124)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Delivery Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(571, 151)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Document Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(571, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Posting Date"
        '
        'TextBoxBPName
        '
        Me.TextBoxBPName.Location = New System.Drawing.Point(152, 199)
        Me.TextBoxBPName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxBPName.Name = "TextBoxBPName"
        Me.TextBoxBPName.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxBPName.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 201)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Name"
        '
        'TextBoxBPCode
        '
        Me.TextBoxBPCode.Location = New System.Drawing.Point(152, 167)
        Me.TextBoxBPCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxBPCode.Name = "TextBoxBPCode"
        Me.TextBoxBPCode.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxBPCode.TabIndex = 100
        '
        'btnChooseCustomer
        '
        Me.btnChooseCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseCustomer.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnChooseCustomer.Location = New System.Drawing.Point(292, 167)
        Me.btnChooseCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChooseCustomer.Name = "btnChooseCustomer"
        Me.btnChooseCustomer.Size = New System.Drawing.Size(21, 20)
        Me.btnChooseCustomer.TabIndex = 99
        Me.btnChooseCustomer.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 169)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Vendor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 29)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Purchase Order"
        '
        'TextBoxDocStatus
        '
        Me.TextBoxDocStatus.Enabled = False
        Me.TextBoxDocStatus.Location = New System.Drawing.Point(688, 175)
        Me.TextBoxDocStatus.Name = "TextBoxDocStatus"
        Me.TextBoxDocStatus.Size = New System.Drawing.Size(265, 22)
        Me.TextBoxDocStatus.TabIndex = 122
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(571, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 17)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Doc Status"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(684, 581)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 17)
        Me.Label11.TabIndex = 126
        Me.Label11.Text = "Copy To"
        '
        'ComboBoxCopyTo
        '
        Me.ComboBoxCopyTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCopyTo.Enabled = False
        Me.ComboBoxCopyTo.FormattingEnabled = True
        Me.ComboBoxCopyTo.Items.AddRange(New Object() {"A / P Invoice"})
        Me.ComboBoxCopyTo.Location = New System.Drawing.Point(763, 579)
        Me.ComboBoxCopyTo.Name = "ComboBoxCopyTo"
        Me.ComboBoxCopyTo.Size = New System.Drawing.Size(184, 24)
        Me.ComboBoxCopyTo.TabIndex = 125
        '
        'PurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 677)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBoxCopyTo)
        Me.Controls.Add(Me.TextBoxDocStatus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBoxDocNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.DateTimePickerTaxDate)
        Me.Controls.Add(Me.DateTimePickerDocDueDate)
        Me.Controls.Add(Me.DateTimePickerDocDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxBPName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxBPCode)
        Me.Controls.Add(Me.btnChooseCustomer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PurchaseOrder"
        Me.Text = "PurchaseOrder"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDocNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerTaxDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerDocDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerDocDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBPName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBPCode As System.Windows.Forms.TextBox
    Friend WithEvents btnChooseCustomer As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDocStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCopyTo As System.Windows.Forms.ComboBox
    Friend WithEvents ItemCode As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
