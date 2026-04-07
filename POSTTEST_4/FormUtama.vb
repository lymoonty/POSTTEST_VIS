Public Class FormUtama

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txtnama.Text = "Nama"
        TxtID.Text = "ID Anggota"
        TextBoxemail.Text = "Email"
        TextBoxalmt.Text = "Alamat"
        Txtnama.ForeColor = Color.Gray
        TxtID.ForeColor = Color.Gray
        TextBoxemail.ForeColor = Color.Gray
        TextBoxalmt.ForeColor = Color.Gray

        If ComboBoxdvsi.Items.Count > 0 Then ComboBoxdvsi.SelectedIndex = 0
        Cbanggota.Checked = True
        TabControl1.SelectedTab = TabPage1
        ErrorProvider1.Clear()
    End Sub

    Private Sub TxtPlaceholder_Enter(sender As Object, e As EventArgs) Handles Txtnama.Enter, TxtID.Enter, TextBoxemail.Enter, TextBoxalmt.Enter
        Dim txt As TextBox = CType(sender, TextBox)
        txt.ForeColor = Color.Black

        If txt.Name = "Txtnama" AndAlso txt.Text = "Nama" Then txt.Text = ""
        If txt.Name = "TxtID" AndAlso txt.Text = "ID Anggota" Then txt.Text = ""
        If txt.Name = "TextBoxemail" AndAlso txt.Text = "Email" Then txt.Text = ""
        If txt.Name = "TextBoxalmt" AndAlso txt.Text = "Alamat" Then txt.Text = ""
    End Sub

    Private Sub TxtPlaceholder_Leave(sender As Object, e As EventArgs) Handles Txtnama.Leave, TxtID.Leave, TextBoxemail.Leave, TextBoxalmt.Leave
        Dim txt As TextBox = CType(sender, TextBox)

        If String.IsNullOrWhiteSpace(txt.Text) Then
            txt.ForeColor = Color.Gray
            If txt.Name = "Txtnama" Then txt.Text = "Nama"
            If txt.Name = "TxtID" Then txt.Text = "ID Anggota"
            If txt.Name = "TextBoxemail" Then txt.Text = "Email"
            If txt.Name = "TextBoxalmt" Then txt.Text = "Alamat"
        End If
    End Sub

    Private Function ValidasiForm() As Boolean
        ErrorProvider1.Clear()
        Dim isValid As Boolean = True

        If String.IsNullOrWhiteSpace(Txtnama.Text) OrElse Txtnama.Text = "Nama" Then
            ErrorProvider1.SetError(Txtnama, "Inputan tidak boleh kosong") : isValid = False
        End If
        If String.IsNullOrWhiteSpace(TxtID.Text) OrElse TxtID.Text = "ID Anggota" Then
            ErrorProvider1.SetError(TxtID, "Inputan tidak boleh kosong") : isValid = False
        End If
        If String.IsNullOrWhiteSpace(TextBoxemail.Text) OrElse TextBoxemail.Text = "Email" Then
            ErrorProvider1.SetError(TextBoxemail, "Inputan tidak boleh kosong") : isValid = False
        End If
        If String.IsNullOrWhiteSpace(TextBoxalmt.Text) OrElse TextBoxalmt.Text = "Alamat" Then
            ErrorProvider1.SetError(TextBoxalmt, "Inputan tidak boleh kosong") : isValid = False
        End If

        If Not MaskedTextBoxtlp.MaskCompleted Then
            ErrorProvider1.SetError(MaskedTextBoxtlp, "Nomor telepon belum lengkap!") : isValid = False
        End If

        Dim countHobby As Integer = 0
        For Each chk As CheckBox In GBhobby.Controls.OfType(Of CheckBox)()
            If chk.Checked Then countHobby += 1
        Next
        If countHobby = 0 Then
            ErrorProvider1.SetError(GBhobby, "Pilih minimal 1 hobby/aktivitas") : isValid = False
        End If

        Return isValid
    End Function
    Private Sub Txtnama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtnama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> " "c Then
            e.Handled = True
            ErrorProvider1.SetError(Txtnama, "Nama hanya boleh huruf & spasi")
        Else
            ErrorProvider1.SetError(Txtnama, "")
        End If
    End Sub

    Private Sub MaskedTextBoxtlp_Leave(sender As Object, e As EventArgs) Handles MaskedTextBoxtlp.Leave
        If Not MaskedTextBoxtlp.MaskCompleted Then
            ErrorProvider1.SetError(MaskedTextBoxtlp, "Format harus 0000-0000-0000")
        Else
            ErrorProvider1.SetError(MaskedTextBoxtlp, "")
        End If
    End Sub

    Private Sub Buttonbrwsr_Click(sender As Object, e As EventArgs) Handles Buttonbrwsr.Click
        OpenFileDialog1.Filter = "Gambar|*.jpg;*.jpeg;*.png"
        OpenFileDialog1.Title = "Pilih Foto Profil"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PictureBoxpoto.Image = Image.FromFile(OpenFileDialog1.FileName)
            PictureBoxpoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        If ValidasiForm() Then TampilkanKartu()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If ValidasiForm() Then ProsesSimpan()
    End Sub

    Private Sub BukaDataToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem1.Click
        Dim ofd As New OpenFileDialog()
        ofd.Filter = "Text File|*.txt|CSV File|*.csv"
        ofd.Title = "Buka Data Anggota"
        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim data As String = IO.File.ReadAllText(ofd.FileName)
                Dim parts() As String = data.Split("|"c)
                Txtnama.Text = parts(0)
                TxtID.Text = parts(1)
                ComboBoxdvsi.Text = parts(2)
                MaskedTextBoxtlp.Text = parts(3)
                TextBoxemail.Text = parts(4)
                TextBoxalmt.Text = parts(5)

                Cbketua.Checked = (parts(6) = "Ketua")
                Cbanggota.Checked = (parts(6) = "Anggota")
                Cbadmin.Checked = (parts(6) = "Admin Medsos")
                CbRL.Checked = (parts(6) = "Relawan Lapangan")

                Dim hobbiesStr As String = If(parts.Length > 7, parts(7), "")
                For Each chk As CheckBox In GBhobby.Controls.OfType(Of CheckBox)()
                    chk.Checked = hobbiesStr.Contains(chk.Text)
                Next
                MessageBox.Show("Data berhasil dimuat.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Gagal membaca file atau format tidak sesuai.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem1.Click
        Dim keluar = MessageBox.Show("Yakin ingin keluar dari aplikasi?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If keluar = DialogResult.Yes Then Application.Exit()
    End Sub
    Private Sub Buttonsmpn_Click(sender As Object, e As EventArgs) Handles Buttonsmpn.Click
        If ValidasiForm() Then
            Dim konfirmasi = MessageBox.Show("Data dah bener blom? mau simpan dan cetak kartu sekarang?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If konfirmasi = DialogResult.Yes Then
                ProsesSimpan()
                TampilkanKartu()
            End If
        End If
    End Sub

    Private Sub ProsesSimpan()
        SaveFileDialog1.Filter = "Text File|*.txt|CSV File|*.csv"
        SaveFileDialog1.Title = "Simpan Data Anggota"
        SaveFileDialog1.FileName = "Anggota_" & Txtnama.Text.Replace(" ", "_")

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim peran As String = ""
            If Cbketua.Checked Then
                peran = "Ketua"
            ElseIf Cbanggota.Checked Then
                peran = "Anggota"
            ElseIf Cbadmin.Checked Then
                peran = "Admin Medsos"
            ElseIf CbRL.Checked Then
                peran = "Relawan Lapangan"
            Else
                peran = "Lainnya"
            End If

            Dim listHobby As New List(Of String)
            For Each chk As CheckBox In GBhobby.Controls.OfType(Of CheckBox)()
                If chk.Checked Then listHobby.Add(chk.Text)
            Next

            Dim formatData As String = $"{Txtnama.Text}|{TxtID.Text}|{ComboBoxdvsi.Text}|{MaskedTextBoxtlp.Text}|{TextBoxemail.Text}|{TextBoxalmt.Text}|{peran}|{String.Join(",", listHobby)}"
            IO.File.WriteAllText(SaveFileDialog1.FileName, formatData)
            MessageBox.Show("Data udah kesimpan ye", "zukzess", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub TampilkanKartu()
        Dim frmHasil As New FormHasil()
        frmHasil.SetData(
            Txtnama.Text,
            TxtID.Text,
            ComboBoxdvsi.Text,
            MaskedTextBoxtlp.Text & " | " & TextBoxemail.Text,
            String.Join(", ", GBhobby.Controls.OfType(Of CheckBox)().Where(Function(c) c.Checked).Select(Function(c) c.Text)),
            PictureBoxpoto.Image
        )
        frmHasil.ShowDialog()
    End Sub

End Class