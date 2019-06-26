<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UDOdata
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFatherMenuID = New System.Windows.Forms.TextBox()
        Me.lblFatherMenuID = New System.Windows.Forms.Label()
        Me.chkCreateMenu = New System.Windows.Forms.CheckBox()
        Me.RadOldForm = New System.Windows.Forms.RadioButton()
        Me.RadNewForm = New System.Windows.Forms.RadioButton()
        Me.ChkCreateDefaultForm = New System.Windows.Forms.CheckBox()
        Me.btnAddUDO = New System.Windows.Forms.Button()
        Me.grpRecords = New System.Windows.Forms.GroupBox()
        Me.grpChild = New System.Windows.Forms.GroupBox()
        Me.txtMaindish = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDrink = New System.Windows.Forms.TextBox()
        Me.cmdAddchild = New System.Windows.Forms.Button()
        Me.cmdRemovechild = New System.Windows.Forms.Button()
        Me.lstMainDish = New System.Windows.Forms.ListBox()
        Me.lstDrink = New System.Windows.Forms.ListBox()
        Me.lstSideDish = New System.Windows.Forms.ListBox()
        Me.txtSideDish = New System.Windows.Forms.TextBox()
        Me.cmdGetRecord = New System.Windows.Forms.Button()
        Me.cmdDeleteRecord = New System.Windows.Forms.Button()
        Me.cmdUpdateRecord = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdAddRecord = New System.Windows.Forms.Button()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpUDO = New System.Windows.Forms.GroupBox()
        Me.btnAddFields = New System.Windows.Forms.Button()
        Me.chkUDOAfter = New System.Windows.Forms.CheckedListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grpRecords.SuspendLayout()
        Me.grpChild.SuspendLayout()
        Me.grpUDO.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFatherMenuID)
        Me.GroupBox1.Controls.Add(Me.lblFatherMenuID)
        Me.GroupBox1.Controls.Add(Me.chkCreateMenu)
        Me.GroupBox1.Controls.Add(Me.RadOldForm)
        Me.GroupBox1.Controls.Add(Me.RadNewForm)
        Me.GroupBox1.Controls.Add(Me.ChkCreateDefaultForm)
        Me.GroupBox1.Controls.Add(Me.btnAddUDO)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 341)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1167, 146)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Register UDO"
        '
        'txtFatherMenuID
        '
        Me.txtFatherMenuID.Enabled = False
        Me.txtFatherMenuID.Location = New System.Drawing.Point(556, 92)
        Me.txtFatherMenuID.Name = "txtFatherMenuID"
        Me.txtFatherMenuID.Size = New System.Drawing.Size(123, 29)
        Me.txtFatherMenuID.TabIndex = 60
        Me.txtFatherMenuID.Text = "43535"
        '
        'lblFatherMenuID
        '
        Me.lblFatherMenuID.AutoSize = True
        Me.lblFatherMenuID.Enabled = False
        Me.lblFatherMenuID.Location = New System.Drawing.Point(403, 95)
        Me.lblFatherMenuID.Name = "lblFatherMenuID"
        Me.lblFatherMenuID.Size = New System.Drawing.Size(147, 25)
        Me.lblFatherMenuID.TabIndex = 59
        Me.lblFatherMenuID.Text = "Father Menu ID"
        '
        'chkCreateMenu
        '
        Me.chkCreateMenu.AutoSize = True
        Me.chkCreateMenu.Location = New System.Drawing.Point(405, 32)
        Me.chkCreateMenu.Name = "chkCreateMenu"
        Me.chkCreateMenu.Size = New System.Drawing.Size(152, 29)
        Me.chkCreateMenu.TabIndex = 58
        Me.chkCreateMenu.Text = "Create Menu"
        Me.chkCreateMenu.UseVisualStyleBackColor = True
        '
        'RadOldForm
        '
        Me.RadOldForm.AutoSize = True
        Me.RadOldForm.Enabled = False
        Me.RadOldForm.Location = New System.Drawing.Point(104, 107)
        Me.RadOldForm.Name = "RadOldForm"
        Me.RadOldForm.Size = New System.Drawing.Size(184, 29)
        Me.RadOldForm.TabIndex = 57
        Me.RadOldForm.Text = "Old Default Form"
        Me.RadOldForm.UseVisualStyleBackColor = True
        '
        'RadNewForm
        '
        Me.RadNewForm.AutoSize = True
        Me.RadNewForm.Checked = True
        Me.RadNewForm.Enabled = False
        Me.RadNewForm.Location = New System.Drawing.Point(104, 73)
        Me.RadNewForm.Name = "RadNewForm"
        Me.RadNewForm.Size = New System.Drawing.Size(192, 29)
        Me.RadNewForm.TabIndex = 56
        Me.RadNewForm.TabStop = True
        Me.RadNewForm.Text = "New Default Form"
        Me.RadNewForm.UseVisualStyleBackColor = True
        '
        'ChkCreateDefaultForm
        '
        Me.ChkCreateDefaultForm.AutoSize = True
        Me.ChkCreateDefaultForm.Location = New System.Drawing.Point(34, 32)
        Me.ChkCreateDefaultForm.Name = "ChkCreateDefaultForm"
        Me.ChkCreateDefaultForm.Size = New System.Drawing.Size(213, 29)
        Me.ChkCreateDefaultForm.TabIndex = 7
        Me.ChkCreateDefaultForm.Text = "Create Default Form"
        Me.ChkCreateDefaultForm.UseVisualStyleBackColor = True
        '
        'btnAddUDO
        '
        Me.btnAddUDO.Location = New System.Drawing.Point(909, 63)
        Me.btnAddUDO.Name = "btnAddUDO"
        Me.btnAddUDO.Size = New System.Drawing.Size(144, 39)
        Me.btnAddUDO.TabIndex = 6
        Me.btnAddUDO.Text = "Add UDO"
        '
        'grpRecords
        '
        Me.grpRecords.Controls.Add(Me.grpChild)
        Me.grpRecords.Controls.Add(Me.cmdGetRecord)
        Me.grpRecords.Controls.Add(Me.cmdDeleteRecord)
        Me.grpRecords.Controls.Add(Me.cmdUpdateRecord)
        Me.grpRecords.Controls.Add(Me.Label18)
        Me.grpRecords.Controls.Add(Me.txtCode)
        Me.grpRecords.Controls.Add(Me.Label6)
        Me.grpRecords.Controls.Add(Me.cmdAddRecord)
        Me.grpRecords.Controls.Add(Me.txtRoom)
        Me.grpRecords.Controls.Add(Me.txtPrice)
        Me.grpRecords.Controls.Add(Me.Label17)
        Me.grpRecords.Controls.Add(Me.txtName)
        Me.grpRecords.Controls.Add(Me.Label16)
        Me.grpRecords.Controls.Add(Me.Label5)
        Me.grpRecords.Controls.Add(Me.Label15)
        Me.grpRecords.Controls.Add(Me.Label4)
        Me.grpRecords.Controls.Add(Me.Label3)
        Me.grpRecords.Enabled = False
        Me.grpRecords.Location = New System.Drawing.Point(11, 497)
        Me.grpRecords.Name = "grpRecords"
        Me.grpRecords.Size = New System.Drawing.Size(1167, 528)
        Me.grpRecords.TabIndex = 57
        Me.grpRecords.TabStop = False
        Me.grpRecords.Text = "UDO Records"
        '
        'grpChild
        '
        Me.grpChild.Controls.Add(Me.txtMaindish)
        Me.grpChild.Controls.Add(Me.Label7)
        Me.grpChild.Controls.Add(Me.Label9)
        Me.grpChild.Controls.Add(Me.Label8)
        Me.grpChild.Controls.Add(Me.txtDrink)
        Me.grpChild.Controls.Add(Me.cmdAddchild)
        Me.grpChild.Controls.Add(Me.cmdRemovechild)
        Me.grpChild.Controls.Add(Me.lstMainDish)
        Me.grpChild.Controls.Add(Me.lstDrink)
        Me.grpChild.Controls.Add(Me.lstSideDish)
        Me.grpChild.Controls.Add(Me.txtSideDish)
        Me.grpChild.Location = New System.Drawing.Point(14, 122)
        Me.grpChild.Name = "grpChild"
        Me.grpChild.Size = New System.Drawing.Size(1147, 392)
        Me.grpChild.TabIndex = 53
        Me.grpChild.TabStop = False
        Me.grpChild.Text = "Child Records"
        '
        'txtMaindish
        '
        Me.txtMaindish.Location = New System.Drawing.Point(115, 41)
        Me.txtMaindish.Name = "txtMaindish"
        Me.txtMaindish.Size = New System.Drawing.Size(159, 29)
        Me.txtMaindish.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(14, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 39)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Main Dish"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(592, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 39)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Drink"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(288, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 39)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Side Dish"
        '
        'txtDrink
        '
        Me.txtDrink.Location = New System.Drawing.Point(693, 38)
        Me.txtDrink.Name = "txtDrink"
        Me.txtDrink.Size = New System.Drawing.Size(159, 29)
        Me.txtDrink.TabIndex = 46
        '
        'cmdAddchild
        '
        Me.cmdAddchild.Location = New System.Drawing.Point(962, 194)
        Me.cmdAddchild.Name = "cmdAddchild"
        Me.cmdAddchild.Size = New System.Drawing.Size(158, 39)
        Me.cmdAddchild.TabIndex = 49
        Me.cmdAddchild.Text = "Add Child"
        '
        'cmdRemovechild
        '
        Me.cmdRemovechild.Location = New System.Drawing.Point(962, 247)
        Me.cmdRemovechild.Name = "cmdRemovechild"
        Me.cmdRemovechild.Size = New System.Drawing.Size(158, 39)
        Me.cmdRemovechild.TabIndex = 50
        Me.cmdRemovechild.Text = "Remove Child"
        '
        'lstMainDish
        '
        Me.lstMainDish.Enabled = False
        Me.lstMainDish.ItemHeight = 24
        Me.lstMainDish.Location = New System.Drawing.Point(115, 80)
        Me.lstMainDish.Name = "lstMainDish"
        Me.lstMainDish.Size = New System.Drawing.Size(130, 124)
        Me.lstMainDish.TabIndex = 39
        '
        'lstDrink
        '
        Me.lstDrink.Enabled = False
        Me.lstDrink.ItemHeight = 24
        Me.lstDrink.Location = New System.Drawing.Point(693, 80)
        Me.lstDrink.Name = "lstDrink"
        Me.lstDrink.Size = New System.Drawing.Size(130, 124)
        Me.lstDrink.TabIndex = 41
        '
        'lstSideDish
        '
        Me.lstSideDish.Enabled = False
        Me.lstSideDish.ItemHeight = 24
        Me.lstSideDish.Location = New System.Drawing.Point(391, 80)
        Me.lstSideDish.Name = "lstSideDish"
        Me.lstSideDish.Size = New System.Drawing.Size(130, 124)
        Me.lstSideDish.TabIndex = 40
        '
        'txtSideDish
        '
        Me.txtSideDish.Location = New System.Drawing.Point(391, 41)
        Me.txtSideDish.Name = "txtSideDish"
        Me.txtSideDish.Size = New System.Drawing.Size(180, 29)
        Me.txtSideDish.TabIndex = 3
        '
        'cmdGetRecord
        '
        Me.cmdGetRecord.Location = New System.Drawing.Point(792, 74)
        Me.cmdGetRecord.Name = "cmdGetRecord"
        Me.cmdGetRecord.Size = New System.Drawing.Size(173, 39)
        Me.cmdGetRecord.TabIndex = 38
        Me.cmdGetRecord.Text = "Get Record"
        '
        'cmdDeleteRecord
        '
        Me.cmdDeleteRecord.Location = New System.Drawing.Point(792, 27)
        Me.cmdDeleteRecord.Name = "cmdDeleteRecord"
        Me.cmdDeleteRecord.Size = New System.Drawing.Size(173, 39)
        Me.cmdDeleteRecord.TabIndex = 37
        Me.cmdDeleteRecord.Text = "Delete Record"
        '
        'cmdUpdateRecord
        '
        Me.cmdUpdateRecord.Location = New System.Drawing.Point(605, 74)
        Me.cmdUpdateRecord.Name = "cmdUpdateRecord"
        Me.cmdUpdateRecord.Size = New System.Drawing.Size(173, 39)
        Me.cmdUpdateRecord.TabIndex = 36
        Me.cmdUpdateRecord.Text = "UpdateRecord"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(22, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 39)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Code"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(115, 41)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(180, 29)
        Me.txtCode.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(29, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 39)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Code"
        '
        'cmdAddRecord
        '
        Me.cmdAddRecord.Location = New System.Drawing.Point(605, 27)
        Me.cmdAddRecord.Name = "cmdAddRecord"
        Me.cmdAddRecord.Size = New System.Drawing.Size(173, 39)
        Me.cmdAddRecord.TabIndex = 33
        Me.cmdAddRecord.Text = "Add Record"
        '
        'txtRoom
        '
        Me.txtRoom.Location = New System.Drawing.Point(115, 81)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(180, 29)
        Me.txtRoom.TabIndex = 5
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(403, 81)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(180, 29)
        Me.txtPrice.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(310, 81)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 39)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Price"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(403, 41)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(180, 29)
        Me.txtName.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(22, 81)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 39)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Room"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(317, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 39)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Price"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(310, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 39)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Name"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(29, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 39)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Room"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(317, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 39)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Name"
        '
        'grpUDO
        '
        Me.grpUDO.Controls.Add(Me.btnAddFields)
        Me.grpUDO.Controls.Add(Me.chkUDOAfter)
        Me.grpUDO.Controls.Add(Me.btnAdd)
        Me.grpUDO.Enabled = False
        Me.grpUDO.Location = New System.Drawing.Point(11, 20)
        Me.grpUDO.Name = "grpUDO"
        Me.grpUDO.Size = New System.Drawing.Size(1167, 311)
        Me.grpUDO.TabIndex = 56
        Me.grpUDO.TabStop = False
        Me.grpUDO.Text = "User-Defined Tables, Fields and Objects"
        '
        'btnAddFields
        '
        Me.btnAddFields.Location = New System.Drawing.Point(41, 119)
        Me.btnAddFields.Name = "btnAddFields"
        Me.btnAddFields.Size = New System.Drawing.Size(144, 39)
        Me.btnAddFields.TabIndex = 4
        Me.btnAddFields.Text = "Add Fields"
        '
        'chkUDOAfter
        '
        Me.chkUDOAfter.Items.AddRange(New Object() {"SM_OMOR table", "... Name Field", "... Room Field", "... Price Field", "SM_MOR1 Table", "... Line Type", "... MainDish Field", "... SideDish Field", "... Drink Field", "... Line Price", "SM_MOR Object"})
        Me.chkUDOAfter.Location = New System.Drawing.Point(201, 51)
        Me.chkUDOAfter.Name = "chkUDOAfter"
        Me.chkUDOAfter.Size = New System.Drawing.Size(245, 196)
        Me.chkUDOAfter.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(41, 51)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(144, 39)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Tables"
        '
        'UDOdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 1105)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpRecords)
        Me.Controls.Add(Me.grpUDO)
        Me.Name = "UDOdata"
        Me.Text = "UDOdata"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpRecords.ResumeLayout(False)
        Me.grpRecords.PerformLayout()
        Me.grpChild.ResumeLayout(False)
        Me.grpChild.PerformLayout()
        Me.grpUDO.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtFatherMenuID As System.Windows.Forms.TextBox
    Friend WithEvents lblFatherMenuID As System.Windows.Forms.Label
    Friend WithEvents chkCreateMenu As System.Windows.Forms.CheckBox
    Friend WithEvents RadOldForm As System.Windows.Forms.RadioButton
    Friend WithEvents RadNewForm As System.Windows.Forms.RadioButton
    Friend WithEvents ChkCreateDefaultForm As System.Windows.Forms.CheckBox
    Friend WithEvents btnAddUDO As System.Windows.Forms.Button
    Friend WithEvents grpRecords As System.Windows.Forms.GroupBox
    Friend WithEvents grpChild As System.Windows.Forms.GroupBox
    Friend WithEvents txtMaindish As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDrink As System.Windows.Forms.TextBox
    Friend WithEvents cmdAddchild As System.Windows.Forms.Button
    Friend WithEvents cmdRemovechild As System.Windows.Forms.Button
    Friend WithEvents lstMainDish As System.Windows.Forms.ListBox
    Friend WithEvents lstDrink As System.Windows.Forms.ListBox
    Friend WithEvents lstSideDish As System.Windows.Forms.ListBox
    Friend WithEvents txtSideDish As System.Windows.Forms.TextBox
    Friend WithEvents cmdGetRecord As System.Windows.Forms.Button
    Friend WithEvents cmdDeleteRecord As System.Windows.Forms.Button
    Friend WithEvents cmdUpdateRecord As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdAddRecord As System.Windows.Forms.Button
    Friend WithEvents txtRoom As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpUDO As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddFields As System.Windows.Forms.Button
    Friend WithEvents chkUDOAfter As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
