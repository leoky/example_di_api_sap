Public Class APInvoice

    'ke db OINV
    Dim oInvoice As SAPbobsCOM.Documents

    Public Sub New(oInvoice As SAPbobsCOM.Documents)
        InitializeComponent()
        Me.oInvoice = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oPurchaseInvoices)
        Me.oInvoice = oInvoice
    End Sub

    Private Sub addData()
        TextBoxDocNumber.Text = oInvoice.DocNum '//////
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
        addData()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        clearAll()
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(sender As System.Object, e As System.EventArgs) Handles BtnOK.Click
        oInvoice = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oPurchaseInvoices)
        oInvoice.CardCode = TextBoxBPCode.Text

        Dim sNewObjCode As String

        ' Get last added document number (the order that was added)
        oCompany.GetNewObjectCode(sNewObjCode)

        For i As Integer = 0 To oInvoice.Lines.Count - 1

            oInvoice.Lines.SetCurrentLine(0)
            oInvoice.Lines.BaseEntry = TextBoxDocNumber.Text
            oInvoice.Lines.BaseLine = i
            oInvoice.Lines.BaseType = SAPbobsCOM.BoObjectTypes.oPurchaseOrders
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