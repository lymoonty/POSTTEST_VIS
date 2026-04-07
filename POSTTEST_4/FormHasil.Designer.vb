<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormHasil
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
        PictureBox1 = New PictureBox()
        Labelnm = New Label()
        LabelID = New Label()
        Labelkmntas = New Label()
        Labelkntk = New Label()
        Labelhobby = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Location = New Point(100, 139)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(120, 150)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Labelnm
        ' 
        Labelnm.AutoSize = True
        Labelnm.BackColor = Color.Transparent
        Labelnm.Font = New Font("Segoe UI", 13.8F)
        Labelnm.ForeColor = SystemColors.ActiveCaptionText
        Labelnm.Location = New Point(261, 139)
        Labelnm.Name = "Labelnm"
        Labelnm.Size = New Size(75, 31)
        Labelnm.TabIndex = 1
        Labelnm.Text = "Nama"
        ' 
        ' LabelID
        ' 
        LabelID.AutoSize = True
        LabelID.BackColor = Color.Transparent
        LabelID.Font = New Font("Segoe UI", 13.8F)
        LabelID.ForeColor = SystemColors.ActiveCaptionText
        LabelID.Location = New Point(261, 170)
        LabelID.Name = "LabelID"
        LabelID.Size = New Size(36, 31)
        LabelID.TabIndex = 2
        LabelID.Text = "ID"
        ' 
        ' Labelkmntas
        ' 
        Labelkmntas.AutoSize = True
        Labelkmntas.BackColor = Color.Transparent
        Labelkmntas.Font = New Font("Segoe UI", 13.8F)
        Labelkmntas.ForeColor = SystemColors.ActiveCaptionText
        Labelkmntas.Location = New Point(261, 201)
        Labelkmntas.Name = "Labelkmntas"
        Labelkmntas.Size = New Size(121, 31)
        Labelkmntas.TabIndex = 3
        Labelkmntas.Text = "Komunitas"
        ' 
        ' Labelkntk
        ' 
        Labelkntk.AutoSize = True
        Labelkntk.BackColor = Color.Transparent
        Labelkntk.Font = New Font("Segoe UI", 13.8F)
        Labelkntk.ForeColor = SystemColors.ActiveCaptionText
        Labelkntk.Location = New Point(261, 232)
        Labelkntk.Name = "Labelkntk"
        Labelkntk.Size = New Size(83, 31)
        Labelkntk.TabIndex = 4
        Labelkntk.Text = "Kontak"
        ' 
        ' Labelhobby
        ' 
        Labelhobby.AutoSize = True
        Labelhobby.BackColor = Color.Transparent
        Labelhobby.Font = New Font("Segoe UI", 13.8F)
        Labelhobby.ForeColor = SystemColors.ActiveCaptionText
        Labelhobby.Location = New Point(261, 263)
        Labelhobby.Name = "Labelhobby"
        Labelhobby.Size = New Size(178, 31)
        Labelhobby.TabIndex = 5
        Labelhobby.Text = "Hobby/Aktivitas"
        ' 
        ' FormHasil
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        BackgroundImage = My.Resources.Resources.download__5___3_
        ClientSize = New Size(803, 450)
        Controls.Add(Labelhobby)
        Controls.Add(Labelkntk)
        Controls.Add(Labelkmntas)
        Controls.Add(LabelID)
        Controls.Add(Labelnm)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Name = "FormHasil"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Hasil"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Labelnm As Label
    Friend WithEvents LabelID As Label
    Friend WithEvents Labelkmntas As Label
    Friend WithEvents Labelkntk As Label
    Friend WithEvents Labelhobby As Label
End Class
