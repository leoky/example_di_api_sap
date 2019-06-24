<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseCompany
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
        Me.LabelDbType = New System.Windows.Forms.Label()
        Me.ComboBoxDbType = New System.Windows.Forms.ComboBox()
        Me.LabelServer = New System.Windows.Forms.Label()
        Me.TextBoxServerName = New System.Windows.Forms.TextBox()
        Me.LabelUsernameDb = New System.Windows.Forms.Label()
        Me.LabelPasswordDb = New System.Windows.Forms.Label()
        Me.TextBoxUsernameDb = New System.Windows.Forms.TextBox()
        Me.TextBoxPasswordDb = New System.Windows.Forms.TextBox()
        Me.btnConnectDb = New System.Windows.Forms.Button()
        Me.GroupBoxLoginCompany = New System.Windows.Forms.GroupBox()
        Me.btnConnectCompany = New System.Windows.Forms.Button()
        Me.TextBoxPasswordCompany = New System.Windows.Forms.TextBox()
        Me.TextBoxUsernameCompany = New System.Windows.Forms.TextBox()
        Me.ComboBoxDbCompany = New System.Windows.Forms.ComboBox()
        Me.LabelPasswordCompany = New System.Windows.Forms.Label()
        Me.LabelUsernameCompany = New System.Windows.Forms.Label()
        Me.LabelDbCompany = New System.Windows.Forms.Label()
        Me.GroupBoxLoginCompany.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelDbType
        '
        Me.LabelDbType.AutoSize = True
        Me.LabelDbType.Location = New System.Drawing.Point(10, 11)
        Me.LabelDbType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDbType.Name = "LabelDbType"
        Me.LabelDbType.Size = New System.Drawing.Size(49, 13)
        Me.LabelDbType.TabIndex = 0
        Me.LabelDbType.Text = "DB Type"
        '
        'ComboBoxDbType
        '
        Me.ComboBoxDbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDbType.Items.AddRange(New Object() {"MSSQL", "DB_2", "SYBASE", "MSSQL2005", "MAXDB", "MSSQL2008", "MSSQL2012"})
        Me.ComboBoxDbType.Location = New System.Drawing.Point(125, 11)
        Me.ComboBoxDbType.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxDbType.Name = "ComboBoxDbType"
        Me.ComboBoxDbType.Size = New System.Drawing.Size(134, 21)
        Me.ComboBoxDbType.TabIndex = 6
        '
        'LabelServer
        '
        Me.LabelServer.AutoSize = True
        Me.LabelServer.Location = New System.Drawing.Point(10, 47)
        Me.LabelServer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelServer.Name = "LabelServer"
        Me.LabelServer.Size = New System.Drawing.Size(69, 13)
        Me.LabelServer.TabIndex = 2
        Me.LabelServer.Text = "Server Name"
        '
        'TextBoxServerName
        '
        Me.TextBoxServerName.Location = New System.Drawing.Point(125, 47)
        Me.TextBoxServerName.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxServerName.Name = "TextBoxServerName"
        Me.TextBoxServerName.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxServerName.TabIndex = 3
        '
        'LabelUsernameDb
        '
        Me.LabelUsernameDb.AutoSize = True
        Me.LabelUsernameDb.Location = New System.Drawing.Point(10, 84)
        Me.LabelUsernameDb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelUsernameDb.Name = "LabelUsernameDb"
        Me.LabelUsernameDb.Size = New System.Drawing.Size(73, 13)
        Me.LabelUsernameDb.TabIndex = 4
        Me.LabelUsernameDb.Text = "Username DB"
        '
        'LabelPasswordDb
        '
        Me.LabelPasswordDb.AutoSize = True
        Me.LabelPasswordDb.Location = New System.Drawing.Point(10, 115)
        Me.LabelPasswordDb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPasswordDb.Name = "LabelPasswordDb"
        Me.LabelPasswordDb.Size = New System.Drawing.Size(71, 13)
        Me.LabelPasswordDb.TabIndex = 5
        Me.LabelPasswordDb.Text = "Password DB"
        '
        'TextBoxUsernameDb
        '
        Me.TextBoxUsernameDb.Location = New System.Drawing.Point(125, 84)
        Me.TextBoxUsernameDb.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxUsernameDb.Name = "TextBoxUsernameDb"
        Me.TextBoxUsernameDb.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxUsernameDb.TabIndex = 6
        '
        'TextBoxPasswordDb
        '
        Me.TextBoxPasswordDb.Location = New System.Drawing.Point(125, 115)
        Me.TextBoxPasswordDb.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxPasswordDb.Name = "TextBoxPasswordDb"
        Me.TextBoxPasswordDb.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxPasswordDb.TabIndex = 7
        Me.TextBoxPasswordDb.UseSystemPasswordChar = True
        '
        'btnConnectDb
        '
        Me.btnConnectDb.Location = New System.Drawing.Point(12, 156)
        Me.btnConnectDb.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConnectDb.Name = "btnConnectDb"
        Me.btnConnectDb.Size = New System.Drawing.Size(247, 28)
        Me.btnConnectDb.TabIndex = 8
        Me.btnConnectDb.Text = "Connect DB"
        Me.btnConnectDb.UseVisualStyleBackColor = True
        '
        'GroupBoxLoginCompany
        '
        Me.GroupBoxLoginCompany.Controls.Add(Me.btnConnectCompany)
        Me.GroupBoxLoginCompany.Controls.Add(Me.TextBoxPasswordCompany)
        Me.GroupBoxLoginCompany.Controls.Add(Me.TextBoxUsernameCompany)
        Me.GroupBoxLoginCompany.Controls.Add(Me.ComboBoxDbCompany)
        Me.GroupBoxLoginCompany.Controls.Add(Me.LabelPasswordCompany)
        Me.GroupBoxLoginCompany.Controls.Add(Me.LabelUsernameCompany)
        Me.GroupBoxLoginCompany.Controls.Add(Me.LabelDbCompany)
        Me.GroupBoxLoginCompany.Location = New System.Drawing.Point(12, 209)
        Me.GroupBoxLoginCompany.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxLoginCompany.Name = "GroupBoxLoginCompany"
        Me.GroupBoxLoginCompany.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxLoginCompany.Size = New System.Drawing.Size(247, 249)
        Me.GroupBoxLoginCompany.TabIndex = 9
        Me.GroupBoxLoginCompany.TabStop = False
        Me.GroupBoxLoginCompany.Text = "Application Login"
        '
        'btnConnectCompany
        '
        Me.btnConnectCompany.Location = New System.Drawing.Point(1, 141)
        Me.btnConnectCompany.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConnectCompany.Name = "btnConnectCompany"
        Me.btnConnectCompany.Size = New System.Drawing.Size(246, 37)
        Me.btnConnectCompany.TabIndex = 6
        Me.btnConnectCompany.Text = "Login"
        Me.btnConnectCompany.UseVisualStyleBackColor = True
        '
        'TextBoxPasswordCompany
        '
        Me.TextBoxPasswordCompany.Location = New System.Drawing.Point(113, 93)
        Me.TextBoxPasswordCompany.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxPasswordCompany.Name = "TextBoxPasswordCompany"
        Me.TextBoxPasswordCompany.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxPasswordCompany.TabIndex = 5
        Me.TextBoxPasswordCompany.UseSystemPasswordChar = True
        '
        'TextBoxUsernameCompany
        '
        Me.TextBoxUsernameCompany.Location = New System.Drawing.Point(113, 58)
        Me.TextBoxUsernameCompany.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxUsernameCompany.Name = "TextBoxUsernameCompany"
        Me.TextBoxUsernameCompany.Size = New System.Drawing.Size(134, 20)
        Me.TextBoxUsernameCompany.TabIndex = 4
        '
        'ComboBoxDbCompany
        '
        Me.ComboBoxDbCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDbCompany.FormattingEnabled = True
        Me.ComboBoxDbCompany.Location = New System.Drawing.Point(113, 25)
        Me.ComboBoxDbCompany.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBoxDbCompany.Name = "ComboBoxDbCompany"
        Me.ComboBoxDbCompany.Size = New System.Drawing.Size(134, 21)
        Me.ComboBoxDbCompany.TabIndex = 3
        '
        'LabelPasswordCompany
        '
        Me.LabelPasswordCompany.AutoSize = True
        Me.LabelPasswordCompany.Location = New System.Drawing.Point(8, 93)
        Me.LabelPasswordCompany.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelPasswordCompany.Name = "LabelPasswordCompany"
        Me.LabelPasswordCompany.Size = New System.Drawing.Size(53, 13)
        Me.LabelPasswordCompany.TabIndex = 2
        Me.LabelPasswordCompany.Text = "Password"
        '
        'LabelUsernameCompany
        '
        Me.LabelUsernameCompany.AutoSize = True
        Me.LabelUsernameCompany.Location = New System.Drawing.Point(8, 58)
        Me.LabelUsernameCompany.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelUsernameCompany.Name = "LabelUsernameCompany"
        Me.LabelUsernameCompany.Size = New System.Drawing.Size(55, 13)
        Me.LabelUsernameCompany.TabIndex = 1
        Me.LabelUsernameCompany.Text = "Username"
        '
        'LabelDbCompany
        '
        Me.LabelDbCompany.AutoSize = True
        Me.LabelDbCompany.Location = New System.Drawing.Point(5, 25)
        Me.LabelDbCompany.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDbCompany.Name = "LabelDbCompany"
        Me.LabelDbCompany.Size = New System.Drawing.Size(69, 13)
        Me.LabelDbCompany.TabIndex = 0
        Me.LabelDbCompany.Text = "Company DB"
        '
        'ChooseCompany
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 488)
        Me.Controls.Add(Me.GroupBoxLoginCompany)
        Me.Controls.Add(Me.btnConnectDb)
        Me.Controls.Add(Me.TextBoxPasswordDb)
        Me.Controls.Add(Me.TextBoxUsernameDb)
        Me.Controls.Add(Me.LabelPasswordDb)
        Me.Controls.Add(Me.LabelUsernameDb)
        Me.Controls.Add(Me.TextBoxServerName)
        Me.Controls.Add(Me.LabelServer)
        Me.Controls.Add(Me.ComboBoxDbType)
        Me.Controls.Add(Me.LabelDbType)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ChooseCompany"
        Me.Text = "Choose Company Form"
        Me.GroupBoxLoginCompany.ResumeLayout(False)
        Me.GroupBoxLoginCompany.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelDbType As System.Windows.Forms.Label
    Public WithEvents ComboBoxDbType As System.Windows.Forms.ComboBox
    Friend WithEvents LabelServer As System.Windows.Forms.Label
    Friend WithEvents TextBoxServerName As System.Windows.Forms.TextBox
    Friend WithEvents LabelUsernameDb As System.Windows.Forms.Label
    Friend WithEvents LabelPasswordDb As System.Windows.Forms.Label
    Friend WithEvents TextBoxUsernameDb As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPasswordDb As System.Windows.Forms.TextBox
    Friend WithEvents btnConnectDb As System.Windows.Forms.Button
    Friend WithEvents GroupBoxLoginCompany As System.Windows.Forms.GroupBox
    Friend WithEvents LabelPasswordCompany As System.Windows.Forms.Label
    Friend WithEvents LabelUsernameCompany As System.Windows.Forms.Label
    Friend WithEvents LabelDbCompany As System.Windows.Forms.Label
    Friend WithEvents btnConnectCompany As System.Windows.Forms.Button
    Friend WithEvents TextBoxPasswordCompany As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUsernameCompany As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxDbCompany As System.Windows.Forms.ComboBox
End Class
