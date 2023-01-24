Imports MySql.Data.MySqlClient

Public Class User

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Public Shared errMessage As String

    Private sqlQuery As String

    Private ReadOnly server As String = "localhost"
    Private ReadOnly usernameDB As String = "root"
    Private ReadOnly passwordDB As String = ""
    Private ReadOnly database As String = "perpustakaan"

    Private email
    Private name

    Public Function ConnectToDB()
        Return "server =" + server + ";" + "user id=" + usernameDB + ";" + "password =" + passwordDB + ";" + "database =" + database
    End Function

    Public Function EncryptMD5(password As String)
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        bs = x.ComputeHash(bs)
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower)
        Next
        Return s.ToString
    End Function

    Public Function postUser(nameInput As String, emailInput As String, passwordInput As String) As Boolean
        If EmailUniqueValidation(emailInput) Then
            errMessage = "Email Telah Digunakan !"
            Return False
        End If

        Try
            dbConn.ConnectionString = ConnectToDB()

            dbConn.Open()

            sqlCommand.Connection = dbConn

            sqlQuery = "INSERT INTO USERS (NAMA, EMAIL, PASSWORD) VALUE ('" + nameInput + "',LOWER('" + emailInput + "'),'" + EncryptMD5(passwordInput) + "')"



            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()

            Return True
        Catch ex As Exception
            errMessage = ex.Message
            Return False
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function Authentication(emailInput As String, passwordInput As String) As Boolean
        Try
            Dim result As New List(Of String)

            dbConn.ConnectionString = ConnectToDB()
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim queryAuth = "SELECT NAMA, EMAIL FROM USERS WHERE EMAIL=LOWER('" & emailInput & "') AND PASSWORD='" & EncryptMD5(passwordInput) & "'"

            sqlCommand.CommandText = queryAuth


            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString())
                    result.Add(sqlRead.GetString(1).ToString())
                End While

                name = result(0)
                email = result(1)
                sqlRead.Close()
                dbConn.Close()
                Return True
            End If

            sqlRead.Close()
            dbConn.Close()
            Return False
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function EmailUniqueValidation(emailInput As String)
        Try
            dbConn.ConnectionString = ConnectToDB()
            dbConn.Open()
            sqlCommand.Connection = dbConn

            Dim query = "SELECT * FROM USERS WHERE LOWER(EMAIL)=LOWER('" + emailInput + "')"

            sqlCommand.CommandText = query


            sqlRead = sqlCommand.ExecuteReader

            If sqlRead.HasRows Then
                Return True
            End If

            sqlRead.Close()
            dbConn.Close()

            Return False
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Function
    Public ReadOnly Property getName()
        Get
            Return name
        End Get
    End Property

    Public ReadOnly Property getEmail()
        Get
            Return email
        End Get
    End Property

End Class
