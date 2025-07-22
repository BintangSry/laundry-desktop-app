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
    public partial class DetailPesanan : UserControl
    {
        public DetailPesanan()
        {
            InitializeComponent();
            LoadDetailPesanan();
        }

        public async void LoadDetailPesanan()
        {
            using(HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:8000/api/detail");

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var detail = JsonConvert.DeserializeObject<List<DetailPesananClass>>(json);
                    dataGridDetail.DataSource = detail;
                }
                else
                {
                    MessageBox.Show("Gagal memuat data");
                }
            }
        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {
            AddDetail adddetail = new AddDetail();

            if(adddetail.ShowDialog() == DialogResult.OK)
            {
                LoadDetailPesanan();
            }
        }

        private async void Delete_btn_Click(object sender, EventArgs e)
        {
            if(dataGridDetail.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih salah satu yang ingin dihapus");
                return;
            }

            var selecteditem = dataGridDetail.SelectedRows[0];
            int id = Convert.ToInt32(selecteditem.Cells["id"].Value);

            var confirm = MessageBox.Show($"Apakah anda ingin menghapus detail nomor: {id}", "Konfirmasi Hapus", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                using(HttpClient client = new HttpClient())
                {
                    var response = await client.DeleteAsync($"http://localhost:8000/api/detail/{id}");

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Data Berhasil dihapus");
                        LoadDetailPesanan();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus data");
                    }
                }

            }
            
        }

        private async void dataGridDetail_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridDetail.Rows[e.RowIndex];

            int id = Convert.ToInt32(row.Cells["id"].Value);
            int id_pesanan = Convert.ToInt32(row.Cells["id_pesanan"].Value);
            int id_layanan = Convert.ToInt32(row.Cells["id_layanan"].Value);
            int jumlah = Convert.ToInt32(row.Cells["jumlah"].Value);
            int subtotal = Convert.ToInt32(row.Cells["subtotal"].Value);

            using(HttpClient client = new HttpClient())
            {
                var data = new
                {
                    id_pesanan,
                    id_layanan,
                    jumlah,
                    subtotal
                };

                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PutAsync($"http://localhost:8000/api/detail/{id}", content);

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
                    MessageBox.Show("Ada kesalahan Teknus");
                }
                
            }
        }

        private void actionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
