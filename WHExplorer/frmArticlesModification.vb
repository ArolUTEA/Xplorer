Public Class frmArticlesModification
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        fEditExistingCode()
    End Sub

    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        'Recupero il ID della tabella relativa
        Dim tempData, tempDataEsteso As DataTable
        Dim tableName, tableNameEsteso As String
        Dim selectedDgvRow As Integer
        Select Case frmMain.CompEleControl.SelectedIndex
            Case 0
                tableName = "codificati"
                tableNameEsteso = "datiEstesiCodificati"
                selectedDgvRow = frmMain.dgvCEDBViewer.CurrentCell.RowIndex
            Case 1
                tableName = "consumabili"
                tableNameEsteso = "datiEstesiConsumabili"
                selectedDgvRow = frmMain.dgvCSDBViewer.CurrentCell.RowIndex
            Case Else
                tableName = ""
                tableNameEsteso = ""
                selectedDgvRow = 0
                Exit Sub
        End Select
        tempData = frmMain.dbWarehouse.fFindInColumn(txtArolCode.Text, "ArolCode", tableName, frmMain.dbWarehouse.SQLConn)
        tempDataEsteso = frmMain.dbWarehouse.fFindInColumn(txtArolCode.Text, "ArolCode", tableNameEsteso, frmMain.dbWarehouse.SQLConn)
        Select Case frmMain.CompEleControl.SelectedIndex
            Case 0
                fUndoCodificatiModification(tempData.Rows(0)("ID"), selectedDgvRow)
            Case 1
                fUndoConsumabiliModification(tempData.Rows(0)("ID"), selectedDgvRow)
            Case Else
                MsgBox("ORA TOCCA FARE TUTTO UN TRIGO...", MsgBoxStyle.Exclamation)
        End Select
    End Sub

    Private Sub txtArolCode_TextChanged(sender As Object, e As EventArgs) Handles txtArolCode.TextChanged
        btnSave.Enabled = True
        btnUndo.Enabled = True
    End Sub

    Private Sub txtCommercialCode_TextChanged(sender As Object, e As EventArgs) Handles txtCommercialCode.TextChanged
        btnSave.Enabled = True
        btnUndo.Enabled = True
    End Sub

    Private Sub txtDescription_TextChanged(sender As Object, e As EventArgs) Handles txtDescription.TextChanged
        btnSave.Enabled = True
        btnUndo.Enabled = True
    End Sub

    Private Sub txtConstructor_TextChanged(sender As Object, e As EventArgs) Handles txtConstructor.TextChanged
        btnSave.Enabled = True
        btnUndo.Enabled = True
    End Sub

    Private Sub txtSuppDescription_TextChanged(sender As Object, e As EventArgs) Handles txtSuppDescription.TextChanged
        btnSave.Enabled = True
        btnUndo.Enabled = True
    End Sub

    Private Sub txtNote_TextChanged(sender As Object, e As EventArgs) Handles txtNote.TextChanged
        btnSave.Enabled = True
        btnUndo.Enabled = True
    End Sub

    Private Sub txtTipoParte_TextChanged(sender As Object, e As EventArgs) Handles txtTipoParte.TextChanged
        btnSave.Enabled = True
        btnUndo.Enabled = True
    End Sub

    Private Sub txtRiordino_TextChanged(sender As Object, e As EventArgs) Handles txtRiordino.TextChanged
        btnSave.Enabled = True
        btnUndo.Enabled = True
    End Sub

    Private Sub txtScortaSicurezza_TextChanged(sender As Object, e As EventArgs) Handles txtScortaSicurezza.TextChanged
        btnSave.Enabled = True
        btnUndo.Enabled = True
    End Sub

    Private Sub txtLotto_TextChanged(sender As Object, e As EventArgs) Handles txtLotto.TextChanged
        btnSave.Enabled = True
        btnUndo.Enabled = True
    End Sub

    Private Sub cbxModificaStato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxModificaStato.SelectedIndexChanged
        btnSave.Enabled = True
        btnUndo.Enabled = True
    End Sub

    Private Sub frmArticlesModification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxModificaStato.Items.Add("Attivo")
        cbxModificaStato.Items.Add("Solo per ricambio")
        cbxModificaStato.Items.Add("In obsolescenza")
        cbxModificaStato.Items.Add("Annullato")
    End Sub

    Private Sub btnDeleteExisting_Click(sender As Object, e As EventArgs) Handles btnDeleteExisting.Click
        fDeleteExisting()
    End Sub
End Class