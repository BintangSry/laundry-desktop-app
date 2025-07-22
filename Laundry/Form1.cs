using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace Laundry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private async void login_btn_Click(object sender, EventArgs e)
        {
            login_btn.Enabled = false;
            string username = usernametxt.Text.Trim();
            string password = passwordtxt.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong");
                login_btn.Enabled = true;
                return;
            }

            var httpClient = new HttpClient();
            var loginData = new
            {
                username = username,
                password = password
            };

            string json = JsonConvert.SerializeObject(loginData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                HttpResponseMessage response = await httpClient.PostAsync("http://localhost:8000/api/login", content);
                string result = await response.Content.ReadAsStringAsync();

                dynamic obj = JsonConvert.DeserializeObject(result);

                if (obj.success == true)
                {
                    this.Hide();
                    var dashboard = new Dashboard();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Login gagal: " + obj.message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error: " + ex.Message);
            }
            finally
            {
                login_btn.Enabled = true;
            }
        }
    }
}
