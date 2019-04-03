
Imports log4net

Public Class logger
    Public logger As log4net.ILog

    Public Sub New(logger As ILog)
        Me.logger = logger
    End Sub

    Public Sub configurateLogger()

    End Sub
End Class
