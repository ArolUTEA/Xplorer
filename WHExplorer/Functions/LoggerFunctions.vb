Imports System.IO
Imports System.IO.StreamWriter
Module FileLoggerFunctions
    Public Function fAddLogRow(strFilePath As String, strRowToAdd As String)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(strFilePath, True)
        file.WriteLine(strRowToAdd)
        file.Close()
    End Function
    Public Function fCheckIfLogFileExist(ByVal strFilePath As String)
        Try
            If Not Directory.Exists(Path.GetDirectoryName(strFilePath)) Then
                Directory.CreateDirectory(Path.GetDirectoryName(strFilePath))
            End If
            If Not File.Exists(strFilePath) Then
                File.Create(strFilePath).Dispose()
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELLA CREAZIONE DEL FILE DI LOG")
        End Try
    End Function
End Module