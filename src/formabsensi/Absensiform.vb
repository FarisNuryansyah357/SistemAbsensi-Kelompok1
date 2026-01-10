Imports MySql.Data.MySqlClient

Public Class dashboard_Absen
    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        Dim nimDicari = text_NIM.Text.Trim

        If String.IsNullOrEmpty(nimDicari) Then
            MessageBox.Show("Silakan masukkan NIM yang ingin dicari.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            text_NamaMahasiswa.Clear()
            text_kelas.Clear()
            Return
        End If

        Dim query = "SELECT nama_mahasiswa, kelas FROM mahasiswa WHERE nim = @nim;"

        Using conn As New MySqlConnection("SERVER=localhost;DATABASE=absensi_mahasiswa;UID=root;PASSWORD=;")
            Try
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nim", nimDicari)

                    Using reader = cmd.ExecuteReader
                        If reader.Read Then
                            text_NamaMahasiswa.Text = reader("nama_mahasiswa").ToString
                            text_kelas.Text = reader("kelas").ToString
                            MessageBox.Show("Data ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            text_NamaMahasiswa.Clear()
                            text_kelas.Clear()
                            MessageBox.Show("NIM tidak ditemukan dalam database.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Gagal terkoneksi ke database: " & ex.Message, "Kesalahan DB", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim nim = text_NIM.Text.Trim
        Dim matkul = box_matkuliah.Text.Trim
        Dim kehadiran = box_kehadiran.Text.Trim
        Dim waktuAbsensi = Date.Now

        If String.IsNullOrEmpty(nim) Or String.IsNullOrEmpty(matkul) Or String.IsNullOrEmpty(kehadiran) Then
            MessageBox.Show("Semua kolom harus diisi sebelum menyimpan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim query = "INSERT INTO kehadiran (nim, mata_kuliah, status_kehadiran, waktu_absensi) 
                           VALUES (@nim, @matkul, @kehadiran, @waktu);"

        Using conn As New MySqlConnection("SERVER=localhost;DATABASE=absensi_mahasiswa;UID=root;PASSWORD=;")
            Try
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nim", nim)
                    cmd.Parameters.AddWithValue("@matkul", matkul)
                    cmd.Parameters.AddWithValue("@kehadiran", kehadiran)
                    cmd.Parameters.AddWithValue("@waktu", waktuAbsensi)

                    Dim rowsAffected = cmd.ExecuteNonQuery

                    If rowsAffected > 0 Then
                        MessageBox.Show("Absensi berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        text_NIM.Clear()
                        text_NamaMahasiswa.Clear()
                        text_kelas.Clear()
                        box_matkuliah.Text = ""
                        box_kehadiran.Text = ""
                    Else
                        MessageBox.Show("Gagal menyimpan absensi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using

            Catch ex As MySqlException
                MessageBox.Show("Kesalahan Database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
        End Using
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        text_NIM.Clear()
        text_NamaMahasiswa.Clear()
        text_kelas.Clear()
        box_matkuliah.Text = ""
        box_kehadiran.Text = ""
        text_NIM.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        Label1.Text = "SISTEM INFORMASI ABSENSI MAHASISWA"
        Label1.Font = New Font("Segoe UI", 24, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(31, 58, 147)
        Label1.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_Catat_Click(sender As Object, e As EventArgs) Handles btn_Catat.Click

    End Sub

    Private Sub btn_Riwayat_Click(sender As Object, e As EventArgs) Handles btn_Riwayat.Click
        Dim formRiwayatBaru As New riwayatabsen()
        formRiwayatBaru.Show()
        Me.Hide()
    End Sub

    Private Sub show_waktuTanggal_ValueChanged(sender As Object, e As EventArgs) Handles show_waktuTanggal.ValueChanged

    End Sub

    Private Sub text_NIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles text_NIM.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btn_Search.PerformClick()
            e.Handled = True
        End If
    End Sub

End Class