<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUtama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUtama))
        MenuStrip1 = New MenuStrip()
        SimpanDataToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        BukaDataToolStripMenuItem1 = New ToolStripMenuItem()
        KeluarToolStripMenuItem1 = New ToolStripMenuItem()
        Lblgtw = New Label()
        PictureBox1 = New PictureBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        RadioButtonlk = New RadioButton()
        ComboBoxdvsi = New ComboBox()
        RadioButtonpr = New RadioButton()
        DateTimePickerlahir = New DateTimePicker()
        TxtID = New TextBox()
        Txtnama = New TextBox()
        TabPage2 = New TabPage()
        PictureBox7 = New PictureBox()
        MaskedTextBoxtlp = New MaskedTextBox()
        TextBoxalmt = New TextBox()
        TextBoxemail = New TextBox()
        TabPage3 = New TabPage()
        GBhobby = New GroupBox()
        CheckBox9 = New CheckBox()
        CheckBox10 = New CheckBox()
        CheckBox11 = New CheckBox()
        CheckBox12 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox7 = New CheckBox()
        GroupBoxpern = New GroupBox()
        Cbketua = New CheckBox()
        CbRL = New CheckBox()
        Cbadmin = New CheckBox()
        Cbanggota = New CheckBox()
        Buttonsmpn = New Button()
        Buttonbrwsr = New Button()
        PictureBoxpoto = New PictureBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        ErrorProvider1 = New ErrorProvider(components)
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        TabPage2.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        GBhobby.SuspendLayout()
        GroupBoxpern.SuspendLayout()
        CType(PictureBoxpoto, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {SimpanDataToolStripMenuItem, BukaDataToolStripMenuItem, KeluarToolStripMenuItem, BukaDataToolStripMenuItem1, KeluarToolStripMenuItem1})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(803, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' SimpanDataToolStripMenuItem
        ' 
        SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        SimpanDataToolStripMenuItem.Size = New Size(93, 24)
        SimpanDataToolStripMenuItem.Text = "Input Data"
        ' 
        ' BukaDataToolStripMenuItem
        ' 
        BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        BukaDataToolStripMenuItem.Size = New Size(94, 24)
        BukaDataToolStripMenuItem.Text = "Lihat Kartu"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(109, 24)
        KeluarToolStripMenuItem.Text = "Simpan Data"
        ' 
        ' BukaDataToolStripMenuItem1
        ' 
        BukaDataToolStripMenuItem1.Name = "BukaDataToolStripMenuItem1"
        BukaDataToolStripMenuItem1.Size = New Size(91, 24)
        BukaDataToolStripMenuItem1.Text = "Buka Data"
        ' 
        ' KeluarToolStripMenuItem1
        ' 
        KeluarToolStripMenuItem1.Name = "KeluarToolStripMenuItem1"
        KeluarToolStripMenuItem1.Size = New Size(65, 24)
        KeluarToolStripMenuItem1.Text = "Keluar"
        ' 
        ' Lblgtw
        ' 
        Lblgtw.AutoSize = True
        Lblgtw.Font = New Font("Segoe UI Emoji", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Lblgtw.ForeColor = SystemColors.ControlLightLight
        Lblgtw.Location = New Point(151, 41)
        Lblgtw.Name = "Lblgtw"
        Lblgtw.Size = New Size(538, 49)
        Lblgtw.TabIndex = 1
        Lblgtw.Text = "KOMUNITAS ANIMAL LOVERS" & vbCrLf
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(315, 106)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(202, 137)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Location = New Point(0, 249)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(804, 409)
        TabControl1.TabIndex = 3
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.LightSteelBlue
        TabPage1.Controls.Add(PictureBox6)
        TabPage1.Controls.Add(PictureBox5)
        TabPage1.Controls.Add(PictureBox4)
        TabPage1.Controls.Add(PictureBox3)
        TabPage1.Controls.Add(RadioButtonlk)
        TabPage1.Controls.Add(ComboBoxdvsi)
        TabPage1.Controls.Add(RadioButtonpr)
        TabPage1.Controls.Add(DateTimePickerlahir)
        TabPage1.Controls.Add(TxtID)
        TabPage1.Controls.Add(Txtnama)
        TabPage1.ForeColor = SystemColors.ControlText
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(796, 376)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Data Utama"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.download__3___1_
        PictureBox6.Location = New Point(198, 193)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(200, 189)
        PictureBox6.TabIndex = 9
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.download__4___1_
        PictureBox5.Location = New Point(395, 193)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(202, 183)
        PictureBox5.TabIndex = 8
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.download__2_
        PictureBox4.Location = New Point(594, 193)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(200, 193)
        PictureBox4.TabIndex = 7
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.download__1___1_
        PictureBox3.Location = New Point(0, 193)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(201, 187)
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' RadioButtonlk
        ' 
        RadioButtonlk.AutoSize = True
        RadioButtonlk.Location = New Point(185, 140)
        RadioButtonlk.Name = "RadioButtonlk"
        RadioButtonlk.Size = New Size(88, 24)
        RadioButtonlk.TabIndex = 5
        RadioButtonlk.TabStop = True
        RadioButtonlk.Text = "Laki-Laki"
        RadioButtonlk.UseVisualStyleBackColor = True
        ' 
        ' ComboBoxdvsi
        ' 
        ComboBoxdvsi.FormattingEnabled = True
        ComboBoxdvsi.Items.AddRange(New Object() {"Divisi Edukasi & Sosialisasi", "Divisi Rescue & Rehabilitasi", "Divisi Konservasi Habitat", "Divisi Dokumentasi & Media", "Divisi Breeding & Care", "Divisi Umum & Logistik"})
        ComboBoxdvsi.Location = New Point(432, 88)
        ComboBoxdvsi.Name = "ComboBoxdvsi"
        ComboBoxdvsi.Size = New Size(351, 28)
        ComboBoxdvsi.TabIndex = 4
        ' 
        ' RadioButtonpr
        ' 
        RadioButtonpr.AutoSize = True
        RadioButtonpr.Location = New Point(35, 140)
        RadioButtonpr.Name = "RadioButtonpr"
        RadioButtonpr.Size = New Size(104, 24)
        RadioButtonpr.TabIndex = 3
        RadioButtonpr.TabStop = True
        RadioButtonpr.Text = "Perempuan"
        RadioButtonpr.UseVisualStyleBackColor = True
        ' 
        ' DateTimePickerlahir
        ' 
        DateTimePickerlahir.Location = New Point(432, 55)
        DateTimePickerlahir.Name = "DateTimePickerlahir"
        DateTimePickerlahir.Size = New Size(351, 27)
        DateTimePickerlahir.TabIndex = 2
        ' 
        ' TxtID
        ' 
        TxtID.Location = New Point(35, 88)
        TxtID.Name = "TxtID"
        TxtID.Size = New Size(351, 27)
        TxtID.TabIndex = 1
        TxtID.Text = "ID Anggota"
        ' 
        ' Txtnama
        ' 
        Txtnama.Location = New Point(35, 55)
        Txtnama.Name = "Txtnama"
        Txtnama.Size = New Size(351, 27)
        Txtnama.TabIndex = 0
        Txtnama.Text = "Nama"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.LightSteelBlue
        TabPage2.Controls.Add(PictureBox7)
        TabPage2.Controls.Add(MaskedTextBoxtlp)
        TabPage2.Controls.Add(TextBoxalmt)
        TabPage2.Controls.Add(TextBoxemail)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(796, 376)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kontak & Info"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(516, 29)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(283, 351)
        PictureBox7.TabIndex = 4
        PictureBox7.TabStop = False
        ' 
        ' MaskedTextBoxtlp
        ' 
        MaskedTextBoxtlp.Location = New Point(24, 240)
        MaskedTextBoxtlp.Mask = "0000-0000-0000"
        MaskedTextBoxtlp.Name = "MaskedTextBoxtlp"
        MaskedTextBoxtlp.Size = New Size(391, 27)
        MaskedTextBoxtlp.TabIndex = 3
        ' 
        ' TextBoxalmt
        ' 
        TextBoxalmt.Location = New Point(24, 125)
        TextBoxalmt.Multiline = True
        TextBoxalmt.Name = "TextBoxalmt"
        TextBoxalmt.Size = New Size(391, 27)
        TextBoxalmt.TabIndex = 2
        TextBoxalmt.Text = "Alamat"
        ' 
        ' TextBoxemail
        ' 
        TextBoxemail.Location = New Point(24, 182)
        TextBoxemail.Name = "TextBoxemail"
        TextBoxemail.Size = New Size(391, 27)
        TextBoxemail.TabIndex = 1
        TextBoxemail.Text = "Email"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.LightSteelBlue
        TabPage3.Controls.Add(GBhobby)
        TabPage3.Controls.Add(GroupBoxpern)
        TabPage3.Controls.Add(Buttonsmpn)
        TabPage3.Controls.Add(Buttonbrwsr)
        TabPage3.Controls.Add(PictureBoxpoto)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(796, 376)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Profil & Aktivitas"
        ' 
        ' GBhobby
        ' 
        GBhobby.Controls.Add(CheckBox9)
        GBhobby.Controls.Add(CheckBox10)
        GBhobby.Controls.Add(CheckBox11)
        GBhobby.Controls.Add(CheckBox12)
        GBhobby.Controls.Add(CheckBox5)
        GBhobby.Controls.Add(CheckBox8)
        GBhobby.Controls.Add(CheckBox6)
        GBhobby.Controls.Add(CheckBox7)
        GBhobby.Location = New Point(436, 146)
        GBhobby.Name = "GBhobby"
        GBhobby.Size = New Size(319, 142)
        GBhobby.TabIndex = 4
        GBhobby.TabStop = False
        GBhobby.Text = "Hobby/Aktivitas"
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(142, 26)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(127, 24)
        CheckBox9.TabIndex = 5
        CheckBox9.Text = "Street Feeding"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(142, 52)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(166, 24)
        CheckBox10.TabIndex = 6
        CheckBox10.Text = "DIY Aksesoris hewan"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox11
        ' 
        CheckBox11.AutoSize = True
        CheckBox11.Location = New Point(142, 82)
        CheckBox11.Name = "CheckBox11"
        CheckBox11.Size = New Size(107, 24)
        CheckBox11.TabIndex = 7
        CheckBox11.Text = "Fundraising"
        CheckBox11.UseVisualStyleBackColor = True
        ' 
        ' CheckBox12
        ' 
        CheckBox12.AutoSize = True
        CheckBox12.Location = New Point(142, 112)
        CheckBox12.Name = "CheckBox12"
        CheckBox12.Size = New Size(128, 24)
        CheckBox12.TabIndex = 8
        CheckBox12.Text = "Adopsi Hewan"
        CheckBox12.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(6, 26)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(92, 24)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "Fotografi"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(6, 112)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(91, 24)
        CheckBox8.TabIndex = 7
        CheckBox8.Text = "Traveling"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(6, 56)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(109, 24)
        CheckBox6.TabIndex = 5
        CheckBox6.Text = "Memancing"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(6, 86)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(134, 24)
        CheckBox7.TabIndex = 6
        CheckBox7.Text = "Training Hewan"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' GroupBoxpern
        ' 
        GroupBoxpern.Controls.Add(Cbketua)
        GroupBoxpern.Controls.Add(CbRL)
        GroupBoxpern.Controls.Add(Cbadmin)
        GroupBoxpern.Controls.Add(Cbanggota)
        GroupBoxpern.Location = New Point(435, 20)
        GroupBoxpern.Name = "GroupBoxpern"
        GroupBoxpern.Size = New Size(320, 108)
        GroupBoxpern.TabIndex = 1
        GroupBoxpern.TabStop = False
        GroupBoxpern.Text = "Peran"
        ' 
        ' Cbketua
        ' 
        Cbketua.AutoSize = True
        Cbketua.Location = New Point(19, 40)
        Cbketua.Name = "Cbketua"
        Cbketua.Size = New Size(69, 24)
        Cbketua.TabIndex = 0
        Cbketua.Text = "Ketua"
        Cbketua.UseVisualStyleBackColor = True
        ' 
        ' CbRL
        ' 
        CbRL.AutoSize = True
        CbRL.Location = New Point(138, 70)
        CbRL.Name = "CbRL"
        CbRL.Size = New Size(156, 24)
        CbRL.TabIndex = 3
        CbRL.Text = "Relawan Lapangan"
        CbRL.UseVisualStyleBackColor = True
        ' 
        ' Cbadmin
        ' 
        Cbadmin.AutoSize = True
        Cbadmin.Location = New Point(138, 40)
        Cbadmin.Name = "Cbadmin"
        Cbadmin.Size = New Size(130, 24)
        Cbadmin.TabIndex = 2
        Cbadmin.Text = "Admin Medsos"
        Cbadmin.UseVisualStyleBackColor = True
        ' 
        ' Cbanggota
        ' 
        Cbanggota.AutoSize = True
        Cbanggota.Location = New Point(19, 70)
        Cbanggota.Name = "Cbanggota"
        Cbanggota.Size = New Size(89, 24)
        Cbanggota.TabIndex = 1
        Cbanggota.Text = "Anggota"
        Cbanggota.UseVisualStyleBackColor = True
        ' 
        ' Buttonsmpn
        ' 
        Buttonsmpn.Location = New Point(498, 321)
        Buttonsmpn.Name = "Buttonsmpn"
        Buttonsmpn.Size = New Size(170, 29)
        Buttonsmpn.TabIndex = 2
        Buttonsmpn.Text = "Simpan dan Cetak Kartu"
        Buttonsmpn.UseVisualStyleBackColor = True
        ' 
        ' Buttonbrwsr
        ' 
        Buttonbrwsr.Location = New Point(20, 321)
        Buttonbrwsr.Name = "Buttonbrwsr"
        Buttonbrwsr.Size = New Size(170, 29)
        Buttonbrwsr.TabIndex = 1
        Buttonbrwsr.Text = "Browse"
        Buttonbrwsr.UseVisualStyleBackColor = True
        ' 
        ' PictureBoxpoto
        ' 
        PictureBoxpoto.BorderStyle = BorderStyle.FixedSingle
        PictureBoxpoto.Location = New Point(20, 73)
        PictureBoxpoto.Name = "PictureBoxpoto"
        PictureBoxpoto.Size = New Size(228, 149)
        PictureBoxpoto.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxpoto.TabIndex = 0
        PictureBoxpoto.TabStop = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' FormUtama
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSlateGray
        ClientSize = New Size(803, 658)
        Controls.Add(TabControl1)
        Controls.Add(PictureBox1)
        Controls.Add(Lblgtw)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        GBhobby.ResumeLayout(False)
        GBhobby.PerformLayout()
        GroupBoxpern.ResumeLayout(False)
        GroupBoxpern.PerformLayout()
        CType(PictureBoxpoto, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Lblgtw As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ComboBoxdvsi As ComboBox
    Friend WithEvents RadioButtonpr As RadioButton
    Friend WithEvents DateTimePickerlahir As DateTimePicker
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Txtnama As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBoxalmt As TextBox
    Friend WithEvents TextBoxemail As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents GroupBoxpern As GroupBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CbRL As CheckBox
    Friend WithEvents Cbadmin As CheckBox
    Friend WithEvents Cbanggota As CheckBox
    Friend WithEvents Cbketua As CheckBox
    Friend WithEvents Buttonsmpn As Button
    Friend WithEvents Buttonbrwsr As Button
    Friend WithEvents PictureBoxpoto As PictureBox
    Friend WithEvents RadioButtonlk As RadioButton
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents MaskedTextBoxtlp As MaskedTextBox
    Friend WithEvents GBhobby As GroupBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
