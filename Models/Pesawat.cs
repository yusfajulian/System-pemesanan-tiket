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
        public string dari { get; set; }
        public string ke { get; set; }
        public Maskapai Maskapai { get; set; }
        public Kelas kelas { get; set; }
        public Jam_pesawat jam_Pesawat { get; set; }
        public int jml_kursi {get;set;}
        public int harga { get; set; }
    }
}
