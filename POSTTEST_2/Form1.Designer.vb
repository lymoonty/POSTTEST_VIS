<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label1 = New Label()
        ButtonTmbh = New Button()
        TextBoxTmbhjudul = New TextBox()
        TextBoxTmbhgenre = New TextBox()
        TextBoxhpsJudul = New TextBox()
        GroupBox2 = New GroupBox()
        Label4 = New Label()
        Label2 = New Label()
        ButtonHps = New Button()
        LabelDftrBuku = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.AliceBlue
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(ButtonTmbh)
        GroupBox1.Controls.Add(TextBoxTmbhjudul)
        GroupBox1.Controls.Add(TextBoxTmbhgenre)
        GroupBox1.Location = New Point(16, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(309, 187)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Tambah Buku"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 20)
        Label3.TabIndex = 9
        Label3.Text = "Genre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 7
        Label1.Text = "Judul Buku"
        ' 
        ' ButtonTmbh
        ' 
        ButtonTmbh.BackColor = Color.LightCyan
        ButtonTmbh.Location = New Point(176, 152)
        ButtonTmbh.Name = "ButtonTmbh"
        ButtonTmbh.Size = New Size(94, 29)
        ButtonTmbh.TabIndex = 5
        ButtonTmbh.Text = "Tambah"
        ButtonTmbh.UseVisualStyleBackColor = False
        ' 
        ' TextBoxTmbhjudul
        ' 
        TextBoxTmbhjudul.BackColor = Color.LightCyan
        TextBoxTmbhjudul.Location = New Point(107, 37)
        TextBoxTmbhjudul.Name = "TextBoxTmbhjudul"
        TextBoxTmbhjudul.Size = New Size(147, 27)
        TextBoxTmbhjudul.TabIndex = 2
        ' 
        ' TextBoxTmbhgenre
        ' 
        TextBoxTmbhgenre.BackColor = Color.LightCyan
        TextBoxTmbhgenre.Location = New Point(107, 87)
        TextBoxTmbhgenre.Name = "TextBoxTmbhgenre"
        TextBoxTmbhgenre.Size = New Size(147, 27)
        TextBoxTmbhgenre.TabIndex = 3
        ' 
        ' TextBoxhpsJudul
        ' 
        TextBoxhpsJudul.BackColor = Color.LightCyan
        TextBoxhpsJudul.Location = New Point(110, 37)
        TextBoxhpsJudul.Name = "TextBoxhpsJudul"
        TextBoxhpsJudul.Size = New Size(153, 27)
        TextBoxhpsJudul.TabIndex = 1
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.AliceBlue
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(ButtonHps)
        GroupBox2.Controls.Add(TextBoxhpsJudul)
        GroupBox2.Location = New Point(379, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(310, 187)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Hapus Buku"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(29, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 20)
        Label4.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(29, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 20)
        Label2.TabIndex = 8
        Label2.Text = "Judul Buku"
        ' 
        ' ButtonHps
        ' 
        ButtonHps.BackColor = Color.LightCyan
        ButtonHps.Location = New Point(190, 152)
        ButtonHps.Name = "ButtonHps"
        ButtonHps.Size = New Size(94, 29)
        ButtonHps.TabIndex = 6
        ButtonHps.Text = "Hapus"
        ButtonHps.UseVisualStyleBackColor = False
        ' 
        ' LabelDftrBuku
        ' 
        LabelDftrBuku.BackColor = Color.AliceBlue
        LabelDftrBuku.BorderStyle = BorderStyle.FixedSingle
        LabelDftrBuku.Location = New Point(192, 245)
        LabelDftrBuku.Name = "LabelDftrBuku"
        LabelDftrBuku.Size = New Size(340, 196)
        LabelDftrBuku.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(721, 450)
        Controls.Add(LabelDftrBuku)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Posttest2"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxhpsJudul As TextBox
    Friend WithEvents TextBoxTmbhjudul As TextBox
    Friend WithEvents TextBoxTmbhgenre As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ButtonTmbh As Button
    Friend WithEvents ButtonHps As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelDftrBuku As Label

End Class
