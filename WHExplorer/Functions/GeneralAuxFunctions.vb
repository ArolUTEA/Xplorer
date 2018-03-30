Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles
Module GeneralAuxFunctions
    Public Function fReturnTableName() As String
        Try
            Select Case frmMain.CompEleControl.SelectedIndex
                Case 0
                    fReturnTableName = "codificati"
                Case 1
                    fReturnTableName = "consumabili"
            End Select
        Catch ex As Exception
            MsgBox("ERRORE NELLA SELEZIONE DELLA TABELLA", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Function
    Public Function fPopulateAndResizeDGV(dgvSelected As DataGridView, tempData As DataTable, iDGVWidth As Integer)
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
        Catch ex As Exception
            MsgBox("ERRORE NEL POPOLAMENTO E NEL RESIZE DEL DATAGRIDVIEW", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Function
    Public Function fDeleteFromDGV(dgvSelected As DataGridView, iSelectedRow As Integer)
        Try
            dgvSelected.Rows(iSelectedRow).Selected = True
            For Each dr In dgvSelected.SelectedRows
                dgvSelected.Rows.Remove(dr)
            Next
        Catch ex As Exception
            MsgBox("ERRORE NELLA CANCELLAZIONE DAL DATAGRIDVIEW", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Function
    Public Function fManagementOfDgvClickOrKeyMove()
        Dim tempBool As Boolean
        Select Case frmMain.CompEleControl.SelectedIndex
            Case 0
                'CODIFICATI
                tempBool = IsDBNull(frmMain.dgvCEDBViewer.CurrentCell.Value)
            Case 1
                'CONSUMABILI
                tempBool = IsDBNull(frmMain.dgvCSDBViewer.CurrentCell.Value)
            Case Else
                Exit Function
        End Select
        If Not tempBool Then
            frmMain.sCheckIfThereAreFiles()
            If frmMain.bUserWritePerm Then
                frmMain.btnEdit.Enabled = True
                frmMain.btnDelete.Enabled = True
            End If
        End If
    End Function
End Module