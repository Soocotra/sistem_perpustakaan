Public Class register

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If String.Compare(passwordField.Text, confirmPwField.Text) = 0 Then
                Dim userRegistered As UserSkeleton
                userRegistered = New UserSkeleton(usernameField.Text, passwordField.Text)


                login.dbUsers.Add(userRegistered)
                MsgBox("Register Berhasil ! Silahkan login")
                Me.Close()
            Else
                MsgBox("Konfirmasi password tidak cocok")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString + passwordField.Text)
        End Try
    End Sub
End Class