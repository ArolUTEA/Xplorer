Imports System.Data.SQLite
Module ResearchFunctions
    Public Function fFindElementInColumn(strItemToFind As String, strTableName As String, strColumnName As String) As Boolean
        Try
            Dim tempData As DataTable
            tempData = frmMain.dbWarehouse.fFindInColumn(strItemToFind, strColumnName, strTableName, frmMain.dbWarehouse.SQLConn)
            If tempData.Rows.Count > 0 Then
                fPopulateAndResizeDGV(frmMain.dgvCEDBViewer, tempData, frmMain.CompEleControl.Width)
                tempData.Dispose()
                Return True
            Else
                frmMain.dgvCEDBViewer.Visible = False
                MsgBox("NESSUNA OCCORRENZA TROVATA", MsgBoxStyle.Information)
                tempData.Dispose()
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELLA RICERCA DI UN ELEMENTO IN UNA COLONNA DEL DATABASE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fResearchAdvanced() As Boolean
        Try
            Dim tableName As String = Nothing
            'Check which table control is selected
            Select Case frmMain.CompEleControl.SelectedIndex
                Case 0
                    tableName = "codificati"
                Case 1
                    tableName = "consumabili"
                Case Else
                    Return False
            End Select
            Dim tempData As DataTable
            'Call find advanced function
            tempData = frmMain.dbWarehouse.fFindAdvancedInDatabase(frmMain.dbWarehouse.SQLConn, tableName, frmMain.txtFindACode.Text, frmMain.txtFindCCode.Text, frmMain.txtFindDescr.Text, frmMain.txtFindManufacturer.Text, frmMain.txtFindSupDescr.Text)
            If tempData.Rows.Count > 0 Then
                Select Case frmMain.CompEleControl.SelectedIndex
                    Case 0
                        fPopulateAndResizeDGV(frmMain.dgvCEDBViewer, tempData, frmMain.CompEleControl.Width)
                    Case 1
                        fPopulateAndResizeDGV(frmMain.dgvCSDBViewer, tempData, frmMain.CompEleControl.Width)
                    Case Else
                        Return False
                End Select
            Else
                Select Case frmMain.CompEleControl.SelectedIndex
                    Case 0
                        frmMain.dgvCEDBViewer.Visible = False
                    Case 1
                        frmMain.dgvCSDBViewer.Visible = False
                    Case Else
                        Return False
                End Select
                MsgBox("Nessuna occorrenza trovata", MsgBoxStyle.Information)
            End If
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NELLA PROCEDURA DI RICERCA AVANZATA", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fSelectAllAndOrder(dgvSelected As DataGridView, strTableName As String) As Boolean
        Try
            Dim tempData As DataTable
            'Call select all function
            tempData = frmMain.dbWarehouse.fSelectAllAndOrderBy(frmMain.dbWarehouse.SQLConn, strTableName, "ArolCode")
            If tempData.Rows.Count > 0 Then
                fPopulateAndResizeDGV(dgvSelected, tempData, frmMain.CompEleControl.Width)
                Return True
            Else
                dgvSelected.Visible = False
                MsgBox("Nessuna occorrenza trovata", MsgBoxStyle.Information)
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELLA PROCEDURA DI CARICA TUTTO DA DATABASE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fPopulateGuidedSearchComboBoxes() As Boolean
        Dim dbCodingRules As New DBManagement
        Dim strDBPath As String = frmMain.xmlReader.fReadSingleNode("dbRulesPath")
        'Connect to database and check connection status
        Try
            dbCodingRules.fConnection("Data Source =" & strDBPath & ";Version = 3")
        Catch ex As Exception
            MsgBox("ERRORE NELLA CONNESSIONE AL DATABASE DELLE REGOLE DI CODIFICA", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
        'Populate category comboBox
        Dim dtCategory As New DataTable
        Try
            Dim i As Integer = 0
            dtCategory = dbCodingRules.fSelectAndOrderAllInDatabase(dbCodingRules.SQLConn, "tbArticlesCategory", "Category", "Category")
            frmMain.cbxSearchCategory.Items.Clear()
            For Each item In dtCategory.Rows
                frmMain.cbxSearchCategory.Items.Add(dtCategory.Rows(i)(0))
                i = i + 1
            Next
            dtCategory.Dispose()
        Catch ex As Exception
            MsgBox("ERRORE NEL POPOLAMENTO DEL COMBOBOX DELLE CATEGORIE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            dtCategory.Dispose()
            Return False
        End Try
        'Populate manufacturer comboBox
        Dim dtManufacturer As New DataTable
        Try
            Dim strTempQuery As String = "SELECT * FROM tbSupplier ORDER BY SUPPLIER"
            dtManufacturer = dbCodingRules.fExecuteGenericQuery(dbCodingRules.SQLConn, strTempQuery)
            Dim i As Integer = 0
            frmMain.cbxSearchManufacturer.Items.Clear()
            For Each item In dtManufacturer.Rows
                frmMain.cbxSearchManufacturer.Items.Add(dtManufacturer.Rows(i)("SUPPLIER"))
                i = i + 1
            Next
            dtManufacturer.Dispose()
        Catch ex As Exception
            MsgBox("ERRORE NEL POPOLAMENTO DEL COMBOBOX DEI COSTRUTTORI", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            dtManufacturer.Dispose()
            Return False
        End Try
        dbCodingRules.fDisconnect()
        Return True
    End Function
    Public Function fGuideSearchCategory(strTableName As String, strColumnName As String, strItemToSearch1 As String, strItemToSearch2 As String, strOrderBy As String, dtDatabaseConnection As SQLiteConnection, bAndSearchEnable As Boolean) As DataTable
        'Retrieve ArolCode related to Category
        Dim dbCodingRules As New DBManagement
        Dim strDBPath As String = frmMain.xmlReader.fReadSingleNode("dbRulesPath")
        'Connect to database and check connection status
        Try
            dbCodingRules.fConnection("Data Source =" & strDBPath & ";Version = 3")
        Catch ex As Exception
            MsgBox("ERRORE NELLA CONNESSIONE AL DATABASE DELLE REGOLE DI CODIFICA", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return Nothing
        End Try
        'Execute query for ArolCode
        Dim strTempQuery As String = "SELECT * FROM tbArticlesCategory WHERE Category = '" & strItemToSearch1 & "'"
        Dim tempData As DataTable = dbCodingRules.fExecuteGenericQuery(dbCodingRules.SQLConn, strTempQuery)
        If tempData.Rows.Count > 0 Then
            strTempQuery = "SELECT * FROM tbArolCodeLookUp WHERE IDCategory = '" & tempData.Rows(0)("ID").ToString & "'"
            tempData = dbCodingRules.fExecuteGenericQuery(dbCodingRules.SQLConn, strTempQuery)
        End If
        If tempData.Rows.Count > 0 Then
            strTempQuery = "SELECT * FROM tbArolCode WHERE ID = '" & tempData.Rows(0)("IDArolCode").ToString & "'"
            tempData = dbCodingRules.fExecuteGenericQuery(dbCodingRules.SQLConn, strTempQuery)
        End If
        If tempData.Rows.Count > 0 Then
            'Retrieve Search results
            Try
                If bAndSearchEnable Then
                    strTempQuery = "SELECT * FROM " & strTableName & " WHERE " & strColumnName & " LIKE '%" & tempData.Rows(0)("Code").ToString & "%' AND Manufacturer LIKE '%" & strItemToSearch2 & "%' ORDER BY " & strOrderBy
                Else
                    strTempQuery = "SELECT * FROM " & strTableName & " WHERE " & strColumnName & " LIKE '%" & tempData.Rows(0)("Code").ToString & "%' ORDER BY " & strOrderBy
                End If
                Dim sqlCmd As SQLiteCommand = New SQLiteCommand(strTempQuery, dtDatabaseConnection)
                Dim da As New SQLiteDataAdapter
                da.SelectCommand = sqlCmd
                Dim dt As New DataTable
                da.Fill(dt)
                sqlCmd.ExecuteReader()
                If dt IsNot Nothing Then
                    fGuideSearchCategory = dt
                    sqlCmd.Dispose()
                    da.Dispose()
                    dt.Dispose()
                Else
                    sqlCmd.Dispose()
                    da.Dispose()
                    dt.Dispose()
                    Return Nothing
                End If
            Catch ex As Exception
                MsgBox("ERRORE NELLA QUERY DELLA RICERCA GUIDATA PER CATEGORIA", MsgBoxStyle.Critical)
                fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
                Return Nothing
            End Try
        Else
            Return Nothing
        End If
    End Function
    Public Function fGuideSearchManufacturer(strTableName As String, strItemToSearch1 As String, strItemToSearch2 As String, stOrderBy As String, dtDatabaseConnection As SQLiteConnection, bAndSearchEnable As Boolean) As DataTable
        Try
            Dim strTempQuery As String
            If bAndSearchEnable Then
                'Retrieve ArolCode related to Category
                Dim dbCodingRules As New DBManagement
                Dim strDBPath As String = frmMain.xmlReader.fReadSingleNode("dbRulesPath")
                'Connect to database and check connection status
                Try
                    dbCodingRules.fConnection("Data Source =" & strDBPath & ";Version = 3")
                Catch ex As Exception
                    MsgBox("ERRORE NELLA CONNESSIONE AL DATABASE DELLE REGOLE DI CODIFICA", MsgBoxStyle.Critical)
                    fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
                    Return Nothing
                End Try
                'Execute query for ArolCode
                strTempQuery = "SELECT * FROM tbArticlesCategory WHERE Category = '" & strItemToSearch2 & "'"
                Dim tempData As DataTable = dbCodingRules.fExecuteGenericQuery(dbCodingRules.SQLConn, strTempQuery)
                If tempData.Rows.Count > 0 Then
                    strTempQuery = "SELECT * FROM tbArolCodeLookUp WHERE IDCategory = '" & tempData.Rows(0)("ID").ToString & "'"
                    tempData = dbCodingRules.fExecuteGenericQuery(dbCodingRules.SQLConn, strTempQuery)
                End If
                If tempData.Rows.Count > 0 Then
                    strTempQuery = "SELECT * FROM tbArolCode WHERE ID = '" & tempData.Rows(0)("IDArolCode").ToString & "'"
                    tempData = dbCodingRules.fExecuteGenericQuery(dbCodingRules.SQLConn, strTempQuery)
                End If
                If tempData.Rows.Count > 0 Then
                    strTempQuery = "SELECT * FROM " & strTableName & " WHERE Manufacturer LIKE '%" & strItemToSearch1 & "%' AND ArolCode LIKE '%" & tempData.Rows(0)("Code").ToString & "%' ORDER BY " & stOrderBy
                End If
            Else
                strTempQuery = "SELECT * FROM " & strTableName & " WHERE Manufacturer LIKE '%" & strItemToSearch1 & "%' ORDER BY " & stOrderBy
            End If
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(strTempQuery, dtDatabaseConnection)
            Dim da As New SQLiteDataAdapter
            da.SelectCommand = sqlCmd
            Dim dt As New DataTable
            da.Fill(dt)
            sqlCmd.ExecuteReader()
            If dt IsNot Nothing Then
                fGuideSearchManufacturer = dt
                sqlCmd.Dispose()
                da.Dispose()
                dt.Dispose()
            Else
                sqlCmd.Dispose()
                da.Dispose()
                dt.Dispose()
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELLA QUERY DELLA RICERCA GUIDATA PER COSTRUTTORE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return Nothing
        End Try
    End Function
End Module