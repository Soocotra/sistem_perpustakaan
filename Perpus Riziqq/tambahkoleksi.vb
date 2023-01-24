Public Class tambahkoleksi
    Public Shared koleksi As CollectionSkeleton = New CollectionSkeleton()
    Dim listKategori As List(Of String) = New List(Of String)

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy/MM/dd"
    End Sub

    Private Sub BtnTambahGambar_Click(sender As Object, e As EventArgs) Handles BtnTambahGambar.Click
        OpenFileDialog1.Title = "Open Foto"
        OpenFileDialog1.Filter = "Image|*.bmp|Image JPG|*.jpg|Image JPEG|*.jpeg|Image PNG|*.png|Image GIF|*.gif| All Format|*.*"

        Dim pictKoleksiDir As String = OpenFileDialog1.FileName
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then

            PicFoto.Load(OpenFileDialog1.FileName)
            PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
            koleksi.GSFoto = OpenFileDialog1.FileName.ToString()
            koleksi.GSFoto = koleksi.GSFoto.Replace("\", "/")

        End If
    End Sub

    Private Sub BtnTambahKoleksi_Click(sender As Object, e As EventArgs) Handles BtnTambahKoleksi.Click
        koleksi.GSNama = TextNama.Text
        koleksi.GSJenisKoleksi = ComboBox1.SelectedItem
        koleksi.GSDeskripsi = TextDeskripsi.Text
        koleksi.GSPenerbit = TextPenerbit.Text
        koleksi.GSTahunTerbit = TextTahunTerbit.Text
        koleksi.GSLokasiRak = TextLokasiRak.Text
        koleksi.GSStock = TextStock.Text
        koleksi.GSWaktu = DateTimePicker1.Value.ToLongDateString

        If RBBahasa.Checked Then
            koleksi.GSBahasa = RBBahasa.Text
        End If
        If RBEnglish.Checked Then
            koleksi.GSBahasa = RBEnglish.Text
        End If

        If CheckSains.Checked Then
            listKategori.Add("Sains")
        End If
        If CheckSosial.Checked Then
            listKategori.Add("Sosial")
        End If
        If CheckTeknologi.Checked Then
            listKategori.Add("Teknologi")
        End If
        If CheckBudaya.Checked Then
            listKategori.Add("Budaya")
        End If
        koleksi.GSKategori = listKategori

        koleksi.AddDataKoleksiDatabase()
        main_page.ListCollection.Add(koleksi)
        showKoleksi.Show()
        main_page.ReloadDataTableDatabase()
        Me.Close()


    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class