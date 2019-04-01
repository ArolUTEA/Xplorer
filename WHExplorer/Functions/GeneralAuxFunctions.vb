Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles
Module GeneralAuxFunctions
    Public Function fReturnTableName() As String
        Try
            Select Case frmMain.CompEleControl.SelectedIndex
                Case 0
                    Return "codificati"
                Case 1
                    Return "consumabili"
                Case Else
                    Return Nothing
            End Select
        Catch ex As Exception
            MsgBox("ERRORE NELLA SELEZIONE DELLA TABELLA", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function fPopulateAndResizeDGV(dgvSelected As DataGridView, tempData As DataTable, iDGVWidth As Integer) As Boolean
        Dim tempDataTable As DataTable
        Dim i As Integer
        Dim j As Integer = 0
        Dim xFound As Boolean
        Try
            dgvSelected.DataSource = tempData
            'Make datagrid viewer visible
            dgvSelected.Visible = True
            dgvSelected.Width = iDGVWidth - 15
            'Manage datagrid viewer size
            dgvSelected.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            dgvSelected.AutoResizeColumns()
            dgvSelected.AutoResizeRows()
            'Make datagrid viewer readonly
            'All datagrid viewer rows in green
            dgvSelected.RowsDefaultCellStyle.BackColor = Color.FromArgb(204, 255, 204)
            'Leggo la tabella dei codici estesi
            If dgvSelected.Name = "dgvCEDBViewer" Then
                tempDataTable = frmMain.dbWarehouse.fSelectAllAndOrderBy(frmMain.dbWarehouse.SQLConn, "datiEstesiCodificati", "ID")
            ElseIf dgvSelected.Name = "dgvCSDBViewer" Then
                tempDataTable = frmMain.dbWarehouse.fSelectAllAndOrderBy(frmMain.dbWarehouse.SQLConn, "datiEstesiConsumabili", "ID")
            Else
                tempDataTable = Nothing
            End If

            'Definisco una primary key per il tempData
            tempData.PrimaryKey = New DataColumn() {tempData.Columns("ArolCode")}
            'Controllo per quali codici è previsto uno stato diverso da 0

            For Each elemento As DataRow In tempDataTable.Rows
                j = j + 1
                'Se trovo un codice con stato diverso da 0, allora vado a cercarlo nel dgvSelected e cambio il colore della riga corrispondentemente
                If elemento.Item("Stato") <> 0 Then
                    i = 0
                    xFound = False
                    For Each row As DataGridViewRow In dgvSelected.Rows
                        If dgvSelected.Rows(i).Cells("ArolCode").Value IsNot Nothing Then
                            If dgvSelected.Rows(i).Cells("ArolCode").Value.ToString = elemento.Item("ArolCode").ToString Or i >= dgvSelected.Rows.Count - 1 Then
                                xFound = True
                                Exit For
                            Else
                                i = i + 1
                            End If
                        End If
                    Next
                    If i > 0 And i < dgvSelected.Rows.Count And xFound Then
                        fChangeRowColor(dgvSelected, i, elemento.Item("Stato"))
                    End If
                End If
            Next
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NEL POPOLAMENTO E NEL RESIZE DEL DATAGRIDVIEW " & j, MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fDeleteFromDGV(dgvSelected As DataGridView, iSelectedRow As Integer) As Boolean
        Try
            dgvSelected.Rows(iSelectedRow).Selected = True
            For Each dr In dgvSelected.SelectedRows
                dgvSelected.Rows.Remove(dr)
            Next
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NELLA CANCELLAZIONE DAL DATAGRIDVIEW", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fManagementOfDgvClickOrKeyMove(xExtendedEnabled As Boolean) As Boolean
        Try
            'Controllo se il pannello dati estesi è abilitato
            If Not xExtendedEnabled Then
                fEnableDisableDetails()
            End If
            'Pulisco il pannello dei dati estesi
            fClearDetailsPanel()
            'Controllo che la selezione non sia nulla
            Dim tempBool As Boolean
            Select Case frmMain.CompEleControl.SelectedIndex
                Case 0
                    'Tabella dei codificati
                    tempBool = IsDBNull(frmMain.dgvCEDBViewer.CurrentCell.Value)
                Case 1
                    'Tabella dei consumabili
                    tempBool = IsDBNull(frmMain.dgvCSDBViewer.CurrentCell.Value)
                Case Else
                    Return False
            End Select
            If Not tempBool Then
                Dim dgvCurrent As DataGridView
                Dim strCurrentTable As String
                Select Case frmMain.CompEleControl.SelectedIndex
                    Case 0
                        dgvCurrent = frmMain.dgvCEDBViewer
                        strCurrentTable = "codificati"
                    Case 1
                        dgvCurrent = frmMain.dgvCSDBViewer
                        strCurrentTable = "consumabili"
                    Case Else
                        dgvCurrent = Nothing
                        strCurrentTable = ""
                        Return False
                End Select
                fGetDataFromDB(fRetrieveSelectedElementInfo(dgvCurrent), strCurrentTable)
                'frmMain.sCheckIfThereAreFiles()
                fPopulateDocumentDgvs()
            End If
            Return True
        Catch ex As Exception
            MsgBox("LA MEMORIA NON POTEVA ESSERE READ", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function

    Public Function fRetrieveExtendedData(iModifiedID As Integer, strTableName As String) As DataTable
        'Recupero i dati dal database
        Dim tempBasicData As DataTable
        tempBasicData = fRetrieveSelectedData(iModifiedID, strTableName)
        If frmMain.CompEleControl.SelectedIndex = 0 Then
            fRetrieveExtendedData = frmMain.dbWarehouse.fSelectElementFromColumn(frmMain.dbWarehouse.SQLConn, "datiEstesiCodificati", "ArolCode", "ArolCode", tempBasicData.Rows(0)("ArolCode"))
        ElseIf frmMain.CompEleControl.SelectedIndex = 1 Then
            fRetrieveExtendedData = frmMain.dbWarehouse.fSelectElementFromColumn(frmMain.dbWarehouse.SQLConn, "datiEstesiConsumabili", "ArolCode", "ArolCode", tempBasicData.Rows(0)("ArolCode"))
        Else
            fRetrieveExtendedData = Nothing
        End If
        If fRetrieveExtendedData.Rows.Count = 0 Then
            fRetrieveExtendedData = Nothing
        End If
    End Function
    Public Function fEnableDisableDetails() As Boolean
        If frmMain.pnlExtendedData.Visible Then
            frmMain.pnlExtendedData.Visible = False
            frmMain.CompEleControl.Width = 1565
        Else
            frmMain.pnlExtendedData.Visible = True
            frmMain.CompEleControl.Width = 1565 - frmMain.pnlExtendedData.Width - 10
        End If
        frmMain.dgvCEDBViewer.Width = frmMain.CompEleControl.Width - 15
        frmMain.dgvCSDBViewer.Width = frmMain.CompEleControl.Width - 15
        Return True
    End Function
    Public Function fClearDetailsPanel() As Boolean
        frmMain.txtArolCode.Clear()
        frmMain.txtCodificaRichiestaDa.Clear()
        frmMain.txtDataInserimento.Clear()
        frmMain.txtInseritoDa.Clear()
        frmMain.txtStatoAttuale.Clear()
        frmMain.txtTipoParte.Clear()
        frmMain.txtRiordino.Clear()
        frmMain.txtScortaSicurezza.Clear()
        frmMain.txtLotto.Clear()
        frmMain.txtCostoUltimo.Clear()
        frmMain.txtNote.Clear()
        frmMain.txtDataUltimaModifica.Clear()
        frmMain.txtModificatoDa.Clear()
        Return True
    End Function
    Public Function fRetrieveSelectedElementInfo(dgvSelected As DataGridView) As Integer
        Return dgvSelected.Rows(dgvSelected.CurrentCell.RowIndex).Cells(0).Value
    End Function
    Public Function fGetDataFromDB(iElementID As Integer, strTableName As String) As Boolean
        'Recupero i dati dal database
        Dim tempBasicData, tempExtendedData As DataTable
        tempBasicData = fRetrieveSelectedData(iElementID, strTableName)
        tempExtendedData = fRetrieveExtendedData(iElementID, strTableName)
        If tempExtendedData.Rows.Count > 0 Then
            fPopulateArticlesDetails(tempBasicData, tempExtendedData)
            Return True
        Else
            MsgBox("DATI NON DISPONIBILI", MsgBoxStyle.Critical)
            Return False
        End If
    End Function
    Public Function fReadDocuments(iDocType As Integer) As String
        Dim rowIndex As Integer
        Dim ArolCode As String
        Dim tempLinkToDoc, tempDocumentation As DataTable
        'Recupero l'informazione del rowIndex del datagridView e l'informazione del ArolCode
        Select Case frmMain.CompEleControl.SelectedIndex
            Case 0
                'CODIFICATI
                rowIndex = frmMain.dgvCEDBViewer.CurrentCell.RowIndex
                ArolCode = frmMain.dgvCEDBViewer.Rows(rowIndex).Cells(1).Value
            Case 1
                'CONSUMABILI
                rowIndex = frmMain.dgvCSDBViewer.CurrentCell.RowIndex
                ArolCode = frmMain.dgvCSDBViewer.Rows(rowIndex).Cells(1).Value
            Case Else
                Return Nothing
        End Select
        'Controllo se ci sono dei documenti
        tempLinkToDoc = frmMain.dbWarehouse.fLookIfThereAreDocuments(ArolCode, frmMain.dbWarehouse.SQLConn, "linkToDoc", "ArolCode")
        If tempLinkToDoc IsNot Nothing Then
            For i = 0 To tempLinkToDoc.Rows.Count - 1
                'Recupero le informazioni sui documenti presenti
                tempDocumentation = frmMain.dbWarehouse.fSelectElementFromColumn(frmMain.dbWarehouse.SQLConn, "documentazione", "ID", "ID", tempLinkToDoc.Rows(i)(2).ToString)
                If tempDocumentation.Rows.Count > 0 Then
                    For j = 0 To tempDocumentation.Rows.Count - 1
                        If tempDocumentation.Rows(j)(1) = iDocType Then
                            Return tempDocumentation.Rows(j)(4).ToString
                        Else
                            'Return Nothing
                        End If
                    Next
                Else
                    Return Nothing
                End If
            Next
        Else
            Return Nothing
        End If
        Return Nothing
    End Function
    Public Function fOpenDocument(strLink As String) As Boolean
        Process.Start(Convert.ToString(strLink))
        Return True
    End Function
    'Funzione per la migrazione della documentazione da tabella codificatiDS a tabelle "documentazione" e linkToDoc
    Public Function fDocumentMigration() As Boolean
        Dim tempCodificatiDS As DataTable
        Dim strLinkToDocID As String
        'Leggo la tabella codificatiDS
        tempCodificatiDS = frmMain.dbWarehouse.fSelectAllAndOrderBy(frmMain.dbWarehouse.SQLConn, "codificatiDS", "ID")
        For i = 0 To tempCodificatiDS.Rows.Count - 1
            'Per ogni elemento della tabella
            'Sposto il file nel nuovo direttorio
            fCopyFromDirToDir(tempCodificatiDS.Rows(i)(3).ToString, frmMain.strDocArchivePath(0) & tempCodificatiDS.Rows(i)(1).ToString & tempCodificatiDS.Rows(i)(2).ToString, False)
            'Popolo la tabella documentazione
            fPopulateDocumentTable(1, "Datasheet", "1", frmMain.strDocArchivePath(0) & tempCodificatiDS.Rows(i)(1).ToString & tempCodificatiDS.Rows(i)(2).ToString, "")
            'Recupero il ID dell'ultimo elemento inserito
            Dim tempDataTable As DataTable
            tempDataTable = frmMain.dbWarehouse.fExecuteGenericQuery(frmMain.dbWarehouse.SQLConn, "SELECT last_insert_rowid()")
            If tempDataTable.Rows.Count > 0 Then
                strLinkToDocID = tempDataTable.Rows(0)(0).ToString
            Else
                strLinkToDocID = ""
                MsgBox("INSERIMENTO FALLITO", MsgBoxStyle.Critical)
                Return False
            End If
            fPopulateLinkToDoc(tempCodificatiDS.Rows(i)(1).ToString, strLinkToDocID)
            If frmDocMigrationRun.prbDocMigration.Value < frmDocMigrationRun.prbDocMigration.Maximum Then
                frmDocMigrationRun.prbDocMigration.Value = frmDocMigrationRun.prbDocMigration.Value + 1
            Else
                frmDocMigrationRun.prbDocMigration.Value = 0
            End If
        Next
        Return True
    End Function

End Module