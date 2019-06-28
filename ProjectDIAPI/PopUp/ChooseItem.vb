Public Class ChooseItem

    Public data As SAPbobsCOM.Items
    Dim oObj As SAPbobsCOM.SBObob

    Private Sub ChooseItem_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        data = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems)
        oObj = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge)

        data.Browser.Recordset = oObj.GetItemList()

        'gridview harus diclear jika tidak maka data yang dibuka tadi masih ada
        'jadi jika kita buka kembali data yang sama akan muncul namun berada dibawah data yang tadinya tidak diclear atau dapat dikatakan terganda/duplikasi
        btnChoose.Enabled = False
        DataGridView.Rows.Clear()

        'looping data untuk table cell (item code, item name, dan price list)
        Do Until data.Browser.EoF = True
            DataGridView.Rows.Add(1)
            DataGridView.Rows(DataGridView.RowCount - 1).Cells(0).Value = data.ItemCode
            DataGridView.Rows(DataGridView.RowCount - 1).Cells(1).Value = data.ItemName
            DataGridView.Rows(DataGridView.RowCount - 1).Cells(3).Value = data.PriceList.Price
            DataGridView.Update()
            data.Browser.MoveNext()
        Loop

    End Sub

    'Method untuk mengambil value dari cell yang di-click kedalam string dan disimpan divariable e
    Public Sub getData(e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim row = Me.DataGridView.Rows(e.RowIndex)
            data.ItemCode = row.Cells(0).Value.ToString
            data.ItemName = row.Cells(1).Value.ToString
            data.PriceList.Price = row.Cells(3).Value.ToString
        End If
    End Sub

    Private Sub btnNew_Click(sender As System.Object, e As System.EventArgs) Handles btnNew.Click
        ItemMasterData.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        data = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems)
        Me.Close()
    End Sub

    Private Sub DataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellClick
        getData(e)
        btnChoose.Enabled = True
    End Sub

    Private Sub DataGridView_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellDoubleClick
        getData(e)
        Me.Close()
    End Sub

    Private Sub btnChoose_Click(sender As System.Object, e As System.EventArgs) Handles btnChoose.Click
        Me.Close()
    End Sub
End Class