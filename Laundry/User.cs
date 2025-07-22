using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Laundry
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("no_telpon")]
        public long NoTelpon { get; set; }

        [JsonProperty("alamat")]
        public string Alamat { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("remember_token")]
        public string RememberToken { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

    }
}
