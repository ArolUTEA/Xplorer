Imports System.Data.SQLite
Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Security.Cryptography
Module UserManagerFunctions
    Public Function fCheckIfUserExist(strUsername As String) As Boolean
        Try
            Return frmMain.dbUsers.fCheckIfAlreadyExist(strUsername, frmMain.dbUsers.SQLConn, "userPermission", "userName")
        Catch ex As Exception
            MsgBox("ERRORE NELLA RICERCA DELL'UTENTE", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fCheckPassword(strUsername As String, strInsertedPassword As String) As Boolean
        Try
            Dim tempData As DataTable = frmMain.dbUsers.fSelectElementFromColumn(frmMain.dbUsers.SQLConn, "userPermission", "userName", "userName", strUsername)
            Dim tempPassword As String = fDecrypt(tempData.Rows(0)("userPassword").ToString)
            tempData.Dispose()
            If strInsertedPassword = tempPassword Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("ERRORE NEL CONTROLLO DELLA PASSWORD", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fChangePassword(strUsername As String, strOldPwd As String, strNewPwd As String, strNewConfirmedPwd As String) As Boolean
        Try
            'FUNZIONE PER IL CAMBIO PASSWORD, LE OPERAZIONI DA ESEGUIRE SONO:
            '1) CONTROLLO SE L'UTENTE ESISTE
            '2) CONTROLLO SE LA VECCHIA PASSWORD E' CORRETTA
            '3) CONTROLLO SE LA NUOVA PASSWORD E L'INSERIMENTO DI CONFERMA COINCIDONO
            '4) AGGIORNO IL DATABASE UTENTI
            If fCheckIfUserExist(strUsername) Then
                If fCheckPassword(strUsername, strOldPwd) Then
                    If strNewPwd = strNewConfirmedPwd Then
                        'AGGIORNAMENTO DEL DATABASE
                        Try
                            Dim strTempQuery As String = "UPDATE userPermission SET userPassword = '" & fEncrypt(strNewPwd) & "' WHERE userName = '" & strUsername & "'"
                            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(strTempQuery, frmMain.dbUsers.SQLConn)
                            sqlCmd.ExecuteNonQuery()
                            sqlCmd.Dispose()
                            Return True
                        Catch ex As Exception
                            MsgBox("ERRORE NELLA MODIFICA DELLA PASSWORD", MsgBoxStyle.Critical)
                            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
                            Return False
                        End Try
                    Else
                        MsgBox("CONFERMA DELLA PASSWORD NON CORRETTA", MsgBoxStyle.Exclamation)
                        Return False
                    End If
                Else
                    MsgBox("PASSWORD INSERITA NON CORRETTA", MsgBoxStyle.Exclamation)
                    Return False
                End If
            Else
                MsgBox("UTENTE NON ESISTENTE", MsgBoxStyle.Exclamation)
                Return False
            End If
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NELLA PROCEDURA DI CAMBIO PASSWORD", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fCheckWritePermission(strUsername As String) As Integer
        Try
            Dim tempData As DataTable = frmMain.dbUsers.fSelectElementFromColumn(frmMain.dbUsers.SQLConn, "userPermission", "userName", "userName", strUsername)
            Return tempData.Rows(0)("userWritePermission")
            tempData.Dispose()
        Catch ex As Exception
            MsgBox("ERRORE NELLA LETTURA DEI PERMESSI", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return 0
        End Try
    End Function
    Public Function fCreateNewUser(strUsername As String, strUserPWD As String) As Boolean
        Try
            Dim strTempQuery As String = "INSERT INTO userPermission (userName,userPassword,userWritePermission) VALUES (@userName,@userPassword,@userPermission)"
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(strTempQuery, frmMain.dbUsers.SQLConn)
            sqlCmd.Parameters.AddWithValue("@userName", strUsername)
            sqlCmd.Parameters.AddWithValue("@userPassword", fEncrypt(strUserPWD))
            sqlCmd.Parameters.AddWithValue("@userPermission", 0)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NELL'INSERIMENTO DI UN NUOVO USER", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Private Function fEncrypt(clearText As String) As String
        Try
            Dim EncryptionKey As String = "MAKV2SPBNI99212"
            Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
            Using encryptor As Aes = Aes.Create()
                Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
                 &H65, &H64, &H76, &H65, &H64, &H65,
                 &H76})
                encryptor.Key = pdb.GetBytes(32)
                encryptor.IV = pdb.GetBytes(16)
                Using ms As New MemoryStream()
                    Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                        cs.Write(clearBytes, 0, clearBytes.Length)
                        cs.Close()
                    End Using
                    clearText = Convert.ToBase64String(ms.ToArray())
                End Using
            End Using
            Return clearText
        Catch ex As Exception
            MsgBox("ERRORE NEL PROCESSO DI CRIPTATURA DELLA PASSWORD", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return ""
        End Try
    End Function
    Private Function fDecrypt(cipherText As String) As String
        Try
            Dim EncryptionKey As String = "MAKV2SPBNI99212"
            Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
            Using encryptor As Aes = Aes.Create()
                Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
                 &H65, &H64, &H76, &H65, &H64, &H65,
                 &H76})
                encryptor.Key = pdb.GetBytes(32)
                encryptor.IV = pdb.GetBytes(16)
                Using ms As New MemoryStream()
                    Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                        cs.Write(cipherBytes, 0, cipherBytes.Length)
                        cs.Close()
                    End Using
                    cipherText = Encoding.Unicode.GetString(ms.ToArray())
                End Using
            End Using
            Return cipherText
        Catch ex As Exception
            MsgBox("ERRORE NEL PROCESSO DI DE-CRIPTATURA DELLA PASSWORD", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return Nothing
        End Try
    End Function
    Public Function fChangeUserPermission(strUserName As String, iPermissionValue As Integer) As Boolean
        Try
            Dim strTempQuery As String = "UPDATE userPermission SET userWritePermission = " & iPermissionValue & " WHERE userName = '" & strUserName & "'"
            Dim sqlCmd As SQLiteCommand = New SQLiteCommand(strTempQuery, frmMain.dbUsers.SQLConn)
            sqlCmd.ExecuteNonQuery()
            sqlCmd.Dispose()
            Return True
        Catch ex As Exception
            MsgBox("ERRORE NELLA MODIFICA DEI PERMESSI", MsgBoxStyle.Critical)
            fAddLogRow(frmMain.strLogFilePath, "Utente: " & ex.ToString)
            Return False
        End Try
    End Function
    Public Function fApplyReaderOnlyPermission() As Boolean
        frmMain.btnInsertNew.Enabled = False
        'frmMain.btnEdit.Enabled = False
        frmMain.bUserWritePerm = False
        frmMain.bManageUser = False
        frmMain.bChangePassword = True
        frmMain.btnChildGenerator.Enabled = False
        frmMain.btnReadFromFile.Enabled = False
        frmArticlesDetails.txtCommercialCode.ReadOnly = True
        frmArticlesDetails.txtDescription.ReadOnly = True
        frmArticlesDetails.txtConstructor.ReadOnly = True
        frmArticlesDetails.txtSuppDescription.ReadOnly = True
        frmArticlesDetails.txtNote.ReadOnly = True
        frmArticlesDetails.cbxModificaStato.Enabled = False
        frmArticlesDetails.btnDeleteExisting.Enabled = False
        frmArticlesDetails.txtLotto.ReadOnly = True
        frmArticlesDetails.txtRiordino.ReadOnly = True
        frmArticlesDetails.txtTipoParte.ReadOnly = True
        frmArticlesDetails.txtScortaSicurezza.ReadOnly = True
        frmArticlesDetails.txtCostoUltimo.ReadOnly = True
        Return True
    End Function
    Public Function fApplyWritePermission() As Boolean
        frmMain.btnInsertNew.Enabled = True
        frmMain.bUserWritePerm = True
        frmMain.bManageUser = False
        frmMain.bChangePassword = True
        frmMain.btnChildGenerator.Enabled = True
        frmMain.btnReadFromFile.Enabled = False
        frmArticlesDetails.txtCommercialCode.ReadOnly = False
        frmArticlesDetails.txtDescription.ReadOnly = False
        frmArticlesDetails.txtConstructor.ReadOnly = False
        frmArticlesDetails.txtSuppDescription.ReadOnly = False
        frmArticlesDetails.txtNote.ReadOnly = False
        frmArticlesDetails.cbxModificaStato.Enabled = True
        frmArticlesDetails.btnDeleteExisting.Enabled = True
        frmArticlesDetails.txtLotto.ReadOnly = False
        frmArticlesDetails.txtRiordino.ReadOnly = False
        frmArticlesDetails.txtTipoParte.ReadOnly = False
        frmArticlesDetails.txtScortaSicurezza.ReadOnly = False
        frmArticlesDetails.txtCostoUltimo.ReadOnly = False
        Return True
    End Function
    Public Function fApplyAdvancedPermission() As Boolean
        frmMain.btnInsertNew.Enabled = True
        frmMain.bUserWritePerm = True
        frmMain.bManageUser = True
        frmMain.bChangePassword = True
        frmMain.btnChildGenerator.Enabled = True
        frmMain.btnReadFromFile.Enabled = True
        frmArticlesDetails.txtCommercialCode.ReadOnly = False
        frmArticlesDetails.txtDescription.ReadOnly = False
        frmArticlesDetails.txtConstructor.ReadOnly = False
        frmArticlesDetails.txtSuppDescription.ReadOnly = False
        frmArticlesDetails.txtNote.ReadOnly = False
        frmArticlesDetails.cbxModificaStato.Enabled = True
        frmArticlesDetails.btnDeleteExisting.Enabled = True
        frmArticlesDetails.txtLotto.ReadOnly = False
        frmArticlesDetails.txtRiordino.ReadOnly = False
        frmArticlesDetails.txtTipoParte.ReadOnly = False
        frmArticlesDetails.txtScortaSicurezza.ReadOnly = False
        frmArticlesDetails.txtCostoUltimo.ReadOnly = False
        Return True
    End Function
End Module