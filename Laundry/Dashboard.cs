using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void detail_btn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            DetailPesanan detail = new DetailPesanan();
            detail.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(detail);
        }

        private void user_btn_Click(object sender, EventArgs e)
        {
            // Bersihkan panel terlebih dahulu
            mainPanel.Controls.Clear();

            // Buat instance dari UserControl
            ManajemenUser manajemenUser = new ManajemenUser();
            manajemenUser.Dock = DockStyle.Fill; // supaya full panel

            // Tambahkan ke panel
            mainPanel.Controls.Add(manajemenUser);
        }

        private void pesanan_btn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            Pesanan pesanan = new Pesanan();
            pesanan.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(pesanan);
        }

        private void layanan_btn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            Layanan layanan = new Layanan();
            layanan.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(layanan);

        }

        private void pembayaran_btn_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            Pembayaran pembayaran = new Pembayaran();
            pembayaran.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(pembayaran);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
