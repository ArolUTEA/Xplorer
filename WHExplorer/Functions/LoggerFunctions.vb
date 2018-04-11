Imports System.IO
Imports System.IO.StreamWriter
Module FileLoggerFunctions
    Public Function fAddLogRow(strFilePath As String, strRowToAdd As String) As Boolean
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(strFilePath, True)
        file.WriteLine(strRowToAdd)
        file.Close()
        Return True
    End Function
    Public Function fCheckIfLogFileExist(ByVal strFilePath As String) As Boolean
        Try
            If Not Directory.Exists(Path.GetDirectoryName(strFilePath)) Then
                Directory.CreateDirectory(Path.GetDirectoryName(strFilePath))
            End If
            If Not File.Exists(strFilePath) Then
                File.Create(strFilePath).Dispose()
            End If
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NELLA CREAZIONE DEL FILE DI LOG")
            Return False
        End Try
    End Function
End Module