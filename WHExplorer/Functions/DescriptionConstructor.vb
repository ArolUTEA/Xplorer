Module DescriptionConstructor
    Public Function fDescriptionConstructor(field0 As String, field1 As String, field2 As String, field3 As String, field4 As String, field5 As String, field6 As String, field7 As String) As Boolean
        frmInsertNew.txtDescription.Text = field0 & " " & field1 & field2 & field3 & field4 & field5 & field6 & field7
        Return True
    End Function
    Public Function fDescriptionConstructorV2(field() As String) As Boolean
        Dim iLenField = field.Length
        frmInsertNew.txtDescription.Text = field(0) & " "
        For i = 1 To iLenField - 1
            frmInsertNew.txtDescription.Text = frmInsertNew.txtDescription.Text & field(i)
        Next
        Return True
    End Function
End Module