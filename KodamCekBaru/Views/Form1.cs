using KodamCekBaru.Controllers;
using System;
using System.Windows.Forms;

namespace KodamCekBaru.Views
{
    public partial class Form1 : Form
    {
        private readonly KhodamController controller = new KhodamController();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewRiwayat.DataSource = controller.AmbilRiwayat();
        }

        private void btnCekKhodam_Click(object sender, EventArgs e)
        {
            var khodam = controller.DapatkanKhodamAcak();

            if (khodam != null)
            {
                MessageBox.Show($"Khodam: {khodam.NamaKhodam}\nElemen: {khodam.Elemen}\nEnergi: {khodam.TingkatEnergi}\nDeskripsi: {khodam.Deskripsi}");

                string namaUser = string.IsNullOrWhiteSpace(txtNamaUser.Text) ? "Guest" : txtNamaUser.Text.Trim();
                controller.SimpanRiwayat(namaUser, khodam.NamaKhodam);

                dataGridViewRiwayat.DataSource = controller.AmbilRiwayat();
            }
            else
            {
                MessageBox.Show("Tidak ada data Khodam ditemukan!");
            }
        }

        private void btnClearRiwayat_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus semua riwayat?", "Konfirmasi", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                controller.HapusRiwayat();
                MessageBox.Show("Semua riwayat berhasil dihapus.");
                dataGridViewRiwayat.DataSource = controller.AmbilRiwayat();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewRiwayat.DataSource = controller.AmbilRiwayat();
        }
    }
}