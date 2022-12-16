Public Class showKoleksi

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not String.IsNullOrEmpty(tambahkoleksi.koleksi.GSFoto) Then
            PicFoto.Load(tambahkoleksi.koleksi.GSFoto)
            PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        TextNama.Text = tambahkoleksi.koleksi.GSNama
        TextJenisKoleksi.Text = tambahkoleksi.koleksi.GSJenisKoleksi
        TextDeskripsi.Text = tambahkoleksi.koleksi.GSDeskripsi
        TextPenerbit.Text = tambahkoleksi.koleksi.GSPenerbit
        TextTahunTerbit.Text = tambahkoleksi.koleksi.GSTahunTerbit
        TextLokasiRak.Text = tambahkoleksi.koleksi.GSLokasiRak
        TextStock.Text = tambahkoleksi.koleksi.GSStock
        TextBahasa.Text = tambahkoleksi.koleksi.GSBahasa
        TextTanggal.Text = tambahkoleksi.koleksi.GSWaktu
        If tambahkoleksi.koleksi.GSKategori IsNot Nothing Then
            TextKategori.Text = String.Join(", ", tambahkoleksi.koleksi.GSKategori)
        End If
    End Sub

    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click
        Close()
    End Sub
End Class