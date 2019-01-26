Imports System.IO
Public Class frmNewDocument
    Private Sub frmNewDocument_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Popolo la combobox di selezione della tipologia
        Dim tempDataTable As DataTable
        Try
            tempDataTable = frmMain.dbWarehouse.fSelectAllAndOrderBy(frmMain.dbWarehouse.SQLConn, "tipologiaDocumentazione", "ID")
            For i As Integer = 0 To tempDataTable.Rows.Count - 1
                cbxSelectType.Items.Add(tempDataTable.Rows(i)(2))
            Next
        Catch ex As Exception
            tempDataTable = Nothing
            MsgBox("ERRORE NEL POPOLAMENTO DELLA COMBO CATEGORIE ", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
        tempDataTable.Dispose()
        'Abilito il dgvConnectTo alla modifica
        dgvConnectTo.Columns(0).ReadOnly = False
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            brwPathDialogSelection.ShowDialog()
            Dim tempFilePath As String
            tempFilePath = Path.GetFullPath(brwPathDialogSelection.FileName)
            If tempFilePath IsNot Nothing Then
                txtFilePath.Text = tempFilePath
            Else
                txtFilePath.Text = ""
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELLA RICERCA DEL FILE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        dgvConnectTo.Rows.Add()
        If Not btnSub.Enabled Then
            btnSub.Enabled = True
        End If
    End Sub
    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        If dgvConnectTo.Rows.Count > 1 Then
            dgvConnectTo.AllowUserToAddRows = False
            dgvConnectTo.Rows.RemoveAt(dgvConnectTo.Rows.Count - 1)
            dgvConnectTo.AllowUserToAddRows = True
        Else
            btnSub.Enabled = False
        End If
    End Sub

    Private Sub dgvConnectTo_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConnectTo.CellValidated
        Dim tempDataTable As DataTable
        If dgvConnectTo.CurrentCell.Value IsNot Nothing Then
            tempDataTable = frmMain.dbWarehouse.fFindInColumn(dgvConnectTo.CurrentCell.Value.ToString, "ArolCode", "codificati", frmMain.dbWarehouse.SQLConn)
            If tempDataTable.Rows.Count = 0 Then
                tempDataTable = frmMain.dbWarehouse.fFindInColumn(dgvConnectTo.CurrentCell.Value.ToString, "ArolCode", "consumabili", frmMain.dbWarehouse.SQLConn)
                If tempDataTable.Rows.Count = 0 Then
                    dgvConnectTo.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(255, 173, 153)
                Else
                    dgvConnectTo.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(204, 255, 204)
                    fCheckIfOnlyOneAndPopulateDgv(tempDataTable)
                End If
            Else
                dgvConnectTo.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(204, 255, 204)
                fCheckIfOnlyOneAndPopulateDgv(tempDataTable)
            End If
        End If
    End Sub
    Public Function fCheckIfOnlyOneAndPopulateDgv(dataValue As DataTable) As Boolean
        If dataValue.Rows.Count > 1 Then
            dgvConnectTo.CurrentRow.DefaultCellStyle.BackColor = Color.FromArgb(255, 173, 153)
            Return False
        Else
            dgvConnectTo.CurrentRow.Cells(0).Value = dataValue.Rows(0)(1).ToString
            dgvConnectTo.CurrentRow.Cells(1).Value = dataValue.Rows(0)(2).ToString
            dgvConnectTo.CurrentRow.Cells(2).Value = dataValue.Rows(0)(3).ToString
            dgvConnectTo.CurrentRow.Cells(3).Value = dataValue.Rows(0)(4).ToString
            dgvConnectTo.AutoResizeColumns()
            Return True
        End If
    End Function
End Class