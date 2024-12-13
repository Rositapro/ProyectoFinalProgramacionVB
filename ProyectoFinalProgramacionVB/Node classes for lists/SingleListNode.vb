Public Class SingleListNode
    Public Property Value As Integer
    Public Property Name As String
    Public Property PhoneNumber As String
    Public Property ZipCode As String
    Public Property [Next] As SingleListNode

    Public Sub New()
        Value = 0
        Name = ""
        PhoneNumber = ""
        ZipCode = ""
        [Next] = Nothing
    End Sub

    Public Sub New(value As Integer, name As String, phoneNumber As String, zipCode As String)
        Me.Value = value
        Me.Name = name
        Me.PhoneNumber = phoneNumber
        Me.ZipCode = zipCode
        [Next] = Nothing
    End Sub

    Public Sub New(value As Integer)
        Me.Value = value
    End Sub

    Public Overrides Function ToString() As String
        Return Value.ToString() & " - " & Name & " " & PhoneNumber & " - " & ZipCode
    End Function

End Class
