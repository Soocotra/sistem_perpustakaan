Imports System.Text.RegularExpressions


Public Class Register
    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim userEmail = TBEmail.Text
        Dim userPassword = TBPassword.Text
        Dim userName = TBName.Text
        Dim userConfPassword = TBConfPassword.Text

        Validate(userEmail, userPassword, userConfPassword, userName)

    End Sub

    Private Function EmailValidation(emailInput As String) As Boolean
        Return Regex.IsMatch(emailInput, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")
    End Function

    Private Sub Validate(userEmail As String, userPassword As String, userConfPassword As String, userName As String)

        Dim isFilled = userEmail.Length > 0 And userPassword.Length > 0 And userConfPassword.Length > 0 And userName.Length > 0

        If userEmail.Length > 0 And userPassword.Length >= 6 And EmailValidation(userEmail) And userPassword = userConfPassword Then
            Dim isPosted As Boolean = Login.Users.postUser(userName, userEmail, userPassword)
            If isPosted Then
                MessageBox.Show("Akun berhasil didaftarkan !")
                Me.Close()
            Else
                MessageBox.Show(Login.Users.errMessage)
            End If

        ElseIf Not userPassword = userConfPassword Then
            MessageBox.Show("Konfirmasi Password tidak cocok")

        ElseIf Not isFilled Then
            If userName.Length < 1 Then
                MessageBox.Show("Nama tidak boleh Kosong")
            ElseIf userEmail.Length < 1 Then
                MessageBox.Show("Email tidak boleh Kosong")
            ElseIf userPassword.Length < 1 Or userConfPassword.Length < 1 Then
                MessageBox.Show("Password dan konfirmasi password tidak boleh Kosong")
            End If

        ElseIf userPassword.Length <= 6 Then
            MessageBox.Show("Panjang Password harus lebih dari 6 karakter")

        ElseIf Not EmailValidation(userEmail) Then
            MessageBox.Show("Format Email tidak valid")

        End If
    End Sub

End Class