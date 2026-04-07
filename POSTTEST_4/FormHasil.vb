Public Class FormHasil

    Public Sub SetData(nama As String, id As String, divisi As String, kontak As String, hobby As String, foto As Image)
        Labelnm.Text = "Nama : " & nama
        LabelID.Text = "ID   : " & id
        Labelkmntas.Text = "Divisi : " & divisi
        Labelkntk.Text = "Kontak : " & kontak
        Labelhobby.Text = "Hobby : " & hobby

        If foto IsNot Nothing Then
            PictureBox1.Image = foto
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

End Class