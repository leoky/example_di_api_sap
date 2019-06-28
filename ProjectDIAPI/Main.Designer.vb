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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnSalesOrder = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnPurchaseOrder = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUDO = New System.Windows.Forms.Button()
        Me.btnUDT = New System.Windows.Forms.Button()
        Me.btnUDF = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnItemMasterData = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBoxMain = New System.Windows.Forms.GroupBox()
        Me.GroupBox4.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.GroupBoxMain.SuspendLayout
        Me.SuspendLayout
        '
        'btnChooseCompany
        '
        Me.btnChooseCompany.Location = New System.Drawing.Point(378, 26)
        Me.btnChooseCompany.Margin = New System.Windows.Forms.Padding(2)
        Me.btnChooseCompany.Name = "btnChooseCompany"
        Me.btnChooseCompany.Size = New System.Drawing.Size(105, 28)
        Me.btnChooseCompany.TabIndex = 0
        Me.btnChooseCompany.Text = "Choose Company"
        Me.btnChooseCompany.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnSalesOrder)
        Me.GroupBox4.Location = New System.Drawing.Point(197, 17)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(114, 105)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "A/R Sales"
        '
        'btnSalesOrder
        '
        Me.btnSalesOrder.Location = New System.Drawing.Point(18, 29)
        Me.btnSalesOrder.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSalesOrder.Name = "btnSalesOrder"
        Me.btnSalesOrder.Size = New System.Drawing.Size(83, 30)
        Me.btnSalesOrder.TabIndex = 2
        Me.btnSalesOrder.Text = "Sales Order"
        Me.btnSalesOrder.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnPurchaseOrder)
        Me.GroupBox3.Location = New System.Drawing.Point(318, 17)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(129, 104)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "A/P Purchases"
        '
        'btnPurchaseOrder
        '
        Me.btnPurchaseOrder.Location = New System.Drawing.Point(18, 29)
        Me.btnPurchaseOrder.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPurchaseOrder.Name = "btnPurchaseOrder"
        Me.btnPurchaseOrder.Size = New System.Drawing.Size(95, 30)
        Me.btnPurchaseOrder.TabIndex = 5
        Me.btnPurchaseOrder.Text = "Purchase Order"
        Me.btnPurchaseOrder.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUDO)
        Me.GroupBox2.Controls.Add(Me.btnUDT)
        Me.GroupBox2.Controls.Add(Me.btnUDF)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 138)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(422, 85)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Define"
        '
        'btnUDO
        '
        Me.btnUDO.Location = New System.Drawing.Point(282, 30)
        Me.btnUDO.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUDO.Name = "btnUDO"
        Me.btnUDO.Size = New System.Drawing.Size(132, 31)
        Me.btnUDO.TabIndex = 5
        Me.btnUDO.Text = "User Define Object"
        Me.btnUDO.UseVisualStyleBackColor = True
        '
        'btnUDT
        '
        Me.btnUDT.Location = New System.Drawing.Point(146, 30)
        Me.btnUDT.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUDT.Name = "btnUDT"
        Me.btnUDT.Size = New System.Drawing.Size(132, 32)
        Me.btnUDT.TabIndex = 4
        Me.btnUDT.Text = "User Define Table"
        Me.btnUDT.UseVisualStyleBackColor = True
        '
        'btnUDF
        '
        Me.btnUDF.Location = New System.Drawing.Point(10, 31)
        Me.btnUDF.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUDF.Name = "btnUDF"
        Me.btnUDF.Size = New System.Drawing.Size(132, 30)
        Me.btnUDF.TabIndex = 3
        Me.btnUDF.Text = "User Define Field"
        Me.btnUDF.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnItemMasterData)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(164, 104)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Master Data"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 63)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Business Partner Data"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnItemMasterData
        '
        Me.btnItemMasterData.Location = New System.Drawing.Point(21, 29)
        Me.btnItemMasterData.Margin = New System.Windows.Forms.Padding(2)
        Me.btnItemMasterData.Name = "btnItemMasterData"
        Me.btnItemMasterData.Size = New System.Drawing.Size(125, 30)
        Me.btnItemMasterData.TabIndex = 0
        Me.btnItemMasterData.Text = "Item Master Data"
        Me.btnItemMasterData.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Simplified SAP Business One"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Created on june 2019"
        '
        'GroupBoxMain
        '
        Me.GroupBoxMain.Controls.Add(Me.GroupBox1)
        Me.GroupBoxMain.Controls.Add(Me.GroupBox2)
        Me.GroupBoxMain.Controls.Add(Me.GroupBox4)
        Me.GroupBoxMain.Controls.Add(Me.GroupBox3)
        Me.GroupBoxMain.Location = New System.Drawing.Point(8, 59)
        Me.GroupBoxMain.Name = "GroupBoxMain"
        Me.GroupBoxMain.Size = New System.Drawing.Size(475, 233)
        Me.GroupBoxMain.TabIndex = 11
        Me.GroupBoxMain.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 340)
        Me.Controls.Add(Me.GroupBoxMain)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChooseCompany)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Main"
        Me.Text = "Main Menu"
        Me.GroupBox4.ResumeLayout(false)
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBoxMain.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnChooseCompany As System.Windows.Forms.Button
    Friend WithEvents btnItemMasterData As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnSalesOrder As System.Windows.Forms.Button
    Friend WithEvents btnUDF As System.Windows.Forms.Button
    Friend WithEvents btnUDT As System.Windows.Forms.Button
    Friend WithEvents btnPurchaseOrder As System.Windows.Forms.Button
    Friend WithEvents btnUDO As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxMain As System.Windows.Forms.GroupBox

End Class
