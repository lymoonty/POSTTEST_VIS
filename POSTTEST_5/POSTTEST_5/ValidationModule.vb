Module ValidationModule
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngka(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiComboBox(ep As ErrorProvider, cb As ComboBox, pesan As String) As Boolean
        If cb.SelectedIndex = -1 OrElse cb.Text.Trim() = "" Then
            ep.SetError(cb, pesan)
            Return False
        Else
            ep.SetError(cb, "")
            Return True
        End If
    End Function

    Public Function ValidasiDataHewan(ep As ErrorProvider, txtKode As TextBox, txtNama As TextBox, txtJenis As TextBox) As Boolean
        Dim v1 = ValidasiTextBox(ep, txtKode, "Kode Hewan gak boleh kosong")
        Dim v2 = ValidasiTextBox(ep, txtNama, "Nama Hewan gak boleh kosong")
        Dim v3 = ValidasiTextBox(ep, txtJenis, "Jenis Hewan gak boleh kosong")
        Return v1 And v2 And v3
    End Function

    Public Function ValidasiDataRincian(ep As ErrorProvider, txtKode As TextBox, cbHewan As ComboBox, txtJK As TextBox, txtUmur As TextBox, txtStatus As TextBox, txtTgl As TextBox, txtCat As TextBox) As Boolean
        Dim v1 = ValidasiTextBox(ep, txtKode, "Kode Rincian wajib diisi!")
        Dim v2 = ValidasiComboBox(ep, cbHewan, "Silakan pilih Hewan!")
        Dim v3 = ValidasiTextBox(ep, txtJK, "Jenis Kelamin wajib diisi!")
        Dim v4 = ValidasiTextBox(ep, txtUmur, "Umur wajib diisi!")
        Dim v5 = ValidasiTextBox(ep, txtStatus, "Status Kesehatan wajib diisi!")
        Dim v6 = ValidasiTextBox(ep, txtTgl, "Tanggal Masuk wajib diisi!")
        Return v1 And v2 And v3 And v4 And v5 And v6
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function
End Module