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

    Public Sub showLBItems()
        LBKoleksi.Items.Clear()

        For Each koleksi In ListCollection
            LBKoleksi.Items.Add(koleksi.GSNama)
        Next
    End Sub



    Private Sub ReloadDataTableDatabase()

    End Sub

    Private Sub main_page_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim data = koleksi.GetDataKoleksiDatabase()
        Tabel.DataSource = data
        LBKoleksi.DataSource = data
        LBKoleksi.DisplayMember = "nama"
        LBKoleksi.ValueMember = "id"


    End Sub

    Private Sub Tabel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabel.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = Tabel.Rows(Index)

        selectedTableKoleksi = selectedRow.Cells(0).Value
        selectedTableKoleksiNama = selectedRow.Cells(1).Value
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim selectedKoleksi As List(Of String) = koleksi.GetDataKoleksiByIdDatabase(selectedTableKoleksi)
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

        Dim formupdate = New UpdateKoleksi()
        formupdate.Show()
    End Sub
End Class
