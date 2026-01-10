<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard_Absen
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
        Panel2 = New Panel()
        btn_Catat = New Button()
        btn_clear = New Button()
        btn_save = New Button()
        btn_Riwayat = New Button()
        Label1 = New Label()
        text_kelas = New TextBox()
        btn_Search = New Button()
        show_waktuTanggal = New DateTimePicker()
        box_matkuliah = New ComboBox()
        box_kehadiran = New ComboBox()
        Label8 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        text_NamaMahasiswa = New TextBox()
        Label4 = New Label()
        text_NIM = New TextBox()
        Label3 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        ImageList1 = New ImageList(components)
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.AutoSize = True
        Panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel2.BackColor = Color.LightGray
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(btn_Catat)
        Panel2.Controls.Add(btn_clear)
        Panel2.Controls.Add(btn_save)
        Panel2.Controls.Add(btn_Riwayat)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(text_kelas)
        Panel2.Controls.Add(btn_Search)
        Panel2.Controls.Add(show_waktuTanggal)
        Panel2.Controls.Add(box_matkuliah)
        Panel2.Controls.Add(box_kehadiran)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(text_NamaMahasiswa)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(text_NIM)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label2)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(2, 2)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(2)
        Panel2.Size = New Size(837, 618)
        Panel2.TabIndex = 19
        ' 
        ' btn_Catat
        ' 
        btn_Catat.BackColor = SystemColors.ActiveCaption
        btn_Catat.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Catat.Location = New Point(17, 94)
        btn_Catat.Margin = New Padding(2)
        btn_Catat.Name = "btn_Catat"
        btn_Catat.Size = New Size(222, 32)
        btn_Catat.TabIndex = 11
        btn_Catat.Text = "Catat Absensi"
        btn_Catat.UseVisualStyleBackColor = False
        ' 
        ' btn_clear
        ' 
        btn_clear.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btn_clear.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_clear.ForeColor = SystemColors.ButtonHighlight
        btn_clear.Location = New Point(17, 545)
        btn_clear.Margin = New Padding(2)
        btn_clear.Name = "btn_clear"
        btn_clear.Size = New Size(106, 33)
        btn_clear.TabIndex = 29
        btn_clear.Text = "Batal"
        btn_clear.UseVisualStyleBackColor = False
        ' 
        ' btn_save
        ' 
        btn_save.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btn_save.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_save.ForeColor = SystemColors.ButtonHighlight
        btn_save.Location = New Point(152, 545)
        btn_save.Margin = New Padding(2)
        btn_save.Name = "btn_save"
        btn_save.Size = New Size(106, 33)
        btn_save.TabIndex = 30
        btn_save.Text = "Simpan"
        btn_save.UseVisualStyleBackColor = False
        ' 
        ' btn_Riwayat
        ' 
        btn_Riwayat.BackColor = Color.CadetBlue
        btn_Riwayat.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_Riwayat.Location = New Point(264, 94)
        btn_Riwayat.Margin = New Padding(2)
        btn_Riwayat.Name = "btn_Riwayat"
        btn_Riwayat.Size = New Size(222, 32)
        btn_Riwayat.TabIndex = 17
        btn_Riwayat.Text = "Riwayat Absensi"
        btn_Riwayat.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(356, 22)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(196, 45)
        Label1.TabIndex = 0
        Label1.Text = "Pakai Kode"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' text_kelas
        ' 
        text_kelas.BackColor = SystemColors.ButtonHighlight
        text_kelas.Font = New Font("Segoe UI", 12F)
        text_kelas.Location = New Point(17, 356)
        text_kelas.Margin = New Padding(2)
        text_kelas.Name = "text_kelas"
        text_kelas.ReadOnly = True
        text_kelas.Size = New Size(311, 29)
        text_kelas.TabIndex = 36
        ' 
        ' btn_Search
        ' 
        btn_Search.BackgroundImage = My.Resources.Resources.resize
        btn_Search.BackgroundImageLayout = ImageLayout.Stretch
        btn_Search.Location = New Point(332, 214)
        btn_Search.Margin = New Padding(2)
        btn_Search.Name = "btn_Search"
        btn_Search.Size = New Size(32, 30)
        btn_Search.TabIndex = 35
        btn_Search.UseVisualStyleBackColor = True
        ' 
        ' show_waktuTanggal
        ' 
        show_waktuTanggal.Anchor = AnchorStyles.Right
        show_waktuTanggal.Enabled = False
        show_waktuTanggal.Location = New Point(591, 81)
        show_waktuTanggal.Margin = New Padding(2)
        show_waktuTanggal.Name = "show_waktuTanggal"
        show_waktuTanggal.Size = New Size(244, 23)
        show_waktuTanggal.TabIndex = 31
        show_waktuTanggal.Value = New Date(2025, 11, 22, 15, 5, 22, 0)
        ' 
        ' box_matkuliah
        ' 
        box_matkuliah.DropDownWidth = 442
        box_matkuliah.Font = New Font("Segoe UI", 12F)
        box_matkuliah.FormattingEnabled = True
        box_matkuliah.Items.AddRange(New Object() {"Perancangan Sistem Informasi", "Agama", "Pemograman Visual (Desktop)", "Big Data", "Manajemen Basis Data", "Sistem Informasi", "Kriptografi", "Sistem Pendukung Keputusan"})
        box_matkuliah.Location = New Point(17, 425)
        box_matkuliah.Margin = New Padding(2)
        box_matkuliah.Name = "box_matkuliah"
        box_matkuliah.Size = New Size(311, 29)
        box_matkuliah.TabIndex = 34
        ' 
        ' box_kehadiran
        ' 
        box_kehadiran.Font = New Font("Segoe UI", 12F)
        box_kehadiran.FormattingEnabled = True
        box_kehadiran.Items.AddRange(New Object() {"Hadir", "Izin", "Sakit", "Alpa"})
        box_kehadiran.Location = New Point(17, 506)
        box_kehadiran.Margin = New Padding(2)
        box_kehadiran.Name = "box_kehadiran"
        box_kehadiran.Size = New Size(311, 29)
        box_kehadiran.TabIndex = 32
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label8.Location = New Point(18, 480)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(162, 25)
        Label8.TabIndex = 27
        Label8.Text = "Status Kehadiran"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label5.Location = New Point(18, 399)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(117, 25)
        Label5.TabIndex = 25
        Label5.Text = "Mata Kuliah"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label7.Location = New Point(18, 333)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 25)
        Label7.TabIndex = 23
        Label7.Text = "Kelas"
        ' 
        ' text_NamaMahasiswa
        ' 
        text_NamaMahasiswa.BackColor = SystemColors.ButtonHighlight
        text_NamaMahasiswa.Font = New Font("Segoe UI", 12F)
        text_NamaMahasiswa.Location = New Point(17, 281)
        text_NamaMahasiswa.Margin = New Padding(2)
        text_NamaMahasiswa.Name = "text_NamaMahasiswa"
        text_NamaMahasiswa.ReadOnly = True
        text_NamaMahasiswa.Size = New Size(311, 29)
        text_NamaMahasiswa.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label4.Location = New Point(18, 255)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(164, 25)
        Label4.TabIndex = 21
        Label4.Text = "Nama Mahasiswa"
        ' 
        ' text_NIM
        ' 
        text_NIM.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        text_NIM.Location = New Point(17, 215)
        text_NIM.Margin = New Padding(2)
        text_NIM.Name = "text_NIM"
        text_NIM.Size = New Size(311, 29)
        text_NIM.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(18, 192)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 25)
        Label3.TabIndex = 19
        Label3.Text = "NIM"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(17, 139)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(300, 32)
        Label6.TabIndex = 18
        Label6.Text = "Form Absensi Mahasiswa"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(21, 171)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 21)
        Label2.TabIndex = 1
        Label2.Text = "Silahkan Lakukan Absen "
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' dashboard_Absen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.Control
        ClientSize = New Size(841, 622)
        Controls.Add(Panel2)
        Margin = New Padding(2)
        Name = "dashboard_Absen"
        Padding = New Padding(2)
        StartPosition = FormStartPosition.CenterScreen
        Text = " "
        WindowState = FormWindowState.Maximized
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Catat As Button
    Friend WithEvents btn_Riwayat As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents text_NIM As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents text_NamaMahasiswa As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents show_waktuTanggal As DateTimePicker
    Friend WithEvents btn_clear As Button
    Friend WithEvents box_kehadiran As ComboBox
    Friend WithEvents box_matkuliah As ComboBox
    Friend WithEvents btn_Search As Button
    Friend WithEvents text_kelas As TextBox
    Friend WithEvents ImageList1 As ImageList

End Class
