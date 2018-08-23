Public Class frmArticlesDetails
    Private Sub frmArticlesDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxModificaStato.Items.Add("Attivo")
        cbxModificaStato.Items.Add("Solo ricambio")
        cbxModificaStato.Items.Add("In obsolescenza")
        cbxModificaStato.Items.Add("Annullato")
        btnSave.Enabled = False
        btnUndo.Enabled = False
        If Not frmMain.bUserWritePerm Then
            fApplyReaderOnlyPermission()
        End If
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
    Private Sub cbxModificaStato_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxModificaStato.SelectedIndexChanged
        btnSave.Enabled = True
        btnUndo.Enabled = True
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        fEditExistingCode()
    End Sub
    Private Sub btnUndo_Click(sender As Object, e As EventArgs) Handles btnUndo.Click
        fUndoModification()
    End Sub
    Private Sub btnDeleteExisting_Click(sender As Object, e As EventArgs) Handles btnDeleteExisting.Click
        fDeleteExisting()
        Me.Close()
        Select Case frmMain.CompEleControl.SelectedIndex
            Case 0
                fSelectAllAndOrder(frmMain.dgvCEDBViewer, "codificati")
            Case 1
                fSelectAllAndOrder(frmMain.dgvCSDBViewer, "consumabili")
            Case Else
                Exit Sub
        End Select
    End Sub
End Class