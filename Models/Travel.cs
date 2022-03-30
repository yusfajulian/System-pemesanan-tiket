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
        public string dari { get; set; }
        public string ke { get; set; }
        public Jenis_travel jenis_Travel { get; set; }
        public Jam_kereta jam_Kereta { get; set; }
        public int jml_kursi { get; set; }
        public int harga {get;set;}
    }
}
