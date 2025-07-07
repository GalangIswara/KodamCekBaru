using System;
using System.Data;
using System.Data.SQLite;

namespace KodamCekBaru
{
    public class DatabaseHelper
    {
        private string connectionString = "Data Source=kodam.db;Version=3;";
        public SQLiteConnection Connect()
        {
            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            return conn;
        }

        public DataTable LoadUserCheckData()
        {
            using (var conn = Connect())
            {
                string query = @"
                SELECT uc.id, uc.nama_user, uc.waktu_cek, k.nama_kodam, k.elemen, k.tingkat_energi
                FROM UserCheck uc
                JOIN kodam k ON uc.hasil_khodam_id = k.id
                ORDER BY uc.waktu_cek DESC";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public void SaveUserCheck(string namaUser, string namaKodam)
        {
            using (var conn = Connect())
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
                    insertCmd.Parameters.AddWithValue("@nama_user", namaUser);
                    insertCmd.Parameters.AddWithValue("@waktu_cek", DateTime.Now);
                    insertCmd.Parameters.AddWithValue("@hasil_khodam_id", hasilKhodamId);
                    insertCmd.ExecuteNonQuery();
                }
            }
        }

        public DataRow GetRandomKodam()
        {
            using (var conn = Connect())
            {
                string query = "SELECT * FROM kodam ORDER BY RANDOM() LIMIT 1";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt.Rows.Count > 0 ? dt.Rows[0] : null;
            }
        }

        public void ClearUserCheck()
        {
            using (var conn = Connect())
            {
                string query = "DELETE FROM UserCheck";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
