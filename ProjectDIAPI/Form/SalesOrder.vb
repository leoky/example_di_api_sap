Public Class SalesOrder

    Dim so As SAPbobsCOM.Documents
    Private mode As Integer

    Private Sub SalesOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        so = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oOrders)
        rec = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        recTemp = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

        DateTimePickerDocDate.Value = Now
        DateTimePickerDocDueDate.Value = Now
        DateTimePickerTaxDate.Value = Now

        updateMode(1)

        refreshFromDb()
    End Sub

    Private Sub clearAll()
        TextBoxBPCode.Clear()
        TextBoxBPName.Clear()

        DateTimePickerDocDate.Value = Now
        DateTimePickerDocDueDate.Value = Now
        DateTimePickerTaxDate.Value = Now

        DataGridView.Rows.Clear()
    End Sub

    Private Sub updateMode(mode As Integer, Optional clear As Boolean = True)

        If clear Then
            clearAll()
        End If

        Me.mode = mode
        btnAdd.Enabled = False
        btnFind.Enabled = False
        btnUpdate.Enabled = True
        TextBoxDocNumber.Enabled = False

        '// ketida update mode maka akan ganti button namenya sesuai pilihan
        '// utk case mode find and add itu terbalik 
        '// ketika di mode find maka yg aktif itu mode add dan begitu juga sebaliknya
        Select Case mode
            Case 1
                BtnOK.Text = "Add"
                btnFind.Enabled = True
                TextBoxDocNumber.Enabled = False
            Case 2
                btnOk.Text = "Find"
                btnAdd.Enabled = True
                TextBoxDocNumber.Enabled = True
            Case 3
                btnOk.Text = "Update"
                btnAdd.Enabled = True
                btnFind.Enabled = True
                btnUpdate.Enabled = False
            Case Else
                BtnOK.Text = "Ok"
                btnAdd.Enabled = True
                btnFind.Enabled = True
        End Select
    End Sub

    Private Sub refreshFromDb()
        rec.DoQuery("select * from ORDR order by DocEntry desc")
    End Sub

    Private Sub updatenextprevious()
        Button4.Enabled = Not rec.EoF
        Button1.Enabled = Not rec.BoF
    End Sub

    Private Sub addData(rec As SAPbobsCOM.Recordset)
        TextBoxDocNumber.Text = rec.Fields.Item(0).Value
        TextBoxBPCode.Text = rec.Fields.Item(1).Value
        TextBoxBPName.Text = rec.Fields.Item(2).Value

        DateTimePickerDocDate.Value = rec.Fields.Item(3).Value
        DateTimePickerDocDate.Value = rec.Fields.Item(3).Value
        DateTimePickerDocDueDate.Value = rec.Fields.Item(3).Value


    End Sub

    Private Sub btnFind_Click(sender As System.Object, e As System.EventArgs) Handles btnFind.Click
        updateMode(2)
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        updateMode(1)
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        updateMode(3, False)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        clearAll()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        updatenextprevious()
        If rec.BoF = False Then
            rec.MovePrevious()
            addData(rec)
        End If
    End Sub



    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        updatenextprevious()
        If rec.EoF = False Then
            addData(rec)
            rec.MoveNext()
        End If
    End Sub

    Private Sub cmdChoose_Click(sender As System.Object, e As System.EventArgs) Handles btnChooseCustomer.Click
        Dim cc As ChooseCustomer = New ChooseCustomer
        cc.ShowDialog()
        TextBoxBPCode.Text = cc.data.CardCode
        TextBoxBPName.Text = cc.data.CardName
    End Sub

    Private Sub BtnOK_Click(sender As System.Object, e As System.EventArgs) Handles BtnOK.Click
        Dim oOrder As SAPbobsCOM.Documents = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oOrders)

        Try
            oOrder.CardCode = TextBoxBPCode.Text
            oOrder.CardName = TextBoxBPName.Text
            oOrder.DocTotal = 0
            oOrder.DocDate = DateTimePickerDocDate.Value
            oOrder.DocDueDate = DateTimePickerDocDueDate.Value

            For i As Integer = 0 To DataGridView.Rows.Count - 1
                If DataGridView.Rows(i).Cells(0).Value Then
                    oOrder.Lines.ItemCode = DataGridView.Rows(i).Cells(0).Value
                    oOrder.Lines.ItemDescription = DataGridView.Rows(i).Cells(1).Value
                    oOrder.Lines.Quantity = DataGridView.Rows(i).Cells(2).Value
                    oOrder.Lines.Price = DataGridView.Rows(i).Cells(3).Value
                    oOrder.Lines.LineTotal = DataGridView.Rows(i).Cells(4).Value
                    oOrder.DocTotal = oOrder.DocTotal + DataGridView.Rows(i).Cells(4).Value
                    oOrder.Lines.Add()
                End If
            Next
            oOrder.Add()
            errorBox()
            clearAll()
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub DataGridView_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellClick
        If e.RowIndex >= 0 Then

            Dim row = Me.DataGridView.Rows(e.RowIndex)

            If e.ColumnIndex = 0 Then
                Dim item As ChooseItem = New ChooseItem
                item.ShowDialog()
                row.Cells(0).Value = item.data.ItemCode
                row.Cells(1).Value = item.data.ItemName
            End If

        End If

    End Sub

    Private Sub DataGridView_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellValueChanged
        If e.RowIndex >= 0 Then
            Dim row = Me.DataGridView.Rows(e.RowIndex)

            If row.Cells(2).Value >= 0 And row.Cells(3).Value >= 0 Then
                row.Cells(4).Value = row.Cells(2).Value * row.Cells(3).Value
            End If

        End If
    End Sub
End Class