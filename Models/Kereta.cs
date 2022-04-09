using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveler.Models
{
    public class Kereta
    {
        [Key]
        public string kode_kereta { get; set; }
        public string nama_kereta { get; set; }
        public string stasiun_asal { get; set; }
        public string stasiun_tujuan { get; set; }
        public DateTime berangkat { get; set; }
        public string image { get; set; }
        public int harga { get; set; }
    }
}
