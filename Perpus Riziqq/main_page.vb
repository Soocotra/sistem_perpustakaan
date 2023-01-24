Public Class main_page
    Public Shared ListCollection As List(Of CollectionSkeleton) = New List(Of CollectionSkeleton)
    Public Shared koleksi As CollectionSkeleton = New CollectionSkeleton
    Public Shared selectedTableKoleksi
    Public Shared selectedTableKoleksiNama
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        tambahkoleksi.Show()

    End Sub

    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click
        tambahkoleksi.Show()
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If LBKoleksi.SelectedIndex Then
            LBKoleksi.Items.RemoveAt(LBKoleksi.SelectedIndex)
        End If
    End Sub


    Public Sub ReloadDataTableDatabase()
        Dim data = koleksi.GetDataKoleksiDatabase()
        Tabel.DataSource = data
        LBKoleksi.DataSource = data
        LBKoleksi.DisplayMember = "nama"
        LBKoleksi.ValueMember = "id"
    End Sub

    Private Sub main_page_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub


    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

        updateKoleksi.koleksi.GSID = Tabel.Item("ID", Tabel.CurrentRow.Index).Value
        selectedTableKoleksiNama = Tabel.Item("NAMA", Tabel.CurrentRow.Index).Value

        If Tabel.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih data yang ingin di-update")
        Else
            Dim selectedKoleksi As List(Of String) = koleksi.GetDataKoleksiByIdDatabase(updateKoleksi.koleksi.GSID)
            updateKoleksi.koleksi.GSFoto = selectedKoleksi(2)
            updateKoleksi.koleksi.GSNama = selectedKoleksi(1)
            updateKoleksi.koleksi.GSJenisKoleksi = selectedKoleksi(5)

            updateKoleksi.koleksi.GSDeskripsi = selectedKoleksi(4)

            updateKoleksi.koleksi.GSPenerbit = selectedKoleksi(3)

            updateKoleksi.koleksi.GSTahunTerbit = selectedKoleksi(6)

            updateKoleksi.koleksi.GSLokasiRak = selectedKoleksi(7)

            updateKoleksi.koleksi.GSWaktu = selectedKoleksi(8)

            updateKoleksi.koleksi.GSStock = selectedKoleksi(9)

            updateKoleksi.koleksi.GSBahasa = selectedKoleksi(10)

            updateKoleksi.koleksi.GSJenisKoleksi = selectedKoleksi(5)

            updateKoleksi.koleksi.GSKategori = selectedKoleksi(11).Split(", ").ToList


            Dim formupdate = New updateKoleksi()
            formupdate.Show()

        End If

    End Sub

    Private Sub BtnRemove_Click(sender As Object, e As EventArgs) Handles BtnRemove.Click
        DeleteKoleksi.koleksi.GSID = Tabel.Item("ID", Tabel.CurrentRow.Index).Value

        DeleteKoleksi.Show()
    End Sub
End Class
