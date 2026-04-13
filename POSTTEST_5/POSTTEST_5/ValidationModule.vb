Module ValidationModule
    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse Char.IsWhiteSpace(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
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

    Public Function ValidasiDataHewan(ep As ErrorProvider, txtKode As TextBox, txtNama As TextBox, txtJenis As TextBox) As Boolean
        Dim v1 As Boolean = ValidasiTextBox(ep, txtKode, "Kode Hewan gak boleh kosong")
        Dim v2 As Boolean = ValidasiTextBox(ep, txtNama, "Nama Hewan gak boleh kosong")
        Dim v3 As Boolean = ValidasiTextBox(ep, txtJenis, "Jenis Hewan gak boleh kosong")
        Return v1 And v2 And v3
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function
End Module