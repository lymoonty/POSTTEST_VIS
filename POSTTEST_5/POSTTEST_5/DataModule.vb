Imports MySqlConnector

Module DataModule
    Public Function GetAllHewan() As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter("SELECT kodeHewan, namaHewan, jenisHewan FROM tbhewan ORDER BY kodeHewan ASC", conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchHewan(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter("SELECT kodeHewan, namaHewan, jenisHewan FROM tbhewan WHERE kodeHewan LIKE @kw OR namaHewan LIKE @kw OR jenisHewan LIKE @kw ORDER BY kodeHewan ASC", conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetHewanByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter("SELECT kodeHewan, namaHewan, jenisHewan FROM tbhewan WHERE kodeHewan = @kodeHewan", conn)
                    da.SelectCommand.Parameters.AddWithValue("@kodeHewan", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeSudahAda(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tbhewan WHERE kodeHewan = @kodeHewan", conn)
                    cmd.Parameters.AddWithValue("@kodeHewan", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanHewan(kode As String, nama As String, jenis As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("INSERT INTO tbhewan(kodeHewan, namaHewan, jenisHewan) VALUES(@kodeHewan, @namaHewan, @jenisHewan)", conn)
                    cmd.Parameters.AddWithValue("@kodeHewan", kode)
                    cmd.Parameters.AddWithValue("@namaHewan", nama)
                    cmd.Parameters.AddWithValue("@jenisHewan", jenis)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahHewan(kode As String, nama As String, jenis As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("UPDATE tbhewan SET namaHewan=@namaHewan, jenisHewan=@jenisHewan WHERE kodeHewan=@kodeHewan", conn)
                    cmd.Parameters.AddWithValue("@kodeHewan", kode)
                    cmd.Parameters.AddWithValue("@namaHewan", nama)
                    cmd.Parameters.AddWithValue("@jenisHewan", jenis)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusHewan(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM tbhewan WHERE kodeHewan = @kodeHewan", conn)
                    cmd.Parameters.AddWithValue("@kodeHewan", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetAllRincian() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT t.kodeRincian, h.namaHewan AS 'Nama Hewan', " &
                                  "t.jenisKelamin, t.umur, t.statusKesehatan, t.tanggalMasuk, t.catatan " &
                                  "FROM tbRincianHewan t INNER JOIN tbhewan h ON t.kodeHewan = h.kodeHewan " &
                                  "ORDER BY t.kodeRincian ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan rincian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchRincian(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT t.kodeRincian, h.namaHewan AS 'Nama Hewan', " &
                                  "t.jenisKelamin, t.umur, t.statusKesehatan, t.tanggalMasuk, t.catatan " &
                                  "FROM tbRincianHewan t INNER JOIN tbhewan h ON t.kodeHewan = h.kodeHewan " &
                                  "WHERE t.kodeRincian LIKE @kw OR h.namaHewan LIKE @kw OR t.statusKesehatan LIKE @kw " &
                                  "ORDER BY t.kodeRincian ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari rincian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeRincianSudahAda(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT COUNT(*) FROM tbRincianHewan WHERE kodeRincian = @kodeRincian", conn)
                    cmd.Parameters.AddWithValue("@kodeRincian", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa rincian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanRincian(kode As String, kodeHewan As String, jk As String, umur As String, status As String, tgl As String, cat As String) As Boolean
        Try
            Dim tglValid As String = If(String.IsNullOrWhiteSpace(tgl) OrElse tgl = "0000-00-00", DateTime.Now.ToString("yyyy-MM-dd"), tgl)

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("INSERT INTO tbRincianHewan(kodeRincian, kodeHewan, jenisKelamin, umur, statusKesehatan, tanggalMasuk, catatan) VALUES(@kodeRincian, @kodeHewan, @jenisKelamin, @umur, @statusKesehatan, @tanggalMasuk, @catatan)", conn)
                    cmd.Parameters.AddWithValue("@kodeRincian", kode)
                    cmd.Parameters.AddWithValue("@kodeHewan", kodeHewan)
                    cmd.Parameters.AddWithValue("@jenisKelamin", jk)
                    cmd.Parameters.AddWithValue("@umur", umur)
                    cmd.Parameters.AddWithValue("@statusKesehatan", status)
                    cmd.Parameters.AddWithValue("@tanggalMasuk", tglValid)
                    cmd.Parameters.AddWithValue("@catatan", cat)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan rincian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahRincian(kode As String, kodeHewan As String, jk As String, umur As String, status As String, tgl As String, cat As String) As Boolean
        Try
            Dim tglValid As String = If(String.IsNullOrWhiteSpace(tgl) OrElse tgl = "0000-00-00", DateTime.Now.ToString("yyyy-MM-dd"), tgl)

            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("UPDATE tbRincianHewan SET kodeHewan=@kodeHewan, jenisKelamin=@jenisKelamin, umur=@umur, statusKesehatan=@statusKesehatan, tanggalMasuk=@tanggalMasuk, catatan=@catatan WHERE kodeRincian=@kodeRincian", conn)
                    cmd.Parameters.AddWithValue("@kodeRincian", kode)
                    cmd.Parameters.AddWithValue("@kodeHewan", kodeHewan)
                    cmd.Parameters.AddWithValue("@jenisKelamin", jk)
                    cmd.Parameters.AddWithValue("@umur", umur)
                    cmd.Parameters.AddWithValue("@statusKesehatan", status)
                    cmd.Parameters.AddWithValue("@tanggalMasuk", tglValid)
                    cmd.Parameters.AddWithValue("@catatan", cat)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah rincian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusRincian(kode As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("DELETE FROM tbRincianHewan WHERE kodeRincian = @kodeRincian", conn)
                    cmd.Parameters.AddWithValue("@kodeRincian", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus rincian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module