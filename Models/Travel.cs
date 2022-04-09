using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveler.Models
{
    public class Travel
    {
        [Key]
        public string kode_travel { get; set; }
        public string nama_travel { get; set; }
        public string kota_asal { get; set; }
        public string kota_tujuan { get; set; }
        public DateTime berangkat { get; set; }
        public string image { get; set; }
        public int harga { get; set; }

    }
}
