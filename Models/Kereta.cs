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
        public string dari { get; set; }
        public string ke { get; set; }
        public Jenis_kereta jenis_Kereta { get; set; }
        public Kelas kelas { get; set; }
        public Jam_kereta jam_Kereta { get; set; }
        public int jml_kursi { get; set; }
        public int harga { get; set; }
    }
}
