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
        Me.GroupBoxAddUDO = New System.Windows.Forms.GroupBox()
        Me.btnAddFields = New System.Windows.Forms.Button()
        Me.chkUDOAfter = New System.Windows.Forms.CheckedListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtFatherMenuID = New System.Windows.Forms.TextBox()
        Me.lblFatherMenuID = New System.Windows.Forms.Label()
        Me.chkCreateMenu = New System.Windows.Forms.CheckBox()
        Me.RadOldForm = New System.Windows.Forms.RadioButton()
        Me.RadNewForm = New System.Windows.Forms.RadioButton()
        Me.ChkCreateDefaultForm = New System.Windows.Forms.CheckBox()
        Me.btnAddUDO = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdGetRecord = New System.Windows.Forms.Button()
        Me.cmdDeleteRecord = New System.Windows.Forms.Button()
        Me.cmdUpdateRecord = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmdAddRecord = New System.Windows.Forms.Button()
        Me.txtRoom = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMaindish = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDrink = New System.Windows.Forms.TextBox()
        Me.txtSideDish = New System.Windows.Forms.TextBox()
        Me.cmdAddchild = New System.Windows.Forms.Button()
        Me.cmdRemovechild = New System.Windows.Forms.Button()
        Me.lstAlpha = New System.Windows.Forms.ListBox()
        Me.lstGamma = New System.Windows.Forms.ListBox()
        Me.lstBeta = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBoxAddUDO.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBoxAddUDO
        '
        Me.GroupBoxAddUDO.Controls.Add(Me.btnAddFields)
        Me.GroupBoxAddUDO.Controls.Add(Me.chkUDOAfter)
        Me.GroupBoxAddUDO.Controls.Add(Me.btnAdd)
        Me.GroupBoxAddUDO.Location = New System.Drawing.Point(3, 13)
        Me.GroupBoxAddUDO.Name = "GroupBoxAddUDO"
        Me.GroupBoxAddUDO.Size = New System.Drawing.Size(1066, 267)
        Me.GroupBoxAddUDO.TabIndex = 6
        Me.GroupBoxAddUDO.TabStop = false
        Me.GroupBoxAddUDO.Text = "Add User Define Object"
        '
        'btnAddFields
        '
        Me.btnAddFields.Location = New System.Drawing.Point(318, 142)
        Me.btnAddFields.Name = "btnAddFields"
        Me.btnAddFields.Size = New System.Drawing.Size(144, 39)
        Me.btnAddFields.TabIndex = 7
        Me.btnAddFields.Text = "Add Fields"
        '
        'chkUDOAfter
        '
        Me.chkUDOAfter.Items.AddRange(New Object() {"SM_UDPT table", "... Name Field", "... Description Field", "... Price Field", "SM_UDCT Table", "... Line Type", "... Row Alpha Field", "... Row Beta Field", "... Row Gamma Field", "... Line Price", "SM_DPT Object"})
        Me.chkUDOAfter.Location = New System.Drawing.Point(9, 46)
        Me.chkUDOAfter.Name = "chkUDOAfter"
        Me.chkUDOAfter.Size = New System.Drawing.Size(260, 196)
        Me.chkUDOAfter.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(318, 86)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(144, 39)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add Tables"
        '
        'txtFatherMenuID
        '
        Me.txtFatherMenuID.Enabled = false
        Me.txtFatherMenuID.Location = New System.Drawing.Point(481, 88)
        Me.txtFatherMenuID.Name = "txtFatherMenuID"
        Me.txtFatherMenuID.Size = New System.Drawing.Size(123, 29)
        Me.txtFatherMenuID.TabIndex = 66
        Me.txtFatherMenuID.Text = "43535"
        '
        'lblFatherMenuID
        '
        Me.lblFatherMenuID.AutoSize = true
        Me.lblFatherMenuID.Enabled = false
        Me.lblFatherMenuID.Location = New System.Drawing.Point(328, 91)
        Me.lblFatherMenuID.Name = "lblFatherMenuID"
        Me.lblFatherMenuID.Size = New System.Drawing.Size(147, 25)
        Me.lblFatherMenuID.TabIndex = 65
        Me.lblFatherMenuID.Text = "Father Menu ID"
        '
        'chkCreateMenu
        '
        Me.chkCreateMenu.AutoSize = true
        Me.chkCreateMenu.Location = New System.Drawing.Point(303, 52)
        Me.chkCreateMenu.Name = "chkCreateMenu"
        Me.chkCreateMenu.Size = New System.Drawing.Size(152, 29)
        Me.chkCreateMenu.TabIndex = 64
        Me.chkCreateMenu.Text = "Create Menu"
        Me.chkCreateMenu.UseVisualStyleBackColor = true
        '
        'RadOldForm
        '
        Me.RadOldForm.AutoSize = true
        Me.RadOldForm.Enabled = false
        Me.RadOldForm.Location = New System.Drawing.Point(64, 121)
        Me.RadOldForm.Name = "RadOldForm"
        Me.RadOldForm.Size = New System.Drawing.Size(184, 29)
        Me.RadOldForm.TabIndex = 63
        Me.RadOldForm.Text = "Old Default Form"
        Me.RadOldForm.UseVisualStyleBackColor = true
        '
        'RadNewForm
        '
        Me.RadNewForm.AutoSize = true
        Me.RadNewForm.Checked = true
        Me.RadNewForm.Enabled = false
        Me.RadNewForm.Location = New System.Drawing.Point(64, 87)
        Me.RadNewForm.Name = "RadNewForm"
        Me.RadNewForm.Size = New System.Drawing.Size(192, 29)
        Me.RadNewForm.TabIndex = 62
        Me.RadNewForm.TabStop = true
        Me.RadNewForm.Text = "New Default Form"
        Me.RadNewForm.UseVisualStyleBackColor = true
        '
        'ChkCreateDefaultForm
        '
        Me.ChkCreateDefaultForm.AutoSize = true
        Me.ChkCreateDefaultForm.Location = New System.Drawing.Point(43, 52)
        Me.ChkCreateDefaultForm.Name = "ChkCreateDefaultForm"
        Me.ChkCreateDefaultForm.Size = New System.Drawing.Size(213, 29)
        Me.ChkCreateDefaultForm.TabIndex = 61
        Me.ChkCreateDefaultForm.Text = "Create Default Form"
        Me.ChkCreateDefaultForm.UseVisualStyleBackColor = true
        '
        'btnAddUDO
        '
        Me.btnAddUDO.Location = New System.Drawing.Point(642, 82)
        Me.btnAddUDO.Name = "btnAddUDO"
        Me.btnAddUDO.Size = New System.Drawing.Size(144, 39)
        Me.btnAddUDO.TabIndex = 67
        Me.btnAddUDO.Text = "Add UDO"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAddUDO)
        Me.GroupBox1.Controls.Add(Me.txtFatherMenuID)
        Me.GroupBox1.Controls.Add(Me.lblFatherMenuID)
        Me.GroupBox1.Controls.Add(Me.chkCreateMenu)
        Me.GroupBox1.Controls.Add(Me.RadOldForm)
        Me.GroupBox1.Controls.Add(Me.RadNewForm)
        Me.GroupBox1.Controls.Add(Me.ChkCreateDefaultForm)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 286)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1066, 177)
        Me.GroupBox1.TabIndex = 68
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Register User Define Object"
        '
        'cmdGetRecord
        '
        Me.cmdGetRecord.Location = New System.Drawing.Point(808, 107)
        Me.cmdGetRecord.Name = "cmdGetRecord"
        Me.cmdGetRecord.Size = New System.Drawing.Size(173, 39)
        Me.cmdGetRecord.TabIndex = 80
        Me.cmdGetRecord.Text = "Get Record"
        '
        'cmdDeleteRecord
        '
        Me.cmdDeleteRecord.Location = New System.Drawing.Point(808, 53)
        Me.cmdDeleteRecord.Name = "cmdDeleteRecord"
        Me.cmdDeleteRecord.Size = New System.Drawing.Size(173, 39)
        Me.cmdDeleteRecord.TabIndex = 79
        Me.cmdDeleteRecord.Text = "Delete Record"
        '
        'cmdUpdateRecord
        '
        Me.cmdUpdateRecord.Location = New System.Drawing.Point(614, 107)
        Me.cmdUpdateRecord.Name = "cmdUpdateRecord"
        Me.cmdUpdateRecord.Size = New System.Drawing.Size(173, 39)
        Me.cmdUpdateRecord.TabIndex = 78
        Me.cmdUpdateRecord.Text = "UpdateRecord"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(124, 67)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(180, 29)
        Me.txtCode.TabIndex = 77
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(38, 67)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 39)
        Me.Label18.TabIndex = 76
        Me.Label18.Text = "Code"
        '
        'cmdAddRecord
        '
        Me.cmdAddRecord.Location = New System.Drawing.Point(614, 53)
        Me.cmdAddRecord.Name = "cmdAddRecord"
        Me.cmdAddRecord.Size = New System.Drawing.Size(173, 39)
        Me.cmdAddRecord.TabIndex = 75
        Me.cmdAddRecord.Text = "Add Record"
        '
        'txtRoom
        '
        Me.txtRoom.Location = New System.Drawing.Point(124, 107)
        Me.txtRoom.Name = "txtRoom"
        Me.txtRoom.Size = New System.Drawing.Size(180, 29)
        Me.txtRoom.TabIndex = 74
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(412, 107)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(180, 29)
        Me.txtPrice.TabIndex = 73
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(412, 67)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(180, 29)
        Me.txtName.TabIndex = 72
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(326, 107)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 39)
        Me.Label17.TabIndex = 71
        Me.Label17.Text = "Price"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(38, 107)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 39)
        Me.Label16.TabIndex = 70
        Me.Label16.Text = "Desc"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(326, 67)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 39)
        Me.Label15.TabIndex = 69
        Me.Label15.Text = "Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdGetRecord)
        Me.GroupBox2.Controls.Add(Me.cmdDeleteRecord)
        Me.GroupBox2.Controls.Add(Me.cmdUpdateRecord)
        Me.GroupBox2.Controls.Add(Me.txtCode)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.cmdAddRecord)
        Me.GroupBox2.Controls.Add(Me.txtRoom)
        Me.GroupBox2.Controls.Add(Me.txtPrice)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 482)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1065, 195)
        Me.GroupBox2.TabIndex = 81
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "User Define Records"
        '
        'txtMaindish
        '
        Me.txtMaindish.Location = New System.Drawing.Point(145, 26)
        Me.txtMaindish.Name = "txtMaindish"
        Me.txtMaindish.Size = New System.Drawing.Size(159, 29)
        Me.txtMaindish.TabIndex = 85
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(44, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 39)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Alpha"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(596, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 39)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Gamma"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(318, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 39)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Beta"
        '
        'txtDrink
        '
        Me.txtDrink.Location = New System.Drawing.Point(697, 29)
        Me.txtDrink.Name = "txtDrink"
        Me.txtDrink.Size = New System.Drawing.Size(159, 29)
        Me.txtDrink.TabIndex = 89
        '
        'txtSideDish
        '
        Me.txtSideDish.Location = New System.Drawing.Point(419, 26)
        Me.txtSideDish.Name = "txtSideDish"
        Me.txtSideDish.Size = New System.Drawing.Size(158, 29)
        Me.txtSideDish.TabIndex = 87
        '
        'cmdAddchild
        '
        Me.cmdAddchild.Location = New System.Drawing.Point(43, 270)
        Me.cmdAddchild.Name = "cmdAddchild"
        Me.cmdAddchild.Size = New System.Drawing.Size(115, 39)
        Me.cmdAddchild.TabIndex = 92
        Me.cmdAddchild.Text = "Add Child"
        '
        'cmdRemovechild
        '
        Me.cmdRemovechild.Location = New System.Drawing.Point(179, 270)
        Me.cmdRemovechild.Name = "cmdRemovechild"
        Me.cmdRemovechild.Size = New System.Drawing.Size(158, 39)
        Me.cmdRemovechild.TabIndex = 93
        Me.cmdRemovechild.Text = "Remove Child"
        '
        'lstAlpha
        '
        Me.lstAlpha.Enabled = false
        Me.lstAlpha.ItemHeight = 24
        Me.lstAlpha.Location = New System.Drawing.Point(145, 78)
        Me.lstAlpha.Name = "lstAlpha"
        Me.lstAlpha.Size = New System.Drawing.Size(130, 124)
        Me.lstAlpha.TabIndex = 82
        '
        'lstGamma
        '
        Me.lstGamma.Enabled = false
        Me.lstGamma.ItemHeight = 24
        Me.lstGamma.Location = New System.Drawing.Point(697, 78)
        Me.lstGamma.Name = "lstGamma"
        Me.lstGamma.Size = New System.Drawing.Size(130, 124)
        Me.lstGamma.TabIndex = 84
        '
        'lstBeta
        '
        Me.lstBeta.Enabled = false
        Me.lstBeta.ItemHeight = 24
        Me.lstBeta.Location = New System.Drawing.Point(419, 78)
        Me.lstBeta.Name = "lstBeta"
        Me.lstBeta.Size = New System.Drawing.Size(130, 124)
        Me.lstBeta.TabIndex = 83
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMaindish)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtDrink)
        Me.GroupBox3.Controls.Add(Me.txtSideDish)
        Me.GroupBox3.Controls.Add(Me.cmdAddchild)
        Me.GroupBox3.Controls.Add(Me.cmdRemovechild)
        Me.GroupBox3.Controls.Add(Me.lstAlpha)
        Me.GroupBox3.Controls.Add(Me.lstGamma)
        Me.GroupBox3.Controls.Add(Me.lstBeta)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 706)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1066, 327)
        Me.GroupBox3.TabIndex = 94
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Child Record"
        '
        'UDOdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11!, 24!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 1086)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxAddUDO)
        Me.Name = "UDOdata"
        Me.Text = "UDOdata"
        Me.GroupBoxAddUDO.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents GroupBoxAddUDO As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddFields As System.Windows.Forms.Button
    Friend WithEvents chkUDOAfter As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtFatherMenuID As System.Windows.Forms.TextBox
    Friend WithEvents lblFatherMenuID As System.Windows.Forms.Label
    Friend WithEvents chkCreateMenu As System.Windows.Forms.CheckBox
    Friend WithEvents RadOldForm As System.Windows.Forms.RadioButton
    Friend WithEvents RadNewForm As System.Windows.Forms.RadioButton
    Friend WithEvents ChkCreateDefaultForm As System.Windows.Forms.CheckBox
    Friend WithEvents btnAddUDO As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGetRecord As System.Windows.Forms.Button
    Friend WithEvents cmdDeleteRecord As System.Windows.Forms.Button
    Friend WithEvents cmdUpdateRecord As System.Windows.Forms.Button
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmdAddRecord As System.Windows.Forms.Button
    Friend WithEvents txtRoom As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMaindish As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDrink As System.Windows.Forms.TextBox
    Friend WithEvents txtSideDish As System.Windows.Forms.TextBox
    Friend WithEvents cmdAddchild As System.Windows.Forms.Button
    Friend WithEvents cmdRemovechild As System.Windows.Forms.Button
    Friend WithEvents lstAlpha As System.Windows.Forms.ListBox
    Friend WithEvents lstGamma As System.Windows.Forms.ListBox
    Friend WithEvents lstBeta As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
