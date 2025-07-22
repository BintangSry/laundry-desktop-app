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
    public partial class ManajemenUser : UserControl
    {
        public ManajemenUser()
        {
            InitializeComponent();
            LoadUserData();
        }
        private async void LoadUserData()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:8000/api/users");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var users = JsonConvert.DeserializeObject<List<User>>(json);
                    dataGridUser.DataSource = users;
                }
                else
                {
                    MessageBox.Show("Gagal memuat data user");
                }
            }
        }

        private void dataGridUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void dataGridUser_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridUser.Rows[e.RowIndex];

            int id = Convert.ToInt32(row.Cells["Id"].Value);
            string username = row.Cells["Username"].Value?.ToString();
            int noTelp = Convert.ToInt32(row.Cells["NoTelpon"].Value);
            string alamat = row.Cells["Alamat"].Value?.ToString();
            string role = row.Cells["Role"].Value?.ToString();
            string remember_token = row.Cells["RememberToken"].Value?.ToString();
            DateTime created_at = Convert.ToDateTime(row.Cells["CreatedAt"].Value);
            DateTime updated_at = Convert.ToDateTime(row.Cells["UpdatedAt"].Value);

            using (HttpClient client = new HttpClient())
            {
                var data = new
                {
                    username,
                    no_telpon = noTelp,
                    alamat,
                    role,
                    remember_token,
                    created_at, 
                    updated_at
                };

                var json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PutAsync($"http://localhost:8000/api/users/{id}", content);
                    if (response.IsSuccessStatusCode)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        MessageBox.Show("Gagal update data.");
                    }
                }
                catch
                {
                    MessageBox.Show("Terjadi kesalahan saat update.");
                }
            }
        }

        private void tambah_btn_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();

            if (adduser.ShowDialog() == DialogResult.OK)
            {
                LoadUserData(); // refresh dataGridView
            }
        }

        private async void Delete_btn_Click(object sender, EventArgs e)
        {
            if(dataGridUser.SelectedRows.Count == 0)
            {
                MessageBox.Show("Pilih salah satu id untuk dihapus");
                return;
            }

            var confirm = MessageBox.Show("Yakin ingin menghapus user ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            var selectedRow = dataGridUser.SelectedRows[0];
            int userID = Convert.ToInt32(selectedRow.Cells["id"].Value);

            using(HttpClient client = new HttpClient())
            {
                var response = await client.DeleteAsync($"http://localhost:8000/api/users/{userID}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Data berhasil dihapus");
                    LoadUserData();
                }
                else
                {
                    MessageBox.Show("Gagal Menghapus Data");
                }

            }
        }
    }
}
