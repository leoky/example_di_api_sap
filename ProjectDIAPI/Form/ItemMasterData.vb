Public Class ItemMasterData
    '// variabel
    Dim items As SAPbobsCOM.Items '// interface bawaan untuk database OITM
    Private mode As Integer

    Private Sub btnO_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click

        Try
            Select Case mode
                Case 1
                    getData()
                    '// add ke db
                    items.Add()
                    '// ketika done text field di bersihkan
                    '// refresh data untuk bisa diback data yg baru ditambahkan
                    clearAll()
                    refreshFromDb()
                Case 2
                    'recTemp.DoQuery("select ItemCode,ItemName from OITM where ItemCode ='" + TextBoxItemNo.Text +
                    '"' AND ItemName Like ('%" + TextBoxDescription.Text + "%')")

                    recTemp.DoQuery("SELECT T0.[ItemCode], T0.[ItemName], T1.[Price] FROM OITM T0  INNER JOIN ITM1 T1 ON T0.[ItemCode] = T1.[ItemCode] WHERE T0.[ItemCode] ='" + TextBoxItemNo.Text + "' AND  T0.[ItemName] Like ('%" + TextBoxDescription.Text + "%') ")
                    addData(recTemp)
                Case 3
                    '//ambil id nya dulu baru data data lainya 
                    items.GetByKey(TextBoxItemNo.Text)
                    getData()
                    '//dari di api sap utk update
                    items.Update()

                    updateMode(1)
                    refreshFromDb()
            End Select

            errorBox()

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub ItemMasterData_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '// initial 
        items = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oItems)
        rec = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        recTemp = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

        updateMode(1) '// first set utk ke mode add 


        refreshFromDb()

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

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        clearAll()
        Me.Close()
    End Sub

    'nama text di button terbalek
    'untuk next kita tammpilakn data dulu baru dinext
    'untuk previous kita eksekusi method previous dulu baru update data
    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click
        updatenextprevious()
        If rec.BoF = False Then
            rec.MovePrevious()
            addData(rec)
        End If
    End Sub

    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click
        updatenextprevious()
        If rec.EoF = False Then
            addData(rec)
            rec.MoveNext()
        End If
    End Sub

    'tiap update mode maka akan bersihakn semua field
    ' mode 0 = semua mode on
    ' mode 1 = mode add
    ' mode 2 = mode find
    ' mode 3 = mode update
    ' jika parameter kedua tidak diisi maka nilainya 
    Private Sub updateMode(mode As Integer, Optional clear As Boolean = True)

        If clear Then
            clearAll()
        End If

        Me.mode = mode
        btnAdd.Enabled = False
        btnFind.Enabled = False
        btnUpdate.Enabled = True

        '// ketida update mode maka akan ganti button namenya sesuai pilihan
        '// utk case mode find and add itu terbalik 
        '// ketika di mode find maka yg aktif itu mode add dan begitu juga sebaliknya
        Select Case mode
            Case 1
                btnOk.Text = "Add"
                btnFind.Enabled = True
                TextBoxPrice.Enabled = True
            Case 2
                btnOk.Text = "Find"
                btnAdd.Enabled = True
                TextBoxPrice.Enabled = False

            Case 3
                btnOk.Text = "Update"
                btnAdd.Enabled = True
                btnFind.Enabled = True
                btnUpdate.Enabled = False
                TextBoxPrice.Enabled = True
            Case Else
                btnOk.Text = "Ok"
                btnAdd.Enabled = True
                btnFind.Enabled = True
                TextBoxPrice.Enabled = True
        End Select
    End Sub

    Private Sub updatenextprevious()
        btnnext.enabled = Not rec.eof
        btnprevious.enabled = Not rec.bof
    End Sub

    '// bersihkan semua text field 
    Private Sub clearAll()
        TextBoxItemNo.Clear()
        TextBoxDescription.Clear()
        TextBoxPrice.Text = 0
    End Sub

    '// masukkan semua field data
    Private Sub addData(rec As SAPbobsCOM.Recordset)
        TextBoxItemNo.Text = rec.Fields.Item(0).Value
        TextBoxDescription.Text = rec.Fields.Item(1).Value
        TextBoxPrice.Text = rec.Fields.Item(2).Value
    End Sub

    Private Sub refreshFromDb()
        rec.DoQuery("select * from OITM order by ItemCode desc")
        'rec = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoBridge).GetItemList()
    End Sub

    Private Sub getData()
        items.ItemCode = TextBoxItemNo.Text
        items.ItemName = TextBoxDescription.Text
        items.PriceList.Price = TextBoxPrice.Text

    End Sub
End Class