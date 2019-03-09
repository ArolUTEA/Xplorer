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
    Public Function fCopyFromDirToDir(srcFolder As String, dstFolder As String, delete As Boolean) As Boolean
        File.Copy(srcFolder, dstFolder, True)
        If delete Then
            File.Delete(srcFolder)
        End If
        Return True
    End Function
    Public Function fCreateCodiciTxt(codiceArol As String, codiceCommerciale As String, descrizione As String, costruttore As String, descrizioneSupplementare As String) As String
        Dim iDimCodiceArol As Integer = 16
        Dim iDimCodiceCommerciale As Integer = 18
        Dim iDimDescrizione As Integer = 40
        Dim iDimCostruttore As Integer = 12
        Dim strCodiceArolPadded, strCodiceCommPadded, strDescrizionePadded, strCostruttorePadded As String
        strCodiceArolPadded = UCase(codiceArol.PadRight(iDimCodiceArol, " "))
        strCodiceCommPadded = UCase(codiceCommerciale.PadRight(iDimCodiceCommerciale, " "))
        strDescrizionePadded = UCase(descrizione.PadRight(iDimDescrizione, " "))
        strCostruttorePadded = UCase(costruttore.PadRight(iDimCostruttore, " "))
        Return UCase(strCodiceArolPadded & "|" & strCodiceCommPadded & "|" & strDescrizionePadded & "|" & strCostruttorePadded & "|" & descrizioneSupplementare)
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
            Return Nothing
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
        Return dt
    End Function
    Public Function fWriteToCsv() As Boolean
        Dim csvFilePath As String
        Try
            '1) Controllo se nel datagridview vi sono dati da esportare
            '2) Apro la finestra di selezione del path di destinazione del file csv
            '3) Genero e salvo il file .csv
            Dim tempDGV As DataGridView
            Select Case frmMain.CompEleControl.SelectedIndex
                Case 0
                    tempDGV = frmMain.dgvCEDBViewer
                Case 1
                    tempDGV = frmMain.dgvCSDBViewer
                Case Else
                    tempDGV = Nothing
                    Return False
            End Select
            If tempDGV.Rows.Count > 1 Then
                frmMain.csvFileExportBrwDial.Description = "SELEZIONA IL PERCORSO DOVE SALVARE IL FILE .CSV"
                frmMain.csvFileExportBrwDial.ShowDialog()
                Dim tempSelectedPath As String = frmMain.csvFileExportBrwDial.SelectedPath
                If tempSelectedPath IsNot "" Then
                    csvFilePath = Path.GetFullPath(tempSelectedPath) & "\EXPORT.csv"
                    Dim sw As StreamWriter
                    sw = File.AppendText(csvFilePath)
                    Dim delimeter As String = ","
                    Dim array As String() = New String(tempDGV.Columns.Count - 1) {}
                    'Copio le intestazioni del file
                    For j As Integer = 1 To tempDGV.Columns.Count - 1
                        array(j - 1) = tempDGV.Columns(j).HeaderText
                    Next
                    'Scrivo le intestazioni sul file
                    sw.WriteLine(String.Join(delimeter, array))
                    'Recupero il contenuto del datagridview
                    For i As Integer = 0 To tempDGV.Rows.Count - 1
                        For j As Integer = 1 To tempDGV.Columns.Count - 1
                            If Not tempDGV.Rows(i).IsNewRow Then
                                'Elimino le eventuali virgole, sostituisco con -
                                Dim tempString = (tempDGV(j, i).Value.ToString).Replace(",", " - ")
                                'Elimino gli eventuali line feed
                                array(j - 1) = tempString.Replace(vbLf, "")
                            End If
                        Next
                        If Not tempDGV.Rows(i).IsNewRow Then
                            'Scrivo il contenuto del datagridview sul file
                            sw.WriteLine(String.Join(delimeter, array))
                        End If
                    Next
                    'Chiudo il file
                    sw.Close()
                    MsgBox("FILE .CSV GENERATO CON SUCCESSO!!", MsgBoxStyle.Exclamation)
                Else
                    Return False
                End If
            Else
                MsgBox("NESSUN DATO DA ESPORTARE!!", MsgBoxStyle.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NELLA ESPORTAZIONE DEL CSV", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
End Module
