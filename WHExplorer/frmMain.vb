Imports System.ComponentModel
Imports System.Text
Imports System.IO
Public Class frmMain
    Public dbWarehouse As DBManagement = New DBManagement
    Public dbUsers As DBManagement = New DBManagement
    Public xmlReader As XMLReader = New XMLReader
    Public strUsername As String
    Public bUserWritePerm As Boolean
    Public bManageUser As Boolean
    Public bChangePassword As Boolean
    Public strDBPath As String
    Public strLogFilePath As String = RegularExpressions.Regex.Replace(AppDomain.CurrentDomain.BaseDirectory & "Logs\LogFile" & Date.Now.Year & Date.Now.Month & Date.Now.Day & ".txt", """", "")
    Public strApplicationPath As String = AppDomain.CurrentDomain.BaseDirectory
    Public iModifiedID As Integer
    Public iModifiedRowIndex As Integer
    Public bFormLoad As Boolean = False
    Public bGuidedSearchAnd As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check if log file already exist
        fCheckIfLogFileExist(strLogFilePath)
        'Retriev Windows username
        strUsername = Environment.UserName
        'Update Log File
        fAddLogRow(strLogFilePath, "Utente: " & strUsername & " loggato il " & Date.Now.Day & "/" & Date.Now.Month & "/" & Date.Now.Year & " " & Date.Now.Hour & ":" & Date.Now.Minute & ":" & Date.Now.Second)
        'Update Form1 information
        Me.Text = "Xplorer - " & strUsername
        'Set focus to Componenti Elettrici Tab
        CompElePage.Select()
        'Read database connection configuration from xml file
        Try
            strDBPath = RegularExpressions.Regex.Replace(strApplicationPath & xmlReader.fReadDBPath(), """", "")
        Catch ex As Exception
            MsgBox("ERRORE NELLA LETTURA DEL PATH DEL DATABASE", MsgBoxStyle.Critical)
            fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
        End Try
        'Connect to users database
        Try
            dbUsers.fConnection("Data Source =" & AppDomain.CurrentDomain.BaseDirectory & "Configurations\users.db" & ";Version = 3")
            If dbUsers.bIsConnected Then
                btnLogin.Enabled = True
            Else
                btnLogin.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELL'APERTURA DEL DATABASE USERS", MsgBoxStyle.Critical)
            fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
        End Try
        'Connect to database and check connection status
        Try
            dbWarehouse.fConnection("Data Source =" & strDBPath & ";Version = 3")
            txtOpResult.Text = dbWarehouse.stOpResult
            If Not dbWarehouse.bIsConnected Then
                MsgBox("CONNESSIONE AL DATABASE NON RIUSCITA, IMPOSSIBILE CONTINUARE", MsgBoxStyle.Critical)
                Application.Exit()
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELL'APERTURA DEL DATABASE", MsgBoxStyle.Critical)
            fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
        End Try
        btnOpenFile.Visible = False
        'Check if new files are present in datasheet source folder
        Try
            Dim dsSourceFolder As String = RegularExpressions.Regex.Replace(strApplicationPath & xmlReader.fReadSingleNode("dsSourceFolder"), """", "")
            Dim dsDestFolder As String = RegularExpressions.Regex.Replace(strApplicationPath & xmlReader.fReadSingleNode("dsDestFolder"), """", "")
            If fCheckIfThereFiles(dsSourceFolder) Then
                If MsgBox("Sono disponibili nuovi DataSheet, vuoi Salvarli?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim tempString As String(,)
                    'chiamo la funzione che mi restituisce un array contenente i nomi dei files
                    tempString = fRetrieveFileName(dsSourceFolder)
                    For i = 0 To tempString.GetLength(0) - 1
                        'Copio i datasheet nella cartella di archivio ed inserisco i link nel database
                        fCopyFromDirToDir(dsSourceFolder & tempString(i, 0) & tempString(i, 1), dsDestFolder & tempString(i, 0) & tempString(i, 1), True)
                        If Not dbWarehouse.fCheckIfAlreadyExist(dsDestFolder & tempString(i, 0) & tempString(i, 1), dbWarehouse.SQLConn, "codificatiDS", "Link") Then
                            dbWarehouse.fInsertDatasheetInDatabase(tempString(i, 0), tempString(i, 1), dsDestFolder & tempString(i, 0) & tempString(i, 1), dbWarehouse.SQLConn, "codificatiDS")
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELLA COPIA DEI NUOVI DATASHEETS", MsgBoxStyle.Critical)
            fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
        End Try
        fSelectAllAndOrder(dgvCEDBViewer, "codificati")
        'Enable Simple Search
        rbSimpleSearch.Checked = True
        bFormLoad = True
    End Sub
    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Disconnect from database
        dbWarehouse.fDisconnect()
    End Sub
    Private Sub dgvCEDBViewer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCEDBViewer.CellClick
        fManagementOfDgvClickOrKeyMove()
    End Sub
    Private Sub dgvCSDBViewer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCSDBViewer.CellClick
        fManagementOfDgvClickOrKeyMove()
    End Sub
    Private Sub btnOpenFile_Click(sender As Object, e As EventArgs) Handles btnOpenFile.Click
        Dim rowIndex As Integer
        Dim ArolCode As String
        Select Case CompEleControl.SelectedIndex
            Case 0
                'CODIFICATI
                rowIndex = dgvCEDBViewer.CurrentCell.RowIndex
                ArolCode = dgvCEDBViewer.Rows(rowIndex).Cells(1).Value
            Case 1
                'CONSUMABILI
                rowIndex = dgvCSDBViewer.CurrentCell.RowIndex
                ArolCode = dgvCSDBViewer.Rows(rowIndex).Cells(1).Value
            Case Else
                Exit Sub
        End Select
        dbWarehouse.fChekHowManyExistsAndRead(ArolCode, dbWarehouse.SQLConn, "codificatiDS", "Name")
    End Sub
    Private Sub dgvCEDBViewer_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCEDBViewer.KeyDown
        fManagementOfDgvClickOrKeyMove()
    End Sub
    Private Sub dgvCSDBViewer_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCSDBViewer.KeyDown
        fManagementOfDgvClickOrKeyMove()
    End Sub
    Private Sub dgvCEDBViewer_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvCEDBViewer.KeyUp
        fManagementOfDgvClickOrKeyMove()
    End Sub
    Private Sub dgvCSDBViewer_KeyUp(sender As Object, e As KeyEventArgs) Handles dgvCSDBViewer.KeyUp
        fManagementOfDgvClickOrKeyMove()
    End Sub

    Public Sub sCheckIfThereAreFiles()
        Try
            Dim rowIndex As Integer
            Dim ArolCode As String
            Select Case CompEleControl.SelectedIndex
                Case 0
                    'CODIFICATI
                    rowIndex = dgvCEDBViewer.CurrentCell.RowIndex
                    ArolCode = dgvCEDBViewer.Rows(rowIndex).Cells(1).Value
                Case 1
                    'CONSUMABILI
                    rowIndex = dgvCSDBViewer.CurrentCell.RowIndex
                    ArolCode = dgvCSDBViewer.Rows(rowIndex).Cells(1).Value
                Case Else
                    Exit Sub
            End Select
            'Dim rowIndex As Integer = dgvCEDBViewer.CurrentCell.RowIndex
            'Dim ArolCode As String = dgvCEDBViewer.Rows(rowIndex).Cells(1).Value
            btnOpenFile.Visible = dbWarehouse.fLookIfHaveDataSheet(ArolCode, dbWarehouse.SQLConn, "codificatiDS", "Name")
            lblOpenDocs.Visible = btnOpenFile.Visible
        Catch ex As Exception
            MsgBox("ERRORE NELLA RICERCA DI DATASHEET", MsgBoxStyle.Critical)
            fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Sub
    Private Sub btnInsertNew_Click(sender As Object, e As EventArgs) Handles btnInsertNew.Click
        frmInsertNew.Show()
    End Sub
    Private Sub txtItemToFind_EnterButtonPressed(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtItemToFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            fFindElement()
        End If
    End Sub
    Public Sub fFindElement()
        Try
            'Test if item to Find textbox isn't empty
            If txtItemToFind.Text IsNot Nothing Then
                Dim tableName As String
                'Check which table control is selected
                Select Case CompEleControl.SelectedIndex
                    Case 0
                        tableName = "codificati"
                        'Call find function
                        Dim tempData As DataTable
                        tempData = dbWarehouse.fFindInDatabase(UCase(txtItemToFind.Text), dbWarehouse.SQLConn, tableName)
                        If tempData.Rows.Count > 0 Then
                            fPopulateAndResizeDGV(dgvCEDBViewer, tempData, CompEleControl.Width)
                        Else
                            dgvCEDBViewer.Visible = False
                            MsgBox("Nessuna occorrenza trovata", MsgBoxStyle.Information)
                        End If
                    Case 1
                        tableName = "consumabili"
                        'Call find function
                        Dim tempData As DataTable
                        tempData = dbWarehouse.fFindInDatabase(UCase(txtItemToFind.Text), dbWarehouse.SQLConn, tableName)
                        If tempData.Rows.Count > 0 Then
                            fPopulateAndResizeDGV(dgvCSDBViewer, tempData, CompEleControl.Width)
                        Else
                            dgvCSDBViewer.Visible = False
                            MsgBox("Nessuna occorrenza trovata", MsgBoxStyle.Information)
                        End If
                End Select
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELLA RICERCA SU DATABASE", MsgBoxStyle.Critical)
            fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Sub
    Private Sub btnChildGenerator_Click(sender As Object, e As EventArgs) Handles btnChildGenerator.Click
        Dim dsBackupFolder As String = Nothing
        Dim dsChildFolder As String = Nothing
        prgChildGeneration.Value = 0
        Try
            dsBackupFolder = xmlReader.fReadSingleNode("childBackupPath")
            dsChildFolder = RegularExpressions.Regex.Replace(xmlReader.fReadSingleNode("childPath"), """", "")
        Catch ex As Exception
            MsgBox("ERRORE NELLA LETTURA DEI PATH", MsgBoxStyle.Critical)
            fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
        End Try
        Dim strTempDateTime As String
        'Backup the current "Child file"
        With DateTime.Now
            strTempDateTime = (.Year & .Month & .Day & .Hour & .Minute & .Second)
        End With
        Try
            Dim strBackupPath As String = RegularExpressions.Regex.Replace(String.Concat(dsBackupFolder, "figli.", strTempDateTime, ".txt"), """", "")
            fCopyFromDirToDir(dsChildFolder, strBackupPath, True)
        Catch ex As Exception
            MsgBox("ERRORE NEL BACKUP DEL FILE FIGLI", MsgBoxStyle.Critical)
            fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
        End Try
        'Create the new "Child file"
        Dim sw As StreamWriter
        Dim strFileText As String
        Dim strTempQuery As String
        Dim dtTemp As New DataTable
        Dim i As Integer = 0
        Dim strNumOfElementCopy As String
        fCopyFromDirToDir(AppDomain.CurrentDomain.BaseDirectory & "Sources\figli.txt", dsChildFolder, False)
        'Execute query from Warehouse database
        Try
            strTempQuery = "SELECT * FROM codificati ORDER BY ArolCode"
            dtTemp = dbWarehouse.fExecuteGenericQuery(dbWarehouse.SQLConn, strTempQuery)
            prgChildGeneration.Maximum = dtTemp.Rows.Count
            strNumOfElementCopy = dtTemp.Rows.Count.ToString
        Catch ex As Exception
            MsgBox("ERRORE NELLA ESECUZIONE DELLA QUERY FIGLI", MsgBoxStyle.Critical)
            fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
        End Try
        'Populate the Child file
        Try
            sw = File.AppendText(dsChildFolder)
            For Each element In dtTemp.Rows
                strFileText = fCreateCodiciTxt(dtTemp.Rows(i)("ArolCode").ToString, dtTemp.Rows(i)("CommercialCode").ToString, dtTemp.Rows(i)("Description").ToString, dtTemp.Rows(i)("Manufacturer").ToString, dtTemp.Rows(i)("SupplementaryDescription").ToString)
                sw.WriteLine(strFileText)
                i = i + 1
                prgChildGeneration.Increment(1)
            Next
            sw.Close()
            sw.Dispose()
            MsgBox("FILE CREATO CON SUCCESSO!!", MsgBoxStyle.Exclamation)
        Catch ex As Exception
            MsgBox("ERRORE NELLA CREAZIONE DEL FILE FIGLI.txt", MsgBoxStyle.Critical)
            fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
        End Try
        'sw.Dispose()
        dtTemp.Dispose()
    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Check if user exist
        If fCheckIfUserExist(txtUserName.Text) Then
            'Check Password
            If fCheckPassword(txtUserName.Text, txtPassword.Text) Then
                'Check Write Permission
                Select Case fCheckWritePermission(txtUserName.Text)
                    Case 0
                        fApplyReaderOnlyPermission()
                    Case 1
                        fApplyWritePermission()
                    Case 2
                        fApplyAdvancedPermission()
                End Select
                lblUserLogged.Text = txtUserName.Text
                txtUserName.ResetText()
                txtPassword.ResetText()
            Else
                MsgBox("PASSWORD ERRATA!!", MsgBoxStyle.Exclamation)
                txtPassword.ResetText()
            End If
        Else
            If MsgBox("UTENTE NON PRESENTE, VUOI CREARLO?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If fCreateNewUser(txtUserName.Text, txtPassword.Text) Then
                    MsgBox("UTENTE INSERITO CORRETTAMENTE", MsgBoxStyle.Exclamation)
                End If
            End If
        End If
    End Sub
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            Select Case CompEleControl.SelectedIndex
                Case 0
                    'CODIFICATI
                    'Aggiorno l'elemento
                    With dgvCEDBViewer.Rows(iModifiedRowIndex)
                        Dim strPreviousString, strNewString As String
                        strPreviousString = fGenerateStringForEmail(iModifiedID, "codificati")
                        Dim tempBool As Boolean = fUpdateCodificatiElement(iModifiedID, .Cells(1).Value.ToString, .Cells(2).Value.ToString, .Cells(3).Value.ToString, .Cells(4).Value.ToString, .Cells(5).Value.ToString)
                        If tempBool Then
                            strNewString = fGenerateStringForEmail(iModifiedID, "codificati")
                            frmModDetails.Show()
                            frmModDetails.txtAfter.Text = strNewString
                            frmModDetails.txtPrevious.Text = strPreviousString
                        Else
                            MsgBox("AGGIORNAMENTO FALLITO!!", MsgBoxStyle.Critical)
                        End If
                    End With
                    dgvCEDBViewer.ReadOnly = True
                Case 1
                    'CONSUMABILI
                    With dgvCSDBViewer.Rows(iModifiedRowIndex)
                        Dim strPreviousString, strNewString As String
                        strPreviousString = fGenerateStringForEmail(iModifiedID, "consumabili")
                        Dim tempBool As Boolean = fUpdateConsumabiliElement(iModifiedID, .Cells(1).Value.ToString, .Cells(2).Value.ToString, .Cells(3).Value.ToString, .Cells(4).Value.ToString, .Cells(5).Value.ToString)
                        If tempBool Then
                            strNewString = fGenerateStringForEmail(iModifiedID, "consumabili")
                            frmModDetails.Show()
                            frmModDetails.txtAfter.Text = strNewString
                            frmModDetails.txtPrevious.Text = strPreviousString
                        Else
                            MsgBox("AGGIORNAMENTO FALLITO!!", MsgBoxStyle.Critical)
                        End If
                    End With
                Case Else
                    Exit Sub
            End Select
            btnConfirm.Enabled = False
            btnCancel.Enabled = False
        Catch ex As Exception
            MsgBox("ERRORE NELLA CONFERMA DELLA MODIFICA", MsgBoxStyle.Critical)
            fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Try
            'Recupero i vecchi dati
            Select Case CompEleControl.SelectedIndex
                Case 0
                    fUndoCodificatiModification(iModifiedID, iModifiedRowIndex)
                    dgvCEDBViewer.ReadOnly = True
                Case 1
                    fUndoConsumabiliModification(iModifiedID, iModifiedRowIndex)
                    dgvCSDBViewer.ReadOnly = True
                Case Else
            End Select
            btnCancel.Enabled = False
            btnConfirm.Enabled = False
        Catch ex As Exception
            MsgBox("ERRORE NELL'ANNULLAMENTO DELLA MODIFICA", MsgBoxStyle.Critical)
            fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Select Case CompEleControl.SelectedIndex
                Case 0
                    dgvCEDBViewer.ReadOnly = False
                Case 1
                    dgvCSDBViewer.ReadOnly = False
                Case Else
                    Exit Sub
            End Select
            'Abilito la scrittura
            'dgvCEDBViewer.ReadOnly = False
        Catch ex As Exception
            MsgBox("LA MEMORIA NON POTEVA ESSERE READ", MsgBoxStyle.Critical)
            fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Sub
    Private Sub dgvCEDBViewer_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCEDBViewer.CellValueChanged
        If bFormLoad Then
            Try
                iModifiedRowIndex = dgvCEDBViewer.CurrentCell.RowIndex
                iModifiedID = dgvCEDBViewer.Rows(iModifiedRowIndex).Cells(0).Value
                'Abilito i pulsanti di conferma/annulla modifica
                btnConfirm.Enabled = True
                btnCancel.Enabled = True
            Catch ex As Exception
                MsgBox("LA MEMORIA NON SI PUO' MEMORIZZARE", MsgBoxStyle.Critical)
                fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
            End Try
        End If
    End Sub
    Private Sub dgvCSDBViewer_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCSDBViewer.CellValueChanged
        If bFormLoad Then
            Try
                iModifiedRowIndex = dgvCSDBViewer.CurrentCell.RowIndex
                iModifiedID = dgvCSDBViewer.Rows(iModifiedRowIndex).Cells(0).Value
                'Abilito i pulsanti di conferma/annulla modifica
                btnConfirm.Enabled = True
                btnCancel.Enabled = True
            Catch ex As Exception
                MsgBox("LA MEMORIA NON SI PUO' MEMORIZZARE", MsgBoxStyle.Critical)
                fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
            End Try
        End If
    End Sub
    Private Sub txtFindACode_TextChanged(sender As Object, e As EventArgs) Handles txtFindACode.TextChanged
        fResearchAdvanced()
    End Sub
    Private Sub txtFindCCode_TextChanged(sender As Object, e As EventArgs) Handles txtFindCCode.TextChanged
        fResearchAdvanced()
    End Sub
    Private Sub txtFindDescr_TextChanged(sender As Object, e As EventArgs) Handles txtFindDescr.TextChanged
        fResearchAdvanced()
    End Sub
    Private Sub txtFindManufacturer_TextChanged(sender As Object, e As EventArgs) Handles txtFindManufacturer.TextChanged
        fResearchAdvanced()
    End Sub
    Private Sub txtFindSupDescr_TextChanged(sender As Object, e As EventArgs) Handles txtFindSupDescr.TextChanged
        fResearchAdvanced()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If MsgBox("SEI SICURO?", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
                Select Case CompEleControl.SelectedIndex
                    Case 0
                        'Recupero l'ID selezionato
                        Dim rowIndex As Integer = dgvCEDBViewer.CurrentCell.RowIndex
                        Dim deletedIndex As Integer = dgvCEDBViewer.Rows(rowIndex).Cells(0).Value
                        'Elimino l'elemento dal database
                        Dim tempBool As Boolean = fDeleteElement(deletedIndex, "codificati")
                        'Elimino l'elemento dal datagridview
                        If tempBool Then
                            fDeleteFromDGV(dgvCEDBViewer, rowIndex)
                        End If
                    Case 1
                        'Recupero l'ID selezionato
                        Dim rowIndex As Integer = dgvCSDBViewer.CurrentCell.RowIndex
                        Dim deletedIndex As Integer = dgvCSDBViewer.Rows(rowIndex).Cells(0).Value
                        'Elimino l'elemento dal database
                        Dim tempBool As Boolean = fDeleteElement(deletedIndex, "consumabili")
                        'Elimino l'elemento dal datagridview
                        If tempBool Then
                            fDeleteFromDGV(dgvCSDBViewer, rowIndex)
                        End If
                    Case Else
                        Exit Sub
                End Select
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELLA CANCELLAZIONE DELL'ELEMENTO", MsgBoxStyle.Critical)
            fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Sub
    Private Sub rbAdvancedSearch_CheckedChanged(sender As Object, e As EventArgs) Handles rbAdvancedSearch.CheckedChanged
        pnlAdvancedSearch.Enabled = rbAdvancedSearch.Checked
        If Not pnlAdvancedSearch.Enabled Then
            txtFindACode.Text = ""
            txtFindCCode.Text = ""
            txtFindDescr.Text = ""
            txtFindManufacturer.Text = ""
            txtFindSupDescr.Text = ""
            fResearchAdvanced()
        End If
    End Sub
    Private Sub rbSimpleSearch_CheckedChanged(sender As Object, e As EventArgs) Handles rbSimpleSearch.CheckedChanged
        pnlSimpleSearch.Enabled = rbSimpleSearch.Checked
        If Not pnlSimpleSearch.Enabled Then
            txtItemToFind.Text = ""
            fFindElement()
        End If
    End Sub
    Private Sub rbGuidedSearch_CheckedChanged(sender As Object, e As EventArgs) Handles rbGuidedSearch.CheckedChanged
        pnlGuidedSearch.Enabled = rbGuidedSearch.Checked
        cbxSearchCategory.Text = "Seleziona la categoria..."
        cbxSearchManufacturer.Text = "Seleziona il costruttore..."
        Select Case CompEleControl.SelectedIndex
            Case 0
                cbxSearchCategory.Enabled = True
                cbxSearchManufacturer.Enabled = True
                btnGuideSearch.Enabled = True
            Case 1
                cbxSearchCategory.Enabled = False
                cbxSearchManufacturer.Enabled = True
                btnGuideSearch.Enabled = False
            Case Else
                Exit Sub
        End Select
        If pnlGuidedSearch.Enabled Then
            'Populate comboBoxes
            fPopulateGuidedSearchComboBoxes()
        Else
            txtItemToFind.Text = ""
            fFindElement()
        End If
    End Sub
    Private Sub cbxSearchCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSearchCategory.SelectedIndexChanged
        fResetComboGuidedSearch()
        Dim strTempCategory As String
        Dim strTempManufacturer As String
        If cbxSearchCategory.SelectedItem Is Nothing Then
            strTempCategory = ""
        Else
            strTempCategory = cbxSearchCategory.SelectedItem.ToString
        End If
        If cbxSearchManufacturer.SelectedItem Is Nothing Then
            strTempManufacturer = ""
        Else
            strTempManufacturer = cbxSearchManufacturer.SelectedItem.ToString
        End If
        Dim tableName As String
        Dim selectedDGV As DataGridView
        Select Case CompEleControl.SelectedIndex
            Case 0
                tableName = "codificati"
                selectedDGV = dgvCEDBViewer
            Case 1
                tableName = "consumabili"
                selectedDGV = dgvCSDBViewer
            Case Else
                Exit Sub
        End Select
        Dim tempDataTable As DataTable = fGuideSearchCategory(tableName, "ArolCode", strTempCategory, strTempManufacturer, "ArolCode", dbWarehouse.SQLConn, bGuidedSearchAnd)
        fPopulateAndResizeDGV(selectedDGV, tempDataTable, CompEleControl.Width)
    End Sub
    Public Sub fResetComboGuidedSearch()
        If Not bGuidedSearchAnd Then
            cbxSearchManufacturer.Text = "Seleziona il costruttore..."
            cbxSearchCategory.Text = "Seleziona la categoria..."
        End If
    End Sub
    Private Sub cbxSearchManufacturer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxSearchManufacturer.SelectedIndexChanged
        fResetComboGuidedSearch()
        Dim strTempCategory As String
        Dim strTempManufacturer As String
        If cbxSearchCategory.SelectedItem Is Nothing Then
            strTempCategory = ""
        Else
            strTempCategory = cbxSearchCategory.SelectedItem.ToString
        End If
        If cbxSearchManufacturer.SelectedItem Is Nothing Then
            strTempManufacturer = ""
        Else
            strTempManufacturer = cbxSearchManufacturer.SelectedItem.ToString
        End If
        Dim tableName As String
        Dim selectedDGV As DataGridView
        Select Case CompEleControl.SelectedIndex
            Case 0
                tableName = "codificati"
                selectedDGV = dgvCEDBViewer
            Case 1
                tableName = "consumabili"
                selectedDGV = dgvCSDBViewer
            Case Else
                Exit Sub
        End Select
        Dim tempDataTable As DataTable = fGuideSearchManufacturer(tableName, strTempManufacturer, strTempCategory, "ArolCode", dbWarehouse.SQLConn, bGuidedSearchAnd)
        fPopulateAndResizeDGV(selectedDGV, tempDataTable, CompEleControl.Width)
    End Sub
    Private Sub txtItemToFind_TextChanged(sender As Object, e As EventArgs) Handles txtItemToFind.TextChanged
        fFindElement()
    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.lblRevision.Text = "Xplorer 1.0.5.6"
        frmAbout.lblIssuedDate.Text = "11/04/2018"
        frmAbout.TopMost = True
        frmAbout.Show()
    End Sub
    'Private Sub AggiornaDatasheetToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    If bUserWritePerm Then
    '        Dim tempCodificati As DataTable
    '        Dim strTempQuery As String = "SELECT * FROM codificati"
    '        tempCodificati = dbWarehouse.fExecuteGenericQuery(dbWarehouse.SQLConn, strTempQuery)
    '        Dim i As Integer = 0
    '        For Each element In tempCodificati.Rows
    '            Dim tempContenuto As Integer
    '            If dbWarehouse.fCheckIfAlreadyExist(tempCodificati.Rows(i)("ArolCode").ToString, dbWarehouse.SQLConn, "codificatiDS", "Name") Then
    '                tempContenuto = 1
    '            Else
    '                tempContenuto = 0
    '            End If
    '            strTempQuery = "UPDATE codificati SET Datasheet = " & tempContenuto & " WHERE ArolCode = '" & tempCodificati.Rows(i)("ArolCode") & "'"
    '            dbWarehouse.fExecuteGenericQuery(dbWarehouse.SQLConn, strTempQuery)
    '            i = i + 1
    '        Next
    '    Else
    '        MsgBox("IL TUO UTENTE NON HA I PERMESSI PER FARLO", MsgBoxStyle.OkOnly)
    '    End If
    'End Sub

    Private Sub ManageUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageUserToolStripMenuItem.Click
        If bManageUser Then
            frmUserManagement.Show()
        Else
            MsgBox("IL TUO UTENTE NON HA I PERMESSI PER FARLO", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub btnGuideSearch_Click(sender As Object, e As EventArgs) Handles btnGuideSearch.Click
        If btnGuideSearch.Text = "OR" Then
            btnGuideSearch.Text = "AND"
            bGuidedSearchAnd = True
        Else
            btnGuideSearch.Text = "OR"
            bGuidedSearchAnd = False
        End If
    End Sub
    Private Sub btnReadFromFile_Click(sender As Object, e As EventArgs) Handles btnReadFromFile.Click
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If fCheckEstensione(OpenFileDialog1.FileName, ".txt") Then
                If fReadAllFileReturnDataTable(OpenFileDialog1.FileName) IsNot Nothing Then
                    'Backup the Warehouse database
                    Dim strConfigDBBackupPath As String = xmlReader.fReadSingleNode("dbBackupPath")
                    Dim strDBOriginalPath As String = RegularExpressions.Regex.Replace(xmlReader.fReadSingleNode("dbPath"), """", "")
                    Dim strTempDateTime As String
                    With DateTime.Now
                        strTempDateTime = (.Year & .Month & .Day & .Hour & .Minute & .Second)
                    End With
                    Try
                        Dim strDBBackupPath As String = RegularExpressions.Regex.Replace(String.Concat(strConfigDBBackupPath, ".", strTempDateTime, ".db"), """", "")
                        fCopyFromDirToDir(strDBOriginalPath, strDBBackupPath, False)
                    Catch ex As Exception
                        MsgBox("ERRORE NEL BACKUP DEL DATABASE", MsgBoxStyle.Critical)
                        fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
                    End Try
                    If dbWarehouse.fDeleteAllFromTable(dbWarehouse.SQLConn, "codificati") Then
                        dbWarehouse.fWriteFromChildDataTable(dbWarehouse.SQLConn, "codificati", fReadAllFileReturnDataTable(OpenFileDialog1.FileName))
                    Else
                        Exit Sub
                    End If
                Else
                    Exit Sub
                End If
            Else
                MsgBox("ESTENSIONE FILE NON CORRETTA!! ATTESO TXT FILE", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
    Public Sub fPopulateDataGridView()
        Dim tableName As String
        'Check which table control is selected
        Select Case CompEleControl.SelectedIndex
            Case 0
                tableName = "codificati"
                'Call find function
                Dim tempData As DataTable
                tempData = dbWarehouse.fFindInDatabase(UCase(txtItemToFind.Text), dbWarehouse.SQLConn, tableName)
                If tempData.Rows.Count > 0 Then
                    fPopulateAndResizeDGV(dgvCEDBViewer, tempData, CompEleControl.Width)
                Else
                    dgvCEDBViewer.Visible = False
                    MsgBox("Nessuna occorrenza trovata", MsgBoxStyle.Information)
                End If
            Case 1
                tableName = "consumabili"
                'Call find function
                Dim tempData As DataTable
                tempData = dbWarehouse.fFindInDatabase(UCase(txtItemToFind.Text), dbWarehouse.SQLConn, tableName)
                If tempData.Rows.Count > 0 Then
                    fPopulateAndResizeDGV(dgvCSDBViewer, tempData, CompEleControl.Width)
                Else
                    dgvCSDBViewer.Visible = False
                    MsgBox("Nessuna occorrenza trovata", MsgBoxStyle.Information)
                End If
        End Select
    End Sub
    Private Sub CompEleControl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CompEleControl.SelectedIndexChanged
        fPopulateDataGridView()
        If rbGuidedSearch.Checked Then
            fResetComboGuidedSearch()
            fPopulateGuidedSearchComboBoxes()
        End If
        Select Case CompEleControl.SelectedIndex
            Case 0
                cbxSearchCategory.Enabled = True
                cbxSearchManufacturer.Enabled = True
                btnGuideSearch.Enabled = True
            Case 1
                cbxSearchCategory.Enabled = False
                cbxSearchManufacturer.Enabled = True
                btnGuideSearch.Enabled = False
        End Select
    End Sub

    Private Sub NewManufacturerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewManufacturerToolStripMenuItem.Click
        If bUserWritePerm Then
            Dim strNewManufacturer As String
            Dim strDBPath As String = xmlReader.fReadSingleNode("dbRulesPath")
            Dim strConfigDBBackupPath As String = xmlReader.fReadSingleNode("dbRulesBackupPath")
            Dim strTempDateTime As String
            Dim dbCodingRules As DBManagement = New DBManagement
            strNewManufacturer = InputBox("INSERIRE IL NOME DEL COSTRUTTORE", "NUOVO COSTRUTTORE")
            If strNewManufacturer <> "" Then
                'Check if Len is correct
                If Len(strNewManufacturer) > 12 Then
                    MsgBox("NOME COSTRUTTORE TROPPO LUNGO (MAX. 12 CARATTERI)", MsgBoxStyle.Critical)
                    Exit Sub
                End If
                'Backup the Rules database
                With DateTime.Now
                    strTempDateTime = (.Year & .Month & .Day & .Hour & .Minute & .Second)
                End With
                Try
                    Dim strDBBackupPath As String = RegularExpressions.Regex.Replace(String.Concat(strConfigDBBackupPath, ".", strTempDateTime, ".db"), """", "")
                    fCopyFromDirToDir(strDBPath, strDBBackupPath, False)
                Catch ex As Exception
                    MsgBox("ERRORE NEL BACKUP DEL DATABASE", MsgBoxStyle.Critical)
                    fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
                End Try
                'Connect to database and check connection status
                Try
                    dbCodingRules.fConnection("Data Source =" & strDBPath & ";Version = 3")
                Catch ex As Exception
                    MsgBox("ERRORE NELLA CONNESSIONE AL DATABASE DELLE REGOLE DI CODIFICA", MsgBoxStyle.Critical)
                    fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
                End Try
                'Add the new element to the database
                Try
                    Dim strGenericQuery As String = "INSERT INTO tbSupplier (SUPPLIER) VALUES ('" & strNewManufacturer & "')"
                    dbCodingRules.fExecuteGenericInsert(dbCodingRules.SQLConn, strGenericQuery)
                    MsgBox("INSERIMENTO COMPLETATO CON SUCCESSO!!", MsgBoxStyle.Exclamation)
                Catch ex As Exception
                    MsgBox("ERRORE NELL'INSERIMENTO DEL NUOVO COSTRUTTORE", MsgBoxStyle.Critical)
                    fAddLogRow(strLogFilePath, "Utente: " & ex.ToString)
                End Try
            Else
                Exit Sub
            End If
        Else
            MsgBox("IL TUO UTENTE NON HA I PERMESSI PER FARLO", MsgBoxStyle.OkOnly)
        End If
    End Sub
    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        frmChangePassword.Show()
    End Sub

    Private Sub btnToCSV_Click(sender As Object, e As EventArgs) Handles btnToCSV.Click
        fWriteToCsv()
    End Sub
End Class
