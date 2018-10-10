Imports System.IO, System.Text
Public Class frmInsertNew
    Public dbCodingRules As DBManagement = New DBManagement
    Public xmlReader As XMLReader = New XMLReader
    Dim lblDescrField(7) As Label
    Dim bInitDescrField As Boolean = False
    Dim bComboInit As Boolean = False
    Dim bArolCodeUpperPartNotValid As Boolean = False
    Dim bArolCodeNotValid As Boolean = False
    Dim bCommercialCodeNotValid As Boolean = False
    Dim bConstructorNotValid As Boolean = False
    Dim bDescriptionNotValid As Boolean = False
    Dim bSuppDescriptionNotValid As Boolean = False
    Dim bInitTxtFile As Boolean = False
    Dim txtField(7) As TextBox
    Dim cmbField(7) As ComboBox
    Dim lblField(7) As Label
    Dim lblPrefisso(7) As Label
    Dim lblSuffisso(7) As Label
    Dim astrSeparatore(7) As String
    Dim astrFieldDescr(16) As String
    Public strFilePath As String
    Private Sub frmInsertNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strDBPath As String = xmlReader.fReadSingleNode("dbRulesPath")
        Dim strConfigDBBackupPath As String = xmlReader.fReadSingleNode("dbBackupPath")
        Dim strDBOriginalPath As String = RegularExpressions.Regex.Replace(xmlReader.fReadSingleNode("dbPath"), """", "")
        Dim dtCategory As New DataTable
        Dim dtTemp As New DataTable
        Dim strTempQuery As String
        Dim strTempDateTime As String
        btnCreaFileTxt.Enabled = False
        btnInsertNew.Enabled = False
        'Inizializzo le textBoxes
        clearAndResetTextBoxes()
        'Select materiale a commessa
        rdbMatComm.Select()
        'Select famiglia di componenti
        rdbFamComponente.Select()
        readOnlyField(True)
        'Backup the Warehouse database
        With DateTime.Now
            strTempDateTime = (.Year & .Month & .Day & .Hour & .Minute & .Second)
        End With
        Try
            Dim strDBBackupPath As String = RegularExpressions.Regex.Replace(String.Concat(strConfigDBBackupPath, ".", strTempDateTime, ".db"), """", "")
            fCopyFromDirToDir(strDBOriginalPath, strDBBackupPath, False)
        Catch ex As Exception
            MsgBox("ERRORE NEL BACKUP DEL DATABASE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
        'Connect to database and check connection status
        Try
            dbCodingRules.fConnection("Data Source =" & strDBPath & ";Version = 3")
        Catch ex As Exception
            MsgBox("ERRORE NELLA CONNESSIONE AL DATABASE DELLE REGOLE DI CODIFICA", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
        Try
            dtCategory = dbCodingRules.fSelectAndOrderAllInDatabase(dbCodingRules.SQLConn, "tbArticlesCategory", "Category", "Category")
        Catch ex As Exception
            MsgBox("ERRORE NELLA ESECUZIONE DELLA QUERY DI RICERCA DELLE CATEGORIE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
        Try
            strTempQuery = "SELECT * FROM tbSupplier ORDER BY SUPPLIER"
            dtTemp = dbCodingRules.fExecuteGenericQuery(dbCodingRules.SQLConn, strTempQuery)
        Catch ex As Exception
            MsgBox("ERRORE NELLA ESECUZIONE DELLA QUERY DI RICERCA DEI COSTRUTTORI", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
        'Populate costructor combobox object
        Try
            For i As Integer = 1 To dtTemp.Rows.Count - 1
                cbxConstructor.Items.Add(dtTemp.Rows(i)("SUPPLIER"))
            Next
        Catch ex As Exception
            MsgBox("ERRORE NEL POPOLAMENTO DELLA COMBO COSTRUTTORI", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
        'Populate item category combobox object
        Try
            For i As Integer = 0 To dtCategory.Rows.Count - 1
                cbxCompFamily.Items.Add(dtCategory.Rows(i)(0))
            Next
        Catch ex As Exception
            MsgBox("ERRORE NEL POPOLAMENTO DELLA COMBO CATEGORIE ", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
        dtCategory.Dispose()
        dtTemp.Dispose()
    End Sub
    Private Sub cbxCompFamily_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCompFamily.SelectedIndexChanged
        Try
            Dim dtArolCategoryIDs As New DataTable
            Dim dtCombo As New DataTable
            Dim dtLabel As New DataTable
            Dim dtSeparatore As New DataTable
            Dim idArolCategory As Integer
            Dim j As Integer = 0
            Dim k As Integer = 0
            bComboInit = False
            btnInsertNew.Enabled = False
            clearAndResetTextBoxes()
            cbxAddDatasheet.CheckState = CheckState.Unchecked
            checkArolCode()
            checkCommercialCode()
            checkConstructor()
            If Not bInitDescrField Then
                For i = 0 To 6
                    lblDescrField(i) = New Label
                    txtField(i) = New TextBox
                    cmbField(i) = New ComboBox
                    lblField(i) = New Label
                    lblPrefisso(i) = New Label
                    lblSuffisso(i) = New Label
                    bInitDescrField = True
                    cmbField(i).Items.Clear()
                Next
            End If
            clearPanelFour()
            dtArolCategoryIDs = dbCodingRules.fSelectElementFromColumn(dbCodingRules.SQLConn, "tbArticlesCategory", "Category", "Category", cbxCompFamily.SelectedItem.ToString)
            If dtArolCategoryIDs.Rows.Count > 1 Then
                MsgBox("ERRORE, NOME DUPLICATO!!", MsgBoxStyle.Critical)
            Else
                idArolCategory = Convert.ToInt32(dtArolCategoryIDs.Rows(0)("ID"))
                txtDescrExample.Text = dtArolCategoryIDs.Rows(0)("Example")
            End If
            Dim dtTemp As New DataTable
            Dim strTempQuery As String
            strTempQuery = "SELECT Code FROM tbArolCodeLookUp JOIN tbArolCode on tbArolCode.ID = tbArolCodeLookUp.IDArolCode WHERE tbArolCodeLookUp.IDCategory = " & idArolCategory.ToString
            dtTemp = dbCodingRules.fExecuteGenericQuery(dbCodingRules.SQLConn, strTempQuery)
            If dtTemp.Rows.Count <> 0 Then
                txtCode.Text = dtTemp.Rows(0)("Code")
            Else
                MsgBox("REGOLA NON DEFINITA", MsgBoxStyle.Information)
            End If
            strTempQuery = "SELECT * FROM tbMainTable WHERE IDCategory = " & idArolCategory.ToString
            dtTemp = dbCodingRules.fExecuteGenericQuery(dbCodingRules.SQLConn, strTempQuery)
            If dtTemp.Rows.Count > 0 Then
                txtDescription.Text = Nothing
                k = 0
                For i = 0 To dtTemp.Rows.Count - 1
                    Panel6.Controls.Add(lblDescrField(i))
                    lblDescrField(i).Name = "lblDescrField" & i
                    lblDescrField(i).Size = New Drawing.Size(193, 13)
                    lblDescrField(i).Visible = True
                    strTempQuery = "SELECT * FROM tbTitolo WHERE ID = " & dtTemp.Rows(i)("IDTitolo").ToString
                    dtLabel = dbCodingRules.fExecuteGenericQuery(dbCodingRules.SQLConn, strTempQuery)
                    If IsDBNull(dtLabel.Rows(0)("Titolo")) Then
                        lblDescrField(i).Text = ""
                    Else
                        lblDescrField(i).Text = dtLabel.Rows(0)("Titolo")
                    End If
                    If i <= 2 Then
                        lblDescrField(i).Location = New Point(i * 420 + 184, 44)
                    Else
                        lblDescrField(i).Location = New Point((i - 3) * 420 + 90, 110)
                    End If

                    lblDescrField(i).TextAlign = ContentAlignment.MiddleCenter
                    Select Case dtTemp.Rows(i)("IDTipo")
                        Case 1
                            AddHandler txtField(i).TextChanged, AddressOf textField_TextChanged
                            Panel6.Controls.Add(txtField(i))
                            txtField(i).Name = "txtField" & i
                            If i <= 2 Then
                                txtField(i).Location = New Point(i * 420 + 184, 60)
                            Else
                                txtField(i).Location = New Point((i - 3) * 420 + 90, 126)
                            End If
                            txtField(i).Size = New Drawing.Size(193, 13)
                            txtField(i).TextAlign = HorizontalAlignment.Right
                            txtField(i).Visible = True
                        Case 2
                            strTempQuery = "SELECT * FROM tbComboLookUp INNER JOIN tbLookUpCBX ON tbLookUpCBX.ID = tbComboLookUp.IDLookUpCBX WHERE tbComboLookUp.IDMainTable = " & dtTemp.Rows(i)("ID").ToString
                            dtCombo = dbCodingRules.fExecuteGenericQuery(dbCodingRules.SQLConn, strTempQuery)
                            AddHandler cmbField(i).SelectedValueChanged, AddressOf cmbField_SelectionChanged
                            Panel6.Controls.Add(cmbField(i))
                            cmbField(i).Name = "cmbField" & i
                            If i <= 2 Then
                                cmbField(i).Location = New Point(i * 420 + 184, 60)
                            Else
                                cmbField(i).Location = New Point((i - 3) * 420 + 90, 126)
                            End If
                            cmbField(i).Size = New Drawing.Size(193, 13)
                            cmbField(i).Visible = True
                            For j = 0 To dtCombo.Rows.Count - 1
                                cmbField(i).Items.Add(dtCombo.Rows(j)("Text"))
                            Next
                    End Select
                    If Not (IsDBNull(dtTemp.Rows(i)("IDPrefisso"))) Then
                        strTempQuery = "SELECT * FROM tbPrefisso WHERE tbPrefisso.ID = " & dtTemp.Rows(i)("IDPrefisso").ToString
                        dtLabel = dbCodingRules.fExecuteGenericQuery(dbCodingRules.SQLConn, strTempQuery)
                        If dtLabel.Rows.Count > 0 Then
                            Panel6.Controls.Add(lblPrefisso(i))
                            lblPrefisso(i).Name = "lblPrefisso" & i
                            If i <= 2 Then
                                lblPrefisso(i).Location = New Point(i * 420 + 96, 60)
                            Else
                                lblPrefisso(i).Location = New Point((i - 3) * 420 + 11, 126)
                            End If
                            lblPrefisso(i).Size = New Drawing.Size(82, 13)
                            lblPrefisso(i).Text = dtLabel(0)("TEXT")
                            lblPrefisso(i).Visible = True
                            lblPrefisso(i).TextAlign = ContentAlignment.BottomRight
                        End If
                    End If
                    If Not (IsDBNull(dtTemp.Rows(i)("IDSuffisso"))) Then
                        strTempQuery = "SELECT * FROM tbSuffisso WHERE tbSuffisso.ID = " & dtTemp.Rows(i)("IDSuffisso").ToString
                        dtLabel = dbCodingRules.fExecuteGenericQuery(dbCodingRules.SQLConn, strTempQuery)
                        If dtLabel.Rows.Count > 0 Then
                            Panel6.Controls.Add(lblSuffisso(i))
                            lblSuffisso(i).Name = "lblSuffisso" & i
                            If i <= 2 Then
                                lblSuffisso(i).Location = New Point(i * 420 + 383, 60)
                            Else
                                lblSuffisso(i).Location = New Point((i - 3) * 420 + 298, 126)
                            End If
                            lblSuffisso(i).Size = New Drawing.Size(80, 13)
                            lblSuffisso(i).Text = dtLabel(0)("TEXT")
                            lblSuffisso(i).Visible = True
                            lblSuffisso(i).TextAlign = ContentAlignment.BottomLeft
                        End If
                    End If
                    If Not (IsDBNull(dtTemp.Rows(i)("IDSeparatore"))) Then
                        strTempQuery = "SELECT * FROM tbSeparatore WHERE tbSeparatore.ID = " & dtTemp.Rows(i)("IDSeparatore").ToString
                        dtSeparatore = dbCodingRules.fExecuteGenericQuery(dbCodingRules.SQLConn, strTempQuery)
                        If dtSeparatore.Rows.Count > 0 Then
                            If dtSeparatore(0)("TEXT").ToString = "SPAZIO" Then
                                astrSeparatore(i) = " "
                            Else
                                astrSeparatore(i) = dtSeparatore(0)("TEXT")
                            End If
                        End If
                    End If
                Next
                If (dtTemp.Rows.Count - 1) < 6 Then
                    For i = dtTemp.Rows.Count To 6
                        lblDescrField(i).Visible = False
                        txtField(i).Visible = False
                        cmbField(i).Visible = False
                        lblField(i).Visible = False
                        lblPrefisso(i).Visible = False
                        lblSuffisso(i).Visible = False
                    Next
                End If
            End If
            strTempQuery = "SELECT Text FROM tbDescrizione WHERE ID = " & dtTemp.Rows(0)("IDDescrizione").ToString
            dtTemp = dbCodingRules.fExecuteGenericQuery(dbCodingRules.SQLConn, strTempQuery)
            astrFieldDescr(0) = dtTemp.Rows(0)("Text").ToString
            dtArolCategoryIDs.Dispose()
            dtCombo.Dispose()
            dtLabel.Dispose()
            dtSeparatore.Dispose()
            dtTemp.Dispose()
            bArolCodeNotValid = True
            bCommercialCodeNotValid = True
            bDescriptionNotValid = True
            bConstructorNotValid = True
            txtDescription.BackColor = Color.Red
        Catch ex As Exception
            MsgBox("ERRORE NELLA INIZIALIZZAZIONE DEL FORM DI INSERIMENTO", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Sub
    Friend Sub textField_TextChanged(sender As Object, e As EventArgs)
        descriptionBuild()
        checkDescription()
    End Sub
    Friend Sub cmbField_SelectionChanged(sender As Object, e As EventArgs)
        descriptionBuild()
        checkDescription()
    End Sub
    Public Sub descriptionBuild()
        Try
            For i = 1 To 16
                astrFieldDescr(i) = Nothing
            Next
            Dim j As Integer = 0
            For i = 1 To 16 Step 4
                astrFieldDescr(i) = lblPrefisso(j).Text
                If txtField(j).Visible Then
                    astrFieldDescr(i + 1) = txtField(j).Text
                ElseIf cmbField(j).Visible Then
                    astrFieldDescr(i + 1) = cmbField(j).Text
                ElseIf lblField(j).Visible Then
                    astrFieldDescr(i + 1) = lblField(j).Text
                End If
                astrFieldDescr(i + 2) = lblSuffisso(j).Text
                astrFieldDescr(i + 3) = astrSeparatore(j)
                j = j + 1
            Next
            fDescriptionConstructorV2(astrFieldDescr)
        Catch ex As Exception
            MsgBox("ERRORE NELLA CREAZIONE DELLA STRINGA DI DESCRIZIONE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Sub
    Public Sub checkArolCode()
        Dim strTableName As String = checkMatCommConsumo()
        bArolCodeNotValid = frmMain.dbWarehouse.fCheckIfAlreadyExist(txtCode.Text & txtLowCode.Text, frmMain.dbWarehouse.SQLConn, strTableName, "ArolCode") Or Len(txtLowCode.Text) <> 3
        If bArolCodeNotValid Then
            txtLowCode.BackColor = Color.Red
        Else
            txtLowCode.BackColor = Color.LightGreen
        End If
    End Sub
    Public Sub checkArolCodeUpperPart()
        If Not txtCode.ReadOnly Then
            If Len(txtCode.Text) <> 9 Then
                txtCode.BackColor = Color.Red
                bArolCodeUpperPartNotValid = True
            Else
                txtCode.BackColor = Color.LightGreen
                bArolCodeUpperPartNotValid = False
            End If
        Else
            txtCode.BackColor = Color.Gainsboro
            bArolCodeUpperPartNotValid = False
        End If
    End Sub
    Public Sub checkCommercialCode()
        Dim strTableName As String = checkMatCommConsumo()
        bCommercialCodeNotValid = frmMain.dbWarehouse.fCheckIfAlreadyExist(txtCommercialCode.Text, frmMain.dbWarehouse.SQLConn, strTableName, "CommercialCode") Or Len(txtCommercialCode.Text) > 18 Or
                                  Len(txtCommercialCode.Text) = 0
        If bCommercialCodeNotValid Then
            txtCommercialCode.BackColor = Color.Red
        Else
            txtCommercialCode.BackColor = Color.LightGreen
        End If
    End Sub
    Public Sub checkConstructor()
        If cbxConstructor.SelectedIndex >= 0 Then
            bConstructorNotValid = Len(cbxConstructor.SelectedItem.ToString) = 0
        Else
            bConstructorNotValid = True
        End If
        If bConstructorNotValid Then
            cbxConstructor.BackColor = Color.Red
        Else
            cbxConstructor.BackColor = Color.LightGreen
        End If
    End Sub
    Public Sub checkDescription()
        bDescriptionNotValid = Len(txtDescription.Text) = 0 Or Len(txtDescription.Text) > 40
        If bDescriptionNotValid Then
            txtDescription.BackColor = Color.Red
        Else
            txtDescription.BackColor = Color.LightGreen
        End If
    End Sub
    Public Sub checkNewCode()
        If Not bArolCodeNotValid And Not bCommercialCodeNotValid And Not bDescriptionNotValid And Not bConstructorNotValid And Not bArolCodeUpperPartNotValid Then
            btnInsertNew.Enabled = True
        Else
            btnInsertNew.Enabled = False
        End If
    End Sub
    Private Sub txtLowCode_TextChanged(sender As Object, e As EventArgs) Handles txtLowCode.TextChanged
        btnInsertNew.Enabled = False
        If Len(txtLowCode.Text) > 3 Then
            txtLowCode.Text = LSet(txtLowCode.Text, 3)
        End If
        checkArolCode()
        checkNewCode()
    End Sub
    Private Sub txtCommercialCode_TextChanged(sender As Object, e As EventArgs) Handles txtCommercialCode.TextChanged
        btnInsertNew.Enabled = False
        If Len(txtCommercialCode.Text) > 18 Then
            txtCommercialCode.Text = LSet(txtCommercialCode.Text, 18)
        End If
        checkCommercialCode()
        checkNewCode()
    End Sub
    Private Sub txtSuppDescription_TextChanged(sender As Object, e As EventArgs) Handles txtSuppDescription.TextChanged
        btnInsertNew.Enabled = False
        If Len(txtSuppDescription.Text) > 400 Then
            txtSuppDescription.Text = LSet(txtSuppDescription.Text, 400)
        End If
        checkNewCode()
    End Sub
    Private Sub btnCreaFileTxt_Click(sender As Object, e As EventArgs) Handles btnCreaFileTxt.Click
        Try
            Dim sw As StreamWriter
            Dim strFileText As String
            If Not bInitTxtFile Then
                brwFolderDialog.Description = "SELEZIONA IL PERCORSO DOVE SALVARE IL FILE CODICI.TXT"
                brwFolderDialog.ShowDialog()
                strFilePath = Path.GetFullPath(brwFolderDialog.SelectedPath) & "\CODICI.txt"
                fCopyFromDirToDir(AppDomain.CurrentDomain.BaseDirectory & "Sources\CODICI.txt", strFilePath, False)
                bInitTxtFile = True
            End If
            strFileText = fCreateCodiciTxt(txtCode.Text & txtLowCode.Text, txtCommercialCode.Text, txtDescription.Text, cbxConstructor.SelectedItem.ToString, txtSuppDescription.Text)
            sw = File.AppendText(strFilePath)
            sw.WriteLine(strFileText)
            sw.Close()
            clearAll()
            clearPanelFour()
        Catch ex As Exception
            MsgBox("ERRORE NELLA CREAZIONE DEL FILE CODICI.TXT", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Sub
    Private Sub btnInsertNew_Click(sender As Object, e As EventArgs) Handles btnInsertNew.Click
        Try
            checkArolCode()
            checkCommercialCode()
            checkDescription()
            checkConstructor()
            checkNewCode()
            Dim strArolCode As String
            Dim strCommercialCode As String
            Dim strDescription As String
            Dim strManufacturer As String
            Dim strSupplementaryDescription As String
            Dim strDestFilePath As String
            Dim dsDestFolder As String = xmlReader.fReadSingleNode("dsDestFolder")
            strArolCode = UCase(txtCode.Text & txtLowCode.Text)
            strCommercialCode = UCase(txtCommercialCode.Text)
            strDescription = UCase(txtDescription.Text)
            strManufacturer = UCase(cbxConstructor.SelectedItem.ToString)
            strSupplementaryDescription = UCase(txtSuppDescription.Text)
            Dim strTableName As String
            strTableName = checkMatCommConsumo()
            frmMain.dbWarehouse.fInsertNewComponent(frmMain.dbWarehouse.SQLConn, strTableName, strArolCode, strCommercialCode, strDescription, strManufacturer, strSupplementaryDescription)
            If cbxAddDatasheet.Checked Then
                strDestFilePath = dsDestFolder & strArolCode & txtFileExtension.Text
                fCopyFromDirToDir(txtFileDSPath.Text, strDestFilePath, False)
                frmMain.dbWarehouse.fInsertDatasheetInDatabase(strArolCode, txtFileExtension.Text, strDestFilePath, frmMain.dbWarehouse.SQLConn, "codificatiDS")
            End If
            btnInsertNew.Enabled = False
            btnCreaFileTxt.Enabled = True
            Dim strRichiestoDa, strNote, strTipoParte, strPuntoLotto, strPuntoRiordino, strScortaSicurezza, strStato, strTableNameExtended As String
            txtDataInserimento.Text = Date.Now.Day & "/" & Date.Now.Month & "/" & Date.Now.Year
            txtInseritoDa.Text = frmMain.strUsername
            strRichiestoDa = txtRichiestoDa.Text
            strNote = txtNote.Text
            strTipoParte = txtTipoParte.Text
            strPuntoLotto = txtPuntoLotto.Text
            strPuntoRiordino = txtPuntoRiordino.Text
            strScortaSicurezza = txtScortaSicurezza.Text
            strStato = "0"
            Select Case strTableName
                Case "codificati"
                    strTableNameExtended = "datiEstesiCodificati"
                Case "consumabili"
                    strTableNameExtended = "datiEstesiConsumabili"
                Case Else
                    Exit Sub
            End Select
            frmMain.dbWarehouse.fInsertNewExtendedData(frmMain.dbWarehouse.SQLConn, strTableNameExtended, strArolCode, strStato, txtDataInserimento.Text, txtInseritoDa.Text, strRichiestoDa, strNote, strTipoParte, strPuntoLotto, strPuntoRiordino, strScortaSicurezza)
        Catch ex As Exception
            MsgBox("ERRORE NELL'INSERIMENTO DI UN NUOVO ELEMENTO", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Sub
    Private Sub cbxAddDatasheet_CheckedChanged(sender As Object, e As EventArgs) Handles cbxAddDatasheet.CheckedChanged
        Try
            If cbxAddDatasheet.Checked Then
                brwFileDialog.ShowDialog()
                txtFileDSPath.Text = Path.GetFullPath(brwFileDialog.FileName)
                txtFileExtension.Text = Path.GetExtension(txtFileDSPath.Text)
            Else
                txtFileDSPath.Text = Nothing
            End If
        Catch ex As Exception
            MsgBox("ERRORE NEL RECUPERO DEL PERCORSO DEL DATASHEET", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Sub
    Private Sub cbxConstructor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxConstructor.SelectedIndexChanged
        btnInsertNew.Enabled = False
        If Len(cbxConstructor.SelectedItem.ToString) > 12 Then
            'txtCostructor.Text = LSet(txtCostructor.Text, 12)
        End If
        checkConstructor()
        checkNewCode()
    End Sub
    Private Sub btnLockUnlockDescr_Click(sender As Object, e As EventArgs) Handles btnLockUnlockDescr.Click
        If txtDescription.ReadOnly Then
            txtDescription.ReadOnly = False
            checkDescription()
            btnLockUnlockDescr.BackgroundImage = My.Resources.lock
        Else
            txtDescription.ReadOnly = True
            btnLockUnlockDescr.BackgroundImage = My.Resources.unlock
        End If
    End Sub
    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged
        checkDescription()
    End Sub
    Private Sub frmInsertNew_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        bInitTxtFile = False
    End Sub
    Private Sub rdbMatComm_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMatComm.CheckedChanged
        clearAll()
        'Abilitazione / Disabilitazione materiali a commessa
        If rdbMatComm.Checked Then
            cbxCompFamily.Enabled = True
            cbxCompFamily.ResetText()
            cbxConstructor.ResetText()
            rdbGenerico.Enabled = True
            rdbFamComponente.Enabled = True
            rdbFamComponente.Select()
            readOnlyField(True)
        Else
            cbxCompFamily.Enabled = False
            readOnlyField(False)
        End If
    End Sub
    Private Sub rdbMatCons_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMatCons.CheckedChanged
        clearAll()
        'Abilitazione / Disabilitazione materiali a consumo
        If rdbMatCons.Checked Then
            cbxCompFamily.ResetText()
            cbxCompFamily.Enabled = False
            cbxConstructor.ResetText()
            rdbGenerico.Enabled = False
            rdbFamComponente.Enabled = False
            readOnlyField(False)
            clearPanelFour()
        Else
            cbxCompFamily.Enabled = True
            readOnlyField(True)
        End If
    End Sub
    Private Sub rdbGenerico_CheckedChanged(sender As Object, e As EventArgs) Handles rdbGenerico.CheckedChanged
        clearAll()
        'Abilitazione / Disabilitazione generico
        If rdbGenerico.Checked Then
            cbxCompFamily.ResetText()
            cbxCompFamily.Enabled = False
            cbxConstructor.ResetText()
            readOnlyField(False)
            clearPanelFour()
        End If
    End Sub
    Private Sub rdbFamComponente_CheckedChanged(sender As Object, e As EventArgs) Handles rdbFamComponente.CheckedChanged
        clearAll()
        'Abilitazione / Disabilitazione famiglia di componenti
        If rdbFamComponente.Checked Then
            cbxCompFamily.Enabled = True
            cbxCompFamily.ResetText()
            cbxConstructor.ResetText()
            readOnlyField(True)
        End If
    End Sub
    Public Sub readOnlyField(ByRef enable As Boolean)
        txtCode.Clear()
        txtCode.ReadOnly = enable
        txtDescription.Clear()
        txtDescription.ReadOnly = enable
        If enable Then
            txtCode.ForeColor = Color.Gainsboro
            txtDescription.ForeColor = Color.Gainsboro
        Else
            txtCode.ForeColor = Color.Black
            txtDescription.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        checkArolCodeUpperPart()
    End Sub
    Public Sub clearAndResetTextBoxes()
        txtCode.ForeColor = Color.Black
        txtLowCode.ForeColor = Color.Black
        txtCommercialCode.ForeColor = Color.Black
        txtDescription.ForeColor = Color.Black
        txtSuppDescription.ForeColor = Color.Black
        txtFileDSPath.ForeColor = Color.Black
        txtCode.Clear()
        txtLowCode.Clear()
        txtCommercialCode.Clear()
        txtDescription.Clear()
        txtSuppDescription.Clear()
        txtFileDSPath.Clear()
    End Sub
    Public Sub clearAndResetComboBoxes()
        cbxConstructor.ResetText()
        cbxConstructor.BackColor = Color.Red
        cbxCompFamily.ResetText()
    End Sub
    Public Sub clearAll()
        txtCode.ForeColor = Color.Black
        txtLowCode.ForeColor = Color.Black
        txtCommercialCode.ForeColor = Color.Black
        txtDescription.ForeColor = Color.Black
        txtSuppDescription.ForeColor = Color.Black
        txtFileDSPath.ForeColor = Color.Black
        txtFileExtension.ForeColor = Color.Black
        txtDescrExample.ForeColor = Color.Black
        txtCode.Clear()
        txtLowCode.Clear()
        txtCommercialCode.Clear()
        txtDescription.Clear()
        txtSuppDescription.Clear()
        txtFileDSPath.Clear()
        txtFileExtension.Clear()
        txtDescrExample.Clear()
        cbxConstructor.ResetText()
        cbxConstructor.BackColor = Color.Red
        cbxCompFamily.ResetText()
        cbxAddDatasheet.Checked = CheckState.Unchecked
    End Sub
    Public Sub clearPanelFour()
        If bInitDescrField Then
            For i = 0 To 6
                txtField(i).Visible = False
                cmbField(i).Visible = False
                lblField(i).Visible = False
                lblPrefisso(i).Visible = False
                lblSuffisso(i).Visible = False
                lblDescrField(i).Visible = False
                astrFieldDescr(i) = Nothing
                txtField(i).Text = Nothing
                cmbField(i).Items.Clear()
                cmbField(i).ResetText()
                lblField(i).Text = Nothing
                lblPrefisso(i).Text = Nothing
                lblSuffisso(i).Text = Nothing
                astrSeparatore(i) = Nothing
            Next
        End If
    End Sub
    Public Function checkMatCommConsumo() As String
        If rdbMatComm.Checked And Not rdbMatCons.Checked Then
            checkMatCommConsumo = "codificati"
        ElseIf Not rdbMatComm.Checked And rdbMatCons.Checked Then
            checkMatCommConsumo = "consumabili"
        Else
            checkMatCommConsumo = Nothing
        End If
    End Function
End Class