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
            Dim tempData As DataTable
            tempData = frmMain.dbWarehouse.fSelectElementFromColumn(frmMain.dbWarehouse.SQLConn, "codificati", "ID", "ID", iSelectedID)
            If tempData.Rows.Count > 0 Then
                frmMain.dgvCEDBViewer.Rows(iSelectedDGVRow).Cells(1).Value = tempData.Rows(0)("ArolCode")
                frmMain.dgvCEDBViewer.Rows(iSelectedDGVRow).Cells(2).Value = tempData.Rows(0)("CommercialCode")
                frmMain.dgvCEDBViewer.Rows(iSelectedDGVRow).Cells(3).Value = tempData.Rows(0)("Description")
                frmMain.dgvCEDBViewer.Rows(iSelectedDGVRow).Cells(4).Value = tempData.Rows(0)("Manufacturer")
                frmMain.dgvCEDBViewer.Rows(iSelectedDGVRow).Cells(5).Value = tempData.Rows(0)("SupplementaryDescription")
            Else
                MsgBox("MO SO CAZZ....", MsgBoxStyle.Critical)
                tempData.Dispose()
                Return False
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
            Dim tempData As DataTable
            tempData = frmMain.dbWarehouse.fSelectElementFromColumn(frmMain.dbWarehouse.SQLConn, "consumabili", "ID", "ID", iSelectedID)
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
            frmArticlesDetails.txtArolCode.Text = tempBasicData.Rows(0)("ArolCode")
            frmArticlesDetails.txtCommercialCode.Text = tempBasicData.Rows(0)("CommercialCode")
            frmArticlesDetails.txtDescription.Text = tempBasicData.Rows(0)("Description")
            frmArticlesDetails.txtConstructor.Text = tempBasicData.Rows(0)("Manufacturer")
            frmArticlesDetails.txtSuppDescription.Text = tempBasicData.Rows(0)("SupplementaryDescription")
            If tempExtendedData IsNot Nothing Then
                frmArticlesDetails.txtDataInserimento.Text = tempExtendedData.Rows(0)("DataInserimento")
                frmArticlesDetails.txtCodificaRichiestaDa.Text = tempExtendedData.Rows(0)("RichiestoDa")
                frmArticlesDetails.txtDataUltimaModifica.Text = tempExtendedData.Rows(0)("DataModifica")
                frmArticlesDetails.txtInseritoDa.Text = tempExtendedData.Rows(0)("InseritoDa")
                frmArticlesDetails.txtModificatoDa.Text = tempExtendedData.Rows(0)("ModificatoDa")
                Select Case tempExtendedData.Rows(0)("Stato")
                    Case 0
                        frmArticlesDetails.txtStatoAttuale.Text = "Codice attivo"
                    Case 1
                        frmArticlesDetails.txtStatoAttuale.Text = "Solo per ricambio"
                    Case 2
                        frmArticlesDetails.txtStatoAttuale.Text = "In obsolescenza"
                    Case 3
                        frmArticlesDetails.txtStatoAttuale.Text = "Annullato"
                    Case Else
                        Return False
                        Exit Function
                End Select
                frmArticlesDetails.txtNote.Text = tempExtendedData.Rows(0)("Note")
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
            Select Case frmMain.CompEleControl.SelectedIndex
                Case 0
                    tableName = "codificati"
                Case 1
                    tableName = "consumabili"
                Case Else
                    Return False
                    Exit Function
            End Select
            'Recupero il ID della tabella relativa
            Dim tempData, tempDataEsteso As DataTable
            tempData = frmMain.dbWarehouse.fFindInColumn(frmArticlesDetails.txtArolCode.Text, "ArolCode", tableName, frmMain.dbWarehouse.SQLConn)
            tempDataEsteso = frmMain.dbWarehouse.fFindInColumn(frmArticlesDetails.txtArolCode.Text, "ArolCode", "datiEstesi", frmMain.dbWarehouse.SQLConn)
            If tempData.Rows.Count > 0 Then
                If tableName = "codificati" Then
                    fUpdateCodificatiElement(tempData.Rows(0)("ID"), tempData.Rows(0)("ArolCode"), frmArticlesDetails.txtCommercialCode.Text, frmArticlesDetails.txtDescription.Text, frmArticlesDetails.txtConstructor.Text, frmArticlesDetails.txtSuppDescription.Text)
                ElseIf tableName = "consumabili" Then
                    fUpdateConsumabiliElement(tempData.Rows(0)("ID"), tempData.Rows(0)("ArolCode"), frmArticlesDetails.txtCommercialCode.Text, frmArticlesDetails.txtDescription.Text, frmArticlesDetails.txtConstructor.Text, frmArticlesDetails.txtSuppDescription.Text)
                End If
                'Aggiornare i dati estesi
                If tempDataEsteso.Rows.Count > 0 Then
                    Dim strTempToday As String = Date.Now.Day & "/" & Date.Now.Month & "/" & Date.Now.Year
                    fUpdateExtendedData(tempDataEsteso.Rows(0)("ID"), frmArticlesDetails.cbxModificaStato.SelectedIndex, frmMain.strUsername, strTempToday, frmArticlesDetails.txtNote.Text)
                End If
                'Rileggo i dati
                tempData = frmMain.dbWarehouse.fFindInColumn(frmArticlesDetails.txtArolCode.Text, "ArolCode", tableName, frmMain.dbWarehouse.SQLConn)
                tempDataEsteso = frmMain.dbWarehouse.fFindInColumn(frmArticlesDetails.txtArolCode.Text, "ArolCode", "datiEstesi", frmMain.dbWarehouse.SQLConn)
                fPopulateArticlesDetails(tempData, tempDataEsteso)
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
    Public Function fUpdateExtendedData(selectedID As Integer, stato As Integer, modificatoDa As String, dataModifica As String, note As String) As Boolean
        Try
            Dim strTempQuery As String = "UPDATE datiEstesi SET Stato=@stato, ModificatoDa=@modificatoDa, DataModifica=@dataModifica, Note=@note WHERE ID = '" & selectedID & "'"
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(strTempQuery, frmMain.dbWarehouse.SQLConn)
            sqlCmd.Parameters.AddWithValue("@stato", stato)
            sqlCmd.Parameters.AddWithValue("@modificatoDa", modificatoDa)
            sqlCmd.Parameters.AddWithValue("@dataModifica", dataModifica)
            sqlCmd.Parameters.AddWithValue("@note", note)
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
            Select Case frmMain.CompEleControl.SelectedIndex
                Case 0
                    tableName = "codificati"
                Case 1
                    tableName = "consumabili"
                Case Else
                    Return False
                    Exit Function
            End Select
            'Recupero il ID della tabella relativa
            Dim tempData, tempDataEsteso As DataTable
            tempData = frmMain.dbWarehouse.fFindInColumn(frmArticlesDetails.txtArolCode.Text, "ArolCode", tableName, frmMain.dbWarehouse.SQLConn)
            tempDataEsteso = frmMain.dbWarehouse.fFindInColumn(frmArticlesDetails.txtArolCode.Text, "ArolCode", "datiEstesi", frmMain.dbWarehouse.SQLConn)
            'Rileggo i dati
            tempData = frmMain.dbWarehouse.fFindInColumn(frmArticlesDetails.txtArolCode.Text, "ArolCode", tableName, frmMain.dbWarehouse.SQLConn)
            tempDataEsteso = frmMain.dbWarehouse.fFindInColumn(frmArticlesDetails.txtArolCode.Text, "ArolCode", "datiEstesi", frmMain.dbWarehouse.SQLConn)
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
                Select Case frmMain.CompEleControl.SelectedIndex
                    Case 0
                        tableName = "codificati"
                    Case 1
                        tableName = "consumabili"
                    Case Else
                        Return False
                        Exit Function
                End Select
                'Recupero il ID della tabella relativa
                Dim tempData, tempDataEsteso As DataTable
                tempData = frmMain.dbWarehouse.fFindInColumn(frmArticlesDetails.txtArolCode.Text, "ArolCode", tableName, frmMain.dbWarehouse.SQLConn)
                tempDataEsteso = frmMain.dbWarehouse.fFindInColumn(frmArticlesDetails.txtArolCode.Text, "ArolCode", "datiEstesi", frmMain.dbWarehouse.SQLConn)
                fDeleteElement(tempData.Rows(0)("ID"), tableName)
                fDeleteElement(tempDataEsteso.Rows(0)("ID"), "datiEstesi")
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
End Module