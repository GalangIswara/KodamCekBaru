using KodamCekBaru.Models;
using KodamCekBaru.Data;
using System.Data;

namespace KodamCekBaru.Controllers
{
    public class KhodamController
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public KhodamModel DapatkanKhodamAcak()
        {
            DataRow row = dbHelper.GetRandomKodam();

            if (row == null) return null;

            return new KhodamModel
            {
                NamaKhodam = row["nama_kodam"].ToString(),
                Elemen = row["elemen"].ToString(),
                TingkatEnergi = row["tingkat_energi"].ToString(),
                Deskripsi = row["deskripsi"].ToString()
            };
        }

        public void SimpanRiwayat(string namaUser, string namaKhodam)
        {
            dbHelper.SaveUserCheck(namaUser, namaKhodam);
        }

        public DataTable AmbilRiwayat()
        {
            return dbHelper.LoadUserCheckData();
        }

        public void HapusRiwayat()
        {
            dbHelper.ClearUserCheck();
        }
    }
}