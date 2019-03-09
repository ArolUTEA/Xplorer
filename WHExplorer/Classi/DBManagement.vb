Imports System.Data.SQLite
Imports System.IO
Public Class DBManagement
    Public SQLConn As SQLiteConnection = New SQLiteConnection()
    Public stOpResult As String
    Public bIsConnected As Boolean
    Public strReadResult As New List(Of List(Of String))
    Dim bDestInit As Boolean = False
    Dim bSourceInit As Boolean = False
    Public Function fConnection(strConnectionString As String) As Boolean
        Try
            SQLConn.ConnectionString = strConnectionString
            SQLConn.Open()
            stOpResult = SQLConn.State.ToString()
            If SQLConn.State = ConnectionState.Open Then
                bIsConnected = True
            Else
                bIsConnected = False
            End If
            Return True
        Catch ex As Exception
            MsgBox("ERROR: " & ex.ToString, MsgBoxStyle.Critical)
            SQLConn.Dispose()
            Return False
        End Try
    End Function
    Public Function fDisconnect() As Boolean
        Try
            SQLConn.Close()
            stOpResult = SQLConn.State.ToString()
            Return True
        Catch ex As Exception
            MsgBox("ERROR: " & ex.ToString, MsgBoxStyle.Critical)
            SQLConn.Dispose()
            Return False
        End Try
    End Function
    Public Function fFindInDatabase(strTextToFind As String, dbSource As SQLiteConnection, tableName As String) As DataTable
        Try
            If dbSource.State = ConnectionState.Open Then
                Dim cmd = "SELECT * FROM " & tableName & " WHERE ArolCode LIKE '%" & strTextToFind & "%' OR CommercialCode LIKE '%" & strTextToFind & "%' OR Description LIKE '%" & strTextToFind & "%' OR Manufacturer LIKE '%" & strTextToFind & "%' OR SupplementaryDescription LIKE '%" & strTextToFind & "%'"
                Dim cmdDataGrid As SQLiteCommand = New SQLiteCommand(cmd, dbSource)
                Dim da As New SQLiteDataAdapter
                da.SelectCommand = cmdDataGrid
                Dim dt As New DataTable
                da.Fill(dt)
                cmdDataGrid.ExecuteReader()
                cmdDataGrid.Dispose()
                da.Dispose()
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            fFindInDatabase = Nothing
            MsgBox("ERROR: " & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Function
    Public Function fWriteFileInDatabase(fileName As String, filePath As String, fileData As Byte(), dbDest As SQLiteConnection, tableName As String) As Boolean
        If dbDest.State = ConnectionState.Open Then
            Dim cmd = "INSERT INTO " & tableName & "(Name, Data) VALUES(@Name, @Data)"
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(cmd, dbDest)
            sqlCmd.Parameters.AddWithValue("@Name", fileName)
            sqlCmd.Parameters.AddWithValue("@Data", fileData)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fReadFileFromDatabase(id As Integer, dbSource As SQLiteConnection, tableName As String) As Boolean
        If dbSource.State = ConnectionState.Open Then
            Dim cmd = "SELECT Name, FileExtension, Link FROM " & tableName & " WHERE ID = @ID"
            Dim sqlcmd As SQLiteCommand = New SQLiteCommand(cmd, dbSource)
            sqlcmd.Parameters.AddWithValue("@ID", id)
            Dim da As New SQLiteDataAdapter
            da.SelectCommand = sqlcmd
            Dim dt As New DataTable
            da.Fill(dt)
            sqlcmd.ExecuteReader()
            If dt IsNot Nothing Then
                Process.Start(Convert.ToString(dt.Rows(0)("Link")))
            End If
            sqlcmd.Dispose()
            da.Dispose()
            dt.Dispose()
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fChekHowManyExistsAndRead(element As String, dbSource As SQLiteConnection, tableName As String, column As String) As Boolean
        If dbSource.State = ConnectionState.Open Then
            Dim cmd = "SELECT * FROM " & tableName & " WHERE Name = '" & element & "'"
            Dim sqlcmd As SQLiteCommand = New SQLiteCommand(cmd, dbSource)
            Dim da As New SQLiteDataAdapter
            da.SelectCommand = sqlcmd
            Dim dt As New DataTable
            da.Fill(dt)
            sqlcmd.ExecuteReader()
            If dt.Rows.Count > 0 Then
                For Each i In dt.Rows
                    fReadFileFromDatabase(dt.Rows(0)("ID"), dbSource, tableName)
                Next
            Else
                MsgBox("No Files Found")
            End If
            sqlcmd.Dispose()
            da.Dispose()
            dt.Dispose()
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fInsertDatasheetInDatabase(strComponentName As String, strFileExtension As String, strFilePath As String, dbDest As SQLiteConnection, strTableName As String) As Boolean
        If dbDest.State = ConnectionState.Open Then
            Dim cmd = "INSERT INTO " & strTableName & "(Name, FileExtension, Link) VALUES (@Name, @FileExtension, @Link)"
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(cmd, dbDest)
            sqlCmd.Parameters.AddWithValue("@Name", strComponentName)
            sqlCmd.Parameters.AddWithValue("@FileExtension", strFileExtension)
            sqlCmd.Parameters.AddWithValue("@Link", strFilePath)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fLookIfHaveDataSheet(strElement As String, dbSource As SQLiteConnection, strTableName As String, strColumn As String) As Boolean
        If dbSource.State = ConnectionState.Open Then
            Dim cmd = "SELECT * FROM " & strTableName & " WHERE Name = '" & strElement & "'"
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(cmd, dbSource)
            Dim da As New SQLiteDataAdapter
            da.SelectCommand = sqlCmd
            Dim dt As New DataTable
            da.Fill(dt)
            sqlCmd.ExecuteReader()
            If dt.Rows.Count > 0 Then
                sqlCmd.Dispose()
                da.Dispose()
                dt.Dispose()
                Return True
            Else
                sqlCmd.Dispose()
                da.Dispose()
                dt.Dispose()
                Return False
            End If
        Else
            Return False
        End If
    End Function
    Public Function fLookIfThereAreDocuments(strElement As String, dbSource As SQLiteConnection, strTableName As String, strColumn As String) As DataTable
        If dbSource.State = ConnectionState.Open Then
            Dim cmd = "SELECT * FROM " & strTableName & " WHERE ArolCode = '" & strElement & "'"
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(cmd, dbSource)
            Dim da As New SQLiteDataAdapter
            da.SelectCommand = sqlCmd
            Dim dt As New DataTable
            da.Fill(dt)
            sqlCmd.ExecuteReader()
            If dt.Rows.Count > 0 Then
                sqlCmd.Dispose()
                da.Dispose()
                Return dt
            Else
                sqlCmd.Dispose()
                da.Dispose()
                dt.Dispose()
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function
    Public Function fCheckIfAlreadyExist(strElement As String, dbSource As SQLiteConnection, strTableName As String, strColumn As String) As Boolean
        If dbSource.State = ConnectionState.Open Then
            Dim cmd = "SELECT * FROM " & strTableName & " WHERE " & strColumn & " = '" & strElement & "'"
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(cmd, dbSource)
            Dim da As New SQLiteDataAdapter
            da.SelectCommand = sqlCmd
            Dim dt As New DataTable
            da.Fill(dt)
            sqlCmd.ExecuteReader()
            If dt.Rows.Count > 0 Then
                sqlCmd.Dispose()
                da.Dispose()
                dt.Dispose()
                Return True
            Else
                sqlCmd.Dispose()
                da.Dispose()
                dt.Dispose()
                Return False
            End If
        Else
            Return False
        End If
    End Function
    Public Function fSelectAndOrderAllInDatabase(dbSource As SQLiteConnection, tableName As String, columnName As String, orderColumn As String) As DataTable
        Try
            If dbSource.State = ConnectionState.Open Then
                Dim cmd = "SELECT " & columnName & " FROM " & tableName & " ORDER BY " & orderColumn
                Dim cmdDataGrid As SQLiteCommand = New SQLiteCommand(cmd, dbSource)
                Dim da As New SQLiteDataAdapter
                da.SelectCommand = cmdDataGrid
                Dim dt As New DataTable
                da.Fill(dt)
                cmdDataGrid.ExecuteReader()
                cmdDataGrid.Dispose()
                da.Dispose()
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("ERROR: " & ex.ToString, MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function
    Public Function fSelectElementFromColumn(dbSource As SQLiteConnection, tableName As String, columnName As String, orderColumn As String, elementName As String) As DataTable
        Try
            If dbSource.State = ConnectionState.Open Then
                Dim cmd = "SELECT * FROM " & tableName & " WHERE " & columnName & " = '" & elementName & "'"
                Dim cmdDataGrid As SQLiteCommand = New SQLiteCommand(cmd, dbSource)
                Dim da As New SQLiteDataAdapter
                da.SelectCommand = cmdDataGrid
                Dim dt As New DataTable
                da.Fill(dt)
                cmdDataGrid.ExecuteReader()
                cmdDataGrid.Dispose()
                da.Dispose()
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("ERROR: " & ex.ToString, MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function
    Public Function fExecuteGenericQuery(dbSource As SQLiteConnection, strQuery As String) As DataTable
        Try
            If dbSource.State = ConnectionState.Open Then
                Dim cmd = strQuery
                Dim cmdDataGrid As SQLiteCommand = New SQLiteCommand(cmd, dbSource)
                Dim da As New SQLiteDataAdapter
                da.SelectCommand = cmdDataGrid
                Dim dt As New DataTable
                da.Fill(dt)
                cmdDataGrid.ExecuteReader()
                cmdDataGrid.Dispose()
                da.Dispose()
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("ERROR: " & ex.ToString, MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function
    Public Function fExecuteGenericInsert(dbSource As SQLiteConnection, strQuery As String) As DataTable
        Try
            If dbSource.State = ConnectionState.Open Then
                Dim cmd = strQuery
                Dim cmdDataGrid As SQLiteCommand = New SQLiteCommand(cmd, dbSource)
                Dim da As New SQLiteDataAdapter
                da.SelectCommand = cmdDataGrid
                Dim dt As New DataTable
                cmdDataGrid.ExecuteReader()
                cmdDataGrid.Dispose()
                da.Dispose()
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("ERROR: " & ex.ToString, MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function
    Public Function fInsertNewComponent(dbDest As SQLiteConnection, strTableName As String, strArolCode As String, strCommercialCode As String, strDescription As String, strManufacturer As String, strSupplementaryDescription As String) As Boolean
        If dbDest.State = ConnectionState.Open Then
            Dim cmd = "INSERT INTO " & strTableName & "(ArolCode, CommercialCode, Description, Manufacturer, SupplementaryDescription) VALUES (@ArolCode, @CommercialCode, @Description, @Manufacturer, @SupplementaryDescription)"
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(cmd, dbDest)
            sqlCmd.Parameters.AddWithValue("@ArolCode", strArolCode)
            sqlCmd.Parameters.AddWithValue("@CommercialCode", strCommercialCode)
            sqlCmd.Parameters.AddWithValue("@Description", strDescription)
            sqlCmd.Parameters.AddWithValue("@Manufacturer", strManufacturer)
            sqlCmd.Parameters.AddWithValue("@SupplementaryDescription", strSupplementaryDescription)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fInsertNewExtendedData(dbDest As SQLiteConnection, strTableName As String, strArolCode As String, strStato As String, strDataInserimento As String, strInseritoDa As String, strRichiestoDa As String, strNote As String, strTipoParte As String, strPuntoLotto As String, strPuntoRiordino As String, strScortaSicurezza As String) As Boolean
        If dbDest.State = ConnectionState.Open Then
            Dim cmd = "INSERT INTO " & strTableName & "(ArolCode, Stato, DataInserimento, InseritoDa, RichiestoDa, Note, TipoParte, PuntoLotto, PuntoRiordino, ScortaSicurezza) VALUES (@ArolCode, @Stato, @DataInserimento, @InseritoDa, @RichiestoDa, @Note, @TipoParte, @PuntoLotto, @PuntoRiordino, @ScortaSicurezza)"
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(cmd, dbDest)
            sqlCmd.Parameters.AddWithValue("@ArolCode", strArolCode)
            sqlCmd.Parameters.AddWithValue("@Stato", strStato)
            sqlCmd.Parameters.AddWithValue("@DataInserimento", strDataInserimento)
            sqlCmd.Parameters.AddWithValue("@InseritoDa", strInseritoDa)
            sqlCmd.Parameters.AddWithValue("@RichiestoDa", strRichiestoDa)
            sqlCmd.Parameters.AddWithValue("@Note", strNote)
            sqlCmd.Parameters.AddWithValue("@TipoParte", strTipoParte)
            sqlCmd.Parameters.AddWithValue("@PuntoLotto", strPuntoLotto)
            sqlCmd.Parameters.AddWithValue("@PuntoRiordino", strPuntoRiordino)
            sqlCmd.Parameters.AddWithValue("@ScortaSicurezza", strScortaSicurezza)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            Return True
        Else
            Return False
        End If
    End Function
    Public Function fFindInColumn(strItemToFind As String, strColumnName As String, strTableName As String, dbDatabaseConnection As SQLiteConnection) As DataTable
        Try
            Dim strTempQuery As String = "SELECT * FROM " & strTableName & " WHERE " & strColumnName & " LIKE '%" & strItemToFind & "%'"
            Dim cmdDataGrid As SQLiteCommand = New SQLiteCommand(strTempQuery, dbDatabaseConnection)
            Dim da As New SQLiteDataAdapter
            da.SelectCommand = cmdDataGrid
            Dim dt As New DataTable
            da.Fill(dt)
            cmdDataGrid.ExecuteReader()
            cmdDataGrid.Dispose()
            da.Dispose()
            Return dt
        Catch ex As Exception
            MsgBox("ERROR: " & ex.ToString, MsgBoxStyle.Critical)
            Return Nothing
        End Try
    End Function
    Public Function fFindAdvancedInDatabase(dbSource As SQLiteConnection, strTableName As String, strArolCode As String, strCommercialCode As String, strDescription As String, strManufacturer As String, strSupplementaryDescription As String) As DataTable
        Try
            If dbSource.State = ConnectionState.Open Then
                Dim cmd = "SELECT * FROM " & strTableName & " WHERE ArolCode LIKE '%" & strArolCode & "%' AND CommercialCode LIKE '%" & strCommercialCode & "%' AND Description LIKE '%" & strDescription & "%' AND Manufacturer LIKE '%" & strManufacturer & "%' AND SupplementaryDescription LIKE '%" & strSupplementaryDescription & "%'"
                Dim cmdDataGrid As SQLiteCommand = New SQLiteCommand(cmd, dbSource)
                Dim da As New SQLiteDataAdapter
                da.SelectCommand = cmdDataGrid
                Dim dt As New DataTable
                da.Fill(dt)
                cmdDataGrid.ExecuteReader()
                cmdDataGrid.Dispose()
                da.Dispose()
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELLA RICERCA AVANZATA", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function fSelectAllAndOrderBy(dbSource As SQLiteConnection, strTableName As String, strColumnOrder As String) As DataTable
        Try
            If dbSource.State = ConnectionState.Open Then
                Dim cmd As String = "SELECT * FROM " & strTableName & " ORDER BY " & strColumnOrder
                Dim cmdDataGrid As SQLiteCommand = New SQLiteCommand(cmd, dbSource)
                Dim da As New SQLiteDataAdapter
                da.SelectCommand = cmdDataGrid
                Dim dt As New DataTable
                da.Fill(dt)
                cmdDataGrid.ExecuteReader()
                cmdDataGrid.Dispose()
                da.Dispose()
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELLA SELEZIONE DI TUTTI GLI ELEMENTI", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function fWriteFromChildDataTable(dbDestination As SQLiteConnection, strDestinationTable As String, dataTableToWrite As DataTable) As Boolean
        Try
            If dbDestination.State = ConnectionState.Open Then
                Dim tr As SQLiteTransaction = SQLConn.BeginTransaction()
                Using tr
                    Dim cmd = "INSERT INTO " & strDestinationTable & "(ArolCode, CommercialCode, Description, Manufacturer, SupplementaryDescription) VALUES (@ArolCode, @CommercialCode, @Description, @Manufacturer, @SupplementaryDescription)"
                    Dim sqlCmd As SQLiteCommand = New SQLiteCommand(cmd, dbDestination)
                    Dim i As Integer = 0
                    For Each row In dataTableToWrite.Rows
                        sqlCmd.Parameters.AddWithValue("@ArolCode", dataTableToWrite.Rows(i)(0))
                        sqlCmd.Parameters.AddWithValue("@CommercialCode", dataTableToWrite.Rows(i)(1))
                        sqlCmd.Parameters.AddWithValue("@Description", dataTableToWrite.Rows(i)(2))
                        sqlCmd.Parameters.AddWithValue("@Manufacturer", dataTableToWrite.Rows(i)(3))
                        sqlCmd.Parameters.AddWithValue("@SupplementaryDescription", dataTableToWrite.Rows(i)(4))
                        sqlCmd.ExecuteNonQuery()
                        i = i + 1
                    Next
                    tr.Commit()
                    sqlCmd.Dispose()
                End Using
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELLA SCRITTURA DELLA DATATABLE SU DATABASE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fDeleteAllFromTable(dbDestination As SQLiteConnection, strTable As String) As Boolean
        Try
            If dbDestination.State = ConnectionState.Open Then
                Dim cmd = "DELETE FROM " & strTable
                Dim sqlCmd As SQLiteCommand = New SQLiteCommand(cmd, dbDestination)
                sqlCmd.ExecuteNonQuery()
                sqlCmd.Dispose()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERRORE NELLA CANCELLAZIONE DELLE RIGHE DEL DATABASE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fInsertNewDocument(dbDestination As SQLiteConnection, strTableName As String, iTipo As Integer, strTitolo As String, strVersione As String, strFilePath As String, strFileUrl As String) As Boolean
        Try
            If dbDestination.State = ConnectionState.Open Then
                Dim cmd = "INSERT INTO " & strTableName & "(Tipo,Titolo,Versione,File,Link) VALUES (@Tipo,@Titolo,@Versione,@File,@Link)"
                Dim sqlCmd As SQLiteCommand = New SQLiteCommand(cmd, dbDestination)
                sqlCmd.Parameters.AddWithValue("@Tipo", iTipo)
                sqlCmd.Parameters.AddWithValue("@Titolo", strTitolo)
                sqlCmd.Parameters.AddWithValue("@Versione", strVersione)
                sqlCmd.Parameters.AddWithValue("@File", strFilePath)
                sqlCmd.Parameters.AddWithValue("@Link", strFileUrl)
                sqlCmd.ExecuteNonQuery()
                sqlCmd.Dispose()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERRORE NEL AGGIORNAMENTO DELLA TABELLA DOCUMENTAZIONE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fInsertNewLinkToDoc(dbDestination As SQLiteConnection, strTableName As String, strArolCode As String, strLinkToDocID As String) As Boolean
        Try
            If dbDestination.State = ConnectionState.Open Then
                Dim cmd = "INSERT INTO " & strTableName & "(ArolCode, LinkDoc) VALUES (@ArolCode, @LinkDocId)"
                Dim sqlCmd As SQLiteCommand = New SQLiteCommand(cmd, dbDestination)
                sqlCmd.Parameters.AddWithValue("@ArolCode", strArolCode)
                sqlCmd.Parameters.AddWithValue("@LinkDocId", strLinkToDocID)
                sqlCmd.ExecuteNonQuery()
                sqlCmd.Dispose()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERRORE NEL AGGIORNAMENTO DELLA TABELLA LINKTODOC", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fUpdateLinkToDoc(dbDestination As SQLiteConnection, strTableName As String, strArolCode As String, strNewLinkDoc As String, strOldLinkDoc As String) As Boolean
        Try
            Dim strTempQuery As String = "UPDATE linkToDoc SET ArolCode=@ArolCode, LinkDoc=@LinkDoc WHERE ArolCode = '" & strArolCode & "' AND LinkDoc = '" & strOldLinkDoc & "'"
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(strTempQuery, frmMain.dbWarehouse.SQLConn)
            sqlCmd.Parameters.AddWithValue("@ArolCode", strArolCode)
            sqlCmd.Parameters.AddWithValue("@LinkDoc", strNewLinkDoc)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NELLA MODIFICA DELLA TABELLA LINKTODOC", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
End Class
