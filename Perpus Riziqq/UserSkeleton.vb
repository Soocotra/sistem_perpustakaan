Imports System.Security.Cryptography

Public Class UserSkeleton
    Public Shared TripleDES As TripleDESCryptoServiceProvider

    Public dbUsername
    Public dbPassword

    Public Sub New(username As String, password As String)
        dbUsername = username
        dbPassword = password

    End Sub

    'Public Property GSDBUsername() As String
    '    Get
    '        Return dbUsername
    '    End Get
    '    Set(value As String)
    '        dbUsername = value
    '    End Set
    'End Property

    'Public Property GSDBPassword() As String
    '    Get
    '        Return dbPassword
    '    End Get
    '    Set(value As String)
    '        dbPassword = EncryptData(value)
    '    End Set
    'End Property

    Public Function EncryptData(plaintext As String) As String
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)


        MessageBox.Show(plaintextBytes.Length)
        Dim ms As New System.IO.MemoryStream
        Dim encStream As New CryptoStream(
            ms,
            tripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        Return Convert.ToBase64String(ms.ToArray)
    End Function

    Public Function CheckAuth(username As String, plainPassword As String, dbUsername As String, dbPassword As String) As Boolean
        Dim realPassword As String = dbPassword
        Dim realUsername = dbUsername
        If String.Compare(LCase(username), LCase(realUsername)) = 0 And String.Compare(plainPassword, realPassword) = 0 Then
            Return True
        End If
        Return False
    End Function



End Class
