Public Class UDTdata

    Private Sub UDTdata_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        



        

    End Sub

    Private Sub btnOK_Click(sender As System.Object, e As System.EventArgs) Handles btnOK.Click
        Try
            addData()
            MsgBox("Telah TerAdd")
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub addData()
        Dim oUsrTbl As SAPbobsCOM.UserTablesMD

        oUsrTbl = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserTables)
        oCompany.StartTransaction()

        oUsrTbl.TableName = TextBoxTableName.Text
        oUsrTbl.TableDescription = TextBoxTableDesc.Text
        oUsrTbl.Add()
    End Sub
End Class