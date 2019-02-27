Imports System.Text
Imports System.IO
Module DocumentManagementFunctions
    'Funzione per controllare che il codice arol selezionato sia univoco e popolare il datagrid view
    Public Function fCheckIfOnlyOneAndPopulateDgv(dataValue As DataTable) As Boolean
        If dataValue.Rows.Count > 1 Then
            frmNewDocument.dgvConnectTo.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(255, 173, 153)
            Return False
        Else
            frmNewDocument.dgvConnectTo.CurrentRow.Cells(0).Value = dataValue.Rows(0)(1).ToString
            frmNewDocument.dgvConnectTo.CurrentRow.Cells(1).Value = dataValue.Rows(0)(2).ToString
            frmNewDocument.dgvConnectTo.CurrentRow.Cells(2).Value = dataValue.Rows(0)(3).ToString
            frmNewDocument.dgvConnectTo.CurrentRow.Cells(3).Value = dataValue.Rows(0)(4).ToString
            frmNewDocument.dgvConnectTo.AutoResizeColumns()
            Return True
        End If
    End Function
    'Funzione per controllare i campi da inserire all'interno della tabella, eseguirne la formattazione e richiamare la funzione per popolare la tabella documentazione
    Public Function fInitFields() As Boolean
        Dim iTipoID As Integer
        Dim strTitoloDoc, strRevisione, strFilePath, strUrl As String
        If frmNewDocument.dgvConnectTo.Rows.Count > 0 Then
            If frmNewDocument.cbxSelectType.SelectedItem IsNot Nothing Then
                Dim tempDataTable As DataTable
                tempDataTable = frmMain.dbWarehouse.fFindInColumn(frmNewDocument.cbxSelectType.SelectedItem, "Descrizione", "tipologiaDocumentazione", frmMain.dbWarehouse.SQLConn)
                If tempDataTable.Rows.Count > 0 Then
                    iTipoID = tempDataTable.Rows(0)(0).ToString
                    If frmNewDocument.txtDocTitle.Text <> "" Then
                        strTitoloDoc = frmNewDocument.txtDocTitle.Text
                        If frmNewDocument.txtRevision.Text <> "" Then
                            strRevisione = frmNewDocument.txtRevision.Text
                            If frmNewDocument.txtFilePath.Text <> "" Then
                                strFilePath = frmNewDocument.txtFilePath.Text
                                strUrl = frmNewDocument.txtUrl.Text
                                fInsertNewDocument(iTipoID, strTitoloDoc, strRevisione, strFilePath, strUrl)
                            Else
                                MsgBox("Selezionare un file", MsgBoxStyle.OkOnly)
                                Return False
                            End If
                        Else
                            MsgBox("Inserire un indice di revisione", MsgBoxStyle.OkOnly)
                            Return False
                        End If
                    Else
                        MsgBox("Inserire un titolo al documento", MsgBoxStyle.OkOnly)
                        Return False
                    End If
                Else
                    MsgBox("La memoria non poteva essere read", MsgBoxStyle.Critical)
                    Return False
                End If
            Else
                MsgBox("Necessario selezionare una tipologia", MsgBoxStyle.OkOnly)
            End If
            Return True
        Else
            MsgBox("Necessario collegare il documento ad un codice Arol", MsgBoxStyle.OkOnly)
            Return False
        End If
    End Function
    'Funzione per popolare la tabella documentazione NUOVA
    Public Function fPopulateDocumentTable(iTipoID As Integer, strTitolo As String, strVersione As String, strFilePath As String, strUrlPath As String) As Boolean
        Dim tempBool As Boolean
        tempBool = frmMain.dbWarehouse.fInsertNewDocument(frmMain.dbWarehouse.SQLConn, "documentazione", iTipoID, strTitolo, strVersione, strFilePath, strUrlPath)
        Return True
    End Function
    'Funzione per popolare la tabella linkToDoc
    Public Function fPopulateLinkToDoc(strArolCode As String, strLinkToDocID As String) As Boolean
        frmMain.dbWarehouse.fInsertNewLinkToDoc(frmMain.dbWarehouse.SQLConn, "linkToDoc", strArolCode, strLinkToDocID)
        Return True
    End Function
    'Funzione per aggiornare il link di una documentazione esistente
    Public Function fUpdateDocumentTable(iTipoID As Integer, strTitolo As String, strVersione As String, strFilePath As String, strUrlPath As String, strArolCode As String, strOldLinkDoc As String) As Boolean
        Dim tempBool As Boolean
        Dim tempDataTable As DataTable
        Dim strLinkToDocID As String
        'Popolo la tabella documentazione
        tempBool = frmMain.dbWarehouse.fInsertNewDocument(frmMain.dbWarehouse.SQLConn, "documentazione", iTipoID, strTitolo, strVersione, strFilePath, strUrlPath)
        If tempBool Then
            'Recupero il ID dell'ultimo elemento inserito
            tempDataTable = frmMain.dbWarehouse.fExecuteGenericQuery(frmMain.dbWarehouse.SQLConn, "SELECT last_insert_rowid()")
            If tempDataTable.Rows.Count > 0 Then
                strLinkToDocID = tempDataTable.Rows(0)(0).ToString
                'Aggiorno la linkToDoc table
                frmMain.dbWarehouse.fUpdateLinkToDoc(frmMain.dbWarehouse.SQLConn, "linkToDoc", strArolCode, strLinkToDocID, strOldLinkDoc)
            End If
        End If
        Return True
    End Function
    'Funzione per abilitare/disabilitare il pulsante di "Salva"
    Public Function fEnableSaveButton(xEnable As Boolean) As Boolean
        If xEnable And Not frmNewDocument.btnSave.Enabled Then
            frmNewDocument.btnSave.Enabled = True
        ElseIf Not xEnable And frmNewDocument.btnSave.Enabled Then
            frmNewDocument.btnSave.Enabled = False
        End If
        Return True
    End Function
    'Funzione per inserimento di una nuova documentazione
    Public Function fInsertNewDocument(iTipoID As Integer, strTitoloDoc As String, strRevisione As String, strFilePath As String, strUrl As String) As Boolean
        'Controllo che sia selezionato un codice dal datagridview
        Dim strLinkToDocID As String
        If frmNewDocument.dgvConnectTo.Rows.Count > 0 Then
            'Popolo la document table
            fPopulateDocumentTable(iTipoID, strTitoloDoc, strRevisione, fMoveFileToArchive(iTipoID), strUrl)
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
            Dim strArolCode As String
            For i = 0 To frmNewDocument.dgvConnectTo.Rows.Count - 2
                strArolCode = frmNewDocument.dgvConnectTo.Item(0, i).Value.ToString
                fPopulateLinkToDoc(strArolCode, strLinkToDocID)
            Next
            Return True
        Else
            MsgBox("Nessun codice Arol selezionato!!", MsgBoxStyle.Exclamation)
            Return False
        End If
    End Function
    'Funzione per spostare i file dal path sorgente al path di archiviazione
    Public Function fMoveFileToArchive(iTipoID As Integer) As String
        Dim strDestFolder As String = frmMain.strDocArchivePath(iTipoID - 1)
        Try
            'chiamo la funzione che mi restituisce un array contenente i nomi dei files
            Dim strFullFileName, strFileExtension As String
            Dim information = My.Computer.FileSystem.GetFileInfo(RegularExpressions.Regex.Replace(frmNewDocument.txtFilePath.Text.ToString, """", ""))
            strFullFileName = Path.GetFileNameWithoutExtension(information.FullName)
            strFileExtension = information.Extension
            fCopyFromDirToDir(RegularExpressions.Regex.Replace(frmNewDocument.txtFilePath.Text.ToString, """", ""), RegularExpressions.Regex.Replace(strDestFolder & strFullFileName & strFileExtension, """", ""), False)
            Return RegularExpressions.Regex.Replace(strDestFolder & strFullFileName & strFileExtension, """", "")
        Catch ex As Exception
            MsgBox("ERRORE NELL'ARCHIVIAZIONE DEL DOCUMENTO")
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return Nothing
        End Try
    End Function
    'Funzione per la pulizia dei datagridview
    Public Function fCleanDatagridView() As Boolean
        frmMain.dgvDatasheets.Rows.Clear()
        frmMain.dgvUserManuals.Rows.Clear()
        frmMain.dgvElectricalDrawings.Rows.Clear()
        frmMain.dgvApplicationNotes.Rows.Clear()
        frmMain.dgvEconomicBids.Rows.Clear()
        Return True
    End Function
    'Funzione per rendere visibile/invisibile i datagridview
    Public Function fHideDataGridViews(xVisible As Boolean) As Boolean
        frmMain.dgvDatasheets.Visible = xVisible
        frmMain.dgvUserManuals.Visible = xVisible
        frmMain.dgvElectricalDrawings.Visible = xVisible
        frmMain.dgvApplicationNotes.Visible = xVisible
        frmMain.dgvEconomicBids.Visible = xVisible
        Return xVisible
    End Function
    'Funzione per il popolamento dei datagridview contenenti l'elenco della documentazione
    Public Function fPopulateDocumentDgvs() As Boolean
        fHideDataGridViews(False)
        fCleanDatagridView()
        Dim ArolCode As String
        Dim tempLinkToDoc, tempDocumentation As DataTable
        'Recupero l'informazione del rowIndex del datagridView e l'informazione del ArolCode
        Select Case frmMain.CompEleControl.SelectedIndex
            Case 0
                'CODIFICATI
                ArolCode = frmMain.dgvCEDBViewer.Rows(frmMain.dgvCEDBViewer.CurrentCell.RowIndex).Cells(1).Value
            Case 1
                'CONSUMABILI
                ArolCode = frmMain.dgvCSDBViewer.Rows(frmMain.dgvCSDBViewer.CurrentCell.RowIndex).Cells(1).Value
            Case Else
                Return False
        End Select
        'Controllo se ci sono dei documenti
        tempLinkToDoc = frmMain.dbWarehouse.fLookIfThereAreDocuments(ArolCode, frmMain.dbWarehouse.SQLConn, "linkToDoc", "ArolCode")
        If tempLinkToDoc IsNot Nothing Then
            For i = 0 To tempLinkToDoc.Rows.Count - 1
                'Recupero le informazioni sui documenti presenti e popolo i vari datagridview
                tempDocumentation = frmMain.dbWarehouse.fSelectElementFromColumn(frmMain.dbWarehouse.SQLConn, "documentazione", "ID", "ID", tempLinkToDoc.Rows(i)(2).ToString)
                If tempDocumentation.Rows.Count > 0 Then
                    For j = 0 To tempDocumentation.Rows.Count - 1
                        Select Case tempDocumentation.Rows(j)(1)
                            Case 1
                                frmMain.dgvDatasheets.Visible = True
                                frmMain.dgvDatasheets.Rows.Add(tempDocumentation.Rows(j).ItemArray)
                                frmMain.dgvDatasheets.AutoResizeColumns()
                            Case 2
                                frmMain.dgvUserManuals.Visible = True
                                frmMain.dgvUserManuals.Rows.Add(tempDocumentation.Rows(j).ItemArray)
                                frmMain.dgvUserManuals.AutoResizeColumns()
                            Case 3
                                frmMain.dgvElectricalDrawings.Visible = True
                                frmMain.dgvElectricalDrawings.Rows.Add(tempDocumentation.Rows(j).ItemArray)
                                frmMain.dgvElectricalDrawings.AutoResizeColumns()
                            Case 4
                                frmMain.dgvApplicationNotes.Visible = True
                                frmMain.dgvApplicationNotes.Rows.Add(tempDocumentation.Rows(j).ItemArray)
                                frmMain.dgvApplicationNotes.AutoResizeColumns()
                            Case 5
                                frmMain.dgvEconomicBids.Visible = True
                                frmMain.dgvEconomicBids.Rows.Add(tempDocumentation.Rows(j).ItemArray)
                                frmMain.dgvEconomicBids.AutoResizeColumns()
                            Case Else
                                MsgBox("Uhm... Ciambella....", MsgBoxStyle.Critical)
                        End Select
                    Next
                Else
                    Return False
                End If
            Next
        Else
            Return False
        End If
        Return True
    End Function
    Public Function fOpenDocumentFromDgv(strLink As String) As Boolean
        If strLink <> "" Then
            Process.Start(strLink)
        End If
    End Function
    Public Function fInitDatagridViews() As Boolean
        frmMain.dgvDatasheets.AutoResizeColumns()
        frmMain.dgvDatasheets.ReadOnly = True
        frmMain.dgvUserManuals.AutoResizeColumns()
        frmMain.dgvUserManuals.ReadOnly = True
        frmMain.dgvElectricalDrawings.AutoResizeColumns()
        frmMain.dgvElectricalDrawings.ReadOnly = True
        frmMain.dgvApplicationNotes.AutoResizeColumns()
        frmMain.dgvApplicationNotes.ReadOnly = True
        frmMain.dgvEconomicBids.AutoResizeColumns()
        frmMain.dgvEconomicBids.ReadOnly = True
        Return True
    End Function
End Module
