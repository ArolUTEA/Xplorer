Imports System.IO, System.Text
Module FileSystemFunct
    Public Function fCheckIfThereFiles(folderPath As String) As Boolean
        Dim myDir As DirectoryInfo = New DirectoryInfo(folderPath)
        If myDir.Exists Then
            If myDir.EnumerateFiles().Any() Then
                Return True
            End If
        End If
        Return False

    End Function
    Public Function fRetrieveFileName(folderPath As String) As String(,)
        Dim i As Integer = 0
        Dim tempString(Directory.GetFiles(folderPath).Length - 1, 1) As String
        For Each file As String In Directory.GetFiles(folderPath)
            Dim information = My.Computer.FileSystem.GetFileInfo(file)
            tempString(i, 0) = Path.GetFileNameWithoutExtension(information.FullName)
            tempString(i, 1) = information.Extension
            i = i + 1
        Next
        Return tempString
    End Function
    Public Function fCopyFromDirToDir(srcFolder As String, dstFolder As String, delete As Boolean)
        'Directory.Move(srcFolder, dstFolder)
        File.Copy(srcFolder, dstFolder, True)
        If delete Then
            File.Delete(srcFolder)
        End If
    End Function
    Public Function fCreateCodiciTxt(codiceArol As String, codiceCommerciale As String, descrizione As String, costruttore As String, descrizioneSupplementare As String) As String
        Dim iDimCodiceArol As Integer = 16
        Dim iDimCodiceCommerciale As Integer = 18
        Dim iDimDescrizione As Integer = 40
        Dim iDimCostruttore As Integer = 12
        Dim strCodiceArolPadded, strCodiceCommPadded, strDescrizionePadded, strCostruttorePadded, strDescrSuppPadded As String
        strCodiceArolPadded = UCase(codiceArol.PadRight(iDimCodiceArol, " "))
        strCodiceCommPadded = UCase(codiceCommerciale.PadRight(iDimCodiceCommerciale, " "))
        strDescrizionePadded = UCase(descrizione.PadRight(iDimDescrizione, " "))
        strCostruttorePadded = UCase(costruttore.PadRight(iDimCostruttore, " "))
        fCreateCodiciTxt = UCase(strCodiceArolPadded & "|" & strCodiceCommPadded & "|" & strDescrizionePadded & "|" & strCostruttorePadded & "|" & descrizioneSupplementare)
    End Function
    Public Function fCheckEstensione(filename As String, expectedExtension As String) As Boolean
        Dim infoFile = My.Computer.FileSystem.GetFileInfo(filename)
        Dim extension = infoFile.Extension
        If extension = expectedExtension Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fReadAllFileReturnDataTable(filename As String) As DataTable
        Dim source As String = String.Empty
        Dim dt As DataTable = New DataTable
        If IO.File.Exists(filename) Then
            source = IO.File.ReadAllText(filename)
        Else
            fReadAllFileReturnDataTable = Nothing
            Exit Function
        End If
        Dim rows() As String = source.Split({Environment.NewLine}, StringSplitOptions.None)
        Dim delimetter As Char = "|"
        For i As Integer = 0 To rows(0).Split(delimetter).Length - 1
            Dim column As String = rows(0).Split(delimetter)(i)
            dt.Columns.Add(column)
        Next
        For i As Integer = 2 To rows.Length - 1
            Dim dr As DataRow = dt.NewRow
            For x As Integer = 0 To rows(i).Split(delimetter).Length - 1
                If x <= dt.Columns.Count - 1 Then
                    dr(x) = rows(i).Split(delimetter)(x)
                End If
            Next
            dt.Rows.Add(dr)
        Next
        fReadAllFileReturnDataTable = dt
    End Function
End Module
