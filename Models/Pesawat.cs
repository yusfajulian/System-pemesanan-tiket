using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveler.Models
{
    public class Pesawat
    {
        [Key]
        public string kode_pesawat { get; set; }
        public string Maskapai { get; set; }
        public string Bandara_asal { get; set; }
        public string Bandara_tujuan { get; set; }
        public DateTime berangkat { get; set; }
        public string image { get; set; }
        public int harga { get; set; }
    }
}
