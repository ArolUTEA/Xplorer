Public Class CestinoClassi
    Public Function fFindInDatabase(strTextToFind As String)
        Try
            If SQLConn.State = SQLConn.State.Open Then
                Dim SQLcmd As SQLiteCommand = New SQLiteCommand(SQLConn)
                SQLcmd.CommandText = "Select * FROM codificati WHERE ArolCode LIKE '%" & strTextToFind & "%'"
                Dim dataRead As SQLiteDataReader = SQLcmd.ExecuteReader
                If dataRead.HasRows Then
                    Dim ListRow = 0
                    While dataRead.Read()
                        strReadResult.Add(New List(Of String))
                        For i As Integer = 0 To dataRead.FieldCount - 1
                            strReadResult(ListRow).Add(dataRead.Item(i))
                        Next
                        ListRow = ListRow + 1
                    End While
                Else
                    MsgBox("No result found", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            MsgBox("ERROR: " & ex.ToString, MsgBoxStyle.Critical)
            SQLConn.Dispose()
        End Try
    End Function
End Class
