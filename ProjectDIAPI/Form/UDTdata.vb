Public Class UDTdata



    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        '//menekan button dan memanggil method tertentu
        Try
            addData()
            MsgBox("Telah TerAdd")
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub addData()
        '//memanggil DI API sap dan menginitialize 
        Dim oUsrTbl As SAPbobsCOM.UserTablesMD

        oUsrTbl = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserTables)
        oCompany.StartTransaction()

        oUsrTbl.TableName = TextBoxTableName.Text
        oUsrTbl.TableDescription = TextBoxTableDesc.Text
        oUsrTbl.Add()
    End Sub
End Class