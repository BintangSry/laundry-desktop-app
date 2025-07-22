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
    public partial class AddLayanan : Form
    {
        public AddLayanan()
        {
            InitializeComponent();
        }

        private async void tambah_btn_Click(object sender, EventArgs e)
        {
            string nama_layanan = nama_layanantxt.Text;
            int harga = Convert.ToInt32(hargatxt.Text);
            string jenis_unit = cmJenis.SelectedItem.ToString();

            using(HttpClient client = new HttpClient())
            {
                var data = new
                {
                    nama_layanan,
                    harga,
                    jenis_unit
                };

                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync("http://localhost:8000/api/layanan", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Layanan Berhasil ditambahkan");
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Gagal Menambahkan Data");
                    }
                }
                catch
                {
                    MessageBox.Show("Terjadi Kesalah teknis saat terhubung");
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
