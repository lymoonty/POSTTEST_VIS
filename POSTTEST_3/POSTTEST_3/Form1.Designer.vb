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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PicBox = New PictureBox()
        Btn = New Button()
        textnm = New TextBox()
        Textum = New TextBox()
        Texttlp = New TextBox()
        TextAlmt = New TextBox()
        GroupBoxJK = New GroupBox()
        RadioButtonPR = New RadioButton()
        RadioButtonLK = New RadioButton()
        GroupBoxHB = New GroupBox()
        CheckBoxML = New CheckBox()
        CheckBoxGM = New CheckBox()
        CheckBoxTV = New CheckBox()
        CheckBoxNR = New CheckBox()
        CheckBoxMS = New CheckBox()
        CheckBoxNY = New CheckBox()
        CheckBoxHK = New CheckBox()
        CheckBoxRN = New CheckBox()
        CheckBoxNL = New CheckBox()
        CheckBoxBC = New CheckBox()
        DTPLahir = New DateTimePicker()
        Buttonctk = New Button()
        Labelnm = New Label()
        Labelum = New Label()
        LabelLahir = New Label()
        Labelhp = New Label()
        Labelalmt = New Label()
        CType(PicBox, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxJK.SuspendLayout()
        GroupBoxHB.SuspendLayout()
        SuspendLayout()
        ' 
        ' PicBox
        ' 
        PicBox.BorderStyle = BorderStyle.FixedSingle
        PicBox.Location = New Point(12, 12)
        PicBox.Name = "PicBox"
        PicBox.Size = New Size(264, 400)
        PicBox.SizeMode = PictureBoxSizeMode.StretchImage
        PicBox.TabIndex = 0
        PicBox.TabStop = False
        ' 
        ' Btn
        ' 
        Btn.BackColor = Color.AliceBlue
        Btn.Location = New Point(86, 418)
        Btn.Name = "Btn"
        Btn.Size = New Size(94, 29)
        Btn.TabIndex = 1
        Btn.Text = "Browse"
        Btn.UseVisualStyleBackColor = False
        ' 
        ' textnm
        ' 
        textnm.Location = New Point(396, 28)
        textnm.Name = "textnm"
        textnm.Size = New Size(250, 27)
        textnm.TabIndex = 2
        ' 
        ' Textum
        ' 
        Textum.Location = New Point(396, 61)
        Textum.Name = "Textum"
        Textum.Size = New Size(250, 27)
        Textum.TabIndex = 3
        ' 
        ' Texttlp
        ' 
        Texttlp.Location = New Point(395, 127)
        Texttlp.Name = "Texttlp"
        Texttlp.Size = New Size(250, 27)
        Texttlp.TabIndex = 4
        ' 
        ' TextAlmt
        ' 
        TextAlmt.Location = New Point(396, 160)
        TextAlmt.Multiline = True
        TextAlmt.Name = "TextAlmt"
        TextAlmt.Size = New Size(250, 34)
        TextAlmt.TabIndex = 5
        ' 
        ' GroupBoxJK
        ' 
        GroupBoxJK.Controls.Add(RadioButtonPR)
        GroupBoxJK.Controls.Add(RadioButtonLK)
        GroupBoxJK.ForeColor = SystemColors.Desktop
        GroupBoxJK.Location = New Point(282, 251)
        GroupBoxJK.Name = "GroupBoxJK"
        GroupBoxJK.Size = New Size(250, 161)
        GroupBoxJK.TabIndex = 6
        GroupBoxJK.TabStop = False
        GroupBoxJK.Text = "Jenis Kelamin"
        ' 
        ' RadioButtonPR
        ' 
        RadioButtonPR.AutoSize = True
        RadioButtonPR.Location = New Point(14, 84)
        RadioButtonPR.Name = "RadioButtonPR"
        RadioButtonPR.Size = New Size(104, 24)
        RadioButtonPR.TabIndex = 1
        RadioButtonPR.TabStop = True
        RadioButtonPR.Text = "Perempuan"
        RadioButtonPR.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonLK
        ' 
        RadioButtonLK.AutoSize = True
        RadioButtonLK.Location = New Point(14, 45)
        RadioButtonLK.Name = "RadioButtonLK"
        RadioButtonLK.Size = New Size(88, 24)
        RadioButtonLK.TabIndex = 0
        RadioButtonLK.TabStop = True
        RadioButtonLK.Text = "Laki-Laki"
        RadioButtonLK.UseVisualStyleBackColor = True
        ' 
        ' GroupBoxHB
        ' 
        GroupBoxHB.BackColor = Color.AliceBlue
        GroupBoxHB.Controls.Add(CheckBoxML)
        GroupBoxHB.Controls.Add(CheckBoxGM)
        GroupBoxHB.Controls.Add(CheckBoxTV)
        GroupBoxHB.Controls.Add(CheckBoxNR)
        GroupBoxHB.Controls.Add(CheckBoxMS)
        GroupBoxHB.Controls.Add(CheckBoxNY)
        GroupBoxHB.Controls.Add(CheckBoxHK)
        GroupBoxHB.Controls.Add(CheckBoxRN)
        GroupBoxHB.Controls.Add(CheckBoxNL)
        GroupBoxHB.Controls.Add(CheckBoxBC)
        GroupBoxHB.Location = New Point(538, 251)
        GroupBoxHB.Name = "GroupBoxHB"
        GroupBoxHB.Size = New Size(250, 161)
        GroupBoxHB.TabIndex = 0
        GroupBoxHB.TabStop = False
        GroupBoxHB.Text = "Hobby"
        ' 
        ' CheckBoxML
        ' 
        CheckBoxML.AutoSize = True
        CheckBoxML.Location = New Point(120, 125)
        CheckBoxML.Name = "CheckBoxML"
        CheckBoxML.Size = New Size(81, 24)
        CheckBoxML.TabIndex = 9
        CheckBoxML.Text = "Melukis"
        CheckBoxML.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxGM
        ' 
        CheckBoxGM.AutoSize = True
        CheckBoxGM.Location = New Point(120, 100)
        CheckBoxGM.Name = "CheckBoxGM"
        CheckBoxGM.Size = New Size(83, 24)
        CheckBoxGM.TabIndex = 8
        CheckBoxGM.Text = "Gaming"
        CheckBoxGM.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxTV
        ' 
        CheckBoxTV.AutoSize = True
        CheckBoxTV.Location = New Point(120, 76)
        CheckBoxTV.Name = "CheckBoxTV"
        CheckBoxTV.Size = New Size(91, 24)
        CheckBoxTV.TabIndex = 7
        CheckBoxTV.Text = "Traveling"
        CheckBoxTV.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxNR
        ' 
        CheckBoxNR.AutoSize = True
        CheckBoxNR.Location = New Point(120, 52)
        CheckBoxNR.Name = "CheckBoxNR"
        CheckBoxNR.Size = New Size(77, 24)
        CheckBoxNR.TabIndex = 6
        CheckBoxNR.Text = "Menari"
        CheckBoxNR.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxMS
        ' 
        CheckBoxMS.AutoSize = True
        CheckBoxMS.Location = New Point(120, 26)
        CheckBoxMS.Name = "CheckBoxMS"
        CheckBoxMS.Size = New Size(94, 24)
        CheckBoxMS.TabIndex = 5
        CheckBoxMS.Text = "Memasak"
        CheckBoxMS.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxNY
        ' 
        CheckBoxNY.AutoSize = True
        CheckBoxNY.Location = New Point(10, 125)
        CheckBoxNY.Name = "CheckBoxNY"
        CheckBoxNY.Size = New Size(94, 24)
        CheckBoxNY.TabIndex = 4
        CheckBoxNY.Text = "Menyanyi"
        CheckBoxNY.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxHK
        ' 
        CheckBoxHK.AutoSize = True
        CheckBoxHK.Location = New Point(10, 100)
        CheckBoxHK.Name = "CheckBoxHK"
        CheckBoxHK.Size = New Size(74, 24)
        CheckBoxHK.TabIndex = 3
        CheckBoxHK.Text = "Hiking"
        CheckBoxHK.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxRN
        ' 
        CheckBoxRN.AutoSize = True
        CheckBoxRN.Location = New Point(10, 76)
        CheckBoxRN.Name = "CheckBoxRN"
        CheckBoxRN.Size = New Size(94, 24)
        CheckBoxRN.TabIndex = 2
        CheckBoxRN.Text = "Berenang"
        CheckBoxRN.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxNL
        ' 
        CheckBoxNL.AutoSize = True
        CheckBoxNL.Location = New Point(10, 52)
        CheckBoxNL.Name = "CheckBoxNL"
        CheckBoxNL.Size = New Size(82, 24)
        CheckBoxNL.TabIndex = 1
        CheckBoxNL.Text = "Menulis"
        CheckBoxNL.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxBC
        ' 
        CheckBoxBC.AutoSize = True
        CheckBoxBC.Location = New Point(10, 26)
        CheckBoxBC.Name = "CheckBoxBC"
        CheckBoxBC.Size = New Size(97, 24)
        CheckBoxBC.TabIndex = 0
        CheckBoxBC.Text = "Membaca"
        CheckBoxBC.UseVisualStyleBackColor = True
        ' 
        ' DTPLahir
        ' 
        DTPLahir.Format = DateTimePickerFormat.Short
        DTPLahir.Location = New Point(396, 94)
        DTPLahir.Name = "DTPLahir"
        DTPLahir.Size = New Size(250, 27)
        DTPLahir.TabIndex = 2
        ' 
        ' Buttonctk
        ' 
        Buttonctk.BackColor = Color.AliceBlue
        Buttonctk.Location = New Point(282, 418)
        Buttonctk.Name = "Buttonctk"
        Buttonctk.Size = New Size(506, 29)
        Buttonctk.TabIndex = 7
        Buttonctk.Text = "Cetak kartu"
        Buttonctk.UseVisualStyleBackColor = False
        ' 
        ' Labelnm
        ' 
        Labelnm.AutoSize = True
        Labelnm.BackColor = Color.Transparent
        Labelnm.Location = New Point(296, 31)
        Labelnm.Name = "Labelnm"
        Labelnm.Size = New Size(49, 20)
        Labelnm.TabIndex = 8
        Labelnm.Text = "Nama"
        ' 
        ' Labelum
        ' 
        Labelum.AutoSize = True
        Labelum.BackColor = Color.Transparent
        Labelum.Location = New Point(296, 64)
        Labelum.Name = "Labelum"
        Labelum.Size = New Size(45, 20)
        Labelum.TabIndex = 9
        Labelum.Text = "Umur"
        ' 
        ' LabelLahir
        ' 
        LabelLahir.AutoSize = True
        LabelLahir.BackColor = Color.Transparent
        LabelLahir.Location = New Point(296, 99)
        LabelLahir.Name = "LabelLahir"
        LabelLahir.Size = New Size(94, 20)
        LabelLahir.TabIndex = 10
        LabelLahir.Text = "Tanggal lahir"
        ' 
        ' Labelhp
        ' 
        Labelhp.AutoSize = True
        Labelhp.BackColor = Color.Transparent
        Labelhp.Location = New Point(296, 130)
        Labelhp.Name = "Labelhp"
        Labelhp.Size = New Size(52, 20)
        Labelhp.TabIndex = 11
        Labelhp.Text = "No HP"
        ' 
        ' Labelalmt
        ' 
        Labelalmt.AutoSize = True
        Labelalmt.BackColor = Color.Transparent
        Labelalmt.Location = New Point(296, 174)
        Labelalmt.Name = "Labelalmt"
        Labelalmt.Size = New Size(57, 20)
        Labelalmt.TabIndex = 12
        Labelalmt.Text = "Alamat"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Labelalmt)
        Controls.Add(Labelhp)
        Controls.Add(LabelLahir)
        Controls.Add(Labelum)
        Controls.Add(Labelnm)
        Controls.Add(Buttonctk)
        Controls.Add(DTPLahir)
        Controls.Add(GroupBoxHB)
        Controls.Add(GroupBoxJK)
        Controls.Add(TextAlmt)
        Controls.Add(Texttlp)
        Controls.Add(Textum)
        Controls.Add(textnm)
        Controls.Add(Btn)
        Controls.Add(PicBox)
        Name = "Form1"
        Text = "Form1"
        CType(PicBox, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxJK.ResumeLayout(False)
        GroupBoxJK.PerformLayout()
        GroupBoxHB.ResumeLayout(False)
        GroupBoxHB.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PicBox As PictureBox
    Friend WithEvents Btn As Button
    Friend WithEvents textnm As TextBox
    Friend WithEvents Textum As TextBox
    Friend WithEvents Texttlp As TextBox
    Friend WithEvents TextAlmt As TextBox
    Friend WithEvents GroupBoxJK As GroupBox
    Friend WithEvents GroupBoxHB As GroupBox
    Friend WithEvents RadioButtonPR As RadioButton
    Friend WithEvents RadioButtonLK As RadioButton
    Friend WithEvents CheckBoxML As CheckBox
    Friend WithEvents CheckBoxGM As CheckBox
    Friend WithEvents CheckBoxTV As CheckBox
    Friend WithEvents CheckBoxNR As CheckBox
    Friend WithEvents CheckBoxMS As CheckBox
    Friend WithEvents CheckBoxNY As CheckBox
    Friend WithEvents CheckBoxHK As CheckBox
    Friend WithEvents CheckBoxRN As CheckBox
    Friend WithEvents CheckBoxNL As CheckBox
    Friend WithEvents CheckBoxBC As CheckBox
    Friend WithEvents DTPLahir As DateTimePicker
    Friend WithEvents Buttonctk As Button
    Friend WithEvents Labelnm As Label
    Friend WithEvents Labelum As Label
    Friend WithEvents LabelLahir As Label
    Friend WithEvents Labelhp As Label
    Friend WithEvents Labelalmt As Label

End Class
