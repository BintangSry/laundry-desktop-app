using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry
{
    public class PembayanClass
    {
        public int id {  get; set; }
        public int id_pesanan {  get; set; }
        public DateTime tanggal_bayar { get; set;}
        public string metode_pembayaran { get; set; }
        public int jumlah_bayar { get; set;}
        public string status { get; set; }
    }
}
