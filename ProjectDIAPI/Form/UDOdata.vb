Public Class UDOdata



    Private Sub AddUserTable(ByVal Name As String, ByVal Description As String, _
        ByVal Type As SAPbobsCOM.BoUTBTableType)
        

        Dim oUserTablesMD As SAPbobsCOM.UserTablesMD


        '// objek-objek di initialize
        oUserTablesMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserTables)



        '// set parameter table
        oUserTablesMD.TableName = Name
        oUserTablesMD.TableDescription = Description
        oUserTablesMD.TableType = Type

        lRetCode = oUserTablesMD.Add
        '// check error
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            MsgBox("Table: " & oUserTablesMD.TableName & " was added successfully")
        End If

        oUserTablesMD = Nothing

        GC.Collect() 'Release the handle to the table
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        AddUserTable("SM_OMOR", "Meal Order", SAPbobsCOM.BoUTBTableType.bott_Document)
        chkUDOAfter.SetItemChecked(0, True)
        AddUserTable("SM_MOR1", "Meal Lines", SAPbobsCOM.BoUTBTableType.bott_DocumentLines)
        chkUDOAfter.SetItemChecked(4, True)
    End Sub
    Private Function Add_SM_OMOR_Fields()

        Dim oUserFieldsMD As SAPbobsCOM.UserFieldsMD
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)

        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_OMOR"
        oUserFieldsMD.Name = "Name"
        oUserFieldsMD.Description = "Name"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(1, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(1, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_OMOR"
        oUserFieldsMD.Name = "Room"
        oUserFieldsMD.Description = "Room"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(2, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(2, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_OMOR"
        oUserFieldsMD.Name = "Price"
        oUserFieldsMD.Description = "Price"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(3, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(3, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        GC.Collect() 'Release the handle to the User Fields
    End Function

    Private Function Add_SM_MOR1_Fields()

        Dim oUserFieldsMD As SAPbobsCOM.UserFieldsMD
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)


        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_MOR1"
        oUserFieldsMD.Name = "LineType"
        oUserFieldsMD.Description = "Line Type"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 200

        ' Add Line type valid values - P, R, T, S
        oUserFieldsMD.ValidValues.Value = "P"
        oUserFieldsMD.ValidValues.Description = "C:\\Bitmap\\Smile.bmp"
        oUserFieldsMD.ValidValues.Add()

        oUserFieldsMD.ValidValues.Value = "R"
        oUserFieldsMD.ValidValues.Description = "Regular"
        oUserFieldsMD.ValidValues.Add()

        oUserFieldsMD.ValidValues.Value = "T"
        oUserFieldsMD.ValidValues.Description = "Text"
        oUserFieldsMD.ValidValues.Add()

        oUserFieldsMD.ValidValues.Value = "S"
        oUserFieldsMD.ValidValues.Description = "SubTotal"
        oUserFieldsMD.ValidValues.Add()

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(5, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(5, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        ' Restart User Fields object
        oUserFieldsMD = Nothing
        GC.Collect()
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)

        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_MOR1"
        oUserFieldsMD.Name = "MainDish"
        oUserFieldsMD.Description = "Main Dish"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 200

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(6, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(6, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If


        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_MOR1"
        oUserFieldsMD.Name = "SideDish"
        oUserFieldsMD.Description = "Side Dish"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(7, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(7, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_MOR1"
        oUserFieldsMD.Name = "Drink"
        oUserFieldsMD.Description = "Drink"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(8, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(8, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        ' Restart User Fields object
        oUserFieldsMD = Nothing
        GC.Collect()
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)


        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@SM_MOR1"
        oUserFieldsMD.Name = "Price"
        oUserFieldsMD.Description = "Price"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Numeric
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_Price

        'oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(9, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(9, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        GC.Collect() 'Release the handle to the User Fields
    End Function

    Private Function TableExist(ByVal TableName As String) As Boolean
        Dim oUserTablesMD As SAPbobsCOM.UserTablesMD
        Dim bool As Boolean
        oUserTablesMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserTables)

        bool = oUserTablesMD.GetByKey(TableName)
        Return (bool)
    End Function

    Private Sub btnAddFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddFields.Click
        Add_SM_OMOR_Fields()
        Add_SM_MOR1_Fields()
    End Sub
    Private Sub AddUDO()


        Dim oUserObjectMD As SAPbobsCOM.UserObjectsMD

        oUserObjectMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserObjectsMD)

        oUserObjectMD.CanCancel = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.CanClose = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.CanCreateDefaultForm = SAPbobsCOM.BoYesNoEnum.tNO
        oUserObjectMD.CanDelete = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.CanFind = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.CanYearTransfer = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.ChildTables.TableName = "SM_MOR1"
        oUserObjectMD.Code = "SM_MOR"
        oUserObjectMD.ManageSeries = SAPbobsCOM.BoYesNoEnum.tYES
        oUserObjectMD.Name = "SM_Meal_Order"
        oUserObjectMD.ObjectType = SAPbobsCOM.BoUDOObjType.boud_Document
        oUserObjectMD.TableName = "SM_OMOR"

        ' Handle UDO Form
        If ChkCreateDefaultForm.Checked = True Then
            oUserObjectMD.CanCreateDefaultForm = SAPbobsCOM.BoYesNoEnum.tYES

            oUserObjectMD.FormColumns.FormColumnAlias = "DocEntry"
            oUserObjectMD.FormColumns.FormColumnDescription = "DocEntry"
            oUserObjectMD.FormColumns.Add()

            oUserObjectMD.FormColumns.FormColumnAlias = "U_Name"
            oUserObjectMD.FormColumns.FormColumnDescription = "Name"
            oUserObjectMD.FormColumns.Add()

            oUserObjectMD.FormColumns.FormColumnAlias = "U_Room"
            oUserObjectMD.FormColumns.FormColumnDescription = "Room"
            oUserObjectMD.FormColumns.Add()

            oUserObjectMD.FormColumns.FormColumnAlias = "U_Price"
            oUserObjectMD.FormColumns.FormColumnDescription = "Price"
            oUserObjectMD.FormColumns.Add()

            If RadNewForm.Checked = True Then
                oUserObjectMD.EnableEnhancedForm = SAPbobsCOM.BoYesNoEnum.tYES
                oUserObjectMD.RebuildEnhancedForm = SAPbobsCOM.BoYesNoEnum.tYES

                oUserObjectMD.EnhancedFormColumns.ColumnAlias = "U_LineType"
                oUserObjectMD.EnhancedFormColumns.ColumnDescription = "Line Type"
                oUserObjectMD.EnhancedFormColumns.ColumnIsUsed = SAPbobsCOM.BoYesNoEnum.tYES
                oUserObjectMD.EnhancedFormColumns.ColumnNumber = 1
                oUserObjectMD.EnhancedFormColumns.ChildNumber = 1
                oUserObjectMD.EnhancedFormColumns.Add()

                oUserObjectMD.EnhancedFormColumns.ColumnAlias = "U_MainDish"
                oUserObjectMD.EnhancedFormColumns.ColumnDescription = "Main Dish"
                oUserObjectMD.EnhancedFormColumns.ColumnIsUsed = SAPbobsCOM.BoYesNoEnum.tYES
                oUserObjectMD.EnhancedFormColumns.ColumnNumber = 2
                oUserObjectMD.EnhancedFormColumns.ChildNumber = 1
                oUserObjectMD.EnhancedFormColumns.Add()

                oUserObjectMD.EnhancedFormColumns.ColumnAlias = "U_SideDish"
                oUserObjectMD.EnhancedFormColumns.ColumnDescription = "Side Dish"
                oUserObjectMD.EnhancedFormColumns.ColumnIsUsed = SAPbobsCOM.BoYesNoEnum.tYES
                oUserObjectMD.EnhancedFormColumns.ColumnNumber = 3
                oUserObjectMD.EnhancedFormColumns.ChildNumber = 1
                oUserObjectMD.EnhancedFormColumns.Add()

                oUserObjectMD.EnhancedFormColumns.ColumnAlias = "U_Drink"
                oUserObjectMD.EnhancedFormColumns.ColumnDescription = "Drink"
                oUserObjectMD.EnhancedFormColumns.ColumnIsUsed = SAPbobsCOM.BoYesNoEnum.tYES
                oUserObjectMD.EnhancedFormColumns.ColumnNumber = 4
                oUserObjectMD.EnhancedFormColumns.ChildNumber = 1
                oUserObjectMD.EnhancedFormColumns.Add()

                oUserObjectMD.EnhancedFormColumns.ColumnAlias = "U_Price"
                oUserObjectMD.EnhancedFormColumns.ColumnDescription = "Price"
                oUserObjectMD.EnhancedFormColumns.ColumnIsUsed = SAPbobsCOM.BoYesNoEnum.tYES
                oUserObjectMD.EnhancedFormColumns.ColumnNumber = 5
                oUserObjectMD.EnhancedFormColumns.ChildNumber = 1
                oUserObjectMD.EnhancedFormColumns.Add()

            ElseIf RadOldForm.Checked = True Then
                oUserObjectMD.EnableEnhancedForm = SAPbobsCOM.BoYesNoEnum.tNO
            End If
        End If


        ' Handle Menu
        If chkCreateMenu.Checked Then
            oUserObjectMD.MenuItem = SAPbobsCOM.BoYesNoEnum.tYES
            oUserObjectMD.MenuUID = "MealID"
            oUserObjectMD.MenuCaption = "Meal Order"
            oUserObjectMD.Position = 1
            oUserObjectMD.FatherMenuID = txtFatherMenuID.Text

        End If

        lRetCode = oUserObjectMD.Add()

        '// check for errors in the process
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(10, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            MsgBox("UDO: " & oUserObjectMD.Name & " was added successfully")
            chkUDOAfter.SetItemChecked(9, True)
        End If

        oUserObjectMD = Nothing

        GC.Collect() 'Release the handle to the table
    End Sub

    Sub AddUDORecord()

        Dim oGeneralService As SAPbobsCOM.GeneralService
        Dim oGeneralData As SAPbobsCOM.GeneralData
        Dim oChild As SAPbobsCOM.GeneralData
        Dim oChildren As SAPbobsCOM.GeneralDataCollection
        Dim oGeneralParams As SAPbobsCOM.GeneralDataParams
        Dim oCompanyService As SAPbobsCOM.CompanyService

        Try

            oCompanyService = oCompany.GetCompanyService

            'Get GeneralService (oCmpSrv is the CompanyService)
            oGeneralService = oCompanyService.GetGeneralService("SM_MOR")

            'Create data for new row in main UDO
            oGeneralData = oGeneralService.GetDataInterface(SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralData)
            oGeneralData.SetProperty("U_Name", txtName.Text)
            oGeneralData.SetProperty("U_Room", txtRoom.Text)
            oGeneralData.SetProperty("U_Price", txtPrice.Text)

            ' Handle child rows
            oChildren = oGeneralData.Child("SM_MOR1")

            Dim i As Integer
            For i = 1 To lstMainDish.Items.Count
                'Create data for rows in the child table
                oChild = oChildren.Add
                oChild.SetProperty("U_MainDish", lstMainDish.Items.Item(i - 1))
                oChild.SetProperty("U_SideDish", lstSideDish.Items.Item(i - 1))
                oChild.SetProperty("U_Drink", lstDrink.Items.Item(i - 1))
            Next

            'Add the new row, including children, to database
            oGeneralParams = oGeneralService.Add(oGeneralData)

            txtCode.Text = oGeneralParams.GetProperty("DocEntry")

            MsgBox("Record added")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try


    End Sub

    Sub GetUDORecord()

        Dim oGeneralService As SAPbobsCOM.GeneralService
        Dim oGeneralData As SAPbobsCOM.GeneralData
        Dim oChild As SAPbobsCOM.GeneralData
        Dim oChildren As SAPbobsCOM.GeneralDataCollection
        Dim oGeneralParams As SAPbobsCOM.GeneralDataParams
        Dim oCompanyService As SAPbobsCOM.CompanyService

        oCompanyService = oCompany.GetCompanyService

        Try

            'Get GeneralService (oCmpSrv is the CompanyService)
            oGeneralService = oCompanyService.GetGeneralService("SM_MOR")

            oGeneralParams = oGeneralService.GetDataInterface(SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralDataParams)
            oGeneralParams.SetProperty("DocEntry", txtCode.Text)
            oGeneralData = oGeneralService.GetByParams(oGeneralParams)

            'Create data for a row in the child table
            oChildren = oGeneralData.Child("SM_MOR1")

            'Empty child record lists
            lstMainDish.Items.Clear()
            lstSideDish.Items.Clear()
            lstDrink.Items.Clear()

            ' Handle child rows
            oChildren = oGeneralData.Child("SM_MOR1")
            Dim i As Integer
            MsgBox("going to add sons: " & oChildren.Count.ToString)
            For i = 1 To oChildren.Count
                oChild = oChildren.Item(i - 1)

                lstMainDish.Items.Add(oChild.GetProperty("U_MainDish"))
                lstSideDish.Items.Add(oChild.GetProperty("U_SideDish"))
                lstDrink.Items.Add(oChild.GetProperty("U_Drink"))

            Next

            'Add the new row, including children, to database
            txtName.Text = oGeneralData.GetProperty("U_Name")
            txtRoom.Text = oGeneralData.GetProperty("U_Room")
            txtPrice.Text = oGeneralData.GetProperty("U_Price")

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        MsgBox("Record loaded")

    End Sub

    Sub UpdateUDORecord()
        Dim oGeneralService As SAPbobsCOM.GeneralService
        Dim oGeneralData As SAPbobsCOM.GeneralData
        Dim oGeneralParams As SAPbobsCOM.GeneralDataParams

        Dim sCmp As SAPbobsCOM.CompanyService
        sCmp = oCompany.GetCompanyService

        ' This function updates only parent record.
        ' Child records remain as is.

        Try
            'Get a handle to the SM_MOR UDO
            oGeneralService = sCmp.GetGeneralService("SM_MOR")

            'Get UDO record
            oGeneralParams = oGeneralService.GetDataInterface(SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralDataParams)
            oGeneralParams.SetProperty("DocEntry", txtCode.Text)
            oGeneralData = oGeneralService.GetByParams(oGeneralParams)

            'Update UDO record
            oGeneralData.SetProperty("U_Room", txtRoom.Text)
            oGeneralData.SetProperty("U_Price", txtPrice.Text)
            oGeneralData.SetProperty("U_Name", txtName.Text)
            oGeneralService.Update(oGeneralData)

            MsgBox("Updated")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub DeleteUDORecord()
        Dim oGeneralService As SAPbobsCOM.GeneralService
        Dim oGeneralParams As SAPbobsCOM.GeneralDataParams

        Dim sCmp As SAPbobsCOM.CompanyService
        sCmp = oCompany.GetCompanyService

        Try
            'Get a handle to the SM_MOR UDO
            oGeneralService = sCmp.GetGeneralService("SM_MOR")

            'Delete UDO record
            oGeneralParams = oGeneralService.GetDataInterface(SAPbobsCOM.GeneralServiceDataInterfaces.gsGeneralDataParams)
            oGeneralParams.SetProperty("DocEntry", txtCode.Text)
            oGeneralService.Delete(oGeneralParams)

            MsgBox("Deleted")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub AddChildRecord()
        If txtMaindish.Text = "" Then
            MsgBox("Main Dish is empty")
        ElseIf txtSideDish.Text = "" Then
            MsgBox("Side Dish is empty")
        ElseIf txtDrink.Text = "" Then
            MsgBox("Drink is empty")
        Else
            ' If all fields are full, add the child record
            lstMainDish.Items.Add(txtMaindish.Text)
            lstSideDish.Items.Add(txtSideDish.Text)
            lstDrink.Items.Add(txtDrink.Text)
        End If

    End Sub

    Sub RomoveChildRecord()

        If lstMainDish.Items.Count() > 0 Then
            lstMainDish.Items.Remove(lstMainDish.Items.Item(lstMainDish.Items.Count() - 1))
            lstSideDish.Items.Remove(lstSideDish.Items.Item(lstSideDish.Items.Count() - 1))
            lstDrink.Items.Remove(lstDrink.Items.Item(lstDrink.Items.Count() - 1))
        End If

    End Sub

    Private Sub btnAddUDO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUDO.Click
        AddUDO()
    End Sub

    Private Sub cmdAddRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddRecord.Click
        AddUDORecord()
    End Sub

    Private Sub cmdUpdateRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdateRecord.Click
        UpdateUDORecord()
    End Sub

    Private Sub cmdGetRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGetRecord.Click
        GetUDORecord()
    End Sub

    Private Sub cmdDeleteRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleteRecord.Click
        DeleteUDORecord()
    End Sub

    Private Sub cmdAddchild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddchild.Click
        AddChildRecord()
    End Sub

    Private Sub cmdRemovechild_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemovechild.Click
        RomoveChildRecord()
    End Sub

    Private Sub ChkCreateDefaultForm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCreateDefaultForm.CheckedChanged
        RadNewForm.Enabled = ChkCreateDefaultForm.Checked
        RadOldForm.Enabled = ChkCreateDefaultForm.Checked
    End Sub

    Private Sub chkCreateMenu_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCreateMenu.CheckedChanged
        txtFatherMenuID.Enabled = chkCreateMenu.Checked
        lblFatherMenuID.Enabled = chkCreateMenu.Checked
    End Sub



    Private Sub grpUDO_Enter(sender As System.Object, e As System.EventArgs) Handles grpUDO.Enter

    End Sub

    Private Sub chkUDOAfter_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles chkUDOAfter.SelectedIndexChanged

    End Sub


    Private Sub UDOdata_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        grpUDO.Enabled = True
        grpRecords.Enabled = True
        grpChild.Enabled = True

    End Sub
End Class