Public Class SalesOrder

    'docTotal untuk variabel total transaksi
    'oOrder untuk menerima semua data sales order
    'oOrderTemp adalah object data yg digunakan utk mengambil data yg ada di field form
    Public oOrder, oOrderTemp As SAPbobsCOM.Documents
    Private mode As Integer
    Dim docTotal

    Private Sub SalesOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'awal ke mode add 
        'mengambil list sales order (ORDR) 
        rec = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        oOrder = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oOrders)
        oOrderTemp = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oOrders)

        updateMode(1)

        refreshFromDb()

        TextBoxDocNumber.Text = oOrder.DocNum + 1
        DateTimePickerDocDate.Value = Now
        DateTimePickerDocDueDate.Value = Now
        DateTimePickerTaxDate.Value = Now

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

    Private Sub getData()
        'utk mengambil data dimana untuk dieksekusi ke database
        ' ini ke db ORDR
        oOrderTemp.CardCode = TextBoxBPCode.Text
        oOrderTemp.CardName = TextBoxBPName.Text
        oOrderTemp.DocDate = DateTimePickerDocDate.Value
        oOrderTemp.DocDueDate = DateTimePickerDocDueDate.Value
        oOrderTemp.TaxDate = DateTimePickerTaxDate.Value
        'utk .lines ini utk ke database RDR1
        'dimana berisi tentang tiap transaksi dari sales order

        If mode = 1 Then
            For i As Integer = 0 To DataGridView.Rows.Count - 1
                If DataGridView.Rows(i).Cells(0).Value Then
                    oOrderTemp.Lines.ItemCode = DataGridView.Rows(i).Cells(0).Value
                    oOrderTemp.Lines.ItemDescription = DataGridView.Rows(i).Cells(1).Value
                    oOrderTemp.Lines.Quantity = DataGridView.Rows(i).Cells(2).Value
                    oOrderTemp.Lines.Price = DataGridView.Rows(i).Cells(3).Value
                    oOrderTemp.Lines.LineTotal = DataGridView.Rows(i).Cells(4).Value
                    oOrderTemp.Lines.Add()
                End If
            Next
        Else
            For i As Integer = 0 To DataGridView.Rows.Count - 1
                If DataGridView.Rows(i).Cells(0).Value Then

                    oOrderTemp.Lines.SetCurrentLine(i)
                    oOrderTemp.Lines.ItemCode = DataGridView.Rows(i).Cells(0).Value
                    oOrderTemp.Lines.ItemDescription = DataGridView.Rows(i).Cells(1).Value
                    oOrderTemp.Lines.Quantity = DataGridView.Rows(i).Cells(2).Value
                    oOrderTemp.Lines.Price = DataGridView.Rows(i).Cells(3).Value
                    oOrderTemp.Lines.LineTotal = DataGridView.Rows(i).Cells(4).Value
                    'If DataGridView.Rows.Count >= oOrderTemp.Lines.Count + 1 Then
                    '    oOrderTemp.Lines.Add()
                    'End If
                End If
            Next
            oOrderTemp.Lines.SetCurrentLine(0)
        End If

        oOrderTemp.DocTotal = TextBoxDocTotal.Text
    End Sub

    Private Sub updateMode(mode As Integer, Optional clear As Boolean = True)
        'update mode utk ganti kondisi di form ( find,add, update, nothing)
        ' 1 = add
        ' 2 = find
        ' 3 = update
        ' 0 = nothing 

        If clear Then
            clearAll()
        End If

        Me.mode = mode
        btnAdd.Enabled = False
        btnFind.Enabled = False
        btnUpdate.Enabled = True
        TextBoxDocNumber.Enabled = False
        ComboBoxCopyTo.Enabled = False

        '// ketida update mode maka akan ganti button namenya sesuai pilihan
        '// utk case mode find and add itu terbalik 
        '// ketika di mode find maka yg aktif itu mode add dan begitu juga sebaliknya
        Select Case mode
            Case 1
                BtnOK.Text = "Add"
                btnFind.Enabled = True
                TextBoxDocNumber.Enabled = False
            Case 2
                BtnOK.Text = "Find"
                btnAdd.Enabled = True
                TextBoxDocNumber.Enabled = True
                ComboBoxCopyTo.Enabled = True
            Case 3
                BtnOK.Text = "Update"
                btnAdd.Enabled = True
                btnFind.Enabled = True
                btnUpdate.Enabled = False
            Case Else
                BtnOK.Text = "Ok"
                btnAdd.Enabled = True
                btnFind.Enabled = True
                btnUpdate.Enabled = True
                ComboBoxCopyTo.Enabled = True
        End Select
    End Sub

    Private Sub refreshFromDb()
        'utk mendapatkan data yg terbaru
        rec.DoQuery("select * from ORDR order by DocEntry desc")
        oOrder.Browser.Recordset = rec
    End Sub

    Private Sub updatenextprevious()
        btnNext.Enabled = Not oOrder.Browser.EoF
        btnPrevious.Enabled = Not oOrder.Browser.BoF
    End Sub

    Private Sub addData(oOrder As SAPbobsCOM.Documents)

        'untuk mengisi field form dari data yg diambil dari database
        TextBoxDocNumber.Text = oOrder.DocNum
        TextBoxBPCode.Text = oOrder.CardCode
        TextBoxBPName.Text = oOrder.CardName
        TextBoxDocTotal.Text = oOrder.DocTotal
        TextBoxDocStatus.Text = oOrder.DocumentStatus

        DateTimePickerDocDate.Value = oOrder.DocDate
        DateTimePickerDocDueDate.Value = oOrder.DocDueDate
        DateTimePickerTaxDate.Value = oOrder.TaxDate
        DataGridView.Rows.Clear()

        ' .Lines.setcurrentline utk update urutan item order keberapa sehingga bisa mengambil semua order item 
        For i As Integer = 0 To oOrder.Lines.Count - 1
            DataGridView.Rows.Add(1)
            oOrder.Lines.SetCurrentLine(i)
            DataGridView.Rows(i).Cells(0).Value = oOrder.Lines.ItemCode
            DataGridView.Rows(i).Cells(1).Value = oOrder.Lines.ItemDescription
            DataGridView.Rows(i).Cells(2).Value = oOrder.Lines.Quantity
            DataGridView.Rows(i).Cells(3).Value = oOrder.Lines.Price
            DataGridView.Rows(i).Cells(4).Value = oOrder.Lines.LineTotal
            DataGridView.Rows(i).Cells(4).Value = oOrder.Lines.Quantity * oOrder.Lines.Price

        Next
        oOrder.Lines.SetCurrentLine(0)
    End Sub

    Private Sub calTotal()
        'utk rumus hitung semuanya
        docTotal = 0
        For i As Integer = 0 To DataGridView.Rows.Count - 1
            docTotal = docTotal + DataGridView.Rows(i).Cells(4).Value
        Next
    End Sub

    Private Sub btnFind_Click(sender As System.Object, e As System.EventArgs) Handles btnFind.Click
        updateMode(2)
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        updateMode(1)
        TextBoxDocNumber.Text = oOrder.DocNum + 1
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        updateMode(3, False)
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        clearAll()
        Me.Close()
    End Sub

    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
        updatenextprevious()
        If oOrder.Browser.BoF = False Then
            updateMode(0, False)
            oOrder.Browser.MovePrevious()
            addData(oOrder)
        End If
    End Sub



    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        updatenextprevious()
        If oOrder.Browser.EoF = False Then
            updateMode(0, False)
            oOrder.Browser.MoveNext()
            addData(oOrder)

        End If
    End Sub

    Private Sub cmdChoose_Click(sender As System.Object, e As System.EventArgs) Handles btnChooseCustomer.Click
        Dim cc As ChooseCustomer = New ChooseCustomer
        cc.ShowDialog()
        TextBoxBPCode.Text = cc.data.CardCode
        TextBoxBPName.Text = cc.data.CardName
    End Sub

    Private Sub BtnOK_Click(sender As System.Object, e As System.EventArgs) Handles BtnOK.Click

        Try
            Select Case mode
                Case 1
                    'hitung total harga
                    ' ambil data dari form
                    ' add ke db dengan api yg sudah disediakan
                    ' tampilkan err message jika ada
                    ' form ke default
                    ' mengambil ulang data sales order
                    ' set doc number keselanjutnya utk membantu mengetahui document number sekarang ketika waktu mau add 
                    calTotal()
                    getData()
                    oOrderTemp.Add()
                    errorBox()
                    clearAll()
                    refreshFromDb()
                    TextBoxDocNumber.Text = oOrder.DocNum + 1
                Case 2
                    'kita query berdasarkan doc number
                    oOrderTemp.GetByKey(TextBoxDocNumber.Text)
                    addData(oOrderTemp)
                    errorBox()
                Case 3
                    oOrder.GetByKey(TextBoxDocNumber.Text)
                    getData()
                    oOrderTemp.Update()
                    errorBox()
                    updateMode(0, False)
                    refreshFromDb()
                Case Else
                    Me.Close()
            End Select

        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub DataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellClick
        ' ini ketika cell in datagrid di klik
        ' utk cell pertama
        ' maka akan buka ke form chooseitem
        ' dan mengambil data dari form tersebut dengan nama varibel 'data'
        If e.RowIndex >= 0 Then

            Dim row = Me.DataGridView.Rows(e.RowIndex)

            If e.ColumnIndex = 0 Then
                Dim item As ChooseItem = New ChooseItem
                item.ShowDialog()
                row.Cells(0).Value = item.data.ItemCode
                row.Cells(1).Value = item.data.ItemName
                row.Cells(3).Value = item.data.PriceList.Price
            End If

        End If

    End Sub

    Private Sub DataGridView_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellValueChanged
        ' ketika nilai cell di datagridview berubah
        ' utk calculasi total di datagrid
        If e.RowIndex >= 0 Then
            Dim row = Me.DataGridView.Rows(e.RowIndex)
            'utk kali quantity dengan pricenya
            If row.Cells(2).Value >= 0 And row.Cells(3).Value >= 0 Then
                row.Cells(4).Value = row.Cells(2).Value * row.Cells(3).Value
            End If

            If row.Cells(4).Value Then
                calTotal()
                TextBoxDocTotal.Text = docTotal
            End If

        End If
    End Sub

    Private Sub ComboBoxCopyTo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxCopyTo.SelectedIndexChanged
        Select Case ComboBoxCopyTo.SelectedIndex
            ' 0 = invoice
            Case 0
                Dim ar As ARInvoice = New ARInvoice(oOrder)
                ar.ShowDialog()
        End Select
    End Sub
End Class