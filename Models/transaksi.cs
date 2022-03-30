using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveler.Models
{
    public class transaksi
    {
        [Key]
        public string id_transaksi { get; set; }
        public Pelanggan Pelanggan { get; set; }
        public string dari { get; set; }
        public string ke { get; set; }
        public int jml_orang { get; set; }
        public int harga { get; set; }
        public string type_transaksi { get; set; }
    }
}
