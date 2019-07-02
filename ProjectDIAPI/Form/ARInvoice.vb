'ini ketika kita pilih 'copy form' di sales order maka akan pindahkan data ke form ARInvoice
'semua field sama dengan sales order kecuali untuk field BaseEntry (oInvoice.Lines.BaseEntry)
' - dimana berisi document number dari sales order 

Public Class ARInvoice
    'ke db OINV
    Dim oInvoice As SAPbobsCOM.Documents
    Dim baseEntry As String

    ' Sub New adalah constructor dimana untuk menerima data sales order 
    Public Sub New(oInvoice As SAPbobsCOM.Documents)
        InitializeComponent()
        Me.oInvoice = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInvoices)
        Me.oInvoice = oInvoice
        baseEntry = oInvoice.DocNum
    End Sub

    Private Sub refreshFromDB()
        rec.DoQuery("SELECT DocNum  FROM OINV Order by DocNum DESC")
    End Sub

    'method untuk memasukkan data ke form
    Private Sub addData()
        TextBoxDocNumber.Text = rec.Fields.Item(0).Value.ToString + 1
        TextBoxBPCode.Text = oInvoice.CardCode
        TextBoxBPName.Text = oInvoice.CardName
        TextBoxDocTotal.Text = oInvoice.DocTotal
        TextBoxDocStatus.Text = oInvoice.EDocStatus
        DateTimePickerDocDate.Value = oInvoice.DocDate
        DateTimePickerDocDueDate.Value = oInvoice.DocDueDate
        DateTimePickerTaxDate.Value = oInvoice.TaxDate

        For i As Integer = 0 To oInvoice.Lines.Count - 1

            DataGridView.Rows.Add(1)
            oInvoice.Lines.SetCurrentLine(i)
            DataGridView.Rows(i).Cells(0).Value = oInvoice.Lines.ItemCode
            DataGridView.Rows(i).Cells(1).Value = oInvoice.Lines.ItemDescription
            DataGridView.Rows(i).Cells(2).Value = oInvoice.Lines.Quantity
            DataGridView.Rows(i).Cells(3).Value = oInvoice.Lines.Price
            DataGridView.Rows(i).Cells(4).Value = oInvoice.Lines.LineTotal
            DataGridView.Rows(i).Cells(4).Value = oInvoice.Lines.Quantity * oInvoice.Lines.Price

        Next
    End Sub

    'method utk bersihakn textfield dan reset ke default
    Private Sub clearAll()
        TextBoxBPCode.Clear()
        TextBoxBPName.Clear()
        TextBoxDocNumber.Clear()
        TextBoxDocTotal.Clear()

        DateTimePickerDocDate.Value = Now
        DateTimePickerDocDueDate.Value = Now
        DateTimePickerTaxDate.Value = Now

        DataGridView.Rows.Clear()
    End Sub

    Private Sub ARInvoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        rec = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        refreshFromDB()
        addData()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        clearAll()
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(sender As System.Object, e As System.EventArgs) Handles BtnOK.Click
        oInvoice = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oInvoices)
        oInvoice.CardCode = TextBoxBPCode.Text

        For i As Integer = 0 To oInvoice.Lines.Count - 1

            oInvoice.Lines.SetCurrentLine(0)
            oInvoice.Lines.BaseEntry = baseEntry
            oInvoice.Lines.BaseLine = i
            oInvoice.Lines.BaseType = SAPbobsCOM.BoObjectTypes.oOrders
        Next

        lRetCode = oInvoice.Add()
        oCompany.GetLastError(lErrCode, sErrMsg)
        If lRetCode <> 0 Then ' If the addition failed
            MsgBox(lErrCode & " " & sErrMsg) ' Display error message
        Else
            MsgBox("inv Added to DataBase", MsgBoxStyle.Information, "Order Added")
        End If
    End Sub
End Class