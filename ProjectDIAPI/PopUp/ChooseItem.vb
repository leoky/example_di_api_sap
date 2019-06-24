Public Class ChooseItem

    Public data As SAPbobsCOM.Items
    Dim oObj As SAPbobsCOM.SBObob

    Private Sub ChooseItem_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        data = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems)
        oObj = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge)
        rec = oObj.GetItemList()

        btnChoose.Enabled = False
        DataGridView.Rows.Clear()

        Do Until rec.EoF = True
            DataGridView.Rows.Add(1)
            DataGridView.Rows(DataGridView.RowCount - 1).Cells(0).Value = rec.Fields.Item(0).Value
            DataGridView.Rows(DataGridView.RowCount - 1).Cells(1).Value = rec.Fields.Item(1).Value
            DataGridView.Update()
            rec.MoveNext()
        Loop
    End Sub

    Public Sub getData(e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim row = Me.DataGridView.Rows(e.RowIndex)
            data.ItemCode = row.Cells(0).Value.ToString
            data.ItemName = row.Cells(1).Value.ToString
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

    Private Sub DataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellContentClick

    End Sub
End Class