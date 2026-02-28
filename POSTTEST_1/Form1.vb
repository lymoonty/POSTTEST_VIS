Public Class Form1
    ' Mendeklarasi variabel di luar sub agar aplikasinya tetap berjalan
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    ' Tombol tambah untuk menghitung IPK dan menentukan predikat
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Try
            Dim ipInput As Double = Val(txtIP.Text)
            If ipInput >= 0 And ipInput <= 4.0 Then
                totalIP += ipInput
                jumlahSemester += 1

                ' Menghitung rata -rata IPk
                Dim ipk As Double = totalIP / jumlahSemester
                txtIPK.Text = Format(ipk, "0.00")

                ' Menentukan predikat berdasarkan nilai IPk
                If ipk >= 3.01 Then
                    lblPredikat.Text = "Sangat Memuaskan"
                ElseIf ipk >= 2.76 Then
                    lblPredikat.Text = "Memuaskan"
                ElseIf ipk >= 2.0 Then
                    lblPredikat.Text = "Cukup"
                Else
                    lblPredikat.Text = "Kurang"
                End If

                ' Mengosongkan input IP untuk semester berikutnya
                txtIP.Clear()
                txtIP.Focus()
            Else
                MsgBox("Harap masukkan nilai IP antara 0 sampai 4!")
            End If
        Catch ex As Exception
            MsgBox("Terjadi kesalahan!")
        End Try
    End Sub

    ' Tombol reset untuk mengembalikan semuanya ke awal
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        totalIP = 0
        jumlahSemester = 0
        txtIP.Clear()
        txtIPK.Clear()
        lblPredikat.Text = "-"
    End Sub
End Class