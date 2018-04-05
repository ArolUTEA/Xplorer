Public Class frmChangePassword
    Private Sub btnOkChangePwd_Click(sender As Object, e As EventArgs) Handles btnOkChangePwd.Click
        If fChangePassword(txtUsername.Text, txtOldPwd.Text, txtNewPwd.Text, txtConfirmPwd.Text) Then
            MsgBox("PASSWORD CAMBIATA CON SUCCESSO!!", MsgBoxStyle.Exclamation)
            ActiveForm.Close()
        Else
            MsgBox("CAMBIAMENTO PASSWORD NON RIUSCITO", MsgBoxStyle.Critical)
            ActiveForm.Close()
        End If
    End Sub

    Private Sub btnCancelChangePwd_Click(sender As Object, e As EventArgs) Handles btnCancelChangePwd.Click
        ActiveForm.Close()
    End Sub
End Class