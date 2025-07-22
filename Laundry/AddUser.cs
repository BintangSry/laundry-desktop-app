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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void batal_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void tambah_btn_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = usernametxt.Text;
            int no_telpon = Convert.ToInt32(noTelpontxt.Text);
            string alamat = alamattxt.Text;
            string role = cmRole.SelectedItem.ToString();

            using(HttpClient client = new HttpClient())
            {
                var data = new
                {
                    username,
                    password,
                    no_telpon,
                    alamat,
                    role
                };

                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8,  "application/json");

                var response = await client.PostAsync("http://localhost:8000/api/users", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("User Berhasil ditambahkan");
                    this.DialogResult= DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal Menambahkan User");
                }
            }
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void noTelpontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void alamattxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
