Imports MySqlConnector

Module DataModule
    Public Function GetAllHewan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodeHewan, namaHewan, jenisHewan FROM tbhewan ORDER BY kodeHewan ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
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
            Dim query As String = "SELECT kodeHewan, namaHewan, jenisHewan FROM tbhewan " &
                                  "WHERE kodeHewan LIKE @keyword OR namaHewan LIKE @keyword OR jenisHewan LIKE @keyword " &
                                  "ORDER BY kodeHewan ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetHewanByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT kodeHewan, namaHewan, jenisHewan FROM tbhewan WHERE kodeHewan = @kodeHewan"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
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
            Dim query As String = "SELECT COUNT(*) FROM tbhewan WHERE kodeHewan = @kodeHewan"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeHewan", kode)
                    Dim jumlah As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    Return jumlah > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanHewan(kode As String, nama As String, jenis As String) As Boolean
        Try
            Dim query As String = "INSERT INTO tbhewan(kodeHewan, namaHewan, jenisHewan) VALUES(@kodeHewan, @namaHewan, @jenisHewan)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
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
            Dim query As String = "UPDATE tbhewan SET namaHewan=@namaHewan, jenisHewan=@jenisHewan WHERE kodeHewan=@kodeHewan"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
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
            Dim query As String = "DELETE FROM tbhewan WHERE kodeHewan = @kodeHewan"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kodeHewan", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module