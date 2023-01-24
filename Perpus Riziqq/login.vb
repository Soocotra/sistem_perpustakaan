Imports Microsoft.Win32
Imports System.Windows

Public Class Login
    Public Shared Users As User

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        Users = New User()

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim plainEmail = TBEmail.Text
        Dim plainPassword = TBPassword.Text

        If Users.Authentication(plainEmail, plainPassword) Then
            main_page.Show()
            Me.Hide()
        Else
            MessageBox.Show("Email atau password salah")
        End If
    End Sub

    Private Sub LinkRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRegister.LinkClicked
        Register.Show()
    End Sub

End Class