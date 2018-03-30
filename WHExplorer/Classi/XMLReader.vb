Public Class XMLReader
    Dim xmlFile As Xml.XmlDocument
    Dim xmlNodeList As Xml.XmlNodeList
    Dim xmlNode As Xml.XmlNode
    Dim xmlPath As String = AppDomain.CurrentDomain.BaseDirectory & "Configurations\config.xml"
    'Public strDBPath As String
    Public Function fReadDBPath() As String
        Try
            xmlFile = New Xml.XmlDocument
            xmlFile.Load(xmlPath)
            xmlNodeList = xmlFile.SelectNodes("configuration")
            For Each xmlNode In xmlNodeList
                fReadDBPath = xmlNode.Item("dbPath").InnerText
            Next
        Catch ex As Exception
            MsgBox("ERRORE: " & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Function
    Public Function fCheckWriteUserPermission(username As String) As Boolean
        Try
            xmlFile = New Xml.XmlDocument
            xmlFile.Load(xmlPath)
            xmlNodeList = xmlFile.SelectNodes("configuration")
            For Each xmlNode In xmlNodeList
                If xmlFile.GetElementsByTagName(username).Count > 0 Then
                    If xmlNode.Item(username).InnerText = "RW" Then
                        fCheckWriteUserPermission = True
                    Else
                        fCheckWriteUserPermission = False
                    End If
                Else
                    fCheckWriteUserPermission = False
                End If
            Next
        Catch ex As Exception
            MsgBox("ERRORE: " & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Function
    Public Function fReadDatasheetFolder() As String()
        Try
            xmlFile = New Xml.XmlDocument
            xmlFile.Load(xmlPath)
            xmlNodeList = xmlFile.SelectNodes("configuration")
            For Each xmlNode In xmlNodeList
                fReadDatasheetFolder(0) = xmlNode.SelectSingleNode("dsSourceFolder").InnerText
                fReadDatasheetFolder(1) = xmlNode.SelectSingleNode("dsDestFolder").InnerText
            Next
        Catch ex As Exception
            MsgBox("ERRORE: " & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Function
    Public Function fReadConfigurations() As String()
        Try
            xmlFile = New Xml.XmlDocument
            xmlFile.Load(xmlPath)
            xmlNodeList = xmlFile.SelectNodes("configuration")
            For Each xmlNode In xmlNodeList
                fReadConfigurations(0) = xmlNode.SelectSingleNode("dbPath").InnerText
                fReadConfigurations(1) = xmlNode.SelectSingleNode("dsSourceFolder").InnerText
                fReadConfigurations(2) = xmlNode.SelectSingleNode("dsDestFolder").InnerText
            Next
        Catch ex As Exception
            MsgBox("ERRORE: " & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Function
    Public Function fReadSingleNode(node As String) As String
        Try
            xmlFile = New Xml.XmlDocument
            xmlFile.Load(xmlPath)
            xmlNodeList = xmlFile.SelectNodes("configuration")
            For Each xmlNode In xmlNodeList
                fReadSingleNode = xmlNode.Item(node).InnerText
            Next
        Catch ex As Exception
            MsgBox("ERRORE: " & ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Function
End Class
