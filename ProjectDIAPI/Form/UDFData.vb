Public Class UDFData

    Private Sub AddUserField()
        '//SAP DI API untuk memakai User field Master Data
        Dim oUserFieldsMD As SAPbobsCOM.UserFieldsMD
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)
        '//memilih table sales order(ORDR) atau purchase order(OPOR)
        If ComboBoxTable.SelectedIndex = 0 Then
            oUserFieldsMD.TableName = "ORDR"
        ElseIf ComboBoxTable.SelectedIndex = 1 Then
            oUserFieldsMD.TableName = "OPOR"
        End If

        oUserFieldsMD.Name = TextBoxUDFName.Text
        oUserFieldsMD.Description = TextBoxUDFDescription.Text
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 20
        '//Input ke DAtabase
        oUserFieldsMD.Add()

    End Sub

    Private Sub clearAll()
        '//Menghapuskan field 
        TextBoxUDFName.Clear()
        TextBoxUDFDescription.Clear()


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        '//Menekan dan memanggil method tertentu
        Try
            AddUserField()
            MsgBox("Successfully Added")
            clearAll()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub UDFData_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class