<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambahkoleksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.BtnTambahKoleksi = New System.Windows.Forms.Button()
        Me.BtnTambahGambar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextNama = New System.Windows.Forms.TextBox()
        Me.TextDeskripsi = New System.Windows.Forms.RichTextBox()
        Me.TextPenerbit = New System.Windows.Forms.TextBox()
        Me.TextLokasiRak = New System.Windows.Forms.TextBox()
        Me.TextStock = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBEnglish = New System.Windows.Forms.RadioButton()
        Me.RBBahasa = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBudaya = New System.Windows.Forms.CheckBox()
        Me.CheckTeknologi = New System.Windows.Forms.CheckBox()
        Me.CheckSosial = New System.Windows.Forms.CheckBox()
        Me.CheckSains = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextTahunTerbit = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PicFoto
        '
        Me.PicFoto.Location = New System.Drawing.Point(12, 42)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(156, 209)
        Me.PicFoto.TabIndex = 1
        Me.PicFoto.TabStop = False
        '
        'BtnTambahKoleksi
        '
        Me.BtnTambahKoleksi.Location = New System.Drawing.Point(316, 555)
        Me.BtnTambahKoleksi.Name = "BtnTambahKoleksi"
        Me.BtnTambahKoleksi.Size = New System.Drawing.Size(134, 36)
        Me.BtnTambahKoleksi.TabIndex = 2
        Me.BtnTambahKoleksi.Text = "Tambah Koleksi"
        Me.BtnTambahKoleksi.UseVisualStyleBackColor = True
        '
        'BtnTambahGambar
        '
        Me.BtnTambahGambar.Location = New System.Drawing.Point(12, 266)
        Me.BtnTambahGambar.Name = "BtnTambahGambar"
        Me.BtnTambahGambar.Size = New System.Drawing.Size(156, 27)
        Me.BtnTambahGambar.TabIndex = 3
        Me.BtnTambahGambar.Text = "Tambah Gambar"
        Me.BtnTambahGambar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(230, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nama Koleksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jenis Koleksi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(230, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Deskripsi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Penerbit"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(230, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Lokasi Rak"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(230, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Stock"
        '
        'TextNama
        '
        Me.TextNama.Location = New System.Drawing.Point(357, 42)
        Me.TextNama.Name = "TextNama"
        Me.TextNama.Size = New System.Drawing.Size(190, 20)
        Me.TextNama.TabIndex = 12
        '
        'TextDeskripsi
        '
        Me.TextDeskripsi.Location = New System.Drawing.Point(357, 135)
        Me.TextDeskripsi.Name = "TextDeskripsi"
        Me.TextDeskripsi.Size = New System.Drawing.Size(190, 69)
        Me.TextDeskripsi.TabIndex = 14
        Me.TextDeskripsi.Text = ""
        '
        'TextPenerbit
        '
        Me.TextPenerbit.Location = New System.Drawing.Point(357, 214)
        Me.TextPenerbit.Name = "TextPenerbit"
        Me.TextPenerbit.Size = New System.Drawing.Size(190, 20)
        Me.TextPenerbit.TabIndex = 15
        '
        'TextLokasiRak
        '
        Me.TextLokasiRak.Location = New System.Drawing.Point(357, 320)
        Me.TextLokasiRak.Name = "TextLokasiRak"
        Me.TextLokasiRak.Size = New System.Drawing.Size(190, 20)
        Me.TextLokasiRak.TabIndex = 17
        '
        'TextStock
        '
        Me.TextStock.Location = New System.Drawing.Point(357, 368)
        Me.TextStock.Name = "TextStock"
        Me.TextStock.Size = New System.Drawing.Size(190, 20)
        Me.TextStock.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBEnglish)
        Me.GroupBox1.Controls.Add(Me.RBBahasa)
        Me.GroupBox1.Location = New System.Drawing.Point(233, 426)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 110)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bahasa"
        '
        'RBEnglish
        '
        Me.RBEnglish.AutoSize = True
        Me.RBEnglish.Location = New System.Drawing.Point(6, 53)
        Me.RBEnglish.Name = "RBEnglish"
        Me.RBEnglish.Size = New System.Drawing.Size(59, 17)
        Me.RBEnglish.TabIndex = 21
        Me.RBEnglish.TabStop = True
        Me.RBEnglish.Text = "English"
        Me.RBEnglish.UseVisualStyleBackColor = True
        '
        'RBBahasa
        '
        Me.RBBahasa.AutoSize = True
        Me.RBBahasa.Location = New System.Drawing.Point(6, 19)
        Me.RBBahasa.Name = "RBBahasa"
        Me.RBBahasa.Size = New System.Drawing.Size(110, 17)
        Me.RBBahasa.TabIndex = 20
        Me.RBBahasa.TabStop = True
        Me.RBBahasa.Text = "Bahasa Indonesia"
        Me.RBBahasa.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBudaya)
        Me.GroupBox2.Controls.Add(Me.CheckTeknologi)
        Me.GroupBox2.Controls.Add(Me.CheckSosial)
        Me.GroupBox2.Controls.Add(Me.CheckSains)
        Me.GroupBox2.Location = New System.Drawing.Point(411, 426)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(127, 110)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kategori"
        '
        'CheckBudaya
        '
        Me.CheckBudaya.AutoSize = True
        Me.CheckBudaya.Location = New System.Drawing.Point(6, 87)
        Me.CheckBudaya.Name = "CheckBudaya"
        Me.CheckBudaya.Size = New System.Drawing.Size(62, 17)
        Me.CheckBudaya.TabIndex = 3
        Me.CheckBudaya.Text = "Budaya"
        Me.CheckBudaya.UseVisualStyleBackColor = True
        '
        'CheckTeknologi
        '
        Me.CheckTeknologi.AutoSize = True
        Me.CheckTeknologi.Location = New System.Drawing.Point(6, 64)
        Me.CheckTeknologi.Name = "CheckTeknologi"
        Me.CheckTeknologi.Size = New System.Drawing.Size(73, 17)
        Me.CheckTeknologi.TabIndex = 2
        Me.CheckTeknologi.Text = "Teknologi"
        Me.CheckTeknologi.UseVisualStyleBackColor = True
        '
        'CheckSosial
        '
        Me.CheckSosial.AutoSize = True
        Me.CheckSosial.Location = New System.Drawing.Point(6, 41)
        Me.CheckSosial.Name = "CheckSosial"
        Me.CheckSosial.Size = New System.Drawing.Size(54, 17)
        Me.CheckSosial.TabIndex = 1
        Me.CheckSosial.Text = "Sosial"
        Me.CheckSosial.UseVisualStyleBackColor = True
        '
        'CheckSains
        '
        Me.CheckSains.AutoSize = True
        Me.CheckSains.Location = New System.Drawing.Point(6, 19)
        Me.CheckSains.Name = "CheckSains"
        Me.CheckSains.Size = New System.Drawing.Size(52, 17)
        Me.CheckSains.TabIndex = 0
        Me.CheckSains.Text = "Sains"
        Me.CheckSains.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Buku", "Ensiklopedia", "Koran", "Majalah", "Publikasi", "Penelitian"})
        Me.ComboBox1.Location = New System.Drawing.Point(358, 88)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(189, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(230, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tahun Terbit"
        '
        'TextTahunTerbit
        '
        Me.TextTahunTerbit.Location = New System.Drawing.Point(357, 252)
        Me.TextTahunTerbit.Name = "TextTahunTerbit"
        Me.TextTahunTerbit.Size = New System.Drawing.Size(190, 20)
        Me.TextTahunTerbit.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(230, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Tanggal"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(358, 289)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(189, 20)
        Me.DateTimePicker1.TabIndex = 24
        '
        'tambahkoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 603)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox1)
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
        Me.Name = "tambahkoleksi"
        Me.Text = "Form1"
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicFoto As PictureBox
    Friend WithEvents BtnTambahKoleksi As Button
    Friend WithEvents BtnTambahGambar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextNama As TextBox
    Friend WithEvents TextDeskripsi As RichTextBox
    Friend WithEvents TextPenerbit As TextBox
    Friend WithEvents TextLokasiRak As TextBox
    Friend WithEvents TextStock As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBEnglish As RadioButton
    Friend WithEvents RBBahasa As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBudaya As CheckBox
    Friend WithEvents CheckTeknologi As CheckBox
    Friend WithEvents CheckSosial As CheckBox
    Friend WithEvents CheckSains As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextTahunTerbit As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
