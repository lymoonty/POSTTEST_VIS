Public Class posttest_6
    Private Sub Kosong()
        txtKodeRincian.Clear()
        cbHewan.SelectedIndex = -1
        cbHewan.Text = ""
        txtJenisKelamin.Clear()
        txtUmur.Clear()
        txtStatusKesehatan.Clear()
        txtTanggalMasuk.Text = DateTime.Now.ToString("yyyy-MM-dd")
        txtCatatan.Clear()
        txtCari.Clear()
        ErrorProvider1.Clear()
        txtKodeRincian.Focus()
    End Sub

    Private Sub TampilData()
        dgvRincian.DataSource = DataModule.GetAllRincian()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dtHewan As DataTable = DataModule.GetAllHewan()
        cbHewan.DataSource = dtHewan
        cbHewan.DisplayMember = "namaHewan"
        cbHewan.ValueMember = "kodeHewan"

        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataRincian(ErrorProvider1, txtKodeRincian, cbHewan, txtJenisKelamin, txtUmur, txtStatusKesehatan, txtTanggalMasuk, txtCatatan) Then Exit Sub

        Dim kode As String = txtKodeRincian.Text.Trim()
        Dim kodeHewan As String = cbHewan.SelectedValue.ToString()
        Dim jk As String = txtJenisKelamin.Text.Trim()
        Dim umur As String = txtUmur.Text.Trim()
        Dim status As String = txtStatusKesehatan.Text.Trim()
        Dim tgl As String = txtTanggalMasuk.Text.Trim()
        Dim cat As String = txtCatatan.Text.Trim()

        If DataModule.KodeRincianSudahAda(kode) Then
            MessageBox.Show("Kode Rincian sudah terdaftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeRincian.Focus() : Exit Sub
        End If

        If DataModule.SimpanRincian(kode, kodeHewan, jk, umur, status, tgl, cat) Then
            MessageBox.Show("Data berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData() : Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        If Not ValidationModule.ValidasiDataRincian(ErrorProvider1, txtKodeRincian, cbHewan, txtJenisKelamin, txtUmur, txtStatusKesehatan, txtTanggalMasuk, txtCatatan) Then Exit Sub

        Dim kode As String = txtKodeRincian.Text.Trim()
        Dim kodeHewan As String = cbHewan.SelectedValue.ToString()
        Dim jk As String = txtJenisKelamin.Text.Trim()
        Dim umur As String = txtUmur.Text.Trim()
        Dim status As String = txtStatusKesehatan.Text.Trim()
        Dim tgl As String = txtTanggalMasuk.Text.Trim()
        Dim cat As String = txtCatatan.Text.Trim()

        If DataModule.UbahRincian(kode, kodeHewan, jk, umur, status, tgl, cat) Then
            MessageBox.Show("Data berhasil diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData() : Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan atau gagal diubah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeRincian.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus dari tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeRincian.Focus() : Exit Sub
        End If

        If MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DataModule.HapusRincian(txtKodeRincian.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData() : Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong() : TampilData()
    End Sub

    Private Sub dgvRincian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRincian.CellClick
        If e.RowIndex >= 0 Then
            txtKodeRincian.Text = dgvRincian.Rows(e.RowIndex).Cells(0).Value.ToString()
            cbHewan.Text = dgvRincian.Rows(e.RowIndex).Cells(1).Value.ToString()
            txtJenisKelamin.Text = dgvRincian.Rows(e.RowIndex).Cells(2).Value.ToString()
            txtUmur.Text = dgvRincian.Rows(e.RowIndex).Cells(3).Value.ToString()
            txtStatusKesehatan.Text = dgvRincian.Rows(e.RowIndex).Cells(4).Value.ToString()

            Dim tglObj As Object = dgvRincian.Rows(e.RowIndex).Cells(5).Value
            If tglObj IsNot Nothing AndAlso Not IsDBNull(tglObj) Then
                Try
                    txtTanggalMasuk.Text = Convert.ToDateTime(tglObj).ToString("yyyy-MM-dd")
                Catch
                    txtTanggalMasuk.Text = DateTime.Now.ToString("yyyy-MM-dd")
                End Try
            Else
                txtTanggalMasuk.Text = DateTime.Now.ToString("yyyy-MM-dd")
            End If

            txtCatatan.Text = dgvRincian.Rows(e.RowIndex).Cells(6).Value.ToString()
        End If
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        ValidationModule.HanyaAngka(e)
        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True
            txtStatusKesehatan.Focus()
        End If
    End Sub

    Private Sub txtJenisKelamin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJenisKelamin.KeyPress
        ValidationModule.HanyaHuruf(e)
        If ValidationModule.IsEnterKey(e) Then
            e.Handled = True
            txtUmur.Focus()
        End If
    End Sub

    Private Sub txtCari_TextChanged(sender As Object, e As EventArgs) Handles txtCari.TextChanged
        If txtCari.Text.Trim() = "" Then
            TampilData()
        Else
            dgvRincian.DataSource = DataModule.SearchRincian(txtCari.Text.Trim())
        End If
    End Sub
End Class