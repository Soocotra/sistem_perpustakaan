Public Class DeleteKoleksi

    Public Shared koleksi As New CollectionSkeleton
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        LabelID.Text = koleksi.GSID
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim deleted = koleksi.delete(koleksi.GSID)
        main_page.ReloadDataTableDatabase()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class