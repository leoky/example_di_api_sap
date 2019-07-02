<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APInvoice
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.TextBoxDocNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.DateTimePickerTaxDate = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerDocDueDate = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerDocDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.ItemCode = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBoxCopyTo = New System.Windows.Forms.ComboBox()
        Me.TextBoxDocStatus = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxDocTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TextBoxBPName = New System.Windows.Forms.TextBox()
        Me.TextBoxBPCode = New System.Windows.Forms.TextBox()
        Me.btnChooseCustomer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelOrderNum = New System.Windows.Forms.Label()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(905, 935)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 25)
        Me.Label10.TabIndex = 156
        Me.Label10.Text = "Copy To"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(1192, 116)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(48, 38)
        Me.btnNext.TabIndex = 147
        Me.btnNext.Text = "<"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'TextBoxDocNumber
        '
        Me.TextBoxDocNumber.Enabled = False
        Me.TextBoxDocNumber.Location = New System.Drawing.Point(187, 149)
        Me.TextBoxDocNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxDocNumber.Name = "TextBoxDocNumber"
        Me.TextBoxDocNumber.Size = New System.Drawing.Size(177, 29)
        Me.TextBoxDocNumber.TabIndex = 150
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 153)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 25)
        Me.Label7.TabIndex = 149
        Me.Label7.Text = "Doc Number"
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(1248, 116)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(45, 38)
        Me.btnPrevious.TabIndex = 146
        Me.btnPrevious.Text = ">"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(13, 935)
        Me.BtnOK.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(128, 48)
        Me.BtnOK.TabIndex = 141
        Me.BtnOK.Text = "Add"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'DateTimePickerTaxDate
        '
        Me.DateTimePickerTaxDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerTaxDate.Location = New System.Drawing.Point(930, 265)
        Me.DateTimePickerTaxDate.Margin = New System.Windows.Forms.Padding(6)
        Me.DateTimePickerTaxDate.Name = "DateTimePickerTaxDate"
        Me.DateTimePickerTaxDate.Size = New System.Drawing.Size(363, 29)
        Me.DateTimePickerTaxDate.TabIndex = 140
        Me.DateTimePickerTaxDate.Value = New Date(2019, 6, 22, 23, 37, 16, 0)
        '
        'DateTimePickerDocDueDate
        '
        Me.DateTimePickerDocDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerDocDueDate.Location = New System.Drawing.Point(930, 217)
        Me.DateTimePickerDocDueDate.Margin = New System.Windows.Forms.Padding(6)
        Me.DateTimePickerDocDueDate.Name = "DateTimePickerDocDueDate"
        Me.DateTimePickerDocDueDate.Size = New System.Drawing.Size(363, 29)
        Me.DateTimePickerDocDueDate.TabIndex = 139
        Me.DateTimePickerDocDueDate.Value = New Date(2019, 6, 22, 23, 36, 58, 0)
        '
        'DateTimePickerDocDate
        '
        Me.DateTimePickerDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerDocDate.Location = New System.Drawing.Point(930, 171)
        Me.DateTimePickerDocDate.Margin = New System.Windows.Forms.Padding(6)
        Me.DateTimePickerDocDate.Name = "DateTimePickerDocDate"
        Me.DateTimePickerDocDate.Size = New System.Drawing.Size(363, 29)
        Me.DateTimePickerDocDate.TabIndex = 138
        Me.DateTimePickerDocDate.Value = New Date(2019, 6, 22, 23, 37, 9, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(769, 226)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 25)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Delivery Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(768, 269)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 25)
        Me.Label5.TabIndex = 136
        Me.Label5.Text = "Document Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(769, 179)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 25)
        Me.Label4.TabIndex = 135
        Me.Label4.Text = "Posting Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 256)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 25)
        Me.Label3.TabIndex = 133
        Me.Label3.Text = "Name"
        '
        'DataGridView
        '
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCode, Me.ItemName, Me.Quantity, Me.UnitPrice, Me.Total})
        Me.DataGridView.Location = New System.Drawing.Point(13, 375)
        Me.DataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowTemplate.Height = 24
        Me.DataGridView.Size = New System.Drawing.Size(1280, 380)
        Me.DataGridView.TabIndex = 148
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
        'ComboBoxCopyTo
        '
        Me.ComboBoxCopyTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCopyTo.Enabled = False
        Me.ComboBoxCopyTo.FormattingEnabled = True
        Me.ComboBoxCopyTo.Items.AddRange(New Object() {"A / R Invoice"})
        Me.ComboBoxCopyTo.Location = New System.Drawing.Point(1014, 935)
        Me.ComboBoxCopyTo.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBoxCopyTo.Name = "ComboBoxCopyTo"
        Me.ComboBoxCopyTo.Size = New System.Drawing.Size(252, 32)
        Me.ComboBoxCopyTo.TabIndex = 155
        '
        'TextBoxDocStatus
        '
        Me.TextBoxDocStatus.Enabled = False
        Me.TextBoxDocStatus.Location = New System.Drawing.Point(930, 323)
        Me.TextBoxDocStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxDocStatus.Name = "TextBoxDocStatus"
        Me.TextBoxDocStatus.Size = New System.Drawing.Size(363, 29)
        Me.TextBoxDocStatus.TabIndex = 154
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(768, 323)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 25)
        Me.Label9.TabIndex = 153
        Me.Label9.Text = "Doc Status"
        '
        'TextBoxDocTotal
        '
        Me.TextBoxDocTotal.Location = New System.Drawing.Point(835, 779)
        Me.TextBoxDocTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxDocTotal.Name = "TextBoxDocTotal"
        Me.TextBoxDocTotal.Size = New System.Drawing.Size(430, 29)
        Me.TextBoxDocTotal.TabIndex = 152
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(743, 779)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 25)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "Total"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(149, 935)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(128, 48)
        Me.btnCancel.TabIndex = 142
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'TextBoxBPName
        '
        Me.TextBoxBPName.Location = New System.Drawing.Point(185, 253)
        Me.TextBoxBPName.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBoxBPName.Name = "TextBoxBPName"
        Me.TextBoxBPName.Size = New System.Drawing.Size(180, 29)
        Me.TextBoxBPName.TabIndex = 134
        '
        'TextBoxBPCode
        '
        Me.TextBoxBPCode.Location = New System.Drawing.Point(185, 206)
        Me.TextBoxBPCode.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBoxBPCode.Name = "TextBoxBPCode"
        Me.TextBoxBPCode.Size = New System.Drawing.Size(180, 29)
        Me.TextBoxBPCode.TabIndex = 132
        '
        'btnChooseCustomer
        '
        Me.btnChooseCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChooseCustomer.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnChooseCustomer.Location = New System.Drawing.Point(373, 206)
        Me.btnChooseCustomer.Margin = New System.Windows.Forms.Padding(6)
        Me.btnChooseCustomer.Name = "btnChooseCustomer"
        Me.btnChooseCustomer.Size = New System.Drawing.Size(29, 30)
        Me.btnChooseCustomer.TabIndex = 131
        Me.btnChooseCustomer.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 209)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 25)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "Vendor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 39)
        Me.Label1.TabIndex = 157
        Me.Label1.Text = "A/P Invoice"
        '
        'LabelOrderNum
        '
        Me.LabelOrderNum.AutoSize = True
        Me.LabelOrderNum.Location = New System.Drawing.Point(1261, 59)
        Me.LabelOrderNum.Name = "LabelOrderNum"
        Me.LabelOrderNum.Size = New System.Drawing.Size(23, 25)
        Me.LabelOrderNum.TabIndex = 158
        Me.LabelOrderNum.Text = "0"
        '
        'APInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1342, 1016)
        Me.Controls.Add(Me.LabelOrderNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.TextBoxDocNumber)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.DateTimePickerTaxDate)
        Me.Controls.Add(Me.DateTimePickerDocDueDate)
        Me.Controls.Add(Me.DateTimePickerDocDate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.ComboBoxCopyTo)
        Me.Controls.Add(Me.TextBoxDocStatus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBoxDocTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.TextBoxBPName)
        Me.Controls.Add(Me.TextBoxBPCode)
        Me.Controls.Add(Me.btnChooseCustomer)
        Me.Controls.Add(Me.Label2)
        Me.Name = "APInvoice"
        Me.Text = "APInvoice"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents TextBoxDocNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerTaxDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerDocDueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerDocDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ItemCode As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents ItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBoxCopyTo As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxDocStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDocTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents TextBoxBPName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBPCode As System.Windows.Forms.TextBox
    Friend WithEvents btnChooseCustomer As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelOrderNum As System.Windows.Forms.Label
End Class
