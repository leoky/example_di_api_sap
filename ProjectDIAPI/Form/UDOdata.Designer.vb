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
        Me.grpUDO = New System.Windows.Forms.GroupBox()
        Me.btnAddFields = New System.Windows.Forms.Button()
        Me.chkUDOAfter = New System.Windows.Forms.CheckedListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpUDO.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpUDO
        '
        Me.grpUDO.Controls.Add(Me.btnAddFields)
        Me.grpUDO.Controls.Add(Me.chkUDOAfter)
        Me.grpUDO.Controls.Add(Me.btnAdd)
        Me.grpUDO.Enabled = False
        Me.grpUDO.Location = New System.Drawing.Point(6, 11)
        Me.grpUDO.Margin = New System.Windows.Forms.Padding(2)
        Me.grpUDO.Name = "grpUDO"
        Me.grpUDO.Padding = New System.Windows.Forms.Padding(2)
        Me.grpUDO.Size = New System.Drawing.Size(637, 515)
        Me.grpUDO.TabIndex = 56
        Me.grpUDO.TabStop = False
        Me.grpUDO.Text = "User-Defined Tables and Fields "
        '
        'btnAddFields
        '
        Me.btnAddFields.Location = New System.Drawing.Point(22, 64)
        Me.btnAddFields.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddFields.Name = "btnAddFields"
        Me.btnAddFields.Size = New System.Drawing.Size(79, 21)
        Me.btnAddFields.TabIndex = 4
        Me.btnAddFields.Text = "Add Fields"
        '
        'chkUDOAfter
        '
        Me.chkUDOAfter.Items.AddRange(New Object() {"VIT_TandaTrm table", "... VIT_STATUS Field", "... VIT_INVDUEDATE", "... VIT_TGLSERAH", "... VIT_JAMSERAH", "... VIT_NAMASERAH", "... VIT_TGLKEMBALI", "... VIT_JAMKEMBALI", "VIT_TandaTrmD Table", "... VIT_INVNO", "... VIT_LISTTT", "... VIT_INVDATE ", "... VIT_INVDUEDATE", "... VIT_TOP", "... VIT_CUSTCODE", "... VIT_CUSTNAME", "... VIT_SLSEMP", "... VIT_DOCTOTAL", "... VIT_OPENAMT", "... VIT_GIROAMT", "... VIT_CHECKKMBL ", "... VIT_TITIPINV", "... VIT_REMARKS", "... VIT_NOTTD"})
        Me.chkUDOAfter.Location = New System.Drawing.Point(110, 28)
        Me.chkUDOAfter.Margin = New System.Windows.Forms.Padding(2)
        Me.chkUDOAfter.Name = "chkUDOAfter"
        Me.chkUDOAfter.Size = New System.Drawing.Size(231, 379)
        Me.chkUDOAfter.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(22, 28)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(79, 21)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Tables"
        '
        'UDOdata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 575)
        Me.Controls.Add(Me.grpUDO)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UDOdata"
        Me.Text = "UDOdata"
        Me.grpUDO.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpUDO As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddFields As System.Windows.Forms.Button
    Friend WithEvents chkUDOAfter As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
