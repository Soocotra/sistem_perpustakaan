Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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


        For Each kategori In koleksi.GSKategori
            If kategori.Equals("Sains") Then
                CheckSains.Checked = True
            End If
            If kategori.Equals(" Sosial") Then
                CheckSosial.Checked = True
            End If
            If kategori.Equals(" Teknologi") Then
                CheckTeknologi.Checked = True
            End If
            If kategori.Equals(" Budaya") Then
                CheckBudaya.Checked = True
            End If
        Next

        If String.Compare(koleksi.GSBahasa, "Bahasa Indonesia") Then
            RBBahasa.Checked = True
        End If

        If String.Compare(koleksi.GSBahasa, "English") Then
            RBEnglish.Checked = True
        End If

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

    Private Sub BtnEditKoleksi_Click(sender As Object, e As EventArgs) Handles BtnEditKoleksi.Click
        Dim listKategori As New List(Of String)

        koleksi.GSNama = TextNama.Text
        koleksi.GSJenisKoleksi = CBJenis.SelectedItem
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

        Dim data As New List(Of String) From {
            koleksi.GSNama,
            koleksi.GSFoto,
            koleksi.GSJenisKoleksi,
            koleksi.GSDeskripsi,
            koleksi.GSTahunTerbit,
            koleksi.GSLokasiRak,
            koleksi.GSStock,
            koleksi.GSBahasa,
            String.Join(", ", koleksi.GSKategori.ToArray()),
            koleksi.GSPenerbit
        }
        koleksi.UpdateDataKoleksiByIdDatabase(koleksi.GSID, data)

        MessageBox.Show("Data berhasil diperbarui")
        main_page.ReloadDataTableDatabase()
        Me.Close()
    End Sub
End Class