<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class riwayatabsen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(riwayatabsen))
        Panel2 = New Panel()
        btn_hapus = New Button()
        btn_catatAbsensi = New Button()
        Button3 = New Button()
        Label2 = New Label()
        TextBox1 = New TextBox()
        btn_delSearch = New Button()
        btn_Search = New Button()
        text_NamaMahasiswa = New TextBox()
        dgvRiwayat = New DataGridView()
        DateTimePicker1 = New DateTimePicker()
        TableLayoutPanel2 = New TableLayoutPanel()
        Panel2.SuspendLayout()
        CType(dgvRiwayat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel2.Controls.Add(btn_hapus)
        Panel2.Controls.Add(btn_catatAbsensi)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(btn_delSearch)
        Panel2.Controls.Add(btn_Search)
        Panel2.Controls.Add(text_NamaMahasiswa)
        Panel2.Controls.Add(dgvRiwayat)
        Panel2.Controls.Add(DateTimePicker1)
        Panel2.Controls.Add(TableLayoutPanel2)
        Panel2.Location = New Point(2, 0)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1182, 608)
        Panel2.TabIndex = 51
        ' 
        ' btn_hapus
        ' 
        btn_hapus.BackgroundImage = CType(resources.GetObject("btn_hapus.BackgroundImage"), Image)
        btn_hapus.BackgroundImageLayout = ImageLayout.Stretch
        btn_hapus.Location = New Point(634, 182)
        btn_hapus.Margin = New Padding(2)
        btn_hapus.Name = "btn_hapus"
        btn_hapus.Size = New Size(33, 29)
        btn_hapus.TabIndex = 58
        btn_hapus.UseVisualStyleBackColor = True
        ' 
        ' btn_catatAbsensi
        ' 
        btn_catatAbsensi.BackColor = Color.CadetBlue
        btn_catatAbsensi.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_catatAbsensi.Location = New Point(12, 118)
        btn_catatAbsensi.Margin = New Padding(2)
        btn_catatAbsensi.Name = "btn_catatAbsensi"
        btn_catatAbsensi.Size = New Size(222, 32)
        btn_catatAbsensi.TabIndex = 49
        btn_catatAbsensi.Text = "Catat Absensi"
        btn_catatAbsensi.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaption
        Button3.BackgroundImageLayout = ImageLayout.Center
        Button3.FlatAppearance.BorderColor = Color.Black
        Button3.FlatAppearance.BorderSize = 2
        Button3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(254, 118)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(222, 32)
        Button3.TabIndex = 50
        Button3.Text = "Riwayat Absensi"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(409, 39)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(196, 45)
        Label2.TabIndex = 48
        Label2.Text = "Pakai Kode"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(12, 182)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(216, 33)
        TextBox1.TabIndex = 57
        TextBox1.Text = "Cari Mahasiswa"
        ' 
        ' btn_delSearch
        ' 
        btn_delSearch.BackgroundImage = CType(resources.GetObject("btn_delSearch.BackgroundImage"), Image)
        btn_delSearch.BackgroundImageLayout = ImageLayout.Stretch
        btn_delSearch.Location = New Point(559, 182)
        btn_delSearch.Margin = New Padding(2)
        btn_delSearch.Name = "btn_delSearch"
        btn_delSearch.Size = New Size(35, 29)
        btn_delSearch.TabIndex = 56
        btn_delSearch.UseVisualStyleBackColor = True
        ' 
        ' btn_Search
        ' 
        btn_Search.BackgroundImage = My.Resources.Resources.resize
        btn_Search.BackgroundImageLayout = ImageLayout.Stretch
        btn_Search.Location = New Point(523, 182)
        btn_Search.Margin = New Padding(2)
        btn_Search.Name = "btn_Search"
        btn_Search.Size = New Size(32, 29)
        btn_Search.TabIndex = 55
        btn_Search.UseVisualStyleBackColor = True
        ' 
        ' text_NamaMahasiswa
        ' 
        text_NamaMahasiswa.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        text_NamaMahasiswa.Location = New Point(254, 182)
        text_NamaMahasiswa.Name = "text_NamaMahasiswa"
        text_NamaMahasiswa.Size = New Size(252, 33)
        text_NamaMahasiswa.TabIndex = 54
        ' 
        ' dgvRiwayat
        ' 
        dgvRiwayat.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        dgvRiwayat.BackgroundColor = SystemColors.ActiveCaption
        dgvRiwayat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRiwayat.Location = New Point(12, 231)
        dgvRiwayat.Margin = New Padding(2)
        dgvRiwayat.Name = "dgvRiwayat"
        dgvRiwayat.RowHeadersWidth = 62
        dgvRiwayat.ScrollBars = ScrollBars.None
        dgvRiwayat.Size = New Size(1160, 346)
        dgvRiwayat.TabIndex = 53
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Anchor = AnchorStyles.Right
        DateTimePicker1.Enabled = False
        DateTimePicker1.Location = New Point(938, 182)
        DateTimePicker1.Margin = New Padding(2)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(228, 23)
        DateTimePicker1.TabIndex = 51
        ' 
        ' TableLayoutPanel2
        ' 
        TableLayoutPanel2.ColumnCount = 2
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Location = New Point(828, 286)
        TableLayoutPanel2.Margin = New Padding(2)
        TableLayoutPanel2.Name = "TableLayoutPanel2"
        TableLayoutPanel2.RowCount = 2
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel2.Size = New Size(5, 4)
        TableLayoutPanel2.TabIndex = 1
        ' 
        ' riwayatabsen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1189, 630)
        Controls.Add(Panel2)
        Name = "riwayatabsen"
        Text = "riwayatabsen"
        WindowState = FormWindowState.Maximized
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvRiwayat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvRiwayat As DataGridView
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button3 As Button
    Friend WithEvents btn_catatAbsensi As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents text_NamaMahasiswa As TextBox
    Friend WithEvents btn_Search As Button
    Friend WithEvents btn_delSearch As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_hapus As Button
End Class
