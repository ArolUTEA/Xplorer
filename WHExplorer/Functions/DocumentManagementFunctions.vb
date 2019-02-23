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
                                'If txtUrl.Text <> "" Then
                                strUrl = frmNewDocument.txtUrl.Text
                                'fPopulateDocumentTable(iTipoID, strTitoloDoc, strRevisione, strFilePath, strUrl)
                                fCheckIfDocTypeAlreadyExist(iTipoID, strTitoloDoc, strRevisione, strFilePath, strUrl)
                                'End If
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
    'Funzione per popolare la tabella documentazione
    Public Function fPopulateDocumentTable(iTipoID As Integer, strTitolo As String, strVersione As String, strFilePath As String, strUrlPath As String, strArolCode As String) As Boolean
        Dim tempBool As Boolean
        Dim tempDataTable As DataTable
        Dim i As Integer
        Dim strLinkToDocID As String
        'Popolo da tabella documentazione
        tempBool = frmMain.dbWarehouse.fInsertNewDocument(frmMain.dbWarehouse.SQLConn, "documentazione", iTipoID, strTitolo, strVersione, strFilePath, strUrlPath)
        If tempBool Then
            'Recupero il ID dell'ultimo elemento inserito
            tempDataTable = frmMain.dbWarehouse.fExecuteGenericQuery(frmMain.dbWarehouse.SQLConn, "SELECT last_insert_rowid()")
            If tempDataTable.Rows.Count > 0 Then
                strLinkToDocID = tempDataTable.Rows(0)(0).ToString
                'i = 0
                'Popolo la tabella linkToDoc
                'For i = 0 To frmNewDocument.dgvConnectTo.Rows.Count - 2
                frmMain.dbWarehouse.fInsertNewLinkToDoc(frmMain.dbWarehouse.SQLConn, "linkToDoc", strArolCode, strLinkToDocID)
                'Next
            Else
                Return False
            End If
        Else
            Return False
        End If
        Return True
    End Function
    'Funzione per aggiornare il link di una documentazione esistente
    Public Function fUpdateDocumentTable(iTipoID As Integer, strTitolo As String, strVersione As String, strFilePath As String, strUrlPath As String, strArolCode As String, strOldLinkDoc As String) As Boolean
        Dim tempBool As Boolean
        Dim tempDataTable As DataTable
        Dim i As Integer
        Dim strLinkToDocID As String
        'Popolo la tabella documentazione
        tempBool = frmMain.dbWarehouse.fInsertNewDocument(frmMain.dbWarehouse.SQLConn, "documentazione", iTipoID, strTitolo, strVersione, strFilePath, strUrlPath)
        If tempBool Then
            'Recupero il ID dell'ultimo elemento inserito
            tempDataTable = frmMain.dbWarehouse.fExecuteGenericQuery(frmMain.dbWarehouse.SQLConn, "SELECT last_insert_rowid()")
            If tempDataTable.Rows.Count > 0 Then
                strLinkToDocID = tempDataTable.Rows(0)(0).ToString
                frmMain.dbWarehouse.fUpdateLinkToDoc(frmMain.dbWarehouse.SQLConn, "linkToDoc", strArolCode, strLinkToDocID, strOldLinkDoc)
            End If

        End If
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
    'Funzione per controllare che per un dato codice Arol, non sia già presente un documento dello stesso tipo che si vuole inserire
    Public Function fCheckIfDocTypeAlreadyExist(iTipoID As Integer, strTitoloDoc As String, strRevisione As String, strFilePath As String, strUrl As String) As Boolean
        'Controllo che sia selezionato un codice dal datagridview
        If frmNewDocument.dgvConnectTo.Rows.Count > 0 Then
            'Per ogni codice Arol inserito
            For i = 0 To frmNewDocument.dgvConnectTo.Rows.Count - 2
                'Controllo che nella tabella linkToDoc sia presente un link o meno
                If frmMain.dbWarehouse.fCheckIfAlreadyExist(frmNewDocument.dgvConnectTo.Item(0, i).Value.ToString, frmMain.dbWarehouse.SQLConn, "linkToDoc", "ArolCode") Then
                    Dim tempDataTable, tempDocDataTable As DataTable
                    'Se si, allora leggo la tabella dei link
                    tempDataTable = frmMain.dbWarehouse.fLookIfThereAreDocuments(frmNewDocument.dgvConnectTo.Item(0, i).Value.ToString, frmMain.dbWarehouse.SQLConn, "linkToDoc", "ArolCode")
                    If tempDataTable.Rows.Count > 0 Then
                        'Per ogni link definito ne estrapolo la tipologia di documentazione dalla tabella "documentazione"
                        For j = 0 To tempDataTable.Rows.Count - 1
                            tempDocDataTable = frmMain.dbWarehouse.fSelectElementFromColumn(frmMain.dbWarehouse.SQLConn, "documentazione", "ID", "ID", tempDataTable.Rows(j)(2).ToString)
                            If tempDocDataTable.Rows.Count > 0 Then
                                'Controllo che la tipologia di documentazione non sia già stata inserita
                                If tempDocDataTable.Rows(0)(1).ToString = fCalculateTypeOfDoc() Then
                                    'Se si, chiedo se voglio sovrascrivere il documento o meno
                                    If MsgBox("Per il codice Arol " & frmNewDocument.dgvConnectTo.Item(0, i).Value.ToString & " è già presente un documento della tipologia selezionata, vuoi sovrascrivere?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                        fUpdateDocumentTable(iTipoID, strTitoloDoc, strRevisione, strFilePath, strUrl)
                                    Else
                                        MsgBox("Bravo, saggia decisione!!", MsgBoxStyle.Exclamation)
                                    End If
                                Else
                                    fPopulateDocumentTable(iTipoID, strTitoloDoc, strRevisione, strFilePath, strUrl, frmNewDocument.dgvConnectTo.Item(0, i).Value.ToString)
                                End If
                            End If
                        Next
                    End If
                Else
                    fPopulateDocumentTable(iTipoID, strTitoloDoc, strRevisione, strFilePath, strUrl, frmNewDocument.dgvConnectTo.Item(0, i).Value.ToString)
                End If
            Next
        Else
            MsgBox("Nessun codice Arol selezionato!!", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return False
    End Function
    Public Function fCalculateTypeOfDoc() As String
        Dim tempDataTable As DataTable
        tempDataTable = frmMain.dbWarehouse.fFindInColumn(frmNewDocument.cbxSelectType.SelectedItem, "Descrizione", "tipologiaDocumentazione", frmMain.dbWarehouse.SQLConn)
        If tempDataTable.Rows.Count > 0 Then
            Return tempDataTable.Rows(0)(0).ToString
        Else
            Return ""
        End If
    End Function
End Module
