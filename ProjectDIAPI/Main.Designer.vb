<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.btnChooseCompany = New System.Windows.Forms.Button()
        Me.GroupBoxMain = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnItemMasterData = New System.Windows.Forms.Button()
        Me.btnSalesOrder = New System.Windows.Forms.Button()
        Me.GroupBoxMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnChooseCompany
        '
        Me.btnChooseCompany.Location = New System.Drawing.Point(21, 12)
        Me.btnChooseCompany.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnChooseCompany.Name = "btnChooseCompany"
        Me.btnChooseCompany.Size = New System.Drawing.Size(273, 53)
        Me.btnChooseCompany.TabIndex = 0
        Me.btnChooseCompany.Text = "Choose Company"
        Me.btnChooseCompany.UseVisualStyleBackColor = True
        '
        'GroupBoxMain
        '
        Me.GroupBoxMain.Controls.Add(Me.btnSalesOrder)
        Me.GroupBoxMain.Controls.Add(Me.Button2)
        Me.GroupBoxMain.Controls.Add(Me.btnItemMasterData)
        Me.GroupBoxMain.Location = New System.Drawing.Point(21, 82)
        Me.GroupBoxMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxMain.Name = "GroupBoxMain"
        Me.GroupBoxMain.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxMain.Size = New System.Drawing.Size(273, 345)
        Me.GroupBoxMain.TabIndex = 1
        Me.GroupBoxMain.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(0, 117)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(273, 58)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Business Partner Data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnItemMasterData
        '
        Me.btnItemMasterData.Location = New System.Drawing.Point(0, 22)
        Me.btnItemMasterData.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnItemMasterData.Name = "btnItemMasterData"
        Me.btnItemMasterData.Size = New System.Drawing.Size(273, 58)
        Me.btnItemMasterData.TabIndex = 0
        Me.btnItemMasterData.Text = "Item Master Data"
        Me.btnItemMasterData.UseVisualStyleBackColor = True
        '
        'btnSalesOrder
        '
        Me.btnSalesOrder.Location = New System.Drawing.Point(0, 224)
        Me.btnSalesOrder.Name = "btnSalesOrder"
        Me.btnSalesOrder.Size = New System.Drawing.Size(273, 57)
        Me.btnSalesOrder.TabIndex = 2
        Me.btnSalesOrder.Text = "Sales Order"
        Me.btnSalesOrder.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 427)
        Me.Controls.Add(Me.GroupBoxMain)
        Me.Controls.Add(Me.btnChooseCompany)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Main"
        Me.Text = "Main Menu"
        Me.GroupBoxMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnChooseCompany As System.Windows.Forms.Button
    Friend WithEvents GroupBoxMain As System.Windows.Forms.GroupBox
    Friend WithEvents btnItemMasterData As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnSalesOrder As System.Windows.Forms.Button

End Class
