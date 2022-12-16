Imports System.Security.Cryptography

Public Class login
    Public Shared dbUsers As List(Of UserSkeleton) = New List(Of UserSkeleton)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim authStatus As Boolean
        If dbUsers IsNot Nothing Then
            For Each userAuth In dbUsers
                Try
                    If userAuth.CheckAuth(usernameField.Text, passwordField.Text,
                                   userAuth.dbUsername, userAuth.dbPassword) Then
                        authStatus = True
                        Exit For
                    Else
                        authStatus = False
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Next
            If authStatus Then
                MsgBox("Login berhasil !!!")
                Me.Hide()
                main_page.Show()
            Else
                MsgBox("Username atau password salah!!!")
            End If
        Else
            MsgBox("Belum ada user, silahkan register dulu !")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        register.Show()
    End Sub


End Class