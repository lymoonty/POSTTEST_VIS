Public Class Form1
    Private Sub textnm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textnm.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textum.KeyPress, Texttlp.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles Btn.Click
        Dim openFile As New OpenFileDialog
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png"
        openFile.Title = "Pilih Foto Profil"

        If openFile.ShowDialog = DialogResult.OK Then
            PicBox.Image = Image.FromFile(openFile.FileName)
            PicBox.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Buttonctk_Click(sender As Object, e As EventArgs) Handles Buttonctk.Click
        If textnm.Text = "" Or Textum.Text = "" Or TextAlmt.Text = "" Or TextAlmt.Text = "" Then
            MessageBox.Show("Inputannya gabole kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not RadioButtonLK.Checked And Not RadioButtonPR.Checked Then
            MessageBox.Show("Inputannya gabole kosong (Jenis kelaminnya isi dulu)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim hobiDipilih As String = ""
        Dim countHobi As Integer = 0

        For Each ctrl As Control In GroupBoxHB.Controls
            If TypeOf ctrl Is CheckBox Then
                If DirectCast(ctrl, CheckBox).Checked Then
                    hobiDipilih &= DirectCast(ctrl, CheckBox).Text & ", "
                    countHobi += 1
                End If
            End If
        Next

        If countHobi = 0 Then
            MessageBox.Show("Inputannya tida bole kosong (Hobby minimal pilih satu)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If PicBox.Image Is Nothing Then
            MessageBox.Show("Inputannya tidak bole kosongg (Foto belum diunggah)", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        hobiDipilih = hobiDipilih.TrimEnd(","c, " "c)

        Dim jk As String = If(RadioButtonLK.Checked, "Laki-laki", "Perempuan")

        With Form2
            .Labelnama.Text = "Nama: " & textnm.Text
            .Labelumur.Text = "Umur: " & Textum.Text & " Tahun"
            .Labelnohp.Text = "No. Telp: " & Texttlp.Text
            .Labelalamt.Text = "Alamat: " & TextAlmt.Text
            .LabelTglLahir.Text = "Tgl Lahir: " & DTPLahir.Value.ToString("dd MMMM yyyy")
            .Labelhobby.Text = "Hobby: " & hobiDipilih

            .PB.Image = PicBox.Image
            .PB.SizeMode = PictureBoxSizeMode.StretchImage

            .Show()
        End With
    End Sub
End Class
