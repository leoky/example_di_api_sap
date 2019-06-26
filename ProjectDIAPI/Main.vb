Public Class Main

    Private Sub BtnChooseCompany_Click(sender As System.Object, e As System.EventArgs) Handles btnChooseCompany.Click
        '// jika belum di connect dengan database dan login maka belum bisa mengakses fitur selanjutnya
        If oCompany.Connected Then
            '//GroupBoxMain.Text = "Company : " + oCompany.CompanyName
            GroupBoxMain.Enabled = oCompany.Connected
            '//Me.Text = Me.Text + " (" + oCompany.CompanyName + ")"
        End If

        ChooseCompany.ShowDialog()

    End Sub

    Private Sub Main_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        InitializeCompany()
        GroupBoxMain.Enabled = oCompany.Connected
    End Sub

    Private Sub btnItemMasterData_Click(sender As System.Object, e As System.EventArgs) Handles btnItemMasterData.Click
        ItemMasterData.ShowDialog()
    End Sub

    Private Sub Main_Activated(sender As System.Object, e As System.EventArgs) Handles MyBase.Activated
        If oCompany.Connected Then
            '//GroupBoxMain.Text = "Company : " + oCompany.CompanyName
            GroupBoxMain.Enabled = oCompany.Connected
            '//Me.Text = Me.Text + " (" + oCompany.CompanyName + ")"
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        BPMasterData.ShowDialog()
    End Sub

    Private Sub btnSalesOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnSalesOrder.Click
        SalesOrder.ShowDialog()
    End Sub

    Private Sub btnUDF_Click(sender As System.Object, e As System.EventArgs) Handles btnUDF.Click
        UDFData.ShowDialog()
    End Sub

    Private Sub btnUDT_Click(sender As System.Object, e As System.EventArgs) Handles btnUDT.Click
        UDTdata.ShowDialog()
    End Sub

    Private Sub btnUDO_Click(sender As System.Object, e As System.EventArgs) Handles btnUDO.Click
        UDOdata.ShowDialog()
    End Sub
End Class
