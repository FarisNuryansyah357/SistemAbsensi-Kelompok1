Imports formabsensi
Imports System.Drawing
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports System.Data


Public Class riwayatabsen

    Private dtRiwayat As New DataTable()

    Private Sub riwayatabsen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Label2.Text = "RIWAYAT ABSENSI MAHASISWA"
        Label2.Font = New Font("Segoe UI", 24, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(31, 58, 147)
        Label2.TextAlign = ContentAlignment.MiddleCenter

        TampilkanDataRiwayat()
    End Sub

    Private Sub btn_catatAbsensi_Click(sender As Object, e As EventArgs) Handles btn_catatAbsensi.Click
        Dim formAbsensiUtama As New formabsensi.dashboard_Absen()

        formAbsensiUtama.Show()
        Me.Close()
    End Sub
    Private Sub TampilkanDataRiwayat()
        Dim query As String = "SELECT
                                k.id,  -- <-- GUNAKAN NAMA KOLOM 'id' DARI TABEL KEHADIRAN
                                m.nim AS NIM,
                                m.nama_mahasiswa AS 'Nama Mahasiswa',
                                m.kelas AS Kelas,
                                k.mata_kuliah AS 'Mata Kuliah',
                                k.status_kehadiran AS 'Status Kehadiran',
                                k.waktu_absensi AS 'Tanggal & Waktu'
                              FROM
                                kehadiran k
                              INNER JOIN
                                mahasiswa m ON k.nim = m.nim
                              ORDER BY
                                k.waktu_absensi DESC;"

        Using conn As New MySqlConnection("SERVER=localhost;DATABASE=absensi_mahasiswa;UID=root;PASSWORD=;")
            Try
                conn.Open()

                Using da As New MySqlDataAdapter(query, conn)
                    dtRiwayat.Clear()
                    da.Fill(dtRiwayat)

                    dgvRiwayat.DataSource = dtRiwayat
                    dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


                    If dgvRiwayat.Columns.Contains("id") Then
                        dgvRiwayat.Columns("id").Visible = False
                    End If

                End Using

            Catch ex As MySqlException
                MessageBox.Show("Gagal memuat data riwayat absensi: " & ex.Message, "Kesalahan Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using

    End Sub

    Private Sub dgvRiwayat_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRiwayat.CellContentClick

    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click


        Dim kataKunci As String = text_NamaMahasiswa.Text.Trim()

        Dim dv As New DataView(dtRiwayat)

        If String.IsNullOrEmpty(kataKunci) Then
            dv.RowFilter = String.Empty
        Else
            dv.RowFilter = String.Format("`Nama Mahasiswa` LIKE '%{0}%' OR NIM LIKE '%{0}%'", kataKunci)
        End If

        dgvRiwayat.DataSource = dv.ToTable()

        If dv.Count = 0 AndAlso Not String.IsNullOrEmpty(kataKunci) Then
            MessageBox.Show("Data dengan Nama atau NIM tersebut tidak ditemukan.", "Pencarian", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btn_delSearch_Click(sender As Object, e As EventArgs) Handles btn_delSearch.Click

        text_NamaMahasiswa.Clear()
        dgvRiwayat.DataSource = dtRiwayat
        dgvRiwayat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        text_NamaMahasiswa.Focus()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub text_NIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_NamaMahasiswa.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btn_Search.PerformClick()
            e.Handled = True
        End If
    End Sub

    Private Sub btn_Hapus_Click(sender As Object, e As EventArgs) Handles btn_hapus.Click, btn_hapus.Click

        If dgvRiwayat.SelectedRows.Count = 0 Then
            MessageBox.Show("Silakan pilih satu baris riwayat absensi untuk dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim dialogResult = MessageBox.Show(
        "Apakah Anda YAKIN ingin menghapus data absensi yang dipilih?",
        "Konfirmasi Penghapusan",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If dialogResult = DialogResult.Yes Then
            Try

                Dim idToDelete = Convert.ToInt32(dgvRiwayat.SelectedRows(0).Cells("id").Value)

                HapusDataDariDatabase(idToDelete)

                TampilkanDataRiwayat()

            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat menghapus data: " & ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub HapusDataDariDatabase(ByVal idKehadiran As Integer)
        Dim query As String = "DELETE FROM kehadiran WHERE id = @ID"

        Using conn As New MySqlConnection("SERVER=localhost;DATABASE=absensi_mahasiswa;UID=root;PASSWORD=;")
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@ID", idKehadiran)

                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Data absensi berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Gagal menghapus data. ID tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As MySqlException
                    Throw New Exception("Kesalahan saat koneksi atau eksekusi database: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class