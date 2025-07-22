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
    public partial class AddPembayaran : Form
    {
        public AddPembayaran()
        {
            InitializeComponent();
        }

        private async void tambah_btn_Click(object sender, EventArgs e)
        {
            int id_pesanan = Convert.ToInt32(id_pesanantxt.Text);
            string tanggal_bayar = tanggal_bayartxt.Value.ToString("yyyy-MM-dd");
            string metode_pembayaran = cmMetode.SelectedItem.ToString();
            int jumlah_bayar = Convert.ToInt32(jumlah_bayartxt.Text);
            string status = cmStatus.SelectedItem.ToString();

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
                    var response = await client.PostAsync("http://localhost:8000/api/pembayaran", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Data berhasil ditambahkan");
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Data gagal ditambahkan");
                    }
                }
                catch
                {
                    MessageBox.Show("Gagal Terhubung");
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
