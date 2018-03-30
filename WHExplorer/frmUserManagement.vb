Public Class frmUserManagement
    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged
        If Strings.Len(txtUserName.Text) > 0 Then
            btnFindUser.Enabled = True
        Else
            btnFindUser.Enabled = False
        End If
    End Sub

    Private Sub btnFindUser_Click(sender As Object, e As EventArgs) Handles btnFindUser.Click
        Try
            If fCheckIfUserExist(txtUserName.Text) Then
                Select Case fCheckWritePermission(txtUserName.Text)
                    Case 0
                        rbLettura.Select()
                    Case 1
                        rbScrittura.Select()
                    Case 2
                        rbAdvanced.Select()
                End Select
            Else
                MsgBox("UTENTE NON TROVATO!!", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELLA RICERCA DELL'UTENTE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
        End Try
    End Sub
    Private Sub rbLettura_CheckedChanged(sender As Object, e As EventArgs) Handles rbLettura.Click
        fChangeUserPermission(txtUserName.Text, 0)
    End Sub
    Private Sub rbScrittura_CheckedChanged(sender As Object, e As EventArgs) Handles rbScrittura.Click
        fChangeUserPermission(txtUserName.Text, 1)
    End Sub
    Private Sub rbAdvanced_CheckedChanged(sender As Object, e As EventArgs) Handles rbAdvanced.Click
        fChangeUserPermission(txtUserName.Text, 2)
    End Sub
End Class