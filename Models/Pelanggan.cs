using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveler.Models
{
    public class Pelanggan
    {
        [Key]
        public string nik { get; set; }
        public string nama_pelanggan { get; set; }
        public bool kartu_vaksin { get; set; }
        public string no_telp { get; set; }
        public string email { get; set; }
    }
}
