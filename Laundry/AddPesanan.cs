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
    public partial class AddPesanan : Form
    {
        public AddPesanan()
        {
            InitializeComponent();
        }

        private async void tambah_btn_Click(object sender, EventArgs e)
        {
            int id_user = Convert.ToInt32(idusertxt.Text);
            string tanggal_masuk = DateTime.Now.ToString("yyyy-MM-dd");
            int total_hargatxt = Convert.ToInt32(total_harga.Text);

            using(HttpClient client  = new HttpClient())
            {
                var data = new
                {
                    id_user,
                    tanggal_masuk,
                    status = "proses",
                    total_harga = total_hargatxt
                };

                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("http://localhost:8000/api/pesanan", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Pesanan Berhasil ditambahkan");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal Menambahkan data");
                }
            }

        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
