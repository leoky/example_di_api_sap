Module Db
    '//initialize object
    '// data ini digunakana untuk global
    '// SAPbobsCom.Company adalah company database utama di API DI 
    Public oCompany As SAPbobsCOM.Company
    Public rec, recTemp As SAPbobsCOM.Recordset
    Public sErrMsg As String
    Public lErrCode As Integer
    Public lRetCode As Integer

    Public Sub InitializeCompany()
        oCompany = New SAPbobsCOM.Company
        oCompany.language = SAPbobsCOM.BoSuppLangs.ln_English
    End Sub

    '// jika ada error maka akan show
    '// ini dipakai ketika saat sesudah action dieksekusi
    Public Sub errorBox()
        oCompany.GetLastError(lErrCode, sErrMsg)

        If lErrCode <> 0 Then
            MsgBox(sErrMsg)
        Else
            MsgBox("Action Success")
        End If
    End Sub
End Module
