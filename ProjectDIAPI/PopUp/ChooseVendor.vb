Public Class ChooseVendor

    Dim oObj As SAPbobsCOM.SBObob
    Public data As SAPbobsCOM.BusinessPartners

    Private Sub ChooseVendor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        oObj = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge)
        Data = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
        rec = oObj.GetBPList(SAPbobsCOM.BoCardTypes.cSupplier)

        'gridview harus diclear jika tidak maka data yang dibuka tadi masih ada
        'jadi jika kita buka kembali data yang sama akan muncul namun berada dibawah data yang tadinya tidak diclear atau dapat dikatakan terganda/duplikasi
        btnChoose.Enabled = False
        DataGridViewListCustomer.Rows.Clear()

        'looping data untuk table cell (item code, item name, dan price list)
        Do Until rec.EoF = True
            DataGridViewListCustomer.Rows.Add(1)
            DataGridViewListCustomer.Rows(DataGridViewListCustomer.RowCount - 1).Cells(0).Value = rec.Fields.Item(0).Value
            DataGridViewListCustomer.Rows(DataGridViewListCustomer.RowCount - 1).Cells(1).Value = rec.Fields.Item(1).Value
            DataGridViewListCustomer.Update()
            rec.MoveNext()
        Loop
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        BPMasterData.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        data = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
        Me.Close()
    End Sub

    Private Sub btnChoose_Click(sender As System.Object, e As System.EventArgs) Handles btnChoose.Click
        Me.Close()
    End Sub

    Private Sub DataGridViewListCustomer_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewListCustomer.CellClick
        getData(e)
        btnChoose.Enabled = True
    End Sub

    Private Sub DataGridViewListCustomer_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewListCustomer.CellDoubleClick
        getData(e)
        Me.Close()
    End Sub

    'Method untuk mengambil data dari cell yang di-click kedalam string dan disimpan pada variabel e
    Public Sub getData(e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim row = Me.DataGridViewListCustomer.Rows(e.RowIndex)
            data.CardCode = row.Cells(0).Value.ToString
            data.CardName = row.Cells(1).Value.ToString
        End If
    End Sub
End Class