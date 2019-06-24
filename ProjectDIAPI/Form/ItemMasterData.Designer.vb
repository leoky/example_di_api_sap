<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemMasterData
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxItemNo = New System.Windows.Forms.TextBox()
        Me.GroupBoxHeadItemMasterData = New System.Windows.Forms.GroupBox()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxDescription = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.GroupBoxNavigation = New System.Windows.Forms.GroupBox()
        Me.GroupBoxHeadItemMasterData.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxNavigation.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Decription"
        '
        'TextBoxItemNo
        '
        Me.TextBoxItemNo.Location = New System.Drawing.Point(100, 21)
        Me.TextBoxItemNo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxItemNo.Name = "TextBoxItemNo"
        Me.TextBoxItemNo.Size = New System.Drawing.Size(151, 22)
        Me.TextBoxItemNo.TabIndex = 2
        '
        'GroupBoxHeadItemMasterData
        '
        Me.GroupBoxHeadItemMasterData.Controls.Add(Me.TextBoxPrice)
        Me.GroupBoxHeadItemMasterData.Controls.Add(Me.Label3)
        Me.GroupBoxHeadItemMasterData.Controls.Add(Me.TextBoxDescription)
        Me.GroupBoxHeadItemMasterData.Controls.Add(Me.Label1)
        Me.GroupBoxHeadItemMasterData.Controls.Add(Me.Label2)
        Me.GroupBoxHeadItemMasterData.Controls.Add(Me.TextBoxItemNo)
        Me.GroupBoxHeadItemMasterData.Location = New System.Drawing.Point(19, 64)
        Me.GroupBoxHeadItemMasterData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxHeadItemMasterData.Name = "GroupBoxHeadItemMasterData"
        Me.GroupBoxHeadItemMasterData.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxHeadItemMasterData.Size = New System.Drawing.Size(1000, 151)
        Me.GroupBoxHeadItemMasterData.TabIndex = 3
        Me.GroupBoxHeadItemMasterData.TabStop = False
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Location = New System.Drawing.Point(100, 106)
        Me.TextBoxPrice.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(151, 22)
        Me.TextBoxPrice.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Price"
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Location = New System.Drawing.Point(100, 64)
        Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.Size = New System.Drawing.Size(409, 22)
        Me.TextBoxDescription.TabIndex = 3
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(12, 505)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(93, 32)
        Me.btnOk.TabIndex = 4
        Me.btnOk.Text = "Add"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(112, 505)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 32)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(5, 17)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 6
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(87, 17)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(441, 17)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 8
        Me.btnNext.Text = "Previous"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(521, 17)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 9
        Me.btnPrevious.Text = "Next"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(168, 17)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'GroupBoxNavigation
        '
        Me.GroupBoxNavigation.Controls.Add(Me.btnFind)
        Me.GroupBoxNavigation.Controls.Add(Me.btnNext)
        Me.GroupBoxNavigation.Controls.Add(Me.btnPrevious)
        Me.GroupBoxNavigation.Controls.Add(Me.btnUpdate)
        Me.GroupBoxNavigation.Controls.Add(Me.btnAdd)
        Me.GroupBoxNavigation.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxNavigation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxNavigation.Name = "GroupBoxNavigation"
        Me.GroupBoxNavigation.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxNavigation.Size = New System.Drawing.Size(1000, 46)
        Me.GroupBoxNavigation.TabIndex = 11
        Me.GroupBoxNavigation.TabStop = False
        '
        'ItemMasterData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 543)
        Me.Controls.Add(Me.GroupBoxNavigation)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.GroupBoxHeadItemMasterData)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ItemMasterData"
        Me.Text = "Item Master Data"
        Me.GroupBoxHeadItemMasterData.ResumeLayout(False)
        Me.GroupBoxHeadItemMasterData.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxNavigation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxItemNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxHeadItemMasterData As System.Windows.Forms.GroupBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents GroupBoxNavigation As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
