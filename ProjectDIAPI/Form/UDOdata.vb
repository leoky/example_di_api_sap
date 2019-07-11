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
        AddUserTable("VIT_TandaTrm", "Daftar Tagihan", SAPbobsCOM.BoUTBTableType.bott_Document)
        chkUDOAfter.SetItemChecked(0, True)
        AddUserTable("VIT_TandaTrmD", "Daftar Tagian", SAPbobsCOM.BoUTBTableType.bott_DocumentLines)
        chkUDOAfter.SetItemChecked(8, True)
    End Sub
    Private Function Add_SM_OMOR_Fields()

        Dim oUserFieldsMD As SAPbobsCOM.UserFieldsMD
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)

        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@VIT_TandaTrm"
        oUserFieldsMD.Name = "VIT_STATUS "
        oUserFieldsMD.Description = "Status"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.EditSize = 8

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

        oUserFieldsMD.TableName = "@VIT_TandaTrm"
        oUserFieldsMD.Name = "VIT_INVDUEDATE"
        oUserFieldsMD.Description = "Invoice Due Date"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Date

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

        oUserFieldsMD.TableName = "@VIT_TandaTrm"
        oUserFieldsMD.Name = "VIT_TGLSERAH"
        oUserFieldsMD.Description = "Tanggal Penyerahan"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Date

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

        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@VIT_TandaTrm"
        oUserFieldsMD.Name = "VIT_JAMSERAH"
        oUserFieldsMD.Description = "Tanggal Penyerahan"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Date
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_Time

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(4, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(4, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@VIT_TandaTrm"
        oUserFieldsMD.Name = "VIT_NAMASERAH"
        oUserFieldsMD.Description = "Nama Penerima"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_None
        oUserFieldsMD.Size = 50

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

        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@VIT_TandaTrm"
        oUserFieldsMD.Name = "VIT_TGLKEMBALI"
        oUserFieldsMD.Description = "Tanggal Kembali"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Date
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_None


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

        oUserFieldsMD.TableName = "@VIT_TandaTrm"
        oUserFieldsMD.Name = "VIT_JAMKEMBALI"
        oUserFieldsMD.Description = "Jam Kembali"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Date
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_Time


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



        GC.Collect() 'Release the handle to the User Fields
    End Function

    Private Function Add_SM_MOR1_Fields()

        Dim oUserFieldsMD As SAPbobsCOM.UserFieldsMD
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)


        ' Restart User Fields object
        oUserFieldsMD = Nothing
        GC.Collect()
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)

        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@VIT_TandaTrmD"
        oUserFieldsMD.Name = "VIT_INVNO"
        oUserFieldsMD.Description = "Invoice No"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_None
        oUserFieldsMD.Size = 10

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


        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@VIT_TandaTrmD"
        oUserFieldsMD.Name = "VIT_LISTTT"
        oUserFieldsMD.Description = "Print Tanda Terima"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_None
        oUserFieldsMD.Size = 8

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(10, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(10, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@VIT_TandaTrmD"
        oUserFieldsMD.Name = "VIT_INVDATE"
        oUserFieldsMD.Description = "Invoice Date"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Date
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_None

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(11, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(11, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        ' Restart User Fields object
        oUserFieldsMD = Nothing
        GC.Collect()
        oUserFieldsMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserFields)


        '// Setting the Field's properties

        oUserFieldsMD.TableName = "@VIT_TandaTrmD"
        oUserFieldsMD.Name = "VIT_INVDUEDATE"
        oUserFieldsMD.Description = "Invoice Due Date"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Date
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_None

        'oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(12, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(12, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '// Setting the Field's properties
        oUserFieldsMD.TableName = "@VIT_TandaTrmD"
        oUserFieldsMD.Name = "VIT_TOP"
        oUserFieldsMD.Description = "Term Of Payment"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_None
        oUserFieldsMD.Size = 15

        'oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(13, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(13, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '// Setting the Field's properties
        oUserFieldsMD.TableName = "@VIT_TandaTrmD"
        oUserFieldsMD.Name = "VIT_CUSTCODE"
        oUserFieldsMD.Description = "Customer Code"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_None
        oUserFieldsMD.Size = 15

        'oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(14, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(14, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '// Setting the Field's properties
        oUserFieldsMD.TableName = "@VIT_TandaTrmD"
        oUserFieldsMD.Name = "VIT_CUSTNAME"
        oUserFieldsMD.Description = "Customer Name"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_None
        oUserFieldsMD.Size = 100

        'oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(15, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(15, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '// Setting the Field's properties
        oUserFieldsMD.TableName = "@VIT_TandaTrmD"
        oUserFieldsMD.Name = "VIT_SLSEMP"
        oUserFieldsMD.Description = "Sales Employee"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_None
        oUserFieldsMD.Size = 100

        'oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(16, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(16, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '// Setting the Field's properties
        oUserFieldsMD.TableName = "@VIT_TandaTrmD"
        oUserFieldsMD.Name = "VIT_DOCTOTAL"
        oUserFieldsMD.Description = "Doc Total"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Float
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_Sum

        'oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(17, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(17, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '// Setting the Field's properties
        oUserFieldsMD.TableName = "@VIT_TandaTrmD"
        oUserFieldsMD.Name = "VIT_OPENAMT"
        oUserFieldsMD.Description = "Open Amount"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Float
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_Sum
        oUserFieldsMD.Size = 15

        'oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(18, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(18, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '// Setting the Field's properties
        oUserFieldsMD.TableName = "@VIT_TandaTrmD"
        oUserFieldsMD.Name = "VIT_GIROAMT"
        oUserFieldsMD.Description = "Giro Belum Cair"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Float
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_Sum
        oUserFieldsMD.Size = 15

        'oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(19, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(19, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        

        '// Setting the Field's properties
        oUserFieldsMD.TableName = "@VIT_TandaTrmD"
        oUserFieldsMD.Name = "VIT_CHECKKMBL"
        oUserFieldsMD.Description = "Tertagih"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_None
        oUserFieldsMD.Size = 8

        'oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(20, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(20, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '// Setting the Field's properties
        oUserFieldsMD.TableName = "@VIT_TandaTrmD"
        oUserFieldsMD.Name = "VIT_TITIPINV"
        oUserFieldsMD.Description = "Titipan Invoice"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_None
        oUserFieldsMD.Size = 8

        'oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(21, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(21, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '// Setting the Field's properties
        oUserFieldsMD.TableName = "@VIT_TandaTrmD"
        oUserFieldsMD.Name = "VIT_REMARKS"
        oUserFieldsMD.Description = "Remarks"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_None
        oUserFieldsMD.Size = 200

        'oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(22, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(22, True)
            MsgBox("Field: '" & oUserFieldsMD.Name & "' was added successfuly to " & oUserFieldsMD.TableName & " Table")
        End If

        '// Setting the Field's properties
        oUserFieldsMD.TableName = "@VIT_TandaTrmD"
        oUserFieldsMD.Name = "VIT_NOTTD"
        oUserFieldsMD.Description = "No Tanda Terima"
        oUserFieldsMD.Type = SAPbobsCOM.BoFieldTypes.db_Alpha
        oUserFieldsMD.SubType = SAPbobsCOM.BoFldSubTypes.st_None
        oUserFieldsMD.Size = 10

        'oUserFieldsMD.EditSize = 20

        '// Adding the Field to the Table
        lRetCode = oUserFieldsMD.Add

        '// Check for errors
        If lRetCode <> 0 Then
            If lRetCode = -1 Then
                chkUDOAfter.SetItemChecked(23, True)
            Else
                oCompany.GetLastError(lRetCode, sErrMsg)
                MsgBox(sErrMsg)
            End If
        Else
            chkUDOAfter.SetItemChecked(23, True)
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
    'Private Sub AddUDO()


    '    Dim oUserObjectMD As SAPbobsCOM.UserObjectsMD

    '    oUserObjectMD = oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.oUserObjectsMD)

    '    oUserObjectMD.CanCancel = SAPbobsCOM.BoYesNoEnum.tYES
    '    oUserObjectMD.CanClose = SAPbobsCOM.BoYesNoEnum.tYES
    '    oUserObjectMD.CanCreateDefaultForm = SAPbobsCOM.BoYesNoEnum.tNO
    '    oUserObjectMD.CanDelete = SAPbobsCOM.BoYesNoEnum.tYES
    '    oUserObjectMD.CanFind = SAPbobsCOM.BoYesNoEnum.tYES
    '    oUserObjectMD.CanYearTransfer = SAPbobsCOM.BoYesNoEnum.tYES
    '    oUserObjectMD.ChildTables.TableName = "SM_MOR1"
    '    oUserObjectMD.Code = "SM_MOR"
    '    oUserObjectMD.ManageSeries = SAPbobsCOM.BoYesNoEnum.tYES
    '    oUserObjectMD.Name = "SM_Meal_Order"
    '    oUserObjectMD.ObjectType = SAPbobsCOM.BoUDOObjType.boud_Document
    '    oUserObjectMD.TableName = "SM_OMOR"

    '    ' Handle UDO Form
    '    If ChkCreateDefaultForm.Checked = True Then
    '        oUserObjectMD.CanCreateDefaultForm = SAPbobsCOM.BoYesNoEnum.tYES

    '        oUserObjectMD.FormColumns.FormColumnAlias = "DocEntry"
    '        oUserObjectMD.FormColumns.FormColumnDescription = "DocEntry"
    '        oUserObjectMD.FormColumns.Add()

    '        oUserObjectMD.FormColumns.FormColumnAlias = "U_Name"
    '        oUserObjectMD.FormColumns.FormColumnDescription = "Name"
    '        oUserObjectMD.FormColumns.Add()

    '        oUserObjectMD.FormColumns.FormColumnAlias = "U_Room"
    '        oUserObjectMD.FormColumns.FormColumnDescription = "Room"
    '        oUserObjectMD.FormColumns.Add()

    '        oUserObjectMD.FormColumns.FormColumnAlias = "U_Price"
    '        oUserObjectMD.FormColumns.FormColumnDescription = "Price"
    '        oUserObjectMD.FormColumns.Add()

    '        If RadNewForm.Checked = True Then
    '            oUserObjectMD.EnableEnhancedForm = SAPbobsCOM.BoYesNoEnum.tYES
    '            oUserObjectMD.RebuildEnhancedForm = SAPbobsCOM.BoYesNoEnum.tYES

    '            oUserObjectMD.EnhancedFormColumns.ColumnAlias = "U_LineType"
    '            oUserObjectMD.EnhancedFormColumns.ColumnDescription = "Line Type"
    '            oUserObjectMD.EnhancedFormColumns.ColumnIsUsed = SAPbobsCOM.BoYesNoEnum.tYES
    '            oUserObjectMD.EnhancedFormColumns.ColumnNumber = 1
    '            oUserObjectMD.EnhancedFormColumns.ChildNumber = 1
    '            oUserObjectMD.EnhancedFormColumns.Add()

    '            oUserObjectMD.EnhancedFormColumns.ColumnAlias = "U_MainDish"
    '            oUserObjectMD.EnhancedFormColumns.ColumnDescription = "Main Dish"
    '            oUserObjectMD.EnhancedFormColumns.ColumnIsUsed = SAPbobsCOM.BoYesNoEnum.tYES
    '            oUserObjectMD.EnhancedFormColumns.ColumnNumber = 2
    '            oUserObjectMD.EnhancedFormColumns.ChildNumber = 1
    '            oUserObjectMD.EnhancedFormColumns.Add()

    '            oUserObjectMD.EnhancedFormColumns.ColumnAlias = "U_SideDish"
    '            oUserObjectMD.EnhancedFormColumns.ColumnDescription = "Side Dish"
    '            oUserObjectMD.EnhancedFormColumns.ColumnIsUsed = SAPbobsCOM.BoYesNoEnum.tYES
    '            oUserObjectMD.EnhancedFormColumns.ColumnNumber = 3
    '            oUserObjectMD.EnhancedFormColumns.ChildNumber = 1
    '            oUserObjectMD.EnhancedFormColumns.Add()

    '            oUserObjectMD.EnhancedFormColumns.ColumnAlias = "U_Drink"
    '            oUserObjectMD.EnhancedFormColumns.ColumnDescription = "Drink"
    '            oUserObjectMD.EnhancedFormColumns.ColumnIsUsed = SAPbobsCOM.BoYesNoEnum.tYES
    '            oUserObjectMD.EnhancedFormColumns.ColumnNumber = 4
    '            oUserObjectMD.EnhancedFormColumns.ChildNumber = 1
    '            oUserObjectMD.EnhancedFormColumns.Add()

    '            oUserObjectMD.EnhancedFormColumns.ColumnAlias = "U_Price"
    '            oUserObjectMD.EnhancedFormColumns.ColumnDescription = "Price"
    '            oUserObjectMD.EnhancedFormColumns.ColumnIsUsed = SAPbobsCOM.BoYesNoEnum.tYES
    '            oUserObjectMD.EnhancedFormColumns.ColumnNumber = 5
    '            oUserObjectMD.EnhancedFormColumns.ChildNumber = 1
    '            oUserObjectMD.EnhancedFormColumns.Add()

    '        ElseIf RadOldForm.Checked = True Then
    '            oUserObjectMD.EnableEnhancedForm = SAPbobsCOM.BoYesNoEnum.tNO
    '        End If
    '    End If


    '    ' Handle Menu
    '    If chkCreateMenu.Checked Then
    '        oUserObjectMD.MenuItem = SAPbobsCOM.BoYesNoEnum.tYES
    '        oUserObjectMD.MenuUID = "MealID"
    '        oUserObjectMD.MenuCaption = "Meal Order"
    '        oUserObjectMD.Position = 1
    '        oUserObjectMD.FatherMenuID = txtFatherMenuID.Text

    '    End If

    '    lRetCode = oUserObjectMD.Add()

    '    '// check for errors in the process
    '    If lRetCode <> 0 Then
    '        If lRetCode = -1 Then
    '            chkUDOAfter.SetItemChecked(10, True)
    '        Else
    '            oCompany.GetLastError(lRetCode, sErrMsg)
    '            MsgBox(sErrMsg)
    '        End If
    '    Else
    '        MsgBox("UDO: " & oUserObjectMD.Name & " was added successfully")
    '        chkUDOAfter.SetItemChecked(9, True)
    '    End If

    '    oUserObjectMD = Nothing

    '    GC.Collect() 'Release the handle to the table
    'End Sub













    'Private Sub btnAddUDO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddUDO.Click
    '    AddUDO()
    'End Sub







    Private Sub grpUDO_Enter(sender As System.Object, e As System.EventArgs) Handles grpUDO.Enter

    End Sub

    Private Sub chkUDOAfter_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles chkUDOAfter.SelectedIndexChanged

    End Sub


    Private Sub UDOdata_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        grpUDO.Enabled = True


    End Sub
End Class