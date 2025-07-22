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
    public partial class Pesanan : UserControl
    {
        public Pesanan()
        {
            InitializeComponent();
            LoadPesananData();
        }

        private async void LoadPesananData()
        {
            using(HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:8000/api/pesanan");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var pesanan = JsonConvert.DeserializeObject<List<PesananClass>>(json);
                    dataGridPesanan.DataSource = pesanan;
                }
                else
                {
                    MessageBox.Show("Gagal Memuat data");
                }
            }
        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {
            AddPesanan pesanan = new AddPesanan();
            
            if(pesanan.ShowDialog() == DialogResult.OK)
            {
                LoadPesananData();
            }
        }

        private void actionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Delete_btn_Click(object sender, EventArgs e)
        {
            if(dataGridPesanan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih salah satu pesanan yang ingin dihapus");
                return;
            }

            var confirm = MessageBox.Show("Apakah anda yakin ingin menghapus pesanan ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                var selecteditem = dataGridPesanan.SelectedRows[0];
                int id = Convert.ToInt32(selecteditem.Cells["id"].Value);

                using(HttpClient client = new HttpClient())
                {
                    var response = await client.DeleteAsync($"http://localhost:8000/api/pesanan/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Pesanan Berhasil dihapus");
                        LoadPesananData();
                    }
                    else
                    {
                        MessageBox.Show("Gagal Menghapus pesanan");
                    }
                }
            }
        }

        private void dataGridPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void selesai_btn_Click(object sender, EventArgs e)
        {
            if(dataGridPesanan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih salah satu kolom untuk mengkonfirmasi");
                return;
            }

            var confirm = MessageBox.Show("Konfirmasi pesanan ini menjadi selesai?", "konfirmasi Selesai", MessageBoxButtons.YesNo);

            if(confirm == DialogResult.Yes)
            {
                var selecteditem = dataGridPesanan.SelectedRows[0];
                int id = Convert.ToInt32(selecteditem.Cells["id"].Value);
                string status = selecteditem.Cells["status"].Value.ToString();

                if(status == "proses")
                {
                    using(HttpClient client = new HttpClient())
                    {
                        string tanggal_selesai = DateTime.Now.ToString("yyyy-MM-dd");
                        var data = new
                        {
                            tanggal_selesai,
                            status = "selesai"
                        };

                        var json = JsonConvert.SerializeObject(data);
                        var content = new StringContent(json, Encoding.UTF8, "application/json");

                        try
                        {
                            var response = await client.PutAsync($"http://localhost:8000/api/pesanan/{id}", content);

                            if (response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Pesanan berhasil dikonfirmasi selesai");
                                LoadPesananData();

                            }
                        }
                        catch
                        {
                            MessageBox.Show("Terjadi Kesalahan saat update");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Pesanan tersebut sudah dikonfirmasi sebelumnya");
                }
            }
        }
    }
}
