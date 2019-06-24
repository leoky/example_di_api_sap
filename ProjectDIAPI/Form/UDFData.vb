Public Class UDFData

    Private Sub AddUserField()
        Dim oUserFieldsMD As SAPbobsCOM.UserFieldsMD
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)

        If ComboBoxTable.SelectedIndex = 0 Then
            oUserFieldsMD.TableName = "ORDR"
        End If
        oUserFieldsMD.Name = TextBoxUDFName.Text
        oUserFieldsMD.Description = TextBoxUDFDescription.Text
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = TextBoxUDFEditSize.Text

        oUserFieldsMD.Add()

    End Sub

    Private Sub clearAll()
        TextBoxUDFName.Clear()
        TextBoxUDFDescription.Clear()
        TextBoxUDFEditSize.Clear()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            AddUserField()
            MsgBox("Berhasil di Add mas BRO")
            clearAll()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub UDFData_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class