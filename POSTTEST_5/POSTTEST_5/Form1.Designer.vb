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
        components = New ComponentModel.Container()
        PictureBox1 = New PictureBox()
        DGVHewan = New DataGridView()
        TextBoxcari = New TextBox()
        TextBoxjenis = New TextBox()
        TextBoxkode = New TextBox()
        TextBoxnmhwn = New TextBox()
        Labelkdhwn = New Label()
        Labelnmhwn = New Label()
        Labeljnshwn = New Label()
        labelsearch = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        Buttonsmpn = New Button()
        Buttonubh = New Button()
        Buttonhps = New Button()
        Buttonbtl = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DGVHewan, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.images
        PictureBox1.Location = New Point(481, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(162, 140)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' DGVHewan
        ' 
        DGVHewan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVHewan.Location = New Point(-3, 226)
        DGVHewan.Name = "DGVHewan"
        DGVHewan.RowHeadersWidth = 51
        DGVHewan.Size = New Size(810, 233)
        DGVHewan.TabIndex = 1
        ' 
        ' TextBoxcari
        ' 
        TextBoxcari.Location = New Point(147, 123)
        TextBoxcari.Name = "TextBoxcari"
        TextBoxcari.Size = New Size(311, 27)
        TextBoxcari.TabIndex = 2
        ' 
        ' TextBoxjenis
        ' 
        TextBoxjenis.Location = New Point(147, 86)
        TextBoxjenis.Name = "TextBoxjenis"
        TextBoxjenis.Size = New Size(311, 27)
        TextBoxjenis.TabIndex = 3
        ' 
        ' TextBoxkode
        ' 
        TextBoxkode.Location = New Point(147, 15)
        TextBoxkode.Name = "TextBoxkode"
        TextBoxkode.Size = New Size(311, 27)
        TextBoxkode.TabIndex = 4
        ' 
        ' TextBoxnmhwn
        ' 
        TextBoxnmhwn.Location = New Point(147, 53)
        TextBoxnmhwn.Name = "TextBoxnmhwn"
        TextBoxnmhwn.Size = New Size(311, 27)
        TextBoxnmhwn.TabIndex = 5
        ' 
        ' Labelkdhwn
        ' 
        Labelkdhwn.AutoSize = True
        Labelkdhwn.Location = New Point(25, 22)
        Labelkdhwn.Name = "Labelkdhwn"
        Labelkdhwn.Size = New Size(94, 20)
        Labelkdhwn.TabIndex = 6
        Labelkdhwn.Text = "Kode Hewan"
        ' 
        ' Labelnmhwn
        ' 
        Labelnmhwn.AutoSize = True
        Labelnmhwn.Location = New Point(25, 56)
        Labelnmhwn.Name = "Labelnmhwn"
        Labelnmhwn.Size = New Size(99, 20)
        Labelnmhwn.TabIndex = 7
        Labelnmhwn.Text = "Nama Hewan"
        ' 
        ' Labeljnshwn
        ' 
        Labeljnshwn.AutoSize = True
        Labeljnshwn.Location = New Point(25, 89)
        Labeljnshwn.Name = "Labeljnshwn"
        Labeljnshwn.Size = New Size(90, 20)
        Labeljnshwn.TabIndex = 8
        Labeljnshwn.Text = "Jenis Hewan"
        ' 
        ' labelsearch
        ' 
        labelsearch.AutoSize = True
        labelsearch.Location = New Point(25, 126)
        labelsearch.Name = "labelsearch"
        labelsearch.Size = New Size(85, 20)
        labelsearch.TabIndex = 9
        labelsearch.Text = "Cari Hewan"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Buttonsmpn
        ' 
        Buttonsmpn.Location = New Point(25, 191)
        Buttonsmpn.Name = "Buttonsmpn"
        Buttonsmpn.Size = New Size(94, 29)
        Buttonsmpn.TabIndex = 10
        Buttonsmpn.Text = "Simpan"
        Buttonsmpn.UseVisualStyleBackColor = True
        ' 
        ' Buttonubh
        ' 
        Buttonubh.Location = New Point(178, 191)
        Buttonubh.Name = "Buttonubh"
        Buttonubh.Size = New Size(94, 29)
        Buttonubh.TabIndex = 11
        Buttonubh.Text = "Ubah"
        Buttonubh.UseVisualStyleBackColor = True
        ' 
        ' Buttonhps
        ' 
        Buttonhps.Location = New Point(337, 191)
        Buttonhps.Name = "Buttonhps"
        Buttonhps.Size = New Size(94, 29)
        Buttonhps.TabIndex = 12
        Buttonhps.Text = "Hapus"
        Buttonhps.UseVisualStyleBackColor = True
        ' 
        ' Buttonbtl
        ' 
        Buttonbtl.Location = New Point(502, 191)
        Buttonbtl.Name = "Buttonbtl"
        Buttonbtl.Size = New Size(94, 29)
        Buttonbtl.TabIndex = 13
        Buttonbtl.Text = "Batal"
        Buttonbtl.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Linen
        ClientSize = New Size(666, 371)
        Controls.Add(Buttonbtl)
        Controls.Add(Buttonhps)
        Controls.Add(Buttonubh)
        Controls.Add(Buttonsmpn)
        Controls.Add(labelsearch)
        Controls.Add(Labeljnshwn)
        Controls.Add(Labelnmhwn)
        Controls.Add(Labelkdhwn)
        Controls.Add(TextBoxnmhwn)
        Controls.Add(TextBoxkode)
        Controls.Add(TextBoxjenis)
        Controls.Add(TextBoxcari)
        Controls.Add(DGVHewan)
        Controls.Add(PictureBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DGVHewan, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DGVHewan As DataGridView
    Friend WithEvents TextBoxcari As TextBox
    Friend WithEvents TextBoxjenis As TextBox
    Friend WithEvents TextBoxkode As TextBox
    Friend WithEvents TextBoxnmhwn As TextBox
    Friend WithEvents Labelkdhwn As Label
    Friend WithEvents Labelnmhwn As Label
    Friend WithEvents Labeljnshwn As Label
    Friend WithEvents labelsearch As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Buttonbtl As Button
    Friend WithEvents Buttonhps As Button
    Friend WithEvents Buttonubh As Button
    Friend WithEvents Buttonsmpn As Button

End Class
