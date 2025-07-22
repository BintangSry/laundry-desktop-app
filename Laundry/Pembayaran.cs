using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class Pembayaran : UserControl
    {
        public Pembayaran()
        {
            InitializeComponent();
            LoadPembayaran();
        }

        public async void LoadPembayaran()
        {
            using(HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync("http://localhost:8000/api/pembayaran");

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var pembayaran = JsonConvert.DeserializeObject<List<PembayanClass>>(json);
                        dataGridPembayaran.DataSource = pembayaran;
                    }
                    else
                    {
                        MessageBox.Show("Gagal Memuat data");
                    }
                }
                catch
                {
                    MessageBox.Show("Gagal Terhubung");
                }
            }
        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {
            AddPembayaran addpembayaran = new AddPembayaran();

            if(addpembayaran.ShowDialog() == DialogResult.OK)
            {
                LoadPembayaran();
            }
        }

        private async void Delete_btn_Click(object sender, EventArgs e)
        {
            if(dataGridPembayaran.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih salah satu data yang ingin dihapus");
                return;
            }

            var selected = dataGridPembayaran.SelectedRows[0];
            int id = Convert.ToInt32(selected.Cells["id"].Value);

            var confirm = MessageBox.Show($"Anda Yakin ingin menghapus pembayaran dengan id {id}", "Konfirmasi Hapus", MessageBoxButtons.YesNo);

            if(confirm == DialogResult.Yes)
            {
                using(HttpClient client = new HttpClient())
                {
                    try
                    {
                        var response = await client.DeleteAsync($"http://localhost:8000/api/pembayaran/{id}");

                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Data berhasil dihapus");
                            LoadPembayaran();
                        }
                        else
                        {
                            MessageBox.Show("Data gagal dihapus");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Gagal terhubung");
                    }
                }
            }
        }

        private async void dataGridPembayaran_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridPembayaran.Rows[e.RowIndex];

            int id = Convert.ToInt32(row.Cells["id"].Value);
            int id_pesanan = Convert.ToInt32(row.Cells["id_pesanan"].Value);
            string tanggal_bayar = Convert.ToDateTime(row.Cells["tanggal_bayar"].Value).ToString("yyyy-MM-dd");
            string metode_pembayaran = row.Cells["metode_pembayaran"].Value.ToString();
            int jumlah_bayar = Convert.ToInt32(row.Cells["jumlah_bayar"].Value);
            string status = row.Cells["status"].Value.ToString();

            using(HttpClient client = new HttpClient())
            {
                var data = new
                {
                    id_pesanan,
                    tanggal_bayar,
                    metode_pembayaran,
                    jumlah_bayar,
                    status
                };

                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PutAsync($"http://localhost:8000/api/pembayaran/{id}", content);

                    if (response.IsSuccessStatusCode)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        MessageBox.Show("Gagal update data");
                    }
                }
                catch
                {
                    MessageBox.Show("Gagal Terhubung");
                }
            }
        }
    }
}
