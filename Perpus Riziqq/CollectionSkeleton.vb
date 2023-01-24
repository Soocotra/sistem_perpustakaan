Imports MySql.Data.MySqlClient

Public Class CollectionSkeleton

    Private koleksiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection()
    Public Shared sqlCommand As New MySqlCommand()
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "perpustakaan"

    Private idKoleksi As String
    Private foto As String
    Private nama As String
    Private jenisKoleksi As String
    Private deskripsi As String
    Private penerbit As String
    Private tahunTerbit As String
    Private lokasiRak As String
    Private stock As String
    Private bahasa As String
    Private kategori As List(Of String)
    Private waktu As String

    Public Function GetDataKoleksiDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
                                    + "password=" + ";" + "database =" + database
        dbConn.Open()
        sqlCommand.Connection() = dbConn
        sqlCommand.CommandText = "SELECT ID_KOLEKSI AS 'ID',
                                 NAMA_KOLEKSI AS 'NAMA',
                                 JENIS_KOLEKSI AS 'JENIS KOLEKSI',
                                 PENERBIT AS 'PENERBIT',
                                 CREATED_AT AS 'TANGGAL MASUK',
                                 LOKASI_RAK AS 'LOKASI RAK',
                                 STOCK AS 'STOCK',
                                 BAHASA AS 'BAHASA',
                                 KATEGORI AS 'KATEGORI'
                                 FROM KOLEKSI "
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataKoleksiDatabase()
        Dim kategoriJoin = String.Join(", ", kategori.ToArray())
        Try
            dbConn.ConnectionString = "server = " + server + ";" + "user id=" _
                + username + ";" + "password=" + ";" + "database=" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO KOLEKSI 
                        (nama_koleksi, foto, jenis_koleksi, deskripsi, tahun_terbit, lokasi_rak, stock,
                         bahasa, kategori, penerbit)
                        VALUE (
                        '" & nama & "',
                        '" & foto & "',
                        '" & jenisKoleksi & "',
                        '" & deskripsi & "',
                        '" & tahunTerbit & "',
                        '" & lokasiRak & "',
                        '" & stock & "',
                        '" & bahasa & "',
                        '" & kategoriJoin & "',
                        '" & penerbit & "'
                        )"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function GetDataKoleksiByIdDatabase(Id As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username _
                                  + ";" + "password=" + password + ";" + "database =" _
                                  + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT ID_KOLEKSI,
                                    nama_koleksi,
                                    foto,
                                    penerbit,
                                    deskripsi,
                                    jenis_koleksi,
                                    tahun_terbit,
                                    lokasi_rak,
                                    created_at,
                                    stock,
                                    bahasa,
                                    kategori
                                    FROM koleksi 
                                    WHERE id_koleksi ='" & Id & "'"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
            result.Add(sqlRead.GetString(3).ToString())
            result.Add(sqlRead.GetString(4).ToString())
            result.Add(sqlRead.GetString(5).ToString())
            result.Add(sqlRead.GetString(6).ToString())
            result.Add(sqlRead.GetString(7).ToString())
            result.Add(sqlRead.GetString(8).ToString())
            result.Add(sqlRead.GetString(9).ToString())
            result.Add(sqlRead.GetString(10).ToString())
            result.Add(sqlRead.GetString(11).ToString())
        End While

        

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataKoleksiByIdDatabase(Id As Integer, data As List(Of String))

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" _
                                  + username + ";" + "password=" + password + ";" _
                                  + "database =" + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE KOLEKSI SET " &
                        "NAMA_KOLEKSI='" & data(0) & "', " &
                        "foto='" & data(1) & "', " &
                        "JENIS_KOLEKSI='" & data(2) & "', " &
                        "DESKRIPSI='" & data(3) & "', " &
                        "TAHUN_TERBIT='" & data(4) & "', " &
                        "LOKASI_RAK='" & data(5) & "', " &
                        "STOCK='" & data(6) & "', " &
                        "BAHASA='" & data(7) & "', " &
                        "KATEGORI='" & data(8) & "', " &
                        "PENERBIT='" & data(9) & "' " &
                        "WHERE ID_KOLEKSI='" & Id & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Function delete(id As String)
        Try
            dbConn.ConnectionString = "server = " + server + ";" + "user id=" _
                + username + ";" + "password=" + ";" + "database=" + database
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM koleksi WHERE id_koleksi =" + id

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            dbConn.Dispose()
        End Try
    End Function

    Public Property GSID()
        Get
            Return idKoleksi
        End Get
        Set(value)
            idKoleksi = value
        End Set
    End Property

    Public Property GSFoto() As String
        Get
            Return foto
        End Get
        Set(value As String)
            foto = value
        End Set
    End Property

    Public Property GSNama() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property

    Public Property GSJenisKoleksi() As String
        Get
            Return jenisKoleksi
        End Get
        Set(value As String)
            jenisKoleksi = value
        End Set
    End Property

    Public Property GSDeskripsi() As String
        Get
            Return deskripsi
        End Get
        Set(value As String)
            deskripsi = value
        End Set
    End Property

    Public Property GSPenerbit() As String
        Get
            Return penerbit
        End Get
        Set(value As String)
            penerbit = value
        End Set
    End Property

    Public Property GSTahunTerbit() As String
        Get
            Return tahunTerbit
        End Get
        Set(value As String)
            tahunTerbit = value
        End Set
    End Property

    Public Property GSLokasiRak() As String
        Get
            Return lokasiRak
        End Get
        Set(value As String)
            lokasiRak = value
        End Set
    End Property

    Public Property GSStock() As String
        Get
            Return stock
        End Get
        Set(value As String)
            stock = value
        End Set
    End Property

    Public Property GSBahasa() As String
        Get
            Return bahasa
        End Get
        Set(value As String)
            bahasa = value
        End Set
    End Property

    Public Property GSKategori() As List(Of String)
        Get
            Return kategori
        End Get
        Set(value As List(Of String))
            kategori = value
        End Set
    End Property

    Public Property GSWaktu() As String
        Get
            Return waktu
        End Get
        Set(value As String)
            waktu = value
        End Set
    End Property
End Class
