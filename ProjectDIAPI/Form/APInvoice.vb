'ini ketika kita pilih 'copy form' di purchase order maka akan pindahkan data ke form APInvoice
'semua field sama dengan purchase order kecuali untuk field BaseEntry (oInvoice.Lines.BaseEntry)
' - dimana berisi document number dari purchase order 
Public Class APInvoice

    'ke db OPCH
    Dim oPurchaseInvoice As SAPbobsCOM.Documents
    Dim baseEntry As String

    ' Sub New adalah constructor dimana untuk menerima data purchase order 
    Public Sub New(oPurchaseInvoice As SAPbobsCOM.Documents, orderDocNum As Integer)
        InitializeComponent()
        Me.oPurchaseInvoice = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oPurchaseInvoices)
        Me.oPurchaseInvoice = oPurchaseInvoice
        baseEntry = orderDocNum
        LabelOrderNum.Text = baseEntry
    End Sub

    Private Sub refreshFromDB()
        rec.DoQuery("SELECT DocNum  FROM OPCH Order by DocNum DESC")
    End Sub

    'method untuk memasukkan data ke form
    Private Sub addData()
        TextBoxDocNumber.Text = rec.Fields.Item(0).Value.ToString + 1
        TextBoxBPCode.Text = oPurchaseInvoice.CardCode
        TextBoxBPName.Text = oPurchaseInvoice.CardName
        TextBoxDocStatus.Text = oPurchaseInvoice.EDocStatus
        DateTimePickerDocDate.Value = oPurchaseInvoice.DocDate
        DateTimePickerDocDueDate.Value = oPurchaseInvoice.DocDueDate
        DateTimePickerTaxDate.Value = oPurchaseInvoice.TaxDate

        For i As Integer = 0 To oPurchaseInvoice.Lines.Count - 1

            DataGridView.Rows.Add(1)
            oPurchaseInvoice.Lines.SetCurrentLine(i)
            DataGridView.Rows(i).Cells(0).Value = oPurchaseInvoice.Lines.ItemCode
            DataGridView.Rows(i).Cells(1).Value = oPurchaseInvoice.Lines.ItemDescription
            DataGridView.Rows(i).Cells(2).Value = oPurchaseInvoice.Lines.Quantity
            DataGridView.Rows(i).Cells(3).Value = oPurchaseInvoice.Lines.Price

        Next
    End Sub

    'method utk bersihakn textfield dan reset ke default
    Private Sub clearAll()
        TextBoxBPCode.Clear()
        TextBoxBPName.Clear()
        TextBoxDocNumber.Clear()

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
        'kita mengabil data dari form bukan dari data yg diterima order
        oPurchaseInvoice = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oPurchaseInvoices)
        oPurchaseInvoice.CardCode = TextBoxBPCode.Text
        'base entry = document number dari purchase order
        'base line = urutan item
        'base type = tipe order (sales, purchase , dll)
        For i As Integer = 0 To DataGridView.RowCount - 1
            If Not DataGridView.Rows(i).Cells(0).Value = "" Then
                oPurchaseInvoice.Lines.BaseEntry = baseEntry
                oPurchaseInvoice.Lines.BaseLine = i
                oPurchaseInvoice.Lines.BaseType = SAPbobsCOM.BoObjectTypes.oPurchaseOrders
                oPurchaseInvoice.Lines.ItemCode = DataGridView.Rows(i).Cells(0).Value
                oPurchaseInvoice.Lines.Quantity = DataGridView.Rows(i).Cells(2).Value
                oPurchaseInvoice.Lines.Add()
            End If
        Next
        lRetCode = oPurchaseInvoice.Add()

        oCompany.GetLastError(lErrCode, sErrMsg)
        If lRetCode <> 0 Then ' If the addition failed
            MsgBox(lErrCode & " " & sErrMsg) ' Display error message
        Else
            MsgBox("inv Added to DataBase", MsgBoxStyle.Information, "Order Added")
        End If
    End Sub
End Class