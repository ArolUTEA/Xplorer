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
            dgvSelected.ReadOnly = True
            'All datagrid viewer rows in green
            dgvSelected.RowsDefaultCellStyle.BackColor = Color.FromArgb(204, 255, 204)
            'Leggo la tabella dei codici estesi
            If dgvSelected.Name = "dgvCEDBViewer" Then
                tempDataTable = frmMain.dbWarehouse.fSelectAllAndOrderBy(frmMain.dbWarehouse.SQLConn, "datiEstesiCodificati", "ID")
            ElseIf dgvSelected.Name = "dgvCSDBViewer" Then
                tempDataTable = frmMain.dbWarehouse.fSelectAllAndOrderBy(frmMain.dbWarehouse.SQLConn, "datiEstesiConsumabili", "ID")
            End If

            'Definisco una primary key per il tempData
            tempData.PrimaryKey = New DataColumn() {tempData.Columns("ArolCode")}
            'Controllo per quali codici è previsto uno stato diverso da 0
            For Each elemento As DataRow In tempDataTable.Rows
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
            MsgBox("ERRORE NEL POPOLAMENTO E NEL RESIZE DEL DATAGRIDVIEW", MsgBoxStyle.Critical)
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
        Dim tempBool As Boolean
        Select Case frmMain.CompEleControl.SelectedIndex
            Case 0
                'CODIFICATI
                tempBool = IsDBNull(frmMain.dgvCEDBViewer.CurrentCell.Value)
            Case 1
                'CONSUMABILI
                tempBool = IsDBNull(frmMain.dgvCSDBViewer.CurrentCell.Value)
            Case Else
                Return False
        End Select
        Dim iModifiedRowIndex, iModifiedID As Integer
        Dim strTableName As String
        If Not tempBool Then
            frmMain.sCheckIfThereAreFiles()
            If xExtendedEnabled Then
                Try
                    Select Case frmMain.CompEleControl.SelectedIndex
                        Case 0
                            'Recupero l'indice della cella selezionata
                            iModifiedRowIndex = frmMain.dgvCEDBViewer.CurrentCell.RowIndex
                            'Recupero l'ID dell'elemento che si vuole editare
                            iModifiedID = frmMain.dgvCEDBViewer.Rows(iModifiedRowIndex).Cells(0).Value
                            strTableName = "codificati"
                        Case 1
                            'Recupero l'indice della cella selezionata
                            iModifiedRowIndex = frmMain.dgvCSDBViewer.CurrentCell.RowIndex
                            'Recupero l'ID dell'elemento che si vuole editare
                            iModifiedID = frmMain.dgvCSDBViewer.Rows(iModifiedRowIndex).Cells(0).Value
                            strTableName = "consumabili"
                        Case Else
                            Exit Function
                    End Select

                    'Recupero i dati dal database
                    Dim tempBasicData, tempExtendedData As DataTable
                    tempBasicData = fRetrieveSelectedData(iModifiedID, strTableName)
                    tempExtendedData = fRetrieveExtendedData(iModifiedID, strTableName)
                    If tempExtendedData.Rows.Count > 0 Then
                        fPopulateArticlesDetails(tempBasicData, tempExtendedData)
                    Else
                        MsgBox("DATI NON DISPONIBILI", MsgBoxStyle.Critical)
                        Exit Function
                    End If
                    'frmArticlesDetails.Show()
                Catch ex As Exception
                    MsgBox("LA MEMORIA NON POTEVA ESSERE READ", MsgBoxStyle.Critical)
                    fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
                End Try
            End If
        End If
        Return True
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
End Module