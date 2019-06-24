<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesOrder
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnChooseCustomer = New System.Windows.Forms.Button()
        Me.TextBoxBPCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxBPName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePickerDocDate = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerDocDueDate = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerTaxDate = New System.Windows.Forms.DateTimePicker()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.ItemCode = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxDocNumber = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sales Order"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 177)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Customer"
        '
        'btnChooseCustomer
        '
        Me.btnChooseCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseCustomer.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnChooseCustomer.Location = New System.Drawing.Point(268, 177)
        Me.btnChooseCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnChooseCustomer.Name = "btnChooseCustomer"
        Me.btnChooseCustomer.Size = New System.Drawing.Size(21, 20)
        Me.btnChooseCustomer.TabIndex = 68
        Me.btnChooseCustomer.TabStop = False
        '
        'TextBoxBPCode
        '
        Me.TextBoxBPCode.Location = New System.Drawing.Point(131, 175)
        Me.TextBoxBPCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxBPCode.Name = "TextBoxBPCode"
        Me.TextBoxBPCode.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxBPCode.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 209)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 17)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Name"
        '
        'TextBoxBPName
        '
        Me.TextBoxBPName.Location = New System.Drawing.Point(131, 206)
        Me.TextBoxBPName.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxBPName.Name = "TextBoxBPName"
        Me.TextBoxBPName.Size = New System.Drawing.Size(132, 22)
        Me.TextBoxBPName.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(340, 64)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Posting Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(339, 124)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 17)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Document Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 95)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 17)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Delivery Date"
        '
        'DateTimePickerDocDate
        '
        Me.DateTimePickerDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerDocDate.Location = New System.Drawing.Point(457, 58)
        Me.DateTimePickerDocDate.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerDocDate.Name = "DateTimePickerDocDate"
        Me.DateTimePickerDocDate.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePickerDocDate.TabIndex = 75
        Me.DateTimePickerDocDate.Value = New Date(2019, 6, 22, 23, 37, 9, 0)
        '
        'DateTimePickerDocDueDate
        '
        Me.DateTimePickerDocDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerDocDueDate.Location = New System.Drawing.Point(457, 89)
        Me.DateTimePickerDocDueDate.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerDocDueDate.Name = "DateTimePickerDocDueDate"
        Me.DateTimePickerDocDueDate.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePickerDocDueDate.TabIndex = 76
        Me.DateTimePickerDocDueDate.Value = New Date(2019, 6, 22, 23, 36, 58, 0)
        '
        'DateTimePickerTaxDate
        '
        Me.DateTimePickerTaxDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerTaxDate.Location = New System.Drawing.Point(457, 121)
        Me.DateTimePickerTaxDate.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePickerTaxDate.Name = "DateTimePickerTaxDate"
        Me.DateTimePickerTaxDate.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePickerTaxDate.TabIndex = 77
        Me.DateTimePickerTaxDate.Value = New Date(2019, 6, 22, 23, 37, 16, 0)
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(108, 517)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 32)
        Me.Button2.TabIndex = 86
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(4, 517)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(93, 32)
        Me.BtnOK.TabIndex = 85
        Me.BtnOK.Text = "Add"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(52, 75)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 36)
        Me.btnFind.TabIndex = 87
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(215, 75)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 36)
        Me.btnUpdate.TabIndex = 89
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(133, 75)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 36)
        Me.btnAdd.TabIndex = 88
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(651, 27)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 25)
        Me.Button1.TabIndex = 90
        Me.Button1.Text = "<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(689, 27)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(35, 25)
        Me.Button4.TabIndex = 91
        Me.Button4.Text = ">"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCode, Me.ItemName, Me.Quantity, Me.UnitPrice, Me.Total})
        Me.DataGridView.Location = New System.Drawing.Point(12, 248)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.Size = New System.Drawing.Size(971, 246)
        Me.DataGridView.TabIndex = 92
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Doc Number"
        '
        'TextBoxDocNumber
        '
        Me.TextBoxDocNumber.Enabled = False
        Me.TextBoxDocNumber.Location = New System.Drawing.Point(133, 137)
        Me.TextBoxDocNumber.Name = "TextBoxDocNumber"
        Me.TextBoxDocNumber.Size = New System.Drawing.Size(130, 22)
        Me.TextBoxDocNumber.TabIndex = 94
        '
        'SalesOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 560)
        Me.Controls.Add(Me.TextBoxDocNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Button2)
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
        Me.Name = "SalesOrder"
        Me.Text = "SalesOrder"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnChooseCustomer As System.Windows.Forms.Button
    Friend WithEvents TextBoxBPCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBPName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerDocDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerDocDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerTaxDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ItemCode As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDocNumber As System.Windows.Forms.TextBox
End Class
