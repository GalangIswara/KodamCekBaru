using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodamCekBaru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Fungsi untuk menghubungkan ke database SQLite
        public SQLiteConnection ConnectToDatabase()
        {
            string connectionString = "Data Source=kodam.db;Version=3;";
            SQLiteConnection conn = new SQLiteConnection(connectionString);

            try
            {
                conn.Open();
                MessageBox.Show("Koneksi berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal menghubungkan ke database: {ex.Message}");
            }

            return conn;
        }

        // Fungsi untuk mendapatkan data Kodam secara acak
        public void GetKodamData(SQLiteConnection conn)
        {
            string query = "SELECT * FROM kodam ORDER BY RANDOM() LIMIT 1";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string namaKodam = reader["nama_kodam"].ToString();
                string elemen = reader["elemen"].ToString();
                string tingkatEnergi = reader["tingkat_energi"].ToString();
                string deskripsi = reader["deskripsi"].ToString();

                MessageBox.Show($"Khodam: {namaKodam}\nElemen: {elemen}\nEnergi: {tingkatEnergi}\nDeskripsi: {deskripsi}");

                // Simpan ke database
                SaveUserCheck(conn, namaKodam);
            }
            else
            {
                MessageBox.Show("Tidak ada data Khodam ditemukan!");
            }

            reader.Close();
        }

        // Fungsi untuk menyimpan hasil cek ke database
        public void SaveUserCheck(SQLiteConnection conn, string namaKodam)
        {
            try
            {
                string getIdQuery = "SELECT id FROM kodam WHERE nama_kodam = @namaKodam";
                SQLiteCommand getIdCmd = new SQLiteCommand(getIdQuery, conn);
                getIdCmd.Parameters.AddWithValue("@namaKodam", namaKodam);

                object result = getIdCmd.ExecuteScalar();

                if (result != null)
                {
                    int hasilKhodamId = Convert.ToInt32(result);

                    string insertQuery = "INSERT INTO UserCheck (nama_user, waktu_cek, hasil_khodam_id) VALUES (@nama_user, @waktu_cek, @hasil_khodam_id)";
                    SQLiteCommand insertCmd = new SQLiteCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@nama_user", txtNamaUser.Text.Trim() == "" ? "Guest" : txtNamaUser.Text.Trim());
                    insertCmd.Parameters.AddWithValue("@waktu_cek", DateTime.Now);
                    insertCmd.Parameters.AddWithValue("@hasil_khodam_id", hasilKhodamId);

                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Hasil cek Khodam berhasil disimpan ke database.");
                    LoadUserCheckData(conn);
                }
                else
                {
                    MessageBox.Show("Gagal menemukan ID Khodam untuk disimpan.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyimpan: {ex.Message}");
            }
        }

        // Fungsi untuk load data ke DataGridView
        public void LoadUserCheckData(SQLiteConnection conn)
        {
            string query = @"
        SELECT uc.id, uc.nama_user, uc.waktu_cek, k.nama_kodam, k.elemen, k.tingkat_energi
        FROM UserCheck uc
        JOIN kodam k ON uc.hasil_khodam_id = k.id
        ORDER BY uc.waktu_cek DESC";

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridViewRiwayat.DataSource = dt;
        }

        private void btnCekKhodam_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = ConnectToDatabase();
            GetKodamData(conn);
            LoadUserCheckData(conn);
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteConnection conn = ConnectToDatabase();
            LoadUserCheckData(conn);
            conn.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            SQLiteConnection conn = ConnectToDatabase();
            LoadUserCheckData(conn);
            conn.Close();
        }

        private void btnClearRiwayat_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus semua riwayat?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                SQLiteConnection conn = ConnectToDatabase();
                string query = "DELETE FROM UserCheck";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Semua riwayat berhasil dihapus.");

                // refresh data
                SQLiteConnection conn2 = ConnectToDatabase();
                LoadUserCheckData(conn2);
                conn2.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            SQLiteConnection conn = ConnectToDatabase();
            LoadUserCheckData(conn);
            conn.Close();
        }
    }
    
}