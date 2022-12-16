Public Class updateKoleksi
    Public Shared koleksi As CollectionSkeleton = New CollectionSkeleton()

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        PicFoto.Load(koleksi.GSFoto)
        PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
        TextNama.Text = koleksi.GSNama
        CBJenis.SelectedItem() = koleksi.GSJenisKoleksi
        TextDeskripsi.Text = koleksi.GSDeskripsi
        TextPenerbit.Text = koleksi.GSPenerbit
        TextTahunTerbit.Text = koleksi.GSTahunTerbit
        TextLokasiRak.Text = koleksi.GSLokasiRak
        TextStock.Text = koleksi.GSStock
    End Sub
End Class