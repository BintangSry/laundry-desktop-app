using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry
{
    public class PesananClass
    {
        public int id { get; set; }
        public int id_user {  get; set; }
        public DateTime tanggal_masuk { get; set; }
        public DateTime? tanggal_selesai { get; set; }
        public string status { get; set; }
        public int total_harga {  get; set; }
    }
}
