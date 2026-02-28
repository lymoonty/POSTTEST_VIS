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
        txtIP = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        txtIPK = New TextBox()
        lblPredikat = New Label()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txtIP
        ' 
        txtIP.BackColor = SystemColors.InactiveCaption
        txtIP.ForeColor = SystemColors.InfoText
        txtIP.Location = New Point(261, 141)
        txtIP.Name = "txtIP"
        txtIP.Size = New Size(144, 27)
        txtIP.TabIndex = 0
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = SystemColors.Control
        btnTambah.Location = New Point(261, 191)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(70, 29)
        btnTambah.TabIndex = 1
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = SystemColors.Control
        btnReset.Location = New Point(337, 191)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(68, 29)
        btnReset.TabIndex = 2
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' txtIPK
        ' 
        txtIPK.BackColor = SystemColors.InactiveCaption
        txtIPK.Location = New Point(261, 234)
        txtIPK.Name = "txtIPK"
        txtIPK.Size = New Size(144, 27)
        txtIPK.TabIndex = 3
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(261, 277)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(15, 20)
        lblPredikat.TabIndex = 4
        lblPredikat.Text = "-"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(137, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 5
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(137, 237)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 6
        Label2.Text = "IP Kumulatif"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblPredikat)
        Controls.Add(txtIPK)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(txtIP)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "Form1"
        Text = "Kalkulator IP"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtIP As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents lblPredikat As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
