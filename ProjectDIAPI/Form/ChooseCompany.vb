Public Class ChooseCompany
    '//coba aja
    '//object variabel
    Private oRecordSet As SAPbobsCOM.Recordset

    '// ketika class ini dieksekusi untuk pertama kali
    Private Sub ChooseCompany_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        '// set value combobox di posisi ke 6 (optional)
        ComboBoxDbType.SelectedIndex = 6

        '// Jika belum connect maka login untuk company di hide
        GroupBoxLoginCompany.Visible = oCompany.Connected

        '//dihapus
        data()

    End Sub

    Private Sub btnConnectDb_Click(sender As System.Object, e As System.EventArgs) Handles btnConnectDb.Click
        '// data yg harus diisi 
        oCompany.DbServerType = ComboBoxDbType.SelectedIndex + 1
        oCompany.UseTrusted = False
        oCompany.Server = TextBoxServerName.Text
        oCompany.DbUserName = TextBoxUsernameDb.Text
        oCompany.DbPassword = TextBoxPasswordDb.Text

        Try
            '//setelah data db di set 
            '//kita terima semua company list sebagai object RecodSet
            oRecordSet = oCompany.GetCompanyList

            '// digunakan setelah fungsi
            '// ini hanya method jadi tidak mengembalikan hasil
            '// digunakan untuk menangkap error code atau message dari fungsi yg dieksekusi sebelumnya
            oCompany.GetLastError(lErrCode, sErrMsg)

            If lErrCode <> 0 Then
                MsgBox(sErrMsg)
            Else
                If oCompany.Connected = False Then
                    ComboBoxDbCompany.Items.Clear()
                    Do Until oRecordSet.EoF = True
                        '// add data ke list combo box
                        '// datanya diambil data column pertama dari hasil 
                        ComboBoxDbCompany.Items.Add(oRecordSet.Fields.Item(0).Value)
                        '// row selanjutnya
                        oRecordSet.MoveNext()
                    Loop

                    '//show Groupbox
                    GroupBoxLoginCompany.Show()
                End If
            End If

            If oCompany.Connected = True Then
                GroupBoxLoginCompany.Show()
                ComboBoxDbCompany.SelectedText = oCompany.CompanyDB
                TextBoxUsernameCompany.Text = oCompany.UserName
                TextBoxPasswordCompany.Text = oCompany.Password
                Me.Text = Me.Text + ":Connected"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            InitializeCompany()
        End Try
    End Sub

    Private Sub btnConnectCompany_Click(sender As System.Object, e As System.EventArgs) Handles btnConnectCompany.Click
        oCompany.CompanyDB = ComboBoxDbCompany.Text
        oCompany.UserName = TextBoxUsernameCompany.Text
        oCompany.Password = TextBoxPasswordCompany.Text

        ''//connect to company db
        lRetCode = oCompany.Connect

        If lRetCode <> 0 Then
            oCompany.GetLastError(lErrCode, sErrMsg)
            MsgBox(sErrMsg)
        Else
            MsgBox("Connected To " + oCompany.CompanyName)
            ''//update form title
            Me.Text = Me.Text + "(Connected)"
            Me.Close()
        End If
    End Sub

    Private Sub data()
        TextBoxUsernameDb.Text = "sa"
        TextBoxPasswordDb.Text = "sa"
        TextBoxServerName.Text = "DESKTOP-2FI5D08"
        TextBoxUsernameCompany.Text = "manager"
        TextBoxPasswordCompany.Text = "1234"
    End Sub

    Private Sub TextBoxServerName_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxServerName.TextChanged

    End Sub

    Private Sub TextBoxPasswordCompany_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBoxPasswordCompany.TextChanged

    End Sub

    Private Sub ComboBoxDbType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxDbType.SelectedIndexChanged

    End Sub
End Class