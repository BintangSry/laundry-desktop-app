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
    public partial class Layanan : UserControl
    {
        public Layanan()
        {
            InitializeComponent();
            LoadLayanan();
        }

        public async void LoadLayanan()
        {
            using(HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync("http://localhost:8000/api/layanan");

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        var layanan = JsonConvert.DeserializeObject<List<LayananClass>>(json);
                        dataGridLayanan.DataSource = layanan;
                    }
                    else
                    {
                        MessageBox.Show("Data gagal dimuat");
                    }
                }
                catch
                {
                    MessageBox.Show("Gagal Memuat data");
                }
            }
        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {
            AddLayanan addlayanan = new AddLayanan();

            if(addlayanan.ShowDialog() == DialogResult.OK)
            {
                LoadLayanan();
            }
        }

        private async void Delete_btn_Click(object sender, EventArgs e)
        {
            if(dataGridLayanan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih salah satu layanan yang ingin dihapus");
                return;
            }

            var selecteditem = dataGridLayanan.SelectedRows[0];
            int id = Convert.ToInt32(selecteditem.Cells["id"].Value);

            var confirm = MessageBox.Show($"Apakah anda yakin ingin menghapus layanan dengan id: {id}", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
            
            if (confirm == DialogResult.Yes)
            {
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        var response = await client.DeleteAsync($"http://localhost:8000/api/layanan/{id}");
                        if (response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Layanan Berhasil dihapus");
                            LoadLayanan();
                        }
                        else
                        {
                            MessageBox.Show("Gagal Menghapus Data");
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Terjadi Kesalahan");
                    }
                }
            }
        }

        private async void dataGridLayanan_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridLayanan.Rows[e.RowIndex];

            int id = Convert.ToInt32(row.Cells["id"].Value);
            string nama_layanan = row.Cells["nama_layanan"].Value.ToString();
            int harga = Convert.ToInt32(row.Cells["harga"].Value);
            string jenis_unit = row.Cells["jenis_unit"].Value.ToString();

            using(HttpClient client = new HttpClient())
            {
                var data = new
                {
                    nama_layanan,
                    harga,
                    jenis_unit,
                };

                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PutAsync($"http://localhost:8000/api/layanan/{id}", content);

                    if (response.IsSuccessStatusCode)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengupdate data");
                    }
                }
                catch
                {
                    MessageBox.Show("Gagal terhubung ke API");
                }
            }


        }
    }
}
