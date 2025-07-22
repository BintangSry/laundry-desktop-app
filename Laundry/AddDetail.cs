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
    public partial class AddDetail : Form
    {
        public AddDetail()
        {
            InitializeComponent();
        }

        private async void tambah_btn_Click(object sender, EventArgs e)
        {
            int id_pesanan = Convert.ToInt32(id_pesanantxt.Text);
            int id_layanan = Convert.ToInt32(id_layanantxt.Text);
            int jumlah = Convert.ToInt32(jumlahtxt.Text);
            int subtotal = Convert.ToInt32(subtotaltxt.Text);

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

                var response = await client.PostAsync("http://localhost:8000/api/detail", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Detail Pesanan berhasil ditambahkan");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Gagal memasukan data");
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
