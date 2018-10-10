Imports System.Data.SQLite
Module EditExistFunctions
    Public Function fRetreiveSelectedID() As Integer
        Try
            Dim rowIndex As Integer
            rowIndex = frmMain.dgvCEDBViewer.CurrentCell.RowIndex
            fRetreiveSelectedID = frmMain.dgvCEDBViewer.Rows(rowIndex).Cells(0).Value
        Catch ex As Exception
            MsgBox("ERRORE NEL RECUPERO DELL'ID", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            fRetreiveSelectedID = 0
        End Try
    End Function
    Public Function fUpdateCodificatiElement(selectedID As Integer, strArolCode As String, strCommercialCode As String, strDescription As String, strManufacturer As String, strSuppDescr As String) As Boolean
        Try
            Dim strTempQuery As String = "UPDATE codificati SET ArolCode=@ArolCode, CommercialCode=@CommercialCode, Description=@Description, Manufacturer=@Manufacturer, SupplementaryDescription=@SupplementaryDescription WHERE ID = '" & selectedID & "'"
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(strTempQuery, frmMain.dbWarehouse.SQLConn)
            sqlCmd.Parameters.AddWithValue("@ArolCode", strArolCode)
            sqlCmd.Parameters.AddWithValue("@CommercialCode", strCommercialCode)
            sqlCmd.Parameters.AddWithValue("@Description", strDescription)
            sqlCmd.Parameters.AddWithValue("@Manufacturer", strManufacturer)
            sqlCmd.Parameters.AddWithValue("@SupplementaryDescription", strSuppDescr)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NELLA MODIFICA DELL'ELEMENTO SELEZIONATO", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fUpdateConsumabiliElement(selectedID As Integer, strArolCode As String, strCommercialCode As String, strDescription As String, strManufacturer As String, strSuppDescr As String) As Boolean
        Try
            Dim strTempQuery As String = "UPDATE consumabili SET ArolCode=@ArolCode, CommercialCode=@CommercialCode, Description=@Description, Manufacturer=@Manufacturer, SupplementaryDescription=@SupplementaryDescription WHERE ID = '" & selectedID & "'"
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(strTempQuery, frmMain.dbWarehouse.SQLConn)
            sqlCmd.Parameters.AddWithValue("@ArolCode", strArolCode)
            sqlCmd.Parameters.AddWithValue("@CommercialCode", strCommercialCode)
            sqlCmd.Parameters.AddWithValue("@Description", strDescription)
            sqlCmd.Parameters.AddWithValue("@Manufacturer", strManufacturer)
            sqlCmd.Parameters.AddWithValue("@SupplementaryDescription", strSuppDescr)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NELLA MODIFICA DELL'ELEMENTO SELEZIONATO", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fUndoCodificatiModification(iSelectedID As Integer, iSelectedDGVRow As Integer) As Boolean
        Try
            Dim tempData, tempDataExtended As DataTable
            tempData = frmMain.dbWarehouse.fSelectElementFromColumn(frmMain.dbWarehouse.SQLConn, "codificati", "ID", "ID", iSelectedID)
            tempDataExtended = frmMain.dbWarehouse.fSelectElementFromColumn(frmMain.dbWarehouse.SQLConn, "datiEstesiCodificati", "ID", "ID", iSelectedID)
            If tempData.Rows.Count > 0 Then
                frmArticlesModification.txtArolCode.Text = tempData.Rows(0)("ArolCode")
                frmArticlesModification.txtCommercialCode.Text = tempData.Rows(0)("CommercialCode")
                frmArticlesModification.txtDescription.Text = tempData.Rows(0)("Description")
                frmArticlesModification.txtConstructor.Text = tempData.Rows(0)("Manufacturer")
                frmArticlesModification.txtSuppDescription.Text = tempData.Rows(0)("SupplementaryDescription")
            Else
                MsgBox("MO SO CAZZ....", MsgBoxStyle.Critical)
                tempData.Dispose()
                Return False
            End If
            If tempDataExtended.Rows.Count > 0 Then
                Select Case tempDataExtended.Rows(0)("Stato")
                    Case 0
                        frmArticlesModification.txtStatoAttuale.Text = "Codice attivo"
                    Case 1
                        frmArticlesModification.txtStatoAttuale.Text = "Solo per ricambio"
                    Case 2
                        frmArticlesModification.txtStatoAttuale.Text = "In obsolescenza"
                    Case 3
                        frmArticlesModification.txtStatoAttuale.Text = "Annullato"
                    Case Else
                        Return False
                        Exit Function
                End Select
                If Not IsDBNull(tempDataExtended.Rows(0)("Note")) Then
                    frmArticlesModification.txtNote.Text = tempDataExtended.Rows(0)("Note").ToString
                End If
                If Not (IsDBNull(tempDataExtended.Rows(0)("PuntoLotto"))) Then
                    frmArticlesModification.txtLotto.Text = tempDataExtended.Rows(0)("PuntoLotto").ToString
                End If
                If Not (IsDBNull(tempDataExtended.Rows(0)("PuntoRiordino"))) Then
                    frmArticlesModification.txtRiordino.Text = tempDataExtended.Rows(0)("PuntoRiordino").ToString
                End If
                If Not (IsDBNull(tempDataExtended.Rows(0)("TipoParte"))) Then
                    frmArticlesModification.txtTipoParte.Text = tempDataExtended.Rows(0)("TipoParte")
                End If
                If Not (IsDBNull(tempDataExtended.Rows(0)("ScortaSicurezza"))) Then
                    frmArticlesModification.txtScortaSicurezza.Text = tempDataExtended.Rows(0)("ScortaSicurezza").ToString
                End If
                If Not (IsDBNull(tempDataExtended.Rows(0)("CostoUltimo"))) Then
                    Dim strTemp As Array = Split(tempDataExtended.Rows(0)("CostoUltimo").ToString, ",")
                    frmArticlesModification.txtCostoUltimo.Text = strTemp(0) & "," & Left(strTemp(1), 2) & " €"
                End If
            Else
                tempDataExtended.Dispose()
            End If
            tempData.Dispose()
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NEL RECUPERO DEI DATI, TI RICORDI COSA HAI MODIFICATO?", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fUndoConsumabiliModification(iSelectedID As Integer, iSelectedDGVRow As Integer) As Boolean
        Try
            Dim tempData, tempDataExtended As DataTable
            tempData = frmMain.dbWarehouse.fSelectElementFromColumn(frmMain.dbWarehouse.SQLConn, "consumabili", "ID", "ID", iSelectedID)
            tempDataExtended = frmMain.dbWarehouse.fSelectElementFromColumn(frmMain.dbWarehouse.SQLConn, "datiEstesiConsumabili", "ID", "ID", iSelectedID)
            If tempData.Rows.Count > 0 Then
                frmMain.dgvCSDBViewer.Rows(iSelectedDGVRow).Cells(1).Value = tempData.Rows(0)("ArolCode")
                frmMain.dgvCSDBViewer.Rows(iSelectedDGVRow).Cells(2).Value = tempData.Rows(0)("CommercialCode")
                frmMain.dgvCSDBViewer.Rows(iSelectedDGVRow).Cells(3).Value = tempData.Rows(0)("Description")
                frmMain.dgvCSDBViewer.Rows(iSelectedDGVRow).Cells(4).Value = tempData.Rows(0)("Manufacturer")
                frmMain.dgvCSDBViewer.Rows(iSelectedDGVRow).Cells(5).Value = tempData.Rows(0)("SupplementaryDescription")
            Else
                MsgBox("MO SO CAZZ....", MsgBoxStyle.Critical)
                tempData.Dispose()
                Return False
            End If
            If tempDataExtended.Rows.Count > 0 Then
                Select Case tempDataExtended.Rows(0)("Stato")
                    Case 0
                        frmArticlesModification.txtStatoAttuale.Text = "Codice attivo"
                    Case 1
                        frmArticlesModification.txtStatoAttuale.Text = "Solo per ricambio"
                    Case 2
                        frmArticlesModification.txtStatoAttuale.Text = "In obsolescenza"
                    Case 3
                        frmArticlesModification.txtStatoAttuale.Text = "Annullato"
                    Case Else
                        Return False
                        Exit Function
                End Select
                If Not IsDBNull(tempDataExtended.Rows(0)("Note")) Then
                    frmArticlesModification.txtNote.Text = tempDataExtended.Rows(0)("Note").ToString
                End If
                If Not (IsDBNull(tempDataExtended.Rows(0)("PuntoLotto"))) Then
                    frmArticlesModification.txtLotto.Text = tempDataExtended.Rows(0)("PuntoLotto").ToString
                End If
                If Not (IsDBNull(tempDataExtended.Rows(0)("PuntoRiordino"))) Then
                    frmArticlesModification.txtRiordino.Text = tempDataExtended.Rows(0)("PuntoRiordino").ToString
                End If
                If Not (IsDBNull(tempDataExtended.Rows(0)("TipoParte"))) Then
                    frmArticlesModification.txtTipoParte.Text = tempDataExtended.Rows(0)("TipoParte")
                End If
                If Not (IsDBNull(tempDataExtended.Rows(0)("ScortaSicurezza"))) Then
                    frmArticlesModification.txtScortaSicurezza.Text = tempDataExtended.Rows(0)("ScortaSicurezza").ToString
                End If
                If Not (IsDBNull(tempDataExtended.Rows(0)("CostoUltimo"))) Then
                    Dim strTemp As Array = Split(tempDataExtended.Rows(0)("CostoUltimo").ToString, ",")
                    frmArticlesModification.txtCostoUltimo.Text = strTemp(0) & "," & Left(strTemp(1), 2) & " €"
                End If
            Else
                tempDataExtended.Dispose()
            End If
            tempData.Dispose()
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NEL RECUPERO DEI DATI, TI RICORDI COSA HAI MODIFICATO?", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fGenerateStringForEmail(iSelectedID As Integer, strTableName As String) As String
        Try
            Dim tempData As DataTable
            tempData = frmMain.dbWarehouse.fSelectElementFromColumn(frmMain.dbWarehouse.SQLConn, strTableName, "ID", "ID", iSelectedID)
            If tempData.Rows.Count > 0 Then
                Return fCreateCodiciTxt(tempData.Rows(0)("ArolCode"), tempData.Rows(0)("CommercialCode"), tempData.Rows(0)("Description"), tempData.Rows(0)("Manufacturer"), tempData.Rows(0)("SupplementaryDescription"))
            Else
                MsgBox("NESSUN ELEMENTO TROVATO!!", MsgBoxStyle.Exclamation)
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELLA GENERAZIONE DELLA STRINGA PER EMAIL", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function fDeleteElement(iSelectedID As Integer, strTableName As String) As Boolean
        Try
            Dim strTempQuery As String = "DELETE FROM " & strTableName & " WHERE ID = '" & iSelectedID & "'"
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(strTempQuery, frmMain.dbWarehouse.SQLConn)
            sqlCmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NELLA ELIMINAZIONE DEL ELEMENTO DAL DATABASE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fRetrieveSelectedData(iSelectedID As Integer, strTableName As String) As DataTable
        Try
            Dim tempData As DataTable
            tempData = frmMain.dbWarehouse.fSelectElementFromColumn(frmMain.dbWarehouse.SQLConn, strTableName, "ID", "ID", iSelectedID)
            If tempData.Rows.Count > 0 Then
                Return tempData
            Else
                MsgBox("NESSUN DATO RECUPERATO", MsgBoxStyle.Critical)
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("ERRORE NEL RECUPERO DATI DAL DATABASE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function fPopulateArticlesDetails(tempBasicData As DataTable, tempExtendedData As DataTable) As Boolean
        Try
            frmMain.txtArolCode.Text = tempBasicData.Rows(0)("ArolCode").ToString
            If tempExtendedData IsNot Nothing Then
                frmMain.txtDataInserimento.Text = tempExtendedData.Rows(0)("DataInserimento").ToString
                frmMain.txtCodificaRichiestaDa.Text = tempExtendedData.Rows(0)("RichiestoDa").ToString
                If Not IsDBNull(tempExtendedData.Rows(0)("DataModifica")) Then
                    frmMain.txtDataUltimaModifica.Text = tempExtendedData.Rows(0)("DataModifica").ToString
                End If
                frmMain.txtInseritoDa.Text = tempExtendedData.Rows(0)("InseritoDa").ToString
                If Not IsDBNull(tempExtendedData.Rows(0)("ModificatoDa")) Then
                    frmMain.txtModificatoDa.Text = tempExtendedData.Rows(0)("ModificatoDa").ToString
                End If
                Select Case tempExtendedData.Rows(0)("Stato")
                    Case 0
                        frmMain.txtStatoAttuale.Text = "Codice attivo"
                    Case 1
                        frmMain.txtStatoAttuale.Text = "Solo per ricambio"
                    Case 2
                        frmMain.txtStatoAttuale.Text = "In obsolescenza"
                    Case 3
                        frmMain.txtStatoAttuale.Text = "Annullato"
                    Case Else
                        Return False
                        Exit Function
                End Select
                If Not IsDBNull(tempExtendedData.Rows(0)("Note")) Then
                    frmMain.txtNote.Text = tempExtendedData.Rows(0)("Note").ToString
                End If
                If Not (IsDBNull(tempExtendedData.Rows(0)("PuntoLotto"))) Then
                    frmMain.txtLotto.Text = tempExtendedData.Rows(0)("PuntoLotto").ToString
                End If
                If Not (IsDBNull(tempExtendedData.Rows(0)("PuntoRiordino"))) Then
                    frmMain.txtRiordino.Text = tempExtendedData.Rows(0)("PuntoRiordino").ToString
                End If
                If Not (IsDBNull(tempExtendedData.Rows(0)("TipoParte"))) Then
                    frmMain.txtTipoParte.Text = tempExtendedData.Rows(0)("TipoParte")
                End If
                If Not (IsDBNull(tempExtendedData.Rows(0)("ScortaSicurezza"))) Then
                    frmMain.txtScortaSicurezza.Text = tempExtendedData.Rows(0)("ScortaSicurezza").ToString
                End If
                If Not (IsDBNull(tempExtendedData.Rows(0)("CostoUltimo"))) Then
                    Dim strTemp As Array = Split(tempExtendedData.Rows(0)("CostoUltimo").ToString, ",")
                    frmMain.txtCostoUltimo.Text = strTemp(0) & "," & Left(strTemp(1), 2) & " €"
                End If
            End If
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NEL POPOLAMENTO DEL FORM DETTAGLIO ARTICOLO", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fEditExistingCode() As Boolean
        Try
            'Recupero l'informazione di componente codificato o componente consumabile
            Dim tableName As String
            Dim tableNameEsteso As String
            Dim iSelectedDgvID As Integer
            Select Case frmMain.CompEleControl.SelectedIndex
                Case 0
                    tableName = "codificati"
                    tableNameEsteso = "datiEstesiCodificati"
                    iSelectedDgvID = frmMain.dgvCEDBViewer.CurrentCell.RowIndex
                Case 1
                    tableName = "consumabili"
                    tableNameEsteso = "datiEstesiConsumabili"
                    iSelectedDgvID = frmMain.dgvCSDBViewer.CurrentCell.RowIndex
                Case Else
                    Return False
                    Exit Function
            End Select
            'Recupero il ID della tabella relativa
            Dim tempData, tempDataEsteso As DataTable
            tempData = frmMain.dbWarehouse.fFindInColumn(frmArticlesModification.txtArolCode.Text, "ArolCode", tableName, frmMain.dbWarehouse.SQLConn)
            tempDataEsteso = frmMain.dbWarehouse.fFindInColumn(frmArticlesModification.txtArolCode.Text, "ArolCode", tableNameEsteso, frmMain.dbWarehouse.SQLConn)
            If tempData.Rows.Count > 0 Then
                If tableName = "codificati" Then
                    fUpdateCodificatiElement(tempData.Rows(0)("ID"), tempData.Rows(0)("ArolCode"), frmArticlesModification.txtCommercialCode.Text, frmArticlesModification.txtDescription.Text, frmArticlesModification.txtConstructor.Text, frmArticlesModification.txtSuppDescription.Text)
                ElseIf tableName = "consumabili" Then
                    fUpdateConsumabiliElement(tempData.Rows(0)("ID"), tempData.Rows(0)("ArolCode"), frmArticlesModification.txtCommercialCode.Text, frmArticlesModification.txtDescription.Text, frmArticlesModification.txtConstructor.Text, frmArticlesModification.txtSuppDescription.Text)
                End If
                'Aggiornare i dati estesi
                If tempDataEsteso.Rows.Count > 0 Then
                    Dim strTempToday As String = Date.Now.Day & "/" & Date.Now.Month & "/" & Date.Now.Year
                    Dim iStatoComponente As Integer
                    Dim test As Integer = frmArticlesModification.cbxModificaStato.SelectedIndex
                    If frmArticlesModification.cbxModificaStato.SelectedIndex >= 0 Then
                        iStatoComponente = frmArticlesModification.cbxModificaStato.SelectedIndex
                    Else
                        Select Case frmArticlesModification.txtStatoAttuale.Text
                            Case "Codice attivo"
                                iStatoComponente = 0
                            Case "Solo per ricambio"
                                iStatoComponente = 1
                            Case "In obsolescenza"
                                iStatoComponente = 2
                            Case "Annullato"
                                iStatoComponente = 3
                        End Select
                    End If
                    fUpdateExtendedData(tempDataEsteso.Rows(0)("ID"), iStatoComponente, frmMain.strUsername, strTempToday, frmArticlesModification.txtNote.Text, tableNameEsteso, frmArticlesModification.txtLotto.Text, frmArticlesModification.txtRiordino.Text, frmArticlesModification.txtScortaSicurezza.Text, Convert.ToInt16(frmArticlesModification.txtTipoParte.Text))
                End If
                'Rileggo i dati
                tempData = frmMain.dbWarehouse.fFindInColumn(frmArticlesModification.txtArolCode.Text, "ArolCode", tableName, frmMain.dbWarehouse.SQLConn)
                tempDataEsteso = frmMain.dbWarehouse.fFindInColumn(frmArticlesModification.txtArolCode.Text, "ArolCode", tableNameEsteso, frmMain.dbWarehouse.SQLConn)
                fPopulateArticlesDetails(tempData, tempDataEsteso)
                fPopulateArticlesModification(tempData)
            Else
                MsgBox("ELEMENTO NON TROVATO", MsgBoxStyle.Critical)
                Return False
                Exit Function
            End If
            'Generare la stringa per email
            fGenerateStringForEmail(tempData.Rows(0)("ID"), tableName)
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NELLA MODIFICA DELL'ELEMENTO ESISTENTE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fUpdateExtendedData(selectedID As Integer, stato As Integer, modificatoDa As String, dataModifica As String, note As String, strTableName As String, strPuntoLotto As String, strPuntoRiordino As String, strScorta As String, iTipoParte As Integer) As Boolean
        Try
            Dim strTempQuery As String = "UPDATE " & strTableName & " SET Stato=@stato, ModificatoDa=@modificatoDa, DataModifica=@dataModifica, Note=@note, PuntoLotto=@PuntoLotto, PuntoRiordino=@PuntoRiordino, ScortaSicurezza=@Scorta, TipoParte=@TipoParte  WHERE ID = '" & selectedID & "'"
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(strTempQuery, frmMain.dbWarehouse.SQLConn)
            sqlCmd.Parameters.AddWithValue("@stato", stato)
            sqlCmd.Parameters.AddWithValue("@modificatoDa", modificatoDa)
            sqlCmd.Parameters.AddWithValue("@dataModifica", dataModifica)
            sqlCmd.Parameters.AddWithValue("@note", note)
            sqlCmd.Parameters.AddWithValue("@PuntoLotto", strPuntoLotto)
            sqlCmd.Parameters.AddWithValue("@PuntoRiordino", strPuntoRiordino)
            sqlCmd.Parameters.AddWithValue("@Scorta", strScorta)
            sqlCmd.Parameters.AddWithValue("@TipoParte", iTipoParte)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NELLA MODIFICA DEI DATI ESTESI", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fUndoModification() As Boolean
        Try
            'Recupero l'informazione di componente codificato o consumabile
            Dim tableName As String
            Dim tableNameEsteso As String
            Select Case frmMain.CompEleControl.SelectedIndex
                Case 0
                    tableName = "codificati"
                    tableNameEsteso = "datiEstesiCodificati"
                Case 1
                    tableName = "consumabili"
                    tableNameEsteso = "datiEstesiConsumabili"
                Case Else
                    Return False
                    Exit Function
            End Select
            'Recupero il ID della tabella relativa
            Dim tempData, tempDataEsteso As DataTable
            tempData = frmMain.dbWarehouse.fFindInColumn(frmArticlesModification.txtArolCode.Text, "ArolCode", tableName, frmMain.dbWarehouse.SQLConn)
            tempDataEsteso = frmMain.dbWarehouse.fFindInColumn(frmArticlesModification.txtArolCode.Text, "ArolCode", tableNameEsteso, frmMain.dbWarehouse.SQLConn)
            'Rileggo i dati
            tempData = frmMain.dbWarehouse.fFindInColumn(frmArticlesModification.txtArolCode.Text, "ArolCode", tableName, frmMain.dbWarehouse.SQLConn)
            tempDataEsteso = frmMain.dbWarehouse.fFindInColumn(frmArticlesModification.txtArolCode.Text, "ArolCode", tableNameEsteso, frmMain.dbWarehouse.SQLConn)
            fPopulateArticlesDetails(tempData, tempDataEsteso)
            Return True
        Catch ex As Exception
            MsgBox("MO SO CAZZ....", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fDeleteExisting() As Boolean
        Try
            If MsgBox("SEI SICURO?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'Recupero l'informazione di componente codificato o consumabile
                Dim tableName As String
                Dim tableNameEstesi As String
                Dim iDeleteIndex As Integer
                Dim strArolCodeDel As String
                Select Case frmMain.CompEleControl.SelectedIndex
                    Case 0
                        tableName = "codificati"
                        tableNameEstesi = "datiEstesiCodificati"
                        iDeleteIndex = frmMain.dgvCEDBViewer.CurrentCell.RowIndex
                        strArolCodeDel = frmMain.dgvCEDBViewer.Rows(iDeleteIndex).Cells(1).Value
                    Case 1
                        tableName = "consumabili"
                        tableNameEstesi = "datiEstesiConsumabili"
                        iDeleteIndex = frmMain.dgvCSDBViewer.CurrentCell.RowIndex
                        strArolCodeDel = frmMain.dgvCSDBViewer.Rows(iDeleteIndex).Cells(1).Value
                    Case Else
                        Return False
                        Exit Function
                End Select
                'Recupero il ID della tabella relativa
                Dim tempData, tempDataEsteso As DataTable
                tempData = frmMain.dbWarehouse.fFindInColumn(strArolCodeDel, "ArolCode", tableName, frmMain.dbWarehouse.SQLConn)
                tempDataEsteso = frmMain.dbWarehouse.fFindInColumn(strArolCodeDel, "ArolCode", tableNameEstesi, frmMain.dbWarehouse.SQLConn)
                fDeleteElement(tempData.Rows(0)("ID"), tableName)
                fDeleteElement(tempDataEsteso.Rows(0)("ID"), tableNameEstesi)
                Select Case frmMain.CompEleControl.SelectedIndex
                    Case 0
                        fSelectAllAndOrder(frmMain.dgvCEDBViewer, "codificati")
                    Case 1
                        fSelectAllAndOrder(frmMain.dgvCSDBViewer, "consumabili")
                    Case Else
                        Return False
                        Exit Function
                End Select
                fClearDetailsPanel()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELLA CANCELLAZIONE DELL'ELEMENTO", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fRetrieveSelectedDgvID() As Integer
        'Recupero l'indice dell'elemento selezionato nel datagridview
        Dim rowIndex As Integer
        Select Case frmMain.CompEleControl.SelectedIndex
            Case 0
                rowIndex = frmMain.dgvCEDBViewer.CurrentCell.RowIndex
            Case 1
                rowIndex = frmMain.dgvCSDBViewer.CurrentCell.RowIndex
            Case Else
                Return 0
                Exit Function
        End Select
        Return rowIndex
    End Function
    Public Function fPopulateArticlesModification(tempData As DataTable) As Boolean
        'Recupero il contenuto dell'elemento selezionato sul datagridView e popolo il form di modifica
        Dim dgvSelectedDgv As DataGridView
        Dim tableNameEsteso As String
        Dim tempDataEsteso As DataTable
        Select Case frmMain.CompEleControl.SelectedIndex
            Case 0
                dgvSelectedDgv = frmMain.dgvCEDBViewer
                tableNameEsteso = "datiEstesiCodificati"
            Case 1
                dgvSelectedDgv = frmMain.dgvCSDBViewer
                tableNameEsteso = "datiEstesiConsumabili"
            Case Else
                Return False
                Exit Function
        End Select
        frmArticlesModification.txtArolCode.Text = tempData.Rows(0)("ArolCode").ToString 'dgvSelectedDgv.Rows(iSelectedIndex).Cells(1).Value
        frmArticlesModification.txtCommercialCode.Text = tempData.Rows(0)("CommercialCode").ToString 'dgvSelectedDgv.Rows(iSelectedIndex).Cells(2).Value
        frmArticlesModification.txtDescription.Text = tempData.Rows(0)("Description").ToString 'dgvSelectedDgv.Rows(iSelectedIndex).Cells(3).Value
        frmArticlesModification.txtConstructor.Text = tempData.Rows(0)("Manufacturer").ToString 'dgvSelectedDgv.Rows(iSelectedIndex).Cells(4).Value
        frmArticlesModification.txtSuppDescription.Text = tempData.Rows(0)("SupplementaryDescription") 'dgvSelectedDgv.Rows(iSelectedIndex).Cells(5).Value
        tempDataEsteso = frmMain.dbWarehouse.fFindInColumn(frmArticlesModification.txtArolCode.Text, "ArolCode", tableNameEsteso, frmMain.dbWarehouse.SQLConn)
        Select Case tempDataEsteso.Rows(0)("Stato")
            Case 0
                frmArticlesModification.txtStatoAttuale.Text = "Codice attivo"
            Case 1
                frmArticlesModification.txtStatoAttuale.Text = "Solo per ricambio"
            Case 2
                frmArticlesModification.txtStatoAttuale.Text = "In obsolescenza"
            Case 3
                frmArticlesModification.txtStatoAttuale.Text = "Annullato"
            Case Else
                Return False
                Exit Function
        End Select
        If Not IsDBNull(tempDataEsteso.Rows(0)("Note")) Then
            frmArticlesModification.txtNote.Text = tempDataEsteso.Rows(0)("Note").ToString
        End If
        If Not (IsDBNull(tempDataEsteso.Rows(0)("PuntoLotto"))) Then
            frmArticlesModification.txtLotto.Text = tempDataEsteso.Rows(0)("PuntoLotto").ToString
        End If
        If Not (IsDBNull(tempDataEsteso.Rows(0)("PuntoRiordino"))) Then
            frmArticlesModification.txtRiordino.Text = tempDataEsteso.Rows(0)("PuntoRiordino").ToString
        End If
        If Not (IsDBNull(tempDataEsteso.Rows(0)("TipoParte"))) Then
            frmArticlesModification.txtTipoParte.Text = tempDataEsteso.Rows(0)("TipoParte")
        End If
        If Not (IsDBNull(tempDataEsteso.Rows(0)("ScortaSicurezza"))) Then
            frmArticlesModification.txtScortaSicurezza.Text = tempDataEsteso.Rows(0)("ScortaSicurezza").ToString
        End If
        If Not (IsDBNull(tempDataEsteso.Rows(0)("CostoUltimo"))) Then
            Dim strTemp As Array = Split(tempDataEsteso.Rows(0)("CostoUltimo").ToString, ",")
            frmArticlesModification.txtCostoUltimo.Text = strTemp(0) & "," & Left(strTemp(1), 2) & " €"
        End If
        Return True
    End Function
End Module