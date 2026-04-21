<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class posttest_6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Labelrncian = New Label()
        Labelhewn = New Label()
        LabelJK = New Label()
        LabelUM = New Label()
        LabelSK = New Label()
        LabelTM = New Label()
        Labelcttn = New Label()
        txtKodeRincian = New TextBox()
        cbHewan = New ComboBox()
        txtJenisKelamin = New TextBox()
        txtUmur = New TextBox()
        txtStatusKesehatan = New TextBox()
        txtTanggalMasuk = New TextBox()
        txtCatatan = New TextBox()
        txtCari = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        dgvRincian = New DataGridView()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvRincian, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Labelrncian
        ' 
        Labelrncian.AutoSize = True
        Labelrncian.Location = New Point(35, 20)
        Labelrncian.Name = "Labelrncian"
        Labelrncian.Size = New Size(96, 20)
        Labelrncian.TabIndex = 0
        Labelrncian.Text = "Kode Rincian"
        ' 
        ' Labelhewn
        ' 
        Labelhewn.AutoSize = True
        Labelhewn.Location = New Point(309, 19)
        Labelhewn.Name = "Labelhewn"
        Labelhewn.Size = New Size(55, 20)
        Labelhewn.TabIndex = 1
        Labelhewn.Text = "Hewan"
        ' 
        ' LabelJK
        ' 
        LabelJK.AutoSize = True
        LabelJK.Location = New Point(35, 63)
        LabelJK.Name = "LabelJK"
        LabelJK.Size = New Size(98, 20)
        LabelJK.TabIndex = 2
        LabelJK.Text = "Jenis Kelamin"
        ' 
        ' LabelUM
        ' 
        LabelUM.AutoSize = True
        LabelUM.Location = New Point(35, 111)
        LabelUM.Name = "LabelUM"
        LabelUM.Size = New Size(45, 20)
        LabelUM.TabIndex = 3
        LabelUM.Text = "Umur"
        ' 
        ' LabelSK
        ' 
        LabelSK.AutoSize = True
        LabelSK.Location = New Point(35, 163)
        LabelSK.Name = "LabelSK"
        LabelSK.Size = New Size(121, 20)
        LabelSK.TabIndex = 4
        LabelSK.Text = "Status Kesehatan"
        ' 
        ' LabelTM
        ' 
        LabelTM.AutoSize = True
        LabelTM.Location = New Point(35, 212)
        LabelTM.Name = "LabelTM"
        LabelTM.Size = New Size(107, 20)
        LabelTM.TabIndex = 5
        LabelTM.Text = "Tanggal Masuk"
        ' 
        ' Labelcttn
        ' 
        Labelcttn.AutoSize = True
        Labelcttn.Location = New Point(615, 20)
        Labelcttn.Name = "Labelcttn"
        Labelcttn.Size = New Size(60, 20)
        Labelcttn.TabIndex = 19
        Labelcttn.Text = "Catatan"
        ' 
        ' txtKodeRincian
        ' 
        txtKodeRincian.Location = New Point(162, 13)
        txtKodeRincian.Name = "txtKodeRincian"
        txtKodeRincian.Size = New Size(125, 27)
        txtKodeRincian.TabIndex = 7
        ' 
        ' cbHewan
        ' 
        cbHewan.FormattingEnabled = True
        cbHewan.Location = New Point(380, 12)
        cbHewan.Name = "cbHewan"
        cbHewan.Size = New Size(210, 28)
        cbHewan.TabIndex = 6
        ' 
        ' txtJenisKelamin
        ' 
        txtJenisKelamin.Location = New Point(162, 56)
        txtJenisKelamin.Name = "txtJenisKelamin"
        txtJenisKelamin.Size = New Size(343, 27)
        txtJenisKelamin.TabIndex = 8
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(162, 104)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(343, 27)
        txtUmur.TabIndex = 9
        ' 
        ' txtStatusKesehatan
        ' 
        txtStatusKesehatan.Location = New Point(162, 156)
        txtStatusKesehatan.Name = "txtStatusKesehatan"
        txtStatusKesehatan.Size = New Size(343, 27)
        txtStatusKesehatan.TabIndex = 10
        ' 
        ' txtTanggalMasuk
        ' 
        txtTanggalMasuk.Location = New Point(162, 205)
        txtTanggalMasuk.Name = "txtTanggalMasuk"
        txtTanggalMasuk.Size = New Size(343, 27)
        txtTanggalMasuk.TabIndex = 11
        ' 
        ' txtCatatan
        ' 
        txtCatatan.Location = New Point(529, 56)
        txtCatatan.Multiline = True
        txtCatatan.Name = "txtCatatan"
        txtCatatan.Size = New Size(241, 176)
        txtCatatan.TabIndex = 18
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(16, 310)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(772, 27)
        txtCari.TabIndex = 12
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(32, 262)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 13
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(241, 262)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 14
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(465, 262)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 15
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(676, 262)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(94, 29)
        btnBatal.TabIndex = 16
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' dgvRincian
        ' 
        dgvRincian.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRincian.Location = New Point(16, 343)
        dgvRincian.Name = "dgvRincian"
        dgvRincian.RowHeadersWidth = 51
        dgvRincian.Size = New Size(772, 171)
        dgvRincian.TabIndex = 17
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(800, 515)
        Controls.Add(txtCatatan)
        Controls.Add(Labelcttn)
        Controls.Add(dgvRincian)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtCari)
        Controls.Add(txtTanggalMasuk)
        Controls.Add(txtStatusKesehatan)
        Controls.Add(txtUmur)
        Controls.Add(txtJenisKelamin)
        Controls.Add(cbHewan)
        Controls.Add(txtKodeRincian)
        Controls.Add(LabelTM)
        Controls.Add(LabelSK)
        Controls.Add(LabelUM)
        Controls.Add(LabelJK)
        Controls.Add(Labelhewn)
        Controls.Add(Labelrncian)
        Name = "Form2"
        Text = "Rincian Hewan"
        CType(dgvRincian, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Labelrncian As Label
    Friend WithEvents Labelhewn As Label
    Friend WithEvents LabelJK As Label
    Friend WithEvents LabelUM As Label
    Friend WithEvents LabelSK As Label
    Friend WithEvents LabelTM As Label
    Friend WithEvents Labelcttn As Label
    Friend WithEvents txtKodeRincian As TextBox
    Friend WithEvents cbHewan As ComboBox
    Friend WithEvents txtJenisKelamin As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtStatusKesehatan As TextBox
    Friend WithEvents txtTanggalMasuk As TextBox
    Friend WithEvents txtCatatan As TextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents dgvRincian As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class