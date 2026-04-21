Public Class Form1
    Private Sub Kosong()
        TextBoxkode.Clear()
        TextBoxnmhwn.Clear()
        TextBoxjenis.Clear()
        TextBoxcari.Clear()
        ErrorProvider1.Clear()
        TextBoxkode.Focus()
    End Sub

    Private Sub TampilData()
        DGVHewan.DataSource = GetAllHewan()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub Buttonsmpn_Click(sender As Object, e As EventArgs) Handles Buttonsmpn.Click
        ErrorProvider1.Clear()
        If Not ValidasiDataHewan(ErrorProvider1, TextBoxkode, TextBoxnmhwn, TextBoxjenis) Then Exit Sub

        Dim kode As String = TextBoxkode.Text.Trim()
        Dim nama As String = TextBoxnmhwn.Text.Trim()
        Dim jenis As String = TextBoxjenis.Text.Trim()

        If KodeSudahAda(kode) Then
            MessageBox.Show("Kode Hewan sudah terdaftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxkode.Focus()
            Exit Sub
        End If

        If SimpanHewan(kode, nama, jenis) Then
            MessageBox.Show("Data berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub Buttonubh_Click(sender As Object, e As EventArgs) Handles Buttonubh.Click
        ErrorProvider1.Clear()
        If Not ValidasiDataHewan(ErrorProvider1, TextBoxkode, TextBoxnmhwn, TextBoxjenis) Then Exit Sub

        Dim kode As String = TextBoxkode.Text.Trim()
        Dim nama As String = TextBoxnmhwn.Text.Trim()
        Dim jenis As String = TextBoxjenis.Text.Trim()

        If UbahHewan(kode, nama, jenis) Then
            MessageBox.Show("Data berhasil diubah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan atau gagal diubah.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub Buttonhps_Click(sender As Object, e As EventArgs) Handles Buttonhps.Click
        If TextBoxkode.Text.Trim() = "" Then
            MessageBox.Show("Pilih data yang akan dihapus dari tabel.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBoxkode.Focus()
            Exit Sub
        End If

        Dim hasil As DialogResult = MessageBox.Show("Apakah data ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusHewan(TextBoxkode.Text.Trim()) Then
                MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub Buttonbtl_Click(sender As Object, e As EventArgs) Handles Buttonbtl.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub DGVHewan_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVHewan.CellClick
        If e.RowIndex >= 0 Then
            TextBoxkode.Text = DGVHewan.Rows(e.RowIndex).Cells("kodeHewan").Value.ToString()
            TextBoxnmhwn.Text = DGVHewan.Rows(e.RowIndex).Cells("namaHewan").Value.ToString()
            TextBoxjenis.Text = DGVHewan.Rows(e.RowIndex).Cells("jenisHewan").Value.ToString()
            TextBoxkode.Enabled = False
        End If
    End Sub

    Private Sub TextBoxkode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxkode.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            Dim dt As DataTable = GetHewanByKode(TextBoxkode.Text.Trim())
            If dt.Rows.Count > 0 Then
                TextBoxkode.Text = dt.Rows(0)("kodeHewan").ToString()
                TextBoxnmhwn.Text = dt.Rows(0)("namaHewan").ToString()
                TextBoxjenis.Text = dt.Rows(0)("jenisHewan").ToString()
                TextBoxkode.Enabled = False
            Else
                TextBoxnmhwn.Clear()
                TextBoxjenis.Clear()
                TextBoxkode.Enabled = True
            End If
            TextBoxnmhwn.Focus()
        End If
    End Sub

    Private Sub TextBoxnmhwn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxnmhwn.KeyPress
        HanyaHuruf(e)
        If IsEnterKey(e) Then
            e.Handled = True
            TextBoxjenis.Focus()
        End If
    End Sub

    Private Sub TextBoxjenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxjenis.KeyPress
        HanyaHuruf(e)
        If IsEnterKey(e) Then
            e.Handled = True
            Buttonsmpn.Focus()
        End If
    End Sub

    Private Sub TextBoxcari_TextChanged(sender As Object, e As EventArgs) Handles TextBoxcari.TextChanged
        If TextBoxcari.Text.Trim() = "" Then
            TampilData()
        Else
            DGVHewan.DataSource = SearchHewan(TextBoxcari.Text.Trim())
        End If
    End Sub

    Private Sub RIncianHewanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RIncianHewanToolStripMenuItem.Click
        Form2.Show()
    End Sub
End Class