Public Class BPMasterData

    Dim BP As SAPbobsCOM.BusinessPartners
    Private mode As Integer

    Private Sub btnOKBP_Click(sender As System.Object, e As System.EventArgs) Handles btnOKBP.Click
        Try
            Select Case mode
                Case 1
                    getData()
                    BP.Add()
                    clearAll()
                    refreshFromDb()
                Case 2
                    recTemp.DoQuery("SELECT CardCode, CardName, CardType,  Phone1, Phone2  FROM OCRD WHERE CardCode = '" + TextBoxBPCode.Text + "' AND CardName Like ('%" + TextBoxBPName.Text + "%')")
                    addData(recTemp)
                Case 3
                    BP.GetByKey(TextBoxBPCode.Text)
                    getData()

                    BP.Update()

                    updateMode(1)
                    refreshFromDb()
            End Select

            errorBox()

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub BPMasterData_Load(Sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        BP = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oBusinessPartners)
        rec = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)
        recTemp = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset)

        updateMode(1)

        refreshFromDb()


    End Sub

    Private Sub getData()
        BP.CardCode = TextBoxBPCode.Text
        BP.CardName = TextBoxBPName.Text
        BP.Phone1 = TextBoxBPPhone1.Text
        BP.Phone2 = TextBoxBPPhone2.Text
        BP.CardType = ComboBoxBPType.SelectedIndex
    End Sub

    Private Sub addData(rec As SAPbobsCOM.Recordset)

        TextBoxBPCode.Text = rec.Fields.Item(0).Value
        TextBoxBPName.Text = rec.Fields.Item(1).Value
        If rec.Fields.Item(2).Value.ToString = "C" Then
            ComboBoxBPType.SelectedIndex = 0
        ElseIf rec.Fields.Item(2).Value.ToString = "S" Then
            ComboBoxBPType.SelectedIndex = 1
        Else
            ComboBoxBPType.SelectedIndex = 2
        End If

        TextBoxBPPhone1.Text = rec.Fields.Item(3).Value
        TextBoxBPPhone2.Text = rec.Fields.Item(4).Value

       
    End Sub

    Private Sub updateNextPrevious()
        btnNext.Enabled = Not rec.EoF
        btnPrevious.Enabled = Not rec.BoF
    End Sub

    Private Sub refreshFromDb()
        rec.DoQuery("SELECT CardCode, CardName, CardType,  Phone1, Phone2 FROM OCRD ORDER BY CardCode DESC")
    End Sub

    Private Sub clearAll()
        TextBoxBPCode.Clear()
        TextBoxBPName.Clear()
        ComboBoxBPType.SelectedIndex = 0
        TextBoxBPPhone1.Clear()
        TextBoxBPPhone2.Clear()

    End Sub

    Private Sub updateMode(Mode As Integer, Optional clear As Boolean = True)
        If clear Then
            clearAll()
        End If

        Me.mode = Mode
        btnAdd.Enabled = False
        btnFind.Enabled = False
        btnUpdate.Enabled = True

        Select Case Mode
            Case 1
                btnOKBP.Text = "Add"
                btnFind.Enabled = True
            Case 2
                btnOKBP.Text = "Find"
                btnAdd.Enabled = True

            Case 3
                btnOKBP.Text = "Update"
                btnFind.Enabled = True
                btnAdd.Enabled = True
                btnUpdate.Enabled = False
            Case Else
                btnOKBP.Text = "Ok"
                btnAdd.Enabled = True
                btnFind.Enabled = True
        End Select

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


    Private Sub btnNext_Click(sender As System.Object, e As System.EventArgs) Handles btnNext.Click

        updateNextPrevious()
        If rec.EoF = False Then
            addData(rec)
            rec.MoveNext()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As System.Object, e As System.EventArgs) Handles btnPrevious.Click

        updateNextPrevious()
        If rec.BoF = False Then
            rec.MovePrevious()
            addData(rec)
        End If
    End Sub

    Private Sub ComboBoxBPType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBoxBPType.SelectedIndexChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class