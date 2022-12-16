<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class updateKoleksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.CheckSains = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBJenis = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBudaya = New System.Windows.Forms.CheckBox()
        Me.CheckTeknologi = New System.Windows.Forms.CheckBox()
        Me.CheckSosial = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBEnglish = New System.Windows.Forms.RadioButton()
        Me.RBBahasa = New System.Windows.Forms.RadioButton()
        Me.TextStock = New System.Windows.Forms.TextBox()
        Me.TextLokasiRak = New System.Windows.Forms.TextBox()
        Me.TextTahunTerbit = New System.Windows.Forms.TextBox()
        Me.TextPenerbit = New System.Windows.Forms.TextBox()
        Me.TextDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.TextNama = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.BtnTambahKoleksi = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckSains
        '
        Me.CheckSains.AutoSize = True
        Me.CheckSains.Location = New System.Drawing.Point(8, 23)
        Me.CheckSains.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckSains.Name = "CheckSains"
        Me.CheckSains.Size = New System.Drawing.Size(65, 21)
        Me.CheckSains.TabIndex = 0
        Me.CheckSains.Text = "Sains"
        Me.CheckSains.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(491, 338)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(251, 22)
        Me.DateTimePicker1.TabIndex = 45
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(321, 338)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Tanggal"
        '
        'CBJenis
        '
        Me.CBJenis.FormattingEnabled = True
        Me.CBJenis.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi", "Penelitian"})
        Me.CBJenis.Location = New System.Drawing.Point(491, 90)
        Me.CBJenis.Margin = New System.Windows.Forms.Padding(4)
        Me.CBJenis.Name = "CBJenis"
        Me.CBJenis.Size = New System.Drawing.Size(251, 24)
        Me.CBJenis.TabIndex = 28
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBudaya)
        Me.GroupBox2.Controls.Add(Me.CheckTeknologi)
        Me.GroupBox2.Controls.Add(Me.CheckSosial)
        Me.GroupBox2.Controls.Add(Me.CheckSains)
        Me.GroupBox2.Location = New System.Drawing.Point(562, 506)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(169, 135)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategori"
        '
        'CheckBudaya
        '
        Me.CheckBudaya.AutoSize = True
        Me.CheckBudaya.Location = New System.Drawing.Point(8, 107)
        Me.CheckBudaya.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBudaya.Name = "CheckBudaya"
        Me.CheckBudaya.Size = New System.Drawing.Size(78, 21)
        Me.CheckBudaya.TabIndex = 3
        Me.CheckBudaya.Text = "Budaya"
        Me.CheckBudaya.UseVisualStyleBackColor = True
        '
        'CheckTeknologi
        '
        Me.CheckTeknologi.AutoSize = True
        Me.CheckTeknologi.Location = New System.Drawing.Point(8, 79)
        Me.CheckTeknologi.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckTeknologi.Name = "CheckTeknologi"
        Me.CheckTeknologi.Size = New System.Drawing.Size(92, 21)
        Me.CheckTeknologi.TabIndex = 2
        Me.CheckTeknologi.Text = "Teknologi"
        Me.CheckTeknologi.UseVisualStyleBackColor = True
        '
        'CheckSosial
        '
        Me.CheckSosial.AutoSize = True
        Me.CheckSosial.Location = New System.Drawing.Point(8, 50)
        Me.CheckSosial.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckSosial.Name = "CheckSosial"
        Me.CheckSosial.Size = New System.Drawing.Size(68, 21)
        Me.CheckSosial.TabIndex = 1
        Me.CheckSosial.Text = "Sosial"
        Me.CheckSosial.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBEnglish)
        Me.GroupBox1.Controls.Add(Me.RBBahasa)
        Me.GroupBox1.Location = New System.Drawing.Point(325, 506)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(169, 135)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'RBEnglish
        '
        Me.RBEnglish.AutoSize = True
        Me.RBEnglish.Location = New System.Drawing.Point(8, 65)
        Me.RBEnglish.Margin = New System.Windows.Forms.Padding(4)
        Me.RBEnglish.Name = "RBEnglish"
        Me.RBEnglish.Size = New System.Drawing.Size(75, 21)
        Me.RBEnglish.TabIndex = 21
        Me.RBEnglish.TabStop = True
        Me.RBEnglish.Text = "English"
        Me.RBEnglish.UseVisualStyleBackColor = True
        '
        'RBBahasa
        '
        Me.RBBahasa.AutoSize = True
        Me.RBBahasa.Location = New System.Drawing.Point(8, 23)
        Me.RBBahasa.Margin = New System.Windows.Forms.Padding(4)
        Me.RBBahasa.Name = "RBBahasa"
        Me.RBBahasa.Size = New System.Drawing.Size(142, 21)
        Me.RBBahasa.TabIndex = 20
        Me.RBBahasa.TabStop = True
        Me.RBBahasa.Text = "Bahasa Indonesia"
        Me.RBBahasa.UseVisualStyleBackColor = True
        '
        'TextStock
        '
        Me.TextStock.Location = New System.Drawing.Point(490, 435)
        Me.TextStock.Margin = New System.Windows.Forms.Padding(4)
        Me.TextStock.Name = "TextStock"
        Me.TextStock.Size = New System.Drawing.Size(252, 22)
        Me.TextStock.TabIndex = 41
        '
        'TextLokasiRak
        '
        Me.TextLokasiRak.Location = New System.Drawing.Point(490, 376)
        Me.TextLokasiRak.Margin = New System.Windows.Forms.Padding(4)
        Me.TextLokasiRak.Name = "TextLokasiRak"
        Me.TextLokasiRak.Size = New System.Drawing.Size(252, 22)
        Me.TextLokasiRak.TabIndex = 40
        '
        'TextTahunTerbit
        '
        Me.TextTahunTerbit.Location = New System.Drawing.Point(490, 292)
        Me.TextTahunTerbit.Margin = New System.Windows.Forms.Padding(4)
        Me.TextTahunTerbit.Name = "TextTahunTerbit"
        Me.TextTahunTerbit.Size = New System.Drawing.Size(252, 22)
        Me.TextTahunTerbit.TabIndex = 39
        '
        'TextPenerbit
        '
        Me.TextPenerbit.Location = New System.Drawing.Point(490, 245)
        Me.TextPenerbit.Margin = New System.Windows.Forms.Padding(4)
        Me.TextPenerbit.Name = "TextPenerbit"
        Me.TextPenerbit.Size = New System.Drawing.Size(252, 22)
        Me.TextPenerbit.TabIndex = 38
        '
        'TextDeskripsi
        '
        Me.TextDeskripsi.Location = New System.Drawing.Point(490, 148)
        Me.TextDeskripsi.Margin = New System.Windows.Forms.Padding(4)
        Me.TextDeskripsi.Name = "TextDeskripsi"
        Me.TextDeskripsi.Size = New System.Drawing.Size(252, 84)
        Me.TextDeskripsi.TabIndex = 37
        Me.TextDeskripsi.Text = ""
        '
        'TextNama
        '
        Me.TextNama.Location = New System.Drawing.Point(490, 34)
        Me.TextNama.Margin = New System.Windows.Forms.Padding(4)
        Me.TextNama.Name = "TextNama"
        Me.TextNama.Size = New System.Drawing.Size(252, 22)
        Me.TextNama.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(321, 435)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Stock"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(321, 376)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Lokasi Rak"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(321, 292)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Tahun Terbit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(321, 245)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Penerbit"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(321, 148)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Deskripsi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(321, 94)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Jenis Koleksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(321, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Nama Koleksi"
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(13, 365)
        Me.BtnTambahGambar.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(208, 33)
        Me.BtnTambahGambar.TabIndex = 27
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'BtnTambahKoleksi
        '
        Me.BtnTambahKoleksi.Location = New System.Drawing.Point(435, 665)
        Me.BtnTambahKoleksi.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTambahKoleksi.Name = "BtnTambahKoleksi"
        Me.BtnTambahKoleksi.Size = New System.Drawing.Size(179, 44)
        Me.BtnTambahKoleksi.TabIndex = 26
        Me.BtnTambahKoleksi.Text = "Tambah Koleksi"
        Me.BtnTambahKoleksi.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(13, 90)
        Me.PicFoto.Margin = New System.Windows.Forms.Padding(4)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(208, 257)
        Me.PicFoto.TabIndex = 25
        Me.PicFoto.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(42, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 36)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "UPDATE"
        '
        'updateKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 742)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CBJenis)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextStock)
        Me.Controls.Add(Me.TextLokasiRak)
        Me.Controls.Add(Me.TextTahunTerbit)
        Me.Controls.Add(Me.TextPenerbit)
        Me.Controls.Add(Me.TextDeskripsi)
        Me.Controls.Add(Me.TextNama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnTambahGambar)
        Me.Controls.Add(Me.BtnTambahKoleksi)
        Me.Controls.Add(Me.PicFoto)
        Me.Name = "updateKoleksi"
        Me.Text = "update"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CheckSains As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBudaya As CheckBox
    Friend WithEvents CheckTeknologi As CheckBox
    Friend WithEvents CheckSosial As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBEnglish As RadioButton
    Friend WithEvents RBBahasa As RadioButton
    Friend WithEvents TextStock As TextBox
    Friend WithEvents TextLokasiRak As TextBox
    Friend WithEvents TextTahunTerbit As TextBox
    Friend WithEvents TextPenerbit As TextBox
    Friend WithEvents TextDeskripsi As RichTextBox
    Friend WithEvents TextNama As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents BtnTambahKoleksi As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents CBJenis As ComboBox
End Class
