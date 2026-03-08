Public Class Form1
    Private Sub UpdateTampilan(ByVal lbl As Label)
        lbl.Text = ""
        For i As Integer = 0 To jumlahBuku - 1
            lbl.Text &= daftarBuku(i, 0) & " (" & daftarBuku(i, 1) & ")" & vbCrLf
        Next
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles ButtonTmbh.Click
        If jumlahBuku < 100 Then
            daftarBuku(jumlahBuku, 0) = TextBoxTmbhjudul.Text
            daftarBuku(jumlahBuku, 1) = TextBoxTmbhgenre.Text
            jumlahBuku += 1

            UpdateTampilan(LabelDftrBuku)
            TextBoxTmbhjudul.Clear()
            TextBoxTmbhgenre.Clear()
        Else
            MessageBox.Show("Maaf, daftar buku sudah mencapai daftar maksimal")
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles ButtonHps.Click
        Dim indeks As Integer = CariIndeksBuku(TextBoxhpsJudul.Text)

        If indeks <> -1 Then
            For i As Integer = indeks To jumlahBuku - 2
                daftarBuku(i, 0) = daftarBuku(i + 1, 0)
                daftarBuku(i, 1) = daftarBuku(i + 1, 1)
            Next
            jumlahBuku -= 1

            UpdateTampilan(LabelDftrBuku)
            TextBoxhpsJudul.Clear()
            MessageBox.Show("Buku berhasil dihapus.")
        Else
            MessageBox.Show("Judul buku tidak ditemukan.")
        End If
    End Sub
End Class