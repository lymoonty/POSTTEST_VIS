<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Btn = New Button()
        PB = New PictureBox()
        Labelalamt = New Label()
        Labelnohp = New Label()
        LabelTglLahir = New Label()
        Labelumur = New Label()
        Labelnama = New Label()
        Labelhobby = New Label()
        LabelJenisklmn = New Label()
        CType(PB, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Btn
        ' 
        Btn.BackColor = Color.AliceBlue
        Btn.Location = New Point(298, 492)
        Btn.Name = "Btn"
        Btn.Size = New Size(94, 29)
        Btn.TabIndex = 15
        Btn.Text = "Browse"
        Btn.UseVisualStyleBackColor = False
        ' 
        ' PB
        ' 
        PB.BorderStyle = BorderStyle.FixedSingle
        PB.Location = New Point(10, 12)
        PB.Name = "PB"
        PB.Size = New Size(264, 400)
        PB.SizeMode = PictureBoxSizeMode.StretchImage
        PB.TabIndex = 14
        PB.TabStop = False
        ' 
        ' Labelalamt
        ' 
        Labelalamt.AutoSize = True
        Labelalamt.BackColor = Color.Transparent
        Labelalamt.Location = New Point(292, 223)
        Labelalamt.Name = "Labelalamt"
        Labelalamt.Size = New Size(57, 20)
        Labelalamt.TabIndex = 28
        Labelalamt.Text = "Alamat"
        ' 
        ' Labelnohp
        ' 
        Labelnohp.AutoSize = True
        Labelnohp.BackColor = Color.Transparent
        Labelnohp.Location = New Point(292, 151)
        Labelnohp.Name = "Labelnohp"
        Labelnohp.Size = New Size(52, 20)
        Labelnohp.TabIndex = 27
        Labelnohp.Text = "No HP"
        ' 
        ' LabelTglLahir
        ' 
        LabelTglLahir.AutoSize = True
        LabelTglLahir.BackColor = Color.Transparent
        LabelTglLahir.Location = New Point(292, 90)
        LabelTglLahir.Name = "LabelTglLahir"
        LabelTglLahir.Size = New Size(94, 20)
        LabelTglLahir.TabIndex = 26
        LabelTglLahir.Text = "Tanggal lahir"
        ' 
        ' Labelumur
        ' 
        Labelumur.AutoSize = True
        Labelumur.BackColor = Color.Transparent
        Labelumur.Location = New Point(292, 52)
        Labelumur.Name = "Labelumur"
        Labelumur.Size = New Size(45, 20)
        Labelumur.TabIndex = 25
        Labelumur.Text = "Umur"
        ' 
        ' Labelnama
        ' 
        Labelnama.AutoSize = True
        Labelnama.BackColor = Color.Transparent
        Labelnama.Location = New Point(292, 22)
        Labelnama.Name = "Labelnama"
        Labelnama.Size = New Size(49, 20)
        Labelnama.TabIndex = 24
        Labelnama.Text = "Nama"
        ' 
        ' Labelhobby
        ' 
        Labelhobby.AutoSize = True
        Labelhobby.Location = New Point(292, 188)
        Labelhobby.Name = "Labelhobby"
        Labelhobby.Size = New Size(54, 20)
        Labelhobby.TabIndex = 30
        Labelhobby.Text = "Hobby"
        ' 
        ' LabelJenisklmn
        ' 
        LabelJenisklmn.AutoSize = True
        LabelJenisklmn.Location = New Point(292, 118)
        LabelJenisklmn.Name = "LabelJenisklmn"
        LabelJenisklmn.Size = New Size(98, 20)
        LabelJenisklmn.TabIndex = 31
        LabelJenisklmn.Text = "Jenis Kelamin"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.download__1_
        ClientSize = New Size(800, 450)
        Controls.Add(LabelJenisklmn)
        Controls.Add(Labelhobby)
        Controls.Add(Labelalamt)
        Controls.Add(Labelnohp)
        Controls.Add(LabelTglLahir)
        Controls.Add(Labelumur)
        Controls.Add(Labelnama)
        Controls.Add(Btn)
        Controls.Add(PB)
        Name = "Form2"
        Text = "Form2"
        CType(PB, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btn As Button
    Friend WithEvents PB As PictureBox
    Friend WithEvents Labelalamt As Label
    Friend WithEvents Labelnohp As Label
    Friend WithEvents LabelTglLahir As Label
    Friend WithEvents Labelumur As Label
    Friend WithEvents Labelnama As Label
    Friend WithEvents Labelhobby As Label
    Friend WithEvents LabelJenisklmn As Label
End Class
