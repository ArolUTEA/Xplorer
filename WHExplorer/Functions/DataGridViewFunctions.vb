Module DataGridViewFunctions
    Public Function fChangeRowColor(datagridView As DataGridView, rowIndex As Integer, colorIndex As Integer) As Boolean
        Try
            Dim selectedColor As Color
            Select Case colorIndex
                Case 0
                    selectedColor = Color.FromArgb(204, 255, 204)
                Case 1
                    selectedColor = Color.FromArgb(255, 255, 153)
                Case 2
                    selectedColor = Color.FromArgb(255, 214, 153)
                Case 3
                    selectedColor = Color.FromArgb(255, 173, 153)
                Case Else
                    selectedColor = Nothing
            End Select
            datagridView.Rows(rowIndex).DefaultCellStyle.BackColor = selectedColor
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NEL CAMBIO COLORE DI SFONDO RIGA DEL DATAGRIDVIEW", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
End Module
