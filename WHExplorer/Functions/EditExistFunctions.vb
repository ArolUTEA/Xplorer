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
            fUpdateCodificatiElement = True
        Catch ex As Exception
            MsgBox("ERRORE NELLA MODIFICA DELL'ELEMENTO SELEZIONATO", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            fUpdateCodificatiElement = False
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
            fUpdateConsumabiliElement = True
        Catch ex As Exception
            MsgBox("ERRORE NELLA MODIFICA DELL'ELEMENTO SELEZIONATO", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            fUpdateConsumabiliElement = False
        End Try
    End Function
    Public Function fUndoCodificatiModification(iSelectedID As Integer, iSelectedDGVRow As Integer)
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
            End If
            tempData.Dispose()
        Catch ex As Exception
            MsgBox("ERRORE NEL RECUPERO DEI DATI, TI RICORDI COSA HAI MODIFICATO?", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Function
    Public Function fUndoConsumabiliModification(iSelectedID As Integer, iSelectedDGVRow As Integer)
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
            End If
            tempData.Dispose()
        Catch ex As Exception
            MsgBox("ERRORE NEL RECUPERO DEI DATI, TI RICORDI COSA HAI MODIFICATO?", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Function
    Public Function fGenerateStringForEmail(iSelectedID As Integer, strTableName As String) As String
        Try
            Dim tempData As DataTable
            tempData = frmMain.dbWarehouse.fSelectElementFromColumn(frmMain.dbWarehouse.SQLConn, strTableName, "ID", "ID", iSelectedID)
            If tempData.Rows.Count > 0 Then
                fGenerateStringForEmail = fCreateCodiciTxt(tempData.Rows(0)("ArolCode"), tempData.Rows(0)("CommercialCode"), tempData.Rows(0)("Description"), tempData.Rows(0)("Manufacturer"), tempData.Rows(0)("SupplementaryDescription"))
            Else
                MsgBox("NESSUN ELEMENTO TROVATO!!", MsgBoxStyle.Exclamation)
                fGenerateStringForEmail = Nothing
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELLA GENERAZIONE DELLA STRINGA PER EMAIL", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            fGenerateStringForEmail = Nothing
        End Try
    End Function
    Public Function fDeleteElement(iSelectedID As Integer, strTableName As String) As Boolean
        Try
            Dim strTempQuery As String = "DELETE FROM " & strTableName & " WHERE ID = '" & iSelectedID & "'"
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(strTempQuery, frmMain.dbWarehouse.SQLConn)
            sqlCmd.ExecuteNonQuery()
            fDeleteElement = True
        Catch ex As Exception
            MsgBox("ERRORE NELLA ELIMINAZIONE DEL ELEMENTO DAL DATABASE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            fDeleteElement = False
        End Try
    End Function
End Module