﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TextBoxDocTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxDocNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.ItemCode = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxDocTotal
        '
        Me.TextBoxDocTotal.Location = New System.Drawing.Point(519, 418)
        Me.TextBoxDocTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxDocTotal.Name = "TextBoxDocTotal"
        Me.TextBoxDocTotal.Size = New System.Drawing.Size(138, 20)
        Me.TextBoxDocTotal.TabIndex = 120
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1716, 426)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "Total"
        '
        'TextBoxDocNumber
        '
        Me.TextBoxDocNumber.Enabled = False
        Me.TextBoxDocNumber.Location = New System.Drawing.Point(115, 117)
        Me.TextBoxDocNumber.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxDocNumber.Name = "TextBoxDocNumber"
        Me.TextBoxDocNumber.Size = New System.Drawing.Size(98, 20)
        Me.TextBoxDocNumber.TabIndex = 118
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 118)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Doc Number"
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCode, Me.ItemName, Me.Quantity, Me.UnitPrice, Me.Total})
        Me.DataGridView.Location = New System.Drawing.Point(15, 205)
        Me.DataGridView.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.Size = New System.Drawing.Size(643, 200)
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
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Total.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(635, 93)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(25, 20)
        Me.btnPrevious.TabIndex = 114
        Me.btnPrevious.Text = ">"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(605, 93)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(26, 20)
        Me.btnNext.TabIndex = 115
        Me.btnNext.Text = "<"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(2, 2)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(2)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(56, 29)
        Me.btnFind.TabIndex = 111
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(122, 2)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(56, 29)
        Me.btnUpdate.TabIndex = 113
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(62, 2)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(56, 29)
        Me.btnAdd.TabIndex = 112
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(99, 445)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(70, 26)
        Me.btnCancel.TabIndex = 110
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(25, 445)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(70, 26)
        Me.BtnOK.TabIndex = 109
        Me.BtnOK.Text = "Add"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'DateTimePickerTaxDate
        '
        Me.DateTimePickerTaxDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerTaxDate.Location = New System.Drawing.Point(459, 169)
        Me.DateTimePickerTaxDate.Name = "DateTimePickerTaxDate"
        Me.DateTimePickerTaxDate.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerTaxDate.TabIndex = 108
        Me.DateTimePickerTaxDate.Value = New Date(2019, 6, 22, 23, 37, 16, 0)
        '
        'DateTimePickerDocDueDate
        '
        Me.DateTimePickerDocDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerDocDueDate.Location = New System.Drawing.Point(459, 143)
        Me.DateTimePickerDocDueDate.Name = "DateTimePickerDocDueDate"
        Me.DateTimePickerDocDueDate.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerDocDueDate.TabIndex = 107
        Me.DateTimePickerDocDueDate.Value = New Date(2019, 6, 22, 23, 36, 58, 0)
        '
        'DateTimePickerDocDate
        '
        Me.DateTimePickerDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerDocDate.Location = New System.Drawing.Point(459, 118)
        Me.DateTimePickerDocDate.Name = "DateTimePickerDocDate"
        Me.DateTimePickerDocDate.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerDocDate.TabIndex = 106
        Me.DateTimePickerDocDate.Value = New Date(2019, 6, 22, 23, 37, 9, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(371, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "Delivery Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(370, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Document Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(371, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Posting Date"
        '
        'TextBoxBPName
        '
        Me.TextBoxBPName.Location = New System.Drawing.Point(114, 167)
        Me.TextBoxBPName.Name = "TextBoxBPName"
        Me.TextBoxBPName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBPName.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Name"
        '
        'TextBoxBPCode
        '
        Me.TextBoxBPCode.Location = New System.Drawing.Point(114, 142)
        Me.TextBoxBPCode.Name = "TextBoxBPCode"
        Me.TextBoxBPCode.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxBPCode.TabIndex = 100
        '
        'btnChooseCustomer
        '
        Me.btnChooseCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseCustomer.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnChooseCustomer.Location = New System.Drawing.Point(220, 144)
        Me.btnChooseCustomer.Name = "btnChooseCustomer"
        Me.btnChooseCustomer.Size = New System.Drawing.Size(16, 16)
        Me.btnChooseCustomer.TabIndex = 99
        Me.btnChooseCustomer.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Customer"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(259, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 24)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Purchase Order"
        '
        'PurchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 507)
        Me.Controls.Add(Me.TextBoxDocTotal)
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
        Me.Name = "PurchaseOrder"
        Me.Text = "PurchaseOrder"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxDocTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDocNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ItemCode As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
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
End Class
